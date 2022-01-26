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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonTwitter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(205, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "This is our official Twitter\'s profile, stay updated!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonTwitter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 461);
            this.panel1.TabIndex = 2;
            // 
            // buttonTwitter
            // 
            this.buttonTwitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.buttonTwitter.FlatAppearance.BorderSize = 0;
            this.buttonTwitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTwitter.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonTwitter.Image = ((System.Drawing.Image)(resources.GetObject("buttonTwitter.Image")));
            this.buttonTwitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTwitter.Location = new System.Drawing.Point(342, 91);
            this.buttonTwitter.Name = "buttonTwitter";
            this.buttonTwitter.Size = new System.Drawing.Size(173, 43);
            this.buttonTwitter.TabIndex = 0;
            this.buttonTwitter.Text = "Twitter";
            this.buttonTwitter.UseVisualStyleBackColor = false;
            this.buttonTwitter.Click += new System.EventHandler(this.buttonTwitter_Click);
            // 
            // MenuTwitterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(872, 497);
            this.MinimumSize = new System.Drawing.Size(872, 497);
            this.Name = "MenuTwitterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Twitter Page";
            this.Load += new System.EventHandler(this.MenuTwitterPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonTwitter;
    }
}