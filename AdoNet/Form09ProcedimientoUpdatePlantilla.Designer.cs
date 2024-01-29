namespace AdoNet
{
    partial class Form09ProcedimientoUpdatePlantilla
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
            label1 = new Label();
            cmbHospitales = new ComboBox();
            btnUpdateSalarios = new Button();
            label2 = new Label();
            lstPlantilla = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // cmbHospitales
            // 
            cmbHospitales.FormattingEnabled = true;
            cmbHospitales.Location = new Point(12, 27);
            cmbHospitales.Name = "cmbHospitales";
            cmbHospitales.Size = new Size(158, 23);
            cmbHospitales.TabIndex = 1;
            // 
            // btnUpdateSalarios
            // 
            btnUpdateSalarios.Location = new Point(194, 27);
            btnUpdateSalarios.Name = "btnUpdateSalarios";
            btnUpdateSalarios.Size = new Size(108, 23);
            btnUpdateSalarios.TabIndex = 2;
            btnUpdateSalarios.Text = "Modificar salarios";
            btnUpdateSalarios.UseVisualStyleBackColor = true;
            btnUpdateSalarios.Click += btnUpdateSalarios_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Plantilla";
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.ItemHeight = 15;
            lstPlantilla.Location = new Point(13, 80);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(289, 124);
            lstPlantilla.TabIndex = 4;
            // 
            // Form09ProcedimientoUpdatePlantilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 218);
            Controls.Add(lstPlantilla);
            Controls.Add(label2);
            Controls.Add(btnUpdateSalarios);
            Controls.Add(cmbHospitales);
            Controls.Add(label1);
            Name = "Form09ProcedimientoUpdatePlantilla";
            Text = "Form09ProcedimientoUpdatePlantilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbHospitales;
        private Button btnUpdateSalarios;
        private Label label2;
        private ListBox lstPlantilla;
    }
}