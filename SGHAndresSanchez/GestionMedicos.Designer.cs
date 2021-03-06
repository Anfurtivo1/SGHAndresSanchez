﻿namespace SGHAndresSanchez
{
    partial class GestionMedicos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idmedicoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label movilLabel;
            System.Windows.Forms.Label fotoLabel;
            System.Windows.Forms.Label especialidadLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionMedicos));
            this.btnFoto = new System.Windows.Forms.Button();
            this.medicosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.medicosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idmedicoLabel1 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.movilTextBox = new System.Windows.Forms.TextBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.especialidadComboBox = new System.Windows.Forms.ComboBox();
            this.medicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet = new SGHAndresSanchez.hospitalDataSet();
            this.medicosTableAdapter = new SGHAndresSanchez.hospitalDataSetTableAdapters.medicosTableAdapter();
            this.tableAdapterManager = new SGHAndresSanchez.hospitalDataSetTableAdapters.TableAdapterManager();
            idmedicoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            movilLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            especialidadLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingNavigator)).BeginInit();
            this.medicosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // idmedicoLabel
            // 
            idmedicoLabel.AutoSize = true;
            idmedicoLabel.Location = new System.Drawing.Point(228, 43);
            idmedicoLabel.Name = "idmedicoLabel";
            idmedicoLabel.Size = new System.Drawing.Size(52, 13);
            idmedicoLabel.TabIndex = 19;
            idmedicoLabel.Text = "idmedico:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(228, 72);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(45, 13);
            nombreLabel.TabIndex = 21;
            nombreLabel.Text = "nombre:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(228, 98);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(51, 13);
            apellidosLabel.TabIndex = 23;
            apellidosLabel.Text = "apellidos:";
            // 
            // movilLabel
            // 
            movilLabel.AutoSize = true;
            movilLabel.Location = new System.Drawing.Point(228, 124);
            movilLabel.Name = "movilLabel";
            movilLabel.Size = new System.Drawing.Size(34, 13);
            movilLabel.TabIndex = 25;
            movilLabel.Text = "movil:";
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Location = new System.Drawing.Point(68, 43);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(28, 13);
            fotoLabel.TabIndex = 29;
            fotoLabel.Text = "foto:";
            // 
            // especialidadLabel1
            // 
            especialidadLabel1.AutoSize = true;
            especialidadLabel1.Location = new System.Drawing.Point(228, 150);
            especialidadLabel1.Name = "especialidadLabel1";
            especialidadLabel1.Size = new System.Drawing.Size(69, 13);
            especialidadLabel1.TabIndex = 30;
            especialidadLabel1.Text = "especialidad:";
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(44, 173);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(75, 23);
            this.btnFoto.TabIndex = 18;
            this.btnFoto.Text = "Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // medicosBindingNavigator
            // 
            this.medicosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.medicosBindingNavigator.BindingSource = this.medicosBindingSource;
            this.medicosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.medicosBindingNavigator.DeleteItem = null;
            this.medicosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.medicosBindingNavigatorSaveItem});
            this.medicosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.medicosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.medicosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.medicosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.medicosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.medicosBindingNavigator.Name = "medicosBindingNavigator";
            this.medicosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.medicosBindingNavigator.Size = new System.Drawing.Size(432, 25);
            this.medicosBindingNavigator.TabIndex = 19;
            this.medicosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(42, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 25);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // medicosBindingNavigatorSaveItem
            // 
            this.medicosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.medicosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("medicosBindingNavigatorSaveItem.Image")));
            this.medicosBindingNavigatorSaveItem.Name = "medicosBindingNavigatorSaveItem";
            this.medicosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.medicosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.medicosBindingNavigatorSaveItem.Click += new System.EventHandler(this.medicosBindingNavigatorSaveItem_Click);
            // 
            // idmedicoLabel1
            // 
            this.idmedicoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "idmedico", true));
            this.idmedicoLabel1.Location = new System.Drawing.Point(303, 43);
            this.idmedicoLabel1.Name = "idmedicoLabel1";
            this.idmedicoLabel1.Size = new System.Drawing.Size(100, 23);
            this.idmedicoLabel1.TabIndex = 20;
            this.idmedicoLabel1.Text = "label1";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(303, 69);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 22;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(303, 95);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellidosTextBox.TabIndex = 24;
            // 
            // movilTextBox
            // 
            this.movilTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "movil", true));
            this.movilTextBox.Location = new System.Drawing.Point(303, 121);
            this.movilTextBox.Name = "movilTextBox";
            this.movilTextBox.Size = new System.Drawing.Size(100, 20);
            this.movilTextBox.TabIndex = 26;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.medicosBindingSource, "foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(35, 65);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(100, 98);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 30;
            this.fotoPictureBox.TabStop = false;
            // 
            // especialidadComboBox
            // 
            this.especialidadComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "especialidad", true));
            this.especialidadComboBox.FormattingEnabled = true;
            this.especialidadComboBox.Location = new System.Drawing.Point(303, 147);
            this.especialidadComboBox.Name = "especialidadComboBox";
            this.especialidadComboBox.Size = new System.Drawing.Size(100, 21);
            this.especialidadComboBox.TabIndex = 31;
            // 
            // medicosBindingSource
            // 
            this.medicosBindingSource.DataMember = "medicos";
            this.medicosBindingSource.DataSource = this.hospitalDataSet;
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "hospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicosTableAdapter
            // 
            this.medicosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.atencsmedicasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.especialidadesTableAdapter = null;
            this.tableAdapterManager.medicosTableAdapter = this.medicosTableAdapter;
            this.tableAdapterManager.pacientesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SGHAndresSanchez.hospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // GestionMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(432, 216);
            this.Controls.Add(especialidadLabel1);
            this.Controls.Add(this.especialidadComboBox);
            this.Controls.Add(idmedicoLabel);
            this.Controls.Add(this.idmedicoLabel1);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(movilLabel);
            this.Controls.Add(this.movilTextBox);
            this.Controls.Add(fotoLabel);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(this.medicosBindingNavigator);
            this.Controls.Add(this.btnFoto);
            this.Name = "GestionMedicos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GestionMedicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingNavigator)).EndInit();
            this.medicosBindingNavigator.ResumeLayout(false);
            this.medicosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFoto;
        private hospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource medicosBindingSource;
        private hospitalDataSetTableAdapters.medicosTableAdapter medicosTableAdapter;
        private hospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator medicosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton medicosBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idmedicoLabel1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox movilTextBox;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.ComboBox especialidadComboBox;
    }
}