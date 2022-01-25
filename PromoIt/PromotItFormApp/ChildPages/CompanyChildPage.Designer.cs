namespace PromotItFormApp.ChildPages
{
    partial class CompanyChildPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyChildPage));
            this.panelCompanyAbout = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelServiceTextComp = new System.Windows.Forms.Label();
            this.labelServiceComp = new System.Windows.Forms.Label();
            this.buttonPreviousCompany = new System.Windows.Forms.Button();
            this.panelCompanyAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCompanyAbout
            // 
            this.panelCompanyAbout.BackColor = System.Drawing.Color.White;
            this.panelCompanyAbout.Controls.Add(this.label1);
            this.panelCompanyAbout.Controls.Add(this.labelServiceTextComp);
            this.panelCompanyAbout.Controls.Add(this.labelServiceComp);
            this.panelCompanyAbout.Controls.Add(this.buttonPreviousCompany);
            this.panelCompanyAbout.Location = new System.Drawing.Point(-2, 0);
            this.panelCompanyAbout.Name = "panelCompanyAbout";
            this.panelCompanyAbout.Size = new System.Drawing.Size(863, 461);
            this.panelCompanyAbout.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conditions should be fully achieved before a deposit takes place in the user\'s ba" +
    "lance.\r\n\r\n (Read the previous page)";
            // 
            // labelServiceTextComp
            // 
            this.labelServiceTextComp.AutoSize = true;
            this.labelServiceTextComp.Location = new System.Drawing.Point(14, 52);
            this.labelServiceTextComp.Name = "labelServiceTextComp";
            this.labelServiceTextComp.Size = new System.Drawing.Size(813, 120);
            this.labelServiceTextComp.TabIndex = 0;
            this.labelServiceTextComp.Text = resources.GetString("labelServiceTextComp.Text");
            // 
            // labelServiceComp
            // 
            this.labelServiceComp.AutoSize = true;
            this.labelServiceComp.BackColor = System.Drawing.Color.Transparent;
            this.labelServiceComp.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelServiceComp.ForeColor = System.Drawing.Color.White;
            this.labelServiceComp.Location = new System.Drawing.Point(11, 10);
            this.labelServiceComp.Name = "labelServiceComp";
            this.labelServiceComp.Size = new System.Drawing.Size(117, 31);
            this.labelServiceComp.TabIndex = 0;
            this.labelServiceComp.Text = "IS IT FREE?";
            // 
            // buttonPreviousCompany
            // 
            this.buttonPreviousCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.buttonPreviousCompany.FlatAppearance.BorderSize = 0;
            this.buttonPreviousCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreviousCompany.ForeColor = System.Drawing.Color.White;
            this.buttonPreviousCompany.Location = new System.Drawing.Point(14, 403);
            this.buttonPreviousCompany.Name = "buttonPreviousCompany";
            this.buttonPreviousCompany.Size = new System.Drawing.Size(151, 35);
            this.buttonPreviousCompany.TabIndex = 0;
            this.buttonPreviousCompany.Text = "Previous";
            this.buttonPreviousCompany.UseVisualStyleBackColor = false;
            this.buttonPreviousCompany.Click += new System.EventHandler(this.buttonPreviousCompany_Click);
            // 
            // CompanyChildPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.panelCompanyAbout);
            this.MaximumSize = new System.Drawing.Size(872, 497);
            this.MinimumSize = new System.Drawing.Size(872, 497);
            this.Name = "CompanyChildPage";
            this.Text = "CompanyChildPage";
            this.Load += new System.EventHandler(this.CompanyChildPage_Load);
            this.panelCompanyAbout.ResumeLayout(false);
            this.panelCompanyAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCompanyAbout;
        private System.Windows.Forms.Button buttonPreviousCompany;
        private System.Windows.Forms.Label labelServiceTextComp;
        private System.Windows.Forms.Label labelServiceComp;
        private System.Windows.Forms.Label label1;
    }
}