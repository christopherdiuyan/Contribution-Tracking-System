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
    public partial class UserControl_SettingAdmin : UserControl
    {
        public UserControl_SettingAdmin()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            try
            {
                AddAdmin form = new AddAdmin();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            new ProfileAdmin().ShowDialog();
        }

        private void UserControl_SettingAdmin_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
