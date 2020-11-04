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
    public partial class FormCajeroPago : Form
    {
        public FormCajeroPago()
        {
            InitializeComponent();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            int change = Int32.Parse(txtRecep.Text);
            int priceTotal = Int32.Parse(lblPriceTotal.Text);
            lblError.Visible = false;

            if (change > priceTotal)
            {
                int op = change - priceTotal;
                string sOp = op.ToString();
                lblChange.Text = sOp;

                //Habilitar
                lblChange.Visible = true;
                ImgPrint.Visible = true;

                //Deshabilitar
                btnCloseApp.Visible = false;
            }
            else
            {
                lblError.Visible = true;
            }
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere cancelar el pago?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void ImgPrint_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
