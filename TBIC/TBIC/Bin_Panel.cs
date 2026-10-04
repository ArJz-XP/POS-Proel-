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
    public partial class Bin_Panel : Form
    {
        public Bin_Panel()
        {
            InitializeComponent();
        }

        private void Bin_Panel_Load(object sender, EventArgs e)
        {
            TBICDataContext db = new TBICDataContext();

            DateTime cutoff = DateTime.Now.AddDays(-3);
            var expired = db.STAFFs.Where(s => !s.IS_ACTIVE && s.DELETED_AT < cutoff).ToList();

            foreach (var s in expired)
            {
                try
                {
                    db.HARD_DELETE_STAFF(s.STAFF_ID);
                }
                catch
                {
                    // still linked to sales history, so it stays in the bin
                }
            }

            dgvSoftDeleteRecords.DataSource = db.RETRIEVE_SOFT_DELETED_STAFF();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSoftDeleteRecords.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a staff record to delete.");
                return;
            }

            if (MessageBox.Show("Permanently delete this staff record? This cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                TBICDataContext db = new TBICDataContext();
                int staffId = Convert.ToInt32(dgvSoftDeleteRecords.SelectedRows[0].Cells["STAFF_ID"].Value);
                db.HARD_DELETE_STAFF(staffId);

                MessageBox.Show("Staff record permanently deleted.");
                dgvSoftDeleteRecords.DataSource = db.RETRIEVE_SOFT_DELETED_STAFF();
                Form_Instances._acc.inputreload();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not delete this record. It may still be linked to sales history.\nReason: {ex.Message}", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (dgvSoftDeleteRecords.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a staff record to restore.");
                return;
            }

            try
            {
                TBICDataContext db = new TBICDataContext();
                int staffId = Convert.ToInt32(dgvSoftDeleteRecords.SelectedRows[0].Cells["STAFF_ID"].Value);
                db.RESTORE_STAFF(staffId);

                MessageBox.Show("Staff record restored.");
                dgvSoftDeleteRecords.DataSource = db.RETRIEVE_SOFT_DELETED_STAFF();
                Form_Instances._acc.inputreload();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not restore this record.\nReason: {ex.Message}", "Restore Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
