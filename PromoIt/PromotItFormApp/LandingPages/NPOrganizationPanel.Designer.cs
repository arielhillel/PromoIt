﻿namespace PromotItFormApp.PopupForms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
<<<<<<< HEAD
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
=======
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
>>>>>>> YaronMalul_GUI_Changes
            this.panelNPO = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridNPO = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.label1.Size = new System.Drawing.Size(350, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "NON-PROFIT ORGANIZATION - PANEL";
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
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
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
            // Column1
            // 
<<<<<<< HEAD
            this.Column1.DataPropertyName = "clmnCampaignName";
            this.Column1.HeaderText = "Campaign Name";
=======
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "Column1";
>>>>>>> YaronMalul_GUI_Changes
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
<<<<<<< HEAD
            this.Column2.DataPropertyName = "clmnHashtag";
            this.Column2.HeaderText = "Hashtag";
=======
            this.Column2.HeaderText = "Campaign Name";
>>>>>>> YaronMalul_GUI_Changes
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
<<<<<<< HEAD
            this.Column3.DataPropertyName = "clmnWebsite";
            this.Column3.HeaderText = "Website";
=======
            this.Column3.HeaderText = "Hashtag";
>>>>>>> YaronMalul_GUI_Changes
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
<<<<<<< HEAD
            this.Column4.DataPropertyName = "clmnCreator";
            this.Column4.HeaderText = "Creator Username";
=======
            this.Column4.HeaderText = "URL";
>>>>>>> YaronMalul_GUI_Changes
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Creator Username";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
<<<<<<< HEAD
            this.buttonGridEdit.DataPropertyName = "buttonGridEdit";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(101)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(101)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.buttonGridEdit.DefaultCellStyle = dataGridViewCellStyle3;
            this.buttonGridEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGridEdit.HeaderText = "";
            this.buttonGridEdit.MinimumWidth = 6;
            this.buttonGridEdit.Name = "buttonGridEdit";
            this.buttonGridEdit.ReadOnly = true;
            this.buttonGridEdit.Text = "Edit";
            this.buttonGridEdit.UseColumnTextForButtonValue = true;
=======
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Column6.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column6.HeaderText = "";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Text = "EDIT";
            this.Column6.UseColumnTextForButtonValue = true;
>>>>>>> YaronMalul_GUI_Changes
            // 
            // Column7
            // 
<<<<<<< HEAD
            this.buttonGridDelete.DataPropertyName = "buttonGridDelete";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.buttonGridDelete.DefaultCellStyle = dataGridViewCellStyle4;
            this.buttonGridDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGridDelete.HeaderText = "";
            this.buttonGridDelete.MinimumWidth = 6;
            this.buttonGridDelete.Name = "buttonGridDelete";
            this.buttonGridDelete.ReadOnly = true;
            this.buttonGridDelete.Text = "Delete";
            this.buttonGridDelete.UseColumnTextForButtonValue = true;
=======
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Silver;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column7.HeaderText = "";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Text = "Delete";
            this.Column7.UseColumnTextForButtonValue = true;
>>>>>>> YaronMalul_GUI_Changes
            // 
            // NPOrganizationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 605);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelNPO);
            this.Name = "NPOrganizationPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NPOrganizationPanel";
<<<<<<< HEAD
=======
            this.Shown += new System.EventHandler(this.NPOrganizationPanel_Shown);
>>>>>>> YaronMalul_GUI_Changes
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
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
    }
}