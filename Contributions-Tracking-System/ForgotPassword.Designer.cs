namespace Contributions_Tracking_System
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_ErrorMessage_Email = new System.Windows.Forms.Label();
            this.userControl_ForgotPassword1 = new Contributions_Tracking_System.UserControl_ForgotPassword();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Reset = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Email = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.panel1.Controls.Add(this.userControl_ForgotPassword1);
            this.panel1.Controls.Add(this.lbl_ErrorMessage_Email);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Reset);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txt_Email);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 298);
            this.panel1.TabIndex = 0;
            // 
            // lbl_ErrorMessage_Email
            // 
            this.lbl_ErrorMessage_Email.AutoSize = true;
            this.lbl_ErrorMessage_Email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ErrorMessage_Email.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Italic);
            this.lbl_ErrorMessage_Email.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorMessage_Email.Location = new System.Drawing.Point(12, 199);
            this.lbl_ErrorMessage_Email.Name = "lbl_ErrorMessage_Email";
            this.lbl_ErrorMessage_Email.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ErrorMessage_Email.Size = new System.Drawing.Size(115, 15);
            this.lbl_ErrorMessage_Email.TabIndex = 28;
            this.lbl_ErrorMessage_Email.Text = "This field is required.";
            this.lbl_ErrorMessage_Email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_ErrorMessage_Email.Visible = false;
            // 
            // userControl_ForgotPassword1
            // 
            this.userControl_ForgotPassword1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.userControl_ForgotPassword1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_ForgotPassword1.Location = new System.Drawing.Point(0, 0);
            this.userControl_ForgotPassword1.Name = "userControl_ForgotPassword1";
            this.userControl_ForgotPassword1.Size = new System.Drawing.Size(500, 298);
            this.userControl_ForgotPassword1.TabIndex = 6;
            this.userControl_ForgotPassword1.Visible = false;
            this.userControl_ForgotPassword1.Load += new System.EventHandler(this.userControl_ForgotPassword1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reset Password";
            // 
            // btn_Reset
            // 
            this.btn_Reset.ActiveBorderThickness = 1;
            this.btn_Reset.ActiveCornerRadius = 20;
            this.btn_Reset.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(117)))), ((int)(((byte)(137)))));
            this.btn_Reset.ActiveForecolor = System.Drawing.Color.Black;
            this.btn_Reset.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(117)))), ((int)(((byte)(137)))));
            this.btn_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.btn_Reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Reset.BackgroundImage")));
            this.btn_Reset.ButtonText = "Reset";
            this.btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.btn_Reset.IdleBorderThickness = 1;
            this.btn_Reset.IdleCornerRadius = 20;
            this.btn_Reset.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(77)))), ((int)(((byte)(156)))));
            this.btn_Reset.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.btn_Reset.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(77)))), ((int)(((byte)(156)))));
            this.btn_Reset.Location = new System.Drawing.Point(181, 212);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(133, 64);
            this.btn_Reset.TabIndex = 5;
            this.btn_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Contributions_Tracking_System.Properties.Resources.DSWD;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(123, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Email
            // 
            this.txt_Email.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(117)))), ((int)(((byte)(137)))));
            this.txt_Email.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Email.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(117)))), ((int)(((byte)(137)))));
            this.txt_Email.BorderThickness = 3;
            this.txt_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Email.isPassword = false;
            this.txt_Email.Location = new System.Drawing.Point(13, 151);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(474, 44);
            this.txt_Email.TabIndex = 99;
            this.txt_Email.Text = "Email";
            this.txt_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Email.Enter += new System.EventHandler(this.txt_Email_Enter);
            this.txt_Email.Leave += new System.EventHandler(this.txt_Email_Leave);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 298);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Reset;
        private System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuMetroTextbox txt_Email;
        private System.Windows.Forms.Label lbl_ErrorMessage_Email;
        public UserControl_ForgotPassword userControl_ForgotPassword1;
    }
}