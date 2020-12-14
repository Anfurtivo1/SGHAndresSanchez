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

        public FormularioPrincipal()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Acciones que se realizan al cargar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);
            //TODO: esta línea de código carga datos en la tabla 'hospitalDataSet.medicos' Puede moverla o quitarla según sea necesario.
            this.medicosTableAdapter.Fill(this.hospitalDataSet.medicos);
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet.medicos' Puede moverla o quitarla según sea necesario.
            this.medicosTableAdapter.Fill(this.hospitalDataSet.medicos);

            cargarComboEspecialidad();
            cargarComboMedicosDiagnostico();
            timer1.Start();

        }
        /// <summary>
        /// Metodo que carga el combo de medicos
        /// </summary>
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
        /// <summary>
        /// Metodo que carga el combo de medicos del datagridView
        /// </summary>
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
        /// <summary>
        /// Metodo que carga el combo de especialidades
        /// </summary>
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
        /// <summary>
        /// Metodo que carga el combo de pacientes
        /// </summary>
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
        /// <summary>
        /// Metodo que carga el datagridview de diagnosticos
        /// </summary>
        /// <exception cref="">El medico podría no tener ninguna cita asociada</exception>
        private void cargarDGVDiagnosticos()
        {
            diagnosticosDataGridView.Columns[0].ReadOnly = true;
            diagnosticosDataGridView.Columns[1].ReadOnly = true;
            diagnosticosDataGridView.Columns[2].ReadOnly = true;
            diagnosticosDataGridView.Columns[3].ReadOnly = true;

            int pos = cbNombre.SelectedIndex;
            int id = (int)idMedicos[pos];

            hospitalDataSet db = new hospitalDataSet();

            hospitalDataSetTableAdapters.DiagnosticosTableAdapter diagnosticosTableAdapter = new hospitalDataSetTableAdapters.DiagnosticosTableAdapter();
            try
            {
                int idMedico = (int)idMedicos[cbNombre.SelectedIndex];
                diagnosticosTableAdapter.FillByIdMedico(db.Diagnosticos, id);
                lblEspecialidad.Text = db.Diagnosticos[0].especialidad;
                lblIdMedico.Text = id.ToString();
                diagnosticosDataGridView.DataSource = db.Diagnosticos;
                
            }
            catch
            {
                MessageBox.Show("Ese medico no tiene citas asignadas");
            }

            

        }
        /// <summary>
        /// Metodo que carga el panel de los medicos
        /// </summary>
        /// <exception cref="">El medico podría no tener ninguna foto asociada</exception>
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
        /// <summary>
        /// Metodo que carga el panel de los pacientes
        /// </summary>
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
        /// <summary>
        /// Cada vez que pasa un segundo, se actualiza la fecha y hora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("G");
        }
        /// <summary>
        /// Cada vez que se cambia el indice del combo de especialidades se activa el combo de medicos y se carga
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbEspecialidad_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbMedico.Enabled = true;
            cargarComboMedicos();
        }
        /// <summary>
        /// Cada vez que se cambia el indice del combo de pacientes se activa el combo de medicos y se carga el panel de los pacientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbPaciente_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cargarPanelPacientes();
            cbNombre.Enabled = true;
        }
        /// <summary>
        /// Cada vez que se cambia el indice del combo de medicos se activa el combo de pacientes y se carga el panel de medicos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarComboPacientes();
            cargarPanelMedicos();
            cbNombre.SelectedIndex = cbMedico.SelectedIndex;
            cbPaciente.Enabled = true;

        }
        /// <summary>
        /// Cada vez que se cambia el indice del combo de medicos del datagridview se carga el datagridview con sus citas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Cada vez que se pulsa en el boton de actualizar diagnostico se actualiza el diagnostico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizarDiagnostico_Click(object sender, EventArgs e)
        {
            hospitalDataSet db = new hospitalDataSet();
            hospitalDataSetTableAdapters.atencsmedicasTableAdapter atencsmedicasTableAdapter = new hospitalDataSetTableAdapters.atencsmedicasTableAdapter();

            //atencsmedicasTableAdapter.UpdateDiagnostico(diagnosticosDataGridView.Rows[0].Cells[4].Value.ToString());
            MessageBox.Show("Se ha actualizado el registro");
           
        }
        /// <summary>
        /// Carga el combo de los diagnosticos de los medicos
        /// </summary>
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
        /// <summary>
        /// Cada vez que se pulsa en el combo de los medicos del datagridview se realiza lo siguiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbNombre_MouseClick(object sender, MouseEventArgs e)
        {
            cargarComboMedicosDiagnostico();
        }
        /// <summary>
        /// Cada vez que se pulsa en el botón de gestión de medicos se cargar el formulario de gestión de medicos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGestionMedicos_Click(object sender, EventArgs e)
        {
            GestionMedicos gestionMedicos = new GestionMedicos();
            gestionMedicos.ShowDialog();
        }
        /// <summary>
        /// Cada vez que se pulsa en el botón de gestión de pacientes se cargar el formulario de gestión de pacientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGestionPacientes_Click(object sender, EventArgs e)
        {
            GestionPacientes gestionPacientes = new GestionPacientes();
            gestionPacientes.ShowDialog();
        }
        /// <summary>
        /// Cada vez que se pulsa en el botón de añadir cita se añadirá la cita a la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnadirCita_Click(object sender, EventArgs e)
        {
            int posPaciente = cbPaciente.SelectedIndex;
            int idPaciente = (int)idPacientes[posPaciente];

            int posMedico = cbMedico.SelectedIndex;
            int idMedico = (int)idMedicos[posMedico];

            hospitalDataSet db = new hospitalDataSet();

            DateTime fecha=DateTime.Parse(fechaDateTimePicker.Value.ToShortDateString());

            //hospitalDataSetTableAdapters.DataTable1TableAdapter DataTable1TableAdapter = new hospitalDataSetTableAdapters.DataTable1TableAdapter();
            //DataTable1TableAdapter.InsertCita(fecha, idPaciente,idMedico,"");
            MessageBox.Show("Se ha añadido la cita");
        }
        /// <summary>
        /// Cada vez que se pulsa en el botón de pacientesMedicoDia se cargar el formulario de Informe de pacientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Cada vez que se actualiza una fila del datadridview, se activa el boton de actualizar diagnostico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizarDiagnostico.Enabled = true;
        }
    }
}
