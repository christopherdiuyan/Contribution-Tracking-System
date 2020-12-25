using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace Contributions_Tracking_System
{
    public partial class UserControl_Employee : UserControl
    {
        public static string selectedEmployeeID;
        public static string employeeFullName;
        public static DateTime getStartDate = DateTime.Now;
        public static DateTime getEndDate = DateTime.Now;
        public UserControl_Employee()
        {
            InitializeComponent();
        }

        private void UserControl_Employee_Load(object sender, EventArgs e)
        {
            cb_Sort.SelectedIndex = 0;
            dtg_Employee.DataSource = loadEmployeeList();
            AddDataGridViewCheckBox();
            userControl_ProfileContributions1.Hide();
        }
        public DataGridViewCheckBoxColumn chckbox = new DataGridViewCheckBoxColumn();
        private void AddDataGridViewCheckBox()
        {
            chckbox.HeaderText = "Selected";
            chckbox.Name = "Selected";
            dtg_Employee.Columns.Add(chckbox);
            dtg_Employee.ReadOnly = false;
            dtg_Employee.Columns[0].ReadOnly = true;
            dtg_Employee.Columns[1].ReadOnly = true;
            dtg_Employee.Columns[2].ReadOnly = true;
            dtg_Employee.Columns[3].ReadOnly = true;
            dtg_Employee.Columns[4].ReadOnly = true;
            dtg_Employee.Columns[5].ReadOnly = true;
            dtg_Employee.Columns[6].ReadOnly = true;
            dtg_Employee.Columns[7].ReadOnly = true;
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            int officialReceipt;
            if (int.TryParse(txt_Search.Text, out officialReceipt))
            {
                using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd"))
                {
                    con.Open();
                    MySqlCommand command = new MySqlCommand();

                    command.CommandText = string.Format($"SELECT Status, Department, APL, MI, First_Name as 'First Name', Last_Name as 'Last Name', Employee_ID as 'Employee ID' FROM dswd.excelfile WHERE Employee_ID = '{txt_Search.Text}' GROUP by employee_ID");
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    MySqlDataReader reader = command.ExecuteReader();
                    bool existing = reader.HasRows;

                    if (existing)
                    {
                        MessageBox.Show("Record found!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Record not exist!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Search.Text = "";
                    }
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid Input!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Search.Text = "";
            }
        }

        private void btn_Archive_Click(object sender, EventArgs e)
        {
            int total = dtg_Employee.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells["Selected"].Value) == true).Count();

            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd;"))
            {
                int affectedCount = 0;
                try
                {
                    if (total > 0)
                    {
                        string message = $"Are you sure you want to delete {total} row?";
                        if (total > 1)
                        {
                            message = $"Are you sure you want to delete {total} row?";
                        }
                        if (MessageBox.Show(message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int x = dtg_Employee.RowCount - 1; x >= 0; x--)
                            {
                                DataGridViewRow row = dtg_Employee.Rows[x];
                                if (Convert.ToBoolean(row.Cells["Selected"].Value) == true)
                                {
                                    //MessageBox.Show($"Selected row: {row.Cells[1].RowIndex.ToString()}");
                                    con.Open();

                                    MySqlCommand command = new MySqlCommand();
                                    command = new MySqlCommand($"INSERT INTO dswd.archivedrecords SELECT * from dswd.excelfile WHERE Employee_ID = '{row.Cells[8].Value.ToString()}'", con);

                                    affectedCount = command.ExecuteNonQuery();
                                    con.Close();
                                    MySqlCommand command2 = new MySqlCommand();

                                    con.Open();
                                    command2 = new MySqlCommand($"DELETE from dswd.excelfile WHERE Employee_ID = '{row.Cells[8].Value.ToString()}'", con);
                                    command2.ExecuteReader();
                                    con.Close();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    dtg_Employee.DataSource = loadEmployeeList();
                    if (affectedCount > 0)
                    {
                        MessageBox.Show($"Deleted Successfully!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                }
            }
        }

        private void dtg_Employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_Employee.Columns[e.ColumnIndex].HeaderText == "View Record")
            {
                dtg_Employee.CurrentCell = dtg_Employee.Rows[0].Cells[0];
                dtg_Employee.BeginEdit(true);
                DeleteRecordFromDatabase();
                if (dtg_Employee.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    ////MessageBox.Show(dtg_OfficialReceipt.Rows[e.RowIndex].Cells[1].Value.ToString());
                    //new
                    selectedEmployeeID = userControl_ProfileContributions1.lbl_EmployeeID.Text = dtg_Employee.Rows[e.RowIndex].Cells[8].Value.ToString();

                    //MessageBox.Show($"1 = {dtg_Employee.Rows[e.RowIndex].Cells[1].Value.ToString()}\n2 = {dtg_Employee.Rows[e.RowIndex].Cells[2].Value.ToString()}\n3 = {dtg_Employee.Rows[e.RowIndex].Cells[3].Value.ToString()}\n4 = {dtg_Employee.Rows[e.RowIndex].Cells[4].Value.ToString()}\n5 = {dtg_Employee.Rows[e.RowIndex].Cells[5].Value.ToString()}\n6 = {dtg_Employee.Rows[e.RowIndex].Cells[6].Value.ToString()}\n7 = {dtg_Employee.Rows[e.RowIndex].Cells[7].Value.ToString()}");
                    string fname = dtg_Employee.Rows[e.RowIndex].Cells[6].Value.ToString();
                    string lname = dtg_Employee.Rows[e.RowIndex].Cells[7].Value.ToString();
                    string mi = dtg_Employee.Rows[e.RowIndex].Cells[5].Value.ToString();
                    string apl = dtg_Employee.Rows[e.RowIndex].Cells[4].Value.ToString();
                    //new
                    userControl_ProfileContributions1.lbl_AdminName.Text = "Employee > " + fname + " " + mi + ". " + lname + " " + apl + "." + " > Contributions";
                    employeeFullName = fname + " " + mi + ". " + lname + " " + apl + ".";
                    userControl_ProfileContributions1.dtg_EmployeeContributions.DataSource = loadEmployeeProfile();

                    //userControl_ProfileContributions1.dtg_Temp.DataSource = loadEmployeeProfile();
                    CreateDatabaseForCertificate();
                    InsertContributionToDatabase();
                    //new
                    userControl_ProfileContributions1.datepicker_FromDate.Value = getStartDate;
                    userControl_ProfileContributions1.datepicker_ToDate.Value = getEndDate;
                    userControl_ProfileContributions1.Visible = true;

                }
            }
        }

        public void CreateDatabaseForCertificate()
        {
            DataTable t = new DataTable();

            t.Columns.Add("Employee Name", typeof(string));
            t.Columns.Add("Period Covered", typeof(string));
            t.Columns.Add("Official Receipt No.", typeof(string));
            t.Columns.Add("Date Remitted", typeof(string));
            t.Columns.Add("Pag-ibig", typeof(string));
            t.Columns.Add("Philhealth", typeof(string));
            t.Columns.Add("GSIS", typeof(string));
            //UserControl_ProfileContributions uc = new UserControl_ProfileContributions();

            //new
            for (int i = 0; i < userControl_ProfileContributions1.dtg_EmployeeContributions.Rows.Count; i++)
            {
                if (i == 0)
                    getEndDate = Convert.ToDateTime(userControl_ProfileContributions1.dtg_EmployeeContributions.Rows[i].Cells[4].Value.ToString()); //Date Remitted
                if (i == userControl_ProfileContributions1.dtg_EmployeeContributions.Rows.Count - 1)
                    getStartDate = Convert.ToDateTime(userControl_ProfileContributions1.dtg_EmployeeContributions.Rows[i].Cells[4].Value.ToString()); //Date Remitted

                DateTime date = Convert.ToDateTime(userControl_ProfileContributions1.dtg_EmployeeContributions.Rows[i].Cells[4].Value.ToString());
                string month = date.ToString("MMMM");

                t.Rows.Add(
                    employeeFullName, //Employee Name
                    month,              //Month Period
                    userControl_ProfileContributions1.dtg_EmployeeContributions.Rows[i].Cells[3].Value.ToString(), //Official Receipt
                    userControl_ProfileContributions1.dtg_EmployeeContributions.Rows[i].Cells[4].Value.ToString(), //Date Remitted
                    userControl_ProfileContributions1.dtg_EmployeeContributions.Rows[i].Cells[2].Value.ToString(), //pag-ibig
                    userControl_ProfileContributions1.dtg_EmployeeContributions.Rows[i].Cells[1].Value.ToString(), //philhealth
                    userControl_ProfileContributions1.dtg_EmployeeContributions.Rows[i].Cells[0].Value.ToString() //GSIS
                    );
            }
            userControl_ProfileContributions1.dtg_Temp.DataSource = t;
        }   

        public void InsertContributionToDatabase()
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd;Convert Zero Datetime=True"))
            {
                try
                {
                    MySqlCommand command = new MySqlCommand();
                    string storedProc = "InsertToCertificate";

                    command = new MySqlCommand(storedProc, con);
                    command.CommandType = CommandType.StoredProcedure;
                    //new   
                    for (int i = 0; i < userControl_ProfileContributions1.dtg_Temp.Rows.Count - 1; i++)
                    {
                        con.Open();

                        DateTime date = Convert.ToDateTime(userControl_ProfileContributions1.dtg_EmployeeContributions.Rows[i].Cells[4].Value.ToString());
                        DateTime previous = date.AddDays(-30);
                        string month;
                        if (date.ToString("MMMM") == "February")
                        {
                            month = previous.ToString("MMMM") + " " + date.Year;
                        }
                        else
                        {
                            month = previous.ToString("MMMM");
                        }

                        DateTime current = Convert.ToDateTime(userControl_ProfileContributions1.dtg_EmployeeContributions.Rows[i].Cells[4].Value.ToString());
                        string dateConverted = current.ToString("yyyy-MM-dd");

                        command.Parameters.AddWithValue("_EmpName", employeeFullName.ToString());
                        command.Parameters.AddWithValue("_PeriodCovered", month);
                        command.Parameters.AddWithValue("_OfficialReceipt", userControl_ProfileContributions1.dtg_EmployeeContributions.Rows[i].Cells[3].Value.ToString());
                        command.Parameters.AddWithValue("_DateRemitted", dateConverted);
                        command.Parameters.AddWithValue("_Pagibig", Convert.ToDecimal(userControl_ProfileContributions1.dtg_EmployeeContributions.Rows[i].Cells[2].Value.ToString()));
                        command.Parameters.AddWithValue("_Philhealth", Convert.ToDecimal(userControl_ProfileContributions1.dtg_EmployeeContributions.Rows[i].Cells[1].Value.ToString()));
                        command.Parameters.AddWithValue("_GSIS", Convert.ToDecimal(userControl_ProfileContributions1.dtg_EmployeeContributions.Rows[i].Cells[0].Value.ToString()));

                        command.ExecuteNonQuery();
                        con.Close();
                        command.Parameters.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void DeleteRecordFromDatabase()
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd;Convert Zero Datetime=True"))
            {
                try
                {
                    MySqlCommand command = new MySqlCommand();
                    string query = string.Format($"DELETE FROM dswd.certificate WHERE OfficialReceipt > 0");
                    command = new MySqlCommand(query, con);
                    command.CommandType = CommandType.Text;
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private BindingSource loadEmployeeProfile()
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd;Convert Zero Datetime=True"))
            {
                string viewEmployeeProfile = string.Format($"SELECT GSIS, Philhealth, Pag_ibig, or_no as '# OR', DATE FROM dswd.excelfile WHERE employee_id = '{selectedEmployeeID}' ORDER by date desc");

                MySqlCommand cmd = new MySqlCommand(viewEmployeeProfile, con);

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataSet ds = new DataSet();
                BindingSource bs = new BindingSource();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);

                bs.DataSource = ds.Tables[0];

                return bs;
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            searchEmployeeID(txt_Search.Text);
        }

        public void searchEmployeeID(string valueToFind)
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd;Convert Zero Datetime=True"))
            {
                string searchEmployeeID = string.Format($"SELECT Status, Department, APL, MI, First_Name as 'First Name', Last_Name as 'Last Name', Employee_ID as 'Employee ID' FROM dswd.excelfile WHERE Employee_ID LIKE '{valueToFind}%' GROUP by employee_ID");
                MySqlDataAdapter ad = new MySqlDataAdapter(searchEmployeeID, con);
                DataTable table = new DataTable();
                ad.Fill(table);
                dtg_Employee.DataSource = table;
            }
        }

        private void userControl_ProfileContributions1_Load(object sender, EventArgs e)
        {

        }

        public void ViewDepartmentBy(string valueToSort)
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd;Convert Zero Datetime=True"))
            {
                string searchEmployeeID = string.Format($"SELECT Status, Department, APL, MI, First_Name as 'First Name', Last_Name as 'Last Name', Employee_ID as 'Employee ID' FROM dswd.excelfile WHERE Department LIKE '{valueToSort}%' GROUP by employee_ID");
                MySqlDataAdapter ad = new MySqlDataAdapter(searchEmployeeID, con);
                DataTable table = new DataTable();
                ad.Fill(table);
                dtg_Employee.DataSource = table;
            }
        }

        public void ViewStatusBy(string valueToSort)
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd;Convert Zero Datetime=True"))
            {
                string searchEmployeeID = string.Format($"SELECT Status, Department, APL, MI, First_Name as 'First Name', Last_Name as 'Last Name', Employee_ID as 'Employee ID' FROM dswd.excelfile WHERE Status LIKE '{valueToSort}%' GROUP by employee_ID");
                MySqlDataAdapter ad = new MySqlDataAdapter(searchEmployeeID, con);
                DataTable table = new DataTable();
                ad.Fill(table);
                dtg_Employee.DataSource = table;
            }
        }

        private void cb_Sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            //0 - View by
            //1- Department: IT
            //2- Department: ACC
            //3 - Department: Cash - Section
            //4 - Status: Contractual
            //5 - Status: Regular
            
            if (cb_Sort.SelectedIndex == 1)
            {
                ViewDepartmentBy("IT");
            }
            else if(cb_Sort.SelectedIndex == 2)
            {
                ViewDepartmentBy("ACC");
            }
            else if (cb_Sort.SelectedIndex == 3)
            {
                ViewDepartmentBy("Cash");
            }
            else if (cb_Sort.SelectedIndex == 4)
            {
                ViewStatusBy("CONTRACTUAL");
            }
            else if (cb_Sort.SelectedIndex == 5)
            {
                ViewStatusBy("Regular");
            }
        }

        private void btn_ViewAll_Click(object sender, EventArgs e)
        {
            cb_Sort.SelectedIndex = 0;
            dtg_Employee.DataSource = loadEmployeeList();
        }

        private void timeZone1_Load(object sender, EventArgs e)
        {

        }
    }
}
