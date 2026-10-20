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
    public partial class AddStock : Form
    {
        public AddStock()
        {
            InitializeComponent();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbItemName.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select an item.");
                    return;
                }

                if (!int.TryParse(rtxtAmount.Text, out int Quantity) || Quantity <= 0)
                {
                    MessageBox.Show("Enter a valid quantity.");
                    return;
                }

                int ProductID = cmbItemName.SelectedIndex + 1;

                TBICDataContext db = new TBICDataContext();
                db.ADD_STOCK(ProductID, Quantity);

                MessageBox.Show("Stock added successfully!");

                this.Hide();

                Form_Instances._dash.inputReload();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding stock: " + ex.Message);
            }
        }
    }
}
