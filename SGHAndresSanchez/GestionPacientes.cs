﻿using System;
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

        private void pacientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);
            MessageBox.Show("Se ha actualizado el paciente");

        }

        private void GestionPacientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet.pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.hospitalDataSet.pacientes);

        }

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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha añadido el paciente");
        }
    }
}
