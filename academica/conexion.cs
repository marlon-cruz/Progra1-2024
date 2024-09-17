using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //para usar BDD
using System.Data.SqlClient;//para sql server
namespace academica
{
   internal class conexion
    {
        SqlConnection miConexion = new SqlConnection();//Conectarme a la BD.
        SqlCommand misComandos = new SqlCommand();//ejecutar SQL en la BD.
        SqlDataAdapter miAdaptador = new SqlDataAdapter();//Intermediario entre mi BD y la aplicacion.
        DataSet ds = new DataSet();//es la representacion grafica de la BD en memoria RAM.

        public conexion()
        {
            String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academica.mdf;Integrated Security=True";
            miConexion.ConnectionString = cadenaConexion;
            miConexion.Open();
        }

        public DataSet obtenerDatos()
        {
            ds.Clear();
            misComandos.Connection = miConexion;

            misComandos.CommandText = "SELECT * FROM alumnos";
            miAdaptador.SelectCommand = misComandos;
            miAdaptador.Fill(ds, "alumnos");

            return ds;
        }
    }
    
}
