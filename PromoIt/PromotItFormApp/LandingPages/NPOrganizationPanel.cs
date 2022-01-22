using MySql.Data.MySqlClient;
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
        public void Display()
        {
            try
            {
                MySqlDataAdapter adapter = campaign.DisplayAndSearch(Configuration.MySql);
                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                dataGridNPO.DataSource = tbl;
                dataGridNPO.Columns["name"].HeaderText = "Campaign Name";
                dataGridNPO.Columns["hashtag"].HeaderText = "Hashtag";
                dataGridNPO.Columns["webpage"].HeaderText = "URL";
                dataGridNPO.Columns["non_profit_user_name"].HeaderText = "Campaign Creator";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public NPOrganizationPanel()
        {
            InitializeComponent();
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
            Display();
        }

        private void dataGridNPO_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {
                if(MessageBox.Show("Are you sure you want to delete this campaign?", "Infurmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string hashtag = dataGridNPO.Rows[e.RowIndex].Cells[2].Value.ToString();
                    campaign.DeleteCampaign(Configuration.MySql, hashtag);
                    Display();
                }
            }
        }

    }
    
}
