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
            int index = this.lstOficios.SelectedIndex;
            if (index != -1)
            {
                this.lstApellidos.Items.Clear();
                string oficio = this.lstOficios.SelectedItem.ToString();
                List<Empleado> empleados = this.repo.GetEmpleadosPorOficio(oficio);
                foreach (Empleado empleado in empleados)
                {
                    this.lstApellidos.Items.Add(empleado.Apellido);
                }
                this.txtSuma.Text = repo.GetSumSalarioOficio(oficio).ToString();
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
            int index = this.lstOficios.SelectedIndex;
            if (index != -1)
            {
                string oficio = this.lstOficios.SelectedItem.ToString();
                int incremento = int.Parse(this.txtIncremento.Text);
                int filas = this.repo.IncrementarSalariosOficio(oficio, incremento);
                this.txtSuma.Text = repo.GetSumSalarioOficio(oficio).ToString();
                MessageBox.Show("Salarios de " + filas + " empleados incrementado en " + incremento);
            }
        }
    }
}