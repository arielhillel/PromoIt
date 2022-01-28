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
    public partial class BusinessNewProduct : Form
    {
        public BusinessNewProduct()
        {
            InitializeComponent();
        }

        private void buttonSaveProduct_Click(object sender, EventArgs e)
            => SetCampaignProductAsync();

        private async Task SetCampaignProductAsync()
        {
            try
            {
                if (textBoxProductName.Text == "" || textBoxQuantity.Text == "" || textBoxPrice.Text == "")
                    throw new Exception("Please fill the required fields");
                ProductInCampaign product = new ProductInCampaign();
                product.Name = textBoxProductName.Text;
                product.Quantity = textBoxQuantity.Text;
                product.Price = textBoxPrice.Text;
                product.Campaign.Hashtag = Configuration.CorrentCampaign.Hashtag;
                product.BusinessUser = Configuration.CorrentUser;
                bool result = await product.SetNewProductAsync();
                if (!result)
                {
                    Loggings.ErrorLog($"Fail to insert a product by Business, UserName ({product.BusinessUser.UserName}) Campaign (#{product.Campaign.Hashtag}) Product Name ({product.Name} Quantity ({product.Quantity}) Price ({product.Price}))");
                    throw new Exception("Cant Set The product");
                }
                Loggings.ReportLog($"Business User added a product, UserName ({product.BusinessUser.UserName}) Campaign (#{product.Campaign.Hashtag}) Product Name ({product.Name} Quantity ({product.Quantity}) Price ({product.Price}))");
                this.Hide();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
