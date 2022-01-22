﻿using MySql.Data.MySqlClient;
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
        Campaign campaign = new Campaign();
        public void Display()
        {

            try
            {
                MySqlDataAdapter adapter = campaign.DisplayAndSearchAll(Configuration.MySQL);
                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                dataGridCampains.DataSource = tbl;
                dataGridCampains.Columns["hashtag"].HeaderText = "Hashtag";
                dataGridCampains.Columns["webpage"].HeaderText = "URL";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public BusinessCompanyPanel()
        {
            InitializeComponent();
        }

        private void BusinessCompanyPanel_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void dataGridBC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                NewProduct newProduct = new NewProduct();
                newProduct.ShowDialog();
            }
            if(e.ColumnIndex == 2)
            {
                ProductListBC productList = new ProductListBC();
                productList.ShowDialog();
            }
        }
    }
}
