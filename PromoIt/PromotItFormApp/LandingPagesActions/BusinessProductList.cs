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

        private void ProductListBC_Shown(object sender, EventArgs e) => GetProductsInCampaigns();
        
        private void GetProductsInCampaigns()
        {
            try
            {
                ProductInCampaign productInCampaign = new ProductInCampaign();
                productInCampaign.Campaign = Configuration.CorrentCampaign;
                dataGridProductList.DataSource = productInCampaign.GetList();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}
