namespace SGHAndresSanchez
{
    partial class FormularioPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idatencLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label idmedicoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label movilLabel;
            System.Windows.Forms.Label especialidadLabel;
            System.Windows.Forms.Label idpacienteLabel;
            System.Windows.Forms.Label nombreLabel1;
            System.Windows.Forms.Label apellidosLabel1;
            System.Windows.Forms.Label localidadLabel;
            System.Windows.Forms.Label alergiasLabel;
            System.Windows.Forms.Label adestacarLabel;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label nombreLabel2;
            System.Windows.Forms.Label idmedicoLabel2;
            System.Windows.Forms.Label especialidadLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbPaciente = new System.Windows.Forms.ComboBox();
            this.cbMedico = new System.Windows.Forms.ComboBox();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.btnAnadirCita = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.idatencLabel1 = new System.Windows.Forms.Label();
            this.atencsmedicasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet = new SGHAndresSanchez.hospitalDataSet();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.btnPacientesMedicoDia = new System.Windows.Forms.Button();
            this.btnHistorialClinico = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGestionMedicos = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.idmedicoLabel1 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.movilTextBox = new System.Windows.Forms.TextBox();
            this.especialidadTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGestionPacientes = new System.Windows.Forms.Button();
            this.idpacienteTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox1 = new System.Windows.Forms.TextBox();
            this.apellidosTextBox1 = new System.Windows.Forms.TextBox();
            this.localidadTextBox = new System.Windows.Forms.TextBox();
            this.alergiasTextBox = new System.Windows.Forms.TextBox();
            this.adestacarTextBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.diagnosticosDataGridView = new System.Windows.Forms.DataGridView();
            this.idatencDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmedicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblIdMedico = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.cbNombre = new System.Windows.Forms.ComboBox();
            this.btnActualizarDiagnostico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.medicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atencsmedicasTableAdapter = new SGHAndresSanchez.hospitalDataSetTableAdapters.atencsmedicasTableAdapter();
            this.tableAdapterManager = new SGHAndresSanchez.hospitalDataSetTableAdapters.TableAdapterManager();
            this.medicosTableAdapter = new SGHAndresSanchez.hospitalDataSetTableAdapters.medicosTableAdapter();
            this.pacientesTableAdapter = new SGHAndresSanchez.hospitalDataSetTableAdapters.pacientesTableAdapter();
            this.diagnosticosTableAdapter = new SGHAndresSanchez.hospitalDataSetTableAdapters.DiagnosticosTableAdapter();
            idatencLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            idmedicoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            movilLabel = new System.Windows.Forms.Label();
            especialidadLabel = new System.Windows.Forms.Label();
            idpacienteLabel = new System.Windows.Forms.Label();
            nombreLabel1 = new System.Windows.Forms.Label();
            apellidosLabel1 = new System.Windows.Forms.Label();
            localidadLabel = new System.Windows.Forms.Label();
            alergiasLabel = new System.Windows.Forms.Label();
            adestacarLabel = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            nombreLabel2 = new System.Windows.Forms.Label();
            idmedicoLabel2 = new System.Windows.Forms.Label();
            especialidadLabel1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencsmedicasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idatencLabel
            // 
            idatencLabel.AutoSize = true;
            idatencLabel.Location = new System.Drawing.Point(168, 34);
            idatencLabel.Name = "idatencLabel";
            idatencLabel.Size = new System.Drawing.Size(45, 13);
            idatencLabel.TabIndex = 0;
            idatencLabel.Text = "idatenc:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(168, 64);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(37, 13);
            fechaLabel.TabIndex = 2;
            fechaLabel.Text = "fecha:";
            // 
            // idmedicoLabel
            // 
            idmedicoLabel.AutoSize = true;
            idmedicoLabel.Location = new System.Drawing.Point(131, 19);
            idmedicoLabel.Name = "idmedicoLabel";
            idmedicoLabel.Size = new System.Drawing.Size(52, 13);
            idmedicoLabel.TabIndex = 9;
            idmedicoLabel.Text = "idmedico:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(131, 45);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(45, 13);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "nombre:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(131, 71);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(51, 13);
            apellidosLabel.TabIndex = 4;
            apellidosLabel.Text = "apellidos:";
            // 
            // movilLabel
            // 
            movilLabel.AutoSize = true;
            movilLabel.Location = new System.Drawing.Point(131, 97);
            movilLabel.Name = "movilLabel";
            movilLabel.Size = new System.Drawing.Size(34, 13);
            movilLabel.TabIndex = 6;
            movilLabel.Text = "movil:";
            // 
            // especialidadLabel
            // 
            especialidadLabel.AutoSize = true;
            especialidadLabel.Location = new System.Drawing.Point(131, 123);
            especialidadLabel.Name = "especialidadLabel";
            especialidadLabel.Size = new System.Drawing.Size(69, 13);
            especialidadLabel.TabIndex = 8;
            especialidadLabel.Text = "especialidad:";
            // 
            // idpacienteLabel
            // 
            idpacienteLabel.AutoSize = true;
            idpacienteLabel.Location = new System.Drawing.Point(79, 13);
            idpacienteLabel.Name = "idpacienteLabel";
            idpacienteLabel.Size = new System.Drawing.Size(59, 13);
            idpacienteLabel.TabIndex = 0;
            idpacienteLabel.Text = "idpaciente:";
            // 
            // nombreLabel1
            // 
            nombreLabel1.AutoSize = true;
            nombreLabel1.Location = new System.Drawing.Point(79, 39);
            nombreLabel1.Name = "nombreLabel1";
            nombreLabel1.Size = new System.Drawing.Size(45, 13);
            nombreLabel1.TabIndex = 2;
            nombreLabel1.Text = "nombre:";
            // 
            // apellidosLabel1
            // 
            apellidosLabel1.AutoSize = true;
            apellidosLabel1.Location = new System.Drawing.Point(79, 65);
            apellidosLabel1.Name = "apellidosLabel1";
            apellidosLabel1.Size = new System.Drawing.Size(51, 13);
            apellidosLabel1.TabIndex = 4;
            apellidosLabel1.Text = "apellidos:";
            // 
            // localidadLabel
            // 
            localidadLabel.AutoSize = true;
            localidadLabel.Location = new System.Drawing.Point(79, 91);
            localidadLabel.Name = "localidadLabel";
            localidadLabel.Size = new System.Drawing.Size(52, 13);
            localidadLabel.TabIndex = 6;
            localidadLabel.Text = "localidad:";
            // 
            // alergiasLabel
            // 
            alergiasLabel.AutoSize = true;
            alergiasLabel.Location = new System.Drawing.Point(79, 117);
            alergiasLabel.Name = "alergiasLabel";
            alergiasLabel.Size = new System.Drawing.Size(46, 13);
            alergiasLabel.TabIndex = 8;
            alergiasLabel.Text = "alergias:";
            // 
            // adestacarLabel
            // 
            adestacarLabel.AutoSize = true;
            adestacarLabel.Location = new System.Drawing.Point(79, 166);
            adestacarLabel.Name = "adestacarLabel";
            adestacarLabel.Size = new System.Drawing.Size(57, 13);
            adestacarLabel.TabIndex = 10;
            adestacarLabel.Text = "adestacar:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(168, 89);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(70, 13);
            label9.TabIndex = 17;
            label9.Text = "Especialidad:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(168, 117);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(44, 13);
            label10.TabIndex = 18;
            label10.Text = "medico:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(168, 146);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(51, 13);
            label11.TabIndex = 19;
            label11.Text = "paciente:";
            // 
            // nombreLabel2
            // 
            nombreLabel2.AutoSize = true;
            nombreLabel2.Location = new System.Drawing.Point(193, 44);
            nombreLabel2.Name = "nombreLabel2";
            nombreLabel2.Size = new System.Drawing.Size(44, 13);
            nombreLabel2.TabIndex = 22;
            nombreLabel2.Text = "medico:";
            // 
            // idmedicoLabel2
            // 
            idmedicoLabel2.AutoSize = true;
            idmedicoLabel2.Location = new System.Drawing.Point(193, 97);
            idmedicoLabel2.Name = "idmedicoLabel2";
            idmedicoLabel2.Size = new System.Drawing.Size(52, 13);
            idmedicoLabel2.TabIndex = 24;
            idmedicoLabel2.Text = "idmedico:";
            // 
            // especialidadLabel1
            // 
            especialidadLabel1.AutoSize = true;
            especialidadLabel1.Location = new System.Drawing.Point(193, 71);
            especialidadLabel1.Name = "especialidadLabel1";
            especialidadLabel1.Size = new System.Drawing.Size(69, 13);
            especialidadLabel1.TabIndex = 23;
            especialidadLabel1.Text = "especialidad:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(30, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 163);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "CIF - A13121212Q";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tlfno. 926 20 00 00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "C/ La Salud nº7 - 13005 - C.R";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "HOSPITAL GENERAL";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(7, 35);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(115, 107);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Datos del hospital";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(label11);
            this.panel3.Controls.Add(label10);
            this.panel3.Controls.Add(label9);
            this.panel3.Controls.Add(this.cbPaciente);
            this.panel3.Controls.Add(this.cbMedico);
            this.panel3.Controls.Add(this.cbEspecialidad);
            this.panel3.Controls.Add(this.btnAnadirCita);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(idatencLabel);
            this.panel3.Controls.Add(this.idatencLabel1);
            this.panel3.Controls.Add(fechaLabel);
            this.panel3.Controls.Add(this.fechaDateTimePicker);
            this.panel3.Location = new System.Drawing.Point(400, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 222);
            this.panel3.TabIndex = 1;
            // 
            // cbPaciente
            // 
            this.cbPaciente.Enabled = false;
            this.cbPaciente.FormattingEnabled = true;
            this.cbPaciente.Location = new System.Drawing.Point(238, 143);
            this.cbPaciente.Name = "cbPaciente";
            this.cbPaciente.Size = new System.Drawing.Size(200, 21);
            this.cbPaciente.TabIndex = 16;
            this.cbPaciente.SelectedIndexChanged += new System.EventHandler(this.cbPaciente_SelectedIndexChanged_1);
            // 
            // cbMedico
            // 
            this.cbMedico.Enabled = false;
            this.cbMedico.FormattingEnabled = true;
            this.cbMedico.Location = new System.Drawing.Point(238, 114);
            this.cbMedico.Name = "cbMedico";
            this.cbMedico.Size = new System.Drawing.Size(200, 21);
            this.cbMedico.TabIndex = 15;
            this.cbMedico.SelectedIndexChanged += new System.EventHandler(this.cbMedico_SelectedIndexChanged);
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Location = new System.Drawing.Point(238, 86);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(200, 21);
            this.cbEspecialidad.TabIndex = 14;
            this.cbEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cbEspecialidad_SelectedIndexChanged_1);
            // 
            // btnAnadirCita
            // 
            this.btnAnadirCita.Location = new System.Drawing.Point(53, 184);
            this.btnAnadirCita.Name = "btnAnadirCita";
            this.btnAnadirCita.Size = new System.Drawing.Size(210, 23);
            this.btnAnadirCita.TabIndex = 13;
            this.btnAnadirCita.Text = "Añadir cita";
            this.btnAnadirCita.UseVisualStyleBackColor = true;
            this.btnAnadirCita.Click += new System.EventHandler(this.btnAnadirCita_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SGHAndresSanchez.Properties.Resources.citaMedica;
            this.pictureBox5.Location = new System.Drawing.Point(16, 21);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(146, 157);
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // idatencLabel1
            // 
            this.idatencLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.atencsmedicasBindingSource, "idatenc", true));
            this.idatencLabel1.Location = new System.Drawing.Point(238, 34);
            this.idatencLabel1.Name = "idatencLabel1";
            this.idatencLabel1.Size = new System.Drawing.Size(200, 23);
            this.idatencLabel1.TabIndex = 1;
            this.idatencLabel1.Text = "label9";
            // 
            // atencsmedicasBindingSource
            // 
            this.atencsmedicasBindingSource.DataMember = "atencsmedicas";
            this.atencsmedicasBindingSource.DataSource = this.hospitalDataSet;
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "hospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.atencsmedicasBindingSource, "fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(238, 60);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel6.Controls.Add(this.lblFechaHora);
            this.panel6.Location = new System.Drawing.Point(400, 285);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(203, 91);
            this.panel6.TabIndex = 2;
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Location = new System.Drawing.Point(37, 38);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(13, 13);
            this.lblFechaHora.TabIndex = 0;
            this.lblFechaHora.Text = "--";
            // 
            // btnPacientesMedicoDia
            // 
            this.btnPacientesMedicoDia.Location = new System.Drawing.Point(629, 292);
            this.btnPacientesMedicoDia.Name = "btnPacientesMedicoDia";
            this.btnPacientesMedicoDia.Size = new System.Drawing.Size(90, 75);
            this.btnPacientesMedicoDia.TabIndex = 3;
            this.btnPacientesMedicoDia.Text = "Pacientes medico/dia";
            this.btnPacientesMedicoDia.UseVisualStyleBackColor = true;
            this.btnPacientesMedicoDia.Click += new System.EventHandler(this.btnPacientesMedicoDia_Click);
            // 
            // btnHistorialClinico
            // 
            this.btnHistorialClinico.Location = new System.Drawing.Point(734, 292);
            this.btnHistorialClinico.Name = "btnHistorialClinico";
            this.btnHistorialClinico.Size = new System.Drawing.Size(85, 75);
            this.btnHistorialClinico.TabIndex = 4;
            this.btnHistorialClinico.Text = "Historial Clinico";
            this.btnHistorialClinico.UseVisualStyleBackColor = true;
            this.btnHistorialClinico.Click += new System.EventHandler(this.btnHistorialClinico_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btnGestionMedicos);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(idmedicoLabel);
            this.panel2.Controls.Add(this.idmedicoLabel1);
            this.panel2.Controls.Add(nombreLabel);
            this.panel2.Controls.Add(this.nombreTextBox);
            this.panel2.Controls.Add(apellidosLabel);
            this.panel2.Controls.Add(this.apellidosTextBox);
            this.panel2.Controls.Add(movilLabel);
            this.panel2.Controls.Add(this.movilTextBox);
            this.panel2.Controls.Add(especialidadLabel);
            this.panel2.Controls.Add(this.especialidadTextBox);
            this.panel2.Location = new System.Drawing.Point(30, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 175);
            this.panel2.TabIndex = 5;
            // 
            // btnGestionMedicos
            // 
            this.btnGestionMedicos.Location = new System.Drawing.Point(82, 142);
            this.btnGestionMedicos.Name = "btnGestionMedicos";
            this.btnGestionMedicos.Size = new System.Drawing.Size(140, 23);
            this.btnGestionMedicos.TabIndex = 13;
            this.btnGestionMedicos.Text = "Gestión de medicos";
            this.btnGestionMedicos.UseVisualStyleBackColor = true;
            this.btnGestionMedicos.Click += new System.EventHandler(this.btnGestionMedicos_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(18, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(105, 111);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Medico";
            // 
            // idmedicoLabel1
            // 
            this.idmedicoLabel1.Location = new System.Drawing.Point(189, 19);
            this.idmedicoLabel1.Name = "idmedicoLabel1";
            this.idmedicoLabel1.Size = new System.Drawing.Size(124, 23);
            this.idmedicoLabel1.TabIndex = 10;
            this.idmedicoLabel1.Text = "label2";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(206, 42);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.ReadOnly = true;
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 3;
            this.nombreTextBox.Text = "c";
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.Location = new System.Drawing.Point(206, 68);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.ReadOnly = true;
            this.apellidosTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellidosTextBox.TabIndex = 5;
            // 
            // movilTextBox
            // 
            this.movilTextBox.Location = new System.Drawing.Point(206, 94);
            this.movilTextBox.Name = "movilTextBox";
            this.movilTextBox.ReadOnly = true;
            this.movilTextBox.Size = new System.Drawing.Size(100, 20);
            this.movilTextBox.TabIndex = 7;
            // 
            // especialidadTextBox
            // 
            this.especialidadTextBox.Location = new System.Drawing.Point(206, 120);
            this.especialidadTextBox.Name = "especialidadTextBox";
            this.especialidadTextBox.ReadOnly = true;
            this.especialidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.especialidadTextBox.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnGestionPacientes);
            this.panel4.Controls.Add(idpacienteLabel);
            this.panel4.Controls.Add(this.idpacienteTextBox);
            this.panel4.Controls.Add(nombreLabel1);
            this.panel4.Controls.Add(this.nombreTextBox1);
            this.panel4.Controls.Add(apellidosLabel1);
            this.panel4.Controls.Add(this.apellidosTextBox1);
            this.panel4.Controls.Add(localidadLabel);
            this.panel4.Controls.Add(this.localidadTextBox);
            this.panel4.Controls.Add(alergiasLabel);
            this.panel4.Controls.Add(this.alergiasTextBox);
            this.panel4.Controls.Add(adestacarLabel);
            this.panel4.Controls.Add(this.adestacarTextBox);
            this.panel4.Location = new System.Drawing.Point(48, 407);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(277, 247);
            this.panel4.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 134);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Paciente";
            // 
            // btnGestionPacientes
            // 
            this.btnGestionPacientes.Location = new System.Drawing.Point(3, 182);
            this.btnGestionPacientes.Name = "btnGestionPacientes";
            this.btnGestionPacientes.Size = new System.Drawing.Size(83, 56);
            this.btnGestionPacientes.TabIndex = 22;
            this.btnGestionPacientes.Text = "Gestion de pacientes";
            this.btnGestionPacientes.UseVisualStyleBackColor = true;
            this.btnGestionPacientes.Click += new System.EventHandler(this.btnGestionPacientes_Click);
            // 
            // idpacienteTextBox
            // 
            this.idpacienteTextBox.Location = new System.Drawing.Point(144, 10);
            this.idpacienteTextBox.Name = "idpacienteTextBox";
            this.idpacienteTextBox.ReadOnly = true;
            this.idpacienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.idpacienteTextBox.TabIndex = 1;
            // 
            // nombreTextBox1
            // 
            this.nombreTextBox1.Location = new System.Drawing.Point(144, 36);
            this.nombreTextBox1.Name = "nombreTextBox1";
            this.nombreTextBox1.ReadOnly = true;
            this.nombreTextBox1.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox1.TabIndex = 3;
            // 
            // apellidosTextBox1
            // 
            this.apellidosTextBox1.Location = new System.Drawing.Point(144, 62);
            this.apellidosTextBox1.Name = "apellidosTextBox1";
            this.apellidosTextBox1.ReadOnly = true;
            this.apellidosTextBox1.Size = new System.Drawing.Size(100, 20);
            this.apellidosTextBox1.TabIndex = 5;
            // 
            // localidadTextBox
            // 
            this.localidadTextBox.Location = new System.Drawing.Point(144, 88);
            this.localidadTextBox.Name = "localidadTextBox";
            this.localidadTextBox.ReadOnly = true;
            this.localidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.localidadTextBox.TabIndex = 7;
            // 
            // alergiasTextBox
            // 
            this.alergiasTextBox.Location = new System.Drawing.Point(144, 114);
            this.alergiasTextBox.Multiline = true;
            this.alergiasTextBox.Name = "alergiasTextBox";
            this.alergiasTextBox.ReadOnly = true;
            this.alergiasTextBox.Size = new System.Drawing.Size(100, 43);
            this.alergiasTextBox.TabIndex = 9;
            // 
            // adestacarTextBox
            // 
            this.adestacarTextBox.Location = new System.Drawing.Point(144, 163);
            this.adestacarTextBox.Multiline = true;
            this.adestacarTextBox.Name = "adestacarTextBox";
            this.adestacarTextBox.ReadOnly = true;
            this.adestacarTextBox.Size = new System.Drawing.Size(100, 67);
            this.adestacarTextBox.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.diagnosticosDataGridView);
            this.panel5.Controls.Add(this.lblIdMedico);
            this.panel5.Controls.Add(this.lblEspecialidad);
            this.panel5.Controls.Add(this.cbNombre);
            this.panel5.Controls.Add(idmedicoLabel2);
            this.panel5.Controls.Add(especialidadLabel1);
            this.panel5.Controls.Add(nombreLabel2);
            this.panel5.Controls.Add(this.btnActualizarDiagnostico);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(363, 382);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(545, 444);
            this.panel5.TabIndex = 7;
            // 
            // diagnosticosDataGridView
            // 
            this.diagnosticosDataGridView.AutoGenerateColumns = false;
            this.diagnosticosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diagnosticosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idatencDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.diagnosticoDataGridViewTextBoxColumn,
            this.idmedicoDataGridViewTextBoxColumn,
            this.especialidadDataGridViewTextBoxColumn});
            this.diagnosticosDataGridView.DataSource = this.diagnosticosBindingSource;
            this.diagnosticosDataGridView.Location = new System.Drawing.Point(15, 228);
            this.diagnosticosDataGridView.Name = "diagnosticosDataGridView";
            this.diagnosticosDataGridView.Size = new System.Drawing.Size(518, 150);
            this.diagnosticosDataGridView.TabIndex = 29;
            // 
            // idatencDataGridViewTextBoxColumn
            // 
            this.idatencDataGridViewTextBoxColumn.DataPropertyName = "idatenc";
            this.idatencDataGridViewTextBoxColumn.HeaderText = "idatenc";
            this.idatencDataGridViewTextBoxColumn.Name = "idatencDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            // 
            // diagnosticoDataGridViewTextBoxColumn
            // 
            this.diagnosticoDataGridViewTextBoxColumn.DataPropertyName = "diagnostico";
            this.diagnosticoDataGridViewTextBoxColumn.HeaderText = "diagnostico";
            this.diagnosticoDataGridViewTextBoxColumn.Name = "diagnosticoDataGridViewTextBoxColumn";
            // 
            // idmedicoDataGridViewTextBoxColumn
            // 
            this.idmedicoDataGridViewTextBoxColumn.DataPropertyName = "idmedico";
            this.idmedicoDataGridViewTextBoxColumn.HeaderText = "idmedico";
            this.idmedicoDataGridViewTextBoxColumn.Name = "idmedicoDataGridViewTextBoxColumn";
            // 
            // especialidadDataGridViewTextBoxColumn
            // 
            this.especialidadDataGridViewTextBoxColumn.DataPropertyName = "especialidad";
            this.especialidadDataGridViewTextBoxColumn.HeaderText = "especialidad";
            this.especialidadDataGridViewTextBoxColumn.Name = "especialidadDataGridViewTextBoxColumn";
            // 
            // diagnosticosBindingSource
            // 
            this.diagnosticosBindingSource.DataMember = "Diagnosticos";
            this.diagnosticosBindingSource.DataSource = this.hospitalDataSet;
            // 
            // lblIdMedico
            // 
            this.lblIdMedico.AutoSize = true;
            this.lblIdMedico.Location = new System.Drawing.Point(251, 97);
            this.lblIdMedico.Name = "lblIdMedico";
            this.lblIdMedico.Size = new System.Drawing.Size(13, 13);
            this.lblIdMedico.TabIndex = 28;
            this.lblIdMedico.Text = "--";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(278, 71);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(13, 13);
            this.lblEspecialidad.TabIndex = 27;
            this.lblEspecialidad.Text = "--";
            // 
            // cbNombre
            // 
            this.cbNombre.FormattingEnabled = true;
            this.cbNombre.Location = new System.Drawing.Point(241, 41);
            this.cbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(92, 21);
            this.cbNombre.TabIndex = 25;
            this.cbNombre.SelectedIndexChanged += new System.EventHandler(this.nombreComboBox_SelectedIndexChanged);
            this.cbNombre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbNombre_MouseClick);
            // 
            // btnActualizarDiagnostico
            // 
            this.btnActualizarDiagnostico.Enabled = false;
            this.btnActualizarDiagnostico.Location = new System.Drawing.Point(309, 119);
            this.btnActualizarDiagnostico.Name = "btnActualizarDiagnostico";
            this.btnActualizarDiagnostico.Size = new System.Drawing.Size(175, 45);
            this.btnActualizarDiagnostico.TabIndex = 22;
            this.btnActualizarDiagnostico.Text = "Actualizar Diagnostico";
            this.btnActualizarDiagnostico.UseVisualStyleBackColor = true;
            this.btnActualizarDiagnostico.Click += new System.EventHandler(this.btnActualizarDiagnostico_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Citas del medico";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // medicosBindingSource
            // 
            this.medicosBindingSource.DataMember = "medicos";
            this.medicosBindingSource.DataSource = this.hospitalDataSet;
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "pacientes";
            this.pacientesBindingSource.DataSource = this.hospitalDataSet;
            // 
            // atencsmedicasTableAdapter
            // 
            this.atencsmedicasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.atencsmedicasTableAdapter = this.atencsmedicasTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.especialidadesTableAdapter = null;
            this.tableAdapterManager.medicosTableAdapter = this.medicosTableAdapter;
            this.tableAdapterManager.pacientesTableAdapter = this.pacientesTableAdapter;
            this.tableAdapterManager.UpdateOrder = SGHAndresSanchez.hospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // medicosTableAdapter
            // 
            this.medicosTableAdapter.ClearBeforeFill = true;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // diagnosticosTableAdapter
            // 
            this.diagnosticosTableAdapter.ClearBeforeFill = true;
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(920, 838);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnHistorialClinico);
            this.Controls.Add(this.btnPacientesMedicoDia);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencsmedicasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnPacientesMedicoDia;
        private System.Windows.Forms.Button btnHistorialClinico;
        private hospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource atencsmedicasBindingSource;
        private hospitalDataSetTableAdapters.atencsmedicasTableAdapter atencsmedicasTableAdapter;
        private hospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private hospitalDataSetTableAdapters.medicosTableAdapter medicosTableAdapter;
        private System.Windows.Forms.BindingSource medicosBindingSource;
        private hospitalDataSetTableAdapters.pacientesTableAdapter pacientesTableAdapter;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label idatencLabel1;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnAnadirCita;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGestionMedicos;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label idmedicoLabel1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox movilTextBox;
        private System.Windows.Forms.TextBox especialidadTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGestionPacientes;
        private System.Windows.Forms.TextBox idpacienteTextBox;
        private System.Windows.Forms.TextBox nombreTextBox1;
        private System.Windows.Forms.TextBox apellidosTextBox1;
        private System.Windows.Forms.TextBox localidadTextBox;
        private System.Windows.Forms.TextBox alergiasTextBox;
        private System.Windows.Forms.TextBox adestacarTextBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnActualizarDiagnostico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbMedico;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.ComboBox cbPaciente;
        private System.Windows.Forms.BindingSource diagnosticosBindingSource;
        private hospitalDataSetTableAdapters.DiagnosticosTableAdapter diagnosticosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView diagnosticosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idatencDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosticoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmedicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblIdMedico;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.ComboBox cbNombre;
    }
}

