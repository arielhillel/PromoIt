namespace PromotItFormApp.LandingPages
{
    partial class NonProfitPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelNPO = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridNPO = new System.Windows.Forms.DataGridView();
            this.clmnCampaignName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnHashtag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webpage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCreator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDeleteGrid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonNew = new System.Windows.Forms.Button();
            this.panelNPO.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNPO)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNPO
            // 
            this.panelNPO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(139)))));
            this.panelNPO.Controls.Add(this.label1);
            this.panelNPO.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNPO.Location = new System.Drawing.Point(0, 0);
            this.panelNPO.Name = "panelNPO";
            this.panelNPO.Size = new System.Drawing.Size(1141, 135);
            this.panelNPO.TabIndex = 0;
            this.panelNPO.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNPO_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Non-Profit Organization";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridNPO);
            this.panel2.Controls.Add(this.buttonNew);
            this.panel2.Location = new System.Drawing.Point(28, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 429);
            this.panel2.TabIndex = 0;
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
            this.dataGridNPO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnCampaignName,
            this.clmnHashtag,
            this.webpage,
            this.clmnCreator,
            this.buttonDeleteGrid});
            this.dataGridNPO.GridColor = System.Drawing.Color.White;
            this.dataGridNPO.Location = new System.Drawing.Point(17, 90);
            this.dataGridNPO.MultiSelect = false;
            this.dataGridNPO.Name = "dataGridNPO";
            this.dataGridNPO.ReadOnly = true;
            this.dataGridNPO.RowHeadersVisible = false;
            this.dataGridNPO.RowHeadersWidth = 51;
            this.dataGridNPO.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridNPO.RowTemplate.Height = 29;
            this.dataGridNPO.ShowEditingIcon = false;
            this.dataGridNPO.Size = new System.Drawing.Size(1051, 321);
            this.dataGridNPO.TabIndex = 0;
            this.dataGridNPO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridNPO_CellClick);
            // 
            // clmnCampaignName
            // 
            this.clmnCampaignName.DataPropertyName = "clmnCampaignName";
            this.clmnCampaignName.HeaderText = "Campaign Name";
            this.clmnCampaignName.MinimumWidth = 6;
            this.clmnCampaignName.Name = "clmnCampaignName";
            this.clmnCampaignName.ReadOnly = true;
            // 
            // clmnHashtag
            // 
            this.clmnHashtag.DataPropertyName = "clmnHashtag";
            this.clmnHashtag.HeaderText = "Hashtag";
            this.clmnHashtag.MinimumWidth = 6;
            this.clmnHashtag.Name = "clmnHashtag";
            this.clmnHashtag.ReadOnly = true;
            // 
            // webpage
            // 
            this.webpage.DataPropertyName = "clmnWebsite";
            this.webpage.HeaderText = "URL";
            this.webpage.MinimumWidth = 6;
            this.webpage.Name = "webpage";
            this.webpage.ReadOnly = true;
            // 
            // clmnCreator
            // 
            this.clmnCreator.DataPropertyName = "clmnCreator";
            this.clmnCreator.HeaderText = "Campaign Creator";
            this.clmnCreator.MinimumWidth = 6;
            this.clmnCreator.Name = "clmnCreator";
            this.clmnCreator.ReadOnly = true;
            // 
            // buttonDeleteGrid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.buttonDeleteGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.buttonDeleteGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteGrid.HeaderText = "";
            this.buttonDeleteGrid.MinimumWidth = 6;
            this.buttonDeleteGrid.Name = "buttonDeleteGrid";
            this.buttonDeleteGrid.ReadOnly = true;
            this.buttonDeleteGrid.Text = "Delete";
            this.buttonDeleteGrid.UseColumnTextForButtonValue = true;
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.buttonNew.FlatAppearance.BorderSize = 0;
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNew.ForeColor = System.Drawing.Color.White;
            this.buttonNew.Location = new System.Drawing.Point(17, 21);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(172, 47);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // NonProfitPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 605);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelNPO);
            this.MaximumSize = new System.Drawing.Size(1159, 652);
            this.MinimumSize = new System.Drawing.Size(1159, 652);
            this.Name = "NonProfitPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Non-Profit Organzation Dashboard";
            this.Shown += new System.EventHandler(this.NPOrganizationPanel_Shown);
            this.panelNPO.ResumeLayout(false);
            this.panelNPO.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNPO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNPO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.DataGridView dataGridNPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCampaignName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnHashtag;
        private System.Windows.Forms.DataGridViewTextBoxColumn webpage;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCreator;
        private System.Windows.Forms.DataGridViewButtonColumn buttonDeleteGrid;
    }
}