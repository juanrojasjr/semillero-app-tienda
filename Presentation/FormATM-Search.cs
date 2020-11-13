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
            Models oDataCajero = new Models();
            //Función para validar si es INT o STRING
            int nu;
            bool va = Int32.TryParse(txtSearch.Text, out nu);
            if (va)
            {
                //Busca por nombre de producto
                dataGridView1.DataSource = oDataCajero.GetProductsLike(txtSearch.Text, 1);
            }
            else
            {
                //Busca por referencia de producto
                dataGridView1.DataSource = oDataCajero.GetProductsLike(txtSearch.Text, 0);
            }
            DataGridViewColumn col0 = dataGridView1.Columns[0]; //Oculta columna IdProduct
            col0.Visible = false;
            DataGridViewColumn col3 = dataGridView1.Columns[3]; //Oculta columna Categoria
            col3.Visible = false;
            DataGridViewColumn col5 = dataGridView1.Columns[5]; //Oculta columna Cantidad Minima
            col5.Visible = false;
            DataGridViewColumn col6 = dataGridView1.Columns[6]; //Oculta columna Precio Proveedor
            col6.Visible = false;
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            enterFunction();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void enterFunction()
        {
            Cargar();
            txtSearch.Clear();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                enterFunction();
            }
        }
    }
}
