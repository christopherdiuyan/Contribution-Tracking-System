using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
namespace Contributions_Tracking_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lbl_AdminName.Text = Login.adminFullName;


            userControl_Employee1.Hide();
            userControl_Dashboard1.Show();
            userControl_ProfileContributions1.Hide();
            userControl_Contributions1.Hide();


            //btn_Dashboard.Visible = false;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                //do nothing
            }
            else
            {
                Application.Exit();
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            if (p_Sidebar.Width == 67)
            {
                /*
                 * EXPAND
                 * 1. Expand the panel. w = 274
                 * 2. Show logo
                 * */
                p_Sidebar.Visible = false;
                p_Sidebar.Width = 274;
                btn_Home.Visible = true;
                transition_Panel.ShowSync(p_Sidebar);

            }
            else
            {
                /*
                 * MINIMIZE
                 * 1. Hide the logo
                 * 2. Slide the panel w = 67
                 * */
                p_Sidebar.Visible = false;
                p_Sidebar.Width = 67;
                btn_Home.Visible = false;
                transition_Panel.ShowSync(p_Sidebar);
            }

        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btn_Employees_Click(object sender, EventArgs e)
        {
            p_SelectedTab.Height = btn_Employees.Height;
            p_SelectedTab.Top = btn_Employees.Top;
            //btn_Employees.Textcolor = System.Drawing.Color.White;
            userControl_Employee1.Show();
            userControl_Dashboard1.Hide();
            userControl_Contributions1.Hide();
            userControl_Employee1.dtg_Employee.DataSource = loadEmployeeList();
        }

        private BindingSource loadEmployeeList()
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd;Convert Zero Datetime=True"))
            {
                string viewEmployeeList = string.Format($"SELECT Status, Department, APL, MI, First_Name as 'First Name', Last_Name as 'Last Name', Employee_ID as 'Employee ID' FROM dswd.excelfile GROUP by employee_ID Order by Last_Name");

                MySqlCommand cmd = new MySqlCommand(viewEmployeeList, con);

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataSet ds = new DataSet();
                BindingSource bs = new BindingSource();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);

                bs.DataSource = ds.Tables[0];

                return bs;
            }
        }
        //private void btn_Dashboard_Click(object sender, EventArgs e)
        //{
        //    p_SelectedTab.Height = btn_Dashboard.Height;
        //    p_SelectedTab.Top = btn_Dashboard.Top;
        //    userControl_Employee1.Hide();
        //    userControl_Dashboard1.Show();
        //    userControl_Contributions1.Hide();
        //}

        private void btn_Contributions_Click(object sender, EventArgs e)
        {
            //btn_Contributions.Textcolor = System.Drawing.Color.White;
            //p_SelectedTab.Height = btn_Contributions.Height;
            //p_SelectedTab.Top = btn_Contributions.Top;
            //btn_Contributions.ForeColor = System.Drawing.Color.Black;
            userControl_Employee1.Hide();
            userControl_Dashboard1.Hide();
            userControl_Contributions1.Show();
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            //p_SelectedTab.Height = btn_Settings.Height;
            //p_SelectedTab.Top = btn_Settings.Top;

            OpacityForm backForm = new OpacityForm();
            Settings form = new Settings();

            backForm.Show();
            form.ShowDialog();
            backForm.Hide();
            Settings set = new Settings();
            set.userControl_Archive1.dtg_Employee.DataSource = loadEmployeeListFromArchive();

        }

        private BindingSource loadEmployeeListFromArchive()
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd;Convert Zero Datetime=True"))
            {
                string viewEmployeeList = string.Format($"SELECT Status, Department, APL, MI, First_Name as 'First Name', Last_Name as 'Last Name', Employee_ID as 'Employee ID' FROM dswd.archivedrecords GROUP by employee_ID Order by Last_Name");

                MySqlCommand cmd = new MySqlCommand(viewEmployeeList, con);

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataSet ds = new DataSet();
                BindingSource bs = new BindingSource();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);

                bs.DataSource = ds.Tables[0];

                return bs;
            }
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            OpacityForm backForm = new OpacityForm();
            BrowseFile form = new BrowseFile();
            //btn_Import.Textcolor = System.Drawing.Color.White;
            backForm.Show();
            form.ShowDialog();
            
            backForm.Hide();
            
        }

        private void p_Sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd"))
            {
                con.Open();
                MySqlCommand comm1 = new MySqlCommand($"SELECT count(DISTINCT employee_id) FROM dswd.excelfile WHERE Status LIKE 'CONTRACTUAL%'", con);
                userControl_Dashboard1.circularProgressBar_Contractual.Value = Convert.ToInt32(comm1.ExecuteScalar());
                userControl_Dashboard1.circularProgressBar_Contractual.Text = Convert.ToString(comm1.ExecuteScalar());

                MySqlCommand comm2 = new MySqlCommand($"SELECT count(DISTINCT employee_id) FROM dswd.excelfile WHERE Status LIKE 'REGULAR%'", con);
                userControl_Dashboard1.circularProgressBar_Regular.Value = Convert.ToInt32(comm2.ExecuteScalar());
                userControl_Dashboard1.circularProgressBar_Regular.Text = Convert.ToString(comm2.ExecuteScalar());

                MySqlCommand comm3 = new MySqlCommand($"SELECT count(DISTINCT employee_id)  FROM dswd.excelfile", con);
                userControl_Dashboard1.circularProgressBar_TotalEmployees.Value = Convert.ToInt32(comm3.ExecuteScalar());
                userControl_Dashboard1.circularProgressBar_TotalEmployees.Text = Convert.ToString(comm3.ExecuteScalar());

                con.Close();
            }

            userControl_Employee1.Hide();
            userControl_Dashboard1.Hide();
            userControl_Contributions1.Hide();
            userControl_Dashboard1.Show();
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            new ProfileAdmin().ShowDialog();
        }

        private void userControl_Contributions1_Load(object sender, EventArgs e)
        {

        }

        private void p_topBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_HeaderName_Click(object sender, EventArgs e)
        {

        }
    }
}
