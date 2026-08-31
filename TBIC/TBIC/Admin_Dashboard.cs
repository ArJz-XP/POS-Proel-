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

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            
            this.vw_RetrieveTableAdapter1.Fill(this.tBCI_ServerDataSet1.vw_Retrieve);
            txtSearchBoxAdmin.Font = new Font("FredokaSummer", 10, FontStyle.Bold);
            lblNumberOfEmployees.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
            lblTotalEmployee.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
            btnAccManage.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
            btnAdminDashboard.Font = new Font("FredokaSummer", 9, FontStyle.Bold);

            inputReload();

            lblNumberOfEmployees.Text = db.vw_Retrieves.Count().ToString();

            this.ActiveControl = dataGridView1;
        }

        public void inputReload()
        {
            txtSearchBoxAdmin.Text = null;

            txtSearchBoxAdmin.SetPlaceholder("Search Employee");

            dataGridView1.CellFormatting += dataGridView1_CellFormatting;

            lblNumberOfEmployees.Text = db.vw_Retrieves.Count().ToString();
        }

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
            dataGridView1.DataSource = searchResult;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "pASSWORDDataGridViewTextBoxColumn" && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length); // masks with same-length asterisks
                e.FormattingApplied = true;
            }
        }
    }
}
