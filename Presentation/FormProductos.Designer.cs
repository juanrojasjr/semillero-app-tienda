namespace Presentation
{
    partial class FormProductos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_regresar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.Nombre_prod = new System.Windows.Forms.Label();
            this.txt_nombreprod = new System.Windows.Forms.TextBox();
            this.Descripcion_prod = new System.Windows.Forms.Label();
            this.txt_descprod = new System.Windows.Forms.TextBox();
            this.Marca_prod = new System.Windows.Forms.Label();
            this.txt_marcaprod = new System.Windows.Forms.TextBox();
            this.Precio_fab_prod = new System.Windows.Forms.Label();
            this.txt_preciofab = new System.Windows.Forms.TextBox();
            this.Precio_venta_prod = new System.Windows.Forms.Label();
            this.txt_precioventa = new System.Windows.Forms.TextBox();
            this.Unidades = new System.Windows.Forms.Label();
            this.txt_unidprod = new System.Windows.Forms.TextBox();
            this.btn_addproduct = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.lbl_regresar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 47);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "Guardar Producto";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(168)))), ((int)(((byte)(178)))));
            this.label1.Location = new System.Drawing.Point(277, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Agregar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_regresar
            // 
            this.lbl_regresar.AutoSize = true;
            this.lbl_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_regresar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(168)))), ((int)(((byte)(178)))));
            this.lbl_regresar.Location = new System.Drawing.Point(49, 15);
            this.lbl_regresar.Name = "lbl_regresar";
            this.lbl_regresar.Size = new System.Drawing.Size(83, 19);
            this.lbl_regresar.TabIndex = 19;
            this.lbl_regresar.Text = "Regresar";
            this.lbl_regresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_regresar.Click += new System.EventHandler(this.lbl_regresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation.Properties.Resources.add;
            this.pictureBox1.Location = new System.Drawing.Point(231, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Image = global::Presentation.Properties.Resources.previous2;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 41);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 1;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Nombre_prod
            // 
            this.Nombre_prod.AutoSize = true;
            this.Nombre_prod.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_prod.Location = new System.Drawing.Point(512, 93);
            this.Nombre_prod.Name = "Nombre_prod";
            this.Nombre_prod.Size = new System.Drawing.Size(66, 19);
            this.Nombre_prod.TabIndex = 4;
            this.Nombre_prod.Text = "Nombre";
            // 
            // txt_nombreprod
            // 
            this.txt_nombreprod.Location = new System.Drawing.Point(578, 92);
            this.txt_nombreprod.Name = "txt_nombreprod";
            this.txt_nombreprod.Size = new System.Drawing.Size(173, 20);
            this.txt_nombreprod.TabIndex = 5;
            // 
            // Descripcion_prod
            // 
            this.Descripcion_prod.AutoSize = true;
            this.Descripcion_prod.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion_prod.Location = new System.Drawing.Point(488, 138);
            this.Descripcion_prod.Name = "Descripcion_prod";
            this.Descripcion_prod.Size = new System.Drawing.Size(90, 19);
            this.Descripcion_prod.TabIndex = 6;
            this.Descripcion_prod.Text = "Descripcion";
            // 
            // txt_descprod
            // 
            this.txt_descprod.Location = new System.Drawing.Point(578, 137);
            this.txt_descprod.Name = "txt_descprod";
            this.txt_descprod.Size = new System.Drawing.Size(173, 20);
            this.txt_descprod.TabIndex = 7;
            // 
            // Marca_prod
            // 
            this.Marca_prod.AutoSize = true;
            this.Marca_prod.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marca_prod.Location = new System.Drawing.Point(528, 185);
            this.Marca_prod.Name = "Marca_prod";
            this.Marca_prod.Size = new System.Drawing.Size(50, 19);
            this.Marca_prod.TabIndex = 8;
            this.Marca_prod.Text = "Marca";
            this.Marca_prod.Click += new System.EventHandler(this.Marca_prod_Click);
            // 
            // txt_marcaprod
            // 
            this.txt_marcaprod.Location = new System.Drawing.Point(578, 185);
            this.txt_marcaprod.Name = "txt_marcaprod";
            this.txt_marcaprod.Size = new System.Drawing.Size(173, 20);
            this.txt_marcaprod.TabIndex = 9;
            // 
            // Precio_fab_prod
            // 
            this.Precio_fab_prod.AutoSize = true;
            this.Precio_fab_prod.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio_fab_prod.Location = new System.Drawing.Point(449, 230);
            this.Precio_fab_prod.Name = "Precio_fab_prod";
            this.Precio_fab_prod.Size = new System.Drawing.Size(129, 19);
            this.Precio_fab_prod.TabIndex = 10;
            this.Precio_fab_prod.Text = "Precio de Fabrica";
            // 
            // txt_preciofab
            // 
            this.txt_preciofab.Location = new System.Drawing.Point(578, 229);
            this.txt_preciofab.Name = "txt_preciofab";
            this.txt_preciofab.Size = new System.Drawing.Size(173, 20);
            this.txt_preciofab.TabIndex = 11;
            // 
            // Precio_venta_prod
            // 
            this.Precio_venta_prod.AutoSize = true;
            this.Precio_venta_prod.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio_venta_prod.Location = new System.Drawing.Point(459, 277);
            this.Precio_venta_prod.Name = "Precio_venta_prod";
            this.Precio_venta_prod.Size = new System.Drawing.Size(119, 19);
            this.Precio_venta_prod.TabIndex = 12;
            this.Precio_venta_prod.Text = "Precio de Venta";
            // 
            // txt_precioventa
            // 
            this.txt_precioventa.Location = new System.Drawing.Point(578, 276);
            this.txt_precioventa.Name = "txt_precioventa";
            this.txt_precioventa.Size = new System.Drawing.Size(173, 20);
            this.txt_precioventa.TabIndex = 13;
            // 
            // Unidades
            // 
            this.Unidades.AutoSize = true;
            this.Unidades.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unidades.Location = new System.Drawing.Point(504, 323);
            this.Unidades.Name = "Unidades";
            this.Unidades.Size = new System.Drawing.Size(74, 19);
            this.Unidades.TabIndex = 14;
            this.Unidades.Text = "Unidades";
            // 
            // txt_unidprod
            // 
            this.txt_unidprod.Location = new System.Drawing.Point(578, 322);
            this.txt_unidprod.Name = "txt_unidprod";
            this.txt_unidprod.Size = new System.Drawing.Size(173, 20);
            this.txt_unidprod.TabIndex = 15;
            // 
            // btn_addproduct
            // 
            this.btn_addproduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addproduct.Location = new System.Drawing.Point(545, 373);
            this.btn_addproduct.Name = "btn_addproduct";
            this.btn_addproduct.Size = new System.Drawing.Size(232, 37);
            this.btn_addproduct.TabIndex = 16;
            this.btn_addproduct.Text = "Guardar Producto";
            this.btn_addproduct.UseVisualStyleBackColor = true;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(111)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_addproduct);
            this.Controls.Add(this.txt_unidprod);
            this.Controls.Add(this.Unidades);
            this.Controls.Add(this.txt_precioventa);
            this.Controls.Add(this.Precio_venta_prod);
            this.Controls.Add(this.txt_preciofab);
            this.Controls.Add(this.Precio_fab_prod);
            this.Controls.Add(this.txt_marcaprod);
            this.Controls.Add(this.Marca_prod);
            this.Controls.Add(this.txt_descprod);
            this.Controls.Add(this.Descripcion_prod);
            this.Controls.Add(this.txt_nombreprod);
            this.Controls.Add(this.Nombre_prod);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductos";
            this.Text = "PanelProductos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_regresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nombre_prod;
        private System.Windows.Forms.TextBox txt_nombreprod;
        private System.Windows.Forms.Label Descripcion_prod;
        private System.Windows.Forms.TextBox txt_descprod;
        private System.Windows.Forms.Label Marca_prod;
        private System.Windows.Forms.TextBox txt_marcaprod;
        private System.Windows.Forms.Label Precio_fab_prod;
        private System.Windows.Forms.TextBox txt_preciofab;
        private System.Windows.Forms.Label Precio_venta_prod;
        private System.Windows.Forms.TextBox txt_precioventa;
        private System.Windows.Forms.Label Unidades;
        private System.Windows.Forms.TextBox txt_unidprod;
        private System.Windows.Forms.Button btn_addproduct;
    }
}