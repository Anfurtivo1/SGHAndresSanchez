using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void medicosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.medicosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);
            MessageBox.Show("Se ha actualizado el paciente");

        }

        private void GestionMedicos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet.medicos' Puede moverla o quitarla según sea necesario.
            this.medicosTableAdapter.Fill(this.hospitalDataSet.medicos);
            cargarComboEspecialidad();

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdExaminar = new OpenFileDialog();
            //Suponemos que ofdExaminar es un OpenFileDialog incorporado al formuylario
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
                catch(Exception)
                {
                    MessageBox.Show("No se ha podido eliminar el medico, asegurate de que no tiene ninguna cita asignada");
                }
                                
                medicosTableAdapter.Fill(db.medicos);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha añadido el medico");
        }

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
    }
}
