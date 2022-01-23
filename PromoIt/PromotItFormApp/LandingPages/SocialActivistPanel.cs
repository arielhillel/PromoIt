using MySql.Data.MySqlClient;
using PromotItFormApp.LandingPages;
using PromotItFormApp.LandingPagesActions;
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
    public partial class SocialActivistPanel : Form
    {
        public SocialActivistPanel()
        {
            InitializeComponent();
            GetCampaigns();
            

        }
        
        private void dataGridSA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                Campaign campaign = new Campaign();
                campaign.Hashtag = dataGridSA["clmnHashtag", e.RowIndex].Value.ToString();
                Configuration.CorrentCampaign = campaign;
                ActivistProductList productList = new ActivistProductList();
                DialogResult result = productList.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    lblMessage.Text = Configuration.Message;
                    GetCampaigns();
                }
            }
        }


        private void panelSA_Paint(object sender, PaintEventArgs e)
        {
            panelSA.BackColor = ThemeColor.PrimaryColor;
            panelSA.ForeColor = Color.White;
        }

        private void GetCampaigns()
        {
            try
            {
                dataGridSA.DataSource = Campaign.BusinessGetAllCampaigns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
