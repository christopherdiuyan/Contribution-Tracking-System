namespace Contributions_Tracking_System
{
    partial class TimeZone
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
            this.lbl_Sec = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Day = new System.Windows.Forms.Label();
            this.lbl_Hour = new System.Windows.Forms.Label();
            this.lbl_Timezone = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Sec
            // 
            this.lbl_Sec.AutoSize = true;
            this.lbl_Sec.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.lbl_Sec.Location = new System.Drawing.Point(9, 0);
            this.lbl_Sec.Name = "lbl_Sec";
            this.lbl_Sec.Size = new System.Drawing.Size(28, 21);
            this.lbl_Sec.TabIndex = 17;
            this.lbl_Sec.Text = "59";
            this.lbl_Sec.Visible = false;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoEllipsis = true;
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.lbl_Date.Location = new System.Drawing.Point(61, 12);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(110, 25);
            this.lbl_Date.TabIndex = 16;
            this.lbl_Date.Text = "12/12/2020";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Day
            // 
            this.lbl_Day.AutoEllipsis = true;
            this.lbl_Day.AutoSize = true;
            this.lbl_Day.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Day.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.lbl_Day.Location = new System.Drawing.Point(33, 0);
            this.lbl_Day.Name = "lbl_Day";
            this.lbl_Day.Size = new System.Drawing.Size(90, 25);
            this.lbl_Day.TabIndex = 15;
            this.lbl_Day.Text = "Thursday";
            this.lbl_Day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Day.Visible = false;
            // 
            // lbl_Hour
            // 
            this.lbl_Hour.AutoSize = true;
            this.lbl_Hour.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Hour.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Hour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.lbl_Hour.Location = new System.Drawing.Point(233, 12);
            this.lbl_Hour.Name = "lbl_Hour";
            this.lbl_Hour.Size = new System.Drawing.Size(61, 25);
            this.lbl_Hour.TabIndex = 14;
            this.lbl_Hour.Text = "23:59";
            // 
            // lbl_Timezone
            // 
            this.lbl_Timezone.AutoSize = true;
            this.lbl_Timezone.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Timezone.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Timezone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.lbl_Timezone.Location = new System.Drawing.Point(289, 12);
            this.lbl_Timezone.Name = "lbl_Timezone";
            this.lbl_Timezone.Size = new System.Drawing.Size(43, 25);
            this.lbl_Timezone.TabIndex = 18;
            this.lbl_Timezone.Text = "AM";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Date:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.label2.Location = new System.Drawing.Point(177, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Time:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Hour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Sec);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Day);
            this.Controls.Add(this.lbl_Timezone);
            this.Name = "TimeZone";
            this.Size = new System.Drawing.Size(333, 47);
            this.Load += new System.EventHandler(this.TimeZone_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Sec;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Day;
        private System.Windows.Forms.Label lbl_Hour;
        private System.Windows.Forms.Label lbl_Timezone;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
