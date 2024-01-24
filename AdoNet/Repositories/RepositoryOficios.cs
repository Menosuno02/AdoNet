using AdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Repositories
{
    public class RepositoryOficios
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryOficios()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<string> GetOficios()
        {
            string sql = "SELECT DISTINCT(OFICIO) FROM EMP";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<string> oficios = new List<string>();
            while (this.reader.Read())
            {
                string oficio = this.reader["OFICIO"].ToString();
                oficios.Add(oficio);
            }
            this.reader.Close();
            this.cn.Close();
            return oficios;
        }

        public List<string> GetEmpleadosPorOficio(string oficio)
        {
            string sql = "SELECT APELLIDO FROM EMP WHERE OFICIO = @oficio";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.com.Parameters.Add(new SqlParameter("@oficio", oficio));
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<string> empleados = new List<string>();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                empleados.Add(apellido);
            }
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
            return empleados;
        }

        public DatosEmpleadosOficio GetDatosEmpleadosOficio(string oficio)
        {
            string sql = "SELECT SUM(SALARIO) AS SUMA, AVG(SALARIO) AS MEDIA, MIN(SALARIO) AS MINIMO, OFICIO " +
                "FROM EMP GROUP BY OFICIO HAVING OFICIO = @oficio";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.com.Parameters.Add(new SqlParameter("@oficio", oficio));
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.reader.Read();
            DatosEmpleadosOficio datos = new DatosEmpleadosOficio();
            datos.SumaSalarial = int.Parse(this.reader["SUMA"].ToString());
            datos.MediaSalarial = int.Parse(this.reader["MEDIA"].ToString());
            datos.MinimoSalario = int.Parse(this.reader["MINIMO"].ToString());
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
            return datos;
        }

        public int IncrementarSalariosOficio(string oficio, int incremento)
        {
            string sql = "UPDATE EMP SET SALARIO = SALARIO + @incremento WHERE OFICIO = @oficio";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.com.Parameters.Add(new SqlParameter("@incremento", incremento));
            this.com.Parameters.Add(new SqlParameter("@oficio", oficio));
            this.cn.Open();
            int filas = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return filas;
        }
    }
}