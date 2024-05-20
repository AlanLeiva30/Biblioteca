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
    public partial class FrmLibros : Form
    {
        private int id_usuario, id_libro;
        private DataGridViewRow filaSeleccionada;
        // Usa la cadena de conexión desde la clase Configuracion
        string cadenaConexion = Configuracion.CadenaConexion;

        private readonly FrmMenuPrincipal _formularioPrincipal;

        public FrmLibros(int id, FrmMenuPrincipal principal)
        {
            InitializeComponent();
            id_usuario = id;
            lbl_IdUsuario.Text = id_usuario.ToString();
            _formularioPrincipal = principal;

            ConfigurarElementos();
            CargarDatos();
        }

        private void ConfigurarElementos()
        {
            bool existeUsuario = id_usuario > 0;

            // Configurar la visibilidad de los elementos según la existencia del usuario
            btnPrestar.Visible = existeUsuario;
            lbl_SeleccioneLibro.Visible = existeUsuario;
            lbl_IdLibro.Visible = existeUsuario;
            lbl_IdDeUsuario.Visible = existeUsuario;
            lbl_Libro_seleccionado.Visible = existeUsuario;
            lbl_IdUsuario.Visible = existeUsuario;
            btnPrestamos.Visible = existeUsuario;
        }

        private void CargarDatos()
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                EjecutarProcedimientoAlmacenado(conexion, "MostrarLibros", dgvMostrar);

                
                if (dgvMostrar.Columns.Contains("id_libro"))
                {
                    dgvMostrar.Columns["id_libro"].HeaderText = "ID";
                    dgvMostrar.Columns["id_libro"].Visible = false;
                }
                if (dgvMostrar.Columns.Contains("tituloLibro"))
                {
                    dgvMostrar.Columns["tituloLibro"].HeaderText = "Título";
                    dgvMostrar.Columns["tituloLibro"].Width = 200; 
                }
                if (dgvMostrar.Columns.Contains("autor"))
                {
                    dgvMostrar.Columns["autor"].HeaderText = "Autor";
                    dgvMostrar.Columns["autor"].Width = 150;
                }
                if (dgvMostrar.Columns.Contains("año_publicacion"))
                {
                    dgvMostrar.Columns["año_publicacion"].HeaderText = "Año";
                    dgvMostrar.Columns["año_publicacion"].Width = 55; 
                }
                if (dgvMostrar.Columns.Contains("contenido"))
                {
                    dgvMostrar.Columns["contenido"].HeaderText = "Descripción";
                    dgvMostrar.Columns["contenido"].Width = 390;
                }
                
            }
        }

        private void EjecutarProcedimientoAlmacenado(SqlConnection conexion, string nombreProcedimiento, DataGridView vistaActualizada)
        {
            try
            {
                conexion.Open();

                SqlCommand comando = new SqlCommand(nombreProcedimiento, conexion);
                comando.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable dataTable = new DataTable();
                adaptador.Fill(dataTable);
                vistaActualizada.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Mostrar Libros");
            }
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            // Validar que el usuario ha seleccionado un libro
            if (filaSeleccionada != null && filaSeleccionada.Cells["id_libro"].Value != null)
            {
                id_libro = Convert.ToInt32(filaSeleccionada.Cells["id_libro"].Value);
                _formularioPrincipal.abrirPrestamo(id_usuario, id_libro);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún libro.", "Error");
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            _formularioPrincipal.volverInicio();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            _formularioPrincipal.abrirVerPrestamo(id_usuario);
        }

        private void dgvMostrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Comprobar si el índice de fila es válido
            if (e.RowIndex >= 0 && e.RowIndex < dgvMostrar.Rows.Count)
            {
                filaSeleccionada = dgvMostrar.Rows[e.RowIndex];
                id_libro = Convert.ToInt32(filaSeleccionada.Cells["id_libro"].Value);
                lbl_IdLibro.Text = id_libro.ToString();
            }
        }
    }
}
