using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;

namespace Contributions_Tracking_System
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {

        public static string adminFullName, user, pass;
        public Login()
        {
            MaterialSkinManager skinManager;
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey600, Primary.BlueGrey900, Primary.BlueGrey900, Accent.LightBlue200, TextShade.WHITE);
            pb_Login.Controls.Add(btn_Login);
            btn_Login.BackColor = Color.Transparent;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd"))
                {
                    con.Open();

                    MySqlCommand command = new MySqlCommand();
                    command.CommandText = $"SELECT * FROM dswd.admin WHERE username= '{txt_Username.Text}' and password = '{txt_Password.Text}'";
                    user = txt_Username.Text;
                    pass = txt_Password.Text;
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        adminFullName = (reader["firstname"].ToString()) + " " + (reader["lastname"].ToString());
                    }

                    bool existing = reader.HasRows;
                    con.Close();

                    if (existing)
                    {
                        con.Open();
                        MySqlCommand comm1 = new MySqlCommand($"SELECT count(DISTINCT employee_id) FROM dswd.excelfile WHERE Status LIKE 'CONTRACTUAL%'", con);
                        UserControl_Dashboard.contractualCount = Convert.ToInt32(comm1.ExecuteScalar());

                        MySqlCommand comm2 = new MySqlCommand($"SELECT count(DISTINCT employee_id) FROM dswd.excelfile WHERE Status LIKE 'REGULAR%'", con);
                        UserControl_Dashboard.regularCount = Convert.ToInt32(comm2.ExecuteScalar());

                        MySqlCommand comm3 = new MySqlCommand($"SELECT count(DISTINCT employee_id)  FROM dswd.excelfile", con);
                        UserControl_Dashboard.employeesCount = Convert.ToInt32(comm3.ExecuteScalar());

                        con.Close();
                        MessageBox.Show("Successfully login!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dashboard db = new Dashboard();
                        db.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Records Not Found!\n{ex}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //new ForgotPassword().Show();
            new ForgetPassword().ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_Password.isPassword = PasswordPropertyTextAttribute.No.Password;
            }
            else
            {
                //Hides Textbox password
                txt_Password.isPassword = PasswordPropertyTextAttribute.Yes.Password;
            }
        }

        private void txt_Password_Enter(object sender, EventArgs e)
        {
            if(txt_Password.Text == "Password")
            {
                txt_Password.Text = "";
                txt_Password.ForeColor = Color.Black;
                txt_Password.isPassword = true;
            }
        }

        private void txt_Password_Leave(object sender, EventArgs e)
        {
            if (txt_Password.Text == "")
            {
                txt_Password.Text = "Password";
                txt_Password.ForeColor = Color.Silver;
                txt_Password.isPassword = false;
            }
        }
    }
}
