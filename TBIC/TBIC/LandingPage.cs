using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

            txtPass.UseSystemPasswordChar = false;

            InputReload();
        }

        public void InputReload()
        {
            txtUser.Text = null;
            txtPass.Text = null;

            txtUser.SetPlaceholder("Username");
            txtPass.SetPlaceholder("Password");
        }

        #region Login Process

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string User = (txtUser.Text == "Username") ? "" : txtUser.Text;
                string Pass = (txtPass.Text == "Password") ? "" : txtPass.Text;

                TBICDataContext db = new TBICDataContext();

                var login = db.STAFFs.Where(x => x.USERNAME == User && x.PASSWORD == Pass).FirstOrDefault();

                if (login != null)
                {
                    // Capture staff info immediately upon valid login
                    StaffName = login.STAFF_NAME;
                    StaffID = login.STAFF_ID;

                    // Fetch the specific department info for THIS logged-in staff member
                    var staffInfo = db.STAFFs.Where(x => x.STAFF_ID == StaffID).FirstOrDefault();

                    // Common loading screen for everyone logging in successfully
                    Form_Instances._load.StaffInfo(StaffName, StaffID);
                    Form_Instances._load.PreviousForm("Landing");
                    Form_Instances._load.ShowDialog();

                    MessageBox.Show($"Login Successful\nWelcome {login.USERNAME}", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();

                    // Check their specific department ID safely
                    if (staffInfo != null && staffInfo.ROLE == "Cashier")
                    {
                        // Department 1: Cashier / Limited Edition flow
                        Form_Instances._load.StaffInfo(StaffName, StaffID);
                        Form_Instances._load.PreviousForm("Limited");
                        Form_Instances._load.ShowDialog();
                    }
                    else if (staffInfo != null && staffInfo.ROLE == "Manager")
                    {
                        // Department 2: Management / Admin Dashboard flow
                        Form_Instances._load.StaffInfo(StaffName, StaffID);
                        Form_Instances._load.PreviousForm("Admin");
                        Form_Instances._load.ShowDialog();
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
            catch (Exception ex)
            {
                MessageBox.Show($"Something Went Wrong!\n{ex.Message}", "Error Type: Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region UI Enhancements

        public async Task Troll()
        {
            Random R = new Random();

            for (int i = 0; i < 20; i++)
            {
                var x = R.Next(0, 1500);
                var y = R.Next(0, 500);

                DontDeleteForSuprise d = new DontDeleteForSuprise();
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

        #endregion

        public void Logout_Confirmation()
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Form_Instances._lan.InputReload();
                Form_Instances._lan.Show();
                this.Hide();
            }
        }
    }

    #region Secret Sauce

    public static class TextBoxPlaceholderExtensions
    {
        public static void SetPlaceholder(this TextBox textBox, string placeholderText, Color? placeholderColor = null)
        {
            Color normalColor = textBox.ForeColor;
            Color placeholderTextColor = placeholderColor ?? Color.Gray;

            void ShowPlaceholder()
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = placeholderText;
                    textBox.ForeColor = placeholderTextColor;
                    textBox.UseSystemPasswordChar = true;
                }
            }

            void HidePlaceholder()
            {
                if (textBox.Text == placeholderText && textBox.ForeColor == placeholderTextColor)
                {
                    textBox.Text = "";
                    textBox.ForeColor = normalColor;
                    textBox.UseSystemPasswordChar = false;
                }
            }

            textBox.Enter += (s, e) => HidePlaceholder();
            textBox.Leave += (s, e) => ShowPlaceholder();

            // Show it immediately on setup
            ShowPlaceholder();
        }
    }

    #endregion
}