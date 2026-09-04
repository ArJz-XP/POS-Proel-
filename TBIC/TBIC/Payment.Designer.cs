namespace TBIC
{
    partial class Payment
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
            this.components = new System.ComponentModel.Container();
            this.dvgPOS = new System.Windows.Forms.DataGridView();
            this.dvgItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFlavour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Minus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dvgPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgDiscount = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seniorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pWDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewPurchase = new System.Windows.Forms.Button();
            this.btnTransHistory = new System.Windows.Forms.Button();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.txtMOP = new System.Windows.Forms.TextBox();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtDiscount = new System.Windows.Forms.RichTextBox();
            this.rtxtTotalPrice = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMOP = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.picIDK = new System.Windows.Forms.PictureBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnConfirmPrint = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eWalletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblIDs = new System.Windows.Forms.Label();
            this.lblUsernameNumba = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPOS)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIDK)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgPOS
            // 
            this.dvgPOS.AllowUserToAddRows = false;
            this.dvgPOS.AllowUserToDeleteRows = false;
            this.dvgPOS.AllowUserToResizeColumns = false;
            this.dvgPOS.AllowUserToResizeRows = false;
            this.dvgPOS.BackgroundColor = System.Drawing.Color.White;
            this.dvgPOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvgItemId,
            this.dvgItemName,
            this.dgvFlavour,
            this.dvgQuantity,
            this.Plus,
            this.Minus,
            this.dvgPrice,
            this.dvgDiscount});
            this.dvgPOS.GridColor = System.Drawing.Color.White;
            this.dvgPOS.Location = new System.Drawing.Point(20, 51);
            this.dvgPOS.Name = "dvgPOS";
            this.dvgPOS.RowHeadersWidth = 51;
            this.dvgPOS.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dvgPOS.Size = new System.Drawing.Size(961, 293);
            this.dvgPOS.TabIndex = 1;
            this.dvgPOS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgPOS_CellContentClick);
            this.dvgPOS.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgPOS_CellValueChanged);
            this.dvgPOS.CurrentCellDirtyStateChanged += new System.EventHandler(this.dvgPOS_CurrentCellDirtyStateChanged);
            // 
            // dvgItemId
            // 
            this.dvgItemId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgItemId.FillWeight = 159.2357F;
            this.dvgItemId.HeaderText = "ITEM ID";
            this.dvgItemId.MinimumWidth = 6;
            this.dvgItemId.Name = "dvgItemId";
            this.dvgItemId.ReadOnly = true;
            this.dvgItemId.Width = 70;
            // 
            // dvgItemName
            // 
            this.dvgItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgItemName.FillWeight = 121.6078F;
            this.dvgItemName.HeaderText = "ITEM NAME";
            this.dvgItemName.MinimumWidth = 6;
            this.dvgItemName.Name = "dvgItemName";
            this.dvgItemName.ReadOnly = true;
            this.dvgItemName.Width = 250;
            // 
            // dgvFlavour
            // 
            this.dgvFlavour.HeaderText = "FLAVOUR";
            this.dgvFlavour.MinimumWidth = 6;
            this.dgvFlavour.Name = "dgvFlavour";
            this.dgvFlavour.ReadOnly = true;
            this.dgvFlavour.Width = 150;
            // 
            // dvgQuantity
            // 
            this.dvgQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgQuantity.FillWeight = 73.0522F;
            this.dvgQuantity.HeaderText = "QUANTITY";
            this.dvgQuantity.MinimumWidth = 6;
            this.dvgQuantity.Name = "dvgQuantity";
            this.dvgQuantity.ReadOnly = true;
            this.dvgQuantity.Width = 126;
            // 
            // Plus
            // 
            this.Plus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Plus.HeaderText = "";
            this.Plus.MinimumWidth = 6;
            this.Plus.Name = "Plus";
            this.Plus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Plus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Plus.Text = "+";
            this.Plus.Width = 20;
            // 
            // Minus
            // 
            this.Minus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Minus.HeaderText = "";
            this.Minus.MinimumWidth = 6;
            this.Minus.Name = "Minus";
            this.Minus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Minus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Minus.Text = "-";
            this.Minus.Width = 20;
            // 
            // dvgPrice
            // 
            this.dvgPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgPrice.FillWeight = 73.0522F;
            this.dvgPrice.HeaderText = "PRICE";
            this.dvgPrice.MinimumWidth = 6;
            this.dvgPrice.Name = "dvgPrice";
            this.dvgPrice.ReadOnly = true;
            this.dvgPrice.Width = 127;
            // 
            // dvgDiscount
            // 
            this.dvgDiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgDiscount.ContextMenuStrip = this.contextMenuStrip1;
            this.dvgDiscount.FillWeight = 73.0522F;
            this.dvgDiscount.HeaderText = "DISCOUNT";
            this.dvgDiscount.Items.AddRange(new object[] {
            "Senior",
            "Student",
            "PWD",
            "None"});
            this.dvgDiscount.MinimumWidth = 6;
            this.dvgDiscount.Name = "dvgDiscount";
            this.dvgDiscount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgDiscount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dvgDiscount.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem,
            this.seniorToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.pWDToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 92);
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.noneToolStripMenuItem.Text = "None";
            this.noneToolStripMenuItem.Click += new System.EventHandler(this.noneToolStripMenuItem_Click);
            // 
            // seniorToolStripMenuItem
            // 
            this.seniorToolStripMenuItem.Name = "seniorToolStripMenuItem";
            this.seniorToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.seniorToolStripMenuItem.Text = "Senior";
            this.seniorToolStripMenuItem.Click += new System.EventHandler(this.seniorToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // pWDToolStripMenuItem
            // 
            this.pWDToolStripMenuItem.Name = "pWDToolStripMenuItem";
            this.pWDToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.pWDToolStripMenuItem.Text = "PWD";
            this.pWDToolStripMenuItem.Click += new System.EventHandler(this.pWDToolStripMenuItem_Click);
            // 
            // btnNewPurchase
            // 
            this.btnNewPurchase.BackColor = System.Drawing.Color.Transparent;
            this.btnNewPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewPurchase.FlatAppearance.BorderSize = 0;
            this.btnNewPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPurchase.Image = global::TBIC.Properties.Resources.NewPurchaseBtnUI1;
            this.btnNewPurchase.Location = new System.Drawing.Point(1069, 99);
            this.btnNewPurchase.Name = "btnNewPurchase";
            this.btnNewPurchase.Size = new System.Drawing.Size(214, 47);
            this.btnNewPurchase.TabIndex = 2;
            this.btnNewPurchase.UseVisualStyleBackColor = false;
            this.btnNewPurchase.Click += new System.EventHandler(this.btnNewPurchase_Click);
            // 
            // btnTransHistory
            // 
            this.btnTransHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnTransHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTransHistory.FlatAppearance.BorderSize = 0;
            this.btnTransHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransHistory.Image = global::TBIC.Properties.Resources.TransactionHistoryBtnUI1;
            this.btnTransHistory.Location = new System.Drawing.Point(1069, 165);
            this.btnTransHistory.Name = "btnTransHistory";
            this.btnTransHistory.Size = new System.Drawing.Size(217, 65);
            this.btnTransHistory.TabIndex = 3;
            this.btnTransHistory.UseVisualStyleBackColor = false;
            // 
            // txtOrderId
            // 
            this.txtOrderId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderId.Location = new System.Drawing.Point(81, 19);
            this.txtOrderId.Multiline = true;
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(199, 26);
            this.txtOrderId.TabIndex = 4;
            this.txtOrderId.Text = "#123456789";
            // 
            // txtMOP
            // 
            this.txtMOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMOP.Location = new System.Drawing.Point(293, 19);
            this.txtMOP.Multiline = true;
            this.txtMOP.Name = "txtMOP";
            this.txtMOP.Size = new System.Drawing.Size(199, 26);
            this.txtMOP.TabIndex = 5;
            this.txtMOP.Text = "Cash";
            // 
            // pnlBackground
            // 
            this.pnlBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBackground.Controls.Add(this.panel2);
            this.pnlBackground.Controls.Add(this.panel1);
            this.pnlBackground.Controls.Add(this.btnMOP);
            this.pnlBackground.Controls.Add(this.btnCopy);
            this.pnlBackground.Controls.Add(this.picIDK);
            this.pnlBackground.Controls.Add(this.btnPrevious);
            this.pnlBackground.Controls.Add(this.btnNext);
            this.pnlBackground.Controls.Add(this.dvgPOS);
            this.pnlBackground.Controls.Add(this.txtMOP);
            this.pnlBackground.Controls.Add(this.txtOrderId);
            this.pnlBackground.Location = new System.Drawing.Point(16, 147);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1000, 430);
            this.pnlBackground.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.rtxtDiscount);
            this.panel2.Controls.Add(this.rtxtTotalPrice);
            this.panel2.Location = new System.Drawing.Point(675, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 73);
            this.panel2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DISCOUNTS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TOTAL PRICE";
            // 
            // rtxtDiscount
            // 
            this.rtxtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtDiscount.Location = new System.Drawing.Point(162, 27);
            this.rtxtDiscount.Name = "rtxtDiscount";
            this.rtxtDiscount.Size = new System.Drawing.Size(139, 41);
            this.rtxtDiscount.TabIndex = 1;
            this.rtxtDiscount.Text = "";
            // 
            // rtxtTotalPrice
            // 
            this.rtxtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtTotalPrice.Location = new System.Drawing.Point(3, 27);
            this.rtxtTotalPrice.Name = "rtxtTotalPrice";
            this.rtxtTotalPrice.Size = new System.Drawing.Size(157, 41);
            this.rtxtTotalPrice.TabIndex = 0;
            this.rtxtTotalPrice.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(20, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 73);
            this.panel1.TabIndex = 14;
            // 
            // btnMOP
            // 
            this.btnMOP.BackColor = System.Drawing.Color.Transparent;
            this.btnMOP.BackgroundImage = global::TBIC.Properties.Resources.wallet;
            this.btnMOP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMOP.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMOP.FlatAppearance.BorderSize = 0;
            this.btnMOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMOP.Location = new System.Drawing.Point(469, 22);
            this.btnMOP.Margin = new System.Windows.Forms.Padding(2);
            this.btnMOP.Name = "btnMOP";
            this.btnMOP.Size = new System.Drawing.Size(20, 20);
            this.btnMOP.TabIndex = 13;
            this.btnMOP.UseVisualStyleBackColor = false;
            this.btnMOP.Click += new System.EventHandler(this.btnMOP_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.Transparent;
            this.btnCopy.BackgroundImage = global::TBIC.Properties.Resources.copy;
            this.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Location = new System.Drawing.Point(255, 22);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(21, 20);
            this.btnCopy.TabIndex = 12;
            this.btnCopy.UseVisualStyleBackColor = false;
            // 
            // picIDK
            // 
            this.picIDK.BackColor = System.Drawing.Color.Transparent;
            this.picIDK.BackgroundImage = global::TBIC.Properties.Resources.PROEL2D_UI__4_;
            this.picIDK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picIDK.Location = new System.Drawing.Point(20, 10);
            this.picIDK.Margin = new System.Windows.Forms.Padding(2);
            this.picIDK.Name = "picIDK";
            this.picIDK.Size = new System.Drawing.Size(34, 35);
            this.picIDK.TabIndex = 10;
            this.picIDK.TabStop = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.BackgroundImage = global::TBIC.Properties.Resources.PROEL2D_UI__1_;
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrevious.Location = new System.Drawing.Point(919, 22);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(28, 24);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = global::TBIC.Properties.Resources.PROEL2D_UI__2_;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Location = new System.Drawing.Point(952, 22);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(28, 24);
            this.btnNext.TabIndex = 8;
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnConfirmPrint
            // 
            this.btnConfirmPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmPrint.BackgroundImage = global::TBIC.Properties.Resources.PROEL2D_UI__3_;
            this.btnConfirmPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmPrint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfirmPrint.FlatAppearance.BorderSize = 0;
            this.btnConfirmPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPrint.Location = new System.Drawing.Point(779, 582);
            this.btnConfirmPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmPrint.Name = "btnConfirmPrint";
            this.btnConfirmPrint.Size = new System.Drawing.Size(237, 48);
            this.btnConfirmPrint.TabIndex = 7;
            this.btnConfirmPrint.UseVisualStyleBackColor = false;
            this.btnConfirmPrint.Click += new System.EventHandler(this.btnConfirmPrint_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(89)))));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1140, 590);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(112, 34);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cashToolStripMenuItem,
            this.cardToolStripMenuItem,
            this.eWalletToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(119, 70);
            // 
            // cashToolStripMenuItem
            // 
            this.cashToolStripMenuItem.Name = "cashToolStripMenuItem";
            this.cashToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.cashToolStripMenuItem.Text = "Cash";
            this.cashToolStripMenuItem.Click += new System.EventHandler(this.cashToolStripMenuItem_Click);
            // 
            // cardToolStripMenuItem
            // 
            this.cardToolStripMenuItem.Name = "cardToolStripMenuItem";
            this.cardToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.cardToolStripMenuItem.Text = "Card";
            this.cardToolStripMenuItem.Click += new System.EventHandler(this.cardToolStripMenuItem_Click);
            // 
            // eWalletToolStripMenuItem
            // 
            this.eWalletToolStripMenuItem.Name = "eWalletToolStripMenuItem";
            this.eWalletToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.eWalletToolStripMenuItem.Text = "E-Wallet";
            this.eWalletToolStripMenuItem.Click += new System.EventHandler(this.eWalletToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblIDs);
            this.panel3.Controls.Add(this.lblUsernameNumba);
            this.panel3.Controls.Add(this.lblUserID);
            this.panel3.Controls.Add(this.lblUsername);
            this.panel3.Location = new System.Drawing.Point(1122, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(118, 28);
            this.panel3.TabIndex = 25;
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
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TBIC.Properties.Resources.POSPaymentReyal_Updated_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 641);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnConfirmPrint);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.btnTransHistory);
            this.Controls.Add(this.btnNewPurchase);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgPOS)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIDK)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNewPurchase;
        private System.Windows.Forms.Button btnTransHistory;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.TextBox txtMOP;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Button btnConfirmPrint;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox picIDK;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMOP;
        private System.Windows.Forms.Button btnCopy;
        public System.Windows.Forms.DataGridView dvgPOS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seniorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pWDToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFlavour;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgQuantity;
        private System.Windows.Forms.DataGridViewButtonColumn Plus;
        private System.Windows.Forms.DataGridViewButtonColumn Minus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgPrice;
        private System.Windows.Forms.DataGridViewComboBoxColumn dvgDiscount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eWalletToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblIDs;
        private System.Windows.Forms.Label lblUsernameNumba;
        public System.Windows.Forms.Label lblUserID;
        public System.Windows.Forms.Label lblUsername;
        public System.Windows.Forms.RichTextBox rtxtDiscount;
        public System.Windows.Forms.RichTextBox rtxtTotalPrice;
    }
}