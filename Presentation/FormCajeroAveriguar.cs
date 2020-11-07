using Domain;
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
            DataCajero oDataCajero = new DataCajero();
            if (!txtSearch.Text.Trim().Equals("") || !txtRef.Text.Trim().Equals(""))
            {
                dataGridView1.DataSource = oDataCajero.funcion(txtSearch.Text);
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
