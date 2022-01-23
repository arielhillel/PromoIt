using MySql.Data.MySqlClient;
using PromotItLibrary.Classes;
using PromotItLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromotItFormApp.LandingPages
{
    public partial class ProductListBC : Form
    {
        ProductInCampaign product = new ProductInCampaign();
        public string hashtag;
        public void Display()
        {
            try
            {
                MySqlDataAdapter adapter = product.DisplayAndSearch(Configuration.MySQL);
                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                dataGridProductList.DataSource = tbl;
                dataGridProductList.Columns["name"].HeaderText = "Product Name";
                dataGridProductList.Columns["quantity"].HeaderText = "Quantity";
                dataGridProductList.Columns["price"].HeaderText = "Price";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public ProductListBC()
        {
            InitializeComponent();
        }

        private void ProductListBC_Shown(object sender, EventArgs e)
        {
            Display();
        }
    }
}
