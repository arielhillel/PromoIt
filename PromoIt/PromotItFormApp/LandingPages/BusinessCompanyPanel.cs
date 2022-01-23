using MySql.Data.MySqlClient;
using PromotItFormApp.LandingPages;
using PromotItFormApp.LandingPages.Actions;
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
        }

        
        private void dataGridBC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Campaign campaign = new Campaign();
                campaign.Hashtag = dataGridCampains["clmnHashtag", e.RowIndex].Value.ToString();
                Configuration.CorrentCampaign = campaign;

                NewProduct newProduct = new NewProduct();
                newProduct.ShowDialog();
            }
            
            if(e.ColumnIndex == 1)
            {
                Campaign campaign = new Campaign();
                campaign.Hashtag = dataGridCampains["clmnHashtag", e.RowIndex].Value.ToString();
                Configuration.CorrentCampaign = campaign;
                ProductListBC productList = new ProductListBC();
                productList.ShowDialog();
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

        private void panelBCR_Paint(object sender, PaintEventArgs e)
        {
            panelBCR.BackColor = ThemeColor.PrimaryColor;
            panelBCR.ForeColor = Color.White;
        }
    }
}
