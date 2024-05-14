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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BibliotecaFrom
{
    public partial class FrmAdministrarBiblioteca : Form
    {
        private int id_seleccionado;
        // Variable para mantener seguimiento de la tabla actual
        private string tablaActual;
        // Usa la cadena de conexión desde la clase Configuracion
        string cadenaConexion = Configuracion.CadenaConexion;

        public FrmAdministrarBiblioteca()
        {
            InitializeComponent();
        }

        // Evento para el botón de retroceso
        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Evento para el botón de Usuarios
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            tablaActual = "Usuarios";
            lbl_TipoTabla.Text = "Tabla " + tablaActual;
            btnEliminarP.Enabled = false;
            btnEliminaeL.Enabled = false;
            btnEliminarU.Enabled = true;
            MostrarTabla("MostrarUsuarios");
        }

        // Evento para el botón de eliminar usuario
        private void btnEliminarU_Click(object sender, EventArgs e)
        {
            string usuario = txtEliminarPorID.Text;
            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show("Selecciona un ID válido.", "Eliminar Usuario");
                return;
            }
            EjecutarProcedimiento("EliminarUsuario", "@IDUsuario", usuario);
        }

        // Evento para el botón de Libros
        private void btnLibros_Click(object sender, EventArgs e)
        {
            tablaActual = "Libros";
            lbl_TipoTabla.Text = "Tabla " + tablaActual;
            btnEliminarP.Enabled = false;
            btnEliminaeL.Enabled = true;
            btnEliminarU.Enabled = false;
            MostrarTabla("MostrarLibros");
        }

        // Evento para el botón de eliminar libro
        private void btnEliminaeL_Click(object sender, EventArgs e)
        {
            string idLibro = txtEliminarPorID.Text;
            if (string.IsNullOrWhiteSpace(idLibro))
            {
                MessageBox.Show("Ingresa un ID de libro válido.", "Eliminar Libro");
                return;
            }
            EjecutarProcedimiento("EliminarLibro", "@idLibro", idLibro);
        }

        // Evento para el botón de Préstamos
        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            tablaActual = "Prestamos";
            lbl_TipoTabla.Text = "Tabla " + tablaActual;
            btnEliminarP.Enabled = true;
            btnEliminaeL.Enabled = false;
            btnEliminarU.Enabled = false;
            MostrarTabla("MostrarPrestamos");
        }

        // Evento para el botón de eliminar préstamo
        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            string idPrestamo = txtEliminarPorID.Text;
            if (string.IsNullOrWhiteSpace(idPrestamo))
            {
                MessageBox.Show("Ingresa un ID de préstamo válido.", "Eliminar Préstamo");
                return;
            }
            EjecutarProcedimiento("EliminarPrestamo", "@idPrestamo", idPrestamo);
        }

        // Evento para el botón de agregar libro
        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            FrmAgregarLibro agregar = new FrmAgregarLibro();
            agregar.Show();
        }

        // Función para limpiar el campo de texto
        private void LimpiarCampoTexto()
        {
            txtEliminarPorID.Clear();
        }

        // Evento para el click en una celda del DataGridView
        private void dgvMostrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que el índice de la fila es válido
            {
                DataGridViewRow row = this.dgvMostrar.Rows[e.RowIndex];
                switch (tablaActual)
                {
                    case "Usuarios":
                        id_seleccionado = Convert.ToInt32(row.Cells["ID_Usuario"].Value);
                        break;
                    case "Libros":
                        id_seleccionado = Convert.ToInt32(row.Cells["id_libro"].Value);
                        break;
                    case "Prestamos":
                        id_seleccionado = Convert.ToInt32(row.Cells["ID_Prestamo"].Value);
                        break;
                }
                txtEliminarPorID.Text = id_seleccionado.ToString();
            }
        }

        // Función para mostrar una tabla
        private void MostrarTabla(string nombreProcedimiento)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();

                    // Crear un comando SQL para ejecutar el procedimiento almacenado
                    SqlCommand comando = new SqlCommand(nombreProcedimiento, conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    // Adaptador y DataTable para llenar el DataGridView
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable dataTable = new DataTable();
                    adaptador.Fill(dataTable);
                    dgvMostrar.DataSource = dataTable;
                    LimpiarCampoTexto();
                }
                catch (Exception ex)
                {
                    // Error de conexión o consulta SQL
                    MessageBox.Show("Error: " + ex.Message, "Mostrar " + tablaActual);
                }
            }
        }

        // Función para ejecutar un procedimiento almacenado
        private void EjecutarProcedimiento(string nombreProcedimiento, string nombreParametro, string valorParametro)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    // Crear un comando SQL para ejecutar el procedimiento almacenado
                    SqlCommand comando = new SqlCommand(nombreProcedimiento, conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    // Agregar el parámetro al comando
                    comando.Parameters.AddWithValue(nombreParametro, valorParametro);
                    comando.ExecuteNonQuery();
                    MostrarTabla("Mostrar" + tablaActual);
                    MessageBox.Show("Eliminado exitosamente", "Eliminado");
                }
                catch
                {
                    // Error de conexión o consulta SQL
                    MessageBox.Show($"Este elemento de la tabla {tablaActual} tiene un préstamo.\nPrimero elimina ese préstamo.", "Error al eliminar");
                }
            }
        }
    }
}