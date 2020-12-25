namespace Contributions_Tracking_System
{
    partial class UserControl_Contributions
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dtg_OfficialReceipt = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column11 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.userControl_ContributionContents1 = new Contributions_Tracking_System.UserControl_ContributionContents();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_OfficialReceipt)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.btn_Search.BackgroundImage = global::Contributions_Tracking_System.Properties.Resources.search_50px2;
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Location = new System.Drawing.Point(1000, 52);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(49, 29);
            this.btn_Search.TabIndex = 15;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 16.25F);
            this.txt_Search.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_Search.Location = new System.Drawing.Point(768, 52);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(257, 29);
            this.txt_Search.TabIndex = 14;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.btn_Search;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.txt_Search;
            // 
            // dtg_OfficialReceipt
            // 
            this.dtg_OfficialReceipt.AllowUserToAddRows = false;
            this.dtg_OfficialReceipt.AllowUserToDeleteRows = false;
            this.dtg_OfficialReceipt.AllowUserToResizeColumns = false;
            this.dtg_OfficialReceipt.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dtg_OfficialReceipt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_OfficialReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_OfficialReceipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_OfficialReceipt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.dtg_OfficialReceipt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_OfficialReceipt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtg_OfficialReceipt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(117)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_OfficialReceipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtg_OfficialReceipt.ColumnHeadersHeight = 40;
            this.dtg_OfficialReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(113)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_OfficialReceipt.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtg_OfficialReceipt.DoubleBuffered = true;
            this.dtg_OfficialReceipt.EnableHeadersVisualStyles = false;
            this.dtg_OfficialReceipt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.dtg_OfficialReceipt.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.dtg_OfficialReceipt.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.dtg_OfficialReceipt.Location = new System.Drawing.Point(115, 108);
            this.dtg_OfficialReceipt.Name = "dtg_OfficialReceipt";
            this.dtg_OfficialReceipt.ReadOnly = true;
            this.dtg_OfficialReceipt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtg_OfficialReceipt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtg_OfficialReceipt.RowHeadersVisible = false;
            this.dtg_OfficialReceipt.RowHeadersWidth = 30;
            this.dtg_OfficialReceipt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.dtg_OfficialReceipt.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtg_OfficialReceipt.RowTemplate.DividerHeight = 1;
            this.dtg_OfficialReceipt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtg_OfficialReceipt.Size = new System.Drawing.Size(862, 496);
            this.dtg_OfficialReceipt.TabIndex = 16;
            this.dtg_OfficialReceipt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_OfficialReceipt_CellContentClick);
            // 
            // Column11
            // 
            this.Column11.HeaderText = "VIEW";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Text = "View";
            this.Column11.ToolTipText = "View Employee Profile";
            this.Column11.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(575, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Official Receipt #:  ";
            // 
            // userControl_ContributionContents1
            // 
            this.userControl_ContributionContents1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(181)))));
            this.userControl_ContributionContents1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_ContributionContents1.Location = new System.Drawing.Point(0, 0);
            this.userControl_ContributionContents1.Name = "userControl_ContributionContents1";
            this.userControl_ContributionContents1.Size = new System.Drawing.Size(1099, 637);
            this.userControl_ContributionContents1.TabIndex = 18;
            this.userControl_ContributionContents1.Load += new System.EventHandler(this.userControl_ContributionContents1_Load);
            // 
            // UserControl_Contributions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Controls.Add(this.userControl_ContributionContents1);
            this.Controls.Add(this.dtg_OfficialReceipt);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "UserControl_Contributions";
            this.Size = new System.Drawing.Size(1099, 637);
            this.Load += new System.EventHandler(this.UserControl_Contributions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_OfficialReceipt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtg_OfficialReceipt;
        private UserControl_ContributionContents userControl_ContributionContents1;
        private System.Windows.Forms.DataGridViewButtonColumn Column11;
        private System.Windows.Forms.Label label1;
    }
}
