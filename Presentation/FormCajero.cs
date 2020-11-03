using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Domain;

namespace Presentation
{
    public partial class FormCajero : Form
    {

        DataCajero products = new DataCajero();

        public FormCajero()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere cerrar sesión?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void btnMinApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormCajero_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = products.getProducts("coca");
        }

        private void txtBusqueda_Enter(object sender, EventArgs e)
        {
            consultar(txtBusqueda.Text);
        }

        private void consultar(string data)
        {
            //llama los produsctos que ya están en la base de datos
            dataGridView1.DataSource = products.getProducts(data);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consultar(txtBusqueda.Text);
        }
    }
}
