namespace AdoNet
{
    partial class Form10MensajesServidor
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
            txtNumero = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtLocalidad = new TextBox();
            btnInsertar = new Button();
            lblMensajesServidor = new Label();
            label4 = new Label();
            lstDepartamentos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(12, 27);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(138, 23);
            txtNumero.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 85);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(138, 23);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(12, 141);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(138, 23);
            txtLocalidad.TabIndex = 5;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(12, 203);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(138, 23);
            btnInsertar.TabIndex = 6;
            btnInsertar.Text = "Insertar departamento";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // lblMensajesServidor
            // 
            lblMensajesServidor.AutoSize = true;
            lblMensajesServidor.ForeColor = SystemColors.HotTrack;
            lblMensajesServidor.Location = new Point(12, 243);
            lblMensajesServidor.Name = "lblMensajesServidor";
            lblMensajesServidor.Size = new Size(112, 15);
            lblMensajesServidor.TabIndex = 7;
            lblMensajesServidor.Text = "lblMensajesServidor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 9);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 8;
            label4.Text = "Departamentos";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.ItemHeight = 15;
            lstDepartamentos.Location = new Point(175, 27);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(224, 199);
            lstDepartamentos.TabIndex = 9;
            // 
            // Form10MensajesServidor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 267);
            Controls.Add(lstDepartamentos);
            Controls.Add(label4);
            Controls.Add(lblMensajesServidor);
            Controls.Add(btnInsertar);
            Controls.Add(txtLocalidad);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "Form10MensajesServidor";
            Text = "Form10MensajesServidor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtLocalidad;
        private Button btnInsertar;
        private Label lblMensajesServidor;
        private Label label4;
        private ListBox lstDepartamentos;
    }
}