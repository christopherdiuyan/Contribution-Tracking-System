namespace Contributions_Tracking_System
{
    partial class BrowseFile
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseFile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new Bunifu.Framework.UI.BunifuTileButton();
            this.p_Content = new System.Windows.Forms.Panel();
            this.btn_Next = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_BrowseExcelFile = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_BrowseFile = new System.Windows.Forms.RichTextBox();
            this.txt_FileStatus = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.p_Content.SuspendLayout();
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
            this.panel1.TabIndex = 0;
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
            this.p_Content.Controls.Add(this.btn_Next);
            this.p_Content.Controls.Add(this.btn_BrowseExcelFile);
            this.p_Content.Controls.Add(this.label2);
            this.p_Content.Controls.Add(this.txt_BrowseFile);
            this.p_Content.Controls.Add(this.txt_FileStatus);
            this.p_Content.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_Content.Location = new System.Drawing.Point(0, 31);
            this.p_Content.Name = "p_Content";
            this.p_Content.Size = new System.Drawing.Size(628, 260);
            this.p_Content.TabIndex = 0;
            // 
            // btn_Next
            // 
            this.btn_Next.ActiveBorderThickness = 1;
            this.btn_Next.ActiveCornerRadius = 20;
            this.btn_Next.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btn_Next.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Next.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btn_Next.BackColor = System.Drawing.Color.White;
            this.btn_Next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Next.BackgroundImage")));
            this.btn_Next.ButtonText = "Next";
            this.btn_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Next.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Next.IdleBorderThickness = 1;
            this.btn_Next.IdleCornerRadius = 20;
            this.btn_Next.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(155)))), ((int)(((byte)(82)))));
            this.btn_Next.IdleForecolor = System.Drawing.Color.White;
            this.btn_Next.IdleLineColor = System.Drawing.Color.Black;
            this.btn_Next.Location = new System.Drawing.Point(447, 197);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(156, 50);
            this.btn_Next.TabIndex = 14;
            this.btn_Next.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_BrowseExcelFile
            // 
            this.btn_BrowseExcelFile.ActiveBorderThickness = 1;
            this.btn_BrowseExcelFile.ActiveCornerRadius = 20;
            this.btn_BrowseExcelFile.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btn_BrowseExcelFile.ActiveForecolor = System.Drawing.Color.White;
            this.btn_BrowseExcelFile.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btn_BrowseExcelFile.BackColor = System.Drawing.Color.White;
            this.btn_BrowseExcelFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BrowseExcelFile.BackgroundImage")));
            this.btn_BrowseExcelFile.ButtonText = "Upload";
            this.btn_BrowseExcelFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BrowseExcelFile.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BrowseExcelFile.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_BrowseExcelFile.IdleBorderThickness = 1;
            this.btn_BrowseExcelFile.IdleCornerRadius = 20;
            this.btn_BrowseExcelFile.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(77)))), ((int)(((byte)(156)))));
            this.btn_BrowseExcelFile.IdleForecolor = System.Drawing.Color.White;
            this.btn_BrowseExcelFile.IdleLineColor = System.Drawing.Color.Black;
            this.btn_BrowseExcelFile.Location = new System.Drawing.Point(28, 197);
            this.btn_BrowseExcelFile.Margin = new System.Windows.Forms.Padding(5);
            this.btn_BrowseExcelFile.Name = "btn_BrowseExcelFile";
            this.btn_BrowseExcelFile.Size = new System.Drawing.Size(156, 50);
            this.btn_BrowseExcelFile.TabIndex = 13;
            this.btn_BrowseExcelFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_BrowseExcelFile.Click += new System.EventHandler(this.btn_BrowseExcelFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Import Excel File:";
            // 
            // txt_BrowseFile
            // 
            this.txt_BrowseFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BrowseFile.Location = new System.Drawing.Point(28, 79);
            this.txt_BrowseFile.Name = "txt_BrowseFile";
            this.txt_BrowseFile.Size = new System.Drawing.Size(575, 110);
            this.txt_BrowseFile.TabIndex = 11;
            this.txt_BrowseFile.Text = "";
            this.txt_BrowseFile.TextChanged += new System.EventHandler(this.txt_BrowseFile_TextChanged);
            // 
            // txt_FileStatus
            // 
            this.txt_FileStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(232)))));
            this.txt_FileStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FileStatus.Enabled = false;
            this.txt_FileStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FileStatus.Location = new System.Drawing.Point(28, 13);
            this.txt_FileStatus.Name = "txt_FileStatus";
            this.txt_FileStatus.Size = new System.Drawing.Size(575, 33);
            this.txt_FileStatus.TabIndex = 10;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.p_Content;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BrowseFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 291);
            this.Controls.Add(this.p_Content);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BrowseFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BrowseFile";
            this.Activated += new System.EventHandler(this.BrowseFile_Activated);
            this.Load += new System.EventHandler(this.BrowseFile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.p_Content.ResumeLayout(false);
            this.p_Content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel p_Content;
        private Bunifu.Framework.UI.BunifuTileButton btn_Close;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Next;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_BrowseExcelFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txt_BrowseFile;
        private System.Windows.Forms.TextBox txt_FileStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}