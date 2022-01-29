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
    public partial class pnlActivist : Form
    {
        public pnlActivist()
        {
            InitializeComponent();
            GetCampaignsAsync();
            GetCashAmountAsync();
        }
        
        private void dataGridSA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                try
                {
                    if (string.IsNullOrEmpty(dgrdCampaigns["clmnHashtag", e.RowIndex].Value.ToString())) return;

                    Campaign campaign = new Campaign();
                    campaign.Hashtag = dgrdCampaigns["clmnHashtag", e.RowIndex].Value.ToString();
                    Configuration.CorrentCampaign = campaign;
                    ActivistProductList productList = new ActivistProductList();
                    DialogResult result = productList.ShowDialog();
                    if (result == DialogResult.Cancel)
                    {
                        lblMessages.Text = Configuration.Message;
                        GetCashAmountAsync();
                    }
                }
                catch { }
            }
        }

        private void panelSA_Paint(object sender, PaintEventArgs e)
        {
            pnlPanelTop.BackColor = ThemeColor.PrimaryColor;
            pnlPanelTop.ForeColor = Color.White;
        }

        private async Task GetCashAmountAsync()
        {
            ActivistUser activistUser = new ActivistUser();
            try
            {
                activistUser.UserName = Configuration.CorrentUser.UserName;
                ActivistUser result = (await activistUser.GetCashAmountAsync());
                if (result == null) throw new Exception($"Cant Receive Activist Cash report UserName ({activistUser.UserName})");
                activistUser.Cash = result?.Cash;
                txtCashBalanceCheck.Text = activistUser.Cash;
                Loggings.ReportLog($"Activist Cash report UserName ({activistUser.UserName}) Cash ({activistUser.Cash})");
            }
            catch (Exception ex) 
            {
                Loggings.ErrorLog(ex.Message);
            }
        }

        private async Task GetCampaignsAsync()
        {
            try
            {
                Campaign campaign = new Campaign();
                dgrdCampaigns.DataSource = await campaign.GetAllCampaigns_DataTableAsync();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


    }
}
