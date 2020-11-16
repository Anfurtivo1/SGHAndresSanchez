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
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void atencsmedicasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.atencsmedicasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet.pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.hospitalDataSet.pacientes);
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet.medicos' Puede moverla o quitarla según sea necesario.
            this.medicosTableAdapter.Fill(this.hospitalDataSet.medicos);
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet.atencsmedicas' Puede moverla o quitarla según sea necesario.
            this.atencsmedicasTableAdapter.Fill(this.hospitalDataSet.atencsmedicas);
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString();
        }
    }
}
