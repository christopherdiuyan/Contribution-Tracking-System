using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Contributions_Tracking_System
{
    public partial class ExcelSheetName : Form
    {
        public static int countDuplicates = 0;
        public static int totalDuplicates;
        public static List<DuplicateEntry> e_list = new List<DuplicateEntry>();

        public ExcelSheetName()
        {
            InitializeComponent();
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

        private void btn_Import_Click(object sender, EventArgs e)
        {
            try
            {
                string pathconn = "Provider = Microsoft.jet.OLEDB.4.0; Data source=" + BrowseFile.filePath + ";Extended Properties=\"Excel 8.0;HDR= yes;\";";
                OleDbConnection conn = new OleDbConnection(pathconn);
                OleDbDataAdapter MyDataAdapter = new OleDbDataAdapter("Select * from [" + txt_ExcelSheetName.Text + "$]", conn);
                DataTable dt = new DataTable();
                MyDataAdapter.Fill(dt);
                dtg_ExcelFile.DataSource = dt;
               
                if (txt_ExcelSheetName.Text == "")
                {
                    MessageBox.Show("Sheet Name is Required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Record not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string date;
            try
            {
                using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd"))
                {

                    MySqlCommand command = new MySqlCommand();
                    string storedProc = "ImportExcelFile";

                    command = new MySqlCommand(storedProc, con);
                    
                    command.CommandType = CommandType.StoredProcedure;
                    int affectedCount = 0;
                    //for (int i = 0; i < dtg_ExcelFile.Rows.Count - 1; i++) 
                    foreach(DataGridViewRow row in dtg_ExcelFile.Rows) //reads all records in excel file
                    { 
                        if (row.IsNewRow || ValidateEntry(row.Cells[0].Value.ToString(), Convert.ToInt32(row.Cells[1].Value.ToString()), Convert.ToInt32(row.Cells[2].Value.ToString())))
                        {
                            continue; //Skip duplicate entry and empty row in the Excel file
                        }      
                        con.Open();
                        
                        date = row.Cells[0].Value.ToString();

                        DateTime bd = Convert.ToDateTime(date.ToString());
                        string dateConverted = bd.ToString("yyyy-MM-dd");

                        command.Parameters.AddWithValue("_Date", dateConverted);
                        command.Parameters.AddWithValue("_OR_No", Convert.ToInt32(row.Cells[1].Value.ToString()));
                        command.Parameters.AddWithValue("_Employee_ID", Convert.ToInt32(row.Cells[2].Value.ToString()));
                        command.Parameters.AddWithValue("_Last_Name", row.Cells[3].Value.ToString().ToUpper());
                        command.Parameters.AddWithValue("_First_Name", row.Cells[4].Value.ToString().ToUpper());
                        command.Parameters.AddWithValue("_MI", row.Cells[5].Value.ToString().ToUpper());
                        command.Parameters.AddWithValue("_APL", row.Cells[6].Value.ToString().ToUpper());
                        command.Parameters.AddWithValue("_Department", row.Cells[7].Value.ToString().ToUpper());
                        command.Parameters.AddWithValue("_Status", row.Cells[8].Value.ToString().ToUpper());
                        command.Parameters.AddWithValue("_Pag_ibig", Convert.ToDecimal(row.Cells[9].Value.ToString()));
                        command.Parameters.AddWithValue("_Philhealth", Convert.ToDecimal(row.Cells[10].Value.ToString()));
                        command.Parameters.AddWithValue("_GSIS", Convert.ToDecimal(row.Cells[11].Value.ToString()));

                        affectedCount = command.ExecuteNonQuery();
                        con.Close();
                        command.Parameters.Clear();
                    } // end of loop
                    if (affectedCount > 0)
                    {
                        con.Open();
                        MySqlCommand comm1 = new MySqlCommand($"SELECT count(DISTINCT employee_id) FROM dswd.excelfile WHERE Status = 'CONTRACTUAL'", con);
                        UserControl_Dashboard.contractualCount = Convert.ToInt32(comm1.ExecuteScalar());

                        MySqlCommand comm2 = new MySqlCommand($"SELECT count(DISTINCT employee_id) FROM dswd.excelfile WHERE Status = 'REGULAR'", con);
                        UserControl_Dashboard.regularCount = Convert.ToInt32(comm2.ExecuteScalar());

                        MySqlCommand comm3 = new MySqlCommand($"SELECT count(DISTINCT employee_id)  FROM dswd.excelfile", con);
                        UserControl_Dashboard.employeesCount = Convert.ToInt32(comm3.ExecuteScalar());

                        con.Close();
                        MessageBox.Show($"Import Successfully!\nEncounter {countDuplicates} duplicates!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if(countDuplicates > 0)
                    {
                        MessageBox.Show($"Import Unsuccessfully!\nEncounter {countDuplicates} duplicates!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    countDuplicates = 0;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Invalid Format!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("MySQL Error:\n" +ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private bool ValidateEntry(string date, int OR_No, int emp_id)
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd"))
            {
                DateTime bd = Convert.ToDateTime(date.ToString());
                string dateConverted = bd.ToString("yyyy-MM-dd");

                con.Open();
                MySqlCommand command = new MySqlCommand();

                command.CommandText = string.Format("SELECT date, or_no, employee_id FROM dswd.excelfile WHERE date = '" + dateConverted + "' and or_no = '" +OR_No+ "' and employee_id = '" +emp_id+ "'");
                command.CommandType = CommandType.Text;
                command.Connection = con;

                MySqlDataReader reader = command.ExecuteReader();
                
                bool existing = reader.HasRows; //check if there is duplicate entry existing in the database
                con.Close();

                if (existing)
                {
                    e_list.Add(new DuplicateEntry() { Date = dateConverted, Official_Number = OR_No, Employee_ID = emp_id });
                    //con.Open();
                    ////delete duplicate
                    //command.CommandText = string.Format("DELETE FROM dswd.excelfile WHERE date = '" + dateConverted + "' and or_no = '" + OR_No + "' and employee_id = '" + emp_id + "'");
                    //command.CommandType = CommandType.Text;
                    //command.Connection = con;
                    //command.ExecuteReader();
                    //con.Close();
                    countDuplicates++;
                    totalDuplicates = countDuplicates;
                    linkLabel_ViewDuplicates.Visible = true;
                    return true;
                }
                else
                    return false;
            }
        }

        private void ExcelSheetName_Load(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(BrowseFile.filePath);// getting the file path of uploaded file 
            // Get File Name  
            txt_ExcelFileName.Text = fi.Name;
        }

        private void linkLabel_ViewDuplicates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewDuplicate form = new ViewDuplicate(e_list);
            List<DuplicateEntry> emp = form.dtg_DuplicateEntry.DataSource as List<DuplicateEntry>;
            form.ShowDialog();

            form.dtg_DuplicateEntry.DataSource = e_list;
            //form.lbl_TotalDuplicates.Text = $"Total of Employees: {ExcelSheetName.totalDuplicates}";
        }
    }
}
