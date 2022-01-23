﻿using MySql.Data.MySqlClient;
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
    public partial class ProductListSA : Form
    {
 
        public ProductListSA()
        {
            InitializeComponent();
            product = new ProductInCampaign();
        }

        private ProductInCampaign product;

        public void Display()
        {
            try
            {
                MySqlDataAdapter adapter = product.DisplayAndSearch();
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


        private void dataGridProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

            }
            if (e.ColumnIndex == 1)
            {

            }
        }

        private void ProductList_Shown(object sender, EventArgs e)
        {
            Display();
        }
    }
}