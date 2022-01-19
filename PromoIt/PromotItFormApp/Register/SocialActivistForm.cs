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
    public partial class SocialActivistForm : Form
    {
        public void InsertSocialActivist()
        {
            ActivistUser activistUser = new ActivistUser();
            activistUser.Name = textBoxSAName.Text;
            activistUser.UserName = textBoxSAUsername.Text;
            activistUser.UserPassword = textBoxSAPassword.Text;
            activistUser.Email = textBoxSAEmail.Text;
            activistUser.Address = textBoxSAAddress.Text;
            activistUser.PhoneNumber = textBoxSAPhoneNumber.Text;
            bool result = activistUser.Regiser( Configuration.MySql );
            if (result)
            {
                Configuration.LoginUser = activistUser;
            }
        }
        public SocialActivistForm()
        {
            InitializeComponent();
        }

        private void panelSARegister_Paint(object sender, PaintEventArgs e)
        {
            panelSARegister.BackColor = ThemeColor.PrimaryColor;
            panelSARegister.ForeColor = Color.White;
        }

        private void buttonCloseSAForm_Click(object sender, EventArgs e)
        {
            if (buttonCloseSAForm != null)
            {
                Close();
                Main roleSystem = new Main();
                roleSystem.ShowDialog();
            }
        }

        private void buttonSARegister_Click(object sender, EventArgs e)
        {
            if (textBoxSAName.Text == "" || textBoxSAUsername.Text == "" || textBoxSAPassword.Text == "" || textBoxSAEmail.Text == "" || textBoxSAAddress.Text == "" || textBoxSAPhoneNumber.Text == "")
            {
                MessageBox.Show("Please fill the fields required!");
                return;
            }
            else
            {
                try
                {
                    InsertSocialActivist();
                    this.Hide();
                    PopupForms.Login login = new PopupForms.Login();
                    login.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void SocialActivistForm_Load(object sender, EventArgs e)
        {

        }
    }
}