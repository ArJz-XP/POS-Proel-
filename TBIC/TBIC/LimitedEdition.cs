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
    public partial class LimitedEdition : Form
    {
        public string StaffName;
        public int StaffID;

        public LimitedEdition()
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

        TBICDataContext db = new TBICDataContext();
        #region ListView and DataGridView Initialization

        public void ProductAdder(int ID)
        {
            var product = db.PRODUCTs.FirstOrDefault(prod => prod.PRODUCT_ID == ID);

            if (product == null) return;

            bool itemExists = false;

            // Safely convert the product price to double so we can do math with it
            double unitPrice = Convert.ToDouble(product.PRICE);

            // 1. Check if the product is already in the Payment Form's DataGridView (dvgPOS)
            foreach (DataGridViewRow row in Form_Instances._pay.dvgPOS.Rows)
            {
                // Assuming Column 0 = PRODUCT_ID, Column 3 = Quantity, Column 6 = Price
                if (row.Cells[0].Value != null && Convert.ToInt32(row.Cells[0].Value) == ID)
                {
                    int existingQty = Convert.ToInt32(row.Cells[3].Value);
                    int newQty = existingQty + 1;

                    // Update Quantity and Total Price for this row
                    row.Cells[3].Value = newQty;
                    row.Cells[6].Value = $"₱{(unitPrice * newQty):F2}";

                    // Safely update the matching ListViewItem
                    var targetItem = lvProductView.Items.Cast<ListViewItem>()
                        .FirstOrDefault(item => item.SubItems[0].Text == ID.ToString());

                    if (targetItem != null)
                    {
                        targetItem.SubItems[4].Text = newQty.ToString();
                    }

                    itemExists = true;
                    break;
                }
            }

            // 2. If it's a brand new product, calculate initial values and add a new row
            if (!itemExists)
            {
                int initialQty = 1;
                double initialTotalPrice = unitPrice * initialQty; // Base calculation

                // Add to ListView (Assuming column 3 is Unit Price)
                lvProductView.Items.Add(new ListViewItem(new string[]
                {
                    product.PRODUCT_ID.ToString(),
                    product.PRODUCT_NAME,
                    product.FLAVOR,
                    $"₱{unitPrice:F2}",
                    initialQty.ToString()
                }));

                // Add to DataGridView (Quantity starts at 1, Total Price is pre-calculated)
                Form_Instances._pay.dvgPOS.Rows.Add(
                    product.PRODUCT_ID,
                    product.PRODUCT_NAME,
                    product.FLAVOR,
                    initialQty,
                    "+",
                    "-",
                    $"₱{initialTotalPrice:F2}",
                    "None"
                );
            }

            // 3. Immediately recalculate the grand total on the Payment form
            Form_Instances._pay.CalculateTotals();
        }

        #endregion

        private void btnProceedLE_Click(object sender, EventArgs e)
        {
            Form_Instances._pay.StaffInfo(StaffName, StaffID);
            Form_Instances._pay.Show();
            this.Hide();
        }

        private void LimitedEdition_Load(object sender, EventArgs e)
        {
            btnGotoAvocado.Font = new Font("FredokaSummer", 8, FontStyle.Bold);
            btnGotoHershey.Font = new Font("FredokaSummer", 8, FontStyle.Bold);
            btnGotoManggo.Font = new Font("FredokaSummer", 8, FontStyle.Bold);
            btnGotoLimted.Font = new Font("FredokaSummer", 8, FontStyle.Bold);
            btnGotoUbe.Font = new Font("FredokaSummer", 8, FontStyle.Bold);
            btnGotoVanilla.Font = new Font("FredokaSummer", 8, FontStyle.Bold);
            txtSearchLE.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
        }

        private void btnGotoLimted_Click(object sender, EventArgs e)
        {
            PanelShower();

            pnlLimited.Visible = true;
            pnlLimited.Enabled = true;
        }

        public void PanelShower()
        {
            pnlAvocado.Visible = false;
            pnlAvocado.Enabled = false;

            pnlHershey.Visible = false;
            pnlHershey.Enabled = false;

            pnlManggo.Visible = false;
            pnlManggo.Enabled = false;

            pnlLimited.Visible = false;
            pnlLimited.Enabled = false;

            pnlUbe.Visible = false;
            pnlUbe.Enabled = false;

            pnlVanilla.Visible = false;
            pnlVanilla.Enabled = false;
        }

        #region Button Clicks for Panel Navigation

        private void btnGotoHershey_Click(object sender, EventArgs e)
        {
            PanelShower();

            pnlHershey.Visible = true;
            pnlHershey.Enabled = true;
        }

        private void btnGotoManggo_Click(object sender, EventArgs e)
        {
            PanelShower();

            pnlManggo.Visible = true;
            pnlManggo.Enabled = true;
        }

        private void btnGotoAvocado_Click(object sender, EventArgs e)
        {
            PanelShower();

            pnlAvocado.Visible = true;
            pnlAvocado.Enabled = true;
        }

        private void btnGotoUbe_Click(object sender, EventArgs e)
        {
            PanelShower();

            pnlUbe.Visible = true;
            pnlUbe.Enabled = true;
        }

        private void btnGotoVanilla_Click(object sender, EventArgs e)
        {
            PanelShower();

            pnlVanilla.Visible = true;
            pnlVanilla.Enabled = true;
        }

        private void btnMiniMadness_Click(object sender, EventArgs e)
        {
            int ID = 1; // Replace with the actual product ID you want to retrieve

            ProductAdder(ID);
        }

        private void btnDarkestRider_Click(object sender, EventArgs e)
        {
            int ID = 2; // Replace with the actual product ID you want to retrieve

            ProductAdder(ID);
        }

        private void btnAlterEgo_Click(object sender, EventArgs e)
        {
            int ID = 3;

            ProductAdder(ID);
        }

        private void btnPureChoco_Click(object sender, EventArgs e)
        {
            int ID = 4;

            ProductAdder(ID);
        }

        private void btnChocoKiss_Click(object sender, EventArgs e)
        {
            int ID = 5;

            ProductAdder(ID);
        }

        private void btnCaramelKisses_Click(object sender, EventArgs e)
        {
            int ID = 6;

            ProductAdder(ID);
        }

        private void btnGraham_Click(object sender, EventArgs e)
        {
            int ID = 7;

            ProductAdder(ID);
        }

        private void btnTidbits_Click(object sender, EventArgs e)
        {
            int ID = 8;

            ProductAdder(ID);
        }

        private void btnCookiesandChunks_Click(object sender, EventArgs e)
        {
            int ID = 9;

            ProductAdder(ID);
        }

        private void btnLimaFest_Click(object sender, EventArgs e)
        {
            int ID = 10;

            ProductAdder(ID);
        }

        private void btnSweetandRipe_Click(object sender, EventArgs e)
        {
            int ID = 11;

            ProductAdder(ID);
        }

        private void btnGreenAvalanche_Click(object sender, EventArgs e)
        {
            int ID = 12;

            ProductAdder(ID);
        }

        private void btnMidnightFiest_Click(object sender, EventArgs e)
        {
            int ID = 13;

            ProductAdder(ID);
        }

        private void btnDuskGlaciers_Click(object sender, EventArgs e)
        {
            int ID = 14;

            ProductAdder(ID);
        }

        private void btnUbe67_Click(object sender, EventArgs e)
        {
            int ID = 15;

            ProductAdder(ID);
        }

        private void btnSnowCone_Click(object sender, EventArgs e)
        {
            int ID = 16;

            ProductAdder(ID);
        }

        private void btnTheBeningging_Click(object sender, EventArgs e)
        {
            int ID = 17;

            ProductAdder(ID);
        }

        private void btnTasteofDark_Click(object sender, EventArgs e)
        {
            int ID = 18;

            ProductAdder(ID);
        }

        #endregion
    }
}
