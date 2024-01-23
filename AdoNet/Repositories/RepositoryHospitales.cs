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
    public class RepositoryHospitales
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryHospitales()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<Hospital> GetHospitales()
        {
            string sql = "SELECT * FROM HOSPITAL";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<Hospital> hospitales = new List<Hospital>();
            while (this.reader.Read())
            {
                string codigoHospital = this.reader["HOSPITAL_COD"].ToString();
                string nombre = this.reader["NOMBRE"].ToString();
                string direccion = this.reader["DIRECCION"].ToString();
                string tlf = this.reader["TELEFONO"].ToString();
                string numCama = this.reader["NUM_CAMA"].ToString();
                hospitales.Add(new Hospital(codigoHospital, nombre, direccion, tlf, numCama));
            }
            this.reader.Close();
            this.cn.Close();
            return hospitales;
        }

        public Hospital FindHospital(string codigo)
        {
            string sql = "SELECT * FROM HOSPITAL WHERE HOSPITAL_COD = @cod";
            SqlParameter paramCod = new SqlParameter("@cod", codigo);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.com.Parameters.Add(paramCod);
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.reader.Read();
            string codigoHospital = this.reader["HOSPITAL_COD"].ToString();
            string nombre = this.reader["NOMBRE"].ToString();
            string direccion = this.reader["DIRECCION"].ToString();
            string tlf = this.reader["TELEFONO"].ToString();
            string numCama = this.reader["NUM_CAMA"].ToString();
            Hospital hospital = new Hospital(codigoHospital, nombre, direccion, tlf, numCama);
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
            return hospital;
        }

        public int CreateHospital(string codigo, string nombre, string direccion, string telefono, string numCamas)
        {
            string sql = "INSERT INTO HOSPITAL VALUES(@cod,@nombre,@direccion,@tlf,@numcamas)";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.com.Parameters.Add(new SqlParameter("@cod", codigo));
            this.com.Parameters.Add(new SqlParameter("@nombre", nombre));
            this.com.Parameters.Add(new SqlParameter("@direccion", direccion));
            this.com.Parameters.Add(new SqlParameter("@tlf", telefono));
            this.com.Parameters.Add(new SqlParameter("@numcamas", numCamas));
            this.cn.Open();
            int result = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return result;
        }

        public int UpdateHospital(string codigo, string nombre, string direccion, string telefono, string numCamas)
        {
            string sql = "UPDATE HOSPITAL SET NOMBRE = @nombre, DIRECCION = @direccion, TELEFONO = @tlf, NUM_CAMA = @numcamas WHERE HOSPITAL_COD = @cod";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.com.Parameters.Add(new SqlParameter("@cod", codigo));
            this.com.Parameters.Add(new SqlParameter("@nombre", nombre));
            this.com.Parameters.Add(new SqlParameter("@direccion", direccion));
            this.com.Parameters.Add(new SqlParameter("@tlf", telefono));
            this.com.Parameters.Add(new SqlParameter("@numcamas", numCamas));
            this.cn.Open();
            int result = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return result;
        }

        public int DeleteHospital(string codigo)
        {
            string sql = "DELETE FROM HOSPITAL WHERE HOSPITAL_COD = @cod";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.com.Parameters.Add(new SqlParameter("@cod", codigo));
            this.cn.Open();
            int result = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return result;
        }
    }
}