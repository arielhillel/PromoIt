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
            if (e.ColumnIndex == 0) SetBuyAProductAsync(e);
        }

        private void ProductList_Shown(object sender, EventArgs e)
        {
            GetProductsAsync();
        }

        private async Task SetBuyAProductAsync(DataGridViewCellEventArgs e)
        {
            _productDonated.ProductInCampaign.Id = dataGridProductList["clmnProductId", e.RowIndex].Value.ToString();
            _productDonated.ProductInCampaign.Name = dataGridProductList["clmnProductName", e.RowIndex].Value.ToString();
            _productDonated.Quantity = "1";
            _productDonated.ActivistUser = Configuration.CorrentUser;
            _productDonated.ProductInCampaign.BusinessUser.UserName = dataGridProductList["clmnBusinessUser", e.RowIndex].Value.ToString();   //Receive from database
            try
            {
                bool result = await _productDonated.SetBuyAnItemAsync();
                if (!result) return;
                Configuration.Message = $"Thanks For ordering { _productDonated.ProductInCampaign.Name} {_productDonated.Quantity}pcs\n for Campaign #{Configuration.CorrentCampaign.Hashtag}";
                Task sendATweet =  _productDonated.SetTwitterMessage_SetBuyAnItemAsync();
                await sendATweet;
                this.Dispose();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private async Task GetProductsAsync()
        {
            try
            {
                Configuration.CorrentProduct = _productInCampaign;
                _productInCampaign.Campaign = Configuration.CorrentCampaign;
                dataGridProductList.DataSource = await _productInCampaign.GetList_DataTableAsync();
                //dataGridProductList.Columns["clmnProductId"].Visible = false;
                //dataGridProductList.Columns["clmnBusinessUser"].Visible = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
