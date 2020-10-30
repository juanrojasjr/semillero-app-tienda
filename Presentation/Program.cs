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
<<<<<<< HEAD
            Application.Run(new FormProveedores());
=======
            //Application.Run(new FormLogin());
>>>>>>> 9e6f1f27ed12a4cbb256882d99715679822e4fcb

            UserModel store = new UserModel();
            var valStore = store.dataStore();
            if (valStore)
            {
                Application.Run(new FormLogin());
            }
            else
            {
                Application.Run(new FormRegisterStore());
            }
        }
    }
}
