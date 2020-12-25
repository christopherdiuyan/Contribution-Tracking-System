namespace Contributions_Tracking_System
{
    partial class ForgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPassword));
            this.lbl_ErrorMessage_Email = new System.Windows.Forms.Label();
            this.txt_Email = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Cancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Search = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.sendVerificationCode1 = new Contributions_Tracking_System.SendVerificationCode();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ErrorMessage_Email
            // 
            this.lbl_ErrorMessage_Email.AutoSize = true;
            this.lbl_ErrorMessage_Email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ErrorMessage_Email.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Italic);
            this.lbl_ErrorMessage_Email.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorMessage_Email.Location = new System.Drawing.Point(12, 185);
            this.lbl_ErrorMessage_Email.Name = "lbl_ErrorMessage_Email";
            this.lbl_ErrorMessage_Email.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ErrorMessage_Email.Size = new System.Drawing.Size(115, 15);
            this.lbl_ErrorMessage_Email.TabIndex = 100;
            this.lbl_ErrorMessage_Email.Text = "This field is required.";
            this.lbl_ErrorMessage_Email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_ErrorMessage_Email.Visible = false;
            // 
            // txt_Email
            // 
            this.txt_Email.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(117)))), ((int)(((byte)(137)))));
            this.txt_Email.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Email.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(117)))), ((int)(((byte)(137)))));
            this.txt_Email.BorderThickness = 2;
            this.txt_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Email.isPassword = false;
            this.txt_Email.Location = new System.Drawing.Point(13, 137);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(474, 44);
            this.txt_Email.TabIndex = 101;
            this.txt_Email.Text = "Email*";
            this.txt_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Email.Enter += new System.EventHandler(this.txt_Email_Enter);
            this.txt_Email.Leave += new System.EventHandler(this.txt_Email_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(13, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 17);
            this.label1.TabIndex = 102;
            this.label1.Text = "Please enter your e-mail addres to search for your account.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Contributions_Tracking_System.Properties.Resources.DSWD;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(112, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.ActiveBorderThickness = 1;
            this.btn_Cancel.ActiveCornerRadius = 20;
            this.btn_Cancel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(117)))), ((int)(((byte)(137)))));
            this.btn_Cancel.ActiveForecolor = System.Drawing.Color.Black;
            this.btn_Cancel.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(117)))), ((int)(((byte)(137)))));
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.BackgroundImage")));
            this.btn_Cancel.ButtonText = "Cancel";
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.btn_Cancel.IdleBorderThickness = 1;
            this.btn_Cancel.IdleCornerRadius = 20;
            this.btn_Cancel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.btn_Cancel.IdleForecolor = System.Drawing.Color.Black;
            this.btn_Cancel.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.btn_Cancel.Location = new System.Drawing.Point(387, 235);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(100, 50);
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Search
            // 
            this.btn_Search.ActiveBorderThickness = 1;
            this.btn_Search.ActiveCornerRadius = 20;
            this.btn_Search.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(117)))), ((int)(((byte)(137)))));
            this.btn_Search.ActiveForecolor = System.Drawing.Color.Black;
            this.btn_Search.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(117)))), ((int)(((byte)(137)))));
            this.btn_Search.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Search.BackgroundImage")));
            this.btn_Search.ButtonText = "Search";
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.btn_Search.IdleBorderThickness = 1;
            this.btn_Search.IdleCornerRadius = 20;
            this.btn_Search.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(77)))), ((int)(((byte)(156)))));
            this.btn_Search.IdleForecolor = System.Drawing.Color.White;
            this.btn_Search.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(77)))), ((int)(((byte)(156)))));
            this.btn_Search.Location = new System.Drawing.Point(279, 235);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(100, 50);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 203);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(500, 35);
            this.bunifuSeparator2.TabIndex = 118;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // sendVerificationCode1
            // 
            this.sendVerificationCode1.BackColor = System.Drawing.SystemColors.Control;
            this.sendVerificationCode1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendVerificationCode1.Location = new System.Drawing.Point(0, 0);
            this.sendVerificationCode1.Name = "sendVerificationCode1";
            this.sendVerificationCode1.Size = new System.Drawing.Size(500, 298);
            this.sendVerificationCode1.TabIndex = 106;
            this.sendVerificationCode1.Visible = false;
            this.sendVerificationCode1.Load += new System.EventHandler(this.sendVerificationCode1_Load);
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(500, 298);
            this.Controls.Add(this.sendVerificationCode1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ErrorMessage_Email);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.bunifuSeparator2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reset Your Password";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ErrorMessage_Email;
        public Bunifu.Framework.UI.BunifuMetroTextbox txt_Email;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Search;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Cancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SendVerificationCode sendVerificationCode1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
    }
}