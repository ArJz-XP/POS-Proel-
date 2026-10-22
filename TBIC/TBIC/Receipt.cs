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

namespace TBIC
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            ReceiptReload();
        }

        public void ReceiptReload()
        {
            lblDate.Text = DateTime.Now.ToString("dd/mm/yyyy");
            lblCName.Text = Form_Instances._pay.lblUsername.Text;
            lblMOP.Text = Form_Instances._pay.txtMOP.Text;
            lblOrderID.Text = Form_Instances._pay.txtOrderId.Text;

            lvReciept.Items.Clear();

            foreach (DataGridViewRow row in Form_Instances._pay.dvgPOS.Rows)
            {
                if (row.IsNewRow) continue; // skip the DataGridView's built-in blank "new row"

                ListViewItem lv = new ListViewItem(row.Cells["dvgItemName"].Value?.ToString() ?? "");
                lv.SubItems.Add(row.Cells["dvgQuantity"].Value?.ToString() ?? "");
                lv.SubItems.Add(row.Cells["dvgPrice"].Value?.ToString() ?? "");

                lvReciept.Items.Add(lv);
            }

            Calculation();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Form_Instances._pay.btnConfirmPrint.Enabled = true;

            MessageBox.Show("Receipt has been printed successfully.", "Print Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form_Instances._lim.lvProductView.Items.Clear();
            Form_Instances._pay.dvgPOS.Rows.Clear();
            Form_Instances._lim.Show();
            Form_Instances._pay.Hide();
            this.Hide();
        }

        #region Calculation

        public void Calculation()
        {
            int totalQty = 0;
            foreach (ListViewItem item in lvReciept.Items)
            {
                if (int.TryParse(item.SubItems[1].Text, out int qty)) // index 1 = Quantity column
                    totalQty += qty;
            }
            lblTotalItems.Text = totalQty.ToString();

            double vat = VATCalculation();
            lblVat.Text = vat.ToString("F2");

            double.TryParse(CleanCurrency(Form_Instances._pay.rtxtDiscount.Text), out double discount);
            lblDiscounts.Text = discount.ToString("F2");

            double.TryParse(CleanCurrency(Form_Instances._pay.rtxtTotalPrice.Text), out double baseTotal);

            double finalSubtotal = baseTotal + vat - discount;
            lblSubtotal.Text = finalSubtotal.ToString("F2");

            double.TryParse(CleanCurrency(Form_Instances._pay.rtxtAmountPaid.Text), out double paid);

            lblPaidAmount.Text = paid.ToString("F2");
            lblChange.Text = (paid - baseTotal).ToString("F2");
        }

        public double VATCalculation()
        {
            if (double.TryParse(CleanCurrency(Form_Instances._pay.rtxtTotalPrice.Text), out double total))
            {
                return total * 0.12;
            }
            return 0;
        }

        private string CleanCurrency(string input)
        {
            return input.Replace("₱", "").Replace(",", "").Trim();
        }

        #endregion
    }
}
