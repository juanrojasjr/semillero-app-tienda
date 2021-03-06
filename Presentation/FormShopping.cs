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
    public partial class FormShopping : Form
    {
        public FormShopping()
        {
            InitializeComponent();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuyAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            enterFunction();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                pnlFields.Visible = true;
                pnlProvider.Visible = true;
                lblId.Text = dataGridView1.CurrentRow.Cells["IdProduct"].Value.ToString();
                lblQuantity.Text = dataGridView1.CurrentRow.Cells["Inventario"].Value.ToString();
                txtPriceBuy.Text = dataGridView1.CurrentRow.Cells["P. Proveedor"].Value.ToString();
                txtPriceSale.Text = dataGridView1.CurrentRow.Cells["P. Venta"].Value.ToString();
                lblQuantityTotal.Text = lblQuantity.Text;
                getProviders();
            }
            else
                MessageBox.Show("Selecciona la fila por favor.");
        }

        private void refreshQuantityTotal()
        {
            if (!txtAddQuantity.Text.Trim().Equals(""))
            {
                int nu;
                bool va = Int32.TryParse(txtAddQuantity.Text, out nu);
                if (va)
                {
                    int nAddQuantity = Convert.ToInt32(txtAddQuantity.Text);
                    if (nAddQuantity >= 1)
                    {
                        int op = Convert.ToInt32(lblQuantity.Text) + Convert.ToInt32(txtAddQuantity.Text);
                        lblQuantityTotal.Text = op.ToString();
                        int oPriceTotal = Convert.ToInt32(txtPriceBuy.Text) * Convert.ToInt32(txtAddQuantity.Text);
                        lblTotalPrice.Text = oPriceTotal.ToString();
                    }
                    else
                    {
                        MessageBox.Show("El número ingresado debe ser mayor a 0");
                        lblQuantityTotal.Text = lblQuantity.Text;
                    }
                }
                else
                {
                    MessageBox.Show("El campo solo recibe números.");
                    txtAddQuantity.Text = "";
                    lblQuantityTotal.Text = lblQuantity.Text;
                }
            }
            else
            {
                lblQuantityTotal.Text = lblQuantity.Text;
                lblTotalPrice.Text = "";
            }
        }

        private void txtAddQuantity_TextChanged(object sender, EventArgs e)
        {
            refreshQuantityTotal();
        }

        private void txtPriceProv_TextChanged(object sender, EventArgs e)
        {
            refreshQuantityTotal();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormAdmin frmAdmin = new FormAdmin();
            frmAdmin.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.pnlProvider.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void pnlFields_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.pnlFields.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void cbProvider_SelectedValueChanged(object sender, EventArgs e)
        {
            btnContinue.Enabled = true;
        }

        List<String> idProvider = new List<String>();
        private void getProviders()
        {
            Models oModels = new Models();
            DataTable oDataTable = oModels.GetProviders();
            for (int i = 0; i < oDataTable.Rows.Count; i++)
            {
                idProvider.Add(oDataTable.Rows[i]["ProveedoresID"].ToString());
                cbProvider.Items.Add(oDataTable.Rows[i]["Compañía"].ToString());
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Models oShopping = new Models();
            oShopping.AddShopping(lblId.Text, txtAddQuantity.Text, txtPriceBuy.Text, txtPriceSale.Text, lblTotalPrice.Text, txtBill.Text, idProvider[cbProvider.SelectedIndex].ToString());
            oShopping.SetProduct(lblQuantityTotal.Text, txtPriceBuy.Text, txtPriceSale.Text, lblId.Text);
            pnlFields.Visible = false;
            pnlProvider.Visible = false;
            btnContinue.Enabled = false;
            dataGridView1.DataSource = null;
            MessageBox.Show("Compra agregada e inventario editado.");
        }

        private void picHistory_Click(object sender, EventArgs e)
        {
            Models oModels = new Models();
            if (oModels.GetShoppings().Rows.Count != 0) {
                dgvAllShopping.DataSource = oModels.GetShoppings();
                dgvAllShopping.Columns[2].Width = 110;
                dataGridView1.Visible = false;
                dgvAllShopping.Visible = true;
                btnCancel.Visible = true;
            }
            else
            {
                MessageBox.Show("No hay historial para mostrar.");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dgvAllShopping.Visible = false;
            btnCancel.Visible = false;
        }

        private void txtProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                enterFunction();
            }
        }

        private void enterFunction()
        {
            txtProduct.Text = "";
            Models oGetProducts = new Models();
            int nu;
            bool va = Int32.TryParse(txtProduct.Text, out nu);
            if (va)
            {
                // Busca por referencia de producto
                dataGridView1.DataSource = oGetProducts.GetProductsLike(txtProduct.Text, 1);
            }
            else
            {
                //Busca por nombre de producto
                dataGridView1.DataSource = oGetProducts.GetProductsLike(txtProduct.Text, 0);
            }
            dataGridView1.Columns[2].Width = 140;
            dataGridView1.Columns[6].Width = 125;
            if (dataGridView1.RowCount < 1)
            {
                lblSelected.Text = "Ningún resultado. Si no existe el producto, puede crear uno en el +.";
                lblSelected.Visible = true;
            }
            else lblSelected.Visible = false;
        }
    }
}
