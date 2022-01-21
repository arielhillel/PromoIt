﻿using MySql.Data.MySqlClient;
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
            panelNPORegistr.BackColor = ThemeColor.PrimaryColor;
            panelNPORegistr.ForeColor = Color.White;
        }

        private void buttonCloseNPOForm_Click(object sender, EventArgs e) => CloseWindow();

        private void buttonNPORegister_Click(object sender, EventArgs e) => RegisterNonProfitOrganization();

        private void NonProfitOrganizationForm_Load(object sender, EventArgs e) { }

        private void CloseWindow()
        {
            if (buttonCloseNPOForm == null) return;
            this.CloseWindow();
            MainRegister roleSystem = new MainRegister();
            roleSystem.ShowDialog();
        }

        private void RegisterNonProfitOrganization()
        {
            try
            {
                if (textBoxNPOName.Text == "" || textBoxNPOUsername.Text == "" || textBoxNPOPassword.Text == "" || textBoxNPOEmail.Text == "" || textBoxNPOWebsite.Text == "")
                    throw new Exception("Please fill the fields required!");

                NonProfitUser nonProfitUser = new NonProfitUser();
                nonProfitUser.Name = textBoxNPOName.Text;
                nonProfitUser.UserName = textBoxNPOUsername.Text;
                nonProfitUser.UserPassword = textBoxNPOPassword.Text;
                nonProfitUser.Email = textBoxNPOEmail.Text;
                nonProfitUser.WebSite = textBoxNPOWebsite.Text;
                bool result = nonProfitUser.Register(Configuration.MySql);
                if (result)
                {
                    Configuration.LoginUser = nonProfitUser;
                }

                this.Hide();
                PopupForms.Login login = new PopupForms.Login();
                login.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}
