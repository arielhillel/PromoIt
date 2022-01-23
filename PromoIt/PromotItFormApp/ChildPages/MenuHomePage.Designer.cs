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
            this.buttonHomePage = new System.Windows.Forms.Button();
            this.labelHomeDesc = new System.Windows.Forms.Label();
            this.labelHomeInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonHomePage
            // 
            this.buttonHomePage.Location = new System.Drawing.Point(12, 73);
            this.buttonHomePage.Name = "buttonHomePage";
            this.buttonHomePage.Size = new System.Drawing.Size(94, 29);
            this.buttonHomePage.TabIndex = 0;
            this.buttonHomePage.Text = "TEST";
            this.buttonHomePage.UseVisualStyleBackColor = true;
            // 
            // labelHomeDesc
            // 
            this.labelHomeDesc.AutoSize = true;
            this.labelHomeDesc.Location = new System.Drawing.Point(12, 9);
            this.labelHomeDesc.Name = "labelHomeDesc";
            this.labelHomeDesc.Size = new System.Drawing.Size(85, 20);
            this.labelHomeDesc.TabIndex = 0;
            this.labelHomeDesc.Text = "Description";
            // 
            // labelHomeInfo
            // 
            this.labelHomeInfo.AutoSize = true;
            this.labelHomeInfo.Location = new System.Drawing.Point(12, 39);
            this.labelHomeInfo.Name = "labelHomeInfo";
            this.labelHomeInfo.Size = new System.Drawing.Size(87, 20);
            this.labelHomeInfo.TabIndex = 2;
            this.labelHomeInfo.Text = "Information";
            // 
            // MenuHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 564);
            this.Controls.Add(this.labelHomeInfo);
            this.Controls.Add(this.labelHomeDesc);
            this.Controls.Add(this.buttonHomePage);
            this.Name = "MenuHomePage";
            this.Text = "MenuHomePage";
            this.Load += new System.EventHandler(this.MenuHomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHomePage;
        private System.Windows.Forms.Label labelHomeDesc;
        private System.Windows.Forms.Label labelHomeInfo;
    }
}