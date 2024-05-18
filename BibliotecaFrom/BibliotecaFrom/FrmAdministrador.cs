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
    public partial class FrmAdministrador : Form
    {
        private readonly FrmMenuPrincipal _formularioPrincipal;
        public FrmAdministrador(FrmMenuPrincipal formularioPrincipal)
        {
            InitializeComponent();
            _formularioPrincipal = formularioPrincipal;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Obtener el usuario y la contraseña ingresados
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            _formularioPrincipal.abrirAdministrarBiblioteca();
            return;
            // Usa la cadena de conexión desde la clase Configuracion
            string cadenaConexion = Configuracion.CadenaConexion;
            // Consulta SQL
            string consulta = "SELECT COUNT(*) FROM Usuario WHERE usuario = @usuario AND Contraseña = @contraseña AND Administrador = 1";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();

                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@contraseña", contraseña);

                    int cantidad = (int)comando.ExecuteScalar();

                    if (cantidad > 0)
                    {
                        // Usuario autenticado como administrador
                        // Realiza las acciones correspondientes para dar acceso al usuario administrador
                        // Ejemplo: Mostrar formulario de administración, etc.
                        _formularioPrincipal.abrirAdministrarBiblioteca();
                    }
                    else
                    {
                        // Usuario no autenticado o no es administrador
                        MessageBox.Show("Acceso denegado.");
                    }
                }
                catch (Exception ex)
                {
                    // Error de conexión o consulta SQL
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            // Configurar el campo de contraseña para ocultar el texto ingresado
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            _formularioPrincipal.volverInicio();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            // Mostrar formulario de registro
            _formularioPrincipal.abrirRegistro();
        }
    }
}

