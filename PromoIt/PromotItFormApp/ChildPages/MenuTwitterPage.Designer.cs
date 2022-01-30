namespace PromotItFormApp.ChildPages
{
    partial class MenuTwitterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuTwitterPage));
            this.pnlPannelGlobal = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.lblTopTwitter = new System.Windows.Forms.Label();
            this.btnTwitterLink = new System.Windows.Forms.Button();
            this.pnlPannelGlobal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPannelGlobal
            // 
            this.pnlPannelGlobal.BackColor = System.Drawing.Color.White;
            this.pnlPannelGlobal.Controls.Add(this.lblTop);
            this.pnlPannelGlobal.Controls.Add(this.lblTopTwitter);
            this.pnlPannelGlobal.Controls.Add(this.btnTwitterLink);
            this.pnlPannelGlobal.ForeColor = System.Drawing.Color.Transparent;
            this.pnlPannelGlobal.Location = new System.Drawing.Point(0, 0);
            this.pnlPannelGlobal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPannelGlobal.Name = "pnlPannelGlobal";
            this.pnlPannelGlobal.Size = new System.Drawing.Size(753, 346);
            this.pnlPannelGlobal.TabIndex = 2;
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.BackColor = System.Drawing.Color.White;
            this.lblTop.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTop.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTop.Location = new System.Drawing.Point(203, 159);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(416, 25);
            this.lblTop.TabIndex = 4;
            this.lblTop.Text = "This is our official Twitter\'s profile, stay updated!";
            // 
            // lblTopTwitter
            // 
            this.lblTopTwitter.AutoSize = true;
            this.lblTopTwitter.BackColor = System.Drawing.Color.White;
            this.lblTopTwitter.Font = new System.Drawing.Font("Sitka Subheading", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTopTwitter.ForeColor = System.Drawing.Color.Black;
            this.lblTopTwitter.Location = new System.Drawing.Point(111, 100);
            this.lblTopTwitter.Name = "lblTopTwitter";
            this.lblTopTwitter.Size = new System.Drawing.Size(520, 68);
            this.lblTopTwitter.TabIndex = 3;
            this.lblTopTwitter.Text = "Promoit twitter account";
            // 
            // btnTwitterLink
            // 
            this.btnTwitterLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.btnTwitterLink.FlatAppearance.BorderSize = 0;
            this.btnTwitterLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwitterLink.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTwitterLink.Image = ((System.Drawing.Image)(resources.GetObject("btnTwitterLink.Image")));
            this.btnTwitterLink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTwitterLink.Location = new System.Drawing.Point(299, 204);
            this.btnTwitterLink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTwitterLink.Name = "btnTwitterLink";
            this.btnTwitterLink.Size = new System.Drawing.Size(151, 32);
            this.btnTwitterLink.TabIndex = 0;
            this.btnTwitterLink.Text = "Twitter";
            this.btnTwitterLink.UseVisualStyleBackColor = false;
            this.btnTwitterLink.Click += new System.EventHandler(this.buttonTwitter_Click);
            // 
            // MenuTwitterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 344);
            this.Controls.Add(this.pnlPannelGlobal);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(765, 383);
            this.MinimumSize = new System.Drawing.Size(765, 383);
            this.Name = "MenuTwitterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROMOIT - TWITTER PAGE";
            this.Load += new System.EventHandler(this.MenuTwitterPage_Load);
            this.pnlPannelGlobal.ResumeLayout(false);
            this.pnlPannelGlobal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlPannelGlobal;
        private System.Windows.Forms.Button btnTwitterLink;
        private System.Windows.Forms.Label lblTopTwitter;
        private System.Windows.Forms.Label lblTop;
    }
}