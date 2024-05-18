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
    public partial class FrmPrestar : Form
    {
        private int id_usuario, id_libro;
        // Usa la cadena de conexión desde la clase Configuracion
        string cadenaConexion = Configuracion.CadenaConexion;

        private readonly FrmMenuPrincipal _formularioPrincipal;
        public FrmPrestar(int idUsuario, int idLibro, FrmMenuPrincipal formularioPrincipal)
        {
            InitializeComponent();
            id_usuario = idUsuario;
            id_libro = idLibro;
            InicializarTextos();
            _formularioPrincipal = formularioPrincipal;
        }

        private void InicializarTextos()
        {
            SqlCommand comando = new SqlCommand("ObtenerTituloLibroYNombreCompleto");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID_Libro", id_libro);
            comando.Parameters.AddWithValue("@ID_Usuario", id_usuario);

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                EjecutarComando(comando, conexion);
            }
        }

        private void EjecutarComando(SqlCommand comando, SqlConnection conexion)
        {
            try
            {
                comando.Connection = conexion;
                conexion.Open();

                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    if (reader["nombreCompleto"] != DBNull.Value)
                        lbl_UsuarioPrestamo.Text = reader["nombreCompleto"].ToString();
                    if (reader["tituloLibro"] != DBNull.Value)
                        lbl_TituloLibro.Text = reader["tituloLibro"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener los datos de la base de datos: {ex.Message}");
            }
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            DateTime fechaPrestamo = dtpPrestamo.Value;
            DateTime fechaDevolucion = dtpDevolusion.Value;

            ManejarPrestamo(id_usuario, id_libro, fechaPrestamo, fechaDevolucion);
        }

        private void ManejarPrestamo(int idUsuario, int idLibro, DateTime fechaPrestamo, DateTime fechaDevolucion)
        {
            if (idUsuario != -1)
            {
                GuardarPrestamo(idUsuario, idLibro, fechaPrestamo, fechaDevolucion);
                MostrarTicketPrestamo(idUsuario, lbl_TituloLibro.Text, fechaPrestamo, fechaDevolucion);
            }
            else
            {
                MessageBox.Show("El usuario no existe en la base de datos. Debe registrarse.", "Error de usuario");
            }
        }

        private void MostrarTicketPrestamo(int idUsuario, string tituloLibro, DateTime fechaPrestamo, DateTime fechaDevolucion)
        {
            string ticket = $"--- Préstamo Realizado con éxito ---\n" +
                            $"ID de usuario: {idUsuario}\n" +
                            $"Título del libro: {tituloLibro}\n" +
                            $"Fecha de préstamo: {fechaPrestamo}\n" +
                            $"Fecha de devolución: {fechaDevolucion}";
            MessageBox.Show(ticket, "Ticket de Préstamo");
            _formularioPrincipal.volverInicio();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            _formularioPrincipal.volverInicio();
        }

        private void GuardarPrestamo(int idUsuario, int idLibro, DateTime fechaPrestamo, DateTime fechaDevolucion)
        {
            SqlCommand comando = new SqlCommand("RegistrarPrestamo");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID_Usuario", idUsuario);
            comando.Parameters.AddWithValue("@ID_Libro", idLibro);
            comando.Parameters.AddWithValue("@fecha_prestamo", fechaPrestamo);
            comando.Parameters.AddWithValue("@fecha_devolucion", fechaDevolucion);

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                EjecutarComando(comando, conexion);
            }
        }
    }
}
