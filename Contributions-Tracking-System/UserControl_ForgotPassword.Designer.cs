namespace Contributions_Tracking_System
{
    partial class UserControl_ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_ForgotPassword));
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_ErrorMessage_ConfirmPassword = new System.Windows.Forms.Label();
            this.checkBox_NewPassword = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btn_Continue = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txt_NewPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_ConfirmPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbl_ErrorMessage_NewPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(20, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "New Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(20, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirm Password:";
            // 
            // lbl_ErrorMessage_ConfirmPassword
            // 
            this.lbl_ErrorMessage_ConfirmPassword.AutoSize = true;
            this.lbl_ErrorMessage_ConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ErrorMessage_ConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Italic);
            this.lbl_ErrorMessage_ConfirmPassword.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorMessage_ConfirmPassword.Location = new System.Drawing.Point(300, 186);
            this.lbl_ErrorMessage_ConfirmPassword.Name = "lbl_ErrorMessage_ConfirmPassword";
            this.lbl_ErrorMessage_ConfirmPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ErrorMessage_ConfirmPassword.Size = new System.Drawing.Size(221, 15);
            this.lbl_ErrorMessage_ConfirmPassword.TabIndex = 28;
            this.lbl_ErrorMessage_ConfirmPassword.Text = "Those passwords didn\'t match. Try again";
            this.lbl_ErrorMessage_ConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_ErrorMessage_ConfirmPassword.Visible = false;
            // 
            // checkBox_NewPassword
            // 
            this.checkBox_NewPassword.AutoSize = true;
            this.checkBox_NewPassword.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_NewPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_NewPassword.ForeColor = System.Drawing.Color.Black;
            this.checkBox_NewPassword.Location = new System.Drawing.Point(217, 182);
            this.checkBox_NewPassword.Name = "checkBox_NewPassword";
            this.checkBox_NewPassword.Size = new System.Drawing.Size(65, 24);
            this.checkBox_NewPassword.TabIndex = 103;
            this.checkBox_NewPassword.Text = "Show";
            this.checkBox_NewPassword.UseVisualStyleBackColor = false;
            this.checkBox_NewPassword.CheckedChanged += new System.EventHandler(this.checkBox_NewPassword_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 35);
            this.label1.TabIndex = 117;
            this.label1.Text = "Reset Your Password";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 21);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(500, 35);
            this.bunifuSeparator1.TabIndex = 118;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btn_Continue
            // 
            this.btn_Continue.ActiveBorderThickness = 1;
            this.btn_Continue.ActiveCornerRadius = 20;
            this.btn_Continue.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(117)))), ((int)(((byte)(137)))));
            this.btn_Continue.ActiveForecolor = System.Drawing.Color.Black;
            this.btn_Continue.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(117)))), ((int)(((byte)(137)))));
            this.btn_Continue.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Continue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Continue.BackgroundImage")));
            this.btn_Continue.ButtonText = "Continue";
            this.btn_Continue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Continue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Continue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.btn_Continue.IdleBorderThickness = 1;
            this.btn_Continue.IdleCornerRadius = 20;
            this.btn_Continue.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(77)))), ((int)(((byte)(156)))));
            this.btn_Continue.IdleForecolor = System.Drawing.Color.Transparent;
            this.btn_Continue.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(77)))), ((int)(((byte)(156)))));
            this.btn_Continue.Location = new System.Drawing.Point(197, 235);
            this.btn_Continue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(113, 55);
            this.btn_Continue.TabIndex = 119;
            this.btn_Continue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Continue.Click += new System.EventHandler(this.btn_Continue_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 205);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(500, 35);
            this.bunifuSeparator2.TabIndex = 120;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // txt_NewPassword
            // 
            this.txt_NewPassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(117)))), ((int)(((byte)(137)))));
            this.txt_NewPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_NewPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(117)))), ((int)(((byte)(137)))));
            this.txt_NewPassword.BorderThickness = 1;
            this.txt_NewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NewPassword.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_NewPassword.isPassword = true;
            this.txt_NewPassword.Location = new System.Drawing.Point(217, 61);
            this.txt_NewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NewPassword.Name = "txt_NewPassword";
            this.txt_NewPassword.Size = new System.Drawing.Size(252, 44);
            this.txt_NewPassword.TabIndex = 121;
            this.txt_NewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(117)))), ((int)(((byte)(137)))));
            this.txt_ConfirmPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ConfirmPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(117)))), ((int)(((byte)(137)))));
            this.txt_ConfirmPassword.BorderThickness = 1;
            this.txt_ConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ConfirmPassword.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ConfirmPassword.isPassword = true;
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(218, 138);
            this.txt_ConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.Size = new System.Drawing.Size(252, 44);
            this.txt_ConfirmPassword.TabIndex = 122;
            this.txt_ConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_ErrorMessage_NewPassword
            // 
            this.lbl_ErrorMessage_NewPassword.AutoSize = true;
            this.lbl_ErrorMessage_NewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ErrorMessage_NewPassword.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Italic);
            this.lbl_ErrorMessage_NewPassword.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorMessage_NewPassword.Location = new System.Drawing.Point(339, 107);
            this.lbl_ErrorMessage_NewPassword.Name = "lbl_ErrorMessage_NewPassword";
            this.lbl_ErrorMessage_NewPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ErrorMessage_NewPassword.Size = new System.Drawing.Size(132, 15);
            this.lbl_ErrorMessage_NewPassword.TabIndex = 27;
            this.lbl_ErrorMessage_NewPassword.Text = "               Enter password";
            this.lbl_ErrorMessage_NewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_ErrorMessage_NewPassword.Visible = false;
            // 
            // UserControl_ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lbl_ErrorMessage_ConfirmPassword);
            this.Controls.Add(this.txt_ConfirmPassword);
            this.Controls.Add(this.txt_NewPassword);
            this.Controls.Add(this.btn_Continue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.checkBox_NewPassword);
            this.Controls.Add(this.lbl_ErrorMessage_NewPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuSeparator2);
            this.DoubleBuffered = true;
            this.Name = "UserControl_ForgotPassword";
            this.Size = new System.Drawing.Size(500, 298);
            this.Load += new System.EventHandler(this.UserControl_ForgotPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_ErrorMessage_ConfirmPassword;
        private System.Windows.Forms.CheckBox checkBox_NewPassword;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Continue;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        public Bunifu.Framework.UI.BunifuMetroTextbox txt_NewPassword;
        public Bunifu.Framework.UI.BunifuMetroTextbox txt_ConfirmPassword;
        private System.Windows.Forms.Label lbl_ErrorMessage_NewPassword;
    }
}
