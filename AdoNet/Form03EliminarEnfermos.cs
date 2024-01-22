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
    public partial class Form03EliminarEnfermos : Form
    {
        private string connectionString;
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public Form03EliminarEnfermos()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2023";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            this.CargarEnfermos();
        }

        private void btnEliminarEnfermo_Click(object sender, EventArgs e)
        {
            string inscripcion = this.txtInscripcion.Text;
            string sql = "DELETE FROM ENFERMO WHERE INSCRIPCION = @inscripcion";

            SqlParameter paramInscripcion = new SqlParameter();
            paramInscripcion.ParameterName = "inscripcion";
            paramInscripcion.Value = inscripcion;
            paramInscripcion.DbType = DbType.String;
            // Direction por defecto es INPUT, no es necesario a no ser que lo deseemos modificar
            paramInscripcion.Direction = ParameterDirection.Input;
            // SqlParameter paramInscripcion = new SqlParameter("@inscripcion", inscripcion);
            this.com.Parameters.Add(paramInscripcion);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            // Las consultas de acción devuelven el número de registros afectados
            int eliminados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            this.CargarEnfermos();
            MessageBox.Show("Enfermos eliminados: " + eliminados);
        }

        private void CargarEnfermos()
        {
            this.lstEnfermos.Items.Clear();
            string sql = "SELECT * FROM ENFERMO";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                string enfermo = this.reader["APELLIDO"].ToString();
                string inscripcion = this.reader["INSCRIPCION"].ToString();
                this.lstEnfermos.Items.Add(enfermo + " (" + inscripcion + ")");
            }
            this.reader.Close();
            this.cn.Close();
        }
    }
}