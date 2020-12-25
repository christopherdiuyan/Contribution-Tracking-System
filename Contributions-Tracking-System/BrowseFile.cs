using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contributions_Tracking_System
{
    public partial class BrowseFile : Form
    {
        public static string filePath;
        public static string ext;
        public static string type;
        private int key = 0;

        public BrowseFile()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            CloseTransparent();
            Dashboard form = new Dashboard();
            form.TopMost = true;
        }
        public void CloseTransparent()
        {
            OpacityForm a = (OpacityForm)Application.OpenForms["OpacityForm"];
            a.Close();
            this.Close();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            OpacityForm backForm = new OpacityForm();
            try
            {
                ext = Path.GetExtension(txt_BrowseFile.Text); // getting the file extension of uploaded file  
                if (ValidEntry(ext, txt_BrowseFile.Text))   //file format valid
                {
                    //hide BrowseFile form
                    BrowseFile a = (BrowseFile)Application.OpenForms["BrowseFile"];
                    a.Hide();
                    this.Hide();

                    //show ExcelSheetName form
                    ExcelSheetName exform = new ExcelSheetName();
                    exform.ShowDialog();
                    backForm.Hide();
                    filePath = txt_BrowseFile.Text;
                } 
                else if (txt_BrowseFile.Text == String.Empty)
                {
                    MessageBox.Show("Please Import File first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!ValidEntry(ext, txt_BrowseFile.Text))
                {
                    MessageBox.Show("Invalid Format", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                txt_FileStatus.Text = "Error: " + ex.Message.ToString();
            }
        }

        private void btn_BrowseExcelFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();
            try
            {
                if (opfd.ShowDialog() == DialogResult.OK)
                {
                    filePath = opfd.FileName;// getting the file path of uploaded file 
                    txt_BrowseFile.Text = opfd.FileName;

                    ext = Path.GetExtension(txt_BrowseFile.Text); // getting the file extension of uploaded file  
                    ValidEntry(ext, txt_BrowseFile.Text); 
                }
            }
            catch (Exception ex)
            {
                txt_FileStatus.Text = "Error: " + ex.Message.ToString();
            }
        }

        private void txt_BrowseFile_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FileInfo fi = new FileInfo(txt_BrowseFile.Text);
                filePath = txt_BrowseFile.Text;// getting the file path of uploaded file
                 
                ext = Path.GetExtension(txt_BrowseFile.Text); // getting the file extension of uploaded file  
                ValidEntry(ext, txt_BrowseFile.Text);
            }
            catch (Exception ex)
            {
                txt_FileStatus.Text = "Error: " + ex.Message.ToString();
            }
        }
        public bool ValidEntry(string extension, string filepath) //Valid Extension
        {
            switch (extension) 
            {
                case ".xls":
                    //type = "application/vnd.ms-excel";
                    return FileExist(filepath);

                case ".xlsx":
                    //type = "application/vnd.ms-excel";
                    return FileExist(filepath);

                default:
                    txt_FileStatus.Text = "Select Only Excel File having extension .xlsx or .xls"; // if file is other than speified extension
                    return false;
            }
        }
        public bool FileExist(string file)
        {
            if (File.Exists(file))
            {
                txt_FileStatus.Text = "Excel File Uploaded Successfully!";
                return true;
            }
            else
            {
                txt_FileStatus.Text = "File Not Exist!"; 
                return false;
            }
        }
        
        private void BrowseFile_Load(object sender, EventArgs e)
        {

        }

        private void BrowseFile_Activated(object sender, EventArgs e)
        {
            if(key == 0)
            {
                MessageBox.Show("Please Open your Excel File first, before you proceed.", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                key++;
            }
        }
    }
}
