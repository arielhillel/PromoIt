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
    public partial class NonProfitOrganizationForm : Form
    {

        public NonProfitOrganizationForm()
        {
            InitializeComponent();
        }

        private void panelNPORegistr_Paint(object sender, PaintEventArgs e)
        {
            pnlPanelTop.BackColor = ThemeColor.PrimaryColor;
            pnlPanelTop.ForeColor = Color.White;
        }


        private void buttonNPORegister_Click(object sender, EventArgs e) => RegisterNonProfitOrganizationAsync();

        private void NonProfitOrganizationForm_Load(object sender, EventArgs e) { }


        private async Task RegisterNonProfitOrganizationAsync()
        {
            try
            {
                if (txtName.Text == "" || txtUserName.Text == "" || txtPassword.Text == "" || txtWebSite.Text == "" || txtEmail.Text == "")
                    throw new Exception("Please fill the fields required!");

                NonProfitUser nonProfitUser = new NonProfitUser();
                nonProfitUser.Name = txtName.Text;
                nonProfitUser.UserName = txtUserName.Text;
                nonProfitUser.UserPassword = txtPassword.Text;
                nonProfitUser.Email = txtEmail.Text;
                nonProfitUser.WebSite = txtWebSite.Text;
                bool result = await nonProfitUser.RegisterAsync();
                if (!result)
                {
                    Loggings.ErrorLog($"Non Profit Company User cant register UserName ({nonProfitUser.UserName})");
                    throw new Exception("Registeration Fail");
                }

                Configuration.CorrentUser = nonProfitUser;
                Configuration.LognUser = new Users(nonProfitUser);
                Loggings.ReportLog($"Non Profit Company User registered UserName ({nonProfitUser.UserName})");
                
                this.Hide();
                LandingPages.Login login = new LandingPages.Login();
                login.ShowDialog();
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}
