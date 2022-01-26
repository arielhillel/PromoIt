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
                var result = await product.SetNewProductAsync();
                this.Hide();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
