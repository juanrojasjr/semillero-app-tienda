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
    public partial class FormProvider : Form
    {
        Models oProviders = new Models();
        public string idProv = null;
        
        public FormProvider()
        {
            InitializeComponent();
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            MostrarProvd();
            DataGridViewColumn column = dataGridView1.Columns[0];
             column.Visible = false;
        }

        private void MostrarProvd()
        {
            dataGridView1.DataSource = oProviders.GetProviders();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddProvider fmaprv = new FormAddProvider();
            fmaprv.valor = false;
            fmaprv.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormAdmin adm = new FormAdmin();
            adm.Show();
            this.Hide();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                FormAddProvider fmaprv = new FormAddProvider();
                fmaprv.Show();
                fmaprv.txtNameCompany.Text = dataGridView1.CurrentRow.Cells["NameCompany"].Value.ToString();
                fmaprv.txtName.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                fmaprv.txtPhone.Text = dataGridView1.CurrentRow.Cells["Phone"].Value.ToString();
                fmaprv.txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                fmaprv.idprov = dataGridView1.CurrentRow.Cells["ProveedoresID"].Value.ToString();
                this.Hide();
            }
            else
                MessageBox.Show("Seleccione una fila para editar");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idProv = dataGridView1.CurrentRow.Cells["ProveedoresID"].Value.ToString();
                oProviders.DeleteProvider(idProv);
                MessageBox.Show("Se elimino correctamente");
                MostrarProvd();
            }
            else
                MessageBox.Show("Seleccione una fila para eliminar");
        }

        private void BtnConsult_Click(object sender, EventArgs e)
        {
            enterFunction();
        }

        private void Cargar()
        {
            if (!txtEmp.Text.Trim().Equals(""))
            {
                dataGridView1.DataSource = oProviders.GetProvider(txtEmp.Text);
                DataGridViewColumn col = dataGridView1.Columns[0];
                col.Visible = false;

                if (dataGridView1.RowCount > 1)
                {
                    dataGridView1.CurrentCell = null;
                }
            }
        }

        private void BtnViewAll_Click(object sender, EventArgs e)
        {
            Models oProviderss = new Models();
            dataGridView1.DataSource = oProviderss.GetProviders();
            txtEmp.Text = "";
            btnViewAll.Visible = false;
        }

        private void txtEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                enterFunction();
            }
        }

        private void enterFunction()
        {
            Cargar();
            txtEmp.Clear();
            btnViewAll.Visible = true;
        }
    }
}
