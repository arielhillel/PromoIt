namespace PromotItFormApp.PopupForms
{
    partial class BusinessCompanyPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBCR = new System.Windows.Forms.Panel();
            this.labelBCRTitle = new System.Windows.Forms.Label();
            this.labelWinnerList = new System.Windows.Forms.Label();
            this.labelCampaignsList = new System.Windows.Forms.Label();
            this.Hashtag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridCampains = new System.Windows.Forms.DataGridView();
            this.hashtag_BCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webpage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDonateGrid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonProductListGrid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridBuyers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelBCR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCampains)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuyers)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBCR
            // 
            this.panelBCR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(139)))));
            this.panelBCR.Controls.Add(this.labelBCRTitle);
            this.panelBCR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBCR.Location = new System.Drawing.Point(0, 0);
            this.panelBCR.Name = "panelBCR";
            this.panelBCR.Size = new System.Drawing.Size(1123, 135);
            this.panelBCR.TabIndex = 0;
            // 
            // labelBCRTitle
            // 
            this.labelBCRTitle.AutoSize = true;
            this.labelBCRTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBCRTitle.ForeColor = System.Drawing.Color.White;
            this.labelBCRTitle.Location = new System.Drawing.Point(12, 65);
            this.labelBCRTitle.Name = "labelBCRTitle";
            this.labelBCRTitle.Size = new System.Drawing.Size(306, 28);
            this.labelBCRTitle.TabIndex = 0;
            this.labelBCRTitle.Text = "Business Company Representative";
            // 
            // labelWinnerList
            // 
            this.labelWinnerList.AutoSize = true;
            this.labelWinnerList.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWinnerList.Location = new System.Drawing.Point(30, 155);
            this.labelWinnerList.Name = "labelWinnerList";
            this.labelWinnerList.Size = new System.Drawing.Size(127, 31);
            this.labelWinnerList.TabIndex = 0;
            this.labelWinnerList.Text = "Buyers List:";
            // 
            // labelCampaignsList
            // 
            this.labelCampaignsList.AutoSize = true;
            this.labelCampaignsList.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCampaignsList.Location = new System.Drawing.Point(588, 155);
            this.labelCampaignsList.Name = "labelCampaignsList";
            this.labelCampaignsList.Size = new System.Drawing.Size(175, 31);
            this.labelCampaignsList.TabIndex = 0;
            this.labelCampaignsList.Text = "Campaigns List:";
            // 
            // Hashtag
            // 
            this.Hashtag.HeaderText = "Hashtag";
            this.Hashtag.MinimumWidth = 6;
            this.Hashtag.Name = "Hashtag";
            this.Hashtag.Width = 125;
            // 
            // URL
            // 
            this.URL.HeaderText = "URL";
            this.URL.MinimumWidth = 6;
            this.URL.Name = "URL";
            this.URL.Width = 125;
            // 
            // dataGridCampains
            // 
            this.dataGridCampains.AllowUserToAddRows = false;
            this.dataGridCampains.AllowUserToDeleteRows = false;
            this.dataGridCampains.AllowUserToResizeColumns = false;
            this.dataGridCampains.AllowUserToResizeRows = false;
            this.dataGridCampains.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCampains.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCampains.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCampains.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCampains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCampains.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hashtag_BCR,
            this.webpage,
            this.buttonDonateGrid,
            this.buttonProductListGrid});
            this.dataGridCampains.GridColor = System.Drawing.Color.White;
            this.dataGridCampains.Location = new System.Drawing.Point(576, 199);
            this.dataGridCampains.MultiSelect = false;
            this.dataGridCampains.Name = "dataGridCampains";
            this.dataGridCampains.ReadOnly = true;
            this.dataGridCampains.RowHeadersVisible = false;
            this.dataGridCampains.RowHeadersWidth = 51;
            this.dataGridCampains.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridCampains.RowTemplate.Height = 29;
            this.dataGridCampains.ShowEditingIcon = false;
            this.dataGridCampains.Size = new System.Drawing.Size(527, 491);
            this.dataGridCampains.TabIndex = 1;
            this.dataGridCampains.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBC_CellClick);
            // 
            // hashtag_BCR
            // 
            this.hashtag_BCR.DataPropertyName = "hashtag_BCR";
            this.hashtag_BCR.HeaderText = "Hashtag";
            this.hashtag_BCR.MinimumWidth = 6;
            this.hashtag_BCR.Name = "hashtag_BCR";
            this.hashtag_BCR.ReadOnly = true;
            // 
            // webpage
            // 
            this.webpage.DataPropertyName = "webpage";
            this.webpage.HeaderText = "URL";
            this.webpage.MinimumWidth = 6;
            this.webpage.Name = "webpage";
            this.webpage.ReadOnly = true;
            // 
            // buttonDonateGrid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.buttonDonateGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.buttonDonateGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDonateGrid.HeaderText = "";
            this.buttonDonateGrid.MinimumWidth = 6;
            this.buttonDonateGrid.Name = "buttonDonateGrid";
            this.buttonDonateGrid.ReadOnly = true;
            this.buttonDonateGrid.Text = "Donate";
            this.buttonDonateGrid.UseColumnTextForButtonValue = true;
            // 
            // buttonProductListGrid
            // 
            this.buttonProductListGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductListGrid.HeaderText = "";
            this.buttonProductListGrid.MinimumWidth = 6;
            this.buttonProductListGrid.Name = "buttonProductListGrid";
            this.buttonProductListGrid.ReadOnly = true;
            this.buttonProductListGrid.Text = "Product List";
            this.buttonProductListGrid.UseColumnTextForButtonValue = true;
            // 
            // dataGridBuyers
            // 
            this.dataGridBuyers.AllowUserToAddRows = false;
            this.dataGridBuyers.AllowUserToDeleteRows = false;
            this.dataGridBuyers.AllowUserToResizeColumns = false;
            this.dataGridBuyers.AllowUserToResizeRows = false;
            this.dataGridBuyers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridBuyers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBuyers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridBuyers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridBuyers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBuyers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewButtonColumn1});
            this.dataGridBuyers.GridColor = System.Drawing.Color.White;
            this.dataGridBuyers.Location = new System.Drawing.Point(21, 199);
            this.dataGridBuyers.MultiSelect = false;
            this.dataGridBuyers.Name = "dataGridBuyers";
            this.dataGridBuyers.ReadOnly = true;
            this.dataGridBuyers.RowHeadersVisible = false;
            this.dataGridBuyers.RowHeadersWidth = 51;
            this.dataGridBuyers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridBuyers.RowTemplate.Height = 29;
            this.dataGridBuyers.ShowEditingIcon = false;
            this.dataGridBuyers.Size = new System.Drawing.Size(516, 491);
            this.dataGridBuyers.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "hashtag1";
            this.dataGridViewTextBoxColumn2.HeaderText = "Buyer name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "webpage";
            this.dataGridViewTextBoxColumn3.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "Send product";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // BusinessCompanyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 719);
            this.Controls.Add(this.dataGridBuyers);
            this.Controls.Add(this.dataGridCampains);
            this.Controls.Add(this.labelCampaignsList);
            this.Controls.Add(this.labelWinnerList);
            this.Controls.Add(this.panelBCR);
            this.MaximumSize = new System.Drawing.Size(1141, 766);
            this.MinimumSize = new System.Drawing.Size(1141, 766);
            this.Name = "BusinessCompanyPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BusinessCompanyPanel";
            this.Shown += new System.EventHandler(this.BusinessCompanyPanel_Shown);
            this.panelBCR.ResumeLayout(false);
            this.panelBCR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCampains)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuyers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBCR;
        private System.Windows.Forms.Label labelBCRTitle;
        private System.Windows.Forms.Label labelWinnerList;
        private System.Windows.Forms.Label labelCampaignsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hashtag;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.DataGridView dataGridCampains;
        private System.Windows.Forms.DataGridView dataGridBuyers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hashtag_BCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn webpage;
        private System.Windows.Forms.DataGridViewButtonColumn buttonDonateGrid;
        private System.Windows.Forms.DataGridViewButtonColumn buttonProductListGrid;
    }
}