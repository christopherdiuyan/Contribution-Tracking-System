namespace Contributions_Tracking_System
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.p_topBar = new System.Windows.Forms.Panel();
            this.btn_Close = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.p_SelectedTab = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Archive = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_BackUp = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Admin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.p_Content = new System.Windows.Forms.Panel();
            this.userControl_Archive1 = new Contributions_Tracking_System.UserControl_SettingArchive();
            this.userControl_BackUp1 = new Contributions_Tracking_System.UserControl_SettingBackUp();
            this.userControl_SettingAdmin1 = new Contributions_Tracking_System.UserControl_SettingAdmin();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.p_topBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.p_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_topBar
            // 
            this.p_topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.p_topBar.Controls.Add(this.btn_Close);
            this.p_topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_topBar.Location = new System.Drawing.Point(0, 0);
            this.p_topBar.Name = "p_topBar";
            this.p_topBar.Size = new System.Drawing.Size(1025, 31);
            this.p_topBar.TabIndex = 15;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BackgroundImage = global::Contributions_Tracking_System.Properties.Resources.delete_50px;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.color = System.Drawing.Color.Transparent;
            this.btn_Close.colorActive = System.Drawing.Color.Transparent;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImagePosition = 20;
            this.btn_Close.ImageZoom = 50;
            this.btn_Close.LabelPosition = 41;
            this.btn_Close.LabelText = "X";
            this.btn_Close.Location = new System.Drawing.Point(993, 5);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(20, 20);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.p_SelectedTab);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Archive);
            this.panel1.Controls.Add(this.btn_BackUp);
            this.panel1.Controls.Add(this.btn_Admin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 541);
            this.panel1.TabIndex = 16;
            // 
            // p_SelectedTab
            // 
            this.p_SelectedTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.p_SelectedTab.Location = new System.Drawing.Point(214, 105);
            this.p_SelectedTab.Name = "p_SelectedTab";
            this.p_SelectedTab.Size = new System.Drawing.Size(5, 38);
            this.p_SelectedTab.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 47);
            this.label1.TabIndex = 7;
            this.label1.Text = "SETTINGS";
            // 
            // btn_Archive
            // 
            this.btn_Archive.Depth = 0;
            this.btn_Archive.Location = new System.Drawing.Point(30, 228);
            this.btn_Archive.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Archive.Name = "btn_Archive";
            this.btn_Archive.Primary = true;
            this.btn_Archive.Size = new System.Drawing.Size(178, 38);
            this.btn_Archive.TabIndex = 6;
            this.btn_Archive.Text = "Archive";
            this.btn_Archive.UseVisualStyleBackColor = true;
            this.btn_Archive.Click += new System.EventHandler(this.btn_Archive_Click);
            // 
            // btn_BackUp
            // 
            this.btn_BackUp.Depth = 0;
            this.btn_BackUp.Location = new System.Drawing.Point(30, 168);
            this.btn_BackUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_BackUp.Name = "btn_BackUp";
            this.btn_BackUp.Primary = true;
            this.btn_BackUp.Size = new System.Drawing.Size(178, 38);
            this.btn_BackUp.TabIndex = 5;
            this.btn_BackUp.Text = "Back Up";
            this.btn_BackUp.UseVisualStyleBackColor = true;
            this.btn_BackUp.Click += new System.EventHandler(this.btn_BackUp_Click);
            // 
            // btn_Admin
            // 
            this.btn_Admin.Depth = 0;
            this.btn_Admin.Location = new System.Drawing.Point(30, 105);
            this.btn_Admin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Primary = true;
            this.btn_Admin.Size = new System.Drawing.Size(178, 38);
            this.btn_Admin.TabIndex = 4;
            this.btn_Admin.Text = "Admin";
            this.btn_Admin.UseVisualStyleBackColor = true;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(245, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 71);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(245, 501);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(780, 71);
            this.panel3.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Contributions_Tracking_System.Properties.Resources.copyright_52px;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(644, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.label2.Location = new System.Drawing.Point(658, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "LTSys Version 0.0.1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(953, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(72, 399);
            this.panel4.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(72, 399);
            this.panel5.TabIndex = 20;
            // 
            // p_Content
            // 
            this.p_Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.p_Content.Controls.Add(this.userControl_Archive1);
            this.p_Content.Controls.Add(this.userControl_BackUp1);
            this.p_Content.Controls.Add(this.userControl_SettingAdmin1);
            this.p_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_Content.Location = new System.Drawing.Point(245, 102);
            this.p_Content.Name = "p_Content";
            this.p_Content.Size = new System.Drawing.Size(708, 399);
            this.p_Content.TabIndex = 21;
            // 
            // userControl_Archive1
            // 
            this.userControl_Archive1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.userControl_Archive1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Archive1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Archive1.Name = "userControl_Archive1";
            this.userControl_Archive1.Size = new System.Drawing.Size(708, 399);
            this.userControl_Archive1.TabIndex = 2;
            // 
            // userControl_BackUp1
            // 
            this.userControl_BackUp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.userControl_BackUp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_BackUp1.Location = new System.Drawing.Point(0, 0);
            this.userControl_BackUp1.Name = "userControl_BackUp1";
            this.userControl_BackUp1.Size = new System.Drawing.Size(708, 399);
            this.userControl_BackUp1.TabIndex = 1;
            // 
            // userControl_SettingAdmin1
            // 
            this.userControl_SettingAdmin1.BackColor = System.Drawing.Color.White;
            this.userControl_SettingAdmin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_SettingAdmin1.Location = new System.Drawing.Point(0, 0);
            this.userControl_SettingAdmin1.Name = "userControl_SettingAdmin1";
            this.userControl_SettingAdmin1.Size = new System.Drawing.Size(708, 399);
            this.userControl_SettingAdmin1.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 572);
            this.Controls.Add(this.p_Content);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.p_topBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.p_topBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.p_Content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel p_topBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Archive;
        private MaterialSkin.Controls.MaterialRaisedButton btn_BackUp;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Admin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel p_Content;
        private Bunifu.Framework.UI.BunifuTileButton btn_Close;
        private System.Windows.Forms.Panel p_SelectedTab;
        private UserControl_SettingAdmin userControl_SettingAdmin1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControl_SettingBackUp userControl_BackUp1;
        public UserControl_SettingArchive userControl_Archive1;
    }
}