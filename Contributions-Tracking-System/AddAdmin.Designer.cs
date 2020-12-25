namespace Contributions_Tracking_System
{
    partial class AddAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAdmin));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.p_AddAdmin = new System.Windows.Forms.Panel();
            this.btn_Close = new Bunifu.Framework.UI.BunifuTileButton();
            this.p_Content = new System.Windows.Forms.Panel();
            this.lbl_ErrorMessage_Department = new System.Windows.Forms.Label();
            this.lbl_ErrorMessage_ReTypePassword = new System.Windows.Forms.Label();
            this.lbl_ErrorMessage_TypePassword = new System.Windows.Forms.Label();
            this.lbl_ErrorMessage_Username = new System.Windows.Forms.Label();
            this.lbl_ErrorMessage_LastName = new System.Windows.Forms.Label();
            this.lbl_ErrorMessage_FirstName = new System.Windows.Forms.Label();
            this.lbl_ErrorMessage_EmployeeID = new System.Windows.Forms.Label();
            this.txt_LastName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_FirstName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_EmployeeID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Username = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_ReTypePassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_TypePassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cb_Department = new Bunifu.Framework.UI.BunifuDropdown();
            this.btn_Next = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.p_AddAdmin.SuspendLayout();
            this.p_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // p_AddAdmin
            // 
            this.p_AddAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.p_AddAdmin.Controls.Add(this.btn_Close);
            this.p_AddAdmin.Controls.Add(this.p_Content);
            this.p_AddAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_AddAdmin.Location = new System.Drawing.Point(0, 0);
            this.p_AddAdmin.Name = "p_AddAdmin";
            this.p_AddAdmin.Size = new System.Drawing.Size(451, 631);
            this.p_AddAdmin.TabIndex = 0;
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
            this.btn_Close.Location = new System.Drawing.Point(422, 4);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(20, 20);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // p_Content
            // 
            this.p_Content.BackColor = System.Drawing.Color.White;
            this.p_Content.Controls.Add(this.lbl_ErrorMessage_Department);
            this.p_Content.Controls.Add(this.lbl_ErrorMessage_ReTypePassword);
            this.p_Content.Controls.Add(this.lbl_ErrorMessage_TypePassword);
            this.p_Content.Controls.Add(this.lbl_ErrorMessage_Username);
            this.p_Content.Controls.Add(this.lbl_ErrorMessage_LastName);
            this.p_Content.Controls.Add(this.lbl_ErrorMessage_FirstName);
            this.p_Content.Controls.Add(this.lbl_ErrorMessage_EmployeeID);
            this.p_Content.Controls.Add(this.txt_LastName);
            this.p_Content.Controls.Add(this.label9);
            this.p_Content.Controls.Add(this.txt_FirstName);
            this.p_Content.Controls.Add(this.label8);
            this.p_Content.Controls.Add(this.txt_EmployeeID);
            this.p_Content.Controls.Add(this.txt_Username);
            this.p_Content.Controls.Add(this.txt_ReTypePassword);
            this.p_Content.Controls.Add(this.txt_TypePassword);
            this.p_Content.Controls.Add(this.bunifuMetroTextbox1);
            this.p_Content.Controls.Add(this.cb_Department);
            this.p_Content.Controls.Add(this.btn_Next);
            this.p_Content.Controls.Add(this.label7);
            this.p_Content.Controls.Add(this.label6);
            this.p_Content.Controls.Add(this.label5);
            this.p_Content.Controls.Add(this.label4);
            this.p_Content.Controls.Add(this.label2);
            this.p_Content.Controls.Add(this.label1);
            this.p_Content.Controls.Add(this.bunifuSeparator1);
            this.p_Content.Controls.Add(this.label3);
            this.p_Content.Location = new System.Drawing.Point(4, 28);
            this.p_Content.Name = "p_Content";
            this.p_Content.Size = new System.Drawing.Size(442, 595);
            this.p_Content.TabIndex = 1;
            this.p_Content.Paint += new System.Windows.Forms.PaintEventHandler(this.p_Content_Paint);
            // 
            // lbl_ErrorMessage_Department
            // 
            this.lbl_ErrorMessage_Department.AutoSize = true;
            this.lbl_ErrorMessage_Department.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ErrorMessage_Department.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Italic);
            this.lbl_ErrorMessage_Department.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorMessage_Department.Location = new System.Drawing.Point(259, 280);
            this.lbl_ErrorMessage_Department.Name = "lbl_ErrorMessage_Department";
            this.lbl_ErrorMessage_Department.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ErrorMessage_Department.Size = new System.Drawing.Size(122, 15);
            this.lbl_ErrorMessage_Department.TabIndex = 28;
            this.lbl_ErrorMessage_Department.Text = "Choose a Department";
            this.lbl_ErrorMessage_Department.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_ErrorMessage_Department.Visible = false;
            // 
            // lbl_ErrorMessage_ReTypePassword
            // 
            this.lbl_ErrorMessage_ReTypePassword.AutoSize = true;
            this.lbl_ErrorMessage_ReTypePassword.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ErrorMessage_ReTypePassword.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Italic);
            this.lbl_ErrorMessage_ReTypePassword.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorMessage_ReTypePassword.Location = new System.Drawing.Point(218, 458);
            this.lbl_ErrorMessage_ReTypePassword.Name = "lbl_ErrorMessage_ReTypePassword";
            this.lbl_ErrorMessage_ReTypePassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ErrorMessage_ReTypePassword.Size = new System.Drawing.Size(221, 15);
            this.lbl_ErrorMessage_ReTypePassword.TabIndex = 27;
            this.lbl_ErrorMessage_ReTypePassword.Text = "Those passwords didn\'t match. Try again";
            this.lbl_ErrorMessage_ReTypePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_ErrorMessage_ReTypePassword.Visible = false;
            // 
            // lbl_ErrorMessage_TypePassword
            // 
            this.lbl_ErrorMessage_TypePassword.AutoSize = true;
            this.lbl_ErrorMessage_TypePassword.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ErrorMessage_TypePassword.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Italic);
            this.lbl_ErrorMessage_TypePassword.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorMessage_TypePassword.Location = new System.Drawing.Point(247, 392);
            this.lbl_ErrorMessage_TypePassword.Name = "lbl_ErrorMessage_TypePassword";
            this.lbl_ErrorMessage_TypePassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ErrorMessage_TypePassword.Size = new System.Drawing.Size(132, 15);
            this.lbl_ErrorMessage_TypePassword.TabIndex = 26;
            this.lbl_ErrorMessage_TypePassword.Text = "               Enter password";
            this.lbl_ErrorMessage_TypePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_ErrorMessage_TypePassword.Visible = false;
            // 
            // lbl_ErrorMessage_Username
            // 
            this.lbl_ErrorMessage_Username.AutoSize = true;
            this.lbl_ErrorMessage_Username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ErrorMessage_Username.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Italic);
            this.lbl_ErrorMessage_Username.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorMessage_Username.Location = new System.Drawing.Point(292, 341);
            this.lbl_ErrorMessage_Username.Name = "lbl_ErrorMessage_Username";
            this.lbl_ErrorMessage_Username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ErrorMessage_Username.Size = new System.Drawing.Size(89, 15);
            this.lbl_ErrorMessage_Username.TabIndex = 25;
            this.lbl_ErrorMessage_Username.Text = "Enter username";
            this.lbl_ErrorMessage_Username.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_ErrorMessage_Username.Visible = false;
            // 
            // lbl_ErrorMessage_LastName
            // 
            this.lbl_ErrorMessage_LastName.AutoSize = true;
            this.lbl_ErrorMessage_LastName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ErrorMessage_LastName.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Italic);
            this.lbl_ErrorMessage_LastName.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorMessage_LastName.Location = new System.Drawing.Point(290, 218);
            this.lbl_ErrorMessage_LastName.Name = "lbl_ErrorMessage_LastName";
            this.lbl_ErrorMessage_LastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ErrorMessage_LastName.Size = new System.Drawing.Size(89, 15);
            this.lbl_ErrorMessage_LastName.TabIndex = 23;
            this.lbl_ErrorMessage_LastName.Text = "Enter last name";
            this.lbl_ErrorMessage_LastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_ErrorMessage_LastName.Visible = false;
            // 
            // lbl_ErrorMessage_FirstName
            // 
            this.lbl_ErrorMessage_FirstName.AutoSize = true;
            this.lbl_ErrorMessage_FirstName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ErrorMessage_FirstName.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Italic);
            this.lbl_ErrorMessage_FirstName.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorMessage_FirstName.Location = new System.Drawing.Point(289, 156);
            this.lbl_ErrorMessage_FirstName.Name = "lbl_ErrorMessage_FirstName";
            this.lbl_ErrorMessage_FirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ErrorMessage_FirstName.Size = new System.Drawing.Size(90, 15);
            this.lbl_ErrorMessage_FirstName.TabIndex = 22;
            this.lbl_ErrorMessage_FirstName.Text = "Enter first name";
            this.lbl_ErrorMessage_FirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_ErrorMessage_FirstName.Visible = false;
            // 
            // lbl_ErrorMessage_EmployeeID
            // 
            this.lbl_ErrorMessage_EmployeeID.AutoSize = true;
            this.lbl_ErrorMessage_EmployeeID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ErrorMessage_EmployeeID.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Italic);
            this.lbl_ErrorMessage_EmployeeID.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorMessage_EmployeeID.Location = new System.Drawing.Point(292, 94);
            this.lbl_ErrorMessage_EmployeeID.Name = "lbl_ErrorMessage_EmployeeID";
            this.lbl_ErrorMessage_EmployeeID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ErrorMessage_EmployeeID.Size = new System.Drawing.Size(87, 15);
            this.lbl_ErrorMessage_EmployeeID.TabIndex = 21;
            this.lbl_ErrorMessage_EmployeeID.Text = "Enter Admin ID";
            this.lbl_ErrorMessage_EmployeeID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_ErrorMessage_EmployeeID.Visible = false;
            // 
            // txt_LastName
            // 
            this.txt_LastName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_LastName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_LastName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_LastName.BorderThickness = 1;
            this.txt_LastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_LastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_LastName.isPassword = false;
            this.txt_LastName.Location = new System.Drawing.Point(70, 237);
            this.txt_LastName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(309, 29);
            this.txt_LastName.TabIndex = 3;
            this.txt_LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(72, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "Last Name";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_FirstName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_FirstName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_FirstName.BorderThickness = 1;
            this.txt_FirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_FirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_FirstName.isPassword = false;
            this.txt_FirstName.Location = new System.Drawing.Point(70, 175);
            this.txt_FirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(309, 29);
            this.txt_FirstName.TabIndex = 2;
            this.txt_FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(72, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "First Name";
            // 
            // txt_EmployeeID
            // 
            this.txt_EmployeeID.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_EmployeeID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_EmployeeID.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_EmployeeID.BorderThickness = 1;
            this.txt_EmployeeID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_EmployeeID.Enabled = false;
            this.txt_EmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_EmployeeID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_EmployeeID.isPassword = false;
            this.txt_EmployeeID.Location = new System.Drawing.Point(70, 113);
            this.txt_EmployeeID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_EmployeeID.Name = "txt_EmployeeID";
            this.txt_EmployeeID.Size = new System.Drawing.Size(309, 29);
            this.txt_EmployeeID.TabIndex = 1;
            this.txt_EmployeeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Username
            // 
            this.txt_Username.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_Username.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Username.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_Username.BorderThickness = 1;
            this.txt_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Username.isPassword = false;
            this.txt_Username.Location = new System.Drawing.Point(71, 359);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(309, 29);
            this.txt_Username.TabIndex = 5;
            this.txt_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_ReTypePassword
            // 
            this.txt_ReTypePassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_ReTypePassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ReTypePassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_ReTypePassword.BorderThickness = 1;
            this.txt_ReTypePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ReTypePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_ReTypePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ReTypePassword.isPassword = true;
            this.txt_ReTypePassword.Location = new System.Drawing.Point(71, 491);
            this.txt_ReTypePassword.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ReTypePassword.Name = "txt_ReTypePassword";
            this.txt_ReTypePassword.Size = new System.Drawing.Size(309, 29);
            this.txt_ReTypePassword.TabIndex = 7;
            this.txt_ReTypePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_TypePassword
            // 
            this.txt_TypePassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_TypePassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_TypePassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_TypePassword.BorderThickness = 1;
            this.txt_TypePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TypePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_TypePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_TypePassword.isPassword = true;
            this.txt_TypePassword.Location = new System.Drawing.Point(72, 425);
            this.txt_TypePassword.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TypePassword.Name = "txt_TypePassword";
            this.txt_TypePassword.Size = new System.Drawing.Size(309, 29);
            this.txt_TypePassword.TabIndex = 6;
            this.txt_TypePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderThickness = 3;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(-18, -43);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(370, 44);
            this.bunifuMetroTextbox1.TabIndex = 17;
            this.bunifuMetroTextbox1.Text = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cb_Department
            // 
            this.cb_Department.BackColor = System.Drawing.Color.Silver;
            this.cb_Department.BorderRadius = 3;
            this.cb_Department.DisabledColor = System.Drawing.SystemColors.GrayText;
            this.cb_Department.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Department.ForeColor = System.Drawing.Color.Black;
            this.cb_Department.Items = new string[] {
        "Select Department",
        "Account Department",
        "Cash Section",
        "Information Technology Department"};
            this.cb_Department.Location = new System.Drawing.Point(71, 300);
            this.cb_Department.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_Department.Name = "cb_Department";
            this.cb_Department.NomalColor = System.Drawing.Color.Silver;
            this.cb_Department.onHoverColor = System.Drawing.Color.Silver;
            this.cb_Department.selectedIndex = 0;
            this.cb_Department.Size = new System.Drawing.Size(309, 27);
            this.cb_Department.TabIndex = 4;
            // 
            // btn_Next
            // 
            this.btn_Next.ActiveBorderThickness = 1;
            this.btn_Next.ActiveCornerRadius = 20;
            this.btn_Next.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Next.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Next.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Next.BackColor = System.Drawing.Color.White;
            this.btn_Next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Next.BackgroundImage")));
            this.btn_Next.ButtonText = "Next";
            this.btn_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Next.IdleBorderThickness = 1;
            this.btn_Next.IdleCornerRadius = 20;
            this.btn_Next.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(150)))), ((int)(((byte)(16)))));
            this.btn_Next.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.btn_Next.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.btn_Next.Location = new System.Drawing.Point(135, 523);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(164, 64);
            this.btn_Next.TabIndex = 6;
            this.btn_Next.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(70, 465);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Re-Type Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(71, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Type Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(70, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(69, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(110, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "This will create a new record of admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(114)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(87, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTRATION";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 54);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(444, 35);
            this.bunifuSeparator1.TabIndex = 4;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(67, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Admin ID";
            // 
            // AddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 631);
            this.Controls.Add(this.p_AddAdmin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAdmin";
            this.Load += new System.EventHandler(this.AddAdmin_Load);
            this.p_AddAdmin.ResumeLayout(false);
            this.p_Content.ResumeLayout(false);
            this.p_Content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel p_AddAdmin;
        private Bunifu.Framework.UI.BunifuTileButton btn_Close;
        private System.Windows.Forms.Panel p_Content;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Next;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_ErrorMessage_Department;
        private System.Windows.Forms.Label lbl_ErrorMessage_ReTypePassword;
        private System.Windows.Forms.Label lbl_ErrorMessage_TypePassword;
        private System.Windows.Forms.Label lbl_ErrorMessage_Username;
        private System.Windows.Forms.Label lbl_ErrorMessage_LastName;
        private System.Windows.Forms.Label lbl_ErrorMessage_FirstName;
        private System.Windows.Forms.Label lbl_ErrorMessage_EmployeeID;
        public Bunifu.Framework.UI.BunifuMetroTextbox txt_ReTypePassword;
        public Bunifu.Framework.UI.BunifuMetroTextbox txt_TypePassword;
        public Bunifu.Framework.UI.BunifuDropdown cb_Department;
        public Bunifu.Framework.UI.BunifuMetroTextbox txt_EmployeeID;
        public Bunifu.Framework.UI.BunifuMetroTextbox txt_Username;
        public Bunifu.Framework.UI.BunifuMetroTextbox txt_LastName;
        public Bunifu.Framework.UI.BunifuMetroTextbox txt_FirstName;
    }
}