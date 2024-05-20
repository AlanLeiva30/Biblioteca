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

namespace BibliotecaFrom
{
    public partial class FrmRegistrarse : Form
    {

        private readonly FrmMenuPrincipal _formularioPrincipal;
        public FrmRegistrarse(FrmMenuPrincipal formularioPrincipal)
        {
            InitializeComponent();
            _formularioPrincipal = formularioPrincipal;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados en los campos
            string nombreCompleto = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            int administrador = ckbAdministrador.Checked ? 1 : 0;
            string codigo = txtCodigo.Text;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(nombreCompleto) ||
                string.IsNullOrWhiteSpace(direccion) ||
                string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Todos los campos son requeridos.", "Error de registro");
                return;
            }

            // Validar el código de administrador si se seleccionó la opción de administrador
            if (administrador == 1 && codigo != "321")
            {
                MessageBox.Show("Código de administrador incorrecto.", "Error de registro");
                return;
            }

            // Usa la cadena de conexión desde la clase Configuracion
            string cadenaConexion = Configuracion.CadenaConexion;

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();

                    // Crear un comando SQL para ejecutar el procedimiento almacenado
                    SqlCommand comando = new SqlCommand("RegistrarUsuario", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    // Agregar los parámetros al comando
                    comando.Parameters.AddWithValue("@nombreCompleto", nombreCompleto);
                    comando.Parameters.AddWithValue("@direccion", direccion);
                    comando.Parameters.AddWithValue("@telefono", telefono);
                    comando.Parameters.AddWithValue("@correo", correo);
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@contraseña", contraseña);
                    comando.Parameters.AddWithValue("@administrador", administrador);
                    comando.ExecuteNonQuery();

                    limpiarDatos();
                    MessageBox.Show("Registro de usuario exitoso.", "Registro exitoso");
                }
                catch (Exception ex)
                {
                    // Error de conexión o consulta SQL
                    MessageBox.Show("Error: " + ex.Message, "Error de registro");
                }
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            txtCodigo.UseSystemPasswordChar = true;
        }

        private void ckbAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAdministrador.Checked)
            {
                txtCodigo.Visible = true;
                lblSuperUsuario.Visible = true;
            }
            else
            {
                txtCodigo.Visible = false;
                lblSuperUsuario.Visible = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        private void limpiarDatos()
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
            ckbAdministrador.Checked = false;
            txtCodigo.Clear();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            _formularioPrincipal.volverInicio();
        }
    }
}