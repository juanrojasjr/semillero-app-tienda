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
    public partial class FormProveedores : Form
    {
        Agr_Providers objetoprv = new Agr_Providers();
        public string idProv = null;
        
        public FormProveedores()
        {
            InitializeComponent();
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            MostrarProvd();
            DataGridViewColumn column = dataGridView1.Columns[0];
             column.Visible = false;
        }

        private void Cargar()
        {
            Agr_Providers oDataProveedor = new Agr_Providers();
            if (!txtEmp.Text.Trim().Equals("") || !txtProv.Text.Trim().Equals(""))
            {
                dataGridView1.DataSource = oDataProveedor.funcion(txtEmp.Text);
                DataGridViewColumn col = dataGridView1.Columns[0];
                col.Visible = false;

                if (dataGridView1.RowCount > 1)
                {
                    dataGridView1.CurrentCell = null;
                }
            }
        }

        private void MostrarProvd()
        {
            Agr_Providers objeto = new Agr_Providers();
            dataGridView1.DataSource = objeto.GetProvider();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAgregarProveedor fmaprv = new FormAgregarProveedor();
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

        private void btnMinApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                FormAgregarProveedor fmaprv = new FormAgregarProveedor();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idProv = dataGridView1.CurrentRow.Cells["ProveedoresID"].Value.ToString();
                objetoprv.DeleteProvider(idProv);
                MessageBox.Show("Se elimino correctamente");
                MostrarProvd();
            }
            else
                MessageBox.Show("Seleccione una fila para eliminar");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            Cargar();
            txtEmp.Clear();
            txtProv.Clear();
        }
    }
}
