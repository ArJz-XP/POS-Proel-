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
    public partial class Acc_Management : Form
    {
        public Acc_Management()
        {
            InitializeComponent();
        }

        private void btnDashBoardManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Dashboard admin_Dashboard = new Admin_Dashboard();
            admin_Dashboard.Show();
        }

        private void btnManageManage_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Already In Account Management");
        }

        private void Acc_Management_Load(object sender, EventArgs e)
        {
            btnDashBoardManage.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
            btnManageManage.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
            txtAddName.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
            txtAddPassword.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
            txtSearchEmploys.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
        }
    }
}
