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
        }

        // Método que se ejecuta cuando se hace clic en el botón btnUsuario
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia de la clase FrmUsuario
            FrmUsuario usuario = new FrmUsuario();
            // Muestra el formulario usuario
            usuario.Show();
        }

        // Método que se ejecuta cuando se hace clic en el botón btnLibros
        private void btnLibros_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia de la clase FrmLibros con el parámetro 0
            FrmLibros libros = new FrmLibros(0);
            // Muestra el formulario libros
            libros.Show();
        }

        // Método que se ejecuta cuando se hace clic en el botón btnAdministrador
        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia de la clase FrmAdministrador
            FrmAdministrador Administrador = new FrmAdministrador();
            // Muestra el formulario Administrador
            Administrador.Show();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual
            Close();
        }
    }
}

