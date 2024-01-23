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
    public class RepositoryDepartamentos
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryDepartamentos()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<Departamento> GetDepartamentos()
        {
            string sql = "SELECT * FROM DEPT";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<Departamento> departamentos = new List<Departamento>();
            while (this.reader.Read())
            {
                int id = int.Parse(this.reader["DEPT_NO"].ToString());
                string dnombre = this.reader["DNOMBRE"].ToString();
                string loc = this.reader["LOC"].ToString();
                Departamento dept = new Departamento();
                dept.IdDepartamento = id;
                dept.Nombre = dnombre;
                dept.Localidad = loc;
                departamentos.Add(dept);
            }
            this.reader.Close();
            this.cn.Close();
            return departamentos;
        }

        public Departamento FindDepartamento(int idDepartamento)
        {
            string sql = "SELECT * FROM DEPT WHERE DEPT_NO = @id";
            SqlParameter pamId = new SqlParameter("@id", idDepartamento);
            this.com.Parameters.Add(pamId);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.reader.Read();
            int id = int.Parse(this.reader["DEPT_NO"].ToString());
            string nombre = this.reader["DNOMBRE"].ToString();
            string loc = this.reader["LOC"].ToString();
            Departamento departamento = new Departamento();
            departamento.IdDepartamento = id;
            departamento.Nombre = nombre;
            departamento.Localidad = loc;
            this.reader.Close();
            this.com.Parameters.Clear();
            this.cn.Close();
            return departamento;
        }

        public int InsertarDepartamento(int id, string nombre, string localidad)
        {
            string sql = "INSERT INTO DEPT VALUES(@id, @nombre, @loc)";
            SqlParameter paramId = new SqlParameter("@id", id);
            SqlParameter paramNom = new SqlParameter("@nombre", nombre);
            SqlParameter paramLoc = new SqlParameter("@loc", localidad);
            this.com.Parameters.Add(paramId);
            this.com.Parameters.Add(paramNom);
            this.com.Parameters.Add(paramLoc);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int results = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return results;
        }

        public int UpdateDepartamento(int id, string nombre, string localidad)
        {
            string sql = "UPDATE DEPT SET DNOMBRE = @nombre, LOC = @loc WHERE DEPT_NO = @id";
            SqlParameter paramId = new SqlParameter("@id", id);
            SqlParameter paramNombre = new SqlParameter("@nombre", nombre);
            SqlParameter paramLoc = new SqlParameter("@loc", localidad);
            this.com.Parameters.Add(paramId);
            this.com.Parameters.Add(paramNombre);
            this.com.Parameters.Add(paramLoc);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int resultados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return resultados;
        }

        public int DeleteDepartamento(int id)
        {
            string sql = "DELETE FROM DEPT WHERE DEPT_NO = @id";
            SqlParameter paramId = new SqlParameter("@id", id);
            this.com.Parameters.Add(paramId);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int resultados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return resultados;
        }
    }
}