using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academica
{
    public partial class frm_usuario : Form
    {

        Conexion objConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable miTabla = new DataTable();
        public int posicion = 0;
        string accion = "Nuevo";
        public frm_usuario()
        {
            InitializeComponent();
        }
        private void actualizarDs()
        {
            ds.Clear();
            ds = objConexion.obtenerDatos();
            miTabla = ds.Tables["usuarios"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idUsuario"] };
            grdTablaUsuarios.DataSource = miTabla;
            mostrarDatosUsuario();
        }
        public void mostrarDatosUsuario()
        {
            if (miTabla.Rows.Count > 0)
            {
                txtUsuario.Text = miTabla.Rows[posicion].ItemArray[1].ToString();
                txtClaveUsuario.Text = miTabla.Rows[posicion].ItemArray[2].ToString();
                txtNombreUsuario.Text = miTabla.Rows[posicion].ItemArray[3].ToString();
                txtDireccionUsuario.Text = miTabla.Rows[posicion].ItemArray[4].ToString();
                txtTelefonoUsuario.Text = miTabla.Rows[posicion].ItemArray[5].ToString();

                lblNavegacionUsuarios.Text = (posicion + 1) + " de " + miTabla.Rows.Count;
            }
        }

        private void frm_usuario_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }

        private void btnSiguienteUsuario_Click(object sender, EventArgs e)
        {
            if (posicion < miTabla.Rows.Count - 1)
            {
                posicion++;
                mostrarDatosUsuario();
            }
            else
            {
                MessageBox.Show("Esta en el ultimo registro", "Navegacion de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoUsuario_Click(object sender, EventArgs e)
        {
            posicion = miTabla.Rows.Count - 1;
            mostrarDatosUsuario();
        }

        private void btnAnteriorUsuario_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatosUsuario();
            }
            else
            {
                MessageBox.Show("Esta en el primer registro", "Navegacion de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrimeroUsuario_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatosUsuario();
        }

        public void estadoControles(bool estado)
        {
            grdTablaUsuarios.Enabled = !estado;
            grbDatosUsuarios.Enabled = estado;
            btnEliminarUsuario.Enabled = !estado;
            grbDatosUsuarios.Enabled = !estado;
        }
        public void limpiarCajas()
        {
            txtUsuario.Text = "";
            txtNombreUsuario.Text = "";
            txtClaveUsuario.Text = "";
            txtTelefonoUsuario.Text = "";
            txtDireccionUsuario.Text = "";

        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            if (btnNuevoUsuario.Text == "Nuevo")
            {
                btnNuevoUsuario.Text = "Guardar";
                btnModificarUsuario.Text = "Cancelar";
                accion = "nuevo";
                estadoControles(true);
                limpiarCajas();
            }
            else
            {//Guardar
                String[] alumnos = {
                    accion, miTabla.Rows[posicion].ItemArray[0].ToString(),
                    txtUsuario.Text,txtClaveUsuario.Text,txtNombreUsuario.Text,txtTelefonoUsuario.Text
            };
                String respuesta = objConexion.administrarAlumnos(alumnos);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error en el registro de alumnos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnNuevoUsuario.Text = "Nuevo";
                    btnModificarUsuario.Text = "Modificar";
                    estadoControles(false);
                    actualizarDs();
                }
            }
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (btnModificarUsuario.Text == "Modificar")
            {
                btnNuevoUsuario.Text = "Guardar";
                btnModificarUsuario.Text = "Cancelar";
                accion = "modificar";
                estadoControles(true);

            }
            else
            {//Cancelar
                mostrarDatosUsuario();
                btnNuevoUsuario.Text = "Nuevo";
                btnModificarUsuario.Text = "Modificar";
                estadoControles(false);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtUsuario.Text.Trim() + "?", "Eliminar Usuario", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String[] alumnos = {
                    "eliminar", miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                String respuesta = objConexion.administrarAlumnos(alumnos);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error en el registro de alumnos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                     posicion = 0;
                    actualizarDs();
                    mostrarDatosUsuario();
                }
            }
        }
        private void filtrarDatos(String filtro)
        {
            DataView dv = miTabla.DefaultView;
            dv.RowFilter = "usuario like '%" + filtro + "%' OR nombre like '%" + filtro + "%'";
            grdTablaUsuarios.DataSource = dv;
        }

        private void txtBuscarUsuarios_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDatos(txtBuscarUsuarios.Text);
           
            seleccionarUsuario();
            
        }
        public void seleccionarUsuario() {
            try
            {
                var idActual = grdTablaUsuarios.CurrentRow;
                if (idActual != null)
                {
                    posicion = miTabla.Rows.IndexOf(miTabla.Rows.Find(grdTablaUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString()));
                    mostrarDatosUsuario();
                }
                else
                {
                    MessageBox.Show("Registro no encontrado");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error");
            }
        }

        private void grdDatosUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarUsuario();
        }
    }
}
