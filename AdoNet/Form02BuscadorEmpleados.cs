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
    public partial class Form02BuscadorEmpleados : Form
    {
        private string connectionString;
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public Form02BuscadorEmpleados()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2023";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
        }

        private void btnBuscarSalario_Click(object sender, EventArgs e)
        {
            int salario = int.Parse(this.txtSalario.Text);
            string sql = "SELECT * FROM EMP WHERE SALARIO >= " + salario;
            // Siempre que trabajemos con acceso a datos se utiliza el método entrar-salir
            // Abrimos la conexión, usamos lo que necesitemos y posteriormente cerrar todos los recursos utilizados
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string salar = this.reader["SALARIO"].ToString();
                this.lstEmpleados.Items.Add(apellido + " -> " + salar + "€");
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void buttonBuscarOficio_Click(object sender, EventArgs e)
        {
            string oficio = this.txtOficio.Text;
            string sql = "SELECT * FROM EMP WHERE OFICIO = '" + oficio + "'";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string ofi = this.reader["OFICIO"].ToString();
                this.lstEmpleados.Items.Add(apellido + " -> " + ofi);
            }
            this.reader.Close();
            this.cn.Close();
        }
    }
}