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
        public SocialActivistPanel()
        {
            InitializeComponent();
            DisplayCampaigns();
        }

        private void dataGridSA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                Campaign campaign = new Campaign();
                campaign.Hashtag = dataGridSA["clmnHashtag",e.RowIndex].Value.ToString();
                Configuration.CorrentCampaign = campaign;

                ProductListSA productList = new ProductListSA();
                productList.ShowDialog();
            }
        }

        private void DisplayCampaigns()
        {

            try
            {
                dataGridSA.DataSource = Campaign.BusinessDisplayAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panelSA_Paint(object sender, PaintEventArgs e)
        {
            panelSA.BackColor = ThemeColor.PrimaryColor;
            panelSA.ForeColor = Color.White;
        }
    }
}
