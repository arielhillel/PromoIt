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
        public string hashtag;
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
<<<<<<< HEAD
                product.Campaign_Hashtag = "#hashtag";
                var result = product.InsertNewProduct(Configuration.MySQL);
=======
                product.Campaign_Hashtag = hashtag;
                var result = product.InsertNewProduct(Configuration.MySql);
>>>>>>> 85268505f0946ea34af3c041c24f13141853692f
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
