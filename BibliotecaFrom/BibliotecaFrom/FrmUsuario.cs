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
using static BibliotecaFrom.FrmMenuPrincipal;

namespace BibliotecaFrom
{
    public partial class FrmUsuario : Form
    {
        private SqlConnection conexion;
        private string cadenaConexion = Configuracion.CadenaConexion;

        private readonly FrmMenuPrincipal _formularioPrincipal;
        public FrmUsuario(FrmMenuPrincipal formularioPrincipal)
        {
            InitializeComponent();
            conexion = new SqlConnection(cadenaConexion);
            // Se obtiene la instalacia del formulario principal
            _formularioPrincipal = formularioPrincipal;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT ID_Usuario FROM Usuario WHERE usuario = @usuario AND Contraseña = @contraseña";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();

                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    string usuario = txtUsuario.Text;
                    string contraseña = txtContraseña.Text;
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@contraseña", contraseña);

                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        int idUsuario = (int)resultado;
                        // Se ejecuta la función para el cambio de formulario
                        _formularioPrincipal.abrirFormularioLibros(idUsuario);

                    }
                    else
                    {
                        MessageBox.Show("Credenciales inválidas.", "Error de inicio de sesión");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error de conexión");
                }
            }
            //int idUsuario = (int)resultado;
            // Obtiene una instancia para acceder a los delegados
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FrmRegistrarse registro = new FrmRegistrarse();
            registro.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}