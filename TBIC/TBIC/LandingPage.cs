using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBIC
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        public string StaffName;
        public int StaffID;

        private void LandingPage_Load(object sender, EventArgs e)
        {
            txtUser.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
            txtPass.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
            btnLogin.Font = new Font("FredokaSummer", 9, FontStyle.Bold);
        }

        // Reuse a single instance or create a new one when needed
        Loading_Screen Loading_;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string User = txtUser.Text;
            string Pass = txtPass.Text;

            TBICDataContext db = new TBICDataContext();

            var login = db.STAFFs.Where(x => x.USERNAME == User && x.PASSWORD == Pass).FirstOrDefault();

            if (login != null)
            {
                // Capture staff info immediately upon valid login
                StaffName = login.STAFF_NAME;
                StaffID = login.STAFF_ID;

                // Fetch the specific department info for THIS logged-in staff member
                var staffInfo = db.STAFFINFOs.Where(x => x.STAFF_ID == StaffID).FirstOrDefault();

                // Common loading screen for everyone logging in successfully
                Loading_ = new Loading_Screen();
                Loading_.PreviousForm("Landing");
                Loading_.ShowDialog();

                MessageBox.Show($"Login Successful\nWelcome {login.USERNAME}", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();

                // Check their specific department ID safely
                if (staffInfo != null && staffInfo.DEPARTMENT_ID == 1)
                {
                    // Department 1: Cashier / Limited Edition flow
                    Loading_Screen loadingLimited = new Loading_Screen();
                    loadingLimited.PreviousForm("Limited");
                    loadingLimited.StaffName = StaffName;
                    loadingLimited.StaffID = StaffID;
                    loadingLimited.ShowDialog();
                }
                else if (staffInfo != null && staffInfo.DEPARTMENT_ID == 2)
                {
                    // Department 2: Management / Admin Dashboard flow
                    Admin_Dashboard admin_ = new Admin_Dashboard();
                    admin_.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Account found, but no department assigned.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Troll();
            }
        }

        public async Task Troll()
        {
            Random R = new Random();

            for (int i = 0; i < 20; i++)
            {
                var x = R.Next(0, 1500);
                var y = R.Next(0, 500);

                DontDeleteForSuprise d = new DontDeleteForSuprise(this);
                d.Location = new Point(x, y);
                d.Show();

                await Task.Delay(100);
            }

            foreach (Form f in Application.OpenForms.Cast<Form>().ToList())
            {
                if (f is DontDeleteForSuprise)
                {
                    f.Close();
                }
            }

            if (MessageBox.Show("U DIED TO FOXY", "BOOOOOOOOOO", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
            {
                if (MessageBox.Show("YOU DARE DENY FOXY'S EXISTANCE?!?!?!?!", "HOW DARE YOU", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    MessageBox.Show("YOU WILL NOW DIE", "BYE BYE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Process.Start("shutdown", "/s /t 0");
                }
                else
                {
                    MessageBox.Show("Thought so...", "Hmmp!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}