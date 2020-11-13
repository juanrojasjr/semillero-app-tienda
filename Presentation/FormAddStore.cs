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
    public partial class FormAddStore : Form
    {
        public FormAddStore()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            enterFunction();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enterFunction()
        {
            if (txtNameStore.Text == "" || txtNameOwner.Text == "" ||
                txtAddress.Text == "" || txtPhone.Text == "" || txtNit.Text == "")
            {
                lblError.Visible = true;
            }
            else
            {
                Models dataStore = new Models();
                var val = dataStore.AddDataStore(txtNameStore.Text, txtNameOwner.Text, txtPhone.Text, txtAddress.Text, txtNit.Text);
                if (val == 1)
                {
                    MessageBox.Show("Tienda registrada.");
                    this.Hide();

                    //Mostrar FormLogin
                    FormLogin login = new FormLogin();
                    login.Show();
                }
            }
        }

        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                enterFunction();
            }
        }
    }
}
