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
    public partial class UserControl_Dashboard : UserControl
    {
        public static int employeesCount, contractualCount, regularCount;
       
        public UserControl_Dashboard()
        {
            InitializeComponent();
            
            
        }

        //private void btn_Read_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        int index = dtg_Storage.CurrentCell.RowIndex;

        //        if (index > -1)
        //        {
        //            txt_Title.Text = table.Rows[index].ItemArray[0].ToString();
        //            txt_Desciption.Text = table.Rows[index].ItemArray[1].ToString();
        //        }
        //    }
        //    catch
        //    {
        //        MessageBox.Show("No records found!", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
        //    }
        //}

        //private void btn_Delete_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        int index = dtg_Storage.CurrentCell.RowIndex;
        //        table.Rows[index].Delete();
        //    }
        //    catch
        //    {
        //        MessageBox.Show("No records found!", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
        //    }
        //}

        //private void UserControl_Dashboard_Load_1(object sender, EventArgs e)
        //{
        //    table = new DataTable();
        //    table.Columns.Add("Title", typeof(String));
        //    table.Columns.Add("Description", typeof(String));

        //    dtg_Storage.DataSource = table;
        //}

        //private void btn_New_Click(object sender, EventArgs e)
        //{
        //    txt_Title.Clear();
        //    txt_Desciption.Clear();
        //}

        //private void btn_Save_Click(object sender, EventArgs e)
        //{
        //    table.Rows.Add(txt_Title.Text, txt_Desciption.Text);
        //    txt_Title.Clear();
        //    txt_Desciption.Clear();
        //}

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void p_logo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

        }

        private void UserControl_Dashboard_Load(object sender, EventArgs e)
        {
            circularProgressBar_Contractual.Value = Convert.ToInt32(contractualCount.ToString());
            circularProgressBar_Contractual.Text = Convert.ToString(contractualCount.ToString());

            circularProgressBar_Regular.Value = Convert.ToInt32(regularCount.ToString());
            circularProgressBar_Regular.Text = Convert.ToString(regularCount.ToString());

            circularProgressBar_TotalEmployees.Value = Convert.ToInt32(employeesCount.ToString());
            circularProgressBar_TotalEmployees.Text = Convert.ToString(employeesCount.ToString());
        }
    }
}
