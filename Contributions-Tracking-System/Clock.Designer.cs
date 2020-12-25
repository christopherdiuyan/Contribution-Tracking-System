namespace Contributions_Tracking_System
{
    partial class Clock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clock));
            this.panel10 = new System.Windows.Forms.Panel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Day = new System.Windows.Forms.Label();
            this.lbl_Hour = new System.Windows.Forms.Label();
            this.circularProgressBar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.lbl_Sec = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel10.Controls.Add(this.lbl_Sec);
            this.panel10.Controls.Add(this.lbl_Date);
            this.panel10.Controls.Add(this.lbl_Day);
            this.panel10.Controls.Add(this.lbl_Hour);
            this.panel10.Controls.Add(this.circularProgressBar);
            this.panel10.Location = new System.Drawing.Point(8, -14);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(225, 208);
            this.panel10.TabIndex = 2;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoEllipsis = true;
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.lbl_Date.Location = new System.Drawing.Point(67, 143);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(90, 21);
            this.lbl_Date.TabIndex = 12;
            this.lbl_Date.Text = "12/12/2020";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Day
            // 
            this.lbl_Day.AutoEllipsis = true;
            this.lbl_Day.AutoSize = true;
            this.lbl_Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Day.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.lbl_Day.Location = new System.Drawing.Point(69, 124);
            this.lbl_Day.Name = "lbl_Day";
            this.lbl_Day.Size = new System.Drawing.Size(71, 20);
            this.lbl_Day.TabIndex = 11;
            this.lbl_Day.Text = "Monday";
            this.lbl_Day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Hour
            // 
            this.lbl_Hour.AutoSize = true;
            this.lbl_Hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.lbl_Hour.Location = new System.Drawing.Point(38, 64);
            this.lbl_Hour.Name = "lbl_Hour";
            this.lbl_Hour.Size = new System.Drawing.Size(141, 52);
            this.lbl_Hour.TabIndex = 10;
            this.lbl_Hour.Text = "23:59";
            // 
            // circularProgressBar
            // 
            this.circularProgressBar.animated = false;
            this.circularProgressBar.animationIterval = 5;
            this.circularProgressBar.animationSpeed = 300;
            this.circularProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.circularProgressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circularProgressBar.BackgroundImage")));
            this.circularProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.circularProgressBar.ForeColor = System.Drawing.Color.Transparent;
            this.circularProgressBar.LabelVisible = false;
            this.circularProgressBar.LineProgressThickness = 8;
            this.circularProgressBar.LineThickness = 5;
            this.circularProgressBar.Location = new System.Drawing.Point(14, 8);
            this.circularProgressBar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.circularProgressBar.MaxValue = 100;
            this.circularProgressBar.Name = "circularProgressBar";
            this.circularProgressBar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.circularProgressBar.ProgressColor = System.Drawing.Color.SeaGreen;
            this.circularProgressBar.Size = new System.Drawing.Size(187, 187);
            this.circularProgressBar.TabIndex = 9;
            this.circularProgressBar.Value = 0;
            // 
            // lbl_Sec
            // 
            this.lbl_Sec.AutoSize = true;
            this.lbl_Sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.lbl_Sec.Location = new System.Drawing.Point(92, 29);
            this.lbl_Sec.Name = "lbl_Sec";
            this.lbl_Sec.Size = new System.Drawing.Size(32, 24);
            this.lbl_Sec.TabIndex = 13;
            this.lbl_Sec.Text = "59";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.Controls.Add(this.panel10);
            this.Name = "Clock";
            this.Size = new System.Drawing.Size(240, 181);
            this.Load += new System.EventHandler(this.Clock_Load);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Day;
        private System.Windows.Forms.Label lbl_Hour;
        private Bunifu.Framework.UI.BunifuCircleProgressbar circularProgressBar;
        private System.Windows.Forms.Label lbl_Sec;
        private System.Windows.Forms.Timer timer1;
    }
}
