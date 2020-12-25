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
    public partial class AddAdminDetails : Form
    {
        public AddAdminDetails()
        {
            InitializeComponent();
        }

        private void AddAdminDetails_Load(object sender, EventArgs e)
        {
            
        }
       
        private void btn_Save_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd;Convert Zero Datetime=True"))
            {
                try
                {
                    con.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.CommandText = string.Format($"SELECT * FROM dswd.admin WHERE empID = '{lbl_EmployeeNo.Text}'");
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    MySqlDataReader reader = command.ExecuteReader();
                    bool existing = reader.HasRows;
                    con.Close();

                    string storedProc = existing ? "UpdateAdminDetails" : "InsertAdminDetails";
                    command = new MySqlCommand(storedProc, con);

                    command.CommandType = CommandType.StoredProcedure;
                    
                    command.Parameters.AddWithValue("_empID", AddAdmin.adminEmployeeID);
                    command.Parameters.AddWithValue("_firstname", txt_FirstName.Text);

                    command.Parameters.AddWithValue("_middlename", CapitalizeFirstLetter(txt_MiddleName.Text));
                    command.Parameters.AddWithValue("_APL", CapitalizeFirstLetter(txt_APL.Text));

                    command.Parameters.AddWithValue("_lastname", txt_LastName.Text);
                    command.Parameters.AddWithValue("_department", lbl_Department.Text.ToString());
                    command.Parameters.AddWithValue("_username", AddAdmin.username);
                    command.Parameters.AddWithValue("_password", AddAdmin.password);

                    command.Parameters.AddWithValue("_address", txt_Address.Text);
                    command.Parameters.AddWithValue("_cell_telephone", txt_ContactNo.Text);
                    command.Parameters.AddWithValue("_emailAddress", txt_Email.Text);

                    string gender;
                    if (radioButton1.Checked == true)
                        gender = radioButton1.Text;
                    else
                        gender = radioButton2.Text;
                    DateTime date = Convert.ToDateTime(datepicker_Birthdate.Value.ToString());
                    string birthdate = date.ToString("yyyy-MM-dd");

                    date = Convert.ToDateTime(datepicker_DateHired.Value.ToString());
                    string datehired = date.ToString("yyyy-MM-dd");

                    command.Parameters.AddWithValue("_sex", gender);
                    command.Parameters.AddWithValue("_birthdate", birthdate);
                    command.Parameters.AddWithValue("_birthplace", txt_Birthplace.Text);
                    command.Parameters.AddWithValue("_jobPosition", txt_JobPosition.Text);
                    command.Parameters.AddWithValue("_dateHired", datehired);

                    con.Open();
                    int affectedCount = command.ExecuteNonQuery();
                    con.Close();

                    if (affectedCount > 0)
                    {
                        MessageBox.Show($"Record already saved!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public static string CapitalizeFirstLetter(string value)
        {
            return value.First().ToString().ToUpper() + value.Substring(1);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pb_profile.SizeMode = PictureBoxSizeMode.StretchImage;
                pb_profile.Image = new Bitmap(open.FileName);
                // image file path  
                //textBox1.Text = open.FileName;
            }
        }
    }
}
