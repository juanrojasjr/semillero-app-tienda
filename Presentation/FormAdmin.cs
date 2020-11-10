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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere cerrar sesión?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FormLogin fmLogin = new FormLogin();
                fmLogin.Show();
                this.Hide();
            }
                
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormProvider fmprv = new FormProvider();
            fmprv.Show();
            this.Hide();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProducts fmp = new FormProducts();

            fmp.Show();
            this.Hide();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormUser users = new FormUser();
            users.Show();
            this.Hide();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSale fBuys = new FormSale();
            fBuys.Show();
            this.Hide();
        }
    }
}
