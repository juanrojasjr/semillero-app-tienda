namespace Presentation
{
    partial class FormAgregarProducto
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
            this.btn_addproduct = new System.Windows.Forms.Button();
            this.txt_unidprod = new System.Windows.Forms.TextBox();
            this.Unidades = new System.Windows.Forms.Label();
            this.txt_precioventa = new System.Windows.Forms.TextBox();
            this.Precio_venta_prod = new System.Windows.Forms.Label();
            this.txt_preciofab = new System.Windows.Forms.TextBox();
            this.Precio_fab_prod = new System.Windows.Forms.Label();
            this.txt_marcaprod = new System.Windows.Forms.TextBox();
            this.Marca_prod = new System.Windows.Forms.Label();
            this.txt_descprod = new System.Windows.Forms.TextBox();
            this.Descripcion_prod = new System.Windows.Forms.Label();
            this.txt_nombreprod = new System.Windows.Forms.TextBox();
            this.Nombre_prod = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.lbl_regresar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.lbl_regresar);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 47);
            this.panel1.TabIndex = 0;
            // 
            // btn_addproduct
            // 
            this.btn_addproduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addproduct.Location = new System.Drawing.Point(155, 360);
            this.btn_addproduct.Name = "btn_addproduct";
            this.btn_addproduct.Size = new System.Drawing.Size(232, 37);
            this.btn_addproduct.TabIndex = 29;
            this.btn_addproduct.Text = "Guardar Producto";
            this.btn_addproduct.UseVisualStyleBackColor = true;
            // 
            // txt_unidprod
            // 
            this.txt_unidprod.Location = new System.Drawing.Point(188, 309);
            this.txt_unidprod.Name = "txt_unidprod";
            this.txt_unidprod.Size = new System.Drawing.Size(173, 20);
            this.txt_unidprod.TabIndex = 28;
            // 
            // Unidades
            // 
            this.Unidades.AutoSize = true;
            this.Unidades.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unidades.Location = new System.Drawing.Point(114, 310);
            this.Unidades.Name = "Unidades";
            this.Unidades.Size = new System.Drawing.Size(74, 19);
            this.Unidades.TabIndex = 27;
            this.Unidades.Text = "Unidades";
            // 
            // txt_precioventa
            // 
            this.txt_precioventa.Location = new System.Drawing.Point(188, 263);
            this.txt_precioventa.Name = "txt_precioventa";
            this.txt_precioventa.Size = new System.Drawing.Size(173, 20);
            this.txt_precioventa.TabIndex = 26;
            // 
            // Precio_venta_prod
            // 
            this.Precio_venta_prod.AutoSize = true;
            this.Precio_venta_prod.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio_venta_prod.Location = new System.Drawing.Point(69, 264);
            this.Precio_venta_prod.Name = "Precio_venta_prod";
            this.Precio_venta_prod.Size = new System.Drawing.Size(119, 19);
            this.Precio_venta_prod.TabIndex = 25;
            this.Precio_venta_prod.Text = "Precio de Venta";
            // 
            // txt_preciofab
            // 
            this.txt_preciofab.Location = new System.Drawing.Point(188, 216);
            this.txt_preciofab.Name = "txt_preciofab";
            this.txt_preciofab.Size = new System.Drawing.Size(173, 20);
            this.txt_preciofab.TabIndex = 24;
            // 
            // Precio_fab_prod
            // 
            this.Precio_fab_prod.AutoSize = true;
            this.Precio_fab_prod.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio_fab_prod.Location = new System.Drawing.Point(59, 217);
            this.Precio_fab_prod.Name = "Precio_fab_prod";
            this.Precio_fab_prod.Size = new System.Drawing.Size(129, 19);
            this.Precio_fab_prod.TabIndex = 23;
            this.Precio_fab_prod.Text = "Precio de Fabrica";
            // 
            // txt_marcaprod
            // 
            this.txt_marcaprod.Location = new System.Drawing.Point(188, 172);
            this.txt_marcaprod.Name = "txt_marcaprod";
            this.txt_marcaprod.Size = new System.Drawing.Size(173, 20);
            this.txt_marcaprod.TabIndex = 22;
            // 
            // Marca_prod
            // 
            this.Marca_prod.AutoSize = true;
            this.Marca_prod.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marca_prod.Location = new System.Drawing.Point(138, 172);
            this.Marca_prod.Name = "Marca_prod";
            this.Marca_prod.Size = new System.Drawing.Size(50, 19);
            this.Marca_prod.TabIndex = 21;
            this.Marca_prod.Text = "Marca";
            // 
            // txt_descprod
            // 
            this.txt_descprod.Location = new System.Drawing.Point(188, 124);
            this.txt_descprod.Name = "txt_descprod";
            this.txt_descprod.Size = new System.Drawing.Size(173, 20);
            this.txt_descprod.TabIndex = 20;
            // 
            // Descripcion_prod
            // 
            this.Descripcion_prod.AutoSize = true;
            this.Descripcion_prod.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion_prod.Location = new System.Drawing.Point(98, 125);
            this.Descripcion_prod.Name = "Descripcion_prod";
            this.Descripcion_prod.Size = new System.Drawing.Size(90, 19);
            this.Descripcion_prod.TabIndex = 19;
            this.Descripcion_prod.Text = "Descripcion";
            // 
            // txt_nombreprod
            // 
            this.txt_nombreprod.Location = new System.Drawing.Point(188, 79);
            this.txt_nombreprod.Name = "txt_nombreprod";
            this.txt_nombreprod.Size = new System.Drawing.Size(173, 20);
            this.txt_nombreprod.TabIndex = 18;
            // 
            // Nombre_prod
            // 
            this.Nombre_prod.AutoSize = true;
            this.Nombre_prod.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_prod.Location = new System.Drawing.Point(122, 80);
            this.Nombre_prod.Name = "Nombre_prod";
            this.Nombre_prod.Size = new System.Drawing.Size(66, 19);
            this.Nombre_prod.TabIndex = 17;
            this.Nombre_prod.Text = "Nombre";
            // 
            // btnBack
            // 
            this.btnBack.Image = global::Presentation.Properties.Resources.previous2;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 41);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 2;
            this.btnBack.TabStop = false;
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
            this.lbl_regresar.TabIndex = 30;
            this.lbl_regresar.Text = "Regresar";
            this.lbl_regresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(111)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.btn_addproduct);
            this.Controls.Add(this.txt_unidprod);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Unidades);
            this.Controls.Add(this.Nombre_prod);
            this.Controls.Add(this.txt_precioventa);
            this.Controls.Add(this.txt_nombreprod);
            this.Controls.Add(this.Precio_venta_prod);
            this.Controls.Add(this.Descripcion_prod);
            this.Controls.Add(this.txt_preciofab);
            this.Controls.Add(this.txt_descprod);
            this.Controls.Add(this.Precio_fab_prod);
            this.Controls.Add(this.Marca_prod);
            this.Controls.Add(this.txt_marcaprod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAgregarProducto";
            this.Text = "FormAgregarProducto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_addproduct;
        private System.Windows.Forms.TextBox txt_unidprod;
        private System.Windows.Forms.Label Unidades;
        private System.Windows.Forms.TextBox txt_precioventa;
        private System.Windows.Forms.Label Precio_venta_prod;
        private System.Windows.Forms.TextBox txt_preciofab;
        private System.Windows.Forms.Label Precio_fab_prod;
        private System.Windows.Forms.TextBox txt_marcaprod;
        private System.Windows.Forms.Label Marca_prod;
        private System.Windows.Forms.TextBox txt_descprod;
        private System.Windows.Forms.Label Descripcion_prod;
        private System.Windows.Forms.TextBox txt_nombreprod;
        private System.Windows.Forms.Label Nombre_prod;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label lbl_regresar;
    }
}