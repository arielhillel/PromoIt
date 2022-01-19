namespace PromotItFormApp.RoleRegister
{
    partial class BusinessCompanyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessCompanyForm));
            this.buttonCompanyRegister = new System.Windows.Forms.Button();
            this.textBoxBCRPassword = new System.Windows.Forms.TextBox();
            this.textBoxBCRUsername = new System.Windows.Forms.TextBox();
            this.textBoxBCRName = new System.Windows.Forms.TextBox();
            this.labelCompanyPassword = new System.Windows.Forms.Label();
            this.labelCompanyUsername = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.labelCompanyTitle = new System.Windows.Forms.Label();
            this.panelBSRRegister = new System.Windows.Forms.Panel();
            this.buttonCloseBCRForm = new System.Windows.Forms.Button();
            this.panelBSRRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCompanyRegister
            // 
            this.buttonCompanyRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.buttonCompanyRegister.FlatAppearance.BorderSize = 0;
            this.buttonCompanyRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCompanyRegister.ForeColor = System.Drawing.Color.White;
            this.buttonCompanyRegister.Location = new System.Drawing.Point(129, 340);
            this.buttonCompanyRegister.Name = "buttonCompanyRegister";
            this.buttonCompanyRegister.Size = new System.Drawing.Size(172, 47);
            this.buttonCompanyRegister.TabIndex = 4;
            this.buttonCompanyRegister.Text = "Register";
            this.buttonCompanyRegister.UseVisualStyleBackColor = false;
            this.buttonCompanyRegister.Click += new System.EventHandler(this.buttonCompanyRegister_Click);
            // 
            // textBoxBCRPassword
            // 
            this.textBoxBCRPassword.Location = new System.Drawing.Point(12, 248);
            this.textBoxBCRPassword.Name = "textBoxBCRPassword";
            this.textBoxBCRPassword.Size = new System.Drawing.Size(407, 27);
            this.textBoxBCRPassword.TabIndex = 2;
            // 
            // textBoxBCRUsername
            // 
            this.textBoxBCRUsername.Location = new System.Drawing.Point(14, 185);
            this.textBoxBCRUsername.Name = "textBoxBCRUsername";
            this.textBoxBCRUsername.Size = new System.Drawing.Size(407, 27);
            this.textBoxBCRUsername.TabIndex = 1;
            // 
            // textBoxBCRName
            // 
            this.textBoxBCRName.Location = new System.Drawing.Point(12, 128);
            this.textBoxBCRName.Name = "textBoxBCRName";
            this.textBoxBCRName.Size = new System.Drawing.Size(407, 27);
            this.textBoxBCRName.TabIndex = 0;
            // 
            // labelCompanyPassword
            // 
            this.labelCompanyPassword.AutoSize = true;
            this.labelCompanyPassword.Location = new System.Drawing.Point(14, 225);
            this.labelCompanyPassword.Name = "labelCompanyPassword";
            this.labelCompanyPassword.Size = new System.Drawing.Size(73, 20);
            this.labelCompanyPassword.TabIndex = 3;
            this.labelCompanyPassword.Text = "Password:";
            // 
            // labelCompanyUsername
            // 
            this.labelCompanyUsername.AutoSize = true;
            this.labelCompanyUsername.Location = new System.Drawing.Point(14, 162);
            this.labelCompanyUsername.Name = "labelCompanyUsername";
            this.labelCompanyUsername.Size = new System.Drawing.Size(145, 20);
            this.labelCompanyUsername.TabIndex = 4;
            this.labelCompanyUsername.Text = "Company Username:";
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(12, 105);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(119, 20);
            this.labelCompanyName.TabIndex = 5;
            this.labelCompanyName.Text = "Company Name:";
            // 
            // labelCompanyTitle
            // 
            this.labelCompanyTitle.AutoSize = true;
            this.labelCompanyTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelCompanyTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCompanyTitle.ForeColor = System.Drawing.Color.White;
            this.labelCompanyTitle.Location = new System.Drawing.Point(86, 36);
            this.labelCompanyTitle.Name = "labelCompanyTitle";
            this.labelCompanyTitle.Size = new System.Drawing.Size(300, 28);
            this.labelCompanyTitle.TabIndex = 6;
            this.labelCompanyTitle.Text = "Business Company Registeratrion";
            // 
            // panelBSRRegister
            // 
            this.panelBSRRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(139)))));
            this.panelBSRRegister.Controls.Add(this.buttonCloseBCRForm);
            this.panelBSRRegister.Controls.Add(this.labelCompanyTitle);
            this.panelBSRRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBSRRegister.Location = new System.Drawing.Point(0, 0);
            this.panelBSRRegister.Name = "panelBSRRegister";
            this.panelBSRRegister.Size = new System.Drawing.Size(487, 92);
            this.panelBSRRegister.TabIndex = 11;
            this.panelBSRRegister.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBSRRegister_Paint);
            // 
            // buttonCloseBCRForm
            // 
            this.buttonCloseBCRForm.FlatAppearance.BorderSize = 0;
            this.buttonCloseBCRForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseBCRForm.Image = ((System.Drawing.Image)(resources.GetObject("buttonCloseBCRForm.Image")));
            this.buttonCloseBCRForm.Location = new System.Drawing.Point(421, 30);
            this.buttonCloseBCRForm.Name = "buttonCloseBCRForm";
            this.buttonCloseBCRForm.Size = new System.Drawing.Size(54, 46);
            this.buttonCloseBCRForm.TabIndex = 5;
            this.buttonCloseBCRForm.UseVisualStyleBackColor = true;
            this.buttonCloseBCRForm.Click += new System.EventHandler(this.buttonCloseBCRForm_Click);
            // 
            // BusinessCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 523);
            this.Controls.Add(this.buttonCompanyRegister);
            this.Controls.Add(this.textBoxBCRPassword);
            this.Controls.Add(this.textBoxBCRUsername);
            this.Controls.Add(this.textBoxBCRName);
            this.Controls.Add(this.labelCompanyPassword);
            this.Controls.Add(this.labelCompanyUsername);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.panelBSRRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(505, 570);
            this.MinimumSize = new System.Drawing.Size(505, 570);
            this.Name = "BusinessCompanyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BusinessCompanyForm";
            this.Load += new System.EventHandler(this.BusinessCompanyForm_Load);
            this.panelBSRRegister.ResumeLayout(false);
            this.panelBSRRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCompanyRegister;
        private System.Windows.Forms.TextBox textBoxBCRPassword;
        private System.Windows.Forms.TextBox textBoxBCRUsername;
        private System.Windows.Forms.TextBox textBoxBCRName;
        private System.Windows.Forms.Label labelCompanyPassword;
        private System.Windows.Forms.Label labelCompanyUsername;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelCompanyTitle;
        private System.Windows.Forms.Panel panelBSRRegister;
        private System.Windows.Forms.Button buttonCloseBCRForm;
    }
}