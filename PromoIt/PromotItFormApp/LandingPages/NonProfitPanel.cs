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
using PromotItFormApp.LandingPagesActions;

namespace PromotItFormApp.LandingPages
{

   
    public partial class NonProfitPanel : Form
    {
        Campaign _campaign = new Campaign();
        public NonProfitPanel()
        {
            InitializeComponent();
            _campaign = new Campaign();
            _campaign.NonProfitUser = Configuration.CorrentUser;
        }


        private void buttonNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            NonProfitNewCampaign newCamp = new NonProfitNewCampaign();
            newCamp.ShowDialog();
        }

        private void panelNPO_Paint(object sender, PaintEventArgs e)
        {
            panelNPO.BackColor = ThemeColor.PrimaryColor;
            panelNPO.ForeColor = Color.White;
        }
        private void NPOrganizationPanel_Shown(object sender, EventArgs e)
        {
            GetAllCampaignsDisplayAsync();
        }

        private void dataGridNPO_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {
                if(MessageBox.Show("Are you sure you want to delete this campaign?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    SetDeleteACampaignAsync(e);
                }
            }
        }


        private async Task SetDeleteACampaignAsync(DataGridViewCellEventArgs e) 
        {
            try
            {
                _campaign.Hashtag = dataGridNPO.Rows[e.RowIndex].Cells[2].Value.ToString();
                bool result = await _campaign.DeleteCampaignAsync();
                if (!result)
                {
                    Loggings.ErrorLog($"Fail Non Profit Organization user to delete the campaign, UserName ({_campaign.NonProfitUser.UserName}) Campaign (#{_campaign.Hashtag})");
                    throw new Exception("Cant Delete The campaign");
                }

                Loggings.ReportLog($"Delete Campagin by Non Profit Organization user, UserName ({_campaign.NonProfitUser.UserName}) Campaign (#{_campaign.Hashtag})");
                GetAllCampaignsDisplayAsync();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private async Task GetAllCampaignsDisplayAsync()
        {
            try
            {
                DataTable tbl = await _campaign.GetAllCampaignsNonProfit_DataTableAsync();
                dataGridNPO.DataSource = tbl;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);}
        }

    }
    
}
