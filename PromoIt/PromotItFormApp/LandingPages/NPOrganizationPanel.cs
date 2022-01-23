﻿using MySql.Data.MySqlClient;
using PromotItLibrary.Classes;
using PromotItLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using PromotItLibrary.Models;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PromotItLibrary.Classes;

namespace PromotItFormApp.PopupForms
{

   
    public partial class NPOrganizationPanel : Form
    {
        Campaign campaign = new Campaign();
        public NPOrganizationPanel()
        {
            InitializeComponent();
            Campaign campaign = new Campaign();
        }


        private void buttonNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewCampaign newCamp = new NewCampaign();
            newCamp.ShowDialog();
        }

        private void panelNPO_Paint(object sender, PaintEventArgs e)
        {
            panelNPO.BackColor = ThemeColor.PrimaryColor;
            panelNPO.ForeColor = Color.White;
        }
        private void NPOrganizationPanel_Shown(object sender, EventArgs e)
        {
            DisplayCampaigns();
        }

        private void dataGridNPO_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {
                if(MessageBox.Show("Are you sure you want to delete this campaign?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string hashtag = dataGridNPO.Rows[e.RowIndex].Cells[3].Value.ToString();
                    campaign.DeleteCampaign(hashtag);
                    DisplayCampaigns();
                }
            }
        }


        private void DisplayCampaigns()
        {
            try
            {
                DataTable tbl = campaign.ShowNPOCampaigns();
                dataGridNPO.DataSource = tbl;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
    
}
