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
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        TBICDataContext db = new TBICDataContext();

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            txtSearchBoxAdmin.Font = new Font("FredokaSummer", 10, FontStyle.Bold);
            lblNumberOfEmployees.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
            lblTotalEmployee.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
            btnAccManage.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
            btnAdminDashboard.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
            btnGoBack.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
            dataGridView1.DataSource = db.vw_Retrieves.ToList();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment payment = new Payment();
            payment.Show();
        }

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Already In DashBoard");
        }

        private void btnAccManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acc_Management acc_Management = new Acc_Management();
            acc_Management.Show();
        }

        private void txtSearchBoxAdmin_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchBoxAdmin.Text.Trim();

            // Filter your view/table based on the search keyword (e.g., matching a username or name column)
            // Replace 'USERNAME' with whatever column you actually want to search in your view/table
            var searchResult = db.vw_Retrieves.Where(x => x.USERNAME.Contains(keyword)).ToList();

            // Bind the filtered list to your grid
            dataGridView1.DataSource = searchResult;
        }
    }
}
