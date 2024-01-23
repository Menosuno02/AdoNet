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
    public partial class Form07HospitalesCRUD : Form
    {
        private RepositoryHospitales repo;
        private List<string> codHospitales;

        public Form07HospitalesCRUD()
        {
            InitializeComponent();
            this.repo = new RepositoryHospitales();
            this.codHospitales = new List<string>();
            LoadHospitales();
        }

        private void lstHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstHospitales.SelectedIndex;
            if (index != -1)
            {
                string cod = this.codHospitales[index];
                Hospital hospital = this.repo.FindHospital(cod);
                this.txtCodigo.Text = hospital.CodigoHospital;
                this.txtDireccion.Text = hospital.Direccion;
                this.txtNombre.Text = hospital.Nombre;
                this.txtTelefono.Text = hospital.Telefono;
                this.txtNumCamas.Text = hospital.NumCama;
            }
        }

        private void LoadHospitales()
        {
            List<Hospital> hospitales = this.repo.GetHospitales();
            this.lstHospitales.Items.Clear();
            this.codHospitales.Clear();
            foreach (Hospital hosp in hospitales)
            {
                this.codHospitales.Add(hosp.CodigoHospital);
                this.lstHospitales.Items.Add(hosp.Nombre);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string codHospital = this.txtCodigo.Text;
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            string numCama = this.txtNumCamas.Text;
            int result = this.repo.CreateHospital(codHospital, nombre, direccion, telefono, numCama);
            this.LoadHospitales();
            MessageBox.Show("Hospitales creados: " + result);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string codHospital = this.txtCodigo.Text;
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            string numCama = this.txtNumCamas.Text;
            int result = this.repo.UpdateHospital(codHospital, nombre, direccion, telefono, numCama);
            this.LoadHospitales();
            MessageBox.Show("Hospitales modificados: " + result);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = this.lstHospitales.SelectedIndex;
            if (index != -1)
            {
                string cod = this.codHospitales[index];
                int result = this.repo.DeleteHospital(cod);
                this.LoadHospitales();
                MessageBox.Show("Hospitales eliminados: " + result);
            }
        }
    }
}