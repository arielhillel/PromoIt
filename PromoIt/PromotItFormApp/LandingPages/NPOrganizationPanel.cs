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
        public NPOrganizationPanel()
        {
            InitializeComponent();
            //Users user = new Users();
            //user.UserName = "npo";
            //Configuration.LoginUser = user;
            loadDataGrid();
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

        private void loadDataGrid() => dataGridNPO.DataSource = Campaign.ShowCampaigns(Configuration.MySql);

        private void NPOrganizationPanel_Shown(object sender, EventArgs e)
        {
            Display();
        }
    }
    
}
