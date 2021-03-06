﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Domain;
using Common.Cache;

namespace Presentation
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }
        private void msgError(string msg)
        {
            lblError.Text = "        " + msg;
            lblError.Visible = true;
        }
        private void logout(object sender, FormClosedEventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
            lblError.Visible = false;
            this.Show();
            txtUser.Focus();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            lblNameStore.Text = DataStoreCache.Namestore;
        }        

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaxApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnResApp.Visible = true;
            btnMaxApp.Visible = false;
        }

        private void btnResApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnResApp.Visible = false;
            btnMaxApp.Visible = true;
        }

        private void btnMinApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region 'Funcion para arrastrar la ventana'
            [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
            private extern static void ReleaseCapture();
            [DllImport("user32.DLL", EntryPoint = "SendMessage")]
            private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

            private void panel1_MouseDown(object sender, MouseEventArgs e)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        #endregion

        private void lblNameStore_Click(object sender, EventArgs e){}
        private void label1_Click(object sender, EventArgs e){}

        public void login()
        {
            if (txtUser.Text != "")
            {
                if (txtPass.Text != "")
                {
                    Models user = new Models();
                    var valLogin = user.LoginUser(txtUser.Text, txtPass.Text);
                    if (valLogin == true)
                    {
                        FormAdmin admin = new FormAdmin();
                        FormATM cajero = new FormATM();

                        if (UserLoginCache.Position == "Administrator")
                        {
                            admin.Show();
                            admin.FormClosed += logout;
                            this.Hide();
                        }
                        else
                        {
                            cajero.Show();
                            cajero.FormClosed += logout;
                            this.Hide();
                        }
                    }
                    else
                    {
                        msgError("Usuario o contraseña incorrectos.");
                        txtPass.Clear();
                        txtUser.Focus();
                    }
                }
                else
                {
                    msgError("Por favor ingrese su contraseña.");
                }
            }
            else { msgError("Por favor ingrese su usuario."); }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                login();
            }
        }
    }
}
