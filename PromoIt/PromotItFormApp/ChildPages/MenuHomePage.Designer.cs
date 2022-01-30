namespace PromotItFormApp.ChildPages
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
            this.btnGitHub = new System.Windows.Forms.Button();
            this.labelHomeDesc = new System.Windows.Forms.Label();
            this.labelHomeInfo = new System.Windows.Forms.Label();
            this.pnlPanelGlobal = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlPanelGlobal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGitHub
            // 
            this.btnGitHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.btnGitHub.FlatAppearance.BorderSize = 0;
            this.btnGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGitHub.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGitHub.Image = ((System.Drawing.Image)(resources.GetObject("btnGitHub.Image")));
            this.btnGitHub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGitHub.Location = new System.Drawing.Point(314, 213);
            this.btnGitHub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGitHub.Name = "btnGitHub";
            this.btnGitHub.Size = new System.Drawing.Size(151, 32);
            this.btnGitHub.TabIndex = 0;
            this.btnGitHub.Text = "GitHub";
            this.btnGitHub.UseVisualStyleBackColor = false;
            this.btnGitHub.Click += new System.EventHandler(this.buttonGitHub_Click);
            // 
            // labelHomeDesc
            // 
            this.labelHomeDesc.AutoSize = true;
            this.labelHomeDesc.Font = new System.Drawing.Font("Sitka Subheading", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHomeDesc.ForeColor = System.Drawing.Color.Black;
            this.labelHomeDesc.Location = new System.Drawing.Point(259, 102);
            this.labelHomeDesc.Name = "labelHomeDesc";
            this.labelHomeDesc.Size = new System.Drawing.Size(375, 68);
            this.labelHomeDesc.TabIndex = 0;
            this.labelHomeDesc.Text = "Semester Project";
            this.labelHomeDesc.Click += new System.EventHandler(this.labelHomeDesc_Click);
            // 
            // labelHomeInfo
            // 
            this.labelHomeInfo.AutoSize = true;
            this.labelHomeInfo.BackColor = System.Drawing.Color.White;
            this.labelHomeInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHomeInfo.ForeColor = System.Drawing.Color.DarkGray;
            this.labelHomeInfo.Location = new System.Drawing.Point(235, 165);
            this.labelHomeInfo.Name = "labelHomeInfo";
            this.labelHomeInfo.Size = new System.Drawing.Size(388, 25);
            this.labelHomeInfo.TabIndex = 2;
            this.labelHomeInfo.Text = "Ariel Hillel, Yaron Malul and Arthur Zarankin.";
            // 
            // pnlPanelGlobal
            // 
            this.pnlPanelGlobal.BackColor = System.Drawing.Color.White;
            this.pnlPanelGlobal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlPanelGlobal.Controls.Add(this.pictureBox1);
            this.pnlPanelGlobal.Controls.Add(this.labelHomeInfo);
            this.pnlPanelGlobal.Controls.Add(this.labelHomeDesc);
            this.pnlPanelGlobal.Controls.Add(this.btnGitHub);
            this.pnlPanelGlobal.Location = new System.Drawing.Point(-1, -4);
            this.pnlPanelGlobal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPanelGlobal.Name = "pnlPanelGlobal";
            this.pnlPanelGlobal.Size = new System.Drawing.Size(757, 349);
            this.pnlPanelGlobal.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(124, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MenuHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 344);
            this.Controls.Add(this.pnlPanelGlobal);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(765, 383);
            this.MinimumSize = new System.Drawing.Size(765, 383);
            this.Name = "MenuHomePage";
            this.Text = "PROMOIT - ZIONET";
            this.Load += new System.EventHandler(this.MenuHomePage_Load);
            this.pnlPanelGlobal.ResumeLayout(false);
            this.pnlPanelGlobal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGitHub;
        private System.Windows.Forms.Label labelHomeDesc;
        private System.Windows.Forms.Label labelHomeInfo;
        private System.Windows.Forms.Panel pnlPanelGlobal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}