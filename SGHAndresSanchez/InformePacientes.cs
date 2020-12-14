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
    public partial class InformePacientes : Form
    {
        private ArrayList idMedicos = new ArrayList();
        public InformePacientes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Se carga el formulario de los medicos
        /// </summary>
        private void cargarComboMedicos()
        {
            hospitalDataSet db = new hospitalDataSet();
            cmbMedicos.Items.Clear();
            hospitalDataSetTableAdapters.medicosTableAdapter medicosTableAdapter = new hospitalDataSetTableAdapters.medicosTableAdapter();
            medicosTableAdapter.Fill(db.medicos);

            for (int i = 0; i < db.medicos.Count; i++)
            {
                cmbMedicos.Items.Add(db.medicos[i].nombre);
                idMedicos.Add(db.medicos[i].idmedico);

            }


        }
        /// <summary>
        /// Al cargar el formulario se realizan las siguientes opciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InformePacientes_Load(object sender, EventArgs e)
        {
            cargarComboMedicos();
        }
        /// <summary>
        /// Al pulsar en el botón buscar se realizaría una busqueda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
