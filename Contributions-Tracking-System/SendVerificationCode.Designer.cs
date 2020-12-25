namespace Contributions_Tracking_System
{
    partial class SendVerificationCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendVerificationCode));
            this.lbl_Email = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Continue = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_Code = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lbl_ErrorMessage_Code = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userControl_ForgotPassword1 = new Contributions_Tracking_System.UserControl_ForgotPassword();
            this.SuspendLayout();
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lbl_Email.Location = new System.Drawing.Point(77, 82);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(172, 25);
            this.lbl_Email.TabIndex = 105;
            this.lbl_Email.Text = "sample@gmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 104;
            this.label3.Text = "Email: ";
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
            this.btn_Continue.Location = new System.Drawing.Point(191, 233);
            this.btn_Continue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(113, 55);
            this.btn_Continue.TabIndex = 112;
            this.btn_Continue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Continue.Click += new System.EventHandler(this.btn_Continue_Click);
            // 
            // txt_Code
            // 
            this.txt_Code.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(117)))), ((int)(((byte)(137)))));
            this.txt_Code.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Code.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(117)))), ((int)(((byte)(137)))));
            this.txt_Code.BorderThickness = 2;
            this.txt_Code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Code.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Code.isPassword = false;
            this.txt_Code.Location = new System.Drawing.Point(15, 140);
            this.txt_Code.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(474, 44);
            this.txt_Code.TabIndex = 113;
            this.txt_Code.Text = "Enter Code";
            this.txt_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.label1.Location = new System.Drawing.Point(16, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 15);
            this.label1.TabIndex = 114;
            this.label1.Text = "Please check your email for a message with your code. Your code is 6 numbers long" +
    ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 35);
            this.label2.TabIndex = 115;
            this.label2.Text = "Enter Security Code";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 23);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(500, 35);
            this.bunifuSeparator1.TabIndex = 116;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(-3, 206);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(500, 35);
            this.bunifuSeparator2.TabIndex = 117;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            this.bunifuSeparator2.Load += new System.EventHandler(this.bunifuSeparator2_Load);
            // 
            // lbl_ErrorMessage_Code
            // 
            this.lbl_ErrorMessage_Code.AutoSize = true;
            this.lbl_ErrorMessage_Code.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ErrorMessage_Code.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Italic);
            this.lbl_ErrorMessage_Code.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorMessage_Code.Location = new System.Drawing.Point(18, 188);
            this.lbl_ErrorMessage_Code.Name = "lbl_ErrorMessage_Code";
            this.lbl_ErrorMessage_Code.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ErrorMessage_Code.Size = new System.Drawing.Size(359, 15);
            this.lbl_ErrorMessage_Code.TabIndex = 118;
            this.lbl_ErrorMessage_Code.Text = "The number you entered doesn’t match your code. Please try again.";
            this.lbl_ErrorMessage_Code.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_ErrorMessage_Code.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 25);
            this.label4.TabIndex = 119;
            this.label4.Text = "We sent your code to:";
            // 
            // userControl_ForgotPassword1
            // 
            this.userControl_ForgotPassword1.BackColor = System.Drawing.SystemColors.Control;
            this.userControl_ForgotPassword1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_ForgotPassword1.Location = new System.Drawing.Point(0, 0);
            this.userControl_ForgotPassword1.Name = "userControl_ForgotPassword1";
            this.userControl_ForgotPassword1.Size = new System.Drawing.Size(500, 298);
            this.userControl_ForgotPassword1.TabIndex = 120;
            this.userControl_ForgotPassword1.Visible = false;
            this.userControl_ForgotPassword1.Load += new System.EventHandler(this.userControl_ForgotPassword1_Load);
            // 
            // SendVerificationCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_ErrorMessage_Code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Code);
            this.Controls.Add(this.btn_Continue);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.userControl_ForgotPassword1);
            this.Name = "SendVerificationCode";
            this.Size = new System.Drawing.Size(500, 298);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Continue;
        public System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label label3;
        public Bunifu.Framework.UI.BunifuMetroTextbox txt_Code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label lbl_ErrorMessage_Code;
        public System.Windows.Forms.Label label4;
        private UserControl_ForgotPassword userControl_ForgotPassword1;
    }
}
