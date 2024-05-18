using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaFrom
{
    // Definición de la clase FrmMenuPrincipal que hereda de la clase Form
    public partial class FrmMenuPrincipal : Form
    {

        // Método constructor, se llama cuando se crea una nueva instancia de la clase
        public FrmMenuPrincipal()
        {
            // Llama a InitializeComponent(), un método que inicializa el formulario y todos sus controles
            InitializeComponent();
            // Coloca el fondo por defecto
            FrmInicio fondo = new FrmInicio();
            fondo.TopLevel = false;
            pnlContenedorPrincipal.Controls.Add(fondo);
            fondo.Show();
        }

        // Método que se ejecuta cuando se hace clic en el botón btnUsuario
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia de la clase FrmUsuario
            // Se agrega una instancia del formulario actual para que pueda 
            // manipular el contenedor
            FrmUsuario usuario = new FrmUsuario(this);
            usuario.TopLevel = false;
            // Limpia el contenedor
            pnlContenedorPrincipal.Controls.Clear();
            // Agrega el nuevo formulario
            pnlContenedorPrincipal.Controls.Add(usuario);
            // Muestra el formulario usuario
            usuario.Show();
        }

        // Método que se ejecuta cuando se hace clic en el botón btnLibros
        private void btnLibros_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia de la clase FrmLibros con el parámetro 0
            FrmLibros libros = new FrmLibros(0, this);
            // Cambie el tipo de formulario para que se abra dentro del contenedor
            libros.TopLevel = false;
            // Limpia el contenedor
            pnlContenedorPrincipal.Controls.Clear();
            // Agrega el nuevo formulario
            pnlContenedorPrincipal.Controls.Add(libros);
            // Muestra el formulario libros
            libros.Show();
        }

        // Método que se ejecuta cuando se hace clic en el botón btnAdministrador
        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia de la clase FrmAdministrador
            FrmAdministrador Administrador = new FrmAdministrador(this);
            // Tipo de formulario para abrir dentro de conteneodr
            Administrador.TopLevel = false;
            // Limpia el contenedor
            pnlContenedorPrincipal.Controls.Clear();
            // Agrega el formulario al contenedor
            pnlContenedorPrincipal.Controls.Add(Administrador);
            // Muestra el formulario Administrador
            Administrador.Show();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual
            Close();
        }

        // ´Función para limpiar el panel principal (Regresar al menú principal)
        public void volverInicio()
        {
            // Coloca el fondo por defecto
            FrmInicio fondo = new FrmInicio();
            fondo.TopLevel = false;
            pnlContenedorPrincipal.Controls.Clear();
            pnlContenedorPrincipal.Controls.Add(fondo);
            fondo.Show();
        }

        // Función para abrir el formulario de libros
        public void abrirFormularioLibros(int resultado)
        {
            
            FrmLibros libros = new FrmLibros(resultado, this);

            libros.TopLevel = false;
            pnlContenedorPrincipal.Controls.Clear(); // Asegúrate de que esto se ejecute
            pnlContenedorPrincipal.Controls.Add(libros);
            libros.Show();

            libros.Focus(); // Establece el foco en el nuevo formulario
            pnlContenedorPrincipal.Refresh(); // Fuerza la actualización del panel
        }

        // Función para abrir el formulario de administrar biblioteca
        public void abrirAdministrarBiblioteca()
        {
            FrmAdministrarBiblioteca biblioteca = new FrmAdministrarBiblioteca(this);

            biblioteca.TopLevel = false;

            pnlContenedorPrincipal.Controls.Clear();
            pnlContenedorPrincipal.Controls.Add(biblioteca);

            biblioteca.Show();
        }

        public void abrirRegistro()
        {
            // Mostrar formulario de registro
            FrmRegistrarse registrar = new FrmRegistrarse(this);
            registrar.TopLevel = false;

            pnlContenedorPrincipal.Controls.Clear();
            pnlContenedorPrincipal.Controls.Add(registrar);
            registrar.Show();
        }

        public void abrirVerPrestamo(int idUser)
        {
            FrmVerprestamos prestamos = new FrmVerprestamos(idUser, this);
            prestamos.TopLevel = false;

            pnlContenedorPrincipal.Controls.Clear();

            pnlContenedorPrincipal.Controls.Add(prestamos);

            prestamos.Show();
        }

        public void abrirPrestamo(int idUsuario, int idLibro)
        {
            FrmPrestar prestar = new FrmPrestar(idUsuario, idLibro, this);
            prestar.TopLevel = false;

            pnlContenedorPrincipal.Controls.Clear();

            pnlContenedorPrincipal.Controls.Add(prestar);

            prestar.Show();
        }
    }
}

