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
                //llForgotPassword.Hide();
            }

            private void LandingPage_Shown(object sender, EventArgs e)
            {
                this.ActiveControl = txtUser;
            }

            public string StaffName;
            public int StaffID;

            private void LandingPage_Load(object sender, EventArgs e)
            {
                PurgeExpiredStaff();

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

                lblIncorrectUsername.Visible = false;
                lblIncorrectPassword.Visible = false;
            }

            #region Login Process

            int PassTries = 0;

            private void btnLogin_Click(object sender, EventArgs e)
            {
                try
                {
                    string User = (txtUser.Text == "Username") ? "" : txtUser.Text.Trim();
                    string Pass = (txtPass.Text == "Password") ? "" : txtPass.Text;

                    lblIncorrectUsername.Visible = false;
                    lblIncorrectPassword.Visible = false;

                    TBICDataContext db = new TBICDataContext();

                    // 1. Does the username exist and belong to an active account?
                    var account = db.LOGIN_STAFF(User).FirstOrDefault();
                    if (account == null)
                    {
                        lblIncorrectUsername.Visible = true;
                        Troll();
                        return;
                    }

                    // 2. Check the typed password against the stored hash
                    if (!BCrypt.Net.BCrypt.Verify(Pass, account.PasswordHash))
                    {
                        PassTries++;

                        if (PassTries == 3)
                        {
                            llForgotPassword.Show();
                            PassTries = 0;
                        }

                        lblIncorrectPassword.Visible = true;
                        Troll();
                        return;
                    }
                    
                    var login = account;

                    // Login succeeded
                    StaffName = login.STAFF_NAME;
                    StaffID = login.STAFF_ID;

                    Form_Instances._load.StaffInfo(StaffName, StaffID);
                    Form_Instances._load.PreviousForm("Landing");
                    Form_Instances._load.ShowDialog();

                    MessageBox.Show($"Login Successful\nWelcome {login.USERNAME}", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();

                    string role = (login.ROLE ?? "").Trim();

                    if (role.Equals("Cashier", StringComparison.OrdinalIgnoreCase))
                    {
                        Form_Instances._load.StaffInfo(StaffName, StaffID);
                        Form_Instances._load.PreviousForm("Limited");
                        Form_Instances._load.ShowDialog();
                    }
                    else if (role.Equals("Manager", StringComparison.OrdinalIgnoreCase))
                    {
                        Form_Instances._load.StaffInfo(StaffName, StaffID);
                        Form_Instances._load.PreviousForm("Admin");
                        Form_Instances._load.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Account found, but no department assigned.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    LogoutHider.hide();
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

            #region Bin Purge

            private void PurgeExpiredStaff()
            {
                try
                {
                    TBICDataContext db = new TBICDataContext();

                    DateTime cutoff = DateTime.Now.AddDays(-3);
                    var expired = db.STAFFs.Where(s => !s.IS_ACTIVE && s.DELETED_AT < cutoff).ToList();

                    foreach (var s in expired)
                    {
                        try
                        {
                            db.HARD_DELETE_STAFF(s.STAFF_ID);
                        }
                        catch
                        {
                            // still linked to sales history, so it stays in the bin
                        }
                    }
                }
                catch
                {
                    // don't block the login screen if the purge fails
                }
            }

        #endregion

            private void llForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                if (new AccountRecovery(txtUser.Text.Trim()).ShowDialog() == DialogResult.OK)
                {
                    this.Hide();
                }
            }
        }
    

        #region Secret Sauce

        public static class TextBoxPlaceholderExtensions
        {
            public static void SetPlaceholder(this TextBoxBase textBox, string placeholderText, Color? placeholderColor = null)
            {
                Color normalColor = textBox.ForeColor;
                Color placeholderTextColor = placeholderColor ?? Color.Gray;
                bool showingPlaceholder = false;

                void ShowPlaceholder()
                {
                    if (!string.IsNullOrEmpty(textBox.Text)) return;

                    showingPlaceholder = true;
                    textBox.Text = placeholderText;
                    textBox.ForeColor = placeholderTextColor;

                    if (textBox is TextBox tb)
                        tb.UseSystemPasswordChar = true;
                }

                void HidePlaceholder()
                {
                    if (!showingPlaceholder) return;

                    showingPlaceholder = false;
                    textBox.Text = "";
                    textBox.ForeColor = normalColor;

                    if (textBox is TextBox tb)
                        tb.UseSystemPasswordChar = false;
                }

                textBox.Enter += (s, e) => HidePlaceholder();
                textBox.Leave += (s, e) => ShowPlaceholder();

                // If code sets real text while the placeholder is showing, switch back to the normal color
                textBox.TextChanged += (s, e) =>
                {
                    if (showingPlaceholder && textBox.Text != placeholderText)
                    {
                        showingPlaceholder = false;
                        textBox.ForeColor = normalColor;
                    }
                };

                // Show it immediately on setup
                ShowPlaceholder();
            }
        }
    

        public static class LogoutHider
        {
            public static void hide()
            {
                Form_Instances._lim.btnGoBack.Hide();
                Form_Instances._pay.btnLogout.Hide();
                Form_Instances._acc.btnGoBack.Hide();
                Form_Instances._dash.btnGoBack.Hide();
            }
        }

        #endregion
    }