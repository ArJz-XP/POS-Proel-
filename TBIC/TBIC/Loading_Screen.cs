using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBIC
{
    public partial class Loading_Screen : Form
    {
        public Loading_Screen()
        {
            InitializeComponent();
        }

        public void StaffInfo(string staffName, int staffID)
        {
            StaffName = staffName;
            StaffID = staffID;
        }

        string formname_;

        // Add public properties to catch the logged-in user data
        public string StaffName;
        public int StaffID;

        public void PreviousForm(string FormName)
        {
            formname_ = FormName;
        }

        private async void Loading_Screen_Load(object sender, EventArgs e)
        {
            pBLoading.Value = 0;
            pBLoading.Maximum = 100;

            if (formname_ == "Landing")
            {
                try
                {
                    lblProgressMessage.Text = "Connecting to Database...";
                    pBLoading.Value = 10;

                    await Task.Run(() =>
                    {
                        using (TBICDataContext db = new TBICDataContext())
                        {
                            db.Connection.Open();
                        }
                    });
                    pBLoading.Value = 25;

                    lblProgressMessage.Text = "Fetching Data...";
                    int totalProducts = 0;
                    await Task.Run(() =>
                    {
                        using (TBICDataContext db = new TBICDataContext())
                        {
                            totalProducts = db.STAFFs.Count();
                        }
                    });
                    pBLoading.Value = 60;

                    lblProgressMessage.Text = "Validating Request...";
                    await Task.Run(() =>
                    {
                        System.Threading.Thread.Sleep(250);
                    });
                    pBLoading.Value = 90;

                    lblProgressMessage.Text = "Ready!";
                    pBLoading.Value = 100;
                    await Task.Delay(200);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to connect to the database: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            else if (formname_ == "Limited")
            {
                try
                {
                    lblProgressMessage.Text = "Loading Assets...";
                    pBLoading.Value = 25;

                    await Task.Run(() =>
                    {
                        using (TBICDataContext db = new TBICDataContext())
                        {
                            var test = db.PRODUCTs.Count();
                        }
                    });
                    pBLoading.Value = 60;

                    lblProgressMessage.Text = "Preparing Dashboard...";
                    await Task.Run(() =>
                    {
                        System.Threading.Thread.Sleep(250);
                    });
                    pBLoading.Value = 90;

                    lblProgressMessage.Text = "Ready!";
                    pBLoading.Value = 100;
                    await Task.Delay(200);

                    this.Hide();

                    Form_Instances._lim.StaffInfo(StaffName, StaffID);
                    Form_Instances._lim.Show();

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            else if (formname_ == "Admin")
            {
                try
                {
                    lblProgressMessage.Text = "Loading Admin Panel...";
                    pBLoading.Value = 25;
                    await Task.Run(() =>
                    {
                        using (TBICDataContext db = new TBICDataContext())
                        {
                            var test = db.STAFFs.Count();
                        }
                    });
                    pBLoading.Value = 60;
                    lblProgressMessage.Text = "Preparing Dashboard...";
                    await Task.Run(() =>
                    {
                        System.Threading.Thread.Sleep(250);
                    });
                    pBLoading.Value = 90;
                    lblProgressMessage.Text = "Ready!";
                    pBLoading.Value = 100;
                    await Task.Delay(200);

                    this.Hide();

                    Form_Instances._dash.StaffInfo(StaffName, StaffID);
                    Form_Instances._dash.inputReload();
                    Form_Instances._dash.Show();

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }
    }
}