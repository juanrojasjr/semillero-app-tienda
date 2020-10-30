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
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.btnReturnShop = new System.Windows.Forms.PictureBox();
            this.txtSaludo = new System.Windows.Forms.Label();
            this.txtNumFactura = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturnShop)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.txtSaludo);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnReturnShop);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 54);
            this.panel1.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::Presentation.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(57, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(29, 32);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAdd.TabIndex = 2;
            this.btnAdd.TabStop = false;
            // 
            // btnReturnShop
            // 
            this.btnReturnShop.Image = global::Presentation.Properties.Resources.previous2;
            this.btnReturnShop.Location = new System.Drawing.Point(12, 9);
            this.btnReturnShop.Name = "btnReturnShop";
            this.btnReturnShop.Size = new System.Drawing.Size(29, 32);
            this.btnReturnShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReturnShop.TabIndex = 1;
            this.btnReturnShop.TabStop = false;
            // 
            // txtSaludo
            // 
            this.txtSaludo.AutoSize = true;
            this.txtSaludo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaludo.ForeColor = System.Drawing.Color.White;
            this.txtSaludo.Location = new System.Drawing.Point(462, 17);
            this.txtSaludo.Name = "txtSaludo";
            this.txtSaludo.Size = new System.Drawing.Size(51, 19);
            this.txtSaludo.TabIndex = 3;
            this.txtSaludo.Text = "Hola, ";
            // 
            // txtNumFactura
            // 
            this.txtNumFactura.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumFactura.Location = new System.Drawing.Point(34, 60);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.Size = new System.Drawing.Size(393, 27);
            this.txtNumFactura.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 322);
            this.panel2.TabIndex = 5;
            // 
            // FormShopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(111)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtNumFactura);
            this.Controls.Add(this.panel1);
            this.Name = "FormShopping";
            this.Text = "Compras";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturnShop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnReturnShop;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.Label txtSaludo;
        private System.Windows.Forms.TextBox txtNumFactura;
        private System.Windows.Forms.Panel panel2;
    }
}