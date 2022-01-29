using MySql.Data.MySqlClient;
using PromotItFormApp.LandingPages;
using PromotItFormApp.LandingPagesActions;
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
   
    public partial class BusinessPanel : Form
    {

        public BusinessPanel()
        {
            InitializeComponent();
            GetCampaignsAsync();
            GetProductsForShippingAsync();
        }

        private void dataGridBC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
                SetNewProductPage(e);
            else if (e.ColumnIndex == 0)
                GetProductListPage(e);
        }

        private void panelBCR_Paint(object sender, PaintEventArgs e)
        {
            pnlPanelTop.BackColor = ThemeColor.PrimaryColor;
            pnlPanelTop.ForeColor = Color.White;
        }

        private void dataGridBuyers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
                SetProductAsShippedAsync(e);
        }

        private void SetNewProductPage(DataGridViewCellEventArgs e)
        {
            Campaign campaign = new Campaign();
            campaign.Hashtag = dgrdCampains["clmnHashtag", e.RowIndex].Value.ToString();
            Configuration.CorrentCampaign = campaign;
            BusinessNewProduct businessNewProduct = new BusinessNewProduct();
            businessNewProduct.ShowDialog();
        }

        private void GetProductListPage(DataGridViewCellEventArgs e)
        {
            Campaign campaign = new Campaign();
            campaign.Hashtag = dgrdCampains["clmnHashtag", e.RowIndex].Value.ToString();
            Configuration.CorrentCampaign = campaign;
            BusinessProductList businessProductList = new BusinessProductList();
            businessProductList.ShowDialog();
        }

        private async Task GetCampaignsAsync()
        {
            try
            {
                Campaign campaign = new Campaign();
                dgrdCampains.DataSource = await campaign.GetAllCampaigns_DataTableAsync(); ;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private async Task GetProductsForShippingAsync()
        {
            try
            {
                ProductDonated productDonated = new ProductDonated();
                productDonated.ProductInCampaign.BusinessUser = Configuration.CorrentUser;
                dgrdActivists.DataSource = await productDonated.GetDonatedProductForShipping_DataTableAsync();
                //dataGridBuyers.Columns["clmnProductDonatedId"].Visible = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private async Task SetProductAsShippedAsync(DataGridViewCellEventArgs e) 
        {
            try
            {
                ProductDonated productDonated = new ProductDonated();
                productDonated.Id = dgrdActivists["clmnProductDonatedId", e.RowIndex].Value.ToString();
                bool result = await productDonated.SetProductShippingAsync();
                if (result != null && result) GetProductsForShippingAsync();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
