using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Presentation
{
    public partial class FormAgregarProducto : Form

    {
        Agr_Products objetoproduct = new Agr_Products();
        public string idproduct;
        public bool valorprod = true;

        private void FormAgregarProducto_Load(object sender, EventArgs e)
        {

            if (txtNombre.Text != "")
            {
                valorprod = false;
            }

        }
        public FormAgregarProducto()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormProductos fmp = new FormProductos();

            fmp.Show();
            this.Hide();
        }

        private void btn_addproduct_Click(object sender, EventArgs e)
        {
            FormProductos fmp = new FormProductos();
           
            fmp.Show();
            this.Hide();

            
        }

       

        private void txtPrecioFab_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveProd_Click(object sender, EventArgs e)
        {
            if (valorprod == false)
            {
                try
                {
                    objetoproduct.AddProduct(txtNombre.Text, txtDescrip.Text, txtMarca.Text, txtPrecioFab.Text, txtPrecioVenta.Text, txtUnidades.Text);
                    MessageBox.Show("Se agrego correctamente");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("No se pudo agregar los datos"+ ex);
                }
                FormProductos fmp = new FormProductos();
                fmp.Show();
                this.Hide();

            }
            if (valorprod == true)
            {
                try
                {
                    objetoproduct.EditProduct(txtNombre.Text, txtDescrip.Text, txtMarca.Text, txtPrecioFab.Text, txtPrecioVenta.Text, txtUnidades.Text, idproduct);
                    MessageBox.Show("Se agrego correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo agregar los datos" + ex);
                }
                FormProductos fmp = new FormProductos();
                fmp.Show();
                this.Hide();

            }

        }
    }
}
