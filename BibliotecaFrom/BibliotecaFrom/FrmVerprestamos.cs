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
    public partial class FrmVerprestamos : Form
    {
        private int id_usuario;

        public FrmVerprestamos(int id_usuario)
        {
            InitializeComponent();
            this.id_usuario = id_usuario;
            CargarDatos();
        }

        private void CargarDatos()
        {
            // Cadena de conexión a la base de datos
            string connectionString = Configuracion.CadenaConexion;

            // Consulta SQL para obtener los libros prestados al usuario
            string query = "SELECT Prestamo.ID_Prestamo, Libro.tituloLibro, Libro.contenido, Prestamo.fecha_prestamo, Prestamo.fecha_devolucion FROM Prestamo INNER JOIN Libro ON Prestamo.ID_Libro = Libro.id_libro INNER JOIN Usuario ON Prestamo.ID_Usuario = Usuario.ID_Usuario WHERE Usuario.ID_Usuario = @id_usuario";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Crear un comando SQL para ejecutar la consulta
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id_usuario", id_usuario);

                    // Adaptador y DataTable para llenar el DataGridView
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvVer.DataSource = dataTable;

                    dgvVer.Columns[0].Width = 30;
                    dgvVer.Columns[0].HeaderText = "ID";
                    dgvVer.Columns[1].HeaderText = "Descripción";
                    dgvVer.Columns[1].Width = 110;
                    dgvVer.Columns[2].HeaderText = "Libro";
                    dgvVer.Columns[3].HeaderText = "Préstamo";
                    dgvVer.Columns[3].Width = 80;
                    dgvVer.Columns[4].HeaderText = "Devolución";
                    dgvVer.Columns[4].Width = 80;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Ver Libros Prestados");
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_CancelarPrestamo_Click(object sender, EventArgs e)
        {
            if (dgvVer.SelectedRows.Count > 0)
            {
                // Obtén la fila seleccionada.
                DataGridViewRow selectedRow = dgvVer.SelectedRows[0];

                // Obtén ID_Prestamo de la fila seleccionada.
                int id_prestamo = (int)selectedRow.Cells["ID_Prestamo"].Value;

                // Cadena de conexión a la base de datos
                string connectionString = Configuracion.CadenaConexion;

                // Consulta SQL para eliminar el préstamo
                string query = "DELETE FROM Prestamo WHERE ID_Prestamo = @id_prestamo";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Crear un comando SQL para ejecutar la consulta
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id_prestamo", id_prestamo);

                        // Ejecuta la consulta
                        command.ExecuteNonQuery();

                        MessageBox.Show("Préstamo cancelado con éxito.", "Cancelar Préstamo");

                        // Recarga los datos
                        CargarDatos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Cancelar Préstamo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un préstamo para cancelarlo.", "Cancelar Préstamo");
            }
        }
    }
}