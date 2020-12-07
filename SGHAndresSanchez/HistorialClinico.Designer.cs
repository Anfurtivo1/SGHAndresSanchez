namespace SGHAndresSanchez
{
    partial class HistorialClinico
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
            System.Windows.Forms.Label nombreLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.nombreComboBox = new System.Windows.Forms.ComboBox();
            this.DGVHistorial = new System.Windows.Forms.DataGridView();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(26, 64);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(61, 13);
            nombreLabel.TabIndex = 6;
            nombreLabel.Text = "Paciente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "HistorialClinico";
            // 
            // nombreComboBox
            // 
            this.nombreComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreComboBox.FormattingEnabled = true;
            this.nombreComboBox.Location = new System.Drawing.Point(93, 61);
            this.nombreComboBox.Name = "nombreComboBox";
            this.nombreComboBox.Size = new System.Drawing.Size(172, 21);
            this.nombreComboBox.TabIndex = 7;
            this.nombreComboBox.SelectedIndexChanged += new System.EventHandler(this.nombreComboBox_SelectedIndexChanged);
            // 
            // DGVHistorial
            // 
            this.DGVHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVHistorial.Location = new System.Drawing.Point(109, 94);
            this.DGVHistorial.Name = "DGVHistorial";
            this.DGVHistorial.Size = new System.Drawing.Size(240, 150);
            this.DGVHistorial.TabIndex = 8;
            // 
            // HistorialClinico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 256);
            this.Controls.Add(this.DGVHistorial);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreComboBox);
            this.Controls.Add(this.label1);
            this.Name = "HistorialClinico";
            this.Text = "HistorialClinico";
            this.Load += new System.EventHandler(this.HistorialClinico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox nombreComboBox;
        private System.Windows.Forms.DataGridView DGVHistorial;
    }
}