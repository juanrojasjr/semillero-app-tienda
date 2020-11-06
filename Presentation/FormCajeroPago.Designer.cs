namespace Presentation
{
    partial class FormCajeroPago
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
            this.ImgPrint = new System.Windows.Forms.PictureBox();
            this.btnCloseApp = new System.Windows.Forms.PictureBox();
            this.txtRecep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPriceTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseApp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.ImgPrint);
            this.panel1.Controls.Add(this.btnCloseApp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 7);
            this.panel1.Size = new System.Drawing.Size(383, 51);
            this.panel1.TabIndex = 5;
            // 
            // ImgPrint
            // 
            this.ImgPrint.Image = global::Presentation.Properties.Resources.printer;
            this.ImgPrint.Location = new System.Drawing.Point(9, 9);
            this.ImgPrint.Name = "ImgPrint";
            this.ImgPrint.Size = new System.Drawing.Size(32, 32);
            this.ImgPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgPrint.TabIndex = 11;
            this.ImgPrint.TabStop = false;
            this.ImgPrint.Visible = false;
            this.ImgPrint.Click += new System.EventHandler(this.ImgPrint_Click);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseApp.Image = global::Presentation.Properties.Resources.close_icon;
            this.btnCloseApp.Location = new System.Drawing.Point(349, 13);
            this.btnCloseApp.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(24, 24);
            this.btnCloseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCloseApp.TabIndex = 10;
            this.btnCloseApp.TabStop = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // txtRecep
            // 
            this.txtRecep.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecep.Location = new System.Drawing.Point(123, 109);
            this.txtRecep.Name = "txtRecep";
            this.txtRecep.Size = new System.Drawing.Size(143, 27);
            this.txtRecep.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(166, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Recibo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(100, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(143, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total a pagar";
            // 
            // lblPriceTotal
            // 
            this.lblPriceTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblPriceTotal.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(213)))), ((int)(((byte)(184)))));
            this.lblPriceTotal.Location = new System.Drawing.Point(68, 235);
            this.lblPriceTotal.Name = "lblPriceTotal";
            this.lblPriceTotal.Size = new System.Drawing.Size(253, 33);
            this.lblPriceTotal.TabIndex = 10;
            this.lblPriceTotal.Text = "Total a pagar";
            this.lblPriceTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(163, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cambio";
            // 
            // lblChange
            // 
            this.lblChange.BackColor = System.Drawing.Color.Transparent;
            this.lblChange.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(213)))), ((int)(((byte)(184)))));
            this.lblChange.Location = new System.Drawing.Point(79, 318);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(231, 23);
            this.lblChange.TabIndex = 12;
            this.lblChange.Text = "Cambio";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblChange.Visible = false;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(213)))), ((int)(((byte)(184)))));
            this.btnPayment.Location = new System.Drawing.Point(138, 143);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(112, 34);
            this.btnPayment.TabIndex = 13;
            this.btnPayment.Text = "Pagar";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Image = global::Presentation.Properties.Resources.error;
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError.Location = new System.Drawing.Point(84, 181);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(220, 16);
            this.lblError.TabIndex = 14;
            this.lblError.Text = "        Debe ser mayor al precio total.";
            this.lblError.Visible = false;
            // 
            // FormCajeroPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(111)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(383, 384);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPriceTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRecep);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCajeroPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCajeroPago";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCloseApp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRecep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.PictureBox ImgPrint;
        public System.Windows.Forms.Label lblPriceTotal;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lblError;
    }
}