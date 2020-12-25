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
using CrystalDecisions.CrystalReports.Engine;

namespace Contributions_Tracking_System
{
    public partial class UserControl_ProfileContributions : UserControl
    {
        public static DateTime startDate;
        public static DateTime endDate;

        public UserControl_ProfileContributions()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker2_onValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UserControl_ProfileContributions_Load(object sender, EventArgs e)
        {
            datepicker_FromDate.Value = UserControl_Employee.getStartDate;
            datepicker_ToDate.Value = UserControl_Employee.getEndDate;
            dtg_EmployeeContributions.DataSource = loadAllContributions();
        }
        
        private void btn_Create_Click(object sender, EventArgs e) //view all
        {
            datepicker_FromDate.Value = UserControl_Employee.getStartDate;
            datepicker_ToDate.Value = UserControl_Employee.getEndDate;
            dtg_EmployeeContributions.DataSource = loadAllContributions();
        }

        private BindingSource loadAllContributions()
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd;Convert Zero Datetime=True"))
            {
                DateTime bd = Convert.ToDateTime(datepicker_FromDate.Value.ToString());
                string fromDate = bd.ToString("yyyy-MM-dd");

                bd = Convert.ToDateTime(datepicker_ToDate.Value.ToString());
                string toDate = bd.ToString("yyyy-MM-dd");

                string viewEmployeeContributions = string.Format($"SELECT GSIS, Philhealth, Pag_ibig, or_no as '# OR', DATE FROM dswd.excelfile WHERE employee_id = '{UserControl_Employee.selectedEmployeeID}' ORDER by date desc");

                MySqlCommand cmd = new MySqlCommand(viewEmployeeContributions, con);

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataSet ds = new DataSet();
                BindingSource bs = new BindingSource();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);

                bs.DataSource = ds.Tables[0];

                return bs;
            }
        }

        private void datepicker_FromDate_onValueChanged(object sender, EventArgs e)
        {
            dtg_EmployeeContributions.DataSource = loadSortByDate();
        }

        private void datepicker_ToDate_onValueChanged(object sender, EventArgs e)
        {
            dtg_EmployeeContributions.DataSource = loadSortByDate();
        }

        public void PreviewContributionsInCrystalReport()
        {
            PrintPreview form = new PrintPreview();
            GenerateCertificate cert = new GenerateCertificate();
            cert.SetParameterValue("StartDate", datepicker_FromDate.Value);
            cert.SetParameterValue("EndDate", datepicker_ToDate.Value);
            form.crystalReportViewer2.ReportSource = cert;
            form.crystalReportViewer2.Refresh();
        }

        private BindingSource loadSortByDate()
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Magnifiko;persistsecurityinfo=True;database=dswd;Convert Zero Datetime=True"))
            {
                DateTime bd = Convert.ToDateTime(datepicker_FromDate.Value.ToString());
                string fromDate = bd.ToString("yyyy-MM-dd");

                bd = Convert.ToDateTime(datepicker_ToDate.Value.ToString());
                string toDate = bd.ToString("yyyy-MM-dd");

                string viewEmployeeContributions = string.Format($"SELECT GSIS, Philhealth, Pag_ibig, or_no as '# OR', DATE FROM dswd.excelfile WHERE employee_id = '{UserControl_Employee.selectedEmployeeID}' and date between '{fromDate}' and '{toDate}' ORDER by date desc");

                MySqlCommand cmd = new MySqlCommand(viewEmployeeContributions, con);

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataSet ds = new DataSet();
                BindingSource bs = new BindingSource();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);

                bs.DataSource = ds.Tables[0];
                startDate = Convert.ToDateTime(fromDate);
                endDate = Convert.ToDateTime(toDate);

                return bs;
            }
        }

        private void btn_PrintCertificate_Click(object sender, EventArgs e)
        {
            new PrintPreview().ShowDialog();
        }
    }
}
