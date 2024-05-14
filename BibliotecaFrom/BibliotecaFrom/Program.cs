using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaFrom
{
	//CADENA DE CONEXION GLOGAL PARA TODOS LOS FORMULARIOS
	//(cambiar para el de su computadora)
    public static class Configuracion
    {
        public static string CadenaConexion = "Server=PC-GAMER;Database=BibliotecaFrom;Trusted_Connection=True;";

    }
    static class Program
	{
		/// <summary>
		/// Punto de entrada principal para la aplicación.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FrmMenuPrincipal());
		}
	}
}
