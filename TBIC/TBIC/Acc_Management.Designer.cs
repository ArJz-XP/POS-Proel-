namespace TBIC
{
    partial class Acc_Management
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
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.txtAddPassword = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtSearchEmploys = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnConfigure = new System.Windows.Forms.Button();
            this.btnManageManage = new System.Windows.Forms.Button();
            this.btnDashBoardManage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIDs = new System.Windows.Forms.Label();
            this.lblUsernameNumba = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.picMaybedropboxManagement = new System.Windows.Forms.PictureBox();
            this.dgvEmployeeEditor = new System.Windows.Forms.DataGridView();
            this.sTAFFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTAFFNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTMENTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwRetrieveBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tBCI_ServerDataSet = new TBIC.TBCI_ServerDataSet();
            this.txtDepartmentID = new System.Windows.Forms.TextBox();
            this.vwRetrieveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_RetrieveTableAdapter = new TBIC.TBCI_ServerDataSetTableAdapters.vw_RetrieveTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMaybedropboxManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRetrieveBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCI_ServerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRetrieveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddName
            // 
            this.txtAddName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddName.Location = new System.Drawing.Point(32, 261);
            this.txtAddName.Multiline = true;
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(196, 31);
            this.txtAddName.TabIndex = 14;
            this.txtAddName.Text = "NAME";
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddPassword.Location = new System.Drawing.Point(32, 314);
            this.txtAddPassword.Multiline = true;
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.Size = new System.Drawing.Size(196, 31);
            this.txtAddPassword.TabIndex = 15;
            this.txtAddPassword.Text = "PASSWORD";
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Cashier",
            "Manager"});
            this.cmbRole.Location = new System.Drawing.Point(31, 407);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(197, 21);
            this.cmbRole.TabIndex = 17;
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbRole_SelectedIndexChanged);
            // 
            // txtSearchEmploys
            // 
            this.txtSearchEmploys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchEmploys.Location = new System.Drawing.Point(278, 223);
            this.txtSearchEmploys.Multiline = true;
            this.txtSearchEmploys.Name = "txtSearchEmploys";
            this.txtSearchEmploys.Size = new System.Drawing.Size(196, 31);
            this.txtSearchEmploys.TabIndex = 18;
            this.txtSearchEmploys.Text = "Search Items";
            this.txtSearchEmploys.TextChanged += new System.EventHandler(this.txtSearchEmploys_TextChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.BackgroundImage = global::TBIC.Properties.Resources.PROEL2D_UI5;
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Location = new System.Drawing.Point(64, 511);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(140, 30);
            this.btnCreate.TabIndex = 20;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnConfigure
            // 
            this.btnConfigure.BackColor = System.Drawing.Color.Transparent;
            this.btnConfigure.BackgroundImage = global::TBIC.Properties.Resources.Configure;
            this.btnConfigure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfigure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfigure.Location = new System.Drawing.Point(64, 563);
            this.btnConfigure.Name = "btnConfigure";
            this.btnConfigure.Size = new System.Drawing.Size(140, 30);
            this.btnConfigure.TabIndex = 21;
            this.btnConfigure.UseVisualStyleBackColor = false;
            this.btnConfigure.Click += new System.EventHandler(this.btnConfigure_Click);
            // 
            // btnManageManage
            // 
            this.btnManageManage.BackColor = System.Drawing.Color.Transparent;
            this.btnManageManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnManageManage.FlatAppearance.BorderSize = 0;
            this.btnManageManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageManage.Location = new System.Drawing.Point(1056, 161);
            this.btnManageManage.Name = "btnManageManage";
            this.btnManageManage.Size = new System.Drawing.Size(214, 30);
            this.btnManageManage.TabIndex = 22;
            this.btnManageManage.Text = "ACC MANAGEMENT";
            this.btnManageManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageManage.UseVisualStyleBackColor = false;
            this.btnManageManage.Click += new System.EventHandler(this.btnManageManage_Click);
            // 
            // btnDashBoardManage
            // 
            this.btnDashBoardManage.BackColor = System.Drawing.Color.Transparent;
            this.btnDashBoardManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDashBoardManage.FlatAppearance.BorderSize = 0;
            this.btnDashBoardManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoardManage.Location = new System.Drawing.Point(1056, 110);
            this.btnDashBoardManage.Name = "btnDashBoardManage";
            this.btnDashBoardManage.Size = new System.Drawing.Size(214, 28);
            this.btnDashBoardManage.TabIndex = 23;
            this.btnDashBoardManage.Text = "DASHBOARD";
            this.btnDashBoardManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoardManage.UseVisualStyleBackColor = false;
            this.btnDashBoardManage.Click += new System.EventHandler(this.btnDashBoardManage_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblIDs);
            this.panel1.Controls.Add(this.lblUsernameNumba);
            this.panel1.Controls.Add(this.lblUserID);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Location = new System.Drawing.Point(1124, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 28);
            this.panel1.TabIndex = 24;
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
            // picMaybedropboxManagement
            // 
            this.picMaybedropboxManagement.BackColor = System.Drawing.Color.Transparent;
            this.picMaybedropboxManagement.BackgroundImage = global::TBIC.Properties.Resources.PROEL2D_UI;
            this.picMaybedropboxManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMaybedropboxManagement.Location = new System.Drawing.Point(479, 223);
            this.picMaybedropboxManagement.Margin = new System.Windows.Forms.Padding(2);
            this.picMaybedropboxManagement.Name = "picMaybedropboxManagement";
            this.picMaybedropboxManagement.Size = new System.Drawing.Size(35, 31);
            this.picMaybedropboxManagement.TabIndex = 19;
            this.picMaybedropboxManagement.TabStop = false;
            // 
            // dgvEmployeeEditor
            // 
            this.dgvEmployeeEditor.AllowUserToAddRows = false;
            this.dgvEmployeeEditor.AllowUserToDeleteRows = false;
            this.dgvEmployeeEditor.AllowUserToResizeColumns = false;
            this.dgvEmployeeEditor.AllowUserToResizeRows = false;
            this.dgvEmployeeEditor.AutoGenerateColumns = false;
            this.dgvEmployeeEditor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvEmployeeEditor.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployeeEditor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeEditor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTAFFIDDataGridViewTextBoxColumn,
            this.sTAFFNAMEDataGridViewTextBoxColumn,
            this.uSERNAMEDataGridViewTextBoxColumn,
            this.pASSWORDDataGridViewTextBoxColumn,
            this.rOLEDataGridViewTextBoxColumn,
            this.dEPARTMENTNAMEDataGridViewTextBoxColumn});
            this.dgvEmployeeEditor.DataSource = this.vwRetrieveBindingSource1;
            this.dgvEmployeeEditor.Location = new System.Drawing.Point(278, 261);
            this.dgvEmployeeEditor.Name = "dgvEmployeeEditor";
            this.dgvEmployeeEditor.ReadOnly = true;
            this.dgvEmployeeEditor.Size = new System.Drawing.Size(722, 242);
            this.dgvEmployeeEditor.TabIndex = 25;
            this.dgvEmployeeEditor.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEmployeeEditor_CellFormatting);
            // 
            // sTAFFIDDataGridViewTextBoxColumn
            // 
            this.sTAFFIDDataGridViewTextBoxColumn.DataPropertyName = "STAFF_ID";
            this.sTAFFIDDataGridViewTextBoxColumn.HeaderText = "STAFF_ID";
            this.sTAFFIDDataGridViewTextBoxColumn.Name = "sTAFFIDDataGridViewTextBoxColumn";
            this.sTAFFIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTAFFIDDataGridViewTextBoxColumn.Width = 82;
            // 
            // sTAFFNAMEDataGridViewTextBoxColumn
            // 
            this.sTAFFNAMEDataGridViewTextBoxColumn.DataPropertyName = "STAFF_NAME";
            this.sTAFFNAMEDataGridViewTextBoxColumn.HeaderText = "STAFF_NAME";
            this.sTAFFNAMEDataGridViewTextBoxColumn.Name = "sTAFFNAMEDataGridViewTextBoxColumn";
            this.sTAFFNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTAFFNAMEDataGridViewTextBoxColumn.Width = 102;
            // 
            // uSERNAMEDataGridViewTextBoxColumn
            // 
            this.uSERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn.HeaderText = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn.Name = "uSERNAMEDataGridViewTextBoxColumn";
            this.uSERNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.uSERNAMEDataGridViewTextBoxColumn.Width = 93;
            // 
            // pASSWORDDataGridViewTextBoxColumn
            // 
            this.pASSWORDDataGridViewTextBoxColumn.DataPropertyName = "PASSWORD";
            this.pASSWORDDataGridViewTextBoxColumn.HeaderText = "PASSWORD";
            this.pASSWORDDataGridViewTextBoxColumn.Name = "pASSWORDDataGridViewTextBoxColumn";
            this.pASSWORDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pASSWORDDataGridViewTextBoxColumn.Width = 95;
            // 
            // rOLEDataGridViewTextBoxColumn
            // 
            this.rOLEDataGridViewTextBoxColumn.DataPropertyName = "ROLE";
            this.rOLEDataGridViewTextBoxColumn.HeaderText = "ROLE";
            this.rOLEDataGridViewTextBoxColumn.Name = "rOLEDataGridViewTextBoxColumn";
            this.rOLEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rOLEDataGridViewTextBoxColumn.Width = 61;
            // 
            // dEPARTMENTNAMEDataGridViewTextBoxColumn
            // 
            this.dEPARTMENTNAMEDataGridViewTextBoxColumn.DataPropertyName = "DEPARTMENT_NAME";
            this.dEPARTMENTNAMEDataGridViewTextBoxColumn.HeaderText = "DEPARTMENT_NAME";
            this.dEPARTMENTNAMEDataGridViewTextBoxColumn.Name = "dEPARTMENTNAMEDataGridViewTextBoxColumn";
            this.dEPARTMENTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.dEPARTMENTNAMEDataGridViewTextBoxColumn.Width = 144;
            // 
            // vwRetrieveBindingSource1
            // 
            this.vwRetrieveBindingSource1.DataMember = "vw_Retrieve";
            this.vwRetrieveBindingSource1.DataSource = this.tBCI_ServerDataSet;
            // 
            // tBCI_ServerDataSet
            // 
            this.tBCI_ServerDataSet.DataSetName = "TBCI_ServerDataSet";
            this.tBCI_ServerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDepartmentID
            // 
            this.txtDepartmentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartmentID.Location = new System.Drawing.Point(32, 433);
            this.txtDepartmentID.Multiline = true;
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.ReadOnly = true;
            this.txtDepartmentID.Size = new System.Drawing.Size(196, 31);
            this.txtDepartmentID.TabIndex = 26;
            this.txtDepartmentID.Text = "DepID";
            // 
            // vwRetrieveBindingSource
            // 
            this.vwRetrieveBindingSource.DataMember = "vw_Retrieve";
            this.vwRetrieveBindingSource.DataSource = this.tBCI_ServerDataSet;
            // 
            // vw_RetrieveTableAdapter
            // 
            this.vw_RetrieveTableAdapter.ClearBeforeFill = true;
            // 
            // Acc_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TBIC.Properties.Resources.ADMIN_User_Management;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1266, 648);
            this.Controls.Add(this.txtDepartmentID);
            this.Controls.Add(this.dgvEmployeeEditor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDashBoardManage);
            this.Controls.Add(this.btnManageManage);
            this.Controls.Add(this.btnConfigure);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.picMaybedropboxManagement);
            this.Controls.Add(this.txtSearchEmploys);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.txtAddPassword);
            this.Controls.Add(this.txtAddName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Acc_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acc_Management";
            this.Load += new System.EventHandler(this.Acc_Management_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMaybedropboxManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRetrieveBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCI_ServerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRetrieveBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.TextBox txtAddPassword;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TextBox txtSearchEmploys;
        private System.Windows.Forms.PictureBox picMaybedropboxManagement;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnConfigure;
        private System.Windows.Forms.Button btnManageManage;
        private System.Windows.Forms.Button btnDashBoardManage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIDs;
        private System.Windows.Forms.Label lblUsernameNumba;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.DataGridView dgvEmployeeEditor;
        private System.Windows.Forms.TextBox txtDepartmentID;
        private TBCI_ServerDataSet tBCI_ServerDataSet;
        private System.Windows.Forms.BindingSource vwRetrieveBindingSource;
        private TBCI_ServerDataSetTableAdapters.vw_RetrieveTableAdapter vw_RetrieveTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTAFFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTAFFNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSWORDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPARTMENTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vwRetrieveBindingSource1;
    }
}