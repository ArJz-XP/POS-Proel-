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

        private void btnNewPurchase_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to start a new purchase?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form_Instances._lim.lvProductView.Items.Clear();
                Form_Instances._pay.dvgPOS.Rows.Clear();
                Form_Instances._lim.StaffInfo(StaffName, StaffID);
                Form_Instances._lim.Show();
                this.Hide();
            }            
        }
    }
}
