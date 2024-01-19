using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdoNet
{
    public partial class Form01PrimerAdo : Form
    {
        // Declaramos objetos de acceso a datos
        private string connectionString;

        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public Form01PrimerAdo()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2023";
            this.cn = new SqlConnection(this.connectionString);
            // Vamos a recuperar un evento de la conexión para que nos indique su cambio de estado
            this.cn.StateChange += Cn_StateChange;
            this.com = new SqlCommand();
        }

        private void Cn_StateChange(object sender, StateChangeEventArgs e)
        {
            this.lblMensaje.Text = "La conexión está pasando de " + e.OriginalState + " a " + e.CurrentState;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cn.State != ConnectionState.Open)
                {
                    // Establecemos la cadena de conexión
                    this.cn.Open();
                    this.lblMensaje.BackColor = Color.LightGreen;
                }
            }
            catch (SqlException ex)
            {
                this.lblMensaje.Text = "Excepcion SQL " + ex.ToString();
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cn.State != ConnectionState.Closed)
                {
                    this.cn.Close();
                    this.lblMensaje.BackColor = Color.PaleVioletRed;
                }
            }
            catch (SqlException ex)
            {
                this.lblMensaje.Text = "Excepcion SQL " + ex.ToString();
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Indicamos la conexión que utilizará el command
            this.com.Connection = this.cn;
            // Creamos consulta
            string sql = "SELECT * FROM EMP";
            // Indicamos el tipo de consulta a ejecutar (texto, procedimiento almacenado, nombre tabla)
            this.com.CommandType = CommandType.Text;
            // Indicamos a command la consulta
            this.com.CommandText = sql;
            // Aquí la conexión debe etar abierta. Ejecutamos la consulta de selección en el command
            // Dicho método nos devuelve un objeto DataReader
            this.reader = this.com.ExecuteReader();

            // Leemos nombre columna
            for (int i = 0; i < this.reader.FieldCount; i++)
            {
                string columna = this.reader.GetName(i);
                string tipoDato = this.reader.GetDataTypeName(i);
                this.lstColumnas.Items.Add(columna);
                this.lstTiposDato.Items.Add(tipoDato);
            }
            // Leemos un registro
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstApellidos.Items.Add(apellido);
            }
            // Siempre cerrar reader tras leer
            this.reader.Close();
        }
    }
}