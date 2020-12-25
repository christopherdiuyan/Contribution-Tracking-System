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
    public partial class ProfileAdmin : Form
    {
        public ProfileAdmin()
        {
            InitializeComponent();
        }

        private void ProfileAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd"))
                {
                    con.Open();

                    MySqlCommand command = new MySqlCommand();
                    command.CommandText = $"SELECT * FROM dswd.admin WHERE username= '{Login.user}' and password = '{Login.pass}'";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    MySqlDataReader reader = command.ExecuteReader();
                    AddAdminDetails form = new AddAdminDetails();

                    if (reader.Read())
                    {
                        lbl_AdminName.Text = (reader["firstname"].ToString()) + " " + (reader["lastname"].ToString());
                        lbl_EmployeeNo.Text = reader["empID"].ToString();
                        lbl_Department.Text = reader["department"].ToString();

                        txt_FirstName.Text = reader["firstname"].ToString();
                        txt_MiddleName.Text = reader["middlename"].ToString();
                        txt_APL.Text = reader["APL"].ToString();
                        txt_LastName.Text = reader["lastname"].ToString();
                        txt_Address.Text = reader["address"].ToString();
                        txt_ContactNo.Text = reader["cell/telephone"].ToString();
                        txt_Email.Text = reader["emailAddress"].ToString();

                        if(reader["sex"].ToString() == "Male")
                        {
                            radioButton_Male.Checked = true;
                            radioButton_Female.Checked = false;
                        }
                        else
                        {
                            radioButton_Male.Checked = false;
                            radioButton_Female.Checked = true;
                        }

                        datepicker_Birthdate.Value = Convert.ToDateTime(reader["birthdate"].ToString());
                        txt_Birthplace.Text = reader["birthplace"].ToString();
                        txt_JobPosition.Text = reader["jobPosition"].ToString();
                        datepicker_DateHired.Value = Convert.ToDateTime(reader["dateHired"].ToString());
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:\n{ex}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                     
                    command = new MySqlCommand("UpdateAdminDetails", con);

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("_empID", lbl_EmployeeNo.Text);
                    command.Parameters.AddWithValue("_firstname", txt_FirstName.Text);

                    command.Parameters.AddWithValue("_middlename", CapitalizeFirstLetter(txt_MiddleName.Text));
                    command.Parameters.AddWithValue("_APL", CapitalizeFirstLetter(txt_APL.Text));

                    command.Parameters.AddWithValue("_lastname", txt_LastName.Text);
                    command.Parameters.AddWithValue("_department", lbl_Department.Text.ToString());
                    command.Parameters.AddWithValue("_username", Login.user);
                    command.Parameters.AddWithValue("_password", Login.pass);

                    command.Parameters.AddWithValue("_address", txt_Address.Text);
                    command.Parameters.AddWithValue("_cell_telephone", txt_ContactNo.Text);
                    command.Parameters.AddWithValue("_emailAddress", txt_Email.Text);

                    string gender;
                    if (radioButton_Male.Checked == true)
                        gender = radioButton_Male.Text;
                    else
                        gender = radioButton_Female.Text;

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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
