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
            this.dataGridReports = new System.Windows.Forms.DataGridView();
            this.panelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReports)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(139)))));
            this.panelAdmin.Controls.Add(this.labelAdminTitle);
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(579, 135);
            this.panelAdmin.TabIndex = 0;
            this.panelAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAdmin_Paint);
            // 
            // labelAdminTitle
            // 
            this.labelAdminTitle.AutoSize = true;
            this.labelAdminTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdminTitle.ForeColor = System.Drawing.Color.White;
            this.labelAdminTitle.Location = new System.Drawing.Point(11, 43);
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
            this.buttonCampaignsAdmin.Location = new System.Drawing.Point(11, 251);
            this.buttonCampaignsAdmin.Name = "buttonCampaignsAdmin";
            this.buttonCampaignsAdmin.Size = new System.Drawing.Size(171, 47);
            this.buttonCampaignsAdmin.TabIndex = 0;
            this.buttonCampaignsAdmin.Text = "Campaigns";
            this.buttonCampaignsAdmin.UseVisualStyleBackColor = false;
            this.buttonCampaignsAdmin.Click += new System.EventHandler(this.buttonCampaignsAdmin_Click);
            // 
            // buttonUsersAdmin
            // 
            this.buttonUsersAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.buttonUsersAdmin.FlatAppearance.BorderSize = 0;
            this.buttonUsersAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsersAdmin.ForeColor = System.Drawing.Color.White;
            this.buttonUsersAdmin.Location = new System.Drawing.Point(203, 251);
            this.buttonUsersAdmin.Name = "buttonUsersAdmin";
            this.buttonUsersAdmin.Size = new System.Drawing.Size(171, 47);
            this.buttonUsersAdmin.TabIndex = 0;
            this.buttonUsersAdmin.Text = "Users";
            this.buttonUsersAdmin.UseVisualStyleBackColor = false;
            this.buttonUsersAdmin.Click += new System.EventHandler(this.buttonUsersAdmin_Click);
            // 
            // buttonTweetsAdmin
            // 
            this.buttonTweetsAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.buttonTweetsAdmin.FlatAppearance.BorderSize = 0;
            this.buttonTweetsAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTweetsAdmin.ForeColor = System.Drawing.Color.White;
            this.buttonTweetsAdmin.Location = new System.Drawing.Point(398, 251);
            this.buttonTweetsAdmin.Name = "buttonTweetsAdmin";
            this.buttonTweetsAdmin.Size = new System.Drawing.Size(171, 47);
            this.buttonTweetsAdmin.TabIndex = 0;
            this.buttonTweetsAdmin.Text = "Tweets";
            this.buttonTweetsAdmin.UseVisualStyleBackColor = false;
            this.buttonTweetsAdmin.Click += new System.EventHandler(this.buttonTweetsAdmin_Click);
            // 
            // labelReports
            // 
            this.labelReports.AutoSize = true;
            this.labelReports.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelReports.Location = new System.Drawing.Point(11, 192);
            this.labelReports.Name = "labelReports";
            this.labelReports.Size = new System.Drawing.Size(97, 31);
            this.labelReports.TabIndex = 0;
            this.labelReports.Text = "Reports:";
            // 
            // dataGridReports
            // 
            this.dataGridReports.AllowUserToAddRows = false;
            this.dataGridReports.AllowUserToDeleteRows = false;
            this.dataGridReports.AllowUserToResizeColumns = false;
            this.dataGridReports.AllowUserToResizeRows = false;
            this.dataGridReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridReports.BackgroundColor = System.Drawing.Color.White;
            this.dataGridReports.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReports.GridColor = System.Drawing.Color.White;
            this.dataGridReports.Location = new System.Drawing.Point(11, 320);
            this.dataGridReports.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridReports.MultiSelect = false;
            this.dataGridReports.Name = "dataGridReports";
            this.dataGridReports.ReadOnly = true;
            this.dataGridReports.RowHeadersVisible = false;
            this.dataGridReports.RowHeadersWidth = 51;
            this.dataGridReports.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridReports.RowTemplate.Height = 25;
            this.dataGridReports.ShowEditingIcon = false;
            this.dataGridReports.Size = new System.Drawing.Size(557, 305);
            this.dataGridReports.TabIndex = 0;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 637);
            this.Controls.Add(this.dataGridReports);
            this.Controls.Add(this.labelReports);
            this.Controls.Add(this.buttonTweetsAdmin);
            this.Controls.Add(this.buttonUsersAdmin);
            this.Controls.Add(this.buttonCampaignsAdmin);
            this.Controls.Add(this.panelAdmin);
            this.MaximumSize = new System.Drawing.Size(597, 684);
            this.MinimumSize = new System.Drawing.Size(597, 684);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReports)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridReports;
    }
}