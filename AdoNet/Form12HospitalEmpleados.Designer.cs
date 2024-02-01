namespace AdoNet
{
    partial class Form12HospitalEmpleados
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
            label2 = new Label();
            txtSuma = new TextBox();
            label3 = new Label();
            txtMedia = new TextBox();
            label4 = new Label();
            txtEmpleados = new TextBox();
            label5 = new Label();
            lstEmpleados = new ListBox();
            label6 = new Label();
            txtSalario = new TextBox();
            label7 = new Label();
            txtOficio = new TextBox();
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
            cmbHospitales.Size = new Size(121, 23);
            cmbHospitales.TabIndex = 1;
            cmbHospitales.SelectedIndexChanged += cmbHospitales_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "Suma";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(12, 81);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(121, 23);
            txtSuma.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 4;
            label3.Text = "Media";
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(12, 134);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(121, 23);
            txtMedia.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 169);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 6;
            label4.Text = "Empleados";
            // 
            // txtEmpleados
            // 
            txtEmpleados.Location = new Point(12, 187);
            txtEmpleados.Name = "txtEmpleados";
            txtEmpleados.Size = new Size(121, 23);
            txtEmpleados.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(154, 9);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 8;
            label5.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 15;
            lstEmpleados.Location = new Point(154, 27);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(180, 184);
            lstEmpleados.TabIndex = 9;
            lstEmpleados.SelectedIndexChanged += lstEmpleados_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(354, 27);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 10;
            label6.Text = "Salario";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(354, 45);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(100, 23);
            txtSalario.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(354, 81);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 12;
            label7.Text = "Oficio";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(354, 99);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(100, 23);
            txtOficio.TabIndex = 13;
            // 
            // Form12HospitalEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 226);
            Controls.Add(txtOficio);
            Controls.Add(label7);
            Controls.Add(txtSalario);
            Controls.Add(label6);
            Controls.Add(lstEmpleados);
            Controls.Add(label5);
            Controls.Add(txtEmpleados);
            Controls.Add(label4);
            Controls.Add(txtMedia);
            Controls.Add(label3);
            Controls.Add(txtSuma);
            Controls.Add(label2);
            Controls.Add(cmbHospitales);
            Controls.Add(label1);
            Name = "Form12HospitalEmpleados";
            Text = "Form12HospitalEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbHospitales;
        private Label label2;
        private TextBox txtSuma;
        private Label label3;
        private TextBox txtMedia;
        private Label label4;
        private TextBox txtEmpleados;
        private Label label5;
        private ListBox lstEmpleados;
        private Label label6;
        private TextBox txtSalario;
        private Label label7;
        private TextBox txtOficio;
    }
}