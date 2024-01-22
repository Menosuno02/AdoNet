namespace AdoNet
{
    partial class Form03EliminarEnfermos
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
            txtInscripcion = new TextBox();
            btnEliminarEnfermo = new Button();
            label2 = new Label();
            lstEnfermos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Inscripción";
            // 
            // txtInscripcion
            // 
            txtInscripcion.Location = new Point(12, 27);
            txtInscripcion.Name = "txtInscripcion";
            txtInscripcion.Size = new Size(126, 23);
            txtInscripcion.TabIndex = 1;
            // 
            // btnEliminarEnfermo
            // 
            btnEliminarEnfermo.Location = new Point(12, 56);
            btnEliminarEnfermo.Name = "btnEliminarEnfermo";
            btnEliminarEnfermo.Size = new Size(126, 23);
            btnEliminarEnfermo.TabIndex = 2;
            btnEliminarEnfermo.Text = "Eliminar";
            btnEliminarEnfermo.UseVisualStyleBackColor = true;
            btnEliminarEnfermo.Click += btnEliminarEnfermo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 9);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Enfermos";
            // 
            // lstEnfermos
            // 
            lstEnfermos.FormattingEnabled = true;
            lstEnfermos.ItemHeight = 15;
            lstEnfermos.Location = new Point(163, 27);
            lstEnfermos.Name = "lstEnfermos";
            lstEnfermos.Size = new Size(153, 169);
            lstEnfermos.TabIndex = 4;
            // 
            // Form03EliminarEnfermos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 208);
            Controls.Add(lstEnfermos);
            Controls.Add(label2);
            Controls.Add(btnEliminarEnfermo);
            Controls.Add(txtInscripcion);
            Controls.Add(label1);
            Name = "Form03EliminarEnfermos";
            Text = "Form03EliminarEnfermos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInscripcion;
        private Button btnEliminarEnfermo;
        private Label label2;
        private ListBox lstEnfermos;
    }
}