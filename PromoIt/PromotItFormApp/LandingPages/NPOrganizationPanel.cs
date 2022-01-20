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

namespace PromotItFormApp.PopupForms
{
    public partial class NPOrganizationPanel : Form
    {
        public void Display()
        {
            try
            {
                Campaign das = new Campaign();
                MySqlDataAdapter adp = das.DisplayAndSearch(Configuration.MySql);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dataGridNPO.DataSource = tbl;
                dataGridNPO.Columns["name"].HeaderText = "YARON";                
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
    }
    
}
