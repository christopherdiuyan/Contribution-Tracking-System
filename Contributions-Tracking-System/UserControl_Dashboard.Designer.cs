namespace Contributions_Tracking_System
{
    partial class UserControl_Dashboard
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.p_logo = new System.Windows.Forms.Panel();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.timeZone1 = new Contributions_Tracking_System.TimeZone();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelRegular = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.p_Regular = new System.Windows.Forms.Panel();
            this.circularProgressBar_Contractual = new CircularProgressBar.CircularProgressBar();
            this.panelContractual = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.p_Contractual = new System.Windows.Forms.Panel();
            this.circularProgressBar_Regular = new CircularProgressBar.CircularProgressBar();
            this.panelTotalEmployees = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.p_TotalEmployee = new System.Windows.Forms.Panel();
            this.circularProgressBar_TotalEmployees = new CircularProgressBar.CircularProgressBar();
            this.p_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelRegular.SuspendLayout();
            this.panel8.SuspendLayout();
            this.p_Regular.SuspendLayout();
            this.panelContractual.SuspendLayout();
            this.panel5.SuspendLayout();
            this.p_Contractual.SuspendLayout();
            this.panelTotalEmployees.SuspendLayout();
            this.panel2.SuspendLayout();
            this.p_TotalEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.p_Contractual;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.p_Regular;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this.p_TotalEmployee;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 20;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 20;
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 20;
            // 
            // p_logo
            // 
            this.p_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.p_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.p_logo.Controls.Add(this.panel1);
            this.p_logo.Controls.Add(this.timeZone1);
            this.p_logo.Controls.Add(this.pb_logo);
            this.p_logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_logo.Location = new System.Drawing.Point(0, 0);
            this.p_logo.Name = "p_logo";
            this.p_logo.Size = new System.Drawing.Size(1099, 637);
            this.p_logo.TabIndex = 3;
            this.p_logo.Paint += new System.Windows.Forms.PaintEventHandler(this.p_logo_Paint);
            // 
            // pb_logo
            // 
            this.pb_logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_logo.Image = global::Contributions_Tracking_System.Properties.Resources.DSWD;
            this.pb_logo.Location = new System.Drawing.Point(119, 67);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(857, 287);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 0;
            this.pb_logo.TabStop = false;
            // 
            // timeZone1
            // 
            this.timeZone1.Location = new System.Drawing.Point(753, 3);
            this.timeZone1.Name = "timeZone1";
            this.timeZone1.Size = new System.Drawing.Size(333, 47);
            this.timeZone1.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panelRegular);
            this.panel1.Controls.Add(this.panelContractual);
            this.panel1.Controls.Add(this.panelTotalEmployees);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 268);
            this.panel1.TabIndex = 15;
            // 
            // panelRegular
            // 
            this.panelRegular.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelRegular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(77)))), ((int)(((byte)(156)))));
            this.panelRegular.Controls.Add(this.panel8);
            this.panelRegular.Controls.Add(this.p_Regular);
            this.panelRegular.Location = new System.Drawing.Point(681, 19);
            this.panelRegular.Name = "panelRegular";
            this.panelRegular.Size = new System.Drawing.Size(201, 234);
            this.panelRegular.TabIndex = 16;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(0, 196);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(211, 38);
            this.panel8.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(10, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Contractual Employees";
            // 
            // p_Regular
            // 
            this.p_Regular.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.p_Regular.BackColor = System.Drawing.Color.White;
            this.p_Regular.Controls.Add(this.circularProgressBar_Contractual);
            this.p_Regular.Location = new System.Drawing.Point(7, 7);
            this.p_Regular.Name = "p_Regular";
            this.p_Regular.Size = new System.Drawing.Size(185, 210);
            this.p_Regular.TabIndex = 2;
            // 
            // circularProgressBar_Contractual
            // 
            this.circularProgressBar_Contractual.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar_Contractual.AnimationSpeed = 500;
            this.circularProgressBar_Contractual.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar_Contractual.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar_Contractual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar_Contractual.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar_Contractual.InnerMargin = 1;
            this.circularProgressBar_Contractual.InnerWidth = -1;
            this.circularProgressBar_Contractual.Location = new System.Drawing.Point(2, 5);
            this.circularProgressBar_Contractual.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar_Contractual.Name = "circularProgressBar_Contractual";
            this.circularProgressBar_Contractual.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar_Contractual.OuterMargin = -15;
            this.circularProgressBar_Contractual.OuterWidth = 5;
            this.circularProgressBar_Contractual.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.circularProgressBar_Contractual.ProgressWidth = 15;
            this.circularProgressBar_Contractual.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar_Contractual.Size = new System.Drawing.Size(180, 180);
            this.circularProgressBar_Contractual.StartAngle = 270;
            this.circularProgressBar_Contractual.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar_Contractual.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar_Contractual.SubscriptText = "";
            this.circularProgressBar_Contractual.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar_Contractual.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar_Contractual.SuperscriptText = "";
            this.circularProgressBar_Contractual.TabIndex = 12;
            this.circularProgressBar_Contractual.Text = "99999";
            this.circularProgressBar_Contractual.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar_Contractual.Value = 66;
            // 
            // panelContractual
            // 
            this.panelContractual.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelContractual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(77)))), ((int)(((byte)(156)))));
            this.panelContractual.Controls.Add(this.panel5);
            this.panelContractual.Controls.Add(this.p_Contractual);
            this.panelContractual.Location = new System.Drawing.Point(450, 19);
            this.panelContractual.Name = "panelContractual";
            this.panelContractual.Size = new System.Drawing.Size(201, 234);
            this.panelContractual.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(0, 196);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(211, 38);
            this.panel5.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Regular Employees";
            // 
            // p_Contractual
            // 
            this.p_Contractual.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.p_Contractual.BackColor = System.Drawing.Color.White;
            this.p_Contractual.Controls.Add(this.circularProgressBar_Regular);
            this.p_Contractual.Location = new System.Drawing.Point(7, 7);
            this.p_Contractual.Name = "p_Contractual";
            this.p_Contractual.Size = new System.Drawing.Size(185, 210);
            this.p_Contractual.TabIndex = 2;
            // 
            // circularProgressBar_Regular
            // 
            this.circularProgressBar_Regular.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar_Regular.AnimationSpeed = 500;
            this.circularProgressBar_Regular.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar_Regular.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar_Regular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar_Regular.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar_Regular.InnerMargin = 1;
            this.circularProgressBar_Regular.InnerWidth = -1;
            this.circularProgressBar_Regular.Location = new System.Drawing.Point(2, 5);
            this.circularProgressBar_Regular.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar_Regular.Name = "circularProgressBar_Regular";
            this.circularProgressBar_Regular.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar_Regular.OuterMargin = -15;
            this.circularProgressBar_Regular.OuterWidth = 5;
            this.circularProgressBar_Regular.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(61)))));
            this.circularProgressBar_Regular.ProgressWidth = 15;
            this.circularProgressBar_Regular.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar_Regular.Size = new System.Drawing.Size(180, 180);
            this.circularProgressBar_Regular.StartAngle = 270;
            this.circularProgressBar_Regular.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar_Regular.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar_Regular.SubscriptText = "";
            this.circularProgressBar_Regular.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar_Regular.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar_Regular.SuperscriptText = "";
            this.circularProgressBar_Regular.TabIndex = 12;
            this.circularProgressBar_Regular.Text = "99999";
            this.circularProgressBar_Regular.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar_Regular.Value = 66;
            // 
            // panelTotalEmployees
            // 
            this.panelTotalEmployees.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelTotalEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(77)))), ((int)(((byte)(156)))));
            this.panelTotalEmployees.Controls.Add(this.panel2);
            this.panelTotalEmployees.Controls.Add(this.p_TotalEmployee);
            this.panelTotalEmployees.Location = new System.Drawing.Point(216, 19);
            this.panelTotalEmployees.Name = "panelTotalEmployees";
            this.panelTotalEmployees.Size = new System.Drawing.Size(201, 234);
            this.panelTotalEmployees.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 38);
            this.panel2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(35, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Employees";
            // 
            // p_TotalEmployee
            // 
            this.p_TotalEmployee.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.p_TotalEmployee.BackColor = System.Drawing.Color.White;
            this.p_TotalEmployee.Controls.Add(this.circularProgressBar_TotalEmployees);
            this.p_TotalEmployee.Location = new System.Drawing.Point(7, 7);
            this.p_TotalEmployee.Name = "p_TotalEmployee";
            this.p_TotalEmployee.Size = new System.Drawing.Size(185, 210);
            this.p_TotalEmployee.TabIndex = 2;
            // 
            // circularProgressBar_TotalEmployees
            // 
            this.circularProgressBar_TotalEmployees.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar_TotalEmployees.AnimationSpeed = 500;
            this.circularProgressBar_TotalEmployees.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar_TotalEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar_TotalEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar_TotalEmployees.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar_TotalEmployees.InnerMargin = 1;
            this.circularProgressBar_TotalEmployees.InnerWidth = -1;
            this.circularProgressBar_TotalEmployees.Location = new System.Drawing.Point(2, 5);
            this.circularProgressBar_TotalEmployees.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar_TotalEmployees.Name = "circularProgressBar_TotalEmployees";
            this.circularProgressBar_TotalEmployees.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar_TotalEmployees.OuterMargin = -15;
            this.circularProgressBar_TotalEmployees.OuterWidth = 5;
            this.circularProgressBar_TotalEmployees.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(77)))), ((int)(((byte)(156)))));
            this.circularProgressBar_TotalEmployees.ProgressWidth = 15;
            this.circularProgressBar_TotalEmployees.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar_TotalEmployees.Size = new System.Drawing.Size(180, 180);
            this.circularProgressBar_TotalEmployees.StartAngle = 270;
            this.circularProgressBar_TotalEmployees.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar_TotalEmployees.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar_TotalEmployees.SubscriptText = "";
            this.circularProgressBar_TotalEmployees.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar_TotalEmployees.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar_TotalEmployees.SuperscriptText = "";
            this.circularProgressBar_TotalEmployees.TabIndex = 12;
            this.circularProgressBar_TotalEmployees.Text = "99999";
            this.circularProgressBar_TotalEmployees.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar_TotalEmployees.Value = 66;
            // 
            // UserControl_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(144)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.p_logo);
            this.DoubleBuffered = true;
            this.Name = "UserControl_Dashboard";
            this.Size = new System.Drawing.Size(1099, 637);
            this.Load += new System.EventHandler(this.UserControl_Dashboard_Load);
            this.p_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelRegular.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.p_Regular.ResumeLayout(false);
            this.panelContractual.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.p_Contractual.ResumeLayout(false);
            this.panelTotalEmployees.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.p_TotalEmployee.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Panel p_logo;
        private TimeZone timeZone1;
        private System.Windows.Forms.Panel p_Contractual;
        public CircularProgressBar.CircularProgressBar circularProgressBar_Regular;
        private System.Windows.Forms.Panel p_Regular;
        public CircularProgressBar.CircularProgressBar circularProgressBar_Contractual;
        private System.Windows.Forms.Panel p_TotalEmployee;
        public CircularProgressBar.CircularProgressBar circularProgressBar_TotalEmployees;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelRegular;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelContractual;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelTotalEmployees;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
    }
}
