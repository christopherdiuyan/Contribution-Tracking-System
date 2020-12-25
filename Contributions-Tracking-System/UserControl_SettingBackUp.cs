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
    public partial class UserControl_SettingBackUp : UserControl
    {
        public UserControl_SettingBackUp()
        {
            InitializeComponent();
        }

        private void UserControl_BackUp_Load(object sender, EventArgs e)
        {

        }

        private void Backup()
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd;Convert Zero Datetime=True"))
            {
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(txt_Path.Text);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error\n{ex}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    conn.Close();
                    lbl_Success.Visible = true;
                    progressBar.Value = 100;
                }
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_Path.Text = saveFileDialog1.FileName;
                Backup();
            }
        }
    }
}
