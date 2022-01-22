namespace PromotItFormApp.PopupForms
{
    partial class NPOrganizationPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NPOrganizationPanel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelNPO = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridNPO = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hashtag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webpage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.non_profit_user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDeleteGrid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelNPO.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(12, 65);
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
            this.panel2.Controls.Add(this.textBoxSearch);
            this.panel2.Controls.Add(this.pictureBox1);
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
            this.name,
            this.hashtag,
            this.webpage,
            this.non_profit_user_name,
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
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(799, 21);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(234, 27);
            this.textBoxSearch.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1032, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Campaign Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // hashtag
            // 
            this.hashtag.DataPropertyName = "hashtag";
            this.hashtag.HeaderText = "Hashtag";
            this.hashtag.MinimumWidth = 6;
            this.hashtag.Name = "hashtag";
            this.hashtag.ReadOnly = true;
            // 
            // webpage
            // 
            this.webpage.DataPropertyName = "webpage";
            this.webpage.HeaderText = "URL";
            this.webpage.MinimumWidth = 6;
            this.webpage.Name = "webpage";
            this.webpage.ReadOnly = true;
            // 
            // non_profit_user_name
            // 
            this.non_profit_user_name.DataPropertyName = "non_profit_user_name";
            this.non_profit_user_name.HeaderText = "Campaign Creator";
            this.non_profit_user_name.MinimumWidth = 6;
            this.non_profit_user_name.Name = "non_profit_user_name";
            this.non_profit_user_name.ReadOnly = true;
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
            // NPOrganizationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 605);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelNPO);
            this.MaximumSize = new System.Drawing.Size(1159, 652);
            this.MinimumSize = new System.Drawing.Size(1159, 652);
            this.Name = "NPOrganizationPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NPOrganizationPanel";
            this.Shown += new System.EventHandler(this.NPOrganizationPanel_Shown);
            this.panelNPO.ResumeLayout(false);
            this.panelNPO.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNPO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridNPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn hashtag;
        private System.Windows.Forms.DataGridViewTextBoxColumn webpage;
        private System.Windows.Forms.DataGridViewTextBoxColumn non_profit_user_name;
        private System.Windows.Forms.DataGridViewButtonColumn buttonDeleteGrid;
    }
}