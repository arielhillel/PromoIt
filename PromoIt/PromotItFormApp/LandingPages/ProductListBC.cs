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

namespace PromotItFormApp.LandingPages
{
    public partial class ProductListBC : Form
    {
        Product product = new Product();
        public string hashtag;
        public void Display()
        {
            try
            {
<<<<<<< HEAD
                MySqlDataAdapter adapter = product.DisplayAndSearch(Configuration.MySQL);
=======
                MySqlDataAdapter adapter = product.DisplayAndSearchByHashtag(Configuration.MySql, hashtag);
>>>>>>> 85268505f0946ea34af3c041c24f13141853692f
                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                dataGridProductList.DataSource = tbl;
                dataGridProductList.Columns["name"].HeaderText = "Product Name";
                dataGridProductList.Columns["quantity"].HeaderText = "Quantity";
                dataGridProductList.Columns["price"].HeaderText = "Price";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public ProductListBC()
        {
            InitializeComponent();
        }

        private void ProductListBC_Shown(object sender, EventArgs e)
        {
            Display();
        }
    }
}
