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
    public partial class FormAgregarProducto : Form
    {
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

        private void FormAgregarProducto_Load(object sender, EventArgs e)
        {
            
        }
    }
}
