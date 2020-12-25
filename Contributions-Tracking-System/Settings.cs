using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contributions_Tracking_System
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            
            p_SelectedTab.Height = btn_Admin.Height;
            p_SelectedTab.Top = btn_Admin.Top;
            userControl_BackUp1.Hide();
            userControl_SettingAdmin1.Show();
            userControl_Archive1.Hide();
        }

        private void btn_BackUp_Click(object sender, EventArgs e)
        {
            p_SelectedTab.Height = btn_BackUp.Height;
            p_SelectedTab.Top = btn_BackUp.Top;
            userControl_SettingAdmin1.Hide();
            userControl_BackUp1.Show();
            userControl_Archive1.Hide();
        }

        private void btn_Archive_Click(object sender, EventArgs e)
        {
            p_SelectedTab.Height = btn_Archive.Height;
            p_SelectedTab.Top = btn_Archive.Top;
            userControl_Archive1.Show();
            userControl_BackUp1.Hide();
            userControl_SettingAdmin1.Hide();
        }
        
        private void btn_Close_Click(object sender, EventArgs e)
        {
            CloseTransparent();
            Dashboard form = new Dashboard();
            form.TopMost = true;
        }
        public void CloseTransparent()
        {
            OpacityForm a = (OpacityForm)Application.OpenForms["OpacityForm"];
            a.Close();
            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            userControl_SettingAdmin1.Show();
            userControl_BackUp1.Hide();
            userControl_Archive1.Hide();
            userControl_Archive1.dtg_Employee.DataSource = loadEmployeeList();
            userControl_SettingAdmin1.dtg_AdminList.DataSource = loadAdminList();
            AddDataGridViewCheckBox();
        }

        public DataGridViewCheckBoxColumn chckbox = new DataGridViewCheckBoxColumn();
        private void AddDataGridViewCheckBox()
        {
            chckbox.HeaderText = "Selected";
            chckbox.Name = "Selected";
            userControl_Archive1.dtg_Employee.Columns.Add(chckbox);
            userControl_Archive1.dtg_Employee.ReadOnly = false;
            userControl_Archive1.dtg_Employee.Columns[0].ReadOnly = true;
            userControl_Archive1.dtg_Employee.Columns[1].ReadOnly = true;
            userControl_Archive1.dtg_Employee.Columns[2].ReadOnly = true;
            userControl_Archive1.dtg_Employee.Columns[3].ReadOnly = true;
            userControl_Archive1.dtg_Employee.Columns[4].ReadOnly = true;
            userControl_Archive1.dtg_Employee.Columns[5].ReadOnly = true;
            userControl_Archive1.dtg_Employee.Columns[6].ReadOnly = true;
        }

        private BindingSource loadEmployeeList()
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

        private BindingSource loadAdminList()
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd;Convert Zero Datetime=True"))
            {
                string viewAdminList = string.Format($"SELECT Firstname as 'First Name', middlename as 'Middle Name', APL, lastname as 'Last Name', Department, emailAddress as 'E-mail Address' FROM dswd.admin ORDER by lastname");

                MySqlCommand cmd = new MySqlCommand(viewAdminList, con);

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataSet ds = new DataSet();
                BindingSource bs = new BindingSource();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);

                bs.DataSource = ds.Tables[0];

                return bs;
            }
        }
    }
}
