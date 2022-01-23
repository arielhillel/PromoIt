//using Microsoft.Azure.Cosmos;
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
using PromotItLibrary.Classes;
using PromotItLibrary.Models;
using PromotItFormApp;
using PromotItLibrary.Interfaces;

namespace PromotItFormApp.LandingPages
{

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            UserSetValues();
        }

        private void buttonLoginForm_Click(object sender, EventArgs e) => LoginAction();

        private void panelLoginForm_Paint(object sender, PaintEventArgs e)
        {
            panelLoginForm.BackColor = ThemeColor.PrimaryColor;
            panelLoginForm.ForeColor = Color.White;
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e) => PressingEnter(e);

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e) => PressingEnter(e);




        private void UserSetValues() 
        {
            IUsers user = Configuration.LoginUser;
            if (user != null && !string.IsNullOrEmpty(user.UserName))
            {
                textBoxUsername.Text = user.UserName;
                if (!string.IsNullOrEmpty(user.UserPassword))
                    textBoxPassword.Text = user.UserPassword;
            }
        }

        private void PressingEnter(KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Enter) buttonLoginForm.PerformClick();
        }

        private void LoginAction()
        {
            try
            {
                if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
                    throw new Exception("Please provide a username and password");
                Users user = new Users();
                user.UserName = textBoxUsername.Text.Trim();
                user.UserPassword = textBoxPassword.Text.Trim();
                user = user.Login();
                Configuration.LoginUser = user;

                if (user == null)
                    throw new Exception("Wrong username or password!");


                string? type = user.UserType;
                Form? form =
                    type == "admin" ? new AdminPanel() :
                    type == "non-profit" ? new NPOrganizationPanel() :
                    type == "business" ? new BusinessCompanyPanel() :
                    type == "activist" ? new SocialActivistPanel() :
                    null;
                if (form == null)
                    throw new Exception("The system does not recognize you!");

                this.Hide();
                form.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}