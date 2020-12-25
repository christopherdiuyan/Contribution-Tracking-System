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
    public partial class UserControl_ForgotPassword : UserControl
    {
        public UserControl_ForgotPassword()
        {
            InitializeComponent();
        }

        private void UserControl_ForgotPassword_Load(object sender, EventArgs e)
        {
            txt_NewPassword.isPassword = true;
            txt_ConfirmPassword.isPassword = true;
        }

        public bool ValidEntry()
        {
            bool condition = true;
            if (txt_NewPassword.Text == "")
            {
                lbl_ErrorMessage_NewPassword.Text = "               Enter password";
                lbl_ErrorMessage_NewPassword.Visible = true;
                condition = false;
            }
            else if (txt_NewPassword.Text.Length < 8)
            {
                lbl_ErrorMessage_NewPassword.Text = "Use 8 characters or\nmore of your passwords.";
                lbl_ErrorMessage_NewPassword.Visible = true;
                condition = false;
            }
            else
            {
                lbl_ErrorMessage_NewPassword.Text = "";
                lbl_ErrorMessage_NewPassword.Visible = false;
            }

            if (txt_NewPassword.Text != txt_ConfirmPassword.Text)
            {
                lbl_ErrorMessage_ConfirmPassword.Text = "Those passwords didn't match.\nTry again.";
                lbl_ErrorMessage_ConfirmPassword.Visible = true;
                condition = false;
            }
            else
            {
                lbl_ErrorMessage_ConfirmPassword.Text = "";
                lbl_ErrorMessage_ConfirmPassword.Visible = false;
            }

            return condition;
        }

        private void checkBox_NewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_NewPassword.Checked)
            {
                txt_NewPassword.isPassword = PasswordPropertyTextAttribute.No.Password;
                txt_ConfirmPassword.isPassword = PasswordPropertyTextAttribute.No.Password;
            }
            else
            {
                //Hides Textbox password
                txt_NewPassword.isPassword = PasswordPropertyTextAttribute.Yes.Password;
                txt_ConfirmPassword.isPassword = PasswordPropertyTextAttribute.Yes.Password;
            }
        }

        private void btn_Continue_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd"))
            {
                try
                {
                    con.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.CommandText = $"SELECT * FROM dswd.admin WHERE emailAddress = '{ForgetPassword.adminEmail}'";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    MySqlDataReader reader = command.ExecuteReader();
                    bool existing = reader.HasRows;
                    con.Close();
                    if (existing && ValidEntry())
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand($"Update dswd.admin set password = '{txt_ConfirmPassword.Text}' WHERE emailAddress = '{ForgetPassword.adminEmail}'", con);

                        int affectedCount = cmd.ExecuteNonQuery();
                        con.Close();

                        if (affectedCount > 0)
                        {
                            MessageBox.Show($"Record already saved!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        ValidEntry();
                    }
                }
                catch (Exception ex)
                {
                    //Couldn't find your System Account!\nPlease Contact your admin.
                    MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
