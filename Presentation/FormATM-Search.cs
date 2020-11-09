﻿using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FormCajeroAveriguar : Form
    {
        public FormCajeroAveriguar()
        {
            InitializeComponent();
        }

        private void Cargar()
        {
            Models oDataCajero = new Models();
            if (!txtRef.Text.Trim().Equals(""))
            {
                dataGridView1.DataSource = oDataCajero.GetProductsATM(txtRef.Text, 1);
            }
            else
            {
                dataGridView1.DataSource = oDataCajero.GetProductsATM(txtSearch.Text, 0);
            }
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            Cargar();
            txtRef.Clear();
            txtSearch.Clear();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}