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
    public partial class FrmUsuario : Form
    {
        private SqlConnection conexion;
        private string cadenaConexion = Configuracion.CadenaConexion;

        public FrmUsuario()
        {
            InitializeComponent();
            conexion = new SqlConnection(cadenaConexion);
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
                        FrmLibros libros = new FrmLibros(idUsuario);
                        libros.Show();
                        Hide();
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
    }
}