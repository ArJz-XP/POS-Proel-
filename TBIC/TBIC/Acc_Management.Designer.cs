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
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.txtAddPassword = new System.Windows.Forms.TextBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMaybedropboxManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddName
            // 
            this.txtAddName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddName.Location = new System.Drawing.Point(43, 321);
            this.txtAddName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddName.Multiline = true;
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(261, 38);
            this.txtAddName.TabIndex = 14;
            this.txtAddName.Text = "NAME";
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddPassword.Location = new System.Drawing.Point(43, 386);
            this.txtAddPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddPassword.Multiline = true;
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.Size = new System.Drawing.Size(261, 38);
            this.txtAddPassword.TabIndex = 15;
            this.txtAddPassword.Text = "PASSWORD";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "DEPARMENT"});
            this.cmbDepartment.Location = new System.Drawing.Point(43, 511);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(261, 24);
            this.cmbDepartment.TabIndex = 16;
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "ROLES"});
            this.cmbRole.Location = new System.Drawing.Point(43, 569);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(261, 24);
            this.cmbRole.TabIndex = 17;
            // 
            // txtSearchEmploys
            // 
            this.txtSearchEmploys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchEmploys.Location = new System.Drawing.Point(371, 274);
            this.txtSearchEmploys.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchEmploys.Multiline = true;
            this.txtSearchEmploys.Name = "txtSearchEmploys";
            this.txtSearchEmploys.Size = new System.Drawing.Size(261, 38);
            this.txtSearchEmploys.TabIndex = 18;
            this.txtSearchEmploys.Text = "Search Items";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.BackgroundImage = global::TBIC.Properties.Resources.PROEL2D_UI5;
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Location = new System.Drawing.Point(85, 629);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(187, 37);
            this.btnCreate.TabIndex = 20;
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // btnConfigure
            // 
            this.btnConfigure.BackColor = System.Drawing.Color.Transparent;
            this.btnConfigure.BackgroundImage = global::TBIC.Properties.Resources.Configure;
            this.btnConfigure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfigure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfigure.Location = new System.Drawing.Point(1147, 629);
            this.btnConfigure.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfigure.Name = "btnConfigure";
            this.btnConfigure.Size = new System.Drawing.Size(187, 37);
            this.btnConfigure.TabIndex = 21;
            this.btnConfigure.UseVisualStyleBackColor = false;
            // 
            // btnManageManage
            // 
            this.btnManageManage.BackColor = System.Drawing.Color.Transparent;
            this.btnManageManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnManageManage.FlatAppearance.BorderSize = 0;
            this.btnManageManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageManage.Location = new System.Drawing.Point(1408, 198);
            this.btnManageManage.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageManage.Name = "btnManageManage";
            this.btnManageManage.Size = new System.Drawing.Size(285, 37);
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
            this.btnDashBoardManage.Location = new System.Drawing.Point(1408, 135);
            this.btnDashBoardManage.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashBoardManage.Name = "btnDashBoardManage";
            this.btnDashBoardManage.Size = new System.Drawing.Size(285, 34);
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
            this.panel1.Location = new System.Drawing.Point(1499, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 34);
            this.panel1.TabIndex = 24;
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
            // picMaybedropboxManagement
            // 
            this.picMaybedropboxManagement.BackColor = System.Drawing.Color.Transparent;
            this.picMaybedropboxManagement.BackgroundImage = global::TBIC.Properties.Resources.PROEL2D_UI;
            this.picMaybedropboxManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMaybedropboxManagement.Location = new System.Drawing.Point(639, 274);
            this.picMaybedropboxManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMaybedropboxManagement.Name = "picMaybedropboxManagement";
            this.picMaybedropboxManagement.Size = new System.Drawing.Size(47, 38);
            this.picMaybedropboxManagement.TabIndex = 19;
            this.picMaybedropboxManagement.TabStop = false;
            // 
            // Acc_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TBIC.Properties.Resources.ADMIN_User_Management;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1688, 798);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDashBoardManage);
            this.Controls.Add(this.btnManageManage);
            this.Controls.Add(this.btnConfigure);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.picMaybedropboxManagement);
            this.Controls.Add(this.txtSearchEmploys);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.txtAddPassword);
            this.Controls.Add(this.txtAddName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Acc_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acc_Management";
            this.Load += new System.EventHandler(this.Acc_Management_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMaybedropboxManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.TextBox txtAddPassword;
        private System.Windows.Forms.ComboBox cmbDepartment;
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
    }
}