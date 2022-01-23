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

namespace PromotItFormApp.PopupForms
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
            if (e.ColumnIndex == 1)
            {
                string hashtag = dataGridCampains.Rows[e.RowIndex].Cells[3].Value.ToString();
                NewProduct newProduct = new NewProduct();
                newProduct.hashtag = hashtag;
                
                newProduct.ShowDialog();
            }
            if(e.ColumnIndex == 2)
            {
                string hashtag = dataGridCampains.Rows[e.RowIndex].Cells[3].Value.ToString();
                ProductListBC productList = new ProductListBC();
                productList.hashtag=hashtag;
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


    }
}
