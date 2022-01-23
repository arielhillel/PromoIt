namespace PromotItFormApp.LandingPages
{
    partial class SocialActivistPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SocialActivistPanel));
            this.panelSADashboard = new System.Windows.Forms.Panel();
            this.dataGridSA = new System.Windows.Forms.DataGridView();
            this.clmnHashtag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnWebpage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonProductListGrid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridNPO = new System.Windows.Forms.DataGridView();
            this.textBoxSearchSA = new System.Windows.Forms.TextBox();
            this.pictureBoxSearchSA = new System.Windows.Forms.PictureBox();
            this.panelSA = new System.Windows.Forms.Panel();
            this.labelSATitle = new System.Windows.Forms.Label();
            this.panelBalance = new System.Windows.Forms.Panel();
            this.labelSACurrency = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.panelMessagesSA = new System.Windows.Forms.Panel();
            this.dataGridMessages = new System.Windows.Forms.DataGridView();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panelSADashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchSA)).BeginInit();
            this.panelSA.SuspendLayout();
            this.panelBalance.SuspendLayout();
            this.panelMessagesSA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSADashboard
            // 
            this.panelSADashboard.BackColor = System.Drawing.Color.White;
            this.panelSADashboard.Controls.Add(this.dataGridSA);
            this.panelSADashboard.Controls.Add(this.dataGridNPO);
            this.panelSADashboard.Controls.Add(this.textBoxSearchSA);
            this.panelSADashboard.Controls.Add(this.pictureBoxSearchSA);
            this.panelSADashboard.Location = new System.Drawing.Point(20, 283);
            this.panelSADashboard.Name = "panelSADashboard";
            this.panelSADashboard.Size = new System.Drawing.Size(1204, 417);
            this.panelSADashboard.TabIndex = 0;
            // 
            // dataGridSA
            // 
            this.dataGridSA.AllowUserToAddRows = false;
            this.dataGridSA.AllowUserToDeleteRows = false;
            this.dataGridSA.AllowUserToResizeColumns = false;
            this.dataGridSA.AllowUserToResizeRows = false;
            this.dataGridSA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSA.BackgroundColor = System.Drawing.Color.White;
            this.dataGridSA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridSA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnHashtag,
            this.clmnWebpage,
            this.balance,
            this.buttonProductListGrid});
            this.dataGridSA.GridColor = System.Drawing.Color.White;
            this.dataGridSA.Location = new System.Drawing.Point(32, 65);
            this.dataGridSA.MultiSelect = false;
            this.dataGridSA.Name = "dataGridSA";
            this.dataGridSA.ReadOnly = true;
            this.dataGridSA.RowHeadersVisible = false;
            this.dataGridSA.RowHeadersWidth = 51;
            this.dataGridSA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridSA.RowTemplate.Height = 29;
            this.dataGridSA.ShowEditingIcon = false;
            this.dataGridSA.Size = new System.Drawing.Size(1142, 288);
            this.dataGridSA.TabIndex = 5;
            this.dataGridSA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSA_CellClick);
            // 
            // clmnHashtag
            // 
            this.clmnHashtag.DataPropertyName = "clmnHashtag";
            this.clmnHashtag.HeaderText = "Hashtag";
            this.clmnHashtag.MinimumWidth = 6;
            this.clmnHashtag.Name = "clmnHashtag";
            this.clmnHashtag.ReadOnly = true;
            // 
            // clmnWebpage
            // 
            this.clmnWebpage.DataPropertyName = "clmnWebpage";
            this.clmnWebpage.HeaderText = "URL";
            this.clmnWebpage.MinimumWidth = 6;
            this.clmnWebpage.Name = "clmnWebpage";
            this.clmnWebpage.ReadOnly = true;
            // 
            // balance
            // 
            this.balance.DataPropertyName = "balance";
            this.balance.HeaderText = "Balance";
            this.balance.MinimumWidth = 6;
            this.balance.Name = "balance";
            this.balance.ReadOnly = true;
            // 
            // buttonProductListGrid
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.buttonProductListGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.buttonProductListGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductListGrid.HeaderText = "";
            this.buttonProductListGrid.MinimumWidth = 6;
            this.buttonProductListGrid.Name = "buttonProductListGrid";
            this.buttonProductListGrid.ReadOnly = true;
            this.buttonProductListGrid.Text = "Product List";
            this.buttonProductListGrid.UseColumnTextForButtonValue = true;
            // 
            // dataGridNPO
            // 
            this.dataGridNPO.AllowUserToAddRows = false;
            this.dataGridNPO.AllowUserToDeleteRows = false;
            this.dataGridNPO.AllowUserToResizeColumns = false;
            this.dataGridNPO.AllowUserToResizeRows = false;
            this.dataGridNPO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridNPO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridNPO.BackgroundColor = System.Drawing.Color.White;
            this.dataGridNPO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridNPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNPO.GridColor = System.Drawing.Color.White;
            this.dataGridNPO.Location = new System.Drawing.Point(-1956, -600);
            this.dataGridNPO.MultiSelect = false;
            this.dataGridNPO.Name = "dataGridNPO";
            this.dataGridNPO.ReadOnly = true;
            this.dataGridNPO.RowHeadersVisible = false;
            this.dataGridNPO.RowHeadersWidth = 51;
            this.dataGridNPO.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridNPO.RowTemplate.Height = 29;
            this.dataGridNPO.ShowEditingIcon = false;
            this.dataGridNPO.Size = new System.Drawing.Size(608, 143);
            this.dataGridNPO.TabIndex = 1;
            // 
            // textBoxSearchSA
            // 
            this.textBoxSearchSA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchSA.Location = new System.Drawing.Point(905, 27);
            this.textBoxSearchSA.Name = "textBoxSearchSA";
            this.textBoxSearchSA.Size = new System.Drawing.Size(234, 27);
            this.textBoxSearchSA.TabIndex = 0;
            // 
            // pictureBoxSearchSA
            // 
            this.pictureBoxSearchSA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSearchSA.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxSearchSA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSearchSA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearchSA.Image")));
            this.pictureBoxSearchSA.Location = new System.Drawing.Point(1138, 27);
            this.pictureBoxSearchSA.Name = "pictureBoxSearchSA";
            this.pictureBoxSearchSA.Size = new System.Drawing.Size(36, 27);
            this.pictureBoxSearchSA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSearchSA.TabIndex = 4;
            this.pictureBoxSearchSA.TabStop = false;
            // 
            // panelSA
            // 
            this.panelSA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(139)))));
            this.panelSA.Controls.Add(this.labelSATitle);
            this.panelSA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSA.Location = new System.Drawing.Point(0, 0);
            this.panelSA.Name = "panelSA";
            this.panelSA.Size = new System.Drawing.Size(1236, 135);
            this.panelSA.TabIndex = 0;
            this.panelSA.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSA_Paint);
            // 
            // labelSATitle
            // 
            this.labelSATitle.AutoSize = true;
            this.labelSATitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSATitle.ForeColor = System.Drawing.Color.White;
            this.labelSATitle.Location = new System.Drawing.Point(12, 65);
            this.labelSATitle.Name = "labelSATitle";
            this.labelSATitle.Size = new System.Drawing.Size(133, 28);
            this.labelSATitle.TabIndex = 0;
            this.labelSATitle.Text = "Social Activist";
            // 
            // panelBalance
            // 
            this.panelBalance.BackColor = System.Drawing.Color.White;
            this.panelBalance.Controls.Add(this.labelSACurrency);
            this.panelBalance.Controls.Add(this.labelBalance);
            this.panelBalance.Location = new System.Drawing.Point(20, 147);
            this.panelBalance.Name = "panelBalance";
            this.panelBalance.Size = new System.Drawing.Size(396, 124);
            this.panelBalance.TabIndex = 1;
            // 
            // labelSACurrency
            // 
            this.labelSACurrency.AutoSize = true;
            this.labelSACurrency.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSACurrency.ForeColor = System.Drawing.Color.Green;
            this.labelSACurrency.Location = new System.Drawing.Point(143, 18);
            this.labelSACurrency.Name = "labelSACurrency";
            this.labelSACurrency.Size = new System.Drawing.Size(77, 25);
            this.labelSACurrency.TabIndex = 0;
            this.labelSACurrency.Text = "100.00$";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBalance.Location = new System.Drawing.Point(13, 15);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(129, 28);
            this.labelBalance.TabIndex = 0;
            this.labelBalance.Text = "Total Balance:";
            // 
            // panelMessagesSA
            // 
            this.panelMessagesSA.BackColor = System.Drawing.Color.White;
            this.panelMessagesSA.Controls.Add(this.lblMessage);
            this.panelMessagesSA.Controls.Add(this.dataGridMessages);
            this.panelMessagesSA.Location = new System.Drawing.Point(610, 141);
            this.panelMessagesSA.Name = "panelMessagesSA";
            this.panelMessagesSA.Size = new System.Drawing.Size(614, 124);
            this.panelMessagesSA.TabIndex = 0;
            // 
            // dataGridMessages
            // 
            this.dataGridMessages.AllowUserToAddRows = false;
            this.dataGridMessages.AllowUserToDeleteRows = false;
            this.dataGridMessages.AllowUserToResizeColumns = false;
            this.dataGridMessages.AllowUserToResizeRows = false;
            this.dataGridMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridMessages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMessages.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMessages.GridColor = System.Drawing.Color.White;
            this.dataGridMessages.Location = new System.Drawing.Point(7, 10);
            this.dataGridMessages.MultiSelect = false;
            this.dataGridMessages.Name = "dataGridMessages";
            this.dataGridMessages.ReadOnly = true;
            this.dataGridMessages.RowHeadersVisible = false;
            this.dataGridMessages.RowHeadersWidth = 51;
            this.dataGridMessages.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridMessages.RowTemplate.Height = 29;
            this.dataGridMessages.ShowEditingIcon = false;
            this.dataGridMessages.Size = new System.Drawing.Size(600, 112);
            this.dataGridMessages.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Black;
            this.lblMessage.ForeColor = System.Drawing.Color.Brown;
            this.lblMessage.Location = new System.Drawing.Point(41, 59);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(67, 20);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Message";
            // 
            // SocialActivistPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 712);
            this.Controls.Add(this.panelMessagesSA);
            this.Controls.Add(this.panelBalance);
            this.Controls.Add(this.panelSA);
            this.Controls.Add(this.panelSADashboard);
            this.MaximumSize = new System.Drawing.Size(1254, 759);
            this.MinimumSize = new System.Drawing.Size(1254, 759);
            this.Name = "SocialActivistPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SocialActivistPanel";
            this.panelSADashboard.ResumeLayout(false);
            this.panelSADashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchSA)).EndInit();
            this.panelSA.ResumeLayout(false);
            this.panelSA.PerformLayout();
            this.panelBalance.ResumeLayout(false);
            this.panelBalance.PerformLayout();
            this.panelMessagesSA.ResumeLayout(false);
            this.panelMessagesSA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMessages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSADashboard;
        private System.Windows.Forms.TextBox textBoxSearchSA;
        private System.Windows.Forms.PictureBox pictureBoxSearchSA;
        private System.Windows.Forms.Panel panelSA;
        private System.Windows.Forms.Label labelSATitle;
        private System.Windows.Forms.Panel panelBalance;
        private System.Windows.Forms.Panel panelMessagesSA;
        private System.Windows.Forms.DataGridView dataGridNPO;
        private System.Windows.Forms.Label labelSACurrency;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.DataGridView dataGridSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnHashtag;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnWebpage;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
        private System.Windows.Forms.DataGridViewButtonColumn buttonProductListGrid;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.DataGridView dataGridMessages;
    }
}