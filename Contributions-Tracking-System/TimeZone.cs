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
    public partial class TimeZone : UserControl
    {
        public TimeZone()
        {
            InitializeComponent();
        }

        private void TimeZone_Load(object sender, EventArgs e)
        {
            try
            {
                timer1.Start();
                lbl_Sec.Text = DateTime.Now.ToString("ss");
                lbl_Timezone.Text = DateTime.Now.ToString("tt");
                lbl_Hour.Text = DateTime.Now.ToString("hh:mm");
                lbl_Day.Text = DateTime.Now.ToString("dddd");
                lbl_Date.Text = DateTime.Now.ToString("dd/M/yyyy");

            }
            catch (Exception)
            {
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Sec.Text = DateTime.Now.ToString("ss");
            lbl_Timezone.Text = DateTime.Now.ToString("tt");
            lbl_Hour.Text = DateTime.Now.ToString("hh:mm");
            lbl_Day.Text = DateTime.Now.ToString("dddd");
            lbl_Date.Text = DateTime.Now.ToString("dd/M/yyyy");
            timer1.Start();
        }
    }
}
