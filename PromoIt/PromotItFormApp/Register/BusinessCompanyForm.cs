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
        public void InsertBusinessCompany()
        {
            BusinessUser businessUser = new BusinessUser();
            businessUser.Name = textBoxBCRName.Text;
            businessUser.UserName = textBoxBCRUsername.Text;
            businessUser.UserPassword = textBoxBCRPassword.Text;
            bool result = businessUser.Register( Configuration.MySql );
            if (result)
            {
                Configuration.LoginUser = businessUser;
            }
        }
        public BusinessCompanyForm()
        {
            InitializeComponent();
        }

        private void panelBSRRegister_Paint(object sender, PaintEventArgs e)
        {
            panelBSRRegister.BackColor = ThemeColor.PrimaryColor;
            panelBSRRegister.ForeColor = Color.White;
        }

        private void buttonCloseBCRForm_Click(object sender, EventArgs e)
        {
            if (buttonCloseBCRForm != null)
            {
                Close();
                Main roleSystem = new Main();
                roleSystem.ShowDialog();
            }
        }

        private void buttonCompanyRegister_Click(object sender, EventArgs e)
        {
            if (textBoxBCRName.Text == "" || textBoxBCRUsername.Text == "" || textBoxBCRPassword.Text == "")
            {
                MessageBox.Show("Please fill the fields required!");
                return;
            }
            else
            {
                try
                {
                    InsertBusinessCompany();
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

        private void BusinessCompanyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
