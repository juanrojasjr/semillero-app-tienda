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
    public partial class FormAgregarProveedor : Form
    {
        Agr_Providers objetopro = new Agr_Providers();
        public string idprov;
        private bool valor = true;

        private void FormAgregarProveedor_Load(object sender, EventArgs e)
        {
            if (txtNameCompany.Text != "")
            {
                valor = false;
            }
        }

        public FormAgregarProveedor()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormProveedores fmprv = new FormProveedores();
            fmprv.Show();
            this.Hide();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           if (valor == false) 
            {
                try
                {
                    objetopro.InsertarProv(txtNameCompany.Text, txtName.Text, txtPhone.Text, txtEmail.Text);
                    MessageBox.Show("Se agrego correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo agregar los datos por: " + ex);
                }

                FormProveedores prov = new FormProveedores();
                prov.Show();
                this.Hide();
            }
            if (valor == true)
            {
                try
                {
                    objetopro.EditarPov(txtNameCompany.Text, txtName.Text, txtPhone.Text, txtEmail.Text,idprov);
                    MessageBox.Show("Se edito correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar los datos por: " + ex);
                }

                FormProveedores prov = new FormProveedores();
                prov.Show();
                this.Hide();
            }
        }
    }
}
