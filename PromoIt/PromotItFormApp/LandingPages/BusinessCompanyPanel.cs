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
            DisplayCampaigns();
            DisplayProductsForShipping();
        }


        private void dataGridBC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                Campaign campaign = new Campaign();
                campaign.Hashtag = dataGridCampains["clmnHashtag", e.RowIndex].Value.ToString();
                Configuration.CorrentCampaign = campaign;

                BusinessNewProduct businessNewProduct = new BusinessNewProduct();
                businessNewProduct.ShowDialog();
            }
            else if(e.ColumnIndex == 0)
            {
                Campaign campaign = new Campaign();
                campaign.Hashtag = dataGridCampains["clmnHashtag", e.RowIndex].Value.ToString();
                Configuration.CorrentCampaign = campaign;
                
                BusinessProductList businessProductList = new BusinessProductList();
                businessProductList.ShowDialog();
            }

        }

        private void DisplayCampaigns()
        {
            try
            {
                dataGridCampains.DataSource = Campaign.BusinessDisplayAll(); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayProductsForShipping()
        {
            try
            {
                ProductDonated productDonated = new ProductDonated();
                dataGridBuyers.DataSource = productDonated.ShowDonatedProductForShipping();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panelBCR_Paint(object sender, PaintEventArgs e)
        {
            panelBCR.BackColor = ThemeColor.PrimaryColor;
            panelBCR.ForeColor = Color.White;
        }
    }
}
