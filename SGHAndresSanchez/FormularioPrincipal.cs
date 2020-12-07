using System;
using System.Collections;
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
    public partial class FormularioPrincipal : Form
    {
        ArrayList idMedicos = new ArrayList();
        ArrayList idPacientes = new ArrayList();
        private object db;

        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            //TODO: esta línea de código carga datos en la tabla 'hospitalDataSet.medicos' Puede moverla o quitarla según sea necesario.
            this.medicosTableAdapter.Fill(this.hospitalDataSet.medicos);
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet.medicos' Puede moverla o quitarla según sea necesario.
            this.medicosTableAdapter.Fill(this.hospitalDataSet.medicos);

            cargarComboEspecialidad();
            timer1.Start();

        }

        private void cargarComboMedicos()
        {
            hospitalDataSet db = new hospitalDataSet();
            idMedicos.Clear();
            cbMedico.Items.Clear();
            hospitalDataSetTableAdapters.medicosTableAdapter medicosTableAdapter = new hospitalDataSetTableAdapters.medicosTableAdapter();
            medicosTableAdapter.FillByNombre(db.medicos, cbEspecialidad.Text.ToString());

            for (int i = 0; i < db.medicos.Count; i++)
            {
                cbMedico.Items.Add(db.medicos[i].nombre);
                idMedicos.Add(db.medicos[i].idmedico);

            }
            
            
        }

        private void cargarComboMedicosDGV()
        {
            hospitalDataSet db = new hospitalDataSet();
            idMedicos.Clear();
            cbNombre.Items.Clear();
            hospitalDataSetTableAdapters.medicosTableAdapter medicosTableAdapter = new hospitalDataSetTableAdapters.medicosTableAdapter();
            medicosTableAdapter.FillByNombre(db.medicos, cbEspecialidad.Text.ToString());

            for (int i = 0; i < db.medicos.Count; i++)
            {
                cbNombre.Items.Add(db.medicos[i].nombre);
                idMedicos.Add(db.medicos[i].idmedico);

            }


        }

        private void cargarComboEspecialidad()
        {
            hospitalDataSet db = new hospitalDataSet();
            hospitalDataSetTableAdapters.especialidadesTableAdapter medicosTableAdapter = new hospitalDataSetTableAdapters.especialidadesTableAdapter();
            medicosTableAdapter.FillByEspecialidad(db.especialidades);

            for (int i = 0; i < db.especialidades.Count; i++)
            {
                cbEspecialidad.Items.Add(db.especialidades[i].especialidad);

            }
        }

        private void cargarComboPacientes()
        {
            hospitalDataSet db = new hospitalDataSet();
            hospitalDataSetTableAdapters.pacientesTableAdapter PacientesTableAdapter = new hospitalDataSetTableAdapters.pacientesTableAdapter();
            PacientesTableAdapter.FillByNombreApellidos(db.pacientes);

            for (int i = 0; i < db.pacientes.Count; i++)
            {
                cbPaciente.Items.Add(db.pacientes[i].nombre + " " + db.pacientes[i].apellidos);
                idPacientes.Add(db.pacientes[i].idpaciente);

            }
        }

        private void cargarDGVDiagnosticos()
        {
            int pos = cbNombre.SelectedIndex;
            int id = (int)idMedicos[pos];

            hospitalDataSet db = new hospitalDataSet();

            hospitalDataSetTableAdapters.DataTable1TableAdapter DataTable1TableAdapter = new hospitalDataSetTableAdapters.DataTable1TableAdapter();
            DataTable1TableAdapter.FillByNombreApellidos(db.DataTable1, id);
            try
            {
                dataGridView1.Rows[0].Cells[0].Value = db.DataTable1[0].idatenc.ToString();
                dataGridView1.Rows[0].Cells[1].Value = db.DataTable1[0].fecha.ToString();
                dataGridView1.Rows[0].Cells[2].Value = db.DataTable1[0].nombre.ToString();
                dataGridView1.Rows[0].Cells[3].Value = db.DataTable1[0].apellidos.ToString();
                dataGridView1.Rows[0].Cells[4].Value = db.DataTable1[0].diagnostico.ToString();
            }
            catch
            {
                MessageBox.Show("Ese medico no tiene citas asignadas");
            }

            

        }

        private void cargarPanelMedicos()
        {
            int pos = cbMedico.SelectedIndex;
            int id = (int)idMedicos[pos];

            hospitalDataSet db = new hospitalDataSet();

            hospitalDataSetTableAdapters.medicosTableAdapter medicosTableAdapter = new hospitalDataSetTableAdapters.medicosTableAdapter();
            medicosTableAdapter.FillById(db.medicos,id);

            idmedicoLabel1.Text = db.medicos[0].idmedico.ToString();
            nombreTextBox.Text = db.medicos[0].nombre.ToString();
            apellidosTextBox.Text = db.medicos[0].apellidos.ToString();
            movilTextBox.Text = db.medicos[0].movil.ToString();
            especialidadTextBox.Text = db.medicos[0].especialidad.ToString();

            

            // Una vez ejecutada la consulta sobre la tabla médicos, y cargado el DataSet correspondiente
            //1º Se comprueba si en esa tabla devuelta con la consulta sobre los médicos hay algún registro
            if (db.medicos.Rows.Count > 0)
            {
                
                //Inicializamos una fila de datos en la cual se almacenaran todos los datos de la fila seleccionada
                //En este ejemplo nos quedamos con la primera

                try
                {
                    DataRow myRow = db.medicos.Rows[0];
                    //Se almacena el campo foto de la tabla en el array de bytes
                    byte[] MyData = (byte[])myRow["foto"];
                    //Se inicializa un flujo en memoria del array de bytes
                    MemoryStream stream = new MemoryStream(MyData);
                    //En el picture box se muestra la imagen que esta almacenada en el flujo en memoria 
                    //el cual contiene el array de bytes
                    pictureBox3.Image = Image.FromStream(stream);
                }
                catch
                {
                    MessageBox.Show("Error al cargar la imagen, no se ha encontrado una imagen valida");
                }
                
            }

        }

        private void cargarPanelPacientes()
        {
            int pos = cbPaciente.SelectedIndex;
            int id = (int)idPacientes[pos];

            hospitalDataSet db = new hospitalDataSet();
            hospitalDataSetTableAdapters.pacientesTableAdapter pacientesTableAdapter = new hospitalDataSetTableAdapters.pacientesTableAdapter();
            pacientesTableAdapter.FillById(db.pacientes, id);

            idpacienteTextBox.Text = db.pacientes[0].idpaciente.ToString();
            nombreTextBox1.Text = db.pacientes[0].nombre.ToString();
            apellidosTextBox1.Text = db.pacientes[0].apellidos.ToString();
            localidadTextBox.Text = db.pacientes[0].localidad.ToString();
            alergiasTextBox.Text = db.pacientes[0].alergias.ToString();
            adestacarTextBox.Text = db.pacientes[0].adestacar.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("G");
        }

        private void cbEspecialidad_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbMedico.Enabled = true;
            cargarComboMedicos();
        }

        private void cbPaciente_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cargarPanelPacientes();
            cbNombre.Enabled = true;
        }

        private void cbMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarComboPacientes();
            cargarPanelMedicos();
            cbPaciente.Enabled = true;
        }

        private void nombreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int posMedico = cbNombre.SelectedIndex;
            int idMedico = (int)idMedicos[posMedico];
            hospitalDataSet db = new hospitalDataSet();
            hospitalDataSetTableAdapters.medicosTableAdapter medicosTableAdapter = new hospitalDataSetTableAdapters.medicosTableAdapter();
            medicosTableAdapter.FillById(db.medicos,idMedico);
            lblIdMedico.Text = db.medicos[0].idmedico.ToString();
            lblEspecialidad.Text = db.medicos[0].especialidad.ToString();

            cargarDGVDiagnosticos();
            
        }

        private void btnActualizarDiagnostico_Click(object sender, EventArgs e)
        {
            hospitalDataSet db = new hospitalDataSet();
            hospitalDataSetTableAdapters.atencsmedicasTableAdapter atencsmedicasTableAdapter = new hospitalDataSetTableAdapters.atencsmedicasTableAdapter();

            atencsmedicasTableAdapter.UpdateDiagnostico(dataGridView1.Rows[0].Cells[4].Value.ToString());
            MessageBox.Show("Se ha actualizado el registro");
           
        }

        private void cargarComboMedicosDiagnostico()
        {
            cbNombre.Items.Clear();
            idMedicos.Clear();
            hospitalDataSet db = new hospitalDataSet();
            hospitalDataSetTableAdapters.medicosTableAdapter medicosTableAdapter = new hospitalDataSetTableAdapters.medicosTableAdapter();
            medicosTableAdapter.Fill(db.medicos);

            for (int i = 0; i < db.medicos.Count; i++)
            {
                cbNombre.Items.Add(db.medicos[i].nombre);
                idMedicos.Add(db.medicos[i].idmedico);
            }

            lblIdMedico.Text = db.medicos[0].idmedico.ToString();
            lblEspecialidad.Text = db.medicos[0].especialidad.ToString();

        }

        private void cbNombre_MouseClick(object sender, MouseEventArgs e)
        {
            cargarComboMedicosDiagnostico();
        }

        private void btnGestionMedicos_Click(object sender, EventArgs e)
        {
            GestionMedicos gestionMedicos = new GestionMedicos();
            gestionMedicos.ShowDialog();
        }

        private void btnGestionPacientes_Click(object sender, EventArgs e)
        {
            GestionPacientes gestionPacientes = new GestionPacientes();
            gestionPacientes.ShowDialog();
        }

        private void btnAnadirCita_Click(object sender, EventArgs e)
        {
            int posPaciente = cbPaciente.SelectedIndex;
            int idPaciente = (int)idPacientes[posPaciente];

            int posMedico = cbMedico.SelectedIndex;
            int idMedico = (int)idMedicos[posMedico];

            hospitalDataSet db = new hospitalDataSet();

            DateTime fecha=DateTime.Parse(fechaDateTimePicker.Value.ToShortDateString());

            hospitalDataSetTableAdapters.DataTable1TableAdapter DataTable1TableAdapter = new hospitalDataSetTableAdapters.DataTable1TableAdapter();
            DataTable1TableAdapter.InsertCita(fecha, idPaciente,idMedico,"");
            MessageBox.Show("Se ha añadido la cita");
        }

        private void btnPacientesMedicoDia_Click(object sender, EventArgs e)
        {
            InformePacientes informePacientes = new InformePacientes();
            informePacientes.ShowDialog();
        }

        private void btnHistorialClinico_Click(object sender, EventArgs e)
        {
            HistorialClinico historialClinico = new HistorialClinico();
            historialClinico.ShowDialog();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizarDiagnostico.Enabled = true;
        }
    }
}
