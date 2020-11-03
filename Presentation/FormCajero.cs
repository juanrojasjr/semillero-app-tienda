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
        int count = 0;

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
        }

        private void Cargar()
        {
            ModelEntity.MyCompanyEntities db = new ModelEntity.MyCompanyEntities();
            var lst = (from d in db.Products
                        select new ModelEntity.
                        {
                            IdProduct = d.IdProduct,
                            Ref = d.Ref,
                            Nombre = d.Nombre,
                            PriceSale = (int)d.PriceSale
                        }).AsQueryable();

            if (!txtSearch.Text.Trim().Equals("") || !txtRef.Text.Trim().Equals(""))
            {
                lst = lst.Where(d => d.Nombre.Contains(txtSearch.Text));
                //incluye los resultados en el DataGridView
                dataGridView1.DataSource = lst.ToList();
                //MessageBox.Show(lst.ToList().Count.ToString());

                if (lst.ToList().Count == 1)
                {
                    addListViewItems("1", dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString(),
                        dataGridView1.CurrentRow.Cells["Ref"].Value.ToString(),
                        dataGridView1.CurrentRow.Cells["PriceSale"].Value.ToString());
                    int price = Int32.Parse(dataGridView1.CurrentRow.Cells["PriceSale"].Value.ToString());
                    sumTotal(price);
                }
                else if (lst.ToList().Count > 1)
                {
                    dataGridView1.CurrentCell = null;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            addListViewItems("1", dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString(),
                                dataGridView1.CurrentRow.Cells["Ref"].Value.ToString(),
                                dataGridView1.CurrentRow.Cells["PriceSale"].Value.ToString());
            int price = Int32.Parse(dataGridView1.CurrentRow.Cells["PriceSale"].Value.ToString());
            sumTotal(price);
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

    }
}
