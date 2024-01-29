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

#region PROCEDIMIENTOS ALMACENADOS

/*
CREATE OR ALTER PROCEDURE SP_HOSPITALES
AS
	SELECT *
	FROM HOSPITAL
GO

CREATE OR ALTER PROCEDURE SP_UPDATE_PLANTILLA_HOSPITAL
(@NOM_HOSPITAL NVARCHAR(50))
AS
	DECLARE @CODIGO_HOSPITAL INT
	SELECT @CODIGO_HOSPITAL = HOSPITAL_COD
	FROM HOSPITAL
	WHERE NOMBRE = @NOM_HOSPITAL

	DECLARE @SUMA_SALARIO_HOSPITAL INT
	SELECT @SUMA_SALARIO_HOSPITAL = SUM(SALARIO)
	FROM PLANTILLA
	WHERE HOSPITAL_COD = @CODIGO_HOSPITAL

	DECLARE @MOD_SALARIO INT
	IF (@SUMA_SALARIO_HOSPITAL >= 1000000)
	BEGIN
		PRINT 'BAJANDO SALARIOS'
		SET @MOD_SALARIO = -1000
	END
	ELSE
	BEGIN
		PRINT 'SUBIENDO SALARIOS'
		SET @MOD_SALARIO = 1000
	END

	UPDATE PLANTILLA
	SET SALARIO = SALARIO + @MOD_SALARIO
	WHERE HOSPITAL_COD = @CODIGO_HOSPITAL
	SELECT *
	FROM PLANTILLA
	WHERE HOSPITAL_COD = @CODIGO_HOSPITAL
GO
*/

#endregion PROCEDIMIENTOS ALMACENADOS

namespace AdoNet
{
    public partial class Form09ProcedimientoUpdatePlantilla : Form
    {
        private SqlCommand com;
        private SqlConnection cn;
        private SqlDataReader reader;

        public Form09ProcedimientoUpdatePlantilla()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_HOSPITALES";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                this.cmbHospitales.Items.Add(this.reader["NOMBRE"].ToString());
            }

            this.reader.Close();
            this.cn.Close();
        }

        private void btnUpdateSalarios_Click(object sender, EventArgs e)
        {
            if (this.cmbHospitales.SelectedIndex != -1)
            {
                string nomHospital = this.cmbHospitales.SelectedItem.ToString();
                this.com.CommandType = CommandType.StoredProcedure;
                this.com.CommandText = "SP_UPDATE_PLANTILLA_HOSPITAL";
                this.com.Parameters.Add(new SqlParameter("@NOM_HOSPITAL", nomHospital));
                this.cn.Open();
                this.reader = this.com.ExecuteReader();
                this.lstPlantilla.Items.Clear();
                while (this.reader.Read())
                {
                    string apellido = this.reader["APELLIDO"].ToString();
                    string funcion = this.reader["FUNCION"].ToString();
                    string salario = this.reader["SALARIO"].ToString();
                    this.lstPlantilla.Items.Add(apellido + " (" + funcion + ") - " + salario);
                }
                this.com.Parameters.Clear();
                this.reader.Close();
                this.cn.Close();
            }
        }
    }
}