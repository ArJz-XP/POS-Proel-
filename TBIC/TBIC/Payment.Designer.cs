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
            this.txtSearchBox = new System.Windows.Forms.TextBox();
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
            this.btnNewTable = new System.Windows.Forms.Button();
            this.btnPlace = new System.Windows.Forms.Button();
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
            this.picMaybedropbox = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eWalletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGoToDashBoard = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.picMaybedropbox)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchBox.Location = new System.Drawing.Point(296, 132);
            this.txtSearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchBox.Multiline = true;
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(265, 32);
            this.txtSearchBox.TabIndex = 0;
            this.txtSearchBox.Text = "Search The Cream";
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
            this.dvgPOS.Location = new System.Drawing.Point(27, 63);
            this.dvgPOS.Margin = new System.Windows.Forms.Padding(4);
            this.dvgPOS.Name = "dvgPOS";
            this.dvgPOS.RowHeadersWidth = 51;
            this.dvgPOS.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dvgPOS.Size = new System.Drawing.Size(1281, 361);
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 100);
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.noneToolStripMenuItem.Text = "None";
            this.noneToolStripMenuItem.Click += new System.EventHandler(this.noneToolStripMenuItem_Click);
            // 
            // seniorToolStripMenuItem
            // 
            this.seniorToolStripMenuItem.Name = "seniorToolStripMenuItem";
            this.seniorToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.seniorToolStripMenuItem.Text = "Senior";
            this.seniorToolStripMenuItem.Click += new System.EventHandler(this.seniorToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // pWDToolStripMenuItem
            // 
            this.pWDToolStripMenuItem.Name = "pWDToolStripMenuItem";
            this.pWDToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.pWDToolStripMenuItem.Text = "PWD";
            this.pWDToolStripMenuItem.Click += new System.EventHandler(this.pWDToolStripMenuItem_Click);
            // 
            // btnNewTable
            // 
            this.btnNewTable.BackColor = System.Drawing.Color.Transparent;
            this.btnNewTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewTable.FlatAppearance.BorderSize = 0;
            this.btnNewTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTable.Location = new System.Drawing.Point(1403, 138);
            this.btnNewTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewTable.Name = "btnNewTable";
            this.btnNewTable.Size = new System.Drawing.Size(285, 32);
            this.btnNewTable.TabIndex = 2;
            this.btnNewTable.Text = "New Table";
            this.btnNewTable.UseVisualStyleBackColor = false;
            // 
            // btnPlace
            // 
            this.btnPlace.BackColor = System.Drawing.Color.Transparent;
            this.btnPlace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlace.FlatAppearance.BorderSize = 0;
            this.btnPlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlace.Location = new System.Drawing.Point(1403, 193);
            this.btnPlace.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(285, 37);
            this.btnPlace.TabIndex = 3;
            this.btnPlace.Text = "IDK";
            this.btnPlace.UseVisualStyleBackColor = false;
            // 
            // txtOrderId
            // 
            this.txtOrderId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderId.Location = new System.Drawing.Point(108, 23);
            this.txtOrderId.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrderId.Multiline = true;
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(265, 32);
            this.txtOrderId.TabIndex = 4;
            this.txtOrderId.Text = "#123456789";
            // 
            // txtMOP
            // 
            this.txtMOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMOP.Location = new System.Drawing.Point(391, 23);
            this.txtMOP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMOP.Multiline = true;
            this.txtMOP.Name = "txtMOP";
            this.txtMOP.Size = new System.Drawing.Size(265, 32);
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
            this.pnlBackground.Location = new System.Drawing.Point(21, 181);
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1333, 529);
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
            this.panel2.Location = new System.Drawing.Point(900, 431);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 89);
            this.panel2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "DISCOUNTS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "TOTAL PRICE";
            // 
            // rtxtDiscount
            // 
            this.rtxtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtDiscount.Location = new System.Drawing.Point(216, 33);
            this.rtxtDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtDiscount.Name = "rtxtDiscount";
            this.rtxtDiscount.Size = new System.Drawing.Size(184, 50);
            this.rtxtDiscount.TabIndex = 1;
            this.rtxtDiscount.Text = "";
            // 
            // rtxtTotalPrice
            // 
            this.rtxtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtTotalPrice.Location = new System.Drawing.Point(4, 33);
            this.rtxtTotalPrice.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtTotalPrice.Name = "rtxtTotalPrice";
            this.rtxtTotalPrice.Size = new System.Drawing.Size(208, 50);
            this.rtxtTotalPrice.TabIndex = 0;
            this.rtxtTotalPrice.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(27, 431);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 89);
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
            this.btnMOP.Location = new System.Drawing.Point(625, 27);
            this.btnMOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMOP.Name = "btnMOP";
            this.btnMOP.Size = new System.Drawing.Size(27, 25);
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
            this.btnCopy.Location = new System.Drawing.Point(340, 27);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(28, 25);
            this.btnCopy.TabIndex = 12;
            this.btnCopy.UseVisualStyleBackColor = false;
            // 
            // picIDK
            // 
            this.picIDK.BackColor = System.Drawing.Color.Transparent;
            this.picIDK.BackgroundImage = global::TBIC.Properties.Resources.PROEL2D_UI__4_;
            this.picIDK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picIDK.Location = new System.Drawing.Point(27, 12);
            this.picIDK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picIDK.Name = "picIDK";
            this.picIDK.Size = new System.Drawing.Size(45, 43);
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
            this.btnPrevious.Location = new System.Drawing.Point(1225, 27);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(37, 30);
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
            this.btnNext.Location = new System.Drawing.Point(1269, 27);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(37, 30);
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
            this.btnConfirmPrint.Location = new System.Drawing.Point(1039, 716);
            this.btnConfirmPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmPrint.Name = "btnConfirmPrint";
            this.btnConfirmPrint.Size = new System.Drawing.Size(316, 59);
            this.btnConfirmPrint.TabIndex = 7;
            this.btnConfirmPrint.UseVisualStyleBackColor = false;
            this.btnConfirmPrint.Click += new System.EventHandler(this.btnConfirmPrint_Click);
            // 
            // picMaybedropbox
            // 
            this.picMaybedropbox.BackColor = System.Drawing.Color.Transparent;
            this.picMaybedropbox.BackgroundImage = global::TBIC.Properties.Resources.PROEL2D_UI;
            this.picMaybedropbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMaybedropbox.Location = new System.Drawing.Point(568, 132);
            this.picMaybedropbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMaybedropbox.Name = "picMaybedropbox";
            this.picMaybedropbox.Size = new System.Drawing.Size(37, 33);
            this.picMaybedropbox.TabIndex = 11;
            this.picMaybedropbox.TabStop = false;
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
            this.btnLogout.Location = new System.Drawing.Point(1520, 726);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(149, 42);
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
            this.contextMenuStrip2.Size = new System.Drawing.Size(135, 76);
            // 
            // cashToolStripMenuItem
            // 
            this.cashToolStripMenuItem.Name = "cashToolStripMenuItem";
            this.cashToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.cashToolStripMenuItem.Text = "Cash";
            this.cashToolStripMenuItem.Click += new System.EventHandler(this.cashToolStripMenuItem_Click);
            // 
            // cardToolStripMenuItem
            // 
            this.cardToolStripMenuItem.Name = "cardToolStripMenuItem";
            this.cardToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.cardToolStripMenuItem.Text = "Card";
            this.cardToolStripMenuItem.Click += new System.EventHandler(this.cardToolStripMenuItem_Click);
            // 
            // eWalletToolStripMenuItem
            // 
            this.eWalletToolStripMenuItem.Name = "eWalletToolStripMenuItem";
            this.eWalletToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.eWalletToolStripMenuItem.Text = "E-Wallet";
            this.eWalletToolStripMenuItem.Click += new System.EventHandler(this.eWalletToolStripMenuItem_Click);
            // 
            // btnGoToDashBoard
            // 
            this.btnGoToDashBoard.BackColor = System.Drawing.Color.Transparent;
            this.btnGoToDashBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoToDashBoard.FlatAppearance.BorderSize = 0;
            this.btnGoToDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToDashBoard.Location = new System.Drawing.Point(1403, 324);
            this.btnGoToDashBoard.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoToDashBoard.Name = "btnGoToDashBoard";
            this.btnGoToDashBoard.Size = new System.Drawing.Size(285, 32);
            this.btnGoToDashBoard.TabIndex = 13;
            this.btnGoToDashBoard.Text = "DASHBOARD";
            this.btnGoToDashBoard.UseVisualStyleBackColor = false;
            this.btnGoToDashBoard.Click += new System.EventHandler(this.btnGoToDashBoard_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblIDs);
            this.panel3.Controls.Add(this.lblUsernameNumba);
            this.panel3.Controls.Add(this.lblUserID);
            this.panel3.Controls.Add(this.lblUsername);
            this.panel3.Location = new System.Drawing.Point(1496, 19);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(157, 34);
            this.panel3.TabIndex = 25;
            // 
            // lblIDs
            // 
            this.lblIDs.AutoSize = true;
            this.lblIDs.Location = new System.Drawing.Point(13, 17);
            this.lblIDs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDs.Name = "lblIDs";
            this.lblIDs.Size = new System.Drawing.Size(23, 16);
            this.lblIDs.TabIndex = 14;
            this.lblIDs.Text = "ID:";
            // 
            // lblUsernameNumba
            // 
            this.lblUsernameNumba.AutoSize = true;
            this.lblUsernameNumba.Location = new System.Drawing.Point(12, 2);
            this.lblUsernameNumba.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsernameNumba.Name = "lblUsernameNumba";
            this.lblUsernameNumba.Size = new System.Drawing.Size(39, 16);
            this.lblUsernameNumba.TabIndex = 13;
            this.lblUsernameNumba.Text = "User:";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(40, 17);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(21, 16);
            this.lblUserID.TabIndex = 12;
            this.lblUserID.Text = "69";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(55, 2);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(26, 16);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "Me";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TBIC.Properties.Resources.POS_Payment_Reyal1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1685, 789);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnGoToDashBoard);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.picMaybedropbox);
            this.Controls.Add(this.btnConfirmPrint);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.btnPlace);
            this.Controls.Add(this.btnNewTable);
            this.Controls.Add(this.txtSearchBox);
            this.Margin = new System.Windows.Forms.Padding(4);
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
            ((System.ComponentModel.ISupportInitialize)(this.picMaybedropbox)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Button btnNewTable;
        private System.Windows.Forms.Button btnPlace;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.TextBox txtMOP;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Button btnConfirmPrint;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox picIDK;
        private System.Windows.Forms.PictureBox picMaybedropbox;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMOP;
        private System.Windows.Forms.Button btnCopy;
        public System.Windows.Forms.DataGridView dvgPOS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtDiscount;
        private System.Windows.Forms.RichTextBox rtxtTotalPrice;
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
        private System.Windows.Forms.Button btnGoToDashBoard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblIDs;
        private System.Windows.Forms.Label lblUsernameNumba;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblUsername;
    }
}