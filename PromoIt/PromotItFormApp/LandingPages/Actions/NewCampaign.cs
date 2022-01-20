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
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                    throw new Exception("Please fill the required fields");
                Campaign campaign = new Campaign();
                campaign.Name = textBox1.Text;
                campaign.Hashtag = textBox2.Text;
                campaign.Url = textBox3.Text;
                var result = campaign.InsertNewCampaign(Configuration.MySql);
                    
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
