namespace Presentation
{
    partial class FormProveedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.PictureBox();
            this.btnMinApp = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.btnResApp = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.btnMaxApp = new System.Windows.Forms.PictureBox();
            this.btnCloseApp = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmp = new System.Windows.Forms.TextBox();
            this.btnConsult = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaxApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnMinApp);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnResApp);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnMaxApp);
            this.panel1.Controls.Add(this.btnCloseApp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 48);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Image = global::Presentation.Properties.Resources.edit;
            this.btnEditar.Location = new System.Drawing.Point(118, 8);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(32, 32);
            this.btnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditar.TabIndex = 16;
            this.btnEditar.TabStop = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Image = global::Presentation.Properties.Resources.delete;
            this.btnEliminar.Location = new System.Drawing.Point(169, 8);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(32, 32);
            this.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnMinApp
            // 
            this.btnMinApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinApp.Image = global::Presentation.Properties.Resources.minimize_icon;
            this.btnMinApp.Location = new System.Drawing.Point(734, 12);
            this.btnMinApp.Name = "btnMinApp";
            this.btnMinApp.Size = new System.Drawing.Size(24, 24);
            this.btnMinApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinApp.TabIndex = 13;
            this.btnMinApp.TabStop = false;
            this.btnMinApp.Click += new System.EventHandler(this.btnMinApp_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Image = global::Presentation.Properties.Resources.add1;
            this.btnAdd.Location = new System.Drawing.Point(65, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 32);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 8;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnResApp
            // 
            this.btnResApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResApp.Image = global::Presentation.Properties.Resources.restaurar_icon;
            this.btnResApp.Location = new System.Drawing.Point(734, 12);
            this.btnResApp.Name = "btnResApp";
            this.btnResApp.Size = new System.Drawing.Size(24, 24);
            this.btnResApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnResApp.TabIndex = 14;
            this.btnResApp.TabStop = false;
            this.btnResApp.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::Presentation.Properties.Resources.previous23;
            this.btnBack.Location = new System.Drawing.Point(12, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 32);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 1;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnMaxApp
            // 
            this.btnMaxApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaxApp.Image = global::Presentation.Properties.Resources.maximisize_icon;
            this.btnMaxApp.Location = new System.Drawing.Point(734, 12);
            this.btnMaxApp.Name = "btnMaxApp";
            this.btnMaxApp.Size = new System.Drawing.Size(24, 24);
            this.btnMaxApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMaxApp.TabIndex = 12;
            this.btnMaxApp.TabStop = false;
            this.btnMaxApp.Visible = false;
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseApp.Image = global::Presentation.Properties.Resources.close_icon;
            this.btnCloseApp.Location = new System.Drawing.Point(764, 12);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(24, 24);
            this.btnCloseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCloseApp.TabIndex = 11;
            this.btnCloseApp.TabStop = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(168)))), ((int)(((byte)(178)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(168)))), ((int)(((byte)(178)))));
            this.dataGridView1.Location = new System.Drawing.Point(23, 129);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(752, 300);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(23, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingrese el nombre de la empresa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEmp
            // 
            this.txtEmp.BackColor = System.Drawing.Color.White;
            this.txtEmp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmp.Location = new System.Drawing.Point(27, 91);
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.Size = new System.Drawing.Size(274, 27);
            this.txtEmp.TabIndex = 7;
            this.txtEmp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnConsult
            // 
            this.btnConsult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.btnConsult.FlatAppearance.BorderSize = 0;
            this.btnConsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsult.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(213)))), ((int)(((byte)(184)))));
            this.btnConsult.Location = new System.Drawing.Point(329, 74);
            this.btnConsult.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(112, 34);
            this.btnConsult.TabIndex = 10;
            this.btnConsult.Text = "Buscar";
            this.btnConsult.UseVisualStyleBackColor = false;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(111)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProveedores";
            this.Load += new System.EventHandler(this.FormProveedores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaxApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.PictureBox btnMinApp;
        private System.Windows.Forms.PictureBox btnResApp;
        private System.Windows.Forms.PictureBox btnMaxApp;
        private System.Windows.Forms.PictureBox btnCloseApp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox btnEditar;
        private System.Windows.Forms.PictureBox btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmp;
        private System.Windows.Forms.Button btnConsult;
    }
}