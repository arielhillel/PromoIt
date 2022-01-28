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
    public partial class ActivistPanel : Form
    {
        public ActivistPanel()
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
                    if (string.IsNullOrEmpty(dataGridSA["clmnHashtag", e.RowIndex].Value.ToString())) return;

                    Campaign campaign = new Campaign();
                    campaign.Hashtag = dataGridSA["clmnHashtag", e.RowIndex].Value.ToString();
                    Configuration.CorrentCampaign = campaign;
                    ActivistProductList productList = new ActivistProductList();
                    DialogResult result = productList.ShowDialog();
                    if (result == DialogResult.Cancel)
                    {
                        lblMessage.Text = Configuration.Message;
                        GetCampaignsAsync();
                        GetCashAmountAsync();
                    }
                }
                catch { }
            }
        }

        private void panelSA_Paint(object sender, PaintEventArgs e)
        {
            panelSA.BackColor = ThemeColor.PrimaryColor;
            panelSA.ForeColor = Color.White;
        }

        private async Task GetCashAmountAsync()
        {
            ActivistUser activistUser = new ActivistUser();
            try
            {
                activistUser.UserName = Configuration.CorrentUser.UserName;
                activistUser.Cash = (await activistUser.GetCashAmountAsync()).Cash;
                txtCash.Text = activistUser.Cash;
                Loggings.ReportLog($"Activist Cash report UserName ({activistUser.UserName}) Cash ({activistUser.Cash})");
            }
            catch (Exception ex) 
            {
                Loggings.ErrorLog($"Cant Receive Activist Cash report UserName ({activistUser.UserName})");
                MessageBox.Show(ex.Message); 
            }
        }

        private async Task GetCampaignsAsync()
        {
            try
            {
                Campaign campaign = new Campaign();
                dataGridSA.DataSource = await campaign.GetAllCampaigns_DataTableAsync();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


    }
}
