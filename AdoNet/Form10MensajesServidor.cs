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
CREATE OR ALTER PROCEDURE SP_DEPARTAMENTOS
AS
	SELECT DEPT_NO, DNOMBRE, LOC
	FROM DEPT
GO

CREATE OR ALTER PROCEDURE SP_INSERT_DEPARTAMENTO
(@DEPT_NO INT, @DNOMBRE NVARCHAR(50), @LOC NVARCHAR(50))
AS
	INSERT INTO DEPT
	VALUES(@DEPT_NO, @DNOMBRE, @LOC)
GO
*/

#endregion PROCEDIMIENTOS ALMACENADOS

namespace AdoNet
{
    public partial class Form10MensajesServidor : Form
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public Form10MensajesServidor()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.CargarDept();
        }

        private void CargarDept()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_DEPARTAMENTOS";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstDepartamentos.Items.Clear();
            while (this.reader.Read())
            {
                string dept_no = this.reader["DEPT_NO"].ToString();
                string dnombre = this.reader["DNOMBRE"].ToString();
                string loc = this.reader["LOC"].ToString();
                this.lstDepartamentos.Items.Add(dept_no + " - " + dnombre + " - " + loc);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int dept_no = int.Parse(this.txtNumero.Text);
            string dnombre = this.txtNombre.Text;
            string loc = this.txtLocalidad.Text;
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_INSERT_DEPARTAMENTO";
            this.com.Parameters.Add(new SqlParameter("@DEPT_NO", dept_no));
            this.com.Parameters.Add(new SqlParameter("@DNOMBRE", dnombre));
            this.com.Parameters.Add(new SqlParameter("@LOC", loc));
            this.cn.Open();
            int numDept = this.com.ExecuteNonQuery();
            this.com.Parameters.Clear();
            this.reader.Close();
            this.cn.Close();
            this.CargarDept();
            this.lblMensajesServidor.Text = "Dept insertados: " + numDept.ToString();
        }
    }
}