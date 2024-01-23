namespace AdoNet
{
    partial class Form08OficiosModels
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
            lstOficios = new ListBox();
            label2 = new Label();
            lstApellidos = new ListBox();
            label3 = new Label();
            txtSuma = new TextBox();
            label4 = new Label();
            txtIncremento = new TextBox();
            btnIncrementar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Oficios";
            // 
            // lstOficios
            // 
            lstOficios.FormattingEnabled = true;
            lstOficios.ItemHeight = 15;
            lstOficios.Location = new Point(12, 27);
            lstOficios.Name = "lstOficios";
            lstOficios.Size = new Size(120, 199);
            lstOficios.TabIndex = 1;
            lstOficios.SelectedIndexChanged += lstOficios_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 9);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "Empleados";
            // 
            // lstApellidos
            // 
            lstApellidos.FormattingEnabled = true;
            lstApellidos.ItemHeight = 15;
            lstApellidos.Location = new Point(169, 27);
            lstApellidos.Name = "lstApellidos";
            lstApellidos.Size = new Size(120, 154);
            lstApellidos.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 185);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 4;
            label3.Text = "Suma salarial";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(169, 203);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(120, 23);
            txtSuma.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 238);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 6;
            label4.Text = "Incremento";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(12, 256);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(120, 23);
            txtIncremento.TabIndex = 7;
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(146, 256);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(143, 23);
            btnIncrementar.TabIndex = 8;
            btnIncrementar.Text = "Incrementar salario";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // Form08OficiosModels
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 297);
            Controls.Add(btnIncrementar);
            Controls.Add(txtIncremento);
            Controls.Add(label4);
            Controls.Add(txtSuma);
            Controls.Add(label3);
            Controls.Add(lstApellidos);
            Controls.Add(label2);
            Controls.Add(lstOficios);
            Controls.Add(label1);
            Name = "Form08OficiosModels";
            Text = "Form08OficiosModels";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstOficios;
        private Label label2;
        private ListBox lstApellidos;
        private Label label3;
        private TextBox txtSuma;
        private Label label4;
        private TextBox txtIncremento;
        private Button btnIncrementar;
    }
}