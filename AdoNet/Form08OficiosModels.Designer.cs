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
            txtMedia = new TextBox();
            txtMin = new TextBox();
            label6 = new Label();
            label7 = new Label();
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
            lstOficios.Size = new Size(120, 244);
            lstOficios.TabIndex = 1;
            lstOficios.SelectedIndexChanged += lstOficios_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 9);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "Empleados";
            // 
            // lstApellidos
            // 
            lstApellidos.FormattingEnabled = true;
            lstApellidos.ItemHeight = 15;
            lstApellidos.Location = new Point(146, 27);
            lstApellidos.Name = "lstApellidos";
            lstApellidos.Size = new Size(143, 154);
            lstApellidos.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 193);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 4;
            label3.Text = "Suma";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(189, 190);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 283);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 6;
            label4.Text = "Incremento";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(12, 301);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(120, 23);
            txtIncremento.TabIndex = 7;
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(145, 301);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(143, 23);
            btnIncrementar.TabIndex = 8;
            btnIncrementar.Text = "Incrementar salario";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(189, 219);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(100, 23);
            txtMedia.TabIndex = 10;
            // 
            // txtMin
            // 
            txtMin.Location = new Point(189, 248);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(100, 23);
            txtMin.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(143, 222);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 12;
            label6.Text = "Media";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(145, 251);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 13;
            label7.Text = "Min";
            // 
            // Form08OficiosModels
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 342);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtMin);
            Controls.Add(txtMedia);
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
        private TextBox txtMedia;
        private TextBox txtMin;
        private Label label6;
        private Label label7;
    }
}