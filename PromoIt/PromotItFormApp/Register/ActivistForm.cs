using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PromotItLibrary.Models;
using PromotItLibrary.Classes;

namespace PromotItFormApp.RoleRegister
{
    public partial class ActivistForm : Form
    {
        public ActivistForm()
        {
            InitializeComponent();
        }

        private void panelSARegister_Paint(object sender, PaintEventArgs e)
        {
            panelSARegister.BackColor = ThemeColor.PrimaryColor;
            panelSARegister.ForeColor = Color.White;
        }

        private void buttonCloseSAForm_Click(object sender, EventArgs e)
        {
            if (buttonCloseSAForm != null)
            {
                Close();
                Register roleSystem = new Register();
                roleSystem.ShowDialog();
            }
        }

        private void buttonSARegister_Click(object sender, EventArgs e) => RegisterSocialActivistAsync();
        private void SocialActivistForm_Load(object sender, EventArgs e) { }


        private async Task RegisterSocialActivistAsync()
        {
            try
            {
                if (textBoxSAName.Text == "" || textBoxSAUsername.Text == "" || textBoxSAPassword.Text == "" || textBoxSAEmail.Text == "" || textBoxSAAddress.Text == "" || textBoxSAPhoneNumber.Text == "")
                    throw new Exception("Please fill the fields required!");

                ActivistUser activistUser = new ActivistUser();
                activistUser.Name = textBoxSAName.Text;
                activistUser.UserName = textBoxSAUsername.Text;
                activistUser.UserPassword = textBoxSAPassword.Text;
                activistUser.Email = textBoxSAEmail.Text;
                activistUser.Address = textBoxSAAddress.Text;
                activistUser.PhoneNumber = textBoxSAPhoneNumber.Text;
                bool result = await activistUser.RegisterAsync();
                if (result)
                {
                    Configuration.CorrentUser = activistUser;
                    Configuration.LognUser = new Users(activistUser);
                }

                this.Hide();
                LandingPages.Login login = new LandingPages.Login();
                login.ShowDialog();
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}
