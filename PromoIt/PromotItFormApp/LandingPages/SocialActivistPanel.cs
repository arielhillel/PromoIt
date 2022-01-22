﻿using MySql.Data.MySqlClient;
using PromotItFormApp.LandingPages;
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
    public partial class SocialActivistPanel : Form
    {
        Campaign campaign = new Campaign();
        public void Display()
        {

            try
            {
                MySqlDataAdapter adapter = campaign.DisplayAndSearchAll(Configuration.MySQL);
                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                dataGridSA.DataSource = tbl;
                dataGridSA.Columns["hashtag"].HeaderText = "Hashtag";
                dataGridSA.Columns["webpage"].HeaderText = "URL";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public SocialActivistPanel()
        {
            InitializeComponent();
        }


        private void dataGridSA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                string hashtag = dataGridSA.Rows[e.RowIndex].Cells[2].Value.ToString();
                ProductListSA productList = new ProductListSA();
                productList.hashtag = hashtag;
                productList.ShowDialog();
            }
        }

        private void SocialActivistPanel_Shown(object sender, EventArgs e)
        {
            Display();
        }
    }
}
