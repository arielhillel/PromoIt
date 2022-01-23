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
   
    public partial class BusinessCompanyPanel : Form
    {

        public BusinessCompanyPanel()
        {
            InitializeComponent();
            GetCampaigns();
            GetProductsForShipping();
        }

        private void dataGridBC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
                SetNewProduct(e);
            else if (e.ColumnIndex == 0)
                GetProductListPage(e);
        }

        private void panelBCR_Paint(object sender, PaintEventArgs e)
        {
            panelBCR.BackColor = ThemeColor.PrimaryColor;
            panelBCR.ForeColor = Color.White;
        }

        private void SetNewProduct(DataGridViewCellEventArgs e)
        {
            Campaign campaign = new Campaign();
            campaign.Hashtag = dataGridCampains["clmnHashtag", e.RowIndex].Value.ToString();
            Configuration.CorrentCampaign = campaign;
            BusinessNewProduct businessNewProduct = new BusinessNewProduct();
            businessNewProduct.ShowDialog();
        }

        private void GetProductListPage(DataGridViewCellEventArgs e)
        {
            Campaign campaign = new Campaign();
            campaign.Hashtag = dataGridCampains["clmnHashtag", e.RowIndex].Value.ToString();
            Configuration.CorrentCampaign = campaign;
            BusinessProductList businessProductList = new BusinessProductList();
            businessProductList.ShowDialog();
        }

        private void GetCampaigns()
        {
            try
            {
                dataGridCampains.DataSource = Campaign.BusinessGetAllCampaigns(); ;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void GetProductsForShipping()
        {
            try
            {
                ProductDonated productDonated = new ProductDonated();
                dataGridBuyers.DataSource = productDonated.ShowDonatedProductForShipping();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }



        private void dataGridBuyers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
                SetProductAsShipped(e);
        }

        private void SetProductAsShipped(DataGridViewCellEventArgs e) 
        {
            try
            {
                ProductDonated productDonated = new ProductDonated();
                productDonated.Id = dataGridBuyers["clmnProductDonatedId", e.RowIndex].Value.ToString();
                bool result = productDonated.SetProductShipping();
                if (result) GetProductsForShipping();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
