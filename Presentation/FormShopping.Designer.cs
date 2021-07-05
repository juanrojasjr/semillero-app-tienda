namespace Presentation
{
    partial class FormShopping
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
            this.picHistory = new System.Windows.Forms.PictureBox();
            this.btnBuyAdd = new System.Windows.Forms.PictureBox();
            this.btnMinApp = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.btnCloseApp = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.btnConsult = new System.Windows.Forms.Button();
            this.lblSelected = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlFields = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPriceSale = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPriceBuy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblQuantityTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtAddQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlProvider = new System.Windows.Forms.Panel();
            this.cbProvider = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.dgvAllShopping = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuyAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlFields.SuspendLayout();
            this.pnlProvider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllShopping)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.picHistory);
            this.panel1.Controls.Add(this.btnBuyAdd);
            this.panel1.Controls.Add(this.btnMinApp);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnCloseApp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(9, 9, 9, 10);
            this.panel1.Size = new System.Drawing.Size(940, 59);
            this.panel1.TabIndex = 5;
            // 
            // picHistory
            // 
            this.picHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHistory.Image = global::Presentation.Properties.Resources.history;
            this.picHistory.Location = new System.Drawing.Point(97, 11);
            this.picHistory.Margin = new System.Windows.Forms.Padding(4);
            this.picHistory.Name = "picHistory";
            this.picHistory.Size = new System.Drawing.Size(32, 32);
            this.picHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHistory.TabIndex = 12;
            this.picHistory.TabStop = false;
            this.picHistory.Click += new System.EventHandler(this.picHistory_Click);
            // 
            // btnBuyAdd
            // 
            this.btnBuyAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuyAdd.Image = global::Presentation.Properties.Resources.add1;
            this.btnBuyAdd.Location = new System.Drawing.Point(57, 11);
            this.btnBuyAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuyAdd.Name = "btnBuyAdd";
            this.btnBuyAdd.Size = new System.Drawing.Size(32, 32);
            this.btnBuyAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuyAdd.TabIndex = 9;
            this.btnBuyAdd.TabStop = false;
            this.btnBuyAdd.Click += new System.EventHandler(this.btnBuyAdd_Click);
            // 
            // btnMinApp
            // 
            this.btnMinApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinApp.Image = global::Presentation.Properties.Resources.minimize_icon;
            this.btnMinApp.Location = new System.Drawing.Point(872, 15);
            this.btnMinApp.Margin = new System.Windows.Forms.Padding(6);
            this.btnMinApp.Name = "btnMinApp";
            this.btnMinApp.Size = new System.Drawing.Size(24, 24);
            this.btnMinApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinApp.TabIndex = 11;
            this.btnMinApp.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::Presentation.Properties.Resources.previous2;
            this.btnBack.Location = new System.Drawing.Point(15, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 32);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 0;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseApp.Image = global::Presentation.Properties.Resources.close_icon;
            this.btnCloseApp.Location = new System.Drawing.Point(899, 15);
            this.btnCloseApp.Margin = new System.Windows.Forms.Padding(6);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(24, 24);
            this.btnCloseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCloseApp.TabIndex = 10;
            this.btnCloseApp.TabStop = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre o referencia del producto";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(17, 96);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(257, 27);
            this.txtProduct.TabIndex = 7;
            this.txtProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProduct_KeyPress);
            // 
            // btnConsult
            // 
            this.btnConsult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.btnConsult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsult.FlatAppearance.BorderSize = 0;
            this.btnConsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsult.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(213)))), ((int)(((byte)(184)))));
            this.btnConsult.Location = new System.Drawing.Point(300, 89);
            this.btnConsult.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(112, 34);
            this.btnConsult.TabIndex = 16;
            this.btnConsult.Text = "Buscar";
            this.btnConsult.UseVisualStyleBackColor = false;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.ForeColor = System.Drawing.Color.White;
            this.lblSelected.Location = new System.Drawing.Point(435, 97);
            this.lblSelected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(167, 19);
            this.lblSelected.TabIndex = 18;
            this.lblSelected.Text = "Selecciona el producto";
            this.lblSelected.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(908, 275);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pnlFields
            // 
            this.pnlFields.Controls.Add(this.lblId);
            this.pnlFields.Controls.Add(this.lblTotalPrice);
            this.pnlFields.Controls.Add(this.label8);
            this.pnlFields.Controls.Add(this.txtPriceSale);
            this.pnlFields.Controls.Add(this.label6);
            this.pnlFields.Controls.Add(this.txtPriceBuy);
            this.pnlFields.Controls.Add(this.label5);
            this.pnlFields.Controls.Add(this.lblQuantityTotal);
            this.pnlFields.Controls.Add(this.label4);
            this.pnlFields.Controls.Add(this.lblQuantity);
            this.pnlFields.Controls.Add(this.txtAddQuantity);
            this.pnlFields.Controls.Add(this.label3);
            this.pnlFields.Controls.Add(this.label2);
            this.pnlFields.Location = new System.Drawing.Point(17, 422);
            this.pnlFields.Name = "pnlFields";
            this.pnlFields.Size = new System.Drawing.Size(619, 152);
            this.pnlFields.TabIndex = 20;
            this.pnlFields.Visible = false;
            this.pnlFields.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFields_Paint);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(3, -1);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 25;
            this.lblId.Text = "ID";
            this.lblId.Visible = false;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalPrice.Location = new System.Drawing.Point(468, 112);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(117, 19);
            this.lblTotalPrice.TabIndex = 24;
            this.lblTotalPrice.Text = "Cantidad total";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(481, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Total a pagar";
            // 
            // txtPriceSale
            // 
            this.txtPriceSale.Location = new System.Drawing.Point(250, 104);
            this.txtPriceSale.Name = "txtPriceSale";
            this.txtPriceSale.Size = new System.Drawing.Size(145, 27);
            this.txtPriceSale.TabIndex = 22;
            this.txtPriceSale.Text = "Cantidad";
            this.txtPriceSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(274, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Precio de venta";
            // 
            // txtPriceBuy
            // 
            this.txtPriceBuy.Location = new System.Drawing.Point(34, 104);
            this.txtPriceBuy.Name = "txtPriceBuy";
            this.txtPriceBuy.Size = new System.Drawing.Size(129, 27);
            this.txtPriceBuy.TabIndex = 8;
            this.txtPriceBuy.Text = "Cantidad";
            this.txtPriceBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPriceBuy.TextChanged += new System.EventHandler(this.txtPriceProv_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(44, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Precio de compra";
            // 
            // lblQuantityTotal
            // 
            this.lblQuantityTotal.ForeColor = System.Drawing.Color.White;
            this.lblQuantityTotal.Location = new System.Drawing.Point(468, 47);
            this.lblQuantityTotal.Name = "lblQuantityTotal";
            this.lblQuantityTotal.Size = new System.Drawing.Size(117, 19);
            this.lblQuantityTotal.TabIndex = 6;
            this.lblQuantityTotal.Text = "Cantidad total";
            this.lblQuantityTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(481, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad total";
            // 
            // lblQuantity
            // 
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(25, 43);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(146, 19);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Cantidad actual";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAddQuantity
            // 
            this.txtAddQuantity.Location = new System.Drawing.Point(250, 39);
            this.txtAddQuantity.Name = "txtAddQuantity";
            this.txtAddQuantity.Size = new System.Drawing.Size(145, 27);
            this.txtAddQuantity.TabIndex = 3;
            this.txtAddQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAddQuantity.TextChanged += new System.EventHandler(this.txtAddQuantity_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(295, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Agregar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cantidad actual";
            // 
            // pnlProvider
            // 
            this.pnlProvider.Controls.Add(this.cbProvider);
            this.pnlProvider.Controls.Add(this.label9);
            this.pnlProvider.Controls.Add(this.txtBill);
            this.pnlProvider.Controls.Add(this.label7);
            this.pnlProvider.Location = new System.Drawing.Point(655, 422);
            this.pnlProvider.Name = "pnlProvider";
            this.pnlProvider.Size = new System.Drawing.Size(268, 152);
            this.pnlProvider.TabIndex = 21;
            this.pnlProvider.Visible = false;
            this.pnlProvider.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cbProvider
            // 
            this.cbProvider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbProvider.FormattingEnabled = true;
            this.cbProvider.Location = new System.Drawing.Point(79, 108);
            this.cbProvider.Name = "cbProvider";
            this.cbProvider.Size = new System.Drawing.Size(121, 27);
            this.cbProvider.TabIndex = 25;
            this.cbProvider.SelectedValueChanged += new System.EventHandler(this.cbProvider_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(106, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Proveedor";
            // 
            // txtBill
            // 
            this.txtBill.Location = new System.Drawing.Point(89, 39);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(100, 27);
            this.txtBill.TabIndex = 5;
            this.txtBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(76, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "# Factura proveedor";
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.Enabled = false;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(213)))), ((int)(((byte)(184)))));
            this.btnContinue.Location = new System.Drawing.Point(17, 588);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(4);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(906, 34);
            this.btnContinue.TabIndex = 22;
            this.btnContinue.Text = "Continuar";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // dgvAllShopping
            // 
            this.dgvAllShopping.AllowUserToAddRows = false;
            this.dgvAllShopping.AllowUserToDeleteRows = false;
            this.dgvAllShopping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllShopping.Location = new System.Drawing.Point(15, 74);
            this.dgvAllShopping.Name = "dgvAllShopping";
            this.dgvAllShopping.ReadOnly = true;
            this.dgvAllShopping.Size = new System.Drawing.Size(908, 500);
            this.dgvAllShopping.TabIndex = 23;
            this.dgvAllShopping.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(213)))), ((int)(((byte)(184)))));
            this.btnCancel.Location = new System.Drawing.Point(18, 588);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(905, 34);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormShopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(111)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(940, 635);
            this.Controls.Add(this.dgvAllShopping);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.btnConsult);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.pnlFields);
            this.Controls.Add(this.pnlProvider);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormShopping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuyAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlFields.ResumeLayout(false);
            this.pnlFields.PerformLayout();
            this.pnlProvider.ResumeLayout(false);
            this.pnlProvider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllShopping)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMinApp;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.PictureBox btnCloseApp;
        private System.Windows.Forms.PictureBox btnBuyAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Button btnConsult;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlFields;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPriceSale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPriceBuy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblQuantityTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtAddQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel pnlProvider;
        private System.Windows.Forms.ComboBox cbProvider;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.PictureBox picHistory;
        private System.Windows.Forms.DataGridView dgvAllShopping;
        private System.Windows.Forms.Button btnCancel;
    }
}