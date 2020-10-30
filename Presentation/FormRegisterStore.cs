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
    public partial class FormRegisterStore : Form
    {
        public FormRegisterStore()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserModel dataStore = new UserModel();
            var val = dataStore.addDataStore(txtNameStore.Text, txtNameOwner.Text, txtPhone.Text, txtAddress.Text);
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
}
