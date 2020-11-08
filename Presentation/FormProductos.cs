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

        public string id_producto = null;


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
                fmaproduct.txtNombre.Text = dataProduct.CurrentRow.Cells["nombre_producto"].Value.ToString();
                fmaproduct.txtDescrip.Text = dataProduct.CurrentRow.Cells["Descripcion"].Value.ToString();
                fmaproduct.txtMarca.Text = dataProduct.CurrentRow.Cells["Marca"].Value.ToString();
                fmaproduct.txtPrecioFab.Text = dataProduct.CurrentRow.Cells["Precio_fabrica"].Value.ToString();
                fmaproduct.txtPrecioVenta.Text = dataProduct.CurrentRow.Cells["Precio_venta"].Value.ToString();
                fmaproduct.txtUnidades.Text = dataProduct.CurrentRow.Cells["Unidades"].Value.ToString();
                fmaproduct.idproduct = dataProduct.CurrentRow.Cells["id_producto"].Value.ToString();
                this.Hide();
            }
            else
                MessageBox.Show("Seleccione una fila para editar");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataProduct.SelectedRows.Count > 0)
            {
                id_producto = dataProduct.CurrentRow.Cells["id_producto"].Value.ToString();
                a.DeleteProduct(id_producto);
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
