﻿namespace PromotItFormApp.ChildPages
{
    partial class MenuHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuHomePage));
            this.buttonGitHub = new System.Windows.Forms.Button();
            this.labelHomeDesc = new System.Windows.Forms.Label();
            this.labelHomeInfo = new System.Windows.Forms.Label();
            this.panelZionetPage = new System.Windows.Forms.Panel();
            this.panelZionetPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGitHub
            // 
            this.buttonGitHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.buttonGitHub.FlatAppearance.BorderSize = 0;
            this.buttonGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGitHub.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGitHub.Image = ((System.Drawing.Image)(resources.GetObject("buttonGitHub.Image")));
            this.buttonGitHub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGitHub.Location = new System.Drawing.Point(341, 121);
            this.buttonGitHub.Name = "buttonGitHub";
            this.buttonGitHub.Size = new System.Drawing.Size(173, 43);
            this.buttonGitHub.TabIndex = 0;
            this.buttonGitHub.Text = "GitHub";
            this.buttonGitHub.UseVisualStyleBackColor = false;
            this.buttonGitHub.Click += new System.EventHandler(this.buttonGitHub_Click);
            // 
            // labelHomeDesc
            // 
            this.labelHomeDesc.AutoSize = true;
            this.labelHomeDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelHomeDesc.ForeColor = System.Drawing.Color.White;
            this.labelHomeDesc.Location = new System.Drawing.Point(308, 39);
            this.labelHomeDesc.Name = "labelHomeDesc";
            this.labelHomeDesc.Size = new System.Drawing.Size(220, 28);
            this.labelHomeDesc.TabIndex = 0;
            this.labelHomeDesc.Text = "ZioNet Semester Project";
            // 
            // labelHomeInfo
            // 
            this.labelHomeInfo.AutoSize = true;
            this.labelHomeInfo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelHomeInfo.ForeColor = System.Drawing.Color.White;
            this.labelHomeInfo.Location = new System.Drawing.Point(258, 80);
            this.labelHomeInfo.Name = "labelHomeInfo";
            this.labelHomeInfo.Size = new System.Drawing.Size(341, 23);
            this.labelHomeInfo.TabIndex = 2;
            this.labelHomeInfo.Text = "Ariel Hillel, Yaron Malul and Arthur Zarankin.";
            // 
            // panelZionetPage
            // 
            this.panelZionetPage.BackColor = System.Drawing.Color.White;
            this.panelZionetPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelZionetPage.BackgroundImage")));
            this.panelZionetPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelZionetPage.Controls.Add(this.labelHomeInfo);
            this.panelZionetPage.Controls.Add(this.labelHomeDesc);
            this.panelZionetPage.Controls.Add(this.buttonGitHub);
            this.panelZionetPage.Location = new System.Drawing.Point(-1, -6);
            this.panelZionetPage.Name = "panelZionetPage";
            this.panelZionetPage.Size = new System.Drawing.Size(865, 465);
            this.panelZionetPage.TabIndex = 0;
            // 
            // MenuHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.panelZionetPage);
            this.MaximumSize = new System.Drawing.Size(872, 497);
            this.MinimumSize = new System.Drawing.Size(872, 497);
            this.Name = "MenuHomePage";
            this.Text = "ZioNet";
            this.Load += new System.EventHandler(this.MenuHomePage_Load);
            this.panelZionetPage.ResumeLayout(false);
            this.panelZionetPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGitHub;
        private System.Windows.Forms.Label labelHomeDesc;
        private System.Windows.Forms.Label labelHomeInfo;
        private System.Windows.Forms.Panel panelZionetPage;
    }
}