namespace Contributions_Tracking_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.elip_border = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elip_username = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_Username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.elip_password = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pb_Login = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkForgotPass = new System.Windows.Forms.LinkLabel();
            this.btn_Login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_contributions = new System.Windows.Forms.Label();
            this.lbl_signin = new System.Windows.Forms.Label();
            this.pb_Philhealth_icon = new System.Windows.Forms.PictureBox();
            this.pb_Pagibig_icon = new System.Windows.Forms.PictureBox();
            this.pb_GSIS_icon = new System.Windows.Forms.PictureBox();
            this.pb_Title = new System.Windows.Forms.Panel();
            this.pb_DSWD_logo = new System.Windows.Forms.PictureBox();
            this.pb_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Philhealth_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pagibig_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GSIS_icon)).BeginInit();
            this.pb_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DSWD_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // elip_border
            // 
            this.elip_border.ElipseRadius = 20;
            this.elip_border.TargetControl = this;
            // 
            // elip_username
            // 
            this.elip_username.ElipseRadius = 25;
            this.elip_username.TargetControl = this.txt_Username;
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(83)))), ((int)(((byte)(127)))));
            this.txt_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Username.Font = new System.Drawing.Font("Segoe UI", 13.75F);
            this.txt_Username.ForeColor = System.Drawing.Color.Black;
            this.txt_Username.HintForeColor = System.Drawing.Color.Silver;
            this.txt_Username.HintText = "Username";
            this.txt_Username.isPassword = false;
            this.txt_Username.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.txt_Username.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(77)))), ((int)(((byte)(156)))));
            this.txt_Username.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.txt_Username.LineThickness = 2;
            this.txt_Username.Location = new System.Drawing.Point(67, 204);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(282, 60);
            this.txt_Username.TabIndex = 2;
            this.txt_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // elip_password
            // 
            this.elip_password.ElipseRadius = 25;
            this.elip_password.TargetControl = this.txt_Password;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(83)))), ((int)(((byte)(127)))));
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 13.75F);
            this.txt_Password.ForeColor = System.Drawing.Color.Silver;
            this.txt_Password.HintForeColor = System.Drawing.Color.Gray;
            this.txt_Password.HintText = "";
            this.txt_Password.isPassword = false;
            this.txt_Password.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.txt_Password.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(77)))), ((int)(((byte)(156)))));
            this.txt_Password.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.txt_Password.LineThickness = 2;
            this.txt_Password.Location = new System.Drawing.Point(67, 284);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(282, 60);
            this.txt_Password.TabIndex = 3;
            this.txt_Password.Text = "Password";
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Password.Enter += new System.EventHandler(this.txt_Password_Enter);
            this.txt_Password.Leave += new System.EventHandler(this.txt_Password_Leave);
            // 
            // pb_Login
            // 
            this.pb_Login.BackgroundImage = global::Contributions_Tracking_System.Properties.Resources.background;
            this.pb_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_Login.Controls.Add(this.checkBox1);
            this.pb_Login.Controls.Add(this.txt_Password);
            this.pb_Login.Controls.Add(this.txt_Username);
            this.pb_Login.Controls.Add(this.linkForgotPass);
            this.pb_Login.Controls.Add(this.btn_Login);
            this.pb_Login.Controls.Add(this.bunifuMaterialTextbox2);
            this.pb_Login.Controls.Add(this.lbl_contributions);
            this.pb_Login.Controls.Add(this.lbl_signin);
            this.pb_Login.Controls.Add(this.pb_Philhealth_icon);
            this.pb_Login.Controls.Add(this.pb_Pagibig_icon);
            this.pb_Login.Controls.Add(this.pb_GSIS_icon);
            this.pb_Login.Location = new System.Drawing.Point(900, 63);
            this.pb_Login.Name = "pb_Login";
            this.pb_Login.Size = new System.Drawing.Size(402, 537);
            this.pb_Login.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(281, 345);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Show";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // linkForgotPass
            // 
            this.linkForgotPass.AutoSize = true;
            this.linkForgotPass.BackColor = System.Drawing.Color.Transparent;
            this.linkForgotPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkForgotPass.Location = new System.Drawing.Point(64, 348);
            this.linkForgotPass.Name = "linkForgotPass";
            this.linkForgotPass.Size = new System.Drawing.Size(104, 17);
            this.linkForgotPass.TabIndex = 1;
            this.linkForgotPass.TabStop = true;
            this.linkForgotPass.Text = "forgot password?";
            this.linkForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgotPass_LinkClicked);
            // 
            // btn_Login
            // 
            this.btn_Login.ActiveBorderThickness = 1;
            this.btn_Login.ActiveCornerRadius = 20;
            this.btn_Login.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.btn_Login.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btn_Login.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.btn_Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Login.BackgroundImage")));
            this.btn_Login.ButtonText = "Login";
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Login.IdleBorderThickness = 1;
            this.btn_Login.IdleCornerRadius = 20;
            this.btn_Login.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(77)))), ((int)(((byte)(156)))));
            this.btn_Login.IdleForecolor = System.Drawing.Color.Transparent;
            this.btn_Login.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(77)))), ((int)(((byte)(156)))));
            this.btn_Login.Location = new System.Drawing.Point(116, 416);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(182, 78);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox2.LineThickness = 3;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(67, 580);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(320, 52);
            this.bunifuMaterialTextbox2.TabIndex = 6;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_contributions
            // 
            this.lbl_contributions.AutoSize = true;
            this.lbl_contributions.BackColor = System.Drawing.Color.Transparent;
            this.lbl_contributions.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lbl_contributions.Location = new System.Drawing.Point(156, 156);
            this.lbl_contributions.Name = "lbl_contributions";
            this.lbl_contributions.Size = new System.Drawing.Size(107, 19);
            this.lbl_contributions.TabIndex = 4;
            this.lbl_contributions.Text = "Tracking System";
            // 
            // lbl_signin
            // 
            this.lbl_signin.AutoSize = true;
            this.lbl_signin.BackColor = System.Drawing.Color.Transparent;
            this.lbl_signin.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_signin.Location = new System.Drawing.Point(153, 119);
            this.lbl_signin.Name = "lbl_signin";
            this.lbl_signin.Size = new System.Drawing.Size(116, 37);
            this.lbl_signin.TabIndex = 1;
            this.lbl_signin.Text = "SIGN IN";
            // 
            // pb_Philhealth_icon
            // 
            this.pb_Philhealth_icon.BackColor = System.Drawing.Color.Transparent;
            this.pb_Philhealth_icon.Image = global::Contributions_Tracking_System.Properties.Resources.philhealth_logo;
            this.pb_Philhealth_icon.Location = new System.Drawing.Point(285, 21);
            this.pb_Philhealth_icon.Name = "pb_Philhealth_icon";
            this.pb_Philhealth_icon.Size = new System.Drawing.Size(64, 69);
            this.pb_Philhealth_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Philhealth_icon.TabIndex = 2;
            this.pb_Philhealth_icon.TabStop = false;
            // 
            // pb_Pagibig_icon
            // 
            this.pb_Pagibig_icon.BackColor = System.Drawing.Color.Transparent;
            this.pb_Pagibig_icon.Image = global::Contributions_Tracking_System.Properties.Resources.pag_ibig;
            this.pb_Pagibig_icon.Location = new System.Drawing.Point(173, 21);
            this.pb_Pagibig_icon.Name = "pb_Pagibig_icon";
            this.pb_Pagibig_icon.Size = new System.Drawing.Size(73, 69);
            this.pb_Pagibig_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Pagibig_icon.TabIndex = 1;
            this.pb_Pagibig_icon.TabStop = false;
            // 
            // pb_GSIS_icon
            // 
            this.pb_GSIS_icon.BackColor = System.Drawing.Color.Transparent;
            this.pb_GSIS_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_GSIS_icon.Image = global::Contributions_Tracking_System.Properties.Resources.GSIS;
            this.pb_GSIS_icon.Location = new System.Drawing.Point(78, 21);
            this.pb_GSIS_icon.Name = "pb_GSIS_icon";
            this.pb_GSIS_icon.Size = new System.Drawing.Size(57, 69);
            this.pb_GSIS_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_GSIS_icon.TabIndex = 0;
            this.pb_GSIS_icon.TabStop = false;
            // 
            // pb_Title
            // 
            this.pb_Title.BackgroundImage = global::Contributions_Tracking_System.Properties.Resources.background;
            this.pb_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Title.Controls.Add(this.pb_DSWD_logo);
            this.pb_Title.Location = new System.Drawing.Point(0, 63);
            this.pb_Title.Name = "pb_Title";
            this.pb_Title.Size = new System.Drawing.Size(901, 537);
            this.pb_Title.TabIndex = 0;
            // 
            // pb_DSWD_logo
            // 
            this.pb_DSWD_logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_DSWD_logo.Image = global::Contributions_Tracking_System.Properties.Resources.DSWD;
            this.pb_DSWD_logo.Location = new System.Drawing.Point(54, 74);
            this.pb_DSWD_logo.Name = "pb_DSWD_logo";
            this.pb_DSWD_logo.Size = new System.Drawing.Size(779, 291);
            this.pb_DSWD_logo.TabIndex = 0;
            this.pb_DSWD_logo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 600);
            this.Controls.Add(this.pb_Login);
            this.Controls.Add(this.pb_Title);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pb_Login.ResumeLayout(false);
            this.pb_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Philhealth_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pagibig_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GSIS_icon)).EndInit();
            this.pb_Title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_DSWD_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pb_Title;
        private System.Windows.Forms.Panel pb_Login;
        private System.Windows.Forms.PictureBox pb_DSWD_logo;
        private System.Windows.Forms.Label lbl_contributions;
        private System.Windows.Forms.Label lbl_signin;
        private System.Windows.Forms.PictureBox pb_Philhealth_icon;
        private System.Windows.Forms.PictureBox pb_Pagibig_icon;
        private System.Windows.Forms.PictureBox pb_GSIS_icon;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Login;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private Bunifu.Framework.UI.BunifuElipse elip_border;
        private Bunifu.Framework.UI.BunifuElipse elip_username;
        private Bunifu.Framework.UI.BunifuElipse elip_password;
        private System.Windows.Forms.LinkLabel linkForgotPass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Username;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Password;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

