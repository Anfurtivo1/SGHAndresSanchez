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

        private void InformePacientes_Load(object sender, EventArgs e)
        {
            cargarComboMedicos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
