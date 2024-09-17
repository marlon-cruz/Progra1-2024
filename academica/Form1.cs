using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data; //para usar BDD
using System.Data.SqlClient;//para sql server
namespace academica
{
    public partial class Form1 : Form
    {
        conexion objConexion = new conexion();
        DataSet ds = new DataSet();
        DataTable miTabla = new DataTable();

        public int posicion = 0;
        String accion = "nuevo";


        public Form1()
        {
            InitializeComponent();
            actualizarDs();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }
        private void actualizarDs()
        {
            ds.Clear();
            ds = objConexion.obtenerDatos();
            miTabla = ds.Tables["alumnos"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idAlumno"] };
            mostrarDatosAlumno();
        }
        private void mostrarDatosAlumno()
        {
            if (miTabla.Rows.Count > 0)
            {
                txtCodigoAlumnos.Text = miTabla.Rows[posicion].ItemArray[1].ToString();
                txtNombreAlumnos.Text = miTabla.Rows[posicion].ItemArray[2].ToString();
                txtDireccionAlumnos.Text = miTabla.Rows[posicion].ItemArray[3].ToString();
                txtTelefonoAlumnos.Text = miTabla.Rows[posicion].ItemArray[4].ToString();
                txtDuiAlumnos.Text = miTabla.Rows[posicion].ItemArray[5].ToString();

                lblRegistrosAlumnos.Text = (posicion + 1) + " de " + miTabla.Rows.Count;
            }
        }

        private void btnSiguienteAlumno_Click(object sender, EventArgs e)
        {
            if (posicion < miTabla.Rows.Count - 1)
            {
                posicion++;
                mostrarDatosAlumno();
            }
            else
            {
                MessageBox.Show("Esta en el ultimo registro", "Navegacion de alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorAlumno_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatosAlumno();
            }
            else
            {
                MessageBox.Show("Esta en el primer registro", "Navegacion de alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnUltimoAlumno_Click(object sender, EventArgs e)
        {
            posicion = miTabla.Rows.Count - 1;
            mostrarDatosAlumno();
        }

        private void btnPrimeroAlumno_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatosAlumno();
        }
    }
}
