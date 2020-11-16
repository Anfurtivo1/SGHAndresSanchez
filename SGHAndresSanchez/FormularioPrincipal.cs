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

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "frmComboBox")
                {
                    DialogResult rs = MessageBox.Show("Desea cerrar el formulario actual?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        DatosHospital fc = new DatosHospital();
                        fc.MdiParent = this;
                        fc.Dock = DockStyle.Fill;
                        fc.Show();
                    }

                }

            }
            else
            {
                DatosHospital fc = new DatosHospital();
                fc.MdiParent = this;
                fc.Dock = DockStyle.Fill;
                fc.Show();
            }
        }
    }
}
