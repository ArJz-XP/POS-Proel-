using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBIC
{
    public partial class Account_Modification_Panel : Form
    {
        public int departmentID = 0;

        public Account_Modification_Panel()
        {
            InitializeComponent();

            txtFullName.TextChanged += ButtonEnable;
            txtUsername.TextChanged += ButtonEnable;
            txtPassword.TextChanged += ButtonEnable;
            txtRole.TextChanged += ButtonEnable;
        }

        private void TxtFullName_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Size = new Size(706, 344);
            this.CenterToScreen();
            DataLoad();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Size = new Size(706, 121);
            this.CenterToScreen();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepartment.SelectedIndex == 0)
            {
                txtRole.Text = "Cashier";
            }
            else if (cmbDepartment.SelectedIndex == 1)
            {
                txtRole.Text = "Manager";
            }
        }

        #region Confirmation
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this staff information?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                TBICDataContext db = new TBICDataContext();
                int id = int.Parse(lblStaffID.Text);

                int departmentID = 0;
                if (cmbDepartment.Text == "CASHIER")
                {
                    departmentID = 1;
                }
                else if (cmbDepartment.Text == "MANAGEMENT")
                {
                    departmentID = 2;
                }

                if (departmentID == 0)
                {
                    MessageBox.Show("That department doesn't exist.", "Invalid Department", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var staff = db.STAFFs.First(x => x.STAFF_ID == id);

                // Blank box = keep the current hash, typed value = hash the new password
                string passToSave = string.IsNullOrWhiteSpace(txtPassword.Text)
                    ? staff.PASSWORD
                    : BCrypt.Net.BCrypt.HashPassword(txtPassword.Text.Trim());

                db.EDIT_STAFF(
                    id,
                    txtFullName.Text.Trim(),
                    txtUsername.Text.Trim(),
                    passToSave,
                    departmentID,
                    txtRole.Text.Trim()
                );

                MessageBox.Show("Staff information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Form_Instances._acc.inputreload();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not update the account.\nReason: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Data Loading

        public void DataLoad()
        {
            TBICDataContext db = new TBICDataContext();
            int ID = lblStaffID.Text == "" ? 0 : int.Parse(lblStaffID.Text);
            var s = db.STAFFs.FirstOrDefault(x => x.STAFF_ID == ID);
            if (s == null) return;
            txtFullName.Text = s.STAFF_NAME;
            txtUsername.Text = s.USERNAME;
            txtPassword.Text = "";
            cmbDepartment.Text = s.DEPARTMENT_ID == 1 ? "CASHIER" :
                                 s.DEPARTMENT_ID == 2 ? "MANAGEMENT" : "";
            txtRole.Text = s.ROLE;
        }

        #endregion

        #region Button Enable

        public void ButtonEnable(object sender, EventArgs e)
        {
            TBICDataContext db = new TBICDataContext();

            int ID = lblStaffID.Text == "" ? 0 : int.Parse(lblStaffID.Text);
            var s = db.STAFFs.FirstOrDefault(x => x.STAFF_ID == ID);
            if (s == null) return;

            btnConfirm.Enabled =
                s.STAFF_NAME != txtFullName.Text.Trim() ||
                s.USERNAME != txtUsername.Text.Trim() ||
                s.PASSWORD != txtPassword.Text.Trim() ||
                s.DEPARTMENT_ID != departmentID ||
                s.ROLE != txtRole.Text.Trim();
        }

        #endregion

        #region Delete Staff

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this staff information?\nYou will retain the ability to reverse the deletion by going to the bin panel.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    TBICDataContext db = new TBICDataContext();
                    db.SOFT_DELETE_STAFF(int.Parse(lblStaffID.Text));

                    MessageBox.Show("Staff information moved to the bin.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    Form_Instances._acc.inputreload();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Could not delete the account.\nReason: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion
    }
}
