using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            if (txtUser.Text != "")
            {
                if (txtPass.Text != "")
                {
                    UserModel user = new UserModel();
                    var valLogin = user.LoginUser(txtUser.Text, txtPass.Text);
                    if (valLogin == true)
                    {
                        FormAdmin admin = new FormAdmin();
                        FormCajero cajero = new FormCajero();

                        if (UserLoginCache.position == "administrator")
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
                    else {
                        msgError("Usuario o contraseña incorrectos.");
                        txtPass.Clear();
                        txtUser.Focus();
                    }
                }
                else { 
                    msgError("Por favor ingrese su contraseña."); 
                }
            }
            else { msgError("Por favor ingrese su usuario."); }
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
    }
}
