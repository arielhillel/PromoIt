namespace PromotItFormApp.LandingPages
{
    partial class AdminPanel
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
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.labelAdminTitle = new System.Windows.Forms.Label();
            this.buttonCampaignsAdmin = new System.Windows.Forms.Button();
            this.buttonUsersAdmin = new System.Windows.Forms.Button();
            this.buttonTweetsAdmin = new System.Windows.Forms.Button();
            this.labelReports = new System.Windows.Forms.Label();
            this.panelAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(139)))));
            this.panelAdmin.Controls.Add(this.labelAdminTitle);
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(580, 135);
            this.panelAdmin.TabIndex = 0;
            this.panelAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAdmin_Paint);
            // 
            // labelAdminTitle
            // 
            this.labelAdminTitle.AutoSize = true;
            this.labelAdminTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdminTitle.ForeColor = System.Drawing.Color.White;
            this.labelAdminTitle.Location = new System.Drawing.Point(12, 65);
            this.labelAdminTitle.Name = "labelAdminTitle";
            this.labelAdminTitle.Size = new System.Drawing.Size(159, 28);
            this.labelAdminTitle.TabIndex = 0;
            this.labelAdminTitle.Text = "ProLobby Owner";
            // 
            // buttonCampaignsAdmin
            // 
            this.buttonCampaignsAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.buttonCampaignsAdmin.FlatAppearance.BorderSize = 0;
            this.buttonCampaignsAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCampaignsAdmin.ForeColor = System.Drawing.Color.White;
            this.buttonCampaignsAdmin.Location = new System.Drawing.Point(12, 251);
            this.buttonCampaignsAdmin.Name = "buttonCampaignsAdmin";
            this.buttonCampaignsAdmin.Size = new System.Drawing.Size(172, 47);
            this.buttonCampaignsAdmin.TabIndex = 0;
            this.buttonCampaignsAdmin.Text = "Campaigns";
            this.buttonCampaignsAdmin.UseVisualStyleBackColor = false;
            // 
            // buttonUsersAdmin
            // 
            this.buttonUsersAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.buttonUsersAdmin.FlatAppearance.BorderSize = 0;
            this.buttonUsersAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsersAdmin.ForeColor = System.Drawing.Color.White;
            this.buttonUsersAdmin.Location = new System.Drawing.Point(204, 251);
            this.buttonUsersAdmin.Name = "buttonUsersAdmin";
            this.buttonUsersAdmin.Size = new System.Drawing.Size(172, 47);
            this.buttonUsersAdmin.TabIndex = 0;
            this.buttonUsersAdmin.Text = "Users";
            this.buttonUsersAdmin.UseVisualStyleBackColor = false;
            // 
            // buttonTweetsAdmin
            // 
            this.buttonTweetsAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.buttonTweetsAdmin.FlatAppearance.BorderSize = 0;
            this.buttonTweetsAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTweetsAdmin.ForeColor = System.Drawing.Color.White;
            this.buttonTweetsAdmin.Location = new System.Drawing.Point(398, 251);
            this.buttonTweetsAdmin.Name = "buttonTweetsAdmin";
            this.buttonTweetsAdmin.Size = new System.Drawing.Size(172, 47);
            this.buttonTweetsAdmin.TabIndex = 0;
            this.buttonTweetsAdmin.Text = "Tweets";
            this.buttonTweetsAdmin.UseVisualStyleBackColor = false;
            // 
            // labelReports
            // 
            this.labelReports.AutoSize = true;
            this.labelReports.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelReports.Location = new System.Drawing.Point(12, 192);
            this.labelReports.Name = "labelReports";
            this.labelReports.Size = new System.Drawing.Size(97, 31);
            this.labelReports.TabIndex = 0;
            this.labelReports.Text = "Reports:";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 345);
            this.Controls.Add(this.labelReports);
            this.Controls.Add(this.buttonTweetsAdmin);
            this.Controls.Add(this.buttonUsersAdmin);
            this.Controls.Add(this.buttonCampaignsAdmin);
            this.Controls.Add(this.panelAdmin);
            this.MaximumSize = new System.Drawing.Size(598, 392);
            this.MinimumSize = new System.Drawing.Size(598, 392);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Label labelAdminTitle;
        private System.Windows.Forms.Button buttonCampaignsAdmin;
        private System.Windows.Forms.Button buttonUsersAdmin;
        private System.Windows.Forms.Button buttonTweetsAdmin;
        private System.Windows.Forms.Label labelReports;
    }
}