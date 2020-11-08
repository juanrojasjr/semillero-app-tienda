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

namespace Presentation
{
    public partial class FormAgregarUsuarios : Form
    {
        UserModel objetuser = new UserModel();
        public string iduser;
        public bool value = true;

        private void FormAgregarUsuarios_Load(object sender, EventArgs e)
        {
            if (txtLoginName.Text != "")
            {
                value = false;
            }
        }

        public FormAgregarUsuarios()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormUsuarios users = new FormUsuarios();
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
            if (value == false)
            {
                int va = objetuser.AddUser(txtLoginName.Text, txtUserPass.Text, txtFirstName.Text, txtLastName.Text, txtPosition.Text, txtEmail.Text);
                if(va == 1)
                {
                    MessageBox.Show("Se agrego correctamente");
                }
                else
                {
                    MessageBox.Show("No se pudo agregar los datos");
                }

                FormUsuarios user = new FormUsuarios();
                user.Show();
                this.Hide();
            }
            if (value)
            {
                try
                {
                    objetuser.SetUser(txtLoginName.Text, txtUserPass.Text, txtFirstName.Text, txtLastName.Text, txtPosition.Text, txtEmail.Text, iduser);
                    MessageBox.Show("Se edito correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar los datos por: " + ex);
                }

                FormUsuarios user = new FormUsuarios();
                user.Show();
                this.Hide();
            }
        }
    }
}
