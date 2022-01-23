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
            Configuration.Message = "";
        }

        private ProductInCampaign _productInCampaign;
        private ProductDonated _productDonated;

        private void dataGridProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0) SetBuyAProduct(e);
        }

        private void ProductList_Shown(object sender, EventArgs e)
        {
            GetProducts();
        }

        private void SetBuyAProduct(DataGridViewCellEventArgs e)
        {
            _productDonated.ProductInCampaign.Id = int.Parse(dataGridProductList["id", e.RowIndex].Value.ToString());
            _productDonated.ProductInCampaign.Name = dataGridProductList["name", e.RowIndex].Value.ToString();
            _productDonated.Quantity = "1";
            _productDonated.ActivistUser = Configuration.LoginUser;
            try
            {
                bool result = _productDonated.SetBuyAnItem();
                if (result)
                {
                    Configuration.Message = $"Thanks For ordering { _productDonated.ProductInCampaign.Name} {_productDonated.Quantity}pcs\n for Campaign #{Configuration.CorrentCampaign.Hashtag}";
                    this.Dispose();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void GetProducts()
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
    }
}
