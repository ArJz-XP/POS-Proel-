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
    public partial class Admin_Dashboard : Form
    {
        string StaffName;
        int StaffID;

        public Admin_Dashboard()
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

        #region Loading

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            lblNumberOfEmployees.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
            lblTotalEmployee.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
            btnAccManage.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
            btnAdminDashboard.Font = new Font("FredokaSummer", 9, FontStyle.Bold);

            inputReload();
        }

        public void inputReload()
        {
            lblNumberOfEmployees.Text = db.RETRIEVE_STAFF().Count().ToString();

            LoadProductStock();

            lblTotalOrders.Text = db.RETRIEVE_SALES_HISTORY().Count().ToString();

            lblTotalSales.Text = Convert.ToDecimal(db.RETRIEVE_SALES_HISTORY().Sum(s => s.TOTAL_AMOUNT)).ToString("N0");
        }

        private void LoadProductStock()
        {
            using (var db = new TBICDataContext())
            {
                var products = db.ExecuteQuery<ProductStockResult>(
                    "EXEC dbo.RETRIEVE_PRODUCT_STOCK"
                ).ToList();

                lblAtlerEgo.Text = GetStock(products, 3);
                lblDarkestRider.Text = GetStock(products, 2);
                lblMiniMadness.Text = GetStock(products, 1);

                lblSnowcone.Text = GetStock(products, 16);
                lblTheBiningging.Text = GetStock(products, 17);
                lblTasteofDnD.Text = GetStock(products, 18);

                lblPureChoco.Text = GetStock(products, 4);
                lblChocoKiss.Text = GetStock(products, 5);
                lblCaramelKiss.Text = GetStock(products, 6);

                lblGrahamMountain.Text = GetStock(products, 7);
                lblTidbitsGalore.Text = GetStock(products, 8);
                lblCookiesAndChunks.Text = GetStock(products, 9);

                lblLimeFestCombo.Text = GetStock(products, 10);
                lblSweetandRipeExpress.Text = GetStock(products, 11);
                lblGreenAvalanche.Text = GetStock(products, 12);

                lblMidnightFest.Text = GetStock(products, 13);
                lblDuskGlasiers.Text = GetStock(products, 14);
                lblTheBiteof67.Text = GetStock(products, 15);
            }
        }

        private string GetStock(
            List<ProductStockResult> products,
            int productId)
        {
            var product = products.FirstOrDefault(
                p => p.PRODUCT_ID == productId
            );

            return product?.STOCK.ToString() ?? "0";
        }

        public class ProductStockResult
        {
            public int PRODUCT_ID { get; set; }
            public string PRODUCT_NAME { get; set; }
            public int STOCK { get; set; }
        }

        #endregion

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Form_Instances._lan.InputReload();
                Form_Instances._lan.Show();
                this.Hide();
            }
        }

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Already In DashBoard");
        }

        private void btnAccManage_Click(object sender, EventArgs e)
        {
            LogoutHider.hide();

            Form_Instances._acc.StaffInfo(StaffName, StaffID);
            Form_Instances._acc.inputreload();
            Form_Instances._acc.Show();
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            btnGoBack.Show();
        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            Form_Instances._tran.StaffInfo(StaffName, StaffID);
            Form_Instances._tran.Show();
            this.Hide();
        }

        private void btnStockManagement_Click(object sender, EventArgs e)
        {
            Form_Instances._stock.ShowDialog();
        }
    }
}
