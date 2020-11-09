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

        private void Cargar()
        {
            Models oDataATM = new Models();
            if (!txtSearch.Text.Trim().Equals(""))
            {
                dataGridView1.DataSource = oDataATM.GetProductsATM(txtSearch.Text, 0);
            }
            else
            {
                dataGridView1.DataSource = oDataATM.GetProductsATM(txtRef.Text, 1);
            }

            DataGridViewColumn col = dataGridView1.Columns[0];
            col.Visible = false;

            if (dataGridView1.RowCount > 1)
            {
                dataGridView1.CurrentCell = null;
            }
        }

        private void actionItem(string sQuatity)
        {
            addListViewItems(sQuatity, dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString(),
                dataGridView1.CurrentRow.Cells["Ref"].Value.ToString(),
                dataGridView1.CurrentRow.Cells["PriceSale"].Value.ToString());
            int price = Int32.Parse(dataGridView1.CurrentRow.Cells["PriceSale"].Value.ToString());
            int iQuantity = Int32.Parse(sQuatity);
            int op = price * iQuantity;
            sumTotal(op);
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

        private void addListViewItems(string cant, string Nombre, string refe, string price)
        {
            ListViewItem lista = new ListViewItem(cant);
            lista.SubItems.Add(Nombre);
            lista.SubItems.Add(refe);
            lista.SubItems.Add(price);
            listView1.Items.Add(lista);
        }

        private void sumTotal(int price)
        {
            count += price;
            lblPriceTotal.Text = count.ToString();
            lblPriceTotal.Visible = true;
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            Cargar();
            txtRef.Clear();
            txtSearch.Clear();
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
