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
    public partial class UserControl_Contributions : UserControl
    {
        public static string selectedOfficialReceipt;

        public UserControl_Contributions()
        {
            InitializeComponent();
        }

        private void UserControl_Contributions_Load(object sender, EventArgs e)
        {
            dtg_OfficialReceipt.Columns[0].HeaderText = "View Record";
            dtg_OfficialReceipt.DataSource = load();

            //userControl_ContributionContents1.Hide();
        }

        private BindingSource load()
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd;Convert Zero Datetime=True"))
            {
                string viewImportFile = string.Format("SELECT or_no as 'Official Receipt', date as Date FROM dswd.excelfile ORDER by date desc");

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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //searchOfficialReceipt(txt_Search.Text);
            int officialReceipt;
            if (int.TryParse(txt_Search.Text, out officialReceipt))
            {
                using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd"))
                {
                    con.Open();
                    MySqlCommand command = new MySqlCommand();

                    command.CommandText = string.Format($"SELECT or_no as 'Official Receipt', date as Date FROM dswd.excelfile WHERE Or_no = '{txt_Search.Text}' ORDER by date desc");
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

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            searchOfficialReceipt(txt_Search.Text);
        }

        public void searchOfficialReceipt(string valueToFind)
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd;Convert Zero Datetime=True"))
            {
                string searchOfficialReceipt = string.Format($"SELECT or_no as 'Official Receipt', date as Date FROM dswd.excelfile WHERE Or_no LIKE '{valueToFind}%'");
                MySqlDataAdapter ad = new MySqlDataAdapter(searchOfficialReceipt, con);
                DataTable table = new DataTable();
                ad.Fill(table);
                dtg_OfficialReceipt.DataSource = table;
            }
        }

        private void dtg_OfficialReceipt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dtg_OfficialReceipt.Columns[e.ColumnIndex].HeaderText == "View Record")
            {
                if (dtg_OfficialReceipt.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    //MessageBox.Show(dtg_OfficialReceipt.Rows[e.RowIndex].Cells[1].Value.ToString());
                    selectedOfficialReceipt = dtg_OfficialReceipt.Rows[e.RowIndex].Cells[1].Value.ToString();
                    //userControl_ContributionContents1.dtg_OfficialReceiptContents.DataSource = loadSelectedOR();
                    //userControl_ContributionContents1.txt_OfficialReceipt.Text = selectedOfficialReceipt;
                    //userControl_ContributionContents1.txt_Date.Text = dtg_OfficialReceipt.Rows[e.RowIndex].Cells[2].Value.ToString();
                    //userControl_ContributionContents1.Show();
                }
            }
        }
        private BindingSource loadSelectedOR()
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd;Convert Zero Datetime=True"))
            {
                string viewImportFile = string.Format($"SELECT status as Status, department as Department, apl as APL, mi as 'M.I', first_name as 'First Name', last_name as 'Last Name', employee_id as 'Employee ID' FROM dswd.excelfile WHERE Or_no = '{selectedOfficialReceipt}'order by employee_id");

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

        //private void userControl_ContributionContents1_Load(object sender, EventArgs e)
        //{

        //}
    }
}
