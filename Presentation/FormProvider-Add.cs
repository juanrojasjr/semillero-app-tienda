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
    public partial class FormAddProvider : Form
    {
        Models oProviders = new Models();
        public string idprov;
        public bool valor = true;

        private void FormAgregarProveedor_Load(object sender, EventArgs e)
        {
            if (txtNameCompany.Text != "")
            {
                valor = false;
            }
        }

        public FormAddProvider()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FormProvider fmprv = new FormProvider();
            fmprv.Show();
            this.Hide();
        }

        private void BtnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
           if (valor == false) 
            {
                try
                {
                    oProviders.AddProvider(txtNameCompany.Text, txtName.Text, txtPhone.Text, txtEmail.Text);
                    MessageBox.Show("Se agrego correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo agregar los datos por: " + ex);
                }

                FormProvider prov = new FormProvider();
                prov.Show();
                this.Hide();
            }
            if (valor == true)
            {
                try
                {
                    oProviders.EditProvider(txtNameCompany.Text, txtName.Text, txtPhone.Text, txtEmail.Text,idprov);
                    MessageBox.Show("Se edito correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar los datos por: " + ex);
                }

                FormProvider prov = new FormProvider();
                prov.Show();
                this.Hide();
            }
        }

        private void txtNameCompany_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
