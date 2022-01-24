﻿using PromotItLibrary.Classes;
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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            DisplayCampaigns();
        }

        private void panelAdmin_Paint(object sender, PaintEventArgs e)
        {
            panelAdmin.BackColor = ThemeColor.PrimaryColor;
            panelAdmin.ForeColor = Color.White;
        }

        private void buttonUsersAdmin_Click(object sender, EventArgs e) => DisplayUsers();

        private void buttonCampaignsAdmin_Click(object sender, EventArgs e) => DisplayCampaigns();

        private void buttonTweetsAdmin_Click(object sender, EventArgs e) => DisplayTweets();

        private void DisplayCampaigns()
        {
            try
            {
                DataTable tbl = AdminUser.GetAllCampaigns();
                dataGridReports.DataSource = tbl;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DisplayUsers()
        {
            try
            {
                DataTable tbl = AdminUser.GetAllUsers();
                dataGridReports.DataSource = tbl;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayTweets()
        {
            try
            {
                DataTable tbl = AdminUser.GetAllTweets();
                dataGridReports.DataSource = tbl;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
