using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromotItFormApp.ChildPages
{
    public partial class CompanyChildPage : Form
    {
        private Form activeForm;

        public CompanyChildPage()
        {
            InitializeComponent();
        }

        private void LoadTheme()
        {
            foreach (Control buttons in this.Controls)
            {
                if (buttons.GetType() == typeof(Button))
                {
                    Button button = (Button)buttons;
                    buttons.BackColor = ThemeColor.PrimaryColor;
                    buttons.ForeColor = Color.White;
                    button.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }

                labelServiceComp.BackColor = ThemeColor.PrimaryColor;
                //labelSecond.BackColor = ThemeColor.SecondaryColor;
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            activeForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelCompanyAbout.Controls.Add(childForm);
            this.panelCompanyAbout.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonPreviousCompany_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildPages.AboutSecondPage(), sender);
        }

        private void CompanyChildPage_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
