namespace PromotItFormApp.ChildPages
{
    partial class MenuAboutPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAboutPage));
            this.buttonAboutNext = new System.Windows.Forms.Button();
            this.labelAboutUs = new System.Windows.Forms.Label();
            this.labelAboutCoop = new System.Windows.Forms.Label();
            this.labelUsDesc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDetails = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAboutNext
            // 
            this.buttonAboutNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.buttonAboutNext.FlatAppearance.BorderSize = 0;
            this.buttonAboutNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAboutNext.ForeColor = System.Drawing.Color.White;
            this.buttonAboutNext.Location = new System.Drawing.Point(691, 403);
            this.buttonAboutNext.Name = "buttonAboutNext";
            this.buttonAboutNext.Size = new System.Drawing.Size(151, 35);
            this.buttonAboutNext.TabIndex = 0;
            this.buttonAboutNext.Text = "Next";
            this.buttonAboutNext.UseVisualStyleBackColor = false;
            this.buttonAboutNext.Click += new System.EventHandler(this.buttonAboutNext_Click);
            // 
            // labelAboutUs
            // 
            this.labelAboutUs.AutoSize = true;
            this.labelAboutUs.BackColor = System.Drawing.Color.Transparent;
            this.labelAboutUs.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelAboutUs.ForeColor = System.Drawing.Color.White;
            this.labelAboutUs.Location = new System.Drawing.Point(12, 9);
            this.labelAboutUs.Name = "labelAboutUs";
            this.labelAboutUs.Size = new System.Drawing.Size(46, 31);
            this.labelAboutUs.TabIndex = 0;
            this.labelAboutUs.Text = "US:";
            // 
            // labelAboutCoop
            // 
            this.labelAboutCoop.AutoSize = true;
            this.labelAboutCoop.BackColor = System.Drawing.Color.Transparent;
            this.labelAboutCoop.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelAboutCoop.ForeColor = System.Drawing.Color.White;
            this.labelAboutCoop.Location = new System.Drawing.Point(12, 225);
            this.labelAboutCoop.Name = "labelAboutCoop";
            this.labelAboutCoop.Size = new System.Drawing.Size(172, 31);
            this.labelAboutCoop.TabIndex = 0;
            this.labelAboutCoop.Text = "COOPERATION:";
            // 
            // labelUsDesc
            // 
            this.labelUsDesc.AutoSize = true;
            this.labelUsDesc.Location = new System.Drawing.Point(12, 49);
            this.labelUsDesc.Name = "labelUsDesc";
            this.labelUsDesc.Size = new System.Drawing.Size(842, 140);
            this.labelUsDesc.TabIndex = 0;
            this.labelUsDesc.Text = resources.GetString("labelUsDesc.Text");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelDetails);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelUsDesc);
            this.panel1.Controls.Add(this.labelAboutCoop);
            this.panel1.Controls.Add(this.labelAboutUs);
            this.panel1.Controls.Add(this.buttonAboutNext);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 460);
            this.panel1.TabIndex = 1;
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDetails.Location = new System.Drawing.Point(12, 315);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(218, 20);
            this.labelDetails.TabIndex = 0;
            this.labelDetails.Text = "(Full details in the next page!)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(831, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "In full cooperation with known business companies, which they donate products to " +
    "support and giving voice to their idelogy \r\nand mutual agenda.";
            // 
            // MenuAboutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(872, 497);
            this.MinimumSize = new System.Drawing.Size(872, 497);
            this.Name = "MenuAboutPage";
            this.Text = "About Promoit";
            this.Load += new System.EventHandler(this.MenuAboutPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAboutNext;
        private System.Windows.Forms.Label labelAboutUs;
        private System.Windows.Forms.Label labelAboutCoop;
        private System.Windows.Forms.Label labelUsDesc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Label label1;
    }
}