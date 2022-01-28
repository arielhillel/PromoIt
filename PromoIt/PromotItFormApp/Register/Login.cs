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
            txtPassword.UseSystemPasswordChar = true;

            UserSetValues();
        }

        private void buttonLoginForm_Click(object sender, EventArgs e) => GetLoginAsync();

        private void panelLoginForm_Paint(object sender, PaintEventArgs e)
        {
            pnlPanelTop.BackColor = ThemeColor.PrimaryColor;
            pnlPanelTop.ForeColor = Color.White;
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e) => PressingEnter(e);

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e) => PressingEnter(e);




        private void UserSetValues() 
        {
            Users user = Configuration.LognUser;
            if (user != null && !string.IsNullOrEmpty(user.UserName))
            {
                txtUserName.Text = user.UserName;
                if (!string.IsNullOrEmpty(user.UserPassword))
                    txtPassword.Text = user.UserPassword;
            }
            
        }

        private void PressingEnter(KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Enter) btnLogin.PerformClick();
        }

        private async Task GetLoginAsync()
        {
            try
            {
                if (txtUserName.Text == "" || txtPassword.Text == "")
                    throw new Exception("Please provide a username and password");
                Users user = new Users();
                user.UserName = txtUserName.Text.Trim();
                user.UserPassword = txtPassword.Text.Trim();
                user = await user.LoginAsync();
                

                if (user == null)
                {
                    Loggings.ErrorLog($"User cant login UserName ({txtUserName.Text.Trim()}), Wron UserName or Password");
                    throw new Exception("Wrong username or password!");
                }
                    

                Configuration.CorrentUser = user;
                Configuration.LognUser = new Users(user);

                string? type = user.UserType;
                Form? form =
                    type == "admin" ? new pnlAdmin() :
                    type == "non-profit" ? new NonProfitPanel() :
                    type == "business" ? new BusinessPanel() :
                    type == "activist" ? new pnlActivist() :
                    null;
                if (form == null)
                {
                    Loggings.ErrorLog($"User cant login UserName ({user.UserName})");
                    throw new Exception("The system does not recognize you!");
                }
                Loggings.ReportLog($"User login UserName ({user.UserName})");


                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}