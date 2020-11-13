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
            enterFunction();
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

        private void enterFunction()
        {
            if (valor == false)
            {
                try
                {
                    if (validMail(txtEmail.Text))
                    {
                        oProviders.AddProvider(txtNameCompany.Text, txtName.Text, txtPhone.Text, txtEmail.Text);
                        MessageBox.Show("Se agrego correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Ingresa un correo electrónico válido.");
                    }
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
                    oProviders.EditProvider(txtNameCompany.Text, txtName.Text, txtPhone.Text, txtEmail.Text, idprov);
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

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                enterFunction();
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            //Función para validar si es INT o STRING
            int nu;
            bool va = Int32.TryParse(txtPhone.Text, out nu);
            if (va == false)
            {
                MessageBox.Show("Este campo solo recibe números.");
                txtPhone.Text = "";
            }
        }
    }
}
