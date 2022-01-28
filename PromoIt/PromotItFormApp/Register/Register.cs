using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromotItFormApp.RoleRegister
{
    public partial class Register : Form
    {       
        public Register()
        {
            InitializeComponent();
        }

        private void buttonRegisterRole_Click(object sender, EventArgs e) => GetRadioButtonPage();

        private void panelRoleRegister_Paint(object sender, PaintEventArgs e)
        {
            pnlPanelTop.BackColor = ThemeColor.PrimaryColor;
            pnlPanelTop.ForeColor = Color.White;
        }
        private void radioButtonAdmin_KeyDown(object sender, KeyEventArgs e) => PressingEnter(e);
        private void radioButtonNPO_KeyDown(object sender, KeyEventArgs e) => PressingEnter(e);
        private void radioButtonBSR_KeyDown(object sender, KeyEventArgs e) => PressingEnter(e);
        private void radioButtonSA_KeyDown(object sender, KeyEventArgs e) => PressingEnter(e);
        private void RoleSystem_Load(object sender, EventArgs e) { }


        private void PressingEnter(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnRegister.PerformClick();
        }

        private void GetRadioButtonPage() 
        {
            try
            {
                this.Hide();
                if (chkAdmin.Checked)
                    new AdminForm().ShowDialog();
                else if (chkNonProfit.Checked)
                    new NonProfitOrganizationForm().ShowDialog();
                else if (chkBuisness.Checked)
                    new BusinessCompanyForm().ShowDialog();
                else if (chkActivist.Checked)
                    new ActivistForm().ShowDialog();
                else
                    throw new Exception("Please select your role");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }




    }
}
