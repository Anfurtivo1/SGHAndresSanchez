using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGHAndresSanchez
{
    public partial class GestionMedicos : Form
    {
        public GestionMedicos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Cada vez que le damos al botón de guardar, nos muestra un mensaje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void medicosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.medicosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);
            MessageBox.Show("Se ha actualizado el medico");

        }
        /// <summary>
        /// Acciones que se ejecutan al cargar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GestionMedicos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet.medicos' Puede moverla o quitarla según sea necesario.
            this.medicosTableAdapter.Fill(this.hospitalDataSet.medicos);
            cargarComboEspecialidad();

        }
        /// <summary>
        /// Cada vez que pulsamos en el botón de foto, nos mostrará un openfiledialog para seleccionar la foto que queramos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdExaminar = new OpenFileDialog();
            //Suponemos que ofdExaminar es un OpenFileDialog incorporado al formulario
            ofdExaminar.Filter = "image files|*.jpg;*.png;*.gif;*.ico;.*;";

            DialogResult dres = ofdExaminar.ShowDialog();

            if (dres == DialogResult.Abort)
                return;
            if (dres == DialogResult.Cancel)
                return;

            //para guardar la ruta al fichero con la imagen en un TextBox (por si se quiere mostrar)
            //txtRutaFichero.Text = ofdExaminar.FileName;

            //Se muestra la imagen en el PictureBox directamente de la ruta devuelta por el OpenFileDialog
            fotoPictureBox.Image = Image.FromFile(ofdExaminar.FileName);
        }
        /// <summary>
        /// Cada vez que pulsemos en el bóton de eliminar se mostrara un mensaje de confirmación 
        /// </summary>
        /// <exception cref="">Es posible que el medico que se intenta eliminar tenga citas pendientes y no se podrá eliminar</exception>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            hospitalDataSet db = new hospitalDataSet();
            hospitalDataSetTableAdapters.pacientesTableAdapter pacientesTableAdapter = new hospitalDataSetTableAdapters.pacientesTableAdapter();

            int regs;
            DialogResult resp = new DialogResult();
            resp = MessageBox.Show("Seguro que quieres eliminar este medico?", "Eliminar medico", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                try
                {
                    regs = this.medicosTableAdapter.Delete(int.Parse(this.idmedicoLabel1.Text));
                    
                    if (regs > 0)
                    {
                        MessageBox.Show("Medico eliminado", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch(MySql.Data.MySqlClient.MySqlException)
                {
                    MessageBox.Show("No se ha podido eliminar el medico, asegurate de que no tiene ninguna cita asignada");
                }catch(Exception ex)
                {
                    MessageBox.Show("Error al insertar: "+ex.Message);
                }
                                
                medicosTableAdapter.Fill(db.medicos);
            }
        }
        /// <summary>
        /// Cada que queramos añadir un nuevo medico se nos deshabilitaran los demas botones hasta que pulsemos en guardar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;
            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            this.idmedicoLabel1.Text = "";
        }
        /// <summary>
        /// Metodo que carga el combo de las especialidades
        /// </summary>
        private void cargarComboEspecialidad()
        {
            hospitalDataSet db = new hospitalDataSet();
            hospitalDataSetTableAdapters.especialidadesTableAdapter medicosTableAdapter = new hospitalDataSetTableAdapters.especialidadesTableAdapter();
            medicosTableAdapter.FillByEspecialidad(db.especialidades);

            for (int i = 0; i < db.especialidades.Count; i++)
            {
                especialidadComboBox.Items.Add(db.especialidades[i].especialidad);

            }
        }
        /// <summary>
        /// Metodo que inserta en la base de datos el nuevo medico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void medicosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            var foto = imageToByteArray(fotoPictureBox.Image);
            try
            {
                this.medicosTableAdapter.Insert(this.nombreTextBox.Text, this.apellidosTextBox.Text, this.movilTextBox.Text, this.especialidadComboBox.Text, foto);
                MessageBox.Show("Se ha insertado el medico");
            }
            catch
            {
                MessageBox.Show("No se ha insertado el medico");
            }
            

        }
        /// <summary>
        /// Metodo necesario para transformar un pictureBox en un array de bytes
        /// </summary>
        /// <param name="imageIn"></param>
        /// <returns>Una imagen en un array de bytes</returns>
        private byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }


    }
}
