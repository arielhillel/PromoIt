namespace PromotItFormApp.PopupForms
{
    partial class Login
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLoginForm = new System.Windows.Forms.Button();
            this.panelLoginForm = new System.Windows.Forms.Panel();
            this.labelLoginForm = new System.Windows.Forms.Label();
            this.panelLoginForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(97, 220);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(78, 20);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(102, 270);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(73, 20);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(183, 213);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(125, 27);
            this.textBoxUsername.TabIndex = 0;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(183, 263);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(125, 27);
            this.textBoxPassword.TabIndex = 0;
            // 
            // buttonLoginForm
            // 
            this.buttonLoginForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.buttonLoginForm.FlatAppearance.BorderSize = 0;
            this.buttonLoginForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoginForm.ForeColor = System.Drawing.Color.White;
            this.buttonLoginForm.Location = new System.Drawing.Point(158, 411);
            this.buttonLoginForm.Name = "buttonLoginForm";
            this.buttonLoginForm.Size = new System.Drawing.Size(172, 47);
            this.buttonLoginForm.TabIndex = 7;
            this.buttonLoginForm.Text = "Login";
            this.buttonLoginForm.UseVisualStyleBackColor = false;
            this.buttonLoginForm.Click += new System.EventHandler(this.buttonLoginForm_Click);
            // 
            // panelLoginForm
            // 
            this.panelLoginForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(139)))));
            this.panelLoginForm.Controls.Add(this.labelLoginForm);
            this.panelLoginForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLoginForm.Location = new System.Drawing.Point(0, 0);
            this.panelLoginForm.Name = "panelLoginForm";
            this.panelLoginForm.Size = new System.Drawing.Size(487, 99);
            this.panelLoginForm.TabIndex = 0;
            this.panelLoginForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLoginForm_Paint);
            // 
            // labelLoginForm
            // 
            this.labelLoginForm.AutoSize = true;
            this.labelLoginForm.BackColor = System.Drawing.Color.Transparent;
            this.labelLoginForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLoginForm.ForeColor = System.Drawing.Color.White;
            this.labelLoginForm.Location = new System.Drawing.Point(97, 34);
            this.labelLoginForm.Name = "labelLoginForm";
            this.labelLoginForm.Size = new System.Drawing.Size(275, 28);
            this.labelLoginForm.TabIndex = 0;
            this.labelLoginForm.Text = "Insert username and password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 523);
            this.Controls.Add(this.panelLoginForm);
            this.Controls.Add(this.buttonLoginForm);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.MaximumSize = new System.Drawing.Size(505, 570);
            this.MinimumSize = new System.Drawing.Size(505, 570);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PromoteIt - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panelLoginForm.ResumeLayout(false);
            this.panelLoginForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLoginForm;
        private System.Windows.Forms.Panel panelLoginForm;
        private System.Windows.Forms.Label labelLoginForm;
    }
}