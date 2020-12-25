namespace Contributions_Tracking_System
{
    partial class UserControl_SettingAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_SettingAdmin));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dtg_AdminList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_Create = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Profile = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_AdminList)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dtg_AdminList
            // 
            this.dtg_AdminList.AllowUserToAddRows = false;
            this.dtg_AdminList.AllowUserToResizeColumns = false;
            this.dtg_AdminList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtg_AdminList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_AdminList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_AdminList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_AdminList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtg_AdminList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.dtg_AdminList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_AdminList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtg_AdminList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(117)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_AdminList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_AdminList.ColumnHeadersHeight = 30;
            this.dtg_AdminList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(113)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_AdminList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_AdminList.DoubleBuffered = true;
            this.dtg_AdminList.EnableHeadersVisualStyles = false;
            this.dtg_AdminList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.dtg_AdminList.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.dtg_AdminList.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.dtg_AdminList.Location = new System.Drawing.Point(18, 64);
            this.dtg_AdminList.Name = "dtg_AdminList";
            this.dtg_AdminList.ReadOnly = true;
            this.dtg_AdminList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_AdminList.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dtg_AdminList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_AdminList.RowTemplate.DividerHeight = 1;
            this.dtg_AdminList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_AdminList.Size = new System.Drawing.Size(665, 265);
            this.dtg_AdminList.TabIndex = 1;
            // 
            // btn_Create
            // 
            this.btn_Create.ActiveBorderThickness = 1;
            this.btn_Create.ActiveCornerRadius = 20;
            this.btn_Create.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(113)))));
            this.btn_Create.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Create.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Create.BackColor = System.Drawing.Color.White;
            this.btn_Create.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Create.BackgroundImage")));
            this.btn_Create.ButtonText = "Create";
            this.btn_Create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Create.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create.ForeColor = System.Drawing.Color.White;
            this.btn_Create.IdleBorderThickness = 1;
            this.btn_Create.IdleCornerRadius = 20;
            this.btn_Create.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(113)))));
            this.btn_Create.IdleForecolor = System.Drawing.Color.White;
            this.btn_Create.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Create.Location = new System.Drawing.Point(554, 336);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(129, 57);
            this.btn_Create.TabIndex = 3;
            this.btn_Create.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Profile
            // 
            this.btn_Profile.ActiveBorderThickness = 1;
            this.btn_Profile.ActiveCornerRadius = 20;
            this.btn_Profile.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(233)))), ((int)(((byte)(123)))));
            this.btn_Profile.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Profile.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Profile.BackColor = System.Drawing.Color.White;
            this.btn_Profile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Profile.BackgroundImage")));
            this.btn_Profile.ButtonText = "Profile";
            this.btn_Profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Profile.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Profile.ForeColor = System.Drawing.Color.White;
            this.btn_Profile.IdleBorderThickness = 1;
            this.btn_Profile.IdleCornerRadius = 20;
            this.btn_Profile.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(233)))), ((int)(((byte)(123)))));
            this.btn_Profile.IdleForecolor = System.Drawing.Color.White;
            this.btn_Profile.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Profile.Location = new System.Drawing.Point(18, 0);
            this.btn_Profile.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Profile.Name = "btn_Profile";
            this.btn_Profile.Size = new System.Drawing.Size(124, 60);
            this.btn_Profile.TabIndex = 4;
            this.btn_Profile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Profile.Click += new System.EventHandler(this.btn_Profile_Click);
            // 
            // UserControl_SettingAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_Profile);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.dtg_AdminList);
            this.DoubleBuffered = true;
            this.Name = "UserControl_SettingAdmin";
            this.Size = new System.Drawing.Size(708, 399);
            this.Load += new System.EventHandler(this.UserControl_SettingAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_AdminList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Profile;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Create;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dtg_AdminList;
    }
}
