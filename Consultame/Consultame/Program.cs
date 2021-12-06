using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_PRESENTACION;

namespace Consultame
{
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
            /*
             * idicamos que se muestre el fomrulario principal al iniciar la app
             */
            Application.Run(new Formulario_Principal());
        }
    }
}
