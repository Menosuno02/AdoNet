namespace AdoNet
{
    partial class Form07HospitalesCRUD
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
            lstHospitales = new ListBox();
            label2 = new Label();
            txtCodigo = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtDireccion = new TextBox();
            label5 = new Label();
            txtNumCamas = new TextBox();
            label6 = new Label();
            txtTelefono = new TextBox();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnEliminar = new Button();
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
            // lstHospitales
            // 
            lstHospitales.FormattingEnabled = true;
            lstHospitales.ItemHeight = 15;
            lstHospitales.Location = new Point(12, 27);
            lstHospitales.Name = "lstHospitales";
            lstHospitales.Size = new Size(141, 244);
            lstHospitales.TabIndex = 1;
            lstHospitales.SelectedIndexChanged += lstHospitales_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 9);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 2;
            label2.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(175, 27);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(154, 23);
            txtCodigo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 63);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(175, 81);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(154, 23);
            txtNombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 116);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 6;
            label4.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(175, 134);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(154, 23);
            txtDireccion.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(175, 170);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 8;
            label5.Text = "Teléfono";
            // 
            // txtNumCamas
            // 
            txtNumCamas.Location = new Point(175, 243);
            txtNumCamas.Name = "txtNumCamas";
            txtNumCamas.Size = new Size(154, 23);
            txtNumCamas.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(175, 225);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 10;
            label6.Text = "Num camas";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(175, 188);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(154, 23);
            txtTelefono.TabIndex = 11;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(175, 277);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Crear";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(256, 277);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Modificar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 277);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(141, 23);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form07HospitalesCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 312);
            Controls.Add(btnEliminar);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(txtTelefono);
            Controls.Add(label6);
            Controls.Add(txtNumCamas);
            Controls.Add(label5);
            Controls.Add(txtDireccion);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtCodigo);
            Controls.Add(label2);
            Controls.Add(lstHospitales);
            Controls.Add(label1);
            Name = "Form07HospitalesCRUD";
            Text = "Form07HospitalesCRUD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstHospitales;
        private Label label2;
        private TextBox txtCodigo;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtDireccion;
        private Label label5;
        private TextBox txtNumCamas;
        private Label label6;
        private TextBox txtTelefono;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnEliminar;
    }
}