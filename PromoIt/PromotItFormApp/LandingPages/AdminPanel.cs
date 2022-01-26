using PromotItLibrary.Classes;
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
            DisplayCampaignsAsync();
        }

        private void panelAdmin_Paint(object sender, PaintEventArgs e)
        {
            panelAdmin.BackColor = ThemeColor.PrimaryColor;
            panelAdmin.ForeColor = Color.White;
        }

        private void buttonUsersAdmin_Click(object sender, EventArgs e) => DisplayUsersAsync();

        private void buttonCampaignsAdmin_Click(object sender, EventArgs e) => DisplayCampaignsAsync();

        private void buttonTweetsAdmin_Click(object sender, EventArgs e) => DisplayTweetsAsync();

        private async Task DisplayCampaignsAsync()
        {
            try
            {
                AdminUser adminUser = new AdminUser();
                DataTable tbl = await adminUser.GetAllCampaignsAdmin_DataTableAsync();
                dataGridReports.DataSource = tbl;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async Task DisplayUsersAsync()
        {
            try
            {
                AdminUser adminUser = new AdminUser();
                DataTable tbl = await adminUser.GetAllUsers_DataTableAsync();
                dataGridReports.DataSource = tbl;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task DisplayTweetsAsync()
        {
            try
            {
                Tweet tweet = new Tweet();
                DataTable tbl = await tweet.GetAllTweets_DataTableAsync();
                dataGridReports.DataSource = tbl;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
