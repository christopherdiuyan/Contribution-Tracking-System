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
    public partial class AddAdmin : Form
    {
        public static string adminEmployeeID;
        public static string adminFullName, department, username, password;
        public AddAdmin()
        {
            InitializeComponent();
        }

        public static string RandomNumber()
        {
            Random random = new Random();
            long randnum2 = (long)(random.NextDouble() * 99999999999) + 10000000000;
            return randnum2.ToString();
        }

        private void AddAdmin_Load(object sender, EventArgs e)
        {

            adminEmployeeID = txt_EmployeeID.Text = RandomNumber().ToString();
            
        }

        private void p_Content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidEntry())
                {
                    string fname = txt_FirstName.Text.ToString();
                    string lname = txt_LastName.Text.ToString();
                    //Capitalize the first letter
                    adminFullName = lname.First().ToString().ToUpper() + lname.Substring(1) +" "+ fname.First().ToString().ToUpper() + fname.Substring(1); 
                    department = cb_Department.selectedValue.ToUpper();
                    username = txt_Username.Text.ToString();
                    password = txt_ReTypePassword.Text.ToString();
                    
                    AddAdminDetails form = new AddAdminDetails();

                    form.lbl_AdminName.Text = adminFullName;
                    form.lbl_EmployeeNo.Text = adminEmployeeID;
                    form.lbl_Department.Text = department;

                    this.Hide();
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public bool ValidEntry()
        {
            bool condition = true;
            if(txt_EmployeeID.Text == "")
            {
                lbl_ErrorMessage_EmployeeID.Text = "Enter Employee ID";
                lbl_ErrorMessage_EmployeeID.Visible = true;
                condition =  false;
            }
            else
            {
                lbl_ErrorMessage_EmployeeID.Text = "";
                lbl_ErrorMessage_EmployeeID.Visible = false;
            }

            if (txt_FirstName.Text == "")
            {
                lbl_ErrorMessage_FirstName.Text = "Enter first name";
                lbl_ErrorMessage_FirstName.Visible = true;
                condition = false;
            }
            else
            {
                lbl_ErrorMessage_FirstName.Text = "";
                lbl_ErrorMessage_FirstName.Visible = false;
            }

            if (txt_LastName.Text == "")
            {
                lbl_ErrorMessage_LastName.Text = "Enter last name";
                lbl_ErrorMessage_LastName.Visible = true;
                condition = false;
            }
            else
            {
                lbl_ErrorMessage_LastName.Text = "";
                lbl_ErrorMessage_LastName.Visible = false;
            }

            if (cb_Department.selectedIndex == 0)
            {
                lbl_ErrorMessage_Department.Text = "Choose a Department";
                lbl_ErrorMessage_Department.Visible = true;
                condition = false;
            }
            else
            {
                lbl_ErrorMessage_Department.Text = "";
                lbl_ErrorMessage_Department.Visible = false;
            }   

            if (txt_Username.Text == "")
            {
                lbl_ErrorMessage_Username.Text = "Enter username";
                lbl_ErrorMessage_Username.Visible = true;
                condition = false;
            }
            else
            {
                lbl_ErrorMessage_Username.Text = "";
                lbl_ErrorMessage_Username.Visible = false;
            }

            if (txt_TypePassword.Text == "")
            {
                lbl_ErrorMessage_TypePassword.Text = "\n               Enter password";
                lbl_ErrorMessage_TypePassword.Visible = true;
                condition = false;
            }
            else if(txt_TypePassword.Text.Length < 8)
            {
                lbl_ErrorMessage_TypePassword.Text = "Use 8 characters or\nmore of your passwords.";
                lbl_ErrorMessage_TypePassword.Visible = true;
                condition = false;
            }
            else
            {
                lbl_ErrorMessage_TypePassword.Text = "";
                lbl_ErrorMessage_TypePassword.Visible = false;
            }

            if (txt_TypePassword.Text != txt_ReTypePassword.Text)
            {
                lbl_ErrorMessage_ReTypePassword.Text = "Those passwords didn't match.\nTry again.";
                lbl_ErrorMessage_ReTypePassword.Visible = true;
                condition = false;
            }
            else
            {
                lbl_ErrorMessage_ReTypePassword.Text = "";
                lbl_ErrorMessage_ReTypePassword.Visible = false;
            }

            return condition;
        }
    }
    
}

