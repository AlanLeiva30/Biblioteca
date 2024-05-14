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
    public partial class FrmAgregarLibro : Form
    {
        public FrmAgregarLibro()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados en los campos
            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;
            string añoPublicacion = txtAño.Text;
            string contenido = txtContenido.Text;

            // Verificar si todos los campos obligatorios están completos
            if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(autor) ||
                string.IsNullOrWhiteSpace(añoPublicacion) || string.IsNullOrWhiteSpace(contenido))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Agregar Libro");
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
                    SqlCommand comando = new SqlCommand("AgregarLibro", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@tituloLibro", titulo);
                    comando.Parameters.AddWithValue("@autor", autor);
                    comando.Parameters.AddWithValue("@año_publicacion", añoPublicacion);
                    comando.Parameters.AddWithValue("@contenido", contenido);

                    // Ejecutar el comando
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Libro agregado exitosamente.", "Agregar Libro");
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error en caso de excepción
                    MessageBox.Show("Error: " + ex.Message, "Agregar Libro");
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
