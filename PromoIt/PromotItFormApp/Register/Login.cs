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

namespace PromotItFormApp.PopupForms
{


    public partial class Login : Form
    {
        private void Login_Load(object sender, EventArgs e) 
        {      
                IUsers user = Configuration.LoginUser;
                if ( user != null && !string.IsNullOrEmpty(user.UserName) )
                {
                    textBoxUsername.Text = user.UserName;
                    if (!string.IsNullOrEmpty(user.UserPassword))
                        textBoxPassword.Text = user.UserPassword;
                }
        }


        public void LoginVerification()
        {
            Users user = new Users();
            Configuration.LoginUser = user;
            user.UserName = textBoxUsername.Text.Trim();
            user.UserPassword = textBoxPassword.Text.Trim();

            MySqlDataAdapter adapter = user.Login(Configuration.MySql);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count <= 0)
            {
                MessageBox.Show("Wrong username or password!");
                return;
            }


            string? type = dataTable.Rows[0]["type"] as string;
            Form? form =
                type == "Admin" ? new AdminPanel() :
                type == "Non_Profit_Organization" ? new NPOrganizationPanel() :
                type == "Business_Company" ? new BusinessCompanyPanel() :
                type == "Social_Activist" ? new SocialActivistPanel() :
                null;
            if(form == null) 
            {
                MessageBox.Show("The system does not recognize you!");
                return;
            }
            form.Show();
            this.Hide();
        }
        public Login()
        {
            InitializeComponent();
        }
        private void buttonLoginForm_Click(object sender, EventArgs e)
        {          
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Please provide a username and password");
                return;                
            }
           //else
            try{ LoginVerification(); }
            catch { }
        }

        private void panelLoginForm_Paint(object sender, PaintEventArgs e)
        {
            panelLoginForm.BackColor = ThemeColor.PrimaryColor;
            panelLoginForm.ForeColor = Color.White;
        }


        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}