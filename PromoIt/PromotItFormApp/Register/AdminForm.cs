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
            panelAdminRegistr.BackColor = ThemeColor.PrimaryColor;
            panelAdminRegistr.ForeColor = Color.White;
        }

        private void buttonCloseAdminForm_Click(object sender, EventArgs e) => CloseWindow();

        private void buttonAdminRegister_ClickAsync(object sender, EventArgs e) =>  AdminRegisterAsync();
        private void AdminForm_Load(object sender, EventArgs e) { }


        private void CloseWindow()
        {
            if (buttonCloseAdminForm != null) this.CloseWindow();

            Main roleSystem = new Main();
            roleSystem.ShowDialog();
        }

        private async Task AdminRegisterAsync() 
        {
            try
            {
                if (textBoxAdminName.Text == "" || textBoxAdminUsername.Text == "" || textBoxAdminPassword.Text == "")
                    throw new Exception("Please fill the fields required!");

                AdminUser adminUser = new AdminUser();
                adminUser.Name = textBoxAdminName.Text;
                adminUser.UserName = textBoxAdminUsername.Text;
                adminUser.UserPassword = textBoxAdminPassword.Text;
                bool result = await adminUser.RegisterAsync();
                if (result)
                {
                    Configuration.CorrentUser = adminUser;
                    Configuration.LognUser = new Users(adminUser);
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
