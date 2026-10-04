using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.Data.SqlClient.Internal.SqlClientEventSource;

namespace TBIC
{
    public partial class Acc_Management : Form
    {
        string StaffName;
        int StaffID;

        public Acc_Management()
        {
            InitializeComponent();
        }

        public void StaffInfo(string staffName, int staffID)
        {
            StaffName = staffName;
            StaffID = staffID;

            lblUsername.Text = StaffName;
            lblUserID.Text = StaffID.ToString();
        }

        private void btnDashBoardManage_Click(object sender, EventArgs e)
        {
            Form_Instances._dash.StaffInfo(StaffName, StaffID);
            Form_Instances._dash.inputReload();
            Form_Instances._dash.Show();
            this.Hide();

            btnConfigure.Hide();
        }

        private void btnManageManage_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Already In Account Management");
        }

        private void Acc_Management_Load(object sender, EventArgs e)
        {
            TBICDataContext db = new TBICDataContext();
            dgvEmployeeEditor.DataSource = db.RETRIEVE_STAFF();
            btnDashBoardManage.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
            btnManageManage.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
            txtAddName.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
            txtAddUsername.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
            txtAddPassword.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
            txtSearchEmploys.Font = new Font("FredokaSummer", 9, FontStyle.Bold);

            inputreload();

            btnConfigure.Hide();
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            try
            {
                Form_Instances._bin.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was an unexpected problem while opening the bin panel!\nReason: {ex.Message}", "Error Type: Bin Panel Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void inputreload()
        {
            txtAddName.Text = null;
            txtAddUsername.Text = null;
            txtAddPassword.Text = null;
            txtDepartmentID.Text = null;
            txtSearchEmploys.Text = null;
            cmbRole.SelectedIndex = -1;

            txtAddName.SetPlaceholder("Staffname");
            txtAddUsername.SetPlaceholder("Username");
            txtAddPassword.SetPlaceholder("Password");
            txtDepartmentID.SetPlaceholder("Department ID");
            txtSearchEmploys.SetPlaceholder("Search Entry");

            dgvEmployeeEditor.CellFormatting += dgvEmployeeEditor_CellFormatting;
        }

        #region Account Creation

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                TBICDataContext db = new TBICDataContext();

                int Dep_ID = int.Parse(txtDepartmentID.Text);

                string hash = BCrypt.Net.BCrypt.HashPassword(txtAddPassword.Text.Trim());

                db.ADD_STAFF(txtAddName.Text.Trim(), txtAddUsername.Text.Trim(), hash, Dep_ID, cmbRole.Text);

                dgvEmployeeEditor.DataSource = db.RETRIEVE_STAFF();

                inputreload();

                MessageBox.Show("Entry Successfully Added!", "Affirmation");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was an unexpected problem while adding your entry!\nReason: {ex.Message}", "Error Type: Account Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRole.SelectedIndex == 0)
            {
                txtDepartmentID.Text = "1";
            }
            else if (cmbRole.SelectedIndex == 1)
            {
                txtDepartmentID.Text = "2";
            }
        }

        private void txtSearchEmploys_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchEmploys.Text == "Search Entry") return;

            TBICDataContext db = new TBICDataContext();

            string keyword = txtSearchEmploys.Text.Trim();

            var Search = db.RETRIEVE_STAFF();

            dgvEmployeeEditor.DataSource = Search;
        }

        private void dgvEmployeeEditor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvEmployeeEditor.Columns[e.ColumnIndex].Name == "pASSWORDDataGridViewTextBoxColumn" && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length); // masks with same-length asterisks
                e.FormattingApplied = true;
            }
        }

        private void dgvEmployeeEditor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnConfigure.Show();
        }

        private void dgvEmployeeEditor_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btnConfigure.Hide();
        }

        #endregion

        #region Account Modification

        private void btnConfigure_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmployeeEditor.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a staff entry to modify.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dgvEmployeeEditor.SelectedRows[0];
                int staffId = Convert.ToInt32(selectedRow.Cells["STAFF_ID"].Value);

                if (staffId.ToString() == lblUserID.Text)
                {
                    MessageBox.Show("Cannot modify an Entry that is currently in use", "Error Type: Active Account Modification Attempt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Form_Instances._mod.lblStaffID.Text = staffId.ToString();
                Form_Instances._mod.lblName.Text = selectedRow.Cells["STAFF_NAME"].Value.ToString();
                Form_Instances._mod.lblRole.Text = selectedRow.Cells["ROLE"].Value.ToString();
                Form_Instances._mod.DataLoad();

                Form_Instances._mod.Size = new Size(706, 121);
                Form_Instances._mod.btnConfirm.Enabled = false;
                Form_Instances._mod.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was an unexpected problem while opening the entry!\nReason: {ex.Message}", "Error Type: Account Modification Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Sorting Functionality

        private void picMaybedropboxManagement_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(picMaybedropboxManagement, new Point(picMaybedropboxManagement.Width, 0));
        }

        private void ascendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortBothViews(ascending: true);
        }

        private void descendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortBothViews(ascending: false);
        }

        private void SortBothViews(bool ascending)
        {
            using (TBICDataContext db = new TBICDataContext())
            {
                var sorted = ascending
                    ? db.RETRIEVE_STAFF().OrderBy(x => x.STAFF_NAME).ToList()
                    : db.RETRIEVE_STAFF().OrderByDescending(x => x.STAFF_NAME).ToList();

                dgvEmployeeEditor.DataSource = sorted;
            }
        }

        #endregion

    }
}
