using AdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region PROCEDIMIENTOS ALMACENADOS

/*
--	Form12HospitalEmpleados
CREATE OR ALTER PROCEDURE SP_HOSPITALES
AS
	SELECT *
	FROM HOSPITAL
GO

CREATE OR ALTER PROCEDURE SP_EMPLEADOS_HOSPITAL
(@NOMBRE_HOSP NVARCHAR(50), @SUMA INT OUT, @MEDIA INT OUT, @EMPLEADOS INT OUT)
AS
	DECLARE @IDHOSPITAL INT
	SELECT @IDHOSPITAL = HOSPITAL_COD
	FROM HOSPITAL
	WHERE NOMBRE = @NOMBRE_HOSP

	SELECT APELLIDO, SALARIO FROM 
	(SELECT APELLIDO, SALARIO, HOSPITAL_COD
	FROM PLANTILLA
	UNION
	SELECT APELLIDO, SALARIO, HOSPITAL_COD
	FROM DOCTOR) AS QUERY
	WHERE QUERY.HOSPITAL_COD = @IDHOSPITAL;

	SELECT @SUMA = ISNULL(SUM(SALARIO), 0), @MEDIA = ISNULL(AVG(SALARIO), 0), @EMPLEADOS = COUNT(APELLIDO) FROM
	(SELECT APELLIDO, SALARIO, HOSPITAL_COD
	FROM PLANTILLA
	UNION
	SELECT APELLIDO, SALARIO, HOSPITAL_COD
	FROM DOCTOR) AS QUERY
	WHERE QUERY.HOSPITAL_COD = @IDHOSPITAL;
GO
 */

#endregion PROCEDIMIENTOS ALMACENADOS

namespace AdoNet.Repositories
{
    public class RepositoryHospitalEmpleados
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryHospitalEmpleados()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<string> LoadHospitales()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_HOSPITALES";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<string> hospitales = new List<string>();
            while (this.reader.Read())
            {
                hospitales.Add(this.reader["NOMBRE"].ToString());
            }
            this.reader.Close();
            this.cn.Close();
            return hospitales;
        }

        public DatosHospital GetDatosHospital(string hospNom)
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_EMPLEADOS_HOSPITAL";
            SqlParameter paramNomHospital = new SqlParameter("@NOMBRE_HOSP", hospNom);
            this.com.Parameters.Add(paramNomHospital);
            SqlParameter paramSuma = new SqlParameter("@SUMA", 0);
            paramSuma.Direction = ParameterDirection.Output;
            SqlParameter paramMedia = new SqlParameter("@MEDIA", 0);
            paramMedia.Direction = ParameterDirection.Output;
            SqlParameter paramEmpleados = new SqlParameter("@EMPLEADOS", 0);
            paramEmpleados.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(paramSuma);
            this.com.Parameters.Add(paramMedia);
            this.com.Parameters.Add(paramEmpleados);
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            DatosHospital datosHospital = new DatosHospital();
            while (this.reader.Read())
            {
                datosHospital.DatosEmpleados.Add(this.reader["APELLIDO"].ToString() + " - " + this.reader["SALARIO"].ToString());
            }
            this.reader.Close();
            datosHospital.SumaSalarial = int.Parse(paramSuma.Value.ToString());
            datosHospital.MediaSalarial = int.Parse(paramMedia.Value.ToString());
            datosHospital.Empleados = int.Parse(paramEmpleados.Value.ToString());
            this.cn.Close();
            this.com.Parameters.Clear();
            return datosHospital;
        }
    }
}