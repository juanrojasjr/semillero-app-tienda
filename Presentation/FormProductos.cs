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
    public partial class FormProductos : Form
    {
        Agr_Products a = new Agr_Products();

        public string IdProduct = null;


        public FormProductos()
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
            Agr_Products objeto = new Agr_Products();
            dataProduct.DataSource = objeto.GetProduct();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormAdmin fmp = new FormAdmin();

            fmp.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Marca_prod_Click(object sender, EventArgs e)
        {

        }


       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarprod_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

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
               FormAgregarProducto fmaproduct = new FormAgregarProducto();
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
                a.DeleteProduct(IdProduct);
                MessageBox.Show("Se ha eliminado correctamente");
                MostrarProduct();
            }
            else
                MessageBox.Show("Seleccione una fila para eliminar");
        }

        private void btn_agregarprod_Click(object sender, EventArgs e)
        {
            FormAgregarProducto fmp = new FormAgregarProducto();
            fmp.valorprod = false;
            fmp.Show();
            this.Hide();
        }
    }
}
