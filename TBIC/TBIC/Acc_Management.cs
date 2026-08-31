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
        }

        private void btnManageManage_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Already In Account Management");
        }

        private void Acc_Management_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tBCI_ServerDataSet.vw_Retrieve' table. You can move, or remove it, as needed.
            this.vw_RetrieveTableAdapter.Fill(this.tBCI_ServerDataSet.vw_Retrieve);
            btnDashBoardManage.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
            btnManageManage.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
            txtAddName.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
            txtAddPassword.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
            txtSearchEmploys.Font = new Font("FredokaSummer", 9, FontStyle.Bold);

            inputreload();
        }

        public void inputreload()
        {
            txtAddName.Text = null;
            txtAddPassword.Text = null;
            txtDepartmentID.Text = null;
            txtSearchEmploys.Text = null;
            cmbRole.SelectedIndex = -1;

            txtAddName.SetPlaceholder("StaffName");
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

                db.ADD_STAFF(txtAddName.Text, txtAddName.Text, txtAddPassword.Text, Dep_ID, cmbRole.Text);

                dgvEmployeeEditor.CellFormatting += dgvEmployeeEditor_CellFormatting;

                dgvEmployeeEditor.DataSource = db.vw_Retrieves;

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

            var Search = db.vw_Retrieves.Where(x => x.USERNAME.Contains(keyword) || x.STAFF_NAME.Contains(keyword)).ToList();

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

        #endregion

        #region Account Deletion

        private void btnConfigure_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmployeeEditor.SelectedRows.Count == 0) return;

                var selectedRow = dgvEmployeeEditor.SelectedRows[0];
                int staffId = Convert.ToInt32(selectedRow.Cells["sTAFFIDDataGridViewTextBoxColumn"].Value);
                var staffName = selectedRow.Cells["sTAFFNAMEDataGridViewTextBoxColumn"].Value;
                var role = selectedRow.Cells["rOLEDataGridViewTextBoxColumn"].Value;

                if (staffId.ToString() == lblUserID.Text)
                {
                    MessageBox.Show("Cannot Delete an Entry that is currently in use", "Error Type: Active Account Deletion Attempt", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                if (MessageBox.Show($"Delete staff\nID: {staffId}\nName: {staffName}\nRole: {role}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    TBICDataContext db = new TBICDataContext();

                    db.DELETE_STAFF(staffId);

                    dgvEmployeeEditor.DataSource = db.vw_Retrieves;

                    MessageBox.Show("Staff Entry Successfully Deleted!", "Deletion Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was an unexpected problem while removing your entry!\nReason: {ex.Message}", "Error Type: Account Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
