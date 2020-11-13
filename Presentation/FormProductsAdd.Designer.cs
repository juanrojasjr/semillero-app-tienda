namespace Presentation
{
    partial class FormProductsAdd
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
            this.btnMinApp = new System.Windows.Forms.PictureBox();
            this.btnResApp = new System.Windows.Forms.PictureBox();
            this.btnMaxApp = new System.Windows.Forms.PictureBox();
            this.btnCloseApp = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.txtCantStock = new System.Windows.Forms.TextBox();
            this.Cantidad = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.Precio_venta_prod = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.Precio_compra_prod = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.Marca_prod = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.Descripcion_prod = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Nombre_prod = new System.Windows.Forms.Label();
            this.btnSaveProd = new System.Windows.Forms.Button();
            this.txtCantMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaxApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.btnMinApp);
            this.panel1.Controls.Add(this.btnResApp);
            this.panel1.Controls.Add(this.btnMaxApp);
            this.panel1.Controls.Add(this.btnCloseApp);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 47);
            this.panel1.TabIndex = 0;
            // 
            // btnMinApp
            // 
            this.btnMinApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinApp.Image = global::Presentation.Properties.Resources.minimize_icon;
            this.btnMinApp.Location = new System.Drawing.Point(750, 12);
            this.btnMinApp.Name = "btnMinApp";
            this.btnMinApp.Size = new System.Drawing.Size(24, 24);
            this.btnMinApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinApp.TabIndex = 21;
            this.btnMinApp.TabStop = false;
            // 
            // btnResApp
            // 
            this.btnResApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResApp.Image = global::Presentation.Properties.Resources.restaurar_icon;
            this.btnResApp.Location = new System.Drawing.Point(750, 12);
            this.btnResApp.Name = "btnResApp";
            this.btnResApp.Size = new System.Drawing.Size(24, 24);
            this.btnResApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnResApp.TabIndex = 22;
            this.btnResApp.TabStop = false;
            this.btnResApp.Visible = false;
            // 
            // btnMaxApp
            // 
            this.btnMaxApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaxApp.Image = global::Presentation.Properties.Resources.maximisize_icon;
            this.btnMaxApp.Location = new System.Drawing.Point(750, 12);
            this.btnMaxApp.Name = "btnMaxApp";
            this.btnMaxApp.Size = new System.Drawing.Size(24, 24);
            this.btnMaxApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMaxApp.TabIndex = 20;
            this.btnMaxApp.TabStop = false;
            this.btnMaxApp.Visible = false;
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseApp.Image = global::Presentation.Properties.Resources.close_icon;
            this.btnCloseApp.Location = new System.Drawing.Point(780, 12);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(24, 24);
            this.btnCloseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCloseApp.TabIndex = 19;
            this.btnCloseApp.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::Presentation.Properties.Resources.previous2;
            this.btnBack.Location = new System.Drawing.Point(12, 7);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 32);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 2;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtCantStock
            // 
            this.txtCantStock.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantStock.Location = new System.Drawing.Point(442, 174);
            this.txtCantStock.Name = "txtCantStock";
            this.txtCantStock.Size = new System.Drawing.Size(313, 27);
            this.txtCantStock.TabIndex = 28;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Cantidad.Location = new System.Drawing.Point(438, 152);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(136, 19);
            this.Cantidad.TabIndex = 27;
            this.Cantidad.Text = "Cantidad en Stock";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(69, 332);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(313, 27);
            this.txtPrecioVenta.TabIndex = 26;
            // 
            // Precio_venta_prod
            // 
            this.Precio_venta_prod.AutoSize = true;
            this.Precio_venta_prod.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio_venta_prod.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Precio_venta_prod.Location = new System.Drawing.Point(65, 310);
            this.Precio_venta_prod.Name = "Precio_venta_prod";
            this.Precio_venta_prod.Size = new System.Drawing.Size(119, 19);
            this.Precio_venta_prod.TabIndex = 25;
            this.Precio_venta_prod.Text = "Precio de Venta";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCompra.Location = new System.Drawing.Point(442, 254);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(313, 27);
            this.txtPrecioCompra.TabIndex = 24;
            // 
            // Precio_compra_prod
            // 
            this.Precio_compra_prod.AutoSize = true;
            this.Precio_compra_prod.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio_compra_prod.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Precio_compra_prod.Location = new System.Drawing.Point(438, 232);
            this.Precio_compra_prod.Name = "Precio_compra_prod";
            this.Precio_compra_prod.Size = new System.Drawing.Size(135, 19);
            this.Precio_compra_prod.TabIndex = 23;
            this.Precio_compra_prod.Text = "Precio de Compra";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(69, 174);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(313, 27);
            this.txtCategoria.TabIndex = 22;
            // 
            // Marca_prod
            // 
            this.Marca_prod.AutoSize = true;
            this.Marca_prod.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marca_prod.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Marca_prod.Location = new System.Drawing.Point(65, 152);
            this.Marca_prod.Name = "Marca_prod";
            this.Marca_prod.Size = new System.Drawing.Size(76, 19);
            this.Marca_prod.TabIndex = 21;
            this.Marca_prod.Text = "Categoria";
            // 
            // txtRef
            // 
            this.txtRef.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRef.Location = new System.Drawing.Point(69, 96);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(313, 27);
            this.txtRef.TabIndex = 20;
            // 
            // Descripcion_prod
            // 
            this.Descripcion_prod.AutoSize = true;
            this.Descripcion_prod.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion_prod.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Descripcion_prod.Location = new System.Drawing.Point(65, 74);
            this.Descripcion_prod.Name = "Descripcion_prod";
            this.Descripcion_prod.Size = new System.Drawing.Size(82, 19);
            this.Descripcion_prod.TabIndex = 19;
            this.Descripcion_prod.Text = "Referencia";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(442, 96);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(313, 27);
            this.txtNombre.TabIndex = 18;
            // 
            // Nombre_prod
            // 
            this.Nombre_prod.AutoSize = true;
            this.Nombre_prod.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_prod.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Nombre_prod.Location = new System.Drawing.Point(438, 74);
            this.Nombre_prod.Name = "Nombre_prod";
            this.Nombre_prod.Size = new System.Drawing.Size(66, 19);
            this.Nombre_prod.TabIndex = 17;
            this.Nombre_prod.Text = "Nombre";
            // 
            // btnSaveProd
            // 
            this.btnSaveProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.btnSaveProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveProd.FlatAppearance.BorderSize = 0;
            this.btnSaveProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(213)))), ((int)(((byte)(184)))));
            this.btnSaveProd.Location = new System.Drawing.Point(519, 324);
            this.btnSaveProd.Name = "btnSaveProd";
            this.btnSaveProd.Size = new System.Drawing.Size(159, 35);
            this.btnSaveProd.TabIndex = 29;
            this.btnSaveProd.Text = "Guardar";
            this.btnSaveProd.UseVisualStyleBackColor = false;
            this.btnSaveProd.Click += new System.EventHandler(this.btnSaveProd_Click);
            // 
            // txtCantMin
            // 
            this.txtCantMin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantMin.Location = new System.Drawing.Point(69, 254);
            this.txtCantMin.Name = "txtCantMin";
            this.txtCantMin.Size = new System.Drawing.Size(313, 27);
            this.txtCantMin.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(65, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Cantidad Minima";
            // 
            // FormProductsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(111)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(816, 408);
            this.Controls.Add(this.txtCantMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveProd);
            this.Controls.Add(this.txtCantStock);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.Nombre_prod);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.Precio_venta_prod);
            this.Controls.Add(this.Descripcion_prod);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.Precio_compra_prod);
            this.Controls.Add(this.Marca_prod);
            this.Controls.Add(this.txtCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductsAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAgregarProducto";
            this.Load += new System.EventHandler(this.FormAgregarProducto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaxApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.Label Precio_venta_prod;
        private System.Windows.Forms.Label Precio_compra_prod;
        private System.Windows.Forms.Label Marca_prod;
        private System.Windows.Forms.Label Descripcion_prod;
        private System.Windows.Forms.Label Nombre_prod;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.PictureBox btnMinApp;
        private System.Windows.Forms.PictureBox btnResApp;
        private System.Windows.Forms.PictureBox btnMaxApp;
        private System.Windows.Forms.PictureBox btnCloseApp;
        private System.Windows.Forms.Button btnSaveProd;
        public System.Windows.Forms.TextBox txtCantStock;
        public System.Windows.Forms.TextBox txtPrecioVenta;
        public System.Windows.Forms.TextBox txtPrecioCompra;
        public System.Windows.Forms.TextBox txtCategoria;
        public System.Windows.Forms.TextBox txtRef;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtCantMin;
        private System.Windows.Forms.Label label1;
    }
}