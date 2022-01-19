using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromotItFormApp
{
    public partial class FormMainMenu : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Constructor

        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
            buttonCloseChildForm.Visible = false;
        }

        //Methods

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);

            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color); 
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 11.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;    
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    buttonCloseChildForm.Visible = true;

                }
            }
        } 
        private void DisableButton()
        {
            foreach (Control previousButton in panelMenu.Controls)
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.FromArgb(49, 54, 56);
                    previousButton.ForeColor = Color.White;
                    previousButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            activeForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {            
            ActivateButton(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonTwitter_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonContact_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            
            ActivateButton(sender);
            RoleRegister.Main registerForm = new RoleRegister.Main();
            registerForm.ShowDialog();   
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {            
            ActivateButton(sender);
            PopupForms.Login loginForm = new PopupForms.Login();
            loginForm.ShowDialog();
        }

        private void buttonCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Reset();
            }
        }

        private void Reset()
        {
            DisableButton();
            labelTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(141, 145, 139);
            panelLogo.BackColor = Color.FromArgb(36, 35, 49);
            currentButton = null;
            buttonCloseChildForm.Visible = false;   
        }

        private void panelDesktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDesktopPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
