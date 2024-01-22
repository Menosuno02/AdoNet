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
    public partial class Form04ModificarSalas : Form
    {
        private string connectionString;
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public Form04ModificarSalas()
        {
            InitializeComponent();
            connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.CargarSalas();
        }

        private void CargarSalas()
        {
            this.lstSalas.Items.Clear();
            string sql = "SELECT DISTINCT(NOMBRE) FROM SALA";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                string nomSala = this.reader["NOMBRE"].ToString();
                this.lstSalas.Items.Add(nomSala);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnNuevoNombre_Click(object sender, EventArgs e)
        {
            int index = this.lstSalas.SelectedIndex;
            if (index != 1)
            {
                string nomSala = this.lstSalas.SelectedItem.ToString();
                string nuevoNom = this.txtNombreSala.Text;
                string sql = "UPDATE SALA SET NOMBRE = @nuevonom WHERE NOMBRE = @antiguonom";
                this.com.Connection = this.cn;
                this.com.CommandType = CommandType.Text;
                this.com.CommandText = sql;
                SqlParameter paramAntiguoNom = new SqlParameter("@antiguonom", nomSala);
                SqlParameter paramNuevoNom = new SqlParameter("@nuevonom", nuevoNom);
                this.com.Parameters.Add(paramAntiguoNom);
                this.com.Parameters.Add(paramNuevoNom);
                this.cn.Open();
                int modificados = this.com.ExecuteNonQuery();
                this.cn.Close();
                this.com.Parameters.Clear();
                this.CargarSalas();
                MessageBox.Show("Salas modificadas: " + modificados);
            }
        }
    }
}