namespace TBIC
{
    partial class Bin_Panel
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
            this.dgvSoftDeleteRecords = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoftDeleteRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSoftDeleteRecords
            // 
            this.dgvSoftDeleteRecords.AllowUserToAddRows = false;
            this.dgvSoftDeleteRecords.AllowUserToDeleteRows = false;
            this.dgvSoftDeleteRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvSoftDeleteRecords.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSoftDeleteRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoftDeleteRecords.Location = new System.Drawing.Point(13, 12);
            this.dgvSoftDeleteRecords.Name = "dgvSoftDeleteRecords";
            this.dgvSoftDeleteRecords.ReadOnly = true;
            this.dgvSoftDeleteRecords.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvSoftDeleteRecords.Size = new System.Drawing.Size(775, 387);
            this.dgvSoftDeleteRecords.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(713, 405);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "All records in here will be permanently deleted after 3 days.\r\n";
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(632, 405);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 3;
            this.btnRestore.Text = "RESTORE";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // Bin_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 434);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvSoftDeleteRecords);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bin_Panel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bin_Panel";
            this.Load += new System.EventHandler(this.Bin_Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoftDeleteRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSoftDeleteRecords;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRestore;
    }
}