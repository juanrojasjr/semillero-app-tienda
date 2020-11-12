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
using Microsoft.VisualBasic;
using InputKey;

namespace Presentation
{
    public partial class FormATM : Form
    {
        public int count = 0;

        public FormATM()
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

        private void btnConsult_Click(object sender, EventArgs e)
        {
            Cargar();
            txtSearch.Clear();
        }

        private void Cargar()
        {
            Models oDataATM = new Models();
            
            //Función para validar si es INT o STRING
            int nu;
            bool va = Int32.TryParse(txtSearch.Text, out nu);
            if (va)
            {
                //Busca por referencia de producto
                dataGridView1.DataSource = oDataATM.GetProductsLike(txtSearch.Text, 1);
            }
            else
            {
                //Busca por nombre de producto
                dataGridView1.DataSource = oDataATM.GetProductsLike(txtSearch.Text, 0);
            }

            DataGridViewColumn col0 = dataGridView1.Columns[0]; //Oculta columna IdProduct
            col0.Visible = false;
            DataGridViewColumn col3 = dataGridView1.Columns[3]; //Oculta columna Categoria
            col3.Visible = false;
            DataGridViewColumn col5 = dataGridView1.Columns[5]; //Oculta columna Cantidad Minima
            col5.Visible = false;
            DataGridViewColumn col6 = dataGridView1.Columns[6]; //Oculta columna Precio Proveedor
            col6.Visible = false;

            if (dataGridView1.RowCount > 1)
            {
                dataGridView1.CurrentCell = null;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string sQuatity = popupQuantity();
            actionItem(sQuatity);
        }

        private string popupQuantity()
        {
            int quatity = Int32.Parse(InputDialog.mostrar("Introduzca la cantidad", "Cantidad"));
            if (quatity < 1) { quatity = 1; };
            string sQuatity = quatity.ToString();
            return sQuatity;
        }

        private void actionItem(string sQuatity)
        {
            //Agrega producto seleccionado al ListView
            addListViewItems(sQuatity, dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                dataGridView1.CurrentRow.Cells[7].Value.ToString(),
                dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                dataGridView1.CurrentRow.Cells[4].Value.ToString());
            int price = Int32.Parse(dataGridView1.CurrentRow.Cells[7].Value.ToString());
            int iQuantity = Int32.Parse(sQuatity);
            int op = price * iQuantity;
            sumTotal(op); //Realiza multiplicación de cantidad por precio
        }

        private void addListViewItems(string cant, string Nombre, string refe, string price, string id, string stock)
        {
            ListViewItem lista = new ListViewItem(cant);
            lista.SubItems.Add(Nombre);
            lista.SubItems.Add(refe);
            lista.SubItems.Add(price);
            lista.SubItems.Add(id);
            lista.SubItems.Add(stock);
            listView1.Items.Add(lista);
        }

        private void sumTotal(int price)
        {
            count += price;
            lblPriceTotal.Text = count.ToString();
            lblPriceTotal.Visible = true;
        }        

        public void btnCancel_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
            listView1.Items.Clear();
            count = 0;
            lblPriceTotal.Visible = false;
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in listView1.SelectedItems)
            {
                //Obtener datos de la columna seleccionada
                int quantity = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                int price = Int32.Parse(listView1.SelectedItems[0].SubItems[3].Text);
                int opRestPriceTotal = quantity * price;
                count -= opRestPriceTotal;
                lblPriceTotal.Text = count.ToString();
                lista.Remove();
            }
        }

        private void btnConsultItem_Click(object sender, EventArgs e)
        {
            FormCajeroAveriguar oFormCajeroAveriguar = new FormCajeroAveriguar();
            oFormCajeroAveriguar.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            FormCajeroPago oFormCajeroPago = new FormCajeroPago();
            oFormCajeroPago.lblPriceTotal.Text = lblPriceTotal.Text;
            oFormCajeroPago.list = listView1;
            oFormCajeroPago.Show();
            oFormCajeroPago.FormClosed += btnCancel_Click;
        }
    }
}
