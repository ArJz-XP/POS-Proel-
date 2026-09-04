namespace TBIC
{
    partial class TransactionHistory
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblIDs = new System.Windows.Forms.Label();
            this.lblUsernameNumba = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtSearchBoxSearchHistory = new System.Windows.Forms.TextBox();
            this.btnTransactionHistory = new System.Windows.Forms.Button();
            this.btnNewPurchase = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(965, 372);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblIDs);
            this.panel3.Controls.Add(this.lblUsernameNumba);
            this.panel3.Controls.Add(this.lblUserID);
            this.panel3.Controls.Add(this.lblUsername);
            this.panel3.Location = new System.Drawing.Point(1121, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(118, 28);
            this.panel3.TabIndex = 27;
            // 
            // lblIDs
            // 
            this.lblIDs.AutoSize = true;
            this.lblIDs.Location = new System.Drawing.Point(20, 14);
            this.lblIDs.Name = "lblIDs";
            this.lblIDs.Size = new System.Drawing.Size(21, 13);
            this.lblIDs.TabIndex = 14;
            this.lblIDs.Text = "ID:";
            // 
            // lblUsernameNumba
            // 
            this.lblUsernameNumba.AutoSize = true;
            this.lblUsernameNumba.Location = new System.Drawing.Point(9, 2);
            this.lblUsernameNumba.Name = "lblUsernameNumba";
            this.lblUsernameNumba.Size = new System.Drawing.Size(32, 13);
            this.lblUsernameNumba.TabIndex = 13;
            this.lblUsernameNumba.Text = "User:";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(41, 14);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(19, 13);
            this.lblUserID.TabIndex = 12;
            this.lblUserID.Text = "69";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(41, 2);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(22, 13);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "Me";
            // 
            // txtSearchBoxSearchHistory
            // 
            this.txtSearchBoxSearchHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchBoxSearchHistory.Location = new System.Drawing.Point(264, 111);
            this.txtSearchBoxSearchHistory.Multiline = true;
            this.txtSearchBoxSearchHistory.Name = "txtSearchBoxSearchHistory";
            this.txtSearchBoxSearchHistory.Size = new System.Drawing.Size(274, 31);
            this.txtSearchBoxSearchHistory.TabIndex = 28;
            this.txtSearchBoxSearchHistory.Text = "Finding History";
            // 
            // btnTransactionHistory
            // 
            this.btnTransactionHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnTransactionHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTransactionHistory.FlatAppearance.BorderSize = 0;
            this.btnTransactionHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionHistory.Image = global::TBIC.Properties.Resources.TransactionHistoryBtnUI;
            this.btnTransactionHistory.Location = new System.Drawing.Point(1068, 178);
            this.btnTransactionHistory.Name = "btnTransactionHistory";
            this.btnTransactionHistory.Size = new System.Drawing.Size(214, 59);
            this.btnTransactionHistory.TabIndex = 30;
            this.btnTransactionHistory.UseVisualStyleBackColor = false;
            // 
            // btnNewPurchase
            // 
            this.btnNewPurchase.BackColor = System.Drawing.Color.Transparent;
            this.btnNewPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewPurchase.FlatAppearance.BorderSize = 0;
            this.btnNewPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPurchase.Image = global::TBIC.Properties.Resources.NewPurchaseBtnUI;
            this.btnNewPurchase.Location = new System.Drawing.Point(1068, 111);
            this.btnNewPurchase.Name = "btnNewPurchase";
            this.btnNewPurchase.Size = new System.Drawing.Size(214, 41);
            this.btnNewPurchase.TabIndex = 29;
            this.btnNewPurchase.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TBIC.Properties.Resources.TransactionHistoryBG;
            this.pictureBox1.Location = new System.Drawing.Point(-7, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1272, 680);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 641);
            this.Controls.Add(this.btnTransactionHistory);
            this.Controls.Add(this.btnNewPurchase);
            this.Controls.Add(this.txtSearchBoxSearchHistory);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TransactionHistory";
            this.Text = "TransactionHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblIDs;
        private System.Windows.Forms.Label lblUsernameNumba;
        public System.Windows.Forms.Label lblUserID;
        public System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtSearchBoxSearchHistory;
        private System.Windows.Forms.Button btnNewPurchase;
        private System.Windows.Forms.Button btnTransactionHistory;
    }
}