namespace TBIC
{
    partial class Admin_Dashboard
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
            this.picMaybedropboxAdmin = new System.Windows.Forms.PictureBox();
            this.txtSearchBoxAdmin = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTotalEmployee = new System.Windows.Forms.Label();
            this.lblNumberOfEmployees = new System.Windows.Forms.Label();
            this.btnAdminDashboard = new System.Windows.Forms.Button();
            this.btnAccManage = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIDs = new System.Windows.Forms.Label();
            this.lblUsernameNumba = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMaybedropboxAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMaybedropboxAdmin
            // 
            this.picMaybedropboxAdmin.BackColor = System.Drawing.Color.Transparent;
            this.picMaybedropboxAdmin.BackgroundImage = global::TBIC.Properties.Resources.PROEL2D_UI;
            this.picMaybedropboxAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMaybedropboxAdmin.Location = new System.Drawing.Point(415, 210);
            this.picMaybedropboxAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMaybedropboxAdmin.Name = "picMaybedropboxAdmin";
            this.picMaybedropboxAdmin.Size = new System.Drawing.Size(47, 38);
            this.picMaybedropboxAdmin.TabIndex = 12;
            this.picMaybedropboxAdmin.TabStop = false;
            // 
            // txtSearchBoxAdmin
            // 
            this.txtSearchBoxAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchBoxAdmin.Location = new System.Drawing.Point(43, 210);
            this.txtSearchBoxAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchBoxAdmin.Multiline = true;
            this.txtSearchBoxAdmin.Name = "txtSearchBoxAdmin";
            this.txtSearchBoxAdmin.Size = new System.Drawing.Size(365, 38);
            this.txtSearchBoxAdmin.TabIndex = 13;
            this.txtSearchBoxAdmin.Text = "Finding Magno";
            this.txtSearchBoxAdmin.TextChanged += new System.EventHandler(this.txtSearchBoxAdmin_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 256);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(1287, 395);
            this.dataGridView1.TabIndex = 14;
            // 
            // lblTotalEmployee
            // 
            this.lblTotalEmployee.AutoSize = true;
            this.lblTotalEmployee.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalEmployee.Location = new System.Drawing.Point(39, 686);
            this.lblTotalEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalEmployee.Name = "lblTotalEmployee";
            this.lblTotalEmployee.Size = new System.Drawing.Size(142, 16);
            this.lblTotalEmployee.TabIndex = 15;
            this.lblTotalEmployee.Text = "TOTAL EMPLOYEES: ";
            // 
            // lblNumberOfEmployees
            // 
            this.lblNumberOfEmployees.AutoSize = true;
            this.lblNumberOfEmployees.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfEmployees.Location = new System.Drawing.Point(219, 686);
            this.lblNumberOfEmployees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfEmployees.Name = "lblNumberOfEmployees";
            this.lblNumberOfEmployees.Size = new System.Drawing.Size(21, 16);
            this.lblNumberOfEmployees.TabIndex = 16;
            this.lblNumberOfEmployees.Text = "67";
            // 
            // btnAdminDashboard
            // 
            this.btnAdminDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnAdminDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdminDashboard.FlatAppearance.BorderSize = 0;
            this.btnAdminDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminDashboard.Location = new System.Drawing.Point(1405, 133);
            this.btnAdminDashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdminDashboard.Name = "btnAdminDashboard";
            this.btnAdminDashboard.Size = new System.Drawing.Size(285, 34);
            this.btnAdminDashboard.TabIndex = 17;
            this.btnAdminDashboard.Text = "DASHBOARD";
            this.btnAdminDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminDashboard.UseVisualStyleBackColor = false;
            this.btnAdminDashboard.Click += new System.EventHandler(this.btnAdminDashboard_Click);
            // 
            // btnAccManage
            // 
            this.btnAccManage.BackColor = System.Drawing.Color.Transparent;
            this.btnAccManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAccManage.FlatAppearance.BorderSize = 0;
            this.btnAccManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccManage.Location = new System.Drawing.Point(1405, 197);
            this.btnAccManage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAccManage.Name = "btnAccManage";
            this.btnAccManage.Size = new System.Drawing.Size(285, 34);
            this.btnAccManage.TabIndex = 18;
            this.btnAccManage.Text = "ACC MANAGEMENT";
            this.btnAccManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccManage.UseVisualStyleBackColor = false;
            this.btnAccManage.Click += new System.EventHandler(this.btnAccManage_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGoBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(89)))));
            this.btnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.Location = new System.Drawing.Point(1523, 734);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(149, 42);
            this.btnGoBack.TabIndex = 19;
            this.btnGoBack.Text = "Payment";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblIDs);
            this.panel1.Controls.Add(this.lblUsernameNumba);
            this.panel1.Controls.Add(this.lblUserID);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Location = new System.Drawing.Point(1493, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 34);
            this.panel1.TabIndex = 20;
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
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TBIC.Properties.Resources.ADMIN_Dashboard__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1685, 789);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnAccManage);
            this.Controls.Add(this.btnAdminDashboard);
            this.Controls.Add(this.lblNumberOfEmployees);
            this.Controls.Add(this.lblTotalEmployee);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSearchBoxAdmin);
            this.Controls.Add(this.picMaybedropboxAdmin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Admin_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Dashboard";
            this.Load += new System.EventHandler(this.Admin_Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMaybedropboxAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMaybedropboxAdmin;
        private System.Windows.Forms.TextBox txtSearchBoxAdmin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTotalEmployee;
        private System.Windows.Forms.Label lblNumberOfEmployees;
        private System.Windows.Forms.Button btnAdminDashboard;
        private System.Windows.Forms.Button btnAccManage;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIDs;
        private System.Windows.Forms.Label lblUsernameNumba;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblUsername;
    }
}