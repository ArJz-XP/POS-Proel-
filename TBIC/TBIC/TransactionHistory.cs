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
    public partial class TransactionHistory : Form
    {
        public TransactionHistory()
        {
            InitializeComponent();
        }

        string StaffName;
        int StaffID;

        public void StaffInfo(string staffName, int staffID)
        {
            StaffName = staffName;
            StaffID = staffID;

            lblUsername.Text = StaffName;
            lblUserID.Text = StaffID.ToString();
        }

        private void TransactionHistory_Load(object sender, EventArgs e)
        {
            LoadContext();
        }

        private void LoadContext()
        {
            TBICDataContext db = new TBICDataContext();
            dgvTransactionHistory.DataSource = db.RETRIEVE_SALES_HISTORY();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Form_Instances._dash.StaffInfo(StaffName, StaffID);
            Form_Instances._dash.Show();
            this.Hide();
        }
    }
}
