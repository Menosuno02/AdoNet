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
    public partial class Form06DepartamentosClases : Form
    {
        private RepositoryDepartamentos repo;
        private List<int> idsDepartamentoList;

        public Form06DepartamentosClases()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentos();
            this.idsDepartamentoList = new List<int>();
            LoadDepartamentos();
        }

        private void LoadDepartamentos()
        {
            List<Departamento> departamentos = this.repo.GetDepartamentos();
            this.lstDept.Items.Clear();
            this.idsDepartamentoList.Clear();
            foreach (Departamento dept in departamentos)
            {
                this.idsDepartamentoList.Add(dept.IdDepartamento);
                this.lstDept.Items.Add(dept.IdDepartamento + " - " + dept.Nombre + " - " + dept.Localidad);
            }
        }

        private void lstDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstDept.SelectedIndex;
            if (index != -1)
            {
                int id = this.idsDepartamentoList[index];
                Departamento dept = this.repo.FindDepartamento(id);
                this.txtId.Text = dept.IdDepartamento.ToString();
                this.txtNombre.Text = dept.Nombre.ToString();
                this.txtLoc.Text = dept.Localidad.ToString();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLoc.Text;
            int insertados = this.repo.InsertarDepartamento(id, nombre, localidad);
            this.LoadDepartamentos();
            MessageBox.Show("Departamentos insertados: " + insertados);
        }
    }
}