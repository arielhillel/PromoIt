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

namespace PromotItFormApp.LandingPages.Actions
{
    public partial class NewCampaign : Form
    {

        public NewCampaign()
        {
            InitializeComponent();
        }

        private void buttonSaveCamp_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxCampName.Text == "" || textBoxCampHashtag.Text == "" || textBoxCampURL.Text == "")
                    throw new Exception("Please fill the required fields");
                Campaign campaign = new Campaign();
                campaign.Name = textBoxCampName.Text;
                campaign.Hashtag = textBoxCampHashtag.Text;
                campaign.Url = textBoxCampURL.Text;
                var result = campaign.InsertNewCampaign();
               
                this.Hide();
                LandingPages.NPOrganizationPanel NPOPanel = new LandingPages.NPOrganizationPanel();
                NPOPanel.ShowDialog();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
    }
}
