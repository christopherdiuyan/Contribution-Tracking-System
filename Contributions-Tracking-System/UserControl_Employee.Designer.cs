using System.Windows.Forms;

namespace Contributions_Tracking_System
{
    partial class UserControl_Employee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Employee));
            this.panel3 = new System.Windows.Forms.Panel();
            this.userControl_ProfileContributions1 = new Contributions_Tracking_System.UserControl_ProfileContributions();
            this.timeZone1 = new Contributions_Tracking_System.TimeZone();
            this.btn_Back = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.cb_Sort = new System.Windows.Forms.ComboBox();
            this.dtg_Employee = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column11 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_Archive = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_ViewAll = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Employee)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.panel3.Controls.Add(this.userControl_ProfileContributions1);
            this.panel3.Controls.Add(this.timeZone1);
            this.panel3.Controls.Add(this.btn_Back);
            this.panel3.Controls.Add(this.btn_Search);
            this.panel3.Controls.Add(this.txt_Search);
            this.panel3.Controls.Add(this.cb_Sort);
            this.panel3.Controls.Add(this.dtg_Employee);
            this.panel3.Controls.Add(this.btn_Archive);
            this.panel3.Controls.Add(this.btn_ViewAll);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1099, 637);
            this.panel3.TabIndex = 2;
            // 
            // userControl_ProfileContributions1
            // 
            this.userControl_ProfileContributions1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.userControl_ProfileContributions1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userControl_ProfileContributions1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_ProfileContributions1.Location = new System.Drawing.Point(0, 0);
            this.userControl_ProfileContributions1.Name = "userControl_ProfileContributions1";
            this.userControl_ProfileContributions1.Size = new System.Drawing.Size(1099, 637);
            this.userControl_ProfileContributions1.TabIndex = 40;
            // 
            // timeZone1
            // 
            this.timeZone1.Location = new System.Drawing.Point(753, 3);
            this.timeZone1.Name = "timeZone1";
            this.timeZone1.Size = new System.Drawing.Size(333, 47);
            this.timeZone1.TabIndex = 39;
            this.timeZone1.Load += new System.EventHandler(this.timeZone1_Load);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.BackgroundImage = global::Contributions_Tracking_System.Properties.Resources.back_arrow_64px1;
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Back.color = System.Drawing.Color.Transparent;
            this.btn_Back.colorActive = System.Drawing.Color.Transparent;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Back.Image = null;
            this.btn_Back.ImagePosition = 20;
            this.btn_Back.ImageZoom = 50;
            this.btn_Back.LabelPosition = 41;
            this.btn_Back.LabelText = "";
            this.btn_Back.Location = new System.Drawing.Point(6, 6);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(30, 30);
            this.btn_Back.TabIndex = 27;
            this.btn_Back.Visible = false;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.btn_Search.BackgroundImage = global::Contributions_Tracking_System.Properties.Resources.search_50px2;
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Location = new System.Drawing.Point(1023, 55);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(49, 29);
            this.btn_Search.TabIndex = 26;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Search.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 16.25F);
            this.txt_Search.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_Search.Location = new System.Drawing.Point(791, 55);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(257, 29);
            this.txt_Search.TabIndex = 25;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // cb_Sort
            // 
            this.cb_Sort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Sort.DropDownWidth = 100;
            this.cb_Sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Sort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Sort.FormattingEnabled = true;
            this.cb_Sort.Items.AddRange(new object[] {
            "View by",
            "Department: IT",
            "Department: ACC",
            "Department: Cash-Section",
            "Status: Contractual",
            "Status: Regular"});
            this.cb_Sort.Location = new System.Drawing.Point(26, 55);
            this.cb_Sort.Name = "cb_Sort";
            this.cb_Sort.Size = new System.Drawing.Size(198, 29);
            this.cb_Sort.TabIndex = 24;
            this.cb_Sort.SelectedIndexChanged += new System.EventHandler(this.cb_Sort_SelectedIndexChanged);
            // 
            // dtg_Employee
            // 
            this.dtg_Employee.AllowUserToAddRows = false;
            this.dtg_Employee.AllowUserToDeleteRows = false;
            this.dtg_Employee.AllowUserToResizeColumns = false;
            this.dtg_Employee.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtg_Employee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Employee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtg_Employee.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtg_Employee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_Employee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtg_Employee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(117)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Employee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_Employee.ColumnHeadersHeight = 50;
            this.dtg_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtg_Employee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(113)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_Employee.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_Employee.DoubleBuffered = true;
            this.dtg_Employee.EnableHeadersVisualStyles = false;
            this.dtg_Employee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.dtg_Employee.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.dtg_Employee.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.dtg_Employee.Location = new System.Drawing.Point(25, 111);
            this.dtg_Employee.Name = "dtg_Employee";
            this.dtg_Employee.ReadOnly = true;
            this.dtg_Employee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtg_Employee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Employee.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_Employee.RowHeadersVisible = false;
            this.dtg_Employee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dtg_Employee.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_Employee.RowTemplate.DividerHeight = 1;
            this.dtg_Employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtg_Employee.Size = new System.Drawing.Size(1047, 485);
            this.dtg_Employee.TabIndex = 0;
            this.dtg_Employee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Employee_CellContentClick);
            // 
            // Column11
            // 
            this.Column11.HeaderText = "View Record";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Text = "View";
            this.Column11.ToolTipText = "View Employee Profile";
            this.Column11.UseColumnTextForButtonValue = true;
            // 
            // btn_Archive
            // 
            this.btn_Archive.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btn_Archive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Archive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btn_Archive.BackgroundImage = global::Contributions_Tracking_System.Properties.Resources.trash_52px1;
            this.btn_Archive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Archive.BorderRadius = 0;
            this.btn_Archive.ButtonText = "";
            this.btn_Archive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Archive.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Archive.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Archive.Iconimage = null;
            this.btn_Archive.Iconimage_right = null;
            this.btn_Archive.Iconimage_right_Selected = null;
            this.btn_Archive.Iconimage_Selected = null;
            this.btn_Archive.IconMarginLeft = 0;
            this.btn_Archive.IconMarginRight = 0;
            this.btn_Archive.IconRightVisible = true;
            this.btn_Archive.IconRightZoom = 0D;
            this.btn_Archive.IconVisible = true;
            this.btn_Archive.IconZoom = 90D;
            this.btn_Archive.IsTab = false;
            this.btn_Archive.Location = new System.Drawing.Point(740, 50);
            this.btn_Archive.Name = "btn_Archive";
            this.btn_Archive.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btn_Archive.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_Archive.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Archive.selected = false;
            this.btn_Archive.Size = new System.Drawing.Size(33, 34);
            this.btn_Archive.TabIndex = 23;
            this.btn_Archive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Archive.Textcolor = System.Drawing.Color.White;
            this.btn_Archive.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Archive.Click += new System.EventHandler(this.btn_Archive_Click);
            // 
            // btn_ViewAll
            // 
            this.btn_ViewAll.ActiveBorderThickness = 1;
            this.btn_ViewAll.ActiveCornerRadius = 20;
            this.btn_ViewAll.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(113)))));
            this.btn_ViewAll.ActiveForecolor = System.Drawing.Color.White;
            this.btn_ViewAll.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_ViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btn_ViewAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ViewAll.BackgroundImage")));
            this.btn_ViewAll.ButtonText = "View All";
            this.btn_ViewAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ViewAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btn_ViewAll.IdleBorderThickness = 1;
            this.btn_ViewAll.IdleCornerRadius = 20;
            this.btn_ViewAll.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(61)))));
            this.btn_ViewAll.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btn_ViewAll.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(61)))));
            this.btn_ViewAll.Location = new System.Drawing.Point(256, 47);
            this.btn_ViewAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ViewAll.Name = "btn_ViewAll";
            this.btn_ViewAll.Size = new System.Drawing.Size(82, 42);
            this.btn_ViewAll.TabIndex = 38;
            this.btn_ViewAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ViewAll.Click += new System.EventHandler(this.btn_ViewAll_Click);
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 20;
            this.bunifuElipse4.TargetControl = this.txt_Search;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 20;
            this.bunifuElipse5.TargetControl = this.btn_Search;
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 20;
            this.bunifuElipse6.TargetControl = this.btn_Archive;
            // 
            // UserControl_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(181)))));
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.Name = "UserControl_Employee";
            this.Size = new System.Drawing.Size(1099, 637);
            this.Load += new System.EventHandler(this.UserControl_Employee_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Employee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private Bunifu.Framework.UI.BunifuTileButton btn_Back;
        private ComboBox cb_Sort;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Archive;
        private Button btn_Search;
        private TextBox txt_Search;
        private DataGridViewButtonColumn Column11;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dtg_Employee;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_ViewAll;
        private TimeZone timeZone1;
        private UserControl_ProfileContributions userControl_ProfileContributions1;
    }
}
