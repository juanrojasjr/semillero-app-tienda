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
    public partial class FormUsuarios : Form
    {
        UserModel objetoUser = new UserModel();
        public string idUsers = null;

        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            Mostraruser();
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Visible = false;
        }

        private void Mostraruser()
        {
            UserModel objeto = new UserModel();
            dataGridView1.DataSource = objeto.MostrarUsers();
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
            FormAgregarUsuarios fmaprv = new FormAgregarUsuarios();
            fmaprv.Show();
            fmaprv.value = false;
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idUsers = dataGridView1.CurrentRow.Cells["UserID"].Value.ToString();
                objetoUser.EliminarUser(idUsers);
                MessageBox.Show("Se elimino correctamente");
                Mostraruser();
            }
            else
                MessageBox.Show("Seleccione una fila para eliminar");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                FormAgregarUsuarios fmauser = new FormAgregarUsuarios();
                fmauser.Show();
                fmauser.txtLoginName.Text = dataGridView1.CurrentRow.Cells["LoginName"].Value.ToString();
                fmauser.txtUserPass.Text = dataGridView1.CurrentRow.Cells["UserPass"].Value.ToString();
                fmauser.txtFirstName.Text = dataGridView1.CurrentRow.Cells["FirstName"].Value.ToString();
                fmauser.txtLastName.Text = dataGridView1.CurrentRow.Cells["LastName"].Value.ToString();
                fmauser.cmbCargo.Text = dataGridView1.CurrentRow.Cells["Position"].Value.ToString();
                fmauser.txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                fmauser.iduser = dataGridView1.CurrentRow.Cells["UserID"].Value.ToString();
                this.Hide();
            }
            else
                MessageBox.Show("Seleccione una fila para editar");
        }
    }
}
