using System;
using System.Collections;
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
    public partial class HistorialClinico : Form
    {
        ArrayList idPacientes = new ArrayList();
        ArrayList listaPacientes = new ArrayList();

        public HistorialClinico()
        {
            InitializeComponent();
        }
        /// <summary>
        ///  Acciones que se realizan al cargar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HistorialClinico_Load(object sender, EventArgs e)
        {
            llenarComboPacientes();
        }
        /// <summary>
        /// Se llena el combo de los pacientes
        /// </summary>
        private void llenarComboPacientes()
        {
            hospitalDataSet db = new hospitalDataSet();
            hospitalDataSetTableAdapters.pacientesTableAdapter pacientesTableAdapter = new hospitalDataSetTableAdapters.pacientesTableAdapter();

            pacientesTableAdapter.Fill(db.pacientes);

            for (int i = 0; i < db.pacientes.Count; i++)
            {
                nombreComboBox.Items.Add(db.pacientes[i].nombre + " " + db.pacientes[i].apellidos);
                idPacientes.Add(db.pacientes[i].idpaciente);

            }

        }
        /// <summary>
        /// Cada vez que seleccionemos un paciente, se cargan sus datos en el datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nombreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDataGridView();
        }
        /// <summary>
        /// Se cargan los datos del paciente en el datagriview
        /// </summary>
        private void cargarDataGridView()
        {
            hospitalDataSet db = new hospitalDataSet();
            hospitalDataSetTableAdapters.HistorialTableAdapter HistorialTableAdapter = new hospitalDataSetTableAdapters.HistorialTableAdapter();
                int id = (int)this.listaPacientes[this.nombreComboBox.SelectedIndex];
                HistorialTableAdapter.Fill(db.Historial, id);
                DGVHistorial.DataSource = db.Historial;

                foreach (DataGridViewRow row in DGVHistorial.Rows)
                {
                    row.Cells[0].ReadOnly = true;
                    row.Cells[1].ReadOnly = true;
                    row.Cells[2].ReadOnly = true;
                    row.Cells[3].ReadOnly = true;
                }
            }
        }

    }
