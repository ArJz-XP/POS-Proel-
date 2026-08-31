namespace TBIC
{
    partial class Receipt
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTBCInc = new System.Windows.Forms.Label();
            this.lvReciept = new System.Windows.Forms.ListView();
            this.lvItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblReciept = new System.Windows.Forms.Label();
            this.lblDatelabel = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCName = new System.Windows.Forms.Label();
            this.lblCashier = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDiscounts = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::TBIC.Properties.Resources.Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(107, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 78);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Montserrat Subrayada", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(64, 93);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(168, 29);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = "MIGUELITOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "In partnership with";
            // 
            // lblTBCInc
            // 
            this.lblTBCInc.AutoSize = true;
            this.lblTBCInc.Font = new System.Drawing.Font("Noto Sans JP", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTBCInc.Location = new System.Drawing.Point(110, 136);
            this.lblTBCInc.Name = "lblTBCInc";
            this.lblTBCInc.Size = new System.Drawing.Size(65, 21);
            this.lblTBCInc.TabIndex = 3;
            this.lblTBCInc.Text = "TBC Inc";
            // 
            // lvReciept
            // 
            this.lvReciept.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvItemName,
            this.lvQuantity,
            this.lvPrice});
            this.lvReciept.GridLines = true;
            this.lvReciept.HideSelection = false;
            this.lvReciept.Location = new System.Drawing.Point(13, 256);
            this.lvReciept.Name = "lvReciept";
            this.lvReciept.Size = new System.Drawing.Size(287, 231);
            this.lvReciept.TabIndex = 4;
            this.lvReciept.UseCompatibleStateImageBehavior = false;
            this.lvReciept.View = System.Windows.Forms.View.Details;
            // 
            // lvItemName
            // 
            this.lvItemName.Text = "Item Name";
            this.lvItemName.Width = 100;
            // 
            // lvQuantity
            // 
            this.lvQuantity.Text = "Quantity";
            this.lvQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvQuantity.Width = 100;
            // 
            // lvPrice
            // 
            this.lvPrice.Text = "Price";
            this.lvPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvPrice.Width = 80;
            // 
            // lblReciept
            // 
            this.lblReciept.AutoSize = true;
            this.lblReciept.Font = new System.Drawing.Font("Noto Sans JP", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReciept.Location = new System.Drawing.Point(107, 184);
            this.lblReciept.Name = "lblReciept";
            this.lblReciept.Size = new System.Drawing.Size(72, 21);
            this.lblReciept.TabIndex = 5;
            this.lblReciept.Text = "RECIEPT";
            // 
            // lblDatelabel
            // 
            this.lblDatelabel.AutoSize = true;
            this.lblDatelabel.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatelabel.Location = new System.Drawing.Point(68, 211);
            this.lblDatelabel.Name = "lblDatelabel";
            this.lblDatelabel.Size = new System.Drawing.Size(46, 13);
            this.lblDatelabel.TabIndex = 6;
            this.lblDatelabel.Text = "DATE:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(120, 211);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(99, 13);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "DD/MM/YYYY";
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCName.Location = new System.Drawing.Point(120, 230);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(42, 13);
            this.lblCName.TabIndex = 9;
            this.lblCName.Text = "Name";
            // 
            // lblCashier
            // 
            this.lblCashier.AutoSize = true;
            this.lblCashier.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashier.Location = new System.Drawing.Point(45, 230);
            this.lblCashier.Name = "lblCashier";
            this.lblCashier.Size = new System.Drawing.Size(69, 13);
            this.lblCashier.TabIndex = 8;
            this.lblCashier.Text = "CASHIER:";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(111, 662);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblSubtotal);
            this.panel1.Controls.Add(this.lblDiscounts);
            this.panel1.Controls.Add(this.lblVat);
            this.panel1.Controls.Add(this.lblTotalItems);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 494);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 162);
            this.panel1.TabIndex = 11;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Noto Sans JP", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(118, 106);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(28, 21);
            this.lblSubtotal.TabIndex = 20;
            this.lblSubtotal.Text = "XX";
            // 
            // lblDiscounts
            // 
            this.lblDiscounts.AutoSize = true;
            this.lblDiscounts.Font = new System.Drawing.Font("Noto Sans JP", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscounts.Location = new System.Drawing.Point(118, 64);
            this.lblDiscounts.Name = "lblDiscounts";
            this.lblDiscounts.Size = new System.Drawing.Size(28, 21);
            this.lblDiscounts.TabIndex = 19;
            this.lblDiscounts.Text = "XX";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Font = new System.Drawing.Font("Noto Sans JP", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.Location = new System.Drawing.Point(118, 41);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(28, 21);
            this.lblVat.TabIndex = 18;
            this.lblVat.Text = "XX";
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Font = new System.Drawing.Font("Noto Sans JP", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItems.Location = new System.Drawing.Point(118, 9);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(28, 21);
            this.lblTotalItems.TabIndex = 17;
            this.lblTotalItems.Text = "XX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Sans JP", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "DISCOUNT/S:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans JP", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "VAT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans JP", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "SUBTOTAL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans JP", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "--------------------------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans JP", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "TOTAL ITEMS:";
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 698);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblCName);
            this.Controls.Add(this.lblCashier);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDatelabel);
            this.Controls.Add(this.lblReciept);
            this.Controls.Add(this.lvReciept);
            this.Controls.Add(this.lblTBCInc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Receipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Receipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTBCInc;
        private System.Windows.Forms.ListView lvReciept;
        private System.Windows.Forms.Label lblReciept;
        private System.Windows.Forms.Label lblDatelabel;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.Label lblCashier;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ColumnHeader lvItemName;
        private System.Windows.Forms.ColumnHeader lvQuantity;
        private System.Windows.Forms.ColumnHeader lvPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDiscounts;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}