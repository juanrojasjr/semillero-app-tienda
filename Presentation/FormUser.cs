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
    public partial class FormUser : Form
    {
        Models oUsers = new Models();
        public string idUsers = null;

        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            Mostraruser();
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Visible = false;
            DataGridViewColumn colPass = dataGridView1.Columns[2];
            colPass.Visible = false;
        }

        private void Mostraruser()
        {
            dataGridView1.DataSource = oUsers.GetUsers();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormAdmin adm = new FormAdmin();
            adm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddUser fmaprv = new FormAddUser();
            fmaprv.Show();
            fmaprv.value = false;
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idUsers = dataGridView1.CurrentRow.Cells["UserID"].Value.ToString();
                oUsers.DeleteUser(idUsers);
                MessageBox.Show("Se elimino correctamente");
                Models oUserss = new Models();
                dataGridView1.DataSource = oUserss.GetUsers();
            }
            else
                MessageBox.Show("Seleccione una fila para eliminar");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                FormAddUser fmauser = new FormAddUser();
                fmauser.Show();
                fmauser.txtLoginName.Text = dataGridView1.CurrentRow.Cells["LoginName"].Value.ToString();
                fmauser.txtUserPass.Text = dataGridView1.CurrentRow.Cells["UserPass"].Value.ToString();
                fmauser.txtFirstName.Text = dataGridView1.CurrentRow.Cells["FirstName"].Value.ToString();
                fmauser.txtLastName.Text = dataGridView1.CurrentRow.Cells["LastName"].Value.ToString();
                //fmauser.cbCargo. = dataGridView1.CurrentRow.Cells["Position"].Value.ToString();
                fmauser.txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                fmauser.iduser = dataGridView1.CurrentRow.Cells["UserID"].Value.ToString();
                this.Hide();
            }
            else
                MessageBox.Show("Seleccione una fila para editar");
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            if (!txtUser.Text.Trim().Equals(""))
            {
                dataGridView1.DataSource = oUsers.GetUser(txtUser.Text);
                DataGridViewColumn col = dataGridView1.Columns[0];
                col.Visible = false;

                if (dataGridView1.RowCount > 1)
                {
                    dataGridView1.CurrentCell = null;
                }
            }
            btnViewAll.Visible = true;
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            Models oUserss = new Models();
            dataGridView1.DataSource = oUserss.GetUsers();
            txtUser.Text = "";
            btnViewAll.Visible = false;
        }
    }
}
