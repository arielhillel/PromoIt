namespace PromotItFormApp.RoleRegister
{
    partial class MainRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.radioButtonNPO = new System.Windows.Forms.RadioButton();
            this.radioButtonBSR = new System.Windows.Forms.RadioButton();
            this.radioButtonSA = new System.Windows.Forms.RadioButton();
            this.buttonRegisterRole = new System.Windows.Forms.Button();
            this.labelRoleSystemRegister = new System.Windows.Forms.Label();
            this.panelRoleRegister = new System.Windows.Forms.Panel();
            this.panelRoleRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point(159, 239);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(74, 24);
            this.radioButtonAdmin.TabIndex = 0;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Admin";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            this.radioButtonAdmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.radioButtonAdmin_KeyDown);
            // 
            // radioButtonNPO
            // 
            this.radioButtonNPO.AutoSize = true;
            this.radioButtonNPO.Location = new System.Drawing.Point(159, 278);
            this.radioButtonNPO.Name = "radioButtonNPO";
            this.radioButtonNPO.Size = new System.Drawing.Size(190, 24);
            this.radioButtonNPO.TabIndex = 1;
            this.radioButtonNPO.TabStop = true;
            this.radioButtonNPO.Text = "Non-Profit Organization";
            this.radioButtonNPO.UseVisualStyleBackColor = true;
            this.radioButtonNPO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.radioButtonNPO_KeyDown);
            // 
            // radioButtonBSR
            // 
            this.radioButtonBSR.AutoSize = true;
            this.radioButtonBSR.Location = new System.Drawing.Point(159, 322);
            this.radioButtonBSR.Name = "radioButtonBSR";
            this.radioButtonBSR.Size = new System.Drawing.Size(152, 24);
            this.radioButtonBSR.TabIndex = 2;
            this.radioButtonBSR.TabStop = true;
            this.radioButtonBSR.Text = "Business Company";
            this.radioButtonBSR.UseVisualStyleBackColor = true;
            this.radioButtonBSR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.radioButtonBSR_KeyDown);
            // 
            // radioButtonSA
            // 
            this.radioButtonSA.AutoSize = true;
            this.radioButtonSA.Location = new System.Drawing.Point(159, 365);
            this.radioButtonSA.Name = "radioButtonSA";
            this.radioButtonSA.Size = new System.Drawing.Size(122, 24);
            this.radioButtonSA.TabIndex = 3;
            this.radioButtonSA.TabStop = true;
            this.radioButtonSA.Text = "Social Activist";
            this.radioButtonSA.UseVisualStyleBackColor = true;
            this.radioButtonSA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.radioButtonSA_KeyDown);
            // 
            // buttonRegisterRole
            // 
            this.buttonRegisterRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.buttonRegisterRole.FlatAppearance.BorderSize = 0;
            this.buttonRegisterRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegisterRole.ForeColor = System.Drawing.Color.White;
            this.buttonRegisterRole.Location = new System.Drawing.Point(159, 408);
            this.buttonRegisterRole.Name = "buttonRegisterRole";
            this.buttonRegisterRole.Size = new System.Drawing.Size(172, 47);
            this.buttonRegisterRole.TabIndex = 4;
            this.buttonRegisterRole.Text = "Confirm";
            this.buttonRegisterRole.UseVisualStyleBackColor = false;
            this.buttonRegisterRole.Click += new System.EventHandler(this.buttonRegisterRole_Click);
            // 
            // labelRoleSystemRegister
            // 
            this.labelRoleSystemRegister.AutoSize = true;
            this.labelRoleSystemRegister.BackColor = System.Drawing.Color.Transparent;
            this.labelRoleSystemRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRoleSystemRegister.ForeColor = System.Drawing.Color.White;
            this.labelRoleSystemRegister.Location = new System.Drawing.Point(65, 43);
            this.labelRoleSystemRegister.Name = "labelRoleSystemRegister";
            this.labelRoleSystemRegister.Size = new System.Drawing.Size(352, 28);
            this.labelRoleSystemRegister.TabIndex = 2;
            this.labelRoleSystemRegister.Text = "Please pick one of the followin options:";
            // 
            // panelRoleRegister
            // 
            this.panelRoleRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(139)))));
            this.panelRoleRegister.Controls.Add(this.labelRoleSystemRegister);
            this.panelRoleRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRoleRegister.Location = new System.Drawing.Point(0, 0);
            this.panelRoleRegister.Name = "panelRoleRegister";
            this.panelRoleRegister.Size = new System.Drawing.Size(487, 99);
            this.panelRoleRegister.TabIndex = 3;
            this.panelRoleRegister.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRoleRegister_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 523);
            this.Controls.Add(this.buttonRegisterRole);
            this.Controls.Add(this.radioButtonSA);
            this.Controls.Add(this.radioButtonBSR);
            this.Controls.Add(this.radioButtonNPO);
            this.Controls.Add(this.radioButtonAdmin);
            this.Controls.Add(this.panelRoleRegister);
            this.Location = new System.Drawing.Point(450, 480);
            this.MaximumSize = new System.Drawing.Size(505, 570);
            this.MinimumSize = new System.Drawing.Size(505, 570);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoleSystem";
            this.Load += new System.EventHandler(this.RoleSystem_Load);
            this.panelRoleRegister.ResumeLayout(false);
            this.panelRoleRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.RadioButton radioButtonNPO;
        private System.Windows.Forms.RadioButton radioButtonBSR;
        private System.Windows.Forms.RadioButton radioButtonSA;
        private System.Windows.Forms.Button buttonRegisterRole;
        private System.Windows.Forms.Label labelRoleSystemRegister;
        private System.Windows.Forms.Panel panelRoleRegister;
    }
}