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

namespace academica
{
    public partial class login : Form
    {
        Conexion objConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable miTabla = new DataTable();
        public login()
        {
            InitializeComponent();
        }
        private void login_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }

        private void actualizarDs()
        {
            ds.Clear();
            ds = objConexion.obtenerDatos();
            miTabla = ds.Tables["usuarios"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idUsuario"] };

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtContraseña.Text == "" || txtUsuario.Text == "")
                {
                    MessageBox.Show("Ingrese sus credenciales");
                }
                else
                {
                    string[] datos =
                    {
                        "iniciar", txtUsuario.Text,txtContraseña.Text
                    };

                 string respuesta = objConexion.administrarUsuarios(datos);

                    if (respuesta != "1")
                    {
                        principal objForm = new principal();
                        objForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrecta");
                    }
                }



            }
            catch (Exception)
            {
                MessageBox.Show("asada");
                throw;
            }
        }


    }
}

