using AdoNet.Models;
using AdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

# region PROCEDIMIENTOS

/*
CREATE OR ALTER PROCEDURE SP_EMPLEADOS_DEPARTAMENTO
(@NOMBRE NVARCHAR(50), @SUMA INT OUT, @MEDIA INT OUT, @PERSONAS INT OUT)
AS
	DECLARE @IDDEPARTAMENTO INT
	SELECT @IDDEPARTAMENTO = DEPT_NO
	FROM DEPT
	WHERE DNOMBRE = @NOMBRE
	SELECT *
	FROM EMP
	WHERE DEPT_NO = @IDDEPARTAMENTO
	SELECT @SUMA = SUM(SALARIO), @MEDIA = AVG(SALARIO), @PERSONAS = COUNT(EMP_NO)
	FROM EMP
	WHERE DEPT_NO = @IDDEPARTAMENTO
GO
*/

# endregion

namespace AdoNet
{
    public partial class Form11ParametrosSalida : Form
    {
        private RepositoryParametrosSalida repo;
        private ResumenEmpleados resumen;

        public Form11ParametrosSalida()
        {
            InitializeComponent();
            this.repo = new RepositoryParametrosSalida();
            this.resumen = new ResumenEmpleados();
            this.LoadDepartamentos();
        }

        private void LoadDepartamentos()
        {
            List<string> departs = this.repo.LoadDepartamentos();
            foreach (string depart in departs)
            {
                this.cmbDepartamentos.Items.Add(depart);
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            if (this.cmbDepartamentos.SelectedIndex != -1)
            {
                string nomDept = this.cmbDepartamentos.SelectedItem.ToString();
                ResumenEmpleados resumen = this.repo.GetResumenEmpleados(nomDept);
                this.lstEmpleados.Items.Clear();
                foreach (string emple in resumen.Apellidos)
                {
                    this.lstEmpleados.Items.Add(emple);
                }
                this.txtSuma.Text = resumen.SumaSalarial.ToString();
                this.txtMedia.Text = resumen.MediaSalarial.ToString();
                this.txtPersonas.Text = resumen.Personas.ToString();
            }
        }
    }
}