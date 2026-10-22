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
    public partial class StocksManagement : Form
    {
        public StocksManagement()
        {
            InitializeComponent();

            Ingredient_Load();
        }

        public void Ingredient_Load()
        {
            TBICDataContext db = new TBICDataContext();
            dgvIngredients.DataSource = db.RETRIEVE_INGREDIENTS();
        }

        private void btnAddStocks_Click(object sender, EventArgs e)
        {
            Form_Instances._addStock.cmbItemName.SelectedIndex = -1;
            Form_Instances._addStock.rtxtAmount.Text = "";
            Form_Instances._addStock.ShowDialog();
        }
    }
}
