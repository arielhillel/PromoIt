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

namespace PromotItFormApp.LandingPagesActions
{
    public partial class ActivistProductList : Form
    {
 
        public ActivistProductList()
        {
            InitializeComponent();
            _productInCampaign = new ProductInCampaign();
            _productDonated = new ProductDonated();
        }

        private ProductInCampaign _productInCampaign;
        private ProductDonated _productDonated;

        private void Display()
        {
            try
            {
                Configuration.CorrentProduct = _productInCampaign;
                _productInCampaign.Campaign = Configuration.CorrentCampaign;
                MySqlDataAdapter adapter = _productInCampaign.GetList();
                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                dataGridProductList.DataSource = tbl;
                dataGridProductList.Columns["id"].HeaderText = "id";
                dataGridProductList.Columns["name"].HeaderText = "Product Name";
                dataGridProductList.Columns["quantity"].HeaderText = "Quantity";
                dataGridProductList.Columns["price"].HeaderText = "Price";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void dataGridProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                _productDonated.ProductInCampaign.Id = int.Parse(dataGridProductList["id", e.RowIndex].Value.ToString());
                _productDonated.Quantity = "1";
                _productDonated.ActivistUser = Configuration.LoginUser;
                Configuration.CorrentProduct = _productInCampaign;
                try
                {
                    _productDonated.SetBuyAnItem();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }


        }

        private void ProductList_Shown(object sender, EventArgs e)
        {
            Display();
        }
    }
}
