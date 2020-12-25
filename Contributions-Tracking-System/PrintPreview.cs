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
    public partial class PrintPreview : Form
    {
        public PrintPreview()
        {
            InitializeComponent();
        }

        private void PrintPreview_Load(object sender, EventArgs e)
        {
            GenerateCertificate cert = new GenerateCertificate();
            cert.SetParameterValue("StartDate", UserControl_ProfileContributions.startDate);
            cert.SetParameterValue("EndDate", UserControl_ProfileContributions.endDate);
            crystalReportViewer2.ReportSource = cert;
            crystalReportViewer2.Refresh();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
