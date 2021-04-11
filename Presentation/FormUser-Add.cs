using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Presentation
{
    public partial class FormAddUser : Form
    {
        Models objetuser = new Models();
        public string iduser;
        public bool value = true;

        private void FormAgregarUsuarios_Load(object sender, EventArgs e)
        {
            if (txtLoginName.Text != "")
            {
                value = false;
            }
        }

        public FormAddUser()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormUser users = new FormUser();
            users.Show();
            this.Hide();
        }

        private void btnMinApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            functEnter();
        }

        private Boolean validMail(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                functEnter();
            }
        }

        private void functEnter()
        {
            if (value == false)
            {
                if (validMail(txtEmail.Text))
                {
                    int va = objetuser.AddUser(txtLoginName.Text, txtUserPass.Text, txtFirstName.Text, txtLastName.Text, cbCargo.Text, txtEmail.Text);
                    if (va == 1)
                    {
                        MessageBox.Show("Se agrego correctamente");
                        FormUser user = new FormUser();
                        user.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar los datos");
                    }
                }
                else
                {
                    MessageBox.Show("Escribe una dirección de correo electrónico válida.");
                }
            }
            if (value)
            {
                try
                {
                    objetuser.SetUser(txtLoginName.Text, txtUserPass.Text, txtFirstName.Text, txtLastName.Text, cbCargo.Text, txtEmail.Text, iduser);
                    MessageBox.Show("Se edito correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar los datos por: " + ex);
                }

                FormUser user = new FormUser();
                user.Show();
                this.Hide();
            }
        }

        private void cbCargo_KeyDown(object sender, KeyEventArgs e)
        {
            cbCargo.Text = "";
        }

        private void cbCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            cbCargo.Text = "";
        }

        private void cbCargo_KeyUp(object sender, KeyEventArgs e)
        {
            cbCargo.Text = "";
        }
    }
}
