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
    public partial class Main : Form
    {       
        public Main()
        {
            InitializeComponent();
        }

        private void buttonRegisterRole_Click(object sender, EventArgs e)
        {
            
            if (radioButtonAdmin.Checked)
            {
                this.Hide();
                new AdminForm().ShowDialog();
            }
            else if (radioButtonNPO.Checked)
            {
                this.Hide();
                new NonProfitOrganizationForm().ShowDialog();
            }
            else if (radioButtonBSR.Checked)
            {
                this.Hide();
                new BusinessCompanyForm().ShowDialog();
            }
            else if (radioButtonSA.Checked)
            {
                this.Hide();
                new SocialActivistForm().ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select your role");
            }
        }

        private void panelRoleRegister_Paint(object sender, PaintEventArgs e)
        {
            panelRoleRegister.BackColor = ThemeColor.PrimaryColor;
            panelRoleRegister.ForeColor = Color.White;
        }

        private void RoleSystem_Load(object sender, EventArgs e)
        {

        }
    }
}
