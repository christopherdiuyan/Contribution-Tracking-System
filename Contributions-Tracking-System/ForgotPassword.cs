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
    public partial class ForgotPassword : Form
    {
        public static string adminEmail;

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void txt_Email_Enter(object sender, EventArgs e)
        {
            if(txt_Email.Text == "Email")
            {
                txt_Email.Text = "";
                txt_Email.ForeColor = Color.Black;
            }
        }

        private void txt_Email_Leave(object sender, EventArgs e)
        {
            if (txt_Email.Text == "")
            {
                txt_Email.Text = "Email";
                txt_Email.ForeColor = Color.Silver;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd"))
            {
                try
                {
                    if(txt_Email.Text == "")
                    {
                        lbl_ErrorMessage_Email.Visible = true;
                    }
                    else
                    {
                        lbl_ErrorMessage_Email.Visible = false;
                        
                        var eMailValidator = new System.Net.Mail.MailAddress(txt_Email.Text);

                        adminEmail = Convert.ToString(eMailValidator);

                        con.Open();
                        MySqlCommand command = new MySqlCommand();
                        command.CommandText = $"SELECT * FROM dswd.admin WHERE emailAddress = '{adminEmail}'";
                        command.CommandType = CommandType.Text;
                        command.Connection = con;

                        MySqlDataReader reader = command.ExecuteReader();
                        bool existing = reader.HasRows;

                        if(existing)
                        {
                            userControl_ForgotPassword1.Show();
                        }
                        else
                        {
                            MessageBox.Show("Couldn't find your System Account!\nPlease Contact your admin", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Email Format.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void checkBox_OldPassword_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void userControl_ForgotPassword1_Load(object sender, EventArgs e)
        {

        }
    }
}
