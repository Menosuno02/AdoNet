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

        public List<Empleado> GetEmpleadosPorOficio(string oficio)
        {
            string sql = "SELECT * FROM EMP WHERE OFICIO = @oficio";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.com.Parameters.Add(new SqlParameter("@oficio", oficio));
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<Empleado> empleados = new List<Empleado>();
            while (this.reader.Read())
            {
                int empNo = int.Parse(this.reader["EMP_NO"].ToString());
                string apellido = this.reader["APELLIDO"].ToString();
                string of = this.reader["OFICIO"].ToString();
                string dir = this.reader["DIR"].ToString();
                DateTime fechaAlta = DateTime.Parse(this.reader["FECHA_ALT"].ToString());
                int salario = int.Parse(this.reader["SALARIO"].ToString());
                int comision = int.Parse(this.reader["COMISION"].ToString());
                int deptNo = int.Parse(this.reader["DEPT_NO"].ToString());
                empleados.Add(new Empleado(empNo, apellido, oficio, dir, fechaAlta, salario, comision, deptNo));
            }
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
            return empleados;
        }

        public int GetSumSalarioOficio(string oficio)
        {
            string sql = "SELECT SUM(SALARIO) AS SUMA FROM EMP WHERE OFICIO = @oficio";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.com.Parameters.Add(new SqlParameter("@oficio", oficio));
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.reader.Read();
            int sumSalarios = int.Parse(this.reader["SUMA"].ToString());
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
            return sumSalarios;
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