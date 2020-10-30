﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere cerrar sesión?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FormLogin fmLogin = new FormLogin();
                fmLogin.Show();
                this.Hide();
            }
                
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormProveedores fmprv = new FormProveedores();
            fmprv.Show();
            this.Hide();
        }
    }
}
