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
            
            UserModel store = new UserModel();
            var valStore = store.dataStore();
            if (valStore)
            {
                //Application.Run(new FormLogin());
                Application.Run(new FormCajero());
            }
            else
            {
                Application.Run(new FormRegisterStore());
            }
=======

            Application.Run(new FormAdmin());

            //UserModel store = new UserModel();
            //var valStore = store.dataStore();
            //if (valStore)
            //{
            //    Application.Run(new FormLogin());
            //}
            //else
            //{
            //    Application.Run(new FormRegisterStore());
            //}
>>>>>>> bed5cd63f6fcdf631c6784c4a5a30e6159c3b78b
        }
    }
}
