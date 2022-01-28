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
    public partial class AdminForm : Form
    {

        public AdminForm()
        {
            InitializeComponent();
            
        }

        private void panelAdminRegistr_Paint(object sender, PaintEventArgs e)
        {
            pnlPanelTop.BackColor = ThemeColor.PrimaryColor;
            pnlPanelTop.ForeColor = Color.White;
        }

        private void buttonCloseAdminForm_Click(object sender, EventArgs e) => CloseWindow();

        private void buttonAdminRegister_ClickAsync(object sender, EventArgs e) =>  AdminRegisterAsync();
        private void AdminForm_Load(object sender, EventArgs e) { }


        private void CloseWindow()
        {
            if (btnX != null) this.CloseWindow();

            Register roleSystem = new Register();
            roleSystem.ShowDialog();
        }

        private async Task AdminRegisterAsync() 
        {
            try
            {
                if (txtName.Text == "" || txtUserName.Text == "" || txtPassword.Text == "")
                    throw new Exception("Please fill the fields required!");

                AdminUser adminUser = new AdminUser();
                adminUser.Name = txtName.Text;
                adminUser.UserName = txtUserName.Text;
                adminUser.UserPassword = txtPassword.Text;
                bool result = await adminUser.RegisterAsync();
                if (!result)
                {
                    Loggings.ErrorLog($"Admin User cant register UserName ({adminUser.UserName})");
                    throw new Exception("Registeration Fail");
                }
                
                Configuration.CorrentUser = adminUser;
                Configuration.LognUser = new Users(adminUser);
                Loggings.ReportLog($"Admin User registered UserName ({adminUser.UserName})");

                this.Hide();
                LandingPages.Login login = new LandingPages.Login();
                login.ShowDialog();
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


    }
}
