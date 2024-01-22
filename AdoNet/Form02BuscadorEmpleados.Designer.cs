namespace AdoNet
{
    partial class Form02BuscadorEmpleados
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
            txtSalario = new TextBox();
            btnBuscarSalario = new Button();
            label2 = new Label();
            lstEmpleados = new ListBox();
            btnBuscarOficio = new Button();
            txtOficio = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduce salario";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(12, 27);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(168, 23);
            txtSalario.TabIndex = 1;
            // 
            // btnBuscarSalario
            // 
            btnBuscarSalario.Location = new Point(12, 56);
            btnBuscarSalario.Name = "btnBuscarSalario";
            btnBuscarSalario.Size = new Size(168, 23);
            btnBuscarSalario.TabIndex = 2;
            btnBuscarSalario.Text = "Buscar por salario";
            btnBuscarSalario.UseVisualStyleBackColor = true;
            btnBuscarSalario.Click += btnBuscarSalario_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 95);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "Empleados";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 15;
            lstEmpleados.Location = new Point(12, 113);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(352, 169);
            lstEmpleados.TabIndex = 4;
            // 
            // btnBuscarOficio
            // 
            btnBuscarOficio.Location = new Point(196, 56);
            btnBuscarOficio.Name = "btnBuscarOficio";
            btnBuscarOficio.Size = new Size(168, 23);
            btnBuscarOficio.TabIndex = 7;
            btnBuscarOficio.Text = "Buscar por oficio";
            btnBuscarOficio.UseVisualStyleBackColor = true;
            btnBuscarOficio.Click += buttonBuscarOficio_Click;
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(196, 27);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(168, 23);
            txtOficio.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(196, 9);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 5;
            label4.Text = "Introduce oficio";
            // 
            // Form02BuscadorEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 294);
            Controls.Add(btnBuscarOficio);
            Controls.Add(txtOficio);
            Controls.Add(label4);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(btnBuscarSalario);
            Controls.Add(txtSalario);
            Controls.Add(label1);
            Name = "Form02BuscadorEmpleados";
            Text = "Form02BuscadorEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSalario;
        private Button btnBuscarSalario;
        private Label label2;
        private ListBox lstEmpleados;
        private Button btnBuscarOficio;
        private TextBox txtOficio;
        private Label label4;
    }
}