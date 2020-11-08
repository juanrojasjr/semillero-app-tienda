﻿using System;
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
        public bool valor = true;

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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FormProveedores fmprv = new FormProveedores();
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
                    objetopro.AddProvider(txtNameCompany.Text, txtName.Text, txtPhone.Text, txtEmail.Text);
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
                    objetopro.EditProvider(txtNameCompany.Text, txtName.Text, txtPhone.Text, txtEmail.Text,idprov);
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
