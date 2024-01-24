using AdoNet.Models;
using AdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form08OficiosModels : Form
    {
        private RepositoryOficios repo;

        public Form08OficiosModels()
        {
            InitializeComponent();
            this.repo = new RepositoryOficios();
            LoadOficios();
        }

        private void lstOficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstOficios.SelectedIndex != -1)
            {
                this.lstApellidos.Items.Clear();
                string oficio = this.lstOficios.SelectedItem.ToString();
                List<string> empleados = this.repo.GetEmpleadosPorOficio(oficio);
                foreach (string empleado in empleados)
                {
                    this.lstApellidos.Items.Add(empleado);
                }
                DatosEmpleadosOficio datos = repo.GetDatosEmpleadosOficio(oficio);
                this.txtSuma.Text = datos.SumaSalarial.ToString();
                this.txtMedia.Text = datos.MediaSalarial.ToString();
                this.txtMin.Text = datos.MinimoSalario.ToString();
            }
        }

        private void LoadOficios()
        {
            this.lstOficios.Items.Clear();
            List<string> oficios = this.repo.GetOficios();
            foreach (string oficio in oficios)
            {
                this.lstOficios.Items.Add(oficio);
            }
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            if (this.lstOficios.SelectedIndex != -1)
            {
                string oficio = this.lstOficios.SelectedItem.ToString();
                int incremento = int.Parse(this.txtIncremento.Text);
                int filas = this.repo.IncrementarSalariosOficio(oficio, incremento);
                DatosEmpleadosOficio datos = repo.GetDatosEmpleadosOficio(oficio);
                this.txtSuma.Text = datos.SumaSalarial.ToString();
                this.txtMedia.Text = datos.MediaSalarial.ToString();
                this.txtMin.Text = datos.MinimoSalario.ToString();
                MessageBox.Show("Salario de " + filas + " empleados incrementado en " + incremento);
            }
        }
    }
}