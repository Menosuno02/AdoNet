namespace AdoNet
{
    partial class Form05DepartamentosEmpleados
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
            lstDept = new ListBox();
            label2 = new Label();
            lstEmple = new ListBox();
            label3 = new Label();
            txtOficio = new TextBox();
            label4 = new Label();
            txtSalario = new TextBox();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // lstDept
            // 
            lstDept.FormattingEnabled = true;
            lstDept.ItemHeight = 15;
            lstDept.Location = new Point(12, 27);
            lstDept.Name = "lstDept";
            lstDept.Size = new Size(120, 154);
            lstDept.TabIndex = 1;
            lstDept.SelectedIndexChanged += lstDept_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 9);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "Empleados";
            // 
            // lstEmple
            // 
            lstEmple.FormattingEnabled = true;
            lstEmple.ItemHeight = 15;
            lstEmple.Location = new Point(167, 27);
            lstEmple.Name = "lstEmple";
            lstEmple.Size = new Size(120, 154);
            lstEmple.TabIndex = 3;
            lstEmple.SelectedIndexChanged += lstEmple_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 9);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Oficio";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(330, 27);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(100, 23);
            txtOficio.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(330, 75);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 6;
            label4.Text = "Salario";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(330, 93);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(100, 23);
            txtSalario.TabIndex = 7;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(330, 158);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 23);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Modificar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form05DepartamentosEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 197);
            Controls.Add(btnUpdate);
            Controls.Add(txtSalario);
            Controls.Add(label4);
            Controls.Add(txtOficio);
            Controls.Add(label3);
            Controls.Add(lstEmple);
            Controls.Add(label2);
            Controls.Add(lstDept);
            Controls.Add(label1);
            Name = "Form05DepartamentosEmpleados";
            Text = "Form05DepartamentosEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstDept;
        private Label label2;
        private ListBox lstEmple;
        private Label label3;
        private TextBox txtOficio;
        private Label label4;
        private TextBox txtSalario;
        private Button btnUpdate;
    }
}