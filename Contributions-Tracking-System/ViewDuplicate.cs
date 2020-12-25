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
    public partial class ViewDuplicate : Form
    { 
        public ViewDuplicate(List<DuplicateEntry> templist)
        {
            InitializeComponent();
            dtg_DuplicateEntry.DataSource = templist;
            dtg_DuplicateEntry.Columns[0].HeaderText = "Date";
            dtg_DuplicateEntry.Columns[1].HeaderText = "Official Receipt";
            dtg_DuplicateEntry.Columns[2].HeaderText = "Employee ID";
            lbl_TotalDuplicates.Text = $"Total of Employees: {ExcelSheetName.totalDuplicates}";
        }

        private void ViewDuplicate_Load(object sender, EventArgs e)
        {

        }
    }
}
