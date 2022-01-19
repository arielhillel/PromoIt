namespace PromotItFormApp.RoleRegister
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.labelAdminTitle = new System.Windows.Forms.Label();
            this.labelAdminFullName = new System.Windows.Forms.Label();
            this.labelAdminUsername = new System.Windows.Forms.Label();
            this.labelAdminPassword = new System.Windows.Forms.Label();
            this.textBoxAdminName = new System.Windows.Forms.TextBox();
            this.textBoxAdminUsername = new System.Windows.Forms.TextBox();
            this.textBoxAdminPassword = new System.Windows.Forms.TextBox();
            this.buttonAdminRegister = new System.Windows.Forms.Button();
            this.panelAdminRegistr = new System.Windows.Forms.Panel();
            this.buttonCloseAdminForm = new System.Windows.Forms.Button();
            this.panelAdminRegistr.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAdminTitle
            // 
            this.labelAdminTitle.AutoSize = true;
            this.labelAdminTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelAdminTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdminTitle.ForeColor = System.Drawing.Color.White;
            this.labelAdminTitle.Location = new System.Drawing.Point(146, 29);
            this.labelAdminTitle.Name = "labelAdminTitle";
            this.labelAdminTitle.Size = new System.Drawing.Size(190, 28);
            this.labelAdminTitle.TabIndex = 0;
            this.labelAdminTitle.Text = "Admin Registeration";
            // 
            // labelAdminFullName
            // 
            this.labelAdminFullName.AutoSize = true;
            this.labelAdminFullName.Location = new System.Drawing.Point(12, 95);
            this.labelAdminFullName.Name = "labelAdminFullName";
            this.labelAdminFullName.Size = new System.Drawing.Size(79, 20);
            this.labelAdminFullName.TabIndex = 0;
            this.labelAdminFullName.Text = "Full Name:";
            // 
            // labelAdminUsername
            // 
            this.labelAdminUsername.AutoSize = true;
            this.labelAdminUsername.Location = new System.Drawing.Point(13, 170);
            this.labelAdminUsername.Name = "labelAdminUsername";
            this.labelAdminUsername.Size = new System.Drawing.Size(78, 20);
            this.labelAdminUsername.TabIndex = 0;
            this.labelAdminUsername.Text = "Username:";
            // 
            // labelAdminPassword
            // 
            this.labelAdminPassword.AutoSize = true;
            this.labelAdminPassword.Location = new System.Drawing.Point(18, 267);
            this.labelAdminPassword.Name = "labelAdminPassword";
            this.labelAdminPassword.Size = new System.Drawing.Size(73, 20);
            this.labelAdminPassword.TabIndex = 0;
            this.labelAdminPassword.Text = "Password:";
            // 
            // textBoxAdminName
            // 
            this.textBoxAdminName.Location = new System.Drawing.Point(12, 122);
            this.textBoxAdminName.Name = "textBoxAdminName";
            this.textBoxAdminName.Size = new System.Drawing.Size(407, 27);
            this.textBoxAdminName.TabIndex = 0;
            // 
            // textBoxAdminUsername
            // 
            this.textBoxAdminUsername.Location = new System.Drawing.Point(12, 208);
            this.textBoxAdminUsername.Name = "textBoxAdminUsername";
            this.textBoxAdminUsername.Size = new System.Drawing.Size(407, 27);
            this.textBoxAdminUsername.TabIndex = 2;
            // 
            // textBoxAdminPassword
            // 
            this.textBoxAdminPassword.Location = new System.Drawing.Point(13, 300);
            this.textBoxAdminPassword.Name = "textBoxAdminPassword";
            this.textBoxAdminPassword.Size = new System.Drawing.Size(407, 27);
            this.textBoxAdminPassword.TabIndex = 3;
            // 
            // buttonAdminRegister
            // 
            this.buttonAdminRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.buttonAdminRegister.FlatAppearance.BorderSize = 0;
            this.buttonAdminRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdminRegister.ForeColor = System.Drawing.Color.White;
            this.buttonAdminRegister.Location = new System.Drawing.Point(107, 379);
            this.buttonAdminRegister.Name = "buttonAdminRegister";
            this.buttonAdminRegister.Size = new System.Drawing.Size(172, 47);
            this.buttonAdminRegister.TabIndex = 4;
            this.buttonAdminRegister.Text = "Register";
            this.buttonAdminRegister.UseVisualStyleBackColor = false;
            this.buttonAdminRegister.Click += new System.EventHandler(this.buttonAdminRegister_Click);
            // 
            // panelAdminRegistr
            // 
            this.panelAdminRegistr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(139)))));
            this.panelAdminRegistr.Controls.Add(this.buttonCloseAdminForm);
            this.panelAdminRegistr.Controls.Add(this.labelAdminTitle);
            this.panelAdminRegistr.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdminRegistr.Location = new System.Drawing.Point(0, 0);
            this.panelAdminRegistr.Name = "panelAdminRegistr";
            this.panelAdminRegistr.Size = new System.Drawing.Size(487, 83);
            this.panelAdminRegistr.TabIndex = 3;
            this.panelAdminRegistr.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAdminRegistr_Paint);
            // 
            // buttonCloseAdminForm
            // 
            this.buttonCloseAdminForm.FlatAppearance.BorderSize = 0;
            this.buttonCloseAdminForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseAdminForm.Image = ((System.Drawing.Image)(resources.GetObject("buttonCloseAdminForm.Image")));
            this.buttonCloseAdminForm.Location = new System.Drawing.Point(421, 23);
            this.buttonCloseAdminForm.Name = "buttonCloseAdminForm";
            this.buttonCloseAdminForm.Size = new System.Drawing.Size(54, 46);
            this.buttonCloseAdminForm.TabIndex = 5;
            this.buttonCloseAdminForm.UseVisualStyleBackColor = true;
            this.buttonCloseAdminForm.Click += new System.EventHandler(this.buttonCloseAdminForm_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 523);
            this.Controls.Add(this.buttonAdminRegister);
            this.Controls.Add(this.textBoxAdminPassword);
            this.Controls.Add(this.textBoxAdminUsername);
            this.Controls.Add(this.textBoxAdminName);
            this.Controls.Add(this.labelAdminPassword);
            this.Controls.Add(this.labelAdminUsername);
            this.Controls.Add(this.labelAdminFullName);
            this.Controls.Add(this.panelAdminRegistr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(505, 570);
            this.MinimumSize = new System.Drawing.Size(505, 570);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panelAdminRegistr.ResumeLayout(false);
            this.panelAdminRegistr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdminTitle;
        private System.Windows.Forms.Label labelAdminFullName;
        private System.Windows.Forms.Label labelAdminUsername;
        private System.Windows.Forms.Label labelAdminPassword;
        private System.Windows.Forms.TextBox textBoxAdminName;
        private System.Windows.Forms.TextBox textBoxAdminUsername;
        private System.Windows.Forms.TextBox textBoxAdminPassword;
        private System.Windows.Forms.Button buttonAdminRegister;
        private System.Windows.Forms.Panel panelAdminRegistr;
        private System.Windows.Forms.Button buttonCloseAdminForm;
    }
}