namespace Contributions_Tracking_System
{
    partial class ExcelSheetName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelSheetName));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new Bunifu.Framework.UI.BunifuTileButton();
            this.p_Content = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ExcelSheetName = new System.Windows.Forms.TextBox();
            this.btn_Import = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ExcelFileName = new System.Windows.Forms.TextBox();
            this.dtg_ExcelFile = new System.Windows.Forms.DataGridView();
            this.linkLabel_ViewDuplicates = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.p_Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ExcelFile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(77)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 64);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Import Excel File";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BackgroundImage = global::Contributions_Tracking_System.Properties.Resources.close_window_96px;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.color = System.Drawing.Color.Transparent;
            this.btn_Close.colorActive = System.Drawing.Color.Transparent;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Image = null;
            this.btn_Close.ImagePosition = 20;
            this.btn_Close.ImageZoom = 50;
            this.btn_Close.LabelPosition = 41;
            this.btn_Close.LabelText = "";
            this.btn_Close.Location = new System.Drawing.Point(592, 0);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(30, 30);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // p_Content
            // 
            this.p_Content.BackColor = System.Drawing.Color.White;
            this.p_Content.Controls.Add(this.linkLabel_ViewDuplicates);
            this.p_Content.Controls.Add(this.label5);
            this.p_Content.Controls.Add(this.label4);
            this.p_Content.Controls.Add(this.label3);
            this.p_Content.Controls.Add(this.txt_ExcelSheetName);
            this.p_Content.Controls.Add(this.btn_Import);
            this.p_Content.Controls.Add(this.label2);
            this.p_Content.Controls.Add(this.txt_ExcelFileName);
            this.p_Content.Controls.Add(this.dtg_ExcelFile);
            this.p_Content.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_Content.Location = new System.Drawing.Point(0, 30);
            this.p_Content.Name = "p_Content";
            this.p_Content.Size = new System.Drawing.Size(628, 134);
            this.p_Content.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(185, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Open your Excel File First!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(145, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Note: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(26, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "File Name:";
            // 
            // txt_ExcelSheetName
            // 
            this.txt_ExcelSheetName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.txt_ExcelSheetName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ExcelSheetName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ExcelSheetName.Location = new System.Drawing.Point(148, 77);
            this.txt_ExcelSheetName.Name = "txt_ExcelSheetName";
            this.txt_ExcelSheetName.Size = new System.Drawing.Size(317, 33);
            this.txt_ExcelSheetName.TabIndex = 15;
            // 
            // btn_Import
            // 
            this.btn_Import.ActiveBorderThickness = 1;
            this.btn_Import.ActiveCornerRadius = 20;
            this.btn_Import.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btn_Import.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Import.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btn_Import.BackColor = System.Drawing.Color.White;
            this.btn_Import.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Import.BackgroundImage")));
            this.btn_Import.ButtonText = "Import";
            this.btn_Import.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Import.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.btn_Import.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Import.IdleBorderThickness = 1;
            this.btn_Import.IdleCornerRadius = 20;
            this.btn_Import.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(155)))), ((int)(((byte)(82)))));
            this.btn_Import.IdleForecolor = System.Drawing.Color.White;
            this.btn_Import.IdleLineColor = System.Drawing.Color.Black;
            this.btn_Import.Location = new System.Drawing.Point(496, 72);
            this.btn_Import.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(107, 47);
            this.btn_Import.TabIndex = 14;
            this.btn_Import.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sheet Name:";
            // 
            // txt_ExcelFileName
            // 
            this.txt_ExcelFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(232)))));
            this.txt_ExcelFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ExcelFileName.Enabled = false;
            this.txt_ExcelFileName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ExcelFileName.Location = new System.Drawing.Point(148, 13);
            this.txt_ExcelFileName.Name = "txt_ExcelFileName";
            this.txt_ExcelFileName.Size = new System.Drawing.Size(455, 33);
            this.txt_ExcelFileName.TabIndex = 10;
            // 
            // dtg_ExcelFile
            // 
            this.dtg_ExcelFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ExcelFile.Location = new System.Drawing.Point(3, 3);
            this.dtg_ExcelFile.Name = "dtg_ExcelFile";
            this.dtg_ExcelFile.Size = new System.Drawing.Size(619, 43);
            this.dtg_ExcelFile.TabIndex = 17;
            this.dtg_ExcelFile.Visible = false;
            // 
            // linkLabel_ViewDuplicates
            // 
            this.linkLabel_ViewDuplicates.AutoSize = true;
            this.linkLabel_ViewDuplicates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_ViewDuplicates.Location = new System.Drawing.Point(499, 53);
            this.linkLabel_ViewDuplicates.Name = "linkLabel_ViewDuplicates";
            this.linkLabel_ViewDuplicates.Size = new System.Drawing.Size(104, 16);
            this.linkLabel_ViewDuplicates.TabIndex = 20;
            this.linkLabel_ViewDuplicates.TabStop = true;
            this.linkLabel_ViewDuplicates.Text = "View Duplicates";
            this.linkLabel_ViewDuplicates.Visible = false;
            this.linkLabel_ViewDuplicates.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ViewDuplicates_LinkClicked);
            // 
            // ExcelSheetName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 164);
            this.Controls.Add(this.p_Content);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExcelSheetName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExcelSheetName";
            this.Load += new System.EventHandler(this.ExcelSheetName_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.p_Content.ResumeLayout(false);
            this.p_Content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ExcelFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTileButton btn_Close;
        private System.Windows.Forms.Panel p_Content;
        private System.Windows.Forms.TextBox txt_ExcelSheetName;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Import;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ExcelFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtg_ExcelFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel_ViewDuplicates;
    }
}