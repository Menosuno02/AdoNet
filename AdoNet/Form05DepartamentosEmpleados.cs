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
    public partial class Form05DepartamentosEmpleados : Form
    {
        private string connectionString;
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public Form05DepartamentosEmpleados()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.CargarDept();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.lstEmple.SelectedIndex != -1)
            {
                string emple = this.lstEmple.SelectedItem.ToString();
                string oficio = this.txtOficio.Text;
                int salario = Convert.ToInt32(this.txtSalario.Text);
                string sql = "UPDATE EMP SET OFICIO = @oficio, SALARIO = @salario WHERE APELLIDO = @emple";
                this.com.Connection = this.cn;
                this.com.CommandType = CommandType.Text;
                this.com.CommandText = sql;
                this.com.Parameters.Add(new SqlParameter("@oficio", oficio));
                this.com.Parameters.Add(new SqlParameter("@salario", salario));
                this.com.Parameters.Add(new SqlParameter("@emple", emple));
                this.cn.Open();
                this.com.ExecuteNonQuery();
                this.com.Parameters.Clear();
                this.cn.Close();
            }
        }

        private void CargarDept()
        {
            this.lstDept.Items.Clear();
            string sql = "SELECT * FROM DEPT";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                string dept = this.reader["DNOMBRE"].ToString();
                this.lstDept.Items.Add(dept);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void lstDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstDept.SelectedIndex != -1)
            {
                this.lstEmple.Items.Clear();
                string dept = this.lstDept.SelectedItem.ToString();
                string sql = "SELECT * FROM EMP WHERE DEPT_NO = (SELECT DEPT_NO FROM DEPT WHERE DNOMBRE = @dnombre)";
                this.com.Connection = this.cn;
                this.com.CommandType = CommandType.Text;
                this.com.CommandText = sql;
                SqlParameter paramDept = new SqlParameter("@dnombre", dept);
                this.com.Parameters.Add(paramDept);
                this.cn.Open();
                this.reader = this.com.ExecuteReader();
                while (this.reader.Read())
                {
                    string emp = this.reader["APELLIDO"].ToString();
                    this.lstEmple.Items.Add(emp);
                }
                this.com.Parameters.Clear();
                this.reader.Close();
                this.cn.Close();
            }
        }

        private void lstEmple_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstEmple.SelectedIndex != -1)
            {
                string emple = this.lstEmple.SelectedItem.ToString();
                string sql = "SELECT * FROM EMP WHERE APELLIDO = @emple";
                this.com.Connection = this.cn;
                this.com.CommandType = CommandType.Text;
                this.com.CommandText = sql;
                SqlParameter paramEmple = new SqlParameter("@emple", emple);
                this.com.Parameters.Add(paramEmple);
                this.cn.Open();
                this.reader = this.com.ExecuteReader();
                while (this.reader.Read())
                {
                    this.txtOficio.Text = this.reader["OFICIO"].ToString();
                    this.txtSalario.Text = this.reader["SALARIO"].ToString();
                }
                this.com.Parameters.Clear();
                this.reader.Close();
                this.cn.Close();
            }
        }
    }
}