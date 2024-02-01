using AdoNet.Helpers;
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
    public class RepositoryParametrosSalida
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryParametrosSalida()
        {
            string connectionString = HelperConfiguration.GetConnectionString();
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<string> LoadDepartamentos()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_DEPARTAMENTOS";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<string> departamentos = new List<string>();
            while (this.reader.Read())
            {
                departamentos.Add(this.reader["DNOMBRE"].ToString());
            }
            this.reader.Close();
            this.cn.Close();
            return departamentos;
        }

        public ResumenEmpleados GetResumenEmpleados(string dnombre)
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_EMPLEADOS_DEPARTAMENTO";
            this.com.Parameters.Add(new SqlParameter("@NOMBRE", dnombre));
            // Un parámetro de salida no lleva valor, lo recuperamos en el procedimiento
            // Dirección del parámetro -> ParameterDirection.Output
            SqlParameter paramSuma = new SqlParameter();
            paramSuma.Value = 0;
            paramSuma.ParameterName = "@SUMA";
            paramSuma.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(paramSuma);
            SqlParameter paramMedia = new SqlParameter();
            paramMedia.Value = 0;
            paramMedia.ParameterName = "@MEDIA";
            paramMedia.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(paramMedia);
            SqlParameter paramPersonas = new SqlParameter();
            paramPersonas.Value = 0;
            paramPersonas.ParameterName = "@PERSONAS";
            paramPersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(paramPersonas);
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            ResumenEmpleados resumen = new ResumenEmpleados();
            while (this.reader.Read())
            {
                resumen.Apellidos.Add(this.reader["APELLIDO"].ToString());
            }
            this.reader.Close();
            /*
             * Si no ponemos las variables a 0 en el constructor del modelo
             * int suma = 0;
             * int media = 0;
             * int personas = 0;
             * resumen.SumaSalarial = suma;
             * resumen.MediaSalarial = media;
             * resumen.Personas = personas;

            if (resumen.Apellidos.Count != 0)
            {
                // Capturar parámetros tras cerrar el reader
                resumen.SumaSalarial = int.Parse(paramSuma.Value.ToString());
                resumen.MediaSalarial = int.Parse(paramMedia.Value.ToString());
                resumen.Personas = int.Parse(paramPersonas.Value.ToString());
            }
            */

            resumen.SumaSalarial = int.Parse(paramSuma.Value.ToString());
            resumen.MediaSalarial = int.Parse(paramMedia.Value.ToString());
            resumen.Personas = int.Parse(paramPersonas.Value.ToString());
            this.cn.Close();
            this.com.Parameters.Clear();
            return resumen;
        }
    }
}