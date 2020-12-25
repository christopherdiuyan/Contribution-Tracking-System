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
using System.Net;
using System.Net.Mail;

namespace Contributions_Tracking_System
{
    public partial class ForgetPassword : Form
    {
        public static string adminEmail;

        public static string randomCode;
        public static string to;

        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void txt_Email_Enter(object sender, EventArgs e)
        {
            if (txt_Email.Text == "Email*")
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd"))
            {
                try
                {
                    if (txt_Email.Text == "")
                    {
                        lbl_ErrorMessage_Email.Visible = true;
                    }
                    else
                    {
                        lbl_ErrorMessage_Email.Visible = false;

                        var eMailValidator = new System.Net.Mail.MailAddress(txt_Email.Text);

                        adminEmail = Convert.ToString(eMailValidator);
                        sendVerificationCode1.lbl_Email.Text = adminEmail;

                        con.Open();
                        MySqlCommand command = new MySqlCommand();
                        command.CommandText = $"SELECT * FROM dswd.admin WHERE emailAddress = '{adminEmail}'";
                        command.CommandType = CommandType.Text;
                        command.Connection = con;

                        MySqlDataReader reader = command.ExecuteReader();
                        bool existing = reader.HasRows;

                        if (existing)
                        {
                            string from, pass, messageBody;
                            Random rand = new Random();
                            randomCode = (rand.Next(999999)).ToString();
                            MailMessage message = new MailMessage();

                            to = (txt_Email.Text).ToString();

                            from = "dswd.pupdiuyanmoderator@gmail.com";
                            pass = "trackingsystem09";
                            messageBody = $"You asked us to reset your forgotten password. To complete the process, please enter the following code:\n{randomCode}";
                            
                            message.To.Add(to);
                            message.From = new MailAddress(from);
                            message.Body = messageBody;
                            message.Subject = "Forgotten Password";

                            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                            smtp.EnableSsl = true;
                            smtp.Port = 587;
                            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                            smtp.Credentials = new NetworkCredential(from, pass);

                            try
                            {
                                smtp.Send(message);
                                MessageBox.Show("Code send successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                sendVerificationCode1.Visible = true;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
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

        private void sendVerificationCode1_Load(object sender, EventArgs e)
        {

        }
    }
}
