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

namespace PromotItFormApp.LandingPages.Actions
{
    public partial class NewProduct : Form
    {
        public NewProduct()
        {
            InitializeComponent();
        }

        private void buttonSaveProduct_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBoxProductName.Text == "" || textBoxQuantity.Text == "" || textBoxPrice.Text == "")
                    throw new Exception("Please fill the required fields");
                Product product = new Product();
                product.Name = textBoxProductName.Text;
                product.Quantity = textBoxQuantity.Text;
                product.Price = textBoxPrice.Text;
                product.Campaign_Hashtag = "#hashtag";
                var result = product.InsertNewProduct(Configuration.MySQL);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
