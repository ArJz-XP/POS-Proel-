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
            
            txtSearchBoxAdmin.Font = new Font("FredokaSummer", 10, FontStyle.Bold);
            lblNumberOfEmployees.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
            lblTotalEmployee.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
            btnAccManage.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
            btnAdminDashboard.Font = new Font("FredokaSummer", 9, FontStyle.Bold);

            inputReload();

            lblNumberOfEmployees.Text = db.vw_Retrieves.Count().ToString();

            this.ActiveControl = dgvRetrivalList;
        }

        public void inputReload()
        {
            txtSearchBoxAdmin.Text = null;

            txtSearchBoxAdmin.SetPlaceholder("Search Employee");

            dgvRetrivalList.CellFormatting += dataGridView1_CellFormatting;

            lblNumberOfEmployees.Text = db.vw_Retrieves.Count().ToString();

            #region Stocks

            lblAtlerEgo.Text = db.PRODUCTs.Where(x => x.PRODUCT_ID == 3).Select(x => x.STOCK).FirstOrDefault().ToString();
            lblDarkestRider.Text = db.PRODUCTs.Where(x => x.PRODUCT_ID == 2).Select(x => x.STOCK).FirstOrDefault().ToString();
            lblMiniMadness.Text = db.PRODUCTs.Where(x => x.PRODUCT_ID == 1).Select(x => x.STOCK).FirstOrDefault().ToString();

            lblSnowcone.Text = db.PRODUCTs.Where(x => x.PRODUCT_ID == 16).Select(x => x.STOCK).FirstOrDefault().ToString();
            lblTheBiningging.Text = db.PRODUCTs.Where(x => x.PRODUCT_ID == 17).Select(x => x.STOCK).FirstOrDefault().ToString();
            lblTasteofDnD.Text = db.PRODUCTs.Where(x => x.PRODUCT_ID == 18).Select(x => x.STOCK).FirstOrDefault().ToString();

            lblPureChoco.Text = db.PRODUCTs.Where(x => x.PRODUCT_ID == 4).Select(x => x.STOCK).FirstOrDefault().ToString();
            lblChocoKiss.Text = db.PRODUCTs.Where(x => x.PRODUCT_ID == 5).Select(x => x.STOCK).FirstOrDefault().ToString();
            lblCaramelKiss.Text = db.PRODUCTs.Where(x => x.PRODUCT_ID == 6).Select(x => x.STOCK).FirstOrDefault().ToString();

            lblGrahamMountain.Text = db.PRODUCTs.Where(x => x.PRODUCT_ID == 7).Select(x => x.STOCK).FirstOrDefault().ToString();
            lblTidbitsGalore.Text = db.PRODUCTs.Where(x => x.PRODUCT_ID == 8).Select(x => x.STOCK).FirstOrDefault().ToString();
            lblCookiesAndChunks.Text = db.PRODUCTs.Where(x => x.PRODUCT_ID == 9).Select(x => x.STOCK).FirstOrDefault().ToString();

            lblLimeFestCombo.Text = db.PRODUCTs.Where(x => x.PRODUCT_ID == 10).Select(x => x.STOCK).FirstOrDefault().ToString();
            lblSweetandRipeExpress.Text = db.PRODUCTs.Where(x => x.PRODUCT_ID == 11).Select(x => x.STOCK).FirstOrDefault().ToString();
            lblGreenAvalanche.Text = db.PRODUCTs.Where(x => x.PRODUCT_ID == 12).Select(x => x.STOCK).FirstOrDefault().ToString();

            lblMidnightFest.Text = db.PRODUCTs.Where(x => x.PRODUCT_ID == 13).Select(x => x.STOCK).FirstOrDefault().ToString();
            lblDuskGlasiers.Text = db.PRODUCTs.Where(x => x.PRODUCT_ID == 14).Select(x => x.STOCK).FirstOrDefault().ToString();
            lblTheBiteof67.Text = db.PRODUCTs.Where(x => x.PRODUCT_ID == 15).Select(x => x.STOCK).FirstOrDefault().ToString();

            #endregion

        }

        #endregion

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Instances._lan.InputReload();
            Form_Instances._lan.Show();
        }

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Already In DashBoard");
        }

        private void btnAccManage_Click(object sender, EventArgs e)
        {
            Form_Instances._acc.StaffInfo(StaffName, StaffID);
            Form_Instances._acc.inputreload();
            Form_Instances._acc.Show();
            this.Hide();
        }

        private void txtSearchBoxAdmin_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchBoxAdmin.Text == "Search Employee") return;

            string keyword = txtSearchBoxAdmin.Text.Trim();

            // Filter your view/table based on the search keyword (e.g., matching a username or name column)
            // Replace 'USERNAME' with whatever column you actually want to search in your view/table
            var searchResult = db.vw_Retrieves.Where(x => x.USERNAME.Contains(keyword) || x.STAFF_NAME.Contains(keyword)).ToList();

            // Bind the filtered list to your grid
            dgvRetrivalList.DataSource = searchResult;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvRetrivalList.Columns[e.ColumnIndex].Name == "pASSWORDDataGridViewTextBoxColumn" && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length); // masks with same-length asterisks
                e.FormattingApplied = true;
            }
        }

        #region Sorting Functionality

        private void picMaybedropboxAdmin_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(picMaybedropboxAdmin, new Point(picMaybedropboxAdmin.Width, 0));
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
                    ? db.vw_Retrieves.OrderBy(x => x.STAFF_NAME).ToList()
                    : db.vw_Retrieves.OrderByDescending(x => x.STAFF_NAME).ToList();

                dgvRetrivalList.DataSource = sorted;
            }
        }

        #endregion
    }
}
