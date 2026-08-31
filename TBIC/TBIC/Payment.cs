using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBIC
{
    public partial class Payment : Form
    {
        string UserName;
        int StaffID;

        public Payment()
        {
            InitializeComponent();
        }

        public void StaffInfo(string staffName, int staffID)
        {
            UserName = staffName;
            StaffID = staffID;

            lblUsername.Text = UserName;
            lblUserID.Text = StaffID.ToString();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            txtSearchBox.Font = new Font("FredokaSummer", 10, FontStyle.Bold);
            txtOrderId.Font = new Font("FredokaSummer", 10, FontStyle.Bold);
            txtMOP.Font = new Font("FredokaSummer", 10, FontStyle.Bold);

            rtxtTotalPrice.Text = $"₱{dvgPOS.Rows.Cast<DataGridViewRow>().Sum(r => Convert.ToDouble(r.Cells["dvgPrice"].Value?.ToString().Replace("₱", "").Trim() ?? "0")):F2}";

            CalculateTotals();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (dvgPOS.Rows.Count != 0)
            {
                if (MessageBox.Show("There are still Items that have not been processed,\n are you sure you want to Logout?", "Caution Type: Unsuccessful Transaction", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    return;
                }
                else
                {
                    Form_Instances._lan.InputReload();
                    Form_Instances._lan.Show();
                    this.Hide();

                    return;
                }
            }

            Form_Instances._lan.Logout_Confirmation();
        }

        private void btnConfirmPrint_Click(object sender, EventArgs e)
        {
            if (dvgPOS.Rows.Count == 0)
            {
                MessageBox.Show("There are no existing order to print", "Error Type: Invalid Items", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            Form_Instances._rep.Show();
        }

        #region DataGridView Cell Click Handlers

        private void dvgPOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header clicks
            if (e.RowIndex < 0) return;

            string columnName = dvgPOS.Columns[e.ColumnIndex].Name;

            // ==========================================
            // 1. HANDLE QUANTITY & ROW PRICE UPDATE
            // ==========================================
            if (columnName == "Plus" || columnName == "Minus")
            {
                var qtyCell = dvgPOS.Rows[e.RowIndex].Cells["dvgQuantity"];
                var priceCell = dvgPOS.Rows[e.RowIndex].Cells["dvgPrice"];

                double currentQty = Convert.ToDouble(qtyCell.Value ?? 1);

                // Strip the "₱" symbol and trim spaces before parsing
                string cleanPriceString = priceCell.Value?.ToString().Replace("₱", "").Trim() ?? "0";
                double currentPrice = Convert.ToDouble(cleanPriceString);

                // Calculate unit price first to prevent rounding drift
                double unitPrice = currentPrice / currentQty;

                if (columnName == "Plus")
                {
                    double newQty = currentQty + 1;
                    qtyCell.Value = newQty;
                    priceCell.Value = $"₱{(unitPrice * newQty):F2}";
                }
                else if (columnName == "Minus")
                {
                    double newQty = currentQty - 1;

                    if (newQty > 0)
                    {
                        // Normal decrement if quantity is still above 0
                        qtyCell.Value = newQty;
                        priceCell.Value = $"₱{(unitPrice * newQty):F2}";
                    }
                    else
                    {
                        // Quantity hit zero or less, remove the row entirely from the grid
                        dvgPOS.Rows.RemoveAt(e.RowIndex);
                    }
                }

                CalculateTotals();
            }
        }

        public void CalculateTotals()
        {
            double grandTotal = dvgPOS.Rows.Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .Sum(r => Convert.ToDouble(r.Cells["dvgPrice"].Value?.ToString().Replace("₱", "").Trim() ?? "0"));

            double totalDiscount = 0;

            foreach (DataGridViewRow row in dvgPOS.Rows)
            {
                if (row.IsNewRow) continue;

                double rowPrice = Convert.ToDouble(row.Cells["dvgPrice"].Value?.ToString().Replace("₱", "").Trim() ?? "0");
                string selectedDiscount = row.Cells["dvgDiscount"].Value?.ToString();

                // Calculate discount based on dropdown choice
                if (selectedDiscount == "Student")
                {
                    totalDiscount += rowPrice * 0.20; // 20% off this row
                }
                else if (selectedDiscount == "Senior" || selectedDiscount == "PWD")
                {
                    totalDiscount += rowPrice * 0.30; // 30% off this row
                }
                // If "None" or blank, adds 0
            }

            rtxtTotalPrice.Text = $"₱{grandTotal - totalDiscount:F2}";
            rtxtDiscount.Text = $"₱{totalDiscount:F2}";
        }

        private void dvgPOS_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            // This forces the DataGridView to register that the ComboBox value changed immediately,
            // rather than waiting for you to click out of the row.
            if (dvgPOS.IsCurrentCellDirty)
            {
                dvgPOS.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dvgPOS_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header clicks
            if (e.RowIndex < 0) return;

            // Check if the column that changed is your discount column (or quantity/price)
            string columnName = dvgPOS.Columns[e.ColumnIndex].Name;

            if (columnName == "dvgDiscount" || columnName == "dvgQuantity" || columnName == "dvgPrice")
            {
                // Recalculate everything instantly!
                CalculateTotals();
            }
        }

        #endregion

        #region Discount Context Menu Handlers

        private void ApplyDiscountToSelected(string discountType)
        {
            // If you want it to apply to ALL rows when using the header:
            foreach (DataGridViewRow row in dvgPOS.Rows)
            {
                if (row.IsNewRow) continue;
                row.Cells["dvgDiscount"].Value = discountType;
            }

            CalculateTotals();
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyDiscountToSelected("None");
        }

        private void seniorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyDiscountToSelected("Senior");
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyDiscountToSelected("Student");
        }

        private void pWDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyDiscountToSelected("PWD");
        }

        private void btnMOP_Click(object sender, EventArgs e)
        {
            if (contextMenuStrip2 != null)
            {
                contextMenuStrip2.Show(btnMOP, new Point(0, btnMOP.Height));
            }
        }

        private void cashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMOP.Text = "Cash";
        }

        private void cardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMOP.Text = "Card";
        }

        private void eWalletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMOP.Text = "E-Wallet";
        }

        #endregion

        private void btnNewPurchase_Click(object sender, EventArgs e)
        {
            if (dvgPOS.Rows.Count != 0)
            {
                if (MessageBox.Show("There are still Items that have not been processed,\n are you sure you want to return to the Ordering Menu?", "Caution Type: Unsuccessful Transaction", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    return;
                }
            }

            Form_Instances._lim.lvProductView.Items.Clear();
            dvgPOS.Rows.Clear();

            Form_Instances._lim.StaffInfo(UserName, StaffID);
            Form_Instances._lim.Show();
            this.Hide();
        }
    }
}
