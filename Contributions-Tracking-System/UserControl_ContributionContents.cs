using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Contributions_Tracking_System
{
    public partial class UserControl_ContributionContents : UserControl
    {
        public UserControl_ContributionContents()
        {
            InitializeComponent();
        }

        private void UserControl_ContributionContents_Load(object sender, EventArgs e)
        {
            dtg_OfficialReceiptContents.DataSource = loadSelectedOR();
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private BindingSource loadSelectedOR()
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd;Convert Zero Datetime=True"))
            {
                string viewImportFile = string.Format($"SELECT status as Status, department as Department, apl as APL, mi as 'M.I', first_name as 'First Name', last_name as 'Last Name', employee_id as 'Employee ID' FROM dswd.excelfile WHERE Or_no = '{UserControl_Contributions.selectedOfficialReceipt}'order by employee_id");

                MySqlCommand cmd = new MySqlCommand(viewImportFile, con);

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataSet ds = new DataSet();
                BindingSource bs = new BindingSource();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);

                bs.DataSource = ds.Tables[0];

                return bs;
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            searchEmployeeID(txt_Search.Text);
        }

        public void searchEmployeeID(string valueToFind)
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd;Convert Zero Datetime=True"))
            {
                string searchEmployeeID = string.Format($"SELECT status as Status, department as Department, apl as APL, mi as 'M.I', first_name as 'First Name', last_name as 'Last Name', employee_id as 'Employee ID' FROM dswd.excelfile WHERE Or_No = '{UserControl_Contributions.selectedOfficialReceipt}' AND employee_id LIKE '{valueToFind}%'");
                MySqlDataAdapter ad = new MySqlDataAdapter(searchEmployeeID, con);
                DataTable table = new DataTable();
                ad.Fill(table);
                dtg_OfficialReceiptContents.DataSource = table;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            int employeeID;
            if (int.TryParse(txt_Search.Text, out employeeID))
            {
                using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd"))
                {
                    con.Open();
                    MySqlCommand command = new MySqlCommand();

                    command.CommandText = string.Format($"SELECT status as Status, department as Department, apl as APL, mi as 'M.I', first_name as 'First Name', last_name as 'Last Name', employee_id as 'Employee ID' FROM dswd.excelfile WHERE Or_No = '{UserControl_Contributions.selectedOfficialReceipt}' AND employee_id = '{txt_Search.Text}'");
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

        private void dtg_OfficialReceiptContents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }
    }
}
