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
    public partial class AboutSecondPage : Form
    {
        private Form activeForm;
        public AboutSecondPage()
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

                labelTermsService.BackColor = ThemeColor.PrimaryColor;
                labelPoints.BackColor = ThemeColor.SecondaryColor;
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
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonPreviousAbout_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildPages.MenuAboutPage(), sender);
        }

        private void AboutSecondPage_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
