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
            pnlPanelTop.BackColor = ThemeColor.PrimaryColor;
            pnlPanelTop.ForeColor = Color.White;
        }


        private void buttonSARegister_Click(object sender, EventArgs e) => RegisterSocialActivistAsync();
        private void SocialActivistForm_Load(object sender, EventArgs e) { }


        private async Task RegisterSocialActivistAsync()
        {
            try
            {
                if (btnName.Text == "" || txtUserName.Text == "" || txtPassword.Text == "" || txtEmail.Text == "" || txtAddress.Text == "" || txtPhoneNumber.Text == "")
                    throw new Exception("Please fill the fields required!");

                ActivistUser activistUser = new ActivistUser();
                activistUser.Name = btnName.Text;
                activistUser.UserName = txtUserName.Text;
                activistUser.UserPassword = txtPassword.Text;
                activistUser.Email = txtEmail.Text;
                activistUser.Address = txtAddress.Text;
                activistUser.PhoneNumber = txtPhoneNumber.Text;
                bool result = await activistUser.RegisterAsync();
                if (!result)
                {
                    Loggings.ErrorLog($"Activist User cant register UserName ({activistUser.UserName})");
                    throw new Exception("Registeration Fail");
                } 

                Configuration.CorrentUser = activistUser;
                Configuration.LognUser = new Users(activistUser);
                Loggings.ReportLog($"Activist User registered UserName ({activistUser.UserName})");

                this.Hide();
                LandingPages.Login login = new LandingPages.Login();
                login.ShowDialog();
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}
