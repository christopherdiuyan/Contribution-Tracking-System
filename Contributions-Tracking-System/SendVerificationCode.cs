using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contributions_Tracking_System
{
    public partial class SendVerificationCode : UserControl
    {
        public SendVerificationCode()
        {
            InitializeComponent();
        }

        private void bunifuSeparator2_Load(object sender, EventArgs e)
        {

        }

        private void btn_Continue_Click(object sender, EventArgs e)
        {
            if(ForgetPassword.randomCode == (txt_Code.Text).ToString())
            {
                lbl_ErrorMessage_Code.Visible = false;
                ForgetPassword.to = ForgetPassword.adminEmail;
                userControl_ForgotPassword1.Visible = true;
            }
            else
            {
                lbl_ErrorMessage_Code.Visible = true;
            }
        }

        private void userControl_ForgotPassword1_Load(object sender, EventArgs e)
        {

        }
    }
}
