using AdoNet.Models;
using AdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form12HospitalEmpleados : Form
    {
        private RepositoryHospitalEmpleados repo;

        public Form12HospitalEmpleados()
        {
            InitializeComponent();
            this.repo = new RepositoryHospitalEmpleados();
            List<string> hospitales = this.repo.LoadHospitales();
            foreach (string hospital in hospitales)
            {
                this.cmbHospitales.Items.Add(hospital);
            }
        }

        private void cmbHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHospitales.SelectedIndex != -1)
            {
                string nomHospital = this.cmbHospitales.SelectedItem.ToString();
                DatosHospital datosHospital = this.repo.GetDatosHospital(nomHospital);
                this.lstEmpleados.Items.Clear();
                foreach (string emple in datosHospital.DatosEmpleados)
                {
                    this.lstEmpleados.Items.Add(emple);
                }
                this.txtSuma.Text = datosHospital.SumaSalarial.ToString();
                this.txtMedia.Text = datosHospital.MediaSalarial.ToString();
                this.txtEmpleados.Text = datosHospital.Empleados.ToString();
            }
        }
    }
}