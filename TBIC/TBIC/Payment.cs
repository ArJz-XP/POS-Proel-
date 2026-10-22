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
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;

    namespace TBIC
    {
        public partial class Payment : Form
        {
            string UserName;
            int StaffID;

            // True on first launch and after every completed order, false while an order is still open
            bool needNewOrderId = true;

            private readonly Random random = new Random();

            public Payment()
            {
                InitializeComponent();

                dvgPOS.RowsAdded += dvgPOS_RowsAdded;
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
                txtOrderId.Font = new Font("FredokaSummer", 10, FontStyle.Bold);
                txtMOP.Font = new Font("FredokaSummer", 10, FontStyle.Bold);
                rtxtAmountPaid.SetPlaceholder("0.00");

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

                if (MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Form_Instances._lan.InputReload();
                    Form_Instances._lan.Show();
                    this.Hide();
                }
            }

            private void btnConfirmPrint_Click(object sender, EventArgs e)
            {
                // Stop here if the sale was not saved
                if (!SalesRecord())
                    return;

                // The order is finished, so the next batch of items gets a new ID
                needNewOrderId = true;

                // Disable the button so the same order can't be saved twice
                btnConfirmPrint.Enabled = false;

                Form_Instances._rep.ReceiptReload();
                Form_Instances._rep.Show();
            }

            #region SalesRecorder

            public bool SalesRecord()
            {            
                try
                {
                    if (dvgPOS.Rows.Count == 0)
                    {
                        MessageBox.Show("There are no existing order to print", "Error Type: Invalid Items", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return false;
                    }

                    if (string.IsNullOrWhiteSpace(txtMOP.Text))
                    {
                        MessageBox.Show("Please select a mode of payment", "Error Type: Missing Payment Method", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return false;
                    }

                    // Strip the "₱" symbol and trim spaces before parsing
                    string cleanTotalString = rtxtTotalPrice.Text.Replace("₱", "").Replace(",", "").Trim();
                    string cleanPaidString = rtxtAmountPaid.Text.Replace("₱", "").Replace(",", "").Trim();

                    decimal totalAmount = Convert.ToDecimal(cleanTotalString);
                    decimal amountPaid = Convert.ToDecimal(cleanPaidString);

                    if (amountPaid < totalAmount)
                    {
                        MessageBox.Show("The amount paid is less than the total", "Error Type: Insufficient Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return false;
                    }


                    using (var db = new TBICDataContext())
                    {
                        // ==========================================
                        // 1. CREATE THE SALE (ONE PER RECEIPT)
                        // ==========================================
                        var sale = new SALE
                        {
                            STAFF_ID = StaffID,
                            SALES_DATE = DateTime.Now,
                            TOTAL_AMOUNT = totalAmount,
                            PAYMENT_METHOD = txtMOP.Text,
                            AMOUNT_PAID = amountPaid,
                            CHANGE_AMOUNT = amountPaid - totalAmount
                        };

                        // ==========================================
                        // 2. ADD EVERY ROW OF THE GRID AS A SALE DETAIL
                        // ==========================================
                        foreach (DataGridViewRow row in dvgPOS.Rows)
                        {
                            if (row.IsNewRow) continue;

                            int currentQty = Convert.ToInt32(row.Cells["dvgQuantity"].Value);

                            // The price cell already holds unit price x quantity
                            string cleanPriceString = row.Cells["dvgPrice"].Value?.ToString().Replace("₱", "").Replace(",", "").Trim() ?? "0";
                            decimal rowPrice = Convert.ToDecimal(cleanPriceString);

                            sale.SALE_DETAILs.Add(new SALE_DETAIL
                            {
                                PRODUCT_ID = Convert.ToInt32(row.Cells["dvgItemID"].Value),
                                QUANTITY = currentQty,
                                UNIT_PRICE = Math.Round(rowPrice / currentQty, 2),
                                SUBTOTAL = rowPrice
                            });
                        }

                        // ==========================================
                        // 3. SAVE EVERYTHING AT ONCE
                        // ==========================================
                        db.SALEs.InsertOnSubmit(sale);

                        using (var scope = new System.Transactions.TransactionScope())
                        {
                            db.SubmitChanges();

                            foreach (var d in sale.SALE_DETAILs)
                                db.DEDUCT_RECIPE_STOCK(d.PRODUCT_ID, d.QUANTITY);

                            scope.Complete();
                        }

                        txtOrderId.Text = sale.SALES_ID.ToString();
                    }
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }

            #endregion

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

            private void dvgPOS_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
            {
                // Only roll a new ID for the first item of a new order
                if (!needNewOrderId) return;

                RandomizeOrderID();

                needNewOrderId = false;
            }

            private void RandomizeOrderID()
            {
                int orderId = random.Next(100000, 999999); // Generates a random number between 100000 and 999999
                txtOrderId.Text = orderId.ToString();
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

                LogoutHider.hide();

                Form_Instances._lim.lvProductView.Items.Clear();
                dvgPOS.Rows.Clear();

                Form_Instances._lim.StaffInfo(UserName, StaffID);
                Form_Instances._lim.Show();
                this.Hide();
            }

            private void btnTransHistory_Click(object sender, EventArgs e)
            {
                Form_Instances._tran.StaffInfo(UserName, StaffID);
                Form_Instances._tran.Show();
                this.Hide();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                btnLogout.Show();
            }

            private void btnCopy_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrEmpty(txtOrderId.Text))
                    return;

                Clipboard.SetText(txtOrderId.Text);

                MessageBox.Show("Order ID copied to clipboard!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }