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
    public partial class pnlAdmin : Form
    {
        public pnlAdmin()
        {
            InitializeComponent();
            DisplayCampaignsAsync();
        }

        private void panelAdmin_Paint(object sender, PaintEventArgs e)
        {
            pnlPanelTop.BackColor = ThemeColor.PrimaryColor;
            pnlPanelTop.ForeColor = Color.White;
        }

        private void buttonUsersAdmin_Click(object sender, EventArgs e) => DisplayUsersAsync();

        private void buttonCampaignsAdmin_Click(object sender, EventArgs e) => DisplayCampaignsAsync();

        private void buttonTweetsAdmin_Click(object sender, EventArgs e) => DisplayTweetsAsync();

        private async Task DisplayCampaignsAsync()
        {
            try
            {
                AdminUser adminUser = new AdminUser();
                adminUser.UserName = Configuration.CorrentUser.UserName;
                DataTable tbl = await adminUser.GetAllCampaignsAdmin_DataTableAsync();
                dgrdReportsData.DataSource = tbl;

            } catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private async Task DisplayUsersAsync()
        {
            try
            {
                AdminUser adminUser = new AdminUser();
                adminUser.UserName = Configuration.CorrentUser.UserName;
                DataTable tbl = await adminUser.GetAllUsers_DataTableAsync();
                dgrdReportsData.DataSource = tbl;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private async Task DisplayTweetsAsync()
        {
            try
            {
                Tweet tweet = new Tweet();
                DataTable tbl = await tweet.GetAllTweets_DataTableAsync();
                dgrdReportsData.DataSource = tbl;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}
