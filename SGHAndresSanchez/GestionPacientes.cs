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
    public partial class GestionPacientes : Form
    {
        public GestionPacientes()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Cada vez que pulsemos en el botón para guardar el paciente, nos mostrará un mensaje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pacientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);
            MessageBox.Show("Se ha actualizado el paciente");

        }
        /// <summary>
        /// Acciones que se realizan al cargar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GestionPacientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet.pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.hospitalDataSet.pacientes);

        }
        /// <summary>
        /// Cada vez que queramos eliminar un paciente, primero nos preguntara si de verdad queremos eliminarlo, si pulsamos si lo elimina, si no no
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            int regs;
            hospitalDataSet db = new hospitalDataSet();
            hospitalDataSetTableAdapters.pacientesTableAdapter pacientesTableAdapter = new hospitalDataSetTableAdapters.pacientesTableAdapter();
            pacientesTableAdapter.Fill(db.pacientes);
            DialogResult resp = new DialogResult();
            resp = MessageBox.Show("Seguro que quieres eliminar este paciente?", "Eliminar paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                try
                {
                    regs = this.pacientesTableAdapter.Delete(int.Parse(idpacienteTextBox.Text.ToString()));
                    if (regs > 0)
                    {
                        MessageBox.Show("paciente eliminado", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("No se ha podido eliminar el paciente, asegurate de que no tenga ninguna cita pendiente");
                }
                
                pacientesTableAdapter.Fill(db.pacientes);
            }
        }
        /// <summary>
        /// Cada vez que queramos añadir nuevos campos, hariamos lo siguiente, en este caso no hay nada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
