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
    public partial class FormProducts : Form
    {
        Models oModel = new Models();

        public string IdProduct = null;

        public FormProducts()
        {
            InitializeComponent();
        }
        private void FormProductos_Load(object sender, EventArgs e)
        {
            MostrarProduct();
            DataGridViewColumn b = dataProduct.Columns[0];
            b.Visible = false;

        }

        private void MostrarProduct()
        {
            Models oModel = new Models();
            dataProduct.DataSource = oModel.GetProduct();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormAdmin fmp = new FormAdmin();

            fmp.Show();
            this.Hide();
        }

        private void btnMinApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataProduct.SelectedRows.Count > 0)
            {
               FormProductsAdd fmaproduct = new FormProductsAdd();
                fmaproduct.Show();
                fmaproduct.txtRef.Text = dataProduct.CurrentRow.Cells["Ref"].Value.ToString();
                fmaproduct.txtNombre.Text = dataProduct.CurrentRow.Cells["Nombre"].Value.ToString();
                fmaproduct.txtCategoria.Text = dataProduct.CurrentRow.Cells["Categoria"].Value.ToString();
                fmaproduct.txtCantStock.Text = dataProduct.CurrentRow.Cells["Stock"].Value.ToString();
                fmaproduct.txtCantMin.Text = dataProduct.CurrentRow.Cells["CanMin"].Value.ToString();
                fmaproduct.txtPrecioCompra.Text = dataProduct.CurrentRow.Cells["PriceProv"].Value.ToString();
                fmaproduct.txtPrecioVenta.Text = dataProduct.CurrentRow.Cells["PriceSale"].Value.ToString();
                fmaproduct.IdProduct = dataProduct.CurrentRow.Cells["IdProduct"].Value.ToString();
                this.Hide();
            }
            else
                MessageBox.Show("Seleccione una fila para editar");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataProduct.SelectedRows.Count > 0)
            {
                IdProduct = dataProduct.CurrentRow.Cells["IdProduct"].Value.ToString();
                oModel.DeleteProduct(IdProduct);
                MessageBox.Show("Se ha eliminado correctamente");
                MostrarProduct();
            }
            else
                MessageBox.Show("Seleccione una fila para eliminar");
        }

        private void btn_agregarprod_Click(object sender, EventArgs e)
        {
            FormProductsAdd fmp = new FormProductsAdd();
            fmp.valorprod = false;
            fmp.Show();
            this.Hide();
        }
    }
}