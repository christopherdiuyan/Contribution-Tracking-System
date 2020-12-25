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
    public partial class UserControl_SettingArchive : UserControl
    {
        public UserControl_SettingArchive()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            int total = dtg_Employee.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells["Selected"].Value) == true).Count();

            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd;"))
            {
                int affectedCount = 0;
                try
                {
                    if (total > 0)
                    {
                        string message = $"Are you sure you want to restore {total} row?";
                        if (total > 1)
                        {
                            message = $"Are you sure you want to restore {total} row?";
                        }
                        if (MessageBox.Show(message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int x = dtg_Employee.RowCount - 1; x >= 0; x--)
                            {
                                DataGridViewRow row = dtg_Employee.Rows[x];
                                if (Convert.ToBoolean(row.Cells["Selected"].Value) == true)
                                {
                                    //RemoveDuplicates(date, OR_No, emp_id);
                                    //MessageBox.Show($"Selected row: {row.Cells[1].RowIndex.ToString()}");
                                    con.Open();

                                    MySqlCommand command = new MySqlCommand();
                                    command = new MySqlCommand($"INSERT INTO dswd.excelfile SELECT * from dswd.archivedrecords WHERE Employee_ID = '{row.Cells[6].Value.ToString()}'", con);

                                    affectedCount = command.ExecuteNonQuery();
                                    con.Close();
                                    MySqlCommand command2 = new MySqlCommand();

                                    con.Open();
                                    command2 = new MySqlCommand($"DELETE from dswd.archivedrecords WHERE Employee_ID = '{row.Cells[6].Value.ToString()}'", con);
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
                        MessageBox.Show($"Retrieved Successfully!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                }
            }
        }

        private void UserControl_SettingArchive_Load(object sender, EventArgs e)
        {
            dtg_Employee.DataSource = loadEmployeeList();
        }

        private void RemoveDuplicates(string date, int OR_No, int emp_id)
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd"))
            {
                DateTime bd = Convert.ToDateTime(date.ToString());
                string dateConverted = bd.ToString("yyyy-MM-dd");

                con.Open();
                MySqlCommand command = new MySqlCommand();

                command.CommandText = string.Format("SELECT date, or_no, employee_id FROM dswd.excelfile WHERE date = '" + dateConverted + "' and or_no = '" + OR_No + "' and employee_id = '" + emp_id + "'");
                command.CommandType = CommandType.Text;
                command.Connection = con;

                MySqlDataReader reader = command.ExecuteReader();

                bool existing = reader.HasRows; //check if there is duplicate entry existing in the database
                con.Close();

                if (existing)
                {
                    con.Open();

                    //delete duplicate
                    command.CommandText = string.Format("DELETE FROM dswd.excelfile WHERE date = '" + dateConverted + "' and or_no = '" + OR_No + "' and employee_id = '" + emp_id + "'");
                    command.CommandType = CommandType.Text;
                    command.Connection = con;
                    command.ExecuteReader();
                    con.Close();
                }

            }
        }
    }
}
