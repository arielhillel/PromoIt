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
    public partial class BusinessProductList : Form
    {

        public BusinessProductList()
        {
            InitializeComponent();
        }

        private void ProductListBC_Shown(object sender, EventArgs e) => GetProductsInCampaignsAsync();
        
        private async Task GetProductsInCampaignsAsync()
        {
            try
            {
                ProductInCampaign productInCampaign = new ProductInCampaign();
                productInCampaign.Campaign = Configuration.CorrentCampaign;
                dataGridProductList.DataSource = await productInCampaign.GetList_DataTableAsync();
                //dataGridProductList.Columns["clmnProductId"].Visible = false;
                //dataGridProductList.Columns["clmnBusinessUser"].Visible = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}
