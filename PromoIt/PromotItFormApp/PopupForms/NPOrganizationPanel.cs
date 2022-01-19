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

        private void NPOrganizationPanel_Load(object sender, EventArgs e)
        {

        }
    }
    
}
