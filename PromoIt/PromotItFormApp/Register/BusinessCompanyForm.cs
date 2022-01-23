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
            panelBSRRegister.BackColor = ThemeColor.PrimaryColor;
            panelBSRRegister.ForeColor = Color.White;
        }

        private void buttonCloseBCRForm_Click(object sender, EventArgs e) => CloseWindow();

        private void buttonCompanyRegister_Click(object sender, EventArgs e) => RegisterBusinessCompany();

        private void BusinessCompanyForm_Load(object sender, EventArgs e) { }


        private void CloseWindow()
        {
            if (buttonCloseBCRForm == null) return;
            this.CloseWindow();
            Main roleSystem = new Main();
            roleSystem.ShowDialog();
        }

        private void RegisterBusinessCompany() 
        {
            try
            {
                if (textBoxBCRName.Text == "" || textBoxBCRUsername.Text == "" || textBoxBCRPassword.Text == "")
                    throw new Exception("Please fill the fields required!");

                BusinessUser businessUser = new BusinessUser();
                businessUser.Name = textBoxBCRName.Text;
                businessUser.UserName = textBoxBCRUsername.Text;
                businessUser.UserPassword = textBoxBCRPassword.Text;
                bool result = businessUser.Register();
                if (result)
                {
                    Configuration.LoginUser = businessUser;
                }

                this.Hide();
                LandingPages.Login login = new LandingPages.Login();
                login.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }

}
