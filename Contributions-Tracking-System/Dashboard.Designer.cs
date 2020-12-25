namespace Contributions_Tracking_System
{
    partial class Dashboard
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.elip_profile = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_Profile = new Bunifu.Framework.UI.BunifuTileButton();
            this.p_Sidebar = new System.Windows.Forms.Panel();
            this.btn_Home = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_settings = new Bunifu.Framework.UI.BunifuTileButton();
            this.p_SelectedTab = new System.Windows.Forms.Panel();
            this.btn_Menu = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_AdminName = new System.Windows.Forms.Label();
            this.btn_Import = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Contributions = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Employees = new Bunifu.Framework.UI.BunifuFlatButton();
            this.p_Content = new System.Windows.Forms.Panel();
            this.p_topBar = new System.Windows.Forms.Panel();
            this.p_Closebar = new System.Windows.Forms.Panel();
            this.lbl_HeaderName = new System.Windows.Forms.Label();
            this.btn_maximize = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_minimize = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Close = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.transition_Panel = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pb_Content = new System.Windows.Forms.PictureBox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.userControl_ProfileContributions1 = new Contributions_Tracking_System.UserControl_ProfileContributions();
            this.userControl_Employee1 = new Contributions_Tracking_System.UserControl_Employee();
            this.userControl_Contributions1 = new Contributions_Tracking_System.UserControl_Contributions();
            this.userControl_Dashboard1 = new Contributions_Tracking_System.UserControl_Dashboard();
            this.p_Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.p_Content.SuspendLayout();
            this.p_topBar.SuspendLayout();
            this.p_Closebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Content)).BeginInit();
            this.SuspendLayout();
            // 
            // elip_profile
            // 
            this.elip_profile.ElipseRadius = 100;
            this.elip_profile.TargetControl = this.btn_Profile;
            // 
            // btn_Profile
            // 
            this.btn_Profile.BackColor = System.Drawing.Color.Transparent;
            this.btn_Profile.BackgroundImage = global::Contributions_Tracking_System.Properties.Resources.profile;
            this.btn_Profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Profile.color = System.Drawing.Color.Transparent;
            this.btn_Profile.colorActive = System.Drawing.Color.Transparent;
            this.btn_Profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_Panel.SetDecoration(this.btn_Profile, BunifuAnimatorNS.DecorationType.None);
            this.btn_Profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_Profile.ForeColor = System.Drawing.Color.White;
            this.btn_Profile.Image = null;
            this.btn_Profile.ImagePosition = 20;
            this.btn_Profile.ImageZoom = 50;
            this.btn_Profile.LabelPosition = 41;
            this.btn_Profile.LabelText = "";
            this.btn_Profile.Location = new System.Drawing.Point(79, 85);
            this.btn_Profile.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Profile.Name = "btn_Profile";
            this.btn_Profile.Size = new System.Drawing.Size(100, 100);
            this.btn_Profile.TabIndex = 30;
            this.btn_Profile.Click += new System.EventHandler(this.btn_Profile_Click);
            // 
            // p_Sidebar
            // 
            this.p_Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(91)))));
            this.p_Sidebar.Controls.Add(this.btn_Home);
            this.p_Sidebar.Controls.Add(this.btn_settings);
            this.p_Sidebar.Controls.Add(this.p_SelectedTab);
            this.p_Sidebar.Controls.Add(this.btn_Menu);
            this.p_Sidebar.Controls.Add(this.btn_Profile);
            this.p_Sidebar.Controls.Add(this.lbl_AdminName);
            this.p_Sidebar.Controls.Add(this.btn_Import);
            this.p_Sidebar.Controls.Add(this.btn_Contributions);
            this.p_Sidebar.Controls.Add(this.pictureBox2);
            this.p_Sidebar.Controls.Add(this.btn_Employees);
            this.transition_Panel.SetDecoration(this.p_Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.p_Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_Sidebar.Location = new System.Drawing.Point(0, 37);
            this.p_Sidebar.Name = "p_Sidebar";
            this.p_Sidebar.Size = new System.Drawing.Size(268, 663);
            this.p_Sidebar.TabIndex = 15;
            this.p_Sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.p_Sidebar_Paint);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.Transparent;
            this.btn_Home.BackgroundImage = global::Contributions_Tracking_System.Properties.Resources.home_64px1;
            this.btn_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Home.color = System.Drawing.Color.Transparent;
            this.btn_Home.colorActive = System.Drawing.Color.Transparent;
            this.btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_Panel.SetDecoration(this.btn_Home, BunifuAnimatorNS.DecorationType.None);
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_Home.ForeColor = System.Drawing.Color.White;
            this.btn_Home.Image = null;
            this.btn_Home.ImagePosition = 20;
            this.btn_Home.ImageZoom = 50;
            this.btn_Home.LabelPosition = 41;
            this.btn_Home.LabelText = "";
            this.btn_Home.Location = new System.Drawing.Point(12, 9);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(63, 57);
            this.btn_Home.TabIndex = 36;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_settings.BackColor = System.Drawing.Color.Transparent;
            this.btn_settings.BackgroundImage = global::Contributions_Tracking_System.Properties.Resources.settings_64px;
            this.btn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_settings.color = System.Drawing.Color.Transparent;
            this.btn_settings.colorActive = System.Drawing.Color.Transparent;
            this.btn_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_Panel.SetDecoration(this.btn_settings, BunifuAnimatorNS.DecorationType.None);
            this.btn_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_settings.ForeColor = System.Drawing.Color.White;
            this.btn_settings.Image = null;
            this.btn_settings.ImagePosition = 20;
            this.btn_settings.ImageZoom = 50;
            this.btn_settings.LabelPosition = 41;
            this.btn_settings.LabelText = "";
            this.btn_settings.Location = new System.Drawing.Point(6, 607);
            this.btn_settings.Margin = new System.Windows.Forms.Padding(6);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(50, 50);
            this.btn_settings.TabIndex = 35;
            this.btn_settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // p_SelectedTab
            // 
            this.p_SelectedTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.transition_Panel.SetDecoration(this.p_SelectedTab, BunifuAnimatorNS.DecorationType.None);
            this.p_SelectedTab.Location = new System.Drawing.Point(260, 480);
            this.p_SelectedTab.Name = "p_SelectedTab";
            this.p_SelectedTab.Size = new System.Drawing.Size(5, 58);
            this.p_SelectedTab.TabIndex = 2;
            this.p_SelectedTab.Visible = false;
            // 
            // btn_Menu
            // 
            this.btn_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Menu.BackColor = System.Drawing.Color.Transparent;
            this.btn_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.transition_Panel.SetDecoration(this.btn_Menu, BunifuAnimatorNS.DecorationType.None);
            this.btn_Menu.Image = global::Contributions_Tracking_System.Properties.Resources.menu_30px;
            this.btn_Menu.ImageActive = null;
            this.btn_Menu.Location = new System.Drawing.Point(224, 9);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(38, 51);
            this.btn_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Menu.TabIndex = 32;
            this.btn_Menu.TabStop = false;
            this.btn_Menu.Zoom = 10;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // lbl_AdminName
            // 
            this.lbl_AdminName.AutoSize = true;
            this.lbl_AdminName.BackColor = System.Drawing.Color.Transparent;
            this.transition_Panel.SetDecoration(this.lbl_AdminName, BunifuAnimatorNS.DecorationType.None);
            this.lbl_AdminName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdminName.ForeColor = System.Drawing.Color.White;
            this.lbl_AdminName.Location = new System.Drawing.Point(40, 191);
            this.lbl_AdminName.Name = "lbl_AdminName";
            this.lbl_AdminName.Size = new System.Drawing.Size(105, 21);
            this.lbl_AdminName.TabIndex = 31;
            this.lbl_AdminName.Text = "Admin Name";
            this.lbl_AdminName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Import
            // 
            this.btn_Import.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(91)))));
            this.btn_Import.BackColor = System.Drawing.Color.White;
            this.btn_Import.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Import.BorderRadius = 0;
            this.btn_Import.ButtonText = "    Import";
            this.btn_Import.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_Panel.SetDecoration(this.btn_Import, BunifuAnimatorNS.DecorationType.None);
            this.btn_Import.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Import.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Import.ForeColor = System.Drawing.Color.White;
            this.btn_Import.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Import.Iconimage = global::Contributions_Tracking_System.Properties.Resources.Import_File_64p_newx1;
            this.btn_Import.Iconimage_right = null;
            this.btn_Import.Iconimage_right_Selected = null;
            this.btn_Import.Iconimage_Selected = global::Contributions_Tracking_System.Properties.Resources.Import_File_64px;
            this.btn_Import.IconMarginLeft = 10;
            this.btn_Import.IconMarginRight = 0;
            this.btn_Import.IconRightVisible = true;
            this.btn_Import.IconRightZoom = 0D;
            this.btn_Import.IconVisible = true;
            this.btn_Import.IconZoom = 90D;
            this.btn_Import.IsTab = true;
            this.btn_Import.Location = new System.Drawing.Point(3, 275);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Normalcolor = System.Drawing.Color.White;
            this.btn_Import.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(95)))));
            this.btn_Import.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Import.selected = false;
            this.btn_Import.Size = new System.Drawing.Size(262, 58);
            this.btn_Import.TabIndex = 29;
            this.btn_Import.Text = "    Import";
            this.btn_Import.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Import.Textcolor = System.Drawing.Color.Black;
            this.btn_Import.TextFont = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_Contributions
            // 
            this.btn_Contributions.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(91)))));
            this.btn_Contributions.BackColor = System.Drawing.Color.White;
            this.btn_Contributions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Contributions.BorderRadius = 0;
            this.btn_Contributions.ButtonText = "  Contributions";
            this.btn_Contributions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_Panel.SetDecoration(this.btn_Contributions, BunifuAnimatorNS.DecorationType.None);
            this.btn_Contributions.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Contributions.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Contributions.ForeColor = System.Drawing.Color.White;
            this.btn_Contributions.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Contributions.Iconimage = global::Contributions_Tracking_System.Properties.Resources.card_payment_60px_new1;
            this.btn_Contributions.Iconimage_right = null;
            this.btn_Contributions.Iconimage_right_Selected = null;
            this.btn_Contributions.Iconimage_Selected = global::Contributions_Tracking_System.Properties.Resources.card_payment_60px_white1;
            this.btn_Contributions.IconMarginLeft = 10;
            this.btn_Contributions.IconMarginRight = 0;
            this.btn_Contributions.IconRightVisible = true;
            this.btn_Contributions.IconRightZoom = 0D;
            this.btn_Contributions.IconVisible = true;
            this.btn_Contributions.IconZoom = 90D;
            this.btn_Contributions.IsTab = true;
            this.btn_Contributions.Location = new System.Drawing.Point(3, 404);
            this.btn_Contributions.Name = "btn_Contributions";
            this.btn_Contributions.Normalcolor = System.Drawing.Color.White;
            this.btn_Contributions.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(95)))));
            this.btn_Contributions.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Contributions.selected = false;
            this.btn_Contributions.Size = new System.Drawing.Size(262, 60);
            this.btn_Contributions.TabIndex = 22;
            this.btn_Contributions.Text = "  Contributions";
            this.btn_Contributions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Contributions.Textcolor = System.Drawing.Color.Black;
            this.btn_Contributions.TextFont = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Contributions.Click += new System.EventHandler(this.btn_Contributions_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.transition_Panel.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::Contributions_Tracking_System.Properties.Resources.background;
            this.pictureBox2.Location = new System.Drawing.Point(274, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(0, 0);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Employees
            // 
            this.btn_Employees.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(91)))));
            this.btn_Employees.BackColor = System.Drawing.Color.White;
            this.btn_Employees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Employees.BorderRadius = 0;
            this.btn_Employees.ButtonText = "   Employees";
            this.btn_Employees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_Panel.SetDecoration(this.btn_Employees, BunifuAnimatorNS.DecorationType.None);
            this.btn_Employees.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Employees.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employees.ForeColor = System.Drawing.Color.White;
            this.btn_Employees.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Employees.Iconimage = global::Contributions_Tracking_System.Properties.Resources.people_52px_new1;
            this.btn_Employees.Iconimage_right = null;
            this.btn_Employees.Iconimage_right_Selected = null;
            this.btn_Employees.Iconimage_Selected = global::Contributions_Tracking_System.Properties.Resources.people_52px_white;
            this.btn_Employees.IconMarginLeft = 10;
            this.btn_Employees.IconMarginRight = 0;
            this.btn_Employees.IconRightVisible = true;
            this.btn_Employees.IconRightZoom = 0D;
            this.btn_Employees.IconVisible = true;
            this.btn_Employees.IconZoom = 90D;
            this.btn_Employees.IsTab = true;
            this.btn_Employees.Location = new System.Drawing.Point(3, 339);
            this.btn_Employees.Name = "btn_Employees";
            this.btn_Employees.Normalcolor = System.Drawing.Color.White;
            this.btn_Employees.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(95)))));
            this.btn_Employees.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Employees.selected = false;
            this.btn_Employees.Size = new System.Drawing.Size(262, 60);
            this.btn_Employees.TabIndex = 25;
            this.btn_Employees.Text = "   Employees";
            this.btn_Employees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Employees.Textcolor = System.Drawing.Color.Black;
            this.btn_Employees.TextFont = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employees.Click += new System.EventHandler(this.btn_Employees_Click);
            // 
            // p_Content
            // 
            this.p_Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.p_Content.Controls.Add(this.userControl_ProfileContributions1);
            this.p_Content.Controls.Add(this.userControl_Employee1);
            this.p_Content.Controls.Add(this.userControl_Contributions1);
            this.p_Content.Controls.Add(this.userControl_Dashboard1);
            this.transition_Panel.SetDecoration(this.p_Content, BunifuAnimatorNS.DecorationType.None);
            this.p_Content.ForeColor = System.Drawing.Color.White;
            this.p_Content.Location = new System.Drawing.Point(268, 37);
            this.p_Content.Name = "p_Content";
            this.p_Content.Size = new System.Drawing.Size(1098, 663);
            this.p_Content.TabIndex = 16;
            // 
            // p_topBar
            // 
            this.p_topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.p_topBar.Controls.Add(this.p_Closebar);
            this.transition_Panel.SetDecoration(this.p_topBar, BunifuAnimatorNS.DecorationType.None);
            this.p_topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_topBar.Location = new System.Drawing.Point(0, 0);
            this.p_topBar.Name = "p_topBar";
            this.p_topBar.Size = new System.Drawing.Size(1366, 37);
            this.p_topBar.TabIndex = 14;
            this.p_topBar.Paint += new System.Windows.Forms.PaintEventHandler(this.p_topBar_Paint);
            // 
            // p_Closebar
            // 
            this.p_Closebar.BackColor = System.Drawing.Color.DodgerBlue;
            this.p_Closebar.Controls.Add(this.lbl_HeaderName);
            this.p_Closebar.Controls.Add(this.btn_maximize);
            this.p_Closebar.Controls.Add(this.btn_minimize);
            this.p_Closebar.Controls.Add(this.btn_Close);
            this.transition_Panel.SetDecoration(this.p_Closebar, BunifuAnimatorNS.DecorationType.None);
            this.p_Closebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Closebar.Location = new System.Drawing.Point(0, 0);
            this.p_Closebar.Name = "p_Closebar";
            this.p_Closebar.Size = new System.Drawing.Size(1366, 37);
            this.p_Closebar.TabIndex = 1;
            // 
            // lbl_HeaderName
            // 
            this.lbl_HeaderName.AutoSize = true;
            this.transition_Panel.SetDecoration(this.lbl_HeaderName, BunifuAnimatorNS.DecorationType.None);
            this.lbl_HeaderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HeaderName.ForeColor = System.Drawing.Color.White;
            this.lbl_HeaderName.Location = new System.Drawing.Point(12, 7);
            this.lbl_HeaderName.Name = "lbl_HeaderName";
            this.lbl_HeaderName.Size = new System.Drawing.Size(88, 20);
            this.lbl_HeaderName.TabIndex = 2;
            this.lbl_HeaderName.Text = "Dashboard";
            this.lbl_HeaderName.Click += new System.EventHandler(this.lbl_HeaderName_Click);
            // 
            // btn_maximize
            // 
            this.btn_maximize.BackColor = System.Drawing.Color.Transparent;
            this.btn_maximize.BackgroundImage = global::Contributions_Tracking_System.Properties.Resources.maximize_button_26px;
            this.btn_maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_maximize.color = System.Drawing.Color.Transparent;
            this.btn_maximize.colorActive = System.Drawing.Color.Transparent;
            this.btn_maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_Panel.SetDecoration(this.btn_maximize, BunifuAnimatorNS.DecorationType.None);
            this.btn_maximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_maximize.ForeColor = System.Drawing.Color.White;
            this.btn_maximize.Image = global::Contributions_Tracking_System.Properties.Resources.minimize_window_26px;
            this.btn_maximize.ImagePosition = 20;
            this.btn_maximize.ImageZoom = 50;
            this.btn_maximize.LabelPosition = 41;
            this.btn_maximize.LabelText = "X";
            this.btn_maximize.Location = new System.Drawing.Point(1317, 3);
            this.btn_maximize.Margin = new System.Windows.Forms.Padding(6);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.Size = new System.Drawing.Size(20, 20);
            this.btn_maximize.TabIndex = 4;
            this.btn_maximize.TabStop = false;
            this.btn_maximize.Click += new System.EventHandler(this.btn_maximize_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.BackgroundImage = global::Contributions_Tracking_System.Properties.Resources.minimize_window_26px;
            this.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_minimize.color = System.Drawing.Color.Transparent;
            this.btn_minimize.colorActive = System.Drawing.Color.Transparent;
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_Panel.SetDecoration(this.btn_minimize, BunifuAnimatorNS.DecorationType.None);
            this.btn_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.Image = global::Contributions_Tracking_System.Properties.Resources.minimize_window_26px;
            this.btn_minimize.ImagePosition = 20;
            this.btn_minimize.ImageZoom = 50;
            this.btn_minimize.LabelPosition = 41;
            this.btn_minimize.LabelText = "X";
            this.btn_minimize.Location = new System.Drawing.Point(1294, 3);
            this.btn_minimize.Margin = new System.Windows.Forms.Padding(6);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(20, 20);
            this.btn_minimize.TabIndex = 3;
            this.btn_minimize.TabStop = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BackgroundImage = global::Contributions_Tracking_System.Properties.Resources.delete_50px;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.color = System.Drawing.Color.Transparent;
            this.btn_Close.colorActive = System.Drawing.Color.Transparent;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_Panel.SetDecoration(this.btn_Close, BunifuAnimatorNS.DecorationType.None);
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImagePosition = 20;
            this.btn_Close.ImageZoom = 50;
            this.btn_Close.LabelPosition = 41;
            this.btn_Close.LabelText = "X";
            this.btn_Close.Location = new System.Drawing.Point(1339, 3);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(20, 20);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.p_topBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // transition_Panel
            // 
            this.transition_Panel.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.transition_Panel.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.transition_Panel.DefaultAnimation = animation1;
            this.transition_Panel.TimeStep = 0.01F;
            // 
            // pb_Content
            // 
            this.pb_Content.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.transition_Panel.SetDecoration(this.pb_Content, BunifuAnimatorNS.DecorationType.None);
            this.pb_Content.Image = global::Contributions_Tracking_System.Properties.Resources.background;
            this.pb_Content.Location = new System.Drawing.Point(274, 63);
            this.pb_Content.Name = "pb_Content";
            this.pb_Content.Size = new System.Drawing.Size(0, 0);
            this.pb_Content.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Content.TabIndex = 1;
            this.pb_Content.TabStop = false;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 0;
            this.bunifuElipse2.TargetControl = this.btn_Import;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 0;
            this.bunifuElipse3.TargetControl = this.btn_Employees;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 0;
            this.bunifuElipse4.TargetControl = this.btn_Contributions;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 1;
            this.bunifuElipse5.TargetControl = this;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 100;
            this.bunifuElipse1.TargetControl = this.btn_settings;
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 1;
            this.bunifuElipse6.TargetControl = this;
            // 
            // userControl_ProfileContributions1
            // 
            this.userControl_ProfileContributions1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.userControl_ProfileContributions1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transition_Panel.SetDecoration(this.userControl_ProfileContributions1, BunifuAnimatorNS.DecorationType.None);
            this.userControl_ProfileContributions1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_ProfileContributions1.Location = new System.Drawing.Point(0, 0);
            this.userControl_ProfileContributions1.Name = "userControl_ProfileContributions1";
            this.userControl_ProfileContributions1.Size = new System.Drawing.Size(1098, 663);
            this.userControl_ProfileContributions1.TabIndex = 3;
            // 
            // userControl_Employee1
            // 
            this.userControl_Employee1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(181)))));
            this.transition_Panel.SetDecoration(this.userControl_Employee1, BunifuAnimatorNS.DecorationType.None);
            this.userControl_Employee1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Employee1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Employee1.Name = "userControl_Employee1";
            this.userControl_Employee1.Size = new System.Drawing.Size(1098, 663);
            this.userControl_Employee1.TabIndex = 2;
            // 
            // userControl_Contributions1
            // 
            this.userControl_Contributions1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.transition_Panel.SetDecoration(this.userControl_Contributions1, BunifuAnimatorNS.DecorationType.None);
            this.userControl_Contributions1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Contributions1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Contributions1.Name = "userControl_Contributions1";
            this.userControl_Contributions1.Size = new System.Drawing.Size(1098, 663);
            this.userControl_Contributions1.TabIndex = 1;
            // 
            // userControl_Dashboard1
            // 
            this.userControl_Dashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(144)))), ((int)(((byte)(248)))));
            this.transition_Panel.SetDecoration(this.userControl_Dashboard1, BunifuAnimatorNS.DecorationType.None);
            this.userControl_Dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Dashboard1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Dashboard1.Name = "userControl_Dashboard1";
            this.userControl_Dashboard1.Size = new System.Drawing.Size(1098, 663);
            this.userControl_Dashboard1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 700);
            this.Controls.Add(this.p_Content);
            this.Controls.Add(this.p_Sidebar);
            this.Controls.Add(this.pb_Content);
            this.Controls.Add(this.p_topBar);
            this.transition_Panel.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.p_Sidebar.ResumeLayout(false);
            this.p_Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.p_Content.ResumeLayout(false);
            this.p_topBar.ResumeLayout(false);
            this.p_Closebar.ResumeLayout(false);
            this.p_Closebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Content)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse elip_profile;
        private System.Windows.Forms.PictureBox pb_Content;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Employees;
        private System.Windows.Forms.Panel p_Content;
        private System.Windows.Forms.Panel p_topBar;
        private Bunifu.Framework.UI.BunifuTileButton btn_Close;
        private System.Windows.Forms.Label lbl_HeaderName;
        private System.Windows.Forms.Panel p_Closebar;
        private Bunifu.Framework.UI.BunifuTileButton btn_minimize;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private BunifuAnimatorNS.BunifuTransition transition_Panel;
        private Bunifu.Framework.UI.BunifuTileButton btn_maximize;
        private System.Windows.Forms.Panel p_SelectedTab;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Import;
        private Bunifu.Framework.UI.BunifuTileButton btn_Profile;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        public Bunifu.Framework.UI.BunifuFlatButton btn_Contributions;
        public System.Windows.Forms.Panel p_Sidebar;
        public Bunifu.Framework.UI.BunifuImageButton btn_Menu;
        public System.Windows.Forms.Label lbl_AdminName;
        private Bunifu.Framework.UI.BunifuTileButton btn_settings;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuTileButton btn_Home;
        private UserControl_Dashboard userControl_Dashboard1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private UserControl_Employee userControl_Employee1;
        private UserControl_Contributions userControl_Contributions1;
        private UserControl_ProfileContributions userControl_ProfileContributions1;
    }
}