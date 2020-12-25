namespace Contributions_Tracking_System
{
    partial class UserControl_ProfileContributions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_ProfileContributions));
            this.lbl_EmployeeID = new System.Windows.Forms.Label();
            this.lbl_AdminName = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtg_EmployeeContributions = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.datepicker_FromDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.datepicker_ToDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btn_PrintCertificate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_ViewAll = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Back = new Bunifu.Framework.UI.BunifuTileButton();
            this.dtg_Temp = new System.Windows.Forms.DataGridView();
            this.GenerateCertificate1 = new Contributions_Tracking_System.GenerateCertificate();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_EmployeeContributions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Temp)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_EmployeeID
            // 
            this.lbl_EmployeeID.AutoSize = true;
            this.lbl_EmployeeID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_EmployeeID.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_EmployeeID.ForeColor = System.Drawing.Color.White;
            this.lbl_EmployeeID.Location = new System.Drawing.Point(176, 33);
            this.lbl_EmployeeID.Name = "lbl_EmployeeID";
            this.lbl_EmployeeID.Size = new System.Drawing.Size(69, 13);
            this.lbl_EmployeeID.TabIndex = 35;
            this.lbl_EmployeeID.Text = "32165416584";
            this.lbl_EmployeeID.Visible = false;
            // 
            // lbl_AdminName
            // 
            this.lbl_AdminName.AutoSize = true;
            this.lbl_AdminName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AdminName.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_AdminName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(73)))), ((int)(((byte)(86)))));
            this.lbl_AdminName.Location = new System.Drawing.Point(73, 6);
            this.lbl_AdminName.Name = "lbl_AdminName";
            this.lbl_AdminName.Size = new System.Drawing.Size(224, 25);
            this.lbl_AdminName.TabIndex = 33;
            this.lbl_AdminName.Text = "John Christopher Diuyan";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 100;
            this.bunifuElipse2.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(48, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "From Date:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(338, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "To Date:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtg_EmployeeContributions
            // 
            this.dtg_EmployeeContributions.AllowUserToAddRows = false;
            this.dtg_EmployeeContributions.AllowUserToDeleteRows = false;
            this.dtg_EmployeeContributions.AllowUserToResizeColumns = false;
            this.dtg_EmployeeContributions.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtg_EmployeeContributions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_EmployeeContributions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_EmployeeContributions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_EmployeeContributions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtg_EmployeeContributions.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtg_EmployeeContributions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_EmployeeContributions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtg_EmployeeContributions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(117)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_EmployeeContributions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_EmployeeContributions.ColumnHeadersHeight = 30;
            this.dtg_EmployeeContributions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(113)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_EmployeeContributions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_EmployeeContributions.DoubleBuffered = true;
            this.dtg_EmployeeContributions.EnableHeadersVisualStyles = false;
            this.dtg_EmployeeContributions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.dtg_EmployeeContributions.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.dtg_EmployeeContributions.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.dtg_EmployeeContributions.Location = new System.Drawing.Point(25, 111);
            this.dtg_EmployeeContributions.Name = "dtg_EmployeeContributions";
            this.dtg_EmployeeContributions.ReadOnly = true;
            this.dtg_EmployeeContributions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtg_EmployeeContributions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_EmployeeContributions.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_EmployeeContributions.RowHeadersVisible = false;
            this.dtg_EmployeeContributions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dtg_EmployeeContributions.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_EmployeeContributions.RowTemplate.DividerHeight = 1;
            this.dtg_EmployeeContributions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtg_EmployeeContributions.Size = new System.Drawing.Size(1047, 449);
            this.dtg_EmployeeContributions.TabIndex = 11;
            // 
            // datepicker_FromDate
            // 
            this.datepicker_FromDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(140)))), ((int)(((byte)(175)))));
            this.datepicker_FromDate.BorderRadius = 0;
            this.datepicker_FromDate.Font = new System.Drawing.Font("Segoe UI", 4.25F);
            this.datepicker_FromDate.ForeColor = System.Drawing.Color.White;
            this.datepicker_FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker_FromDate.FormatCustom = "MMMM yyy";
            this.datepicker_FromDate.Location = new System.Drawing.Point(129, 48);
            this.datepicker_FromDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datepicker_FromDate.Name = "datepicker_FromDate";
            this.datepicker_FromDate.Size = new System.Drawing.Size(200, 25);
            this.datepicker_FromDate.TabIndex = 3;
            this.datepicker_FromDate.Value = new System.DateTime(2020, 2, 20, 21, 28, 3, 294);
            this.datepicker_FromDate.onValueChanged += new System.EventHandler(this.datepicker_FromDate_onValueChanged);
            // 
            // datepicker_ToDate
            // 
            this.datepicker_ToDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(140)))), ((int)(((byte)(175)))));
            this.datepicker_ToDate.BorderRadius = 0;
            this.datepicker_ToDate.Font = new System.Drawing.Font("Segoe UI", 4.25F);
            this.datepicker_ToDate.ForeColor = System.Drawing.Color.White;
            this.datepicker_ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker_ToDate.FormatCustom = "MMMM yyy";
            this.datepicker_ToDate.Location = new System.Drawing.Point(400, 46);
            this.datepicker_ToDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datepicker_ToDate.Name = "datepicker_ToDate";
            this.datepicker_ToDate.Size = new System.Drawing.Size(200, 25);
            this.datepicker_ToDate.TabIndex = 4;
            this.datepicker_ToDate.Value = new System.DateTime(2020, 2, 20, 21, 28, 3, 294);
            this.datepicker_ToDate.onValueChanged += new System.EventHandler(this.datepicker_ToDate_onValueChanged);
            // 
            // btn_PrintCertificate
            // 
            this.btn_PrintCertificate.ActiveBorderThickness = 1;
            this.btn_PrintCertificate.ActiveCornerRadius = 20;
            this.btn_PrintCertificate.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(144)))), ((int)(((byte)(248)))));
            this.btn_PrintCertificate.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btn_PrintCertificate.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(144)))), ((int)(((byte)(248)))));
            this.btn_PrintCertificate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PrintCertificate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btn_PrintCertificate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_PrintCertificate.BackgroundImage")));
            this.btn_PrintCertificate.ButtonText = "Print Certificate";
            this.btn_PrintCertificate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PrintCertificate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrintCertificate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.btn_PrintCertificate.IdleBorderThickness = 1;
            this.btn_PrintCertificate.IdleCornerRadius = 20;
            this.btn_PrintCertificate.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(89)))), ((int)(((byte)(245)))));
            this.btn_PrintCertificate.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.btn_PrintCertificate.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(89)))), ((int)(((byte)(245)))));
            this.btn_PrintCertificate.Location = new System.Drawing.Point(959, 579);
            this.btn_PrintCertificate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_PrintCertificate.Name = "btn_PrintCertificate";
            this.btn_PrintCertificate.Size = new System.Drawing.Size(127, 52);
            this.btn_PrintCertificate.TabIndex = 38;
            this.btn_PrintCertificate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_PrintCertificate.Click += new System.EventHandler(this.btn_PrintCertificate_Click);
            // 
            // btn_ViewAll
            // 
            this.btn_ViewAll.ActiveBorderThickness = 1;
            this.btn_ViewAll.ActiveCornerRadius = 20;
            this.btn_ViewAll.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(113)))));
            this.btn_ViewAll.ActiveForecolor = System.Drawing.Color.Transparent;
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
            this.btn_ViewAll.Location = new System.Drawing.Point(606, 36);
            this.btn_ViewAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ViewAll.Name = "btn_ViewAll";
            this.btn_ViewAll.Size = new System.Drawing.Size(82, 42);
            this.btn_ViewAll.TabIndex = 37;
            this.btn_ViewAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ViewAll.Click += new System.EventHandler(this.btn_Create_Click);
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
            this.btn_Back.TabIndex = 36;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // dtg_Temp
            // 
            this.dtg_Temp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Temp.Location = new System.Drawing.Point(22, 252);
            this.dtg_Temp.Name = "dtg_Temp";
            this.dtg_Temp.Size = new System.Drawing.Size(1050, 178);
            this.dtg_Temp.TabIndex = 39;
            this.dtg_Temp.Visible = false;
            // 
            // UserControl_ProfileContributions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbl_EmployeeID);
            this.Controls.Add(this.dtg_Temp);
            this.Controls.Add(this.btn_PrintCertificate);
            this.Controls.Add(this.lbl_AdminName);
            this.Controls.Add(this.btn_ViewAll);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.dtg_EmployeeContributions);
            this.Controls.Add(this.datepicker_ToDate);
            this.Controls.Add(this.datepicker_FromDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "UserControl_ProfileContributions";
            this.Size = new System.Drawing.Size(1099, 637);
            this.Load += new System.EventHandler(this.UserControl_ProfileContributions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_EmployeeContributions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Temp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuTileButton btn_Back;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dtg_EmployeeContributions;
        public System.Windows.Forms.Label lbl_EmployeeID;
        public System.Windows.Forms.Label lbl_AdminName;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_ViewAll;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_PrintCertificate;
        public System.Windows.Forms.DataGridView dtg_Temp;
        private GenerateCertificate GenerateCertificate1;
        public Bunifu.Framework.UI.BunifuDatepicker datepicker_FromDate;
        public Bunifu.Framework.UI.BunifuDatepicker datepicker_ToDate;
    }
}
