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
    public partial class MenuAboutPage : Form
    {
        public MenuAboutPage()
        {
            InitializeComponent();
        }
        private void MenuAboutPage_Load(object sender, EventArgs e)
        {
            LoadTheme();
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

                label1.BackColor = ThemeColor.PrimaryColor;
                label2.BackColor = ThemeColor.SecondaryColor;
            }
        }
    }
}
