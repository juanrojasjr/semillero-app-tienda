using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Presentation
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
            
            Models store = new Models();
            var valStore = store.GetDataStore();
            if (valStore)
            {
                Application.Run(new FormLogin());
                //Application.Run(new FormShopping());
            }
            else
            {
                Application.Run(new FormAddStore());
            }
        }
    }
}
