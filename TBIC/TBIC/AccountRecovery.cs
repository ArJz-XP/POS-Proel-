using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Security;
using MimeKit;

namespace TBIC
{
    public partial class AccountRecovery : Form
    {
        TextBox[] otpBoxes;
        string _username;
        string _otp;
        DateTime _expiry;
        int _attempts;
        bool _codeSent = false;

        public AccountRecovery(string username)
        {
            InitializeComponent();
            _username = username;

            otpBoxes = new[] { txtOTPInput1, txtOTPInput2, txtOTPInput3, txtOTPInput4, txtOTPInput5, txtOTPInput6 };
            foreach (var tb in otpBoxes)
            {
                tb.Hide();
                tb.TextChanged += OtpBox_TextChanged;
                tb.KeyPress += OtpBox_KeyPress;
                tb.KeyDown += OtpBox_KeyDown;
            }
        }

        private void AccountRecovery_Shown(object sender, EventArgs e)
        {
            TBICDataContext db = new TBICDataContext();
            rtxtMessage.Text = $"Please enter the email address linked to your account.\nWe will send you a One-Time Password (OTP) to verify your identity and proceed with account recovery.\nIs this your Email? '{db.STAFFs.FirstOrDefault(x => x.USERNAME == _username)?.EMAIL}'.";
            btnVerify.Text = "VERIFY";
            this.ActiveControl = null;
        }

        private async void btnVerify_Click(object sender, EventArgs e)
        {
            if (!_codeSent)
            {
                // Step 1: look up the email, generate and send the code
                TBICDataContext db = new TBICDataContext();
                var account = db.LOGIN_STAFF(_username).FirstOrDefault();
                string email = account?.EMAIL;

                if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
                {
                    MessageBox.Show("No valid email is registered for this account. Contact your manager.");
                    return;
                }

                _otp = GenerateOtp();
                _expiry = DateTime.UtcNow.AddMinutes(5);
                _attempts = 0;

                try
                {
                    SendOtp(email, _otp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Couldn't send the email.\n" + ex.Message + "\n" + ex.InnerException?.Message);
                    return;
                }

                rtxtMessage.Text = "Enter the OTP sent to your email to confirm your identity.\nOnce verified, you can proceed with recovering your account and regaining access.";

                foreach (var tb in otpBoxes)
                {
                    tb.Show();
                    await Task.Delay(100);
                }

                otpBoxes[0].Focus();
                btnVerify.Text = "SUBMIT";
                _codeSent = true;
                return;
            }

            // Step 2: check the code
            string entered = string.Concat(otpBoxes.Select(t => t.Text));

            if (DateTime.UtcNow > _expiry || _attempts >= 5)
            {
                MessageBox.Show("Code expired. Request a new one.");
                return;
            }

            if (entered != _otp)
            {
                _attempts++;
                MessageBox.Show("Invalid code.");
                foreach (var tb in otpBoxes)
                {
                    tb.Clear();
                }
                otpBoxes[0].Focus();
                return;
            }

            _otp = null;

            MessageBox.Show("OTP verified successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var staff = new TBICDataContext().STAFFs.FirstOrDefault(x => x.USERNAME == _username && x.IS_ACTIVE);
            if (staff == null) return;

            string LoadForm = "";

            switch (staff.DEPARTMENT_ID)
            {
                case 1:
                    LoadForm = "Limited";
                    break;
                case 2:
                    LoadForm = "Admin";
                    break;
            }

            Loading_Screen loading = new Loading_Screen();
            loading.StaffInfo(staff.STAFF_NAME, staff.STAFF_ID);
            loading.PreviousForm(LoadForm);
            loading.Show();

            this.DialogResult = DialogResult.OK;   // closes this dialog
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email.Trim();
            }
            catch
            {
                return false;
            }
        }

        private string GenerateOtp()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] bytes = new byte[4];
                rng.GetBytes(bytes);
                return (BitConverter.ToUInt32(bytes, 0) % 1000000).ToString("D6");
            }
        }

        private void SendOtp(string toEmail, string otp)
        {
            var msg = new MimeMessage();
            msg.From.Add(new MailboxAddress("TBIC", "xdfisherofman@gmail.com"));
            msg.To.Add(MailboxAddress.Parse(toEmail));
            msg.Subject = "Your recovery code";
            msg.Body = new TextPart("html")
            {
                Text = "<html>" +
                       "<body style='font-family: Arial, sans-serif; background-color: #f4f6f9; padding: 20px;'>" +

                       "<div style='max-width: 500px; margin: auto; background-color: white; " +
                       "padding: 30px; border-radius: 10px;'>" +

                       "<h2 style='color: #2563eb; text-align: center;'>Account Recovery</h2>" +

                       "<p>Hello,</p>" +

                       "<p>You have requested to recover your account. " +
                       "Please use the One-Time Password (OTP) below to verify your identity.</p>" +

                       "<div style='background-color: #eff6ff; padding: 20px; " +
                       "text-align: center; border-radius: 8px; margin: 25px 0;'>" +

                       "<p style='margin: 0; color: #64748b; font-size: 14px;'>YOUR VERIFICATION CODE</p>" +

                       "<h1 style='color: #2563eb; font-size: 36px; letter-spacing: 8px; " +
                       "margin: 15px 0;'><b>" + otp + "</b></h1>" +

                       "</div>" +

                       "<p style='color: #dc2626;'><b>Important:</b> This code expires in 5 minutes.</p>" +

                       "<p>For your security, <b>do not share this code with anyone.</b></p>" +

                       "<p style='color: #64748b; font-size: 13px;'>" +
                       "If you did not request this code, you can safely ignore this email.</p>" +

                       "<hr style='border: none; border-top: 1px solid #e5e7eb; margin: 25px 0;'>" +

                       "<p style='text-align: center; color: #94a3b8; font-size: 12px;'>" +
                       "Account Support Team</p>" +

                       "</div>" +
                       "</body>" +
                       "</html>"
            };

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect("smtp.gmail.com", 465, SecureSocketOptions.SslOnConnect);
                client.Authenticate("xdfisherofman@gmail.com", "jcjxbbgskcptutkq");
                client.Send(msg);
                client.Disconnect(true);
            }
        }

        private void OtpBox_TextChanged(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;
            int i = Array.IndexOf(otpBoxes, tb);
            if (tb.Text.Length == 1 && i < otpBoxes.Length - 1)
            {
                otpBoxes[i + 1].Focus();
            }
        }

        private void OtpBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void OtpBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Control && e.KeyCode == Keys.V) || (e.Shift && e.KeyCode == Keys.Insert))
            {
                PasteOtp();
                e.SuppressKeyPress = true;
                return;
            }

            var tb = (TextBox)sender;
            int i = Array.IndexOf(otpBoxes, tb);
            if (e.KeyCode == Keys.Back && tb.Text.Length == 0 && i > 0)
            {
                otpBoxes[i - 1].Focus();
            }
        }

        private void PasteOtp()
        {
            if (!Clipboard.ContainsText()) return;

            string digits = new string(Clipboard.GetText().Where(char.IsDigit).ToArray());
            if (digits.Length == 0) return;

            for (int i = 0; i < otpBoxes.Length; i++)
            {
                otpBoxes[i].Text = i < digits.Length ? digits[i].ToString() : "";
            }

            otpBoxes[Math.Min(digits.Length, otpBoxes.Length - 1)].Focus();
        }
    }
}