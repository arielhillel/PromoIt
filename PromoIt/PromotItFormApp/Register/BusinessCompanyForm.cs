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
    public partial class BusinessCompanyForm : Form
    {
        public BusinessCompanyForm()
        {
            InitializeComponent();
        }

        private void panelBSRRegister_Paint(object sender, PaintEventArgs e)
        {
            pnlPanelTop.BackColor = ThemeColor.PrimaryColor;
            pnlPanelTop.ForeColor = Color.White;
        }

        private void buttonCloseBCRForm_Click(object sender, EventArgs e) => CloseWindow();

        private void buttonCompanyRegister_Click(object sender, EventArgs e) => RegisterBusinessCompanyAsync();

        private void BusinessCompanyForm_Load(object sender, EventArgs e) { }


        private void CloseWindow()
        {
            if (btnX == null) return;
            this.CloseWindow();
            Register roleSystem = new Register();
            roleSystem.ShowDialog();
        }

        private async Task RegisterBusinessCompanyAsync() 
        {
            try
            {
                if (txtName.Text == "" || txtUserName.Text == "" || txtPassword.Text == "")
                    throw new Exception("Please fill the fields required!");

                BusinessUser businessUser = new BusinessUser();
                businessUser.Name = txtName.Text;
                businessUser.UserName = txtUserName.Text;
                businessUser.UserPassword = txtPassword.Text;
                bool result = await businessUser.RegisterAsync();
                if (!result)
                {
                    Loggings.ErrorLog($"Business User cant register UserName ({businessUser.UserName})");
                    throw new Exception("Registeration Fail");
                }
                
                Configuration.CorrentUser = businessUser;
                Configuration.LognUser = new Users(businessUser);
                Loggings.ReportLog($"Business User registered UserName ({businessUser.UserName})");

                this.Hide();
                LandingPages.Login login = new LandingPages.Login();
                login.ShowDialog();
                this.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message);}
        }


    }

}
