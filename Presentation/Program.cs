﻿using System;
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
            
            UserModel store = new UserModel();
            var valStore = store.dataStore();
            if (valStore)
            {
                Application.Run(new FormProveedores());
                //Application.Run(new FormCajero());
            }
            else
            {
                Application.Run(new FormRegisterStore());
            }
        }
    }
}
