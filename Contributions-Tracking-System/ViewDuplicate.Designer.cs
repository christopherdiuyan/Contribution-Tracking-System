namespace Contributions_Tracking_System
{
    partial class ViewDuplicate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtg_DuplicateEntry = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_TotalDuplicates = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DuplicateEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_DuplicateEntry
            // 
            this.dtg_DuplicateEntry.AllowUserToAddRows = false;
            this.dtg_DuplicateEntry.AllowUserToDeleteRows = false;
            this.dtg_DuplicateEntry.AllowUserToResizeColumns = false;
            this.dtg_DuplicateEntry.AllowUserToResizeRows = false;
            this.dtg_DuplicateEntry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_DuplicateEntry.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.dtg_DuplicateEntry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_DuplicateEntry.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_DuplicateEntry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_DuplicateEntry.ColumnHeadersHeight = 30;
            this.dtg_DuplicateEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtg_DuplicateEntry.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.dtg_DuplicateEntry.Location = new System.Drawing.Point(11, 33);
            this.dtg_DuplicateEntry.Name = "dtg_DuplicateEntry";
            this.dtg_DuplicateEntry.ReadOnly = true;
            this.dtg_DuplicateEntry.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtg_DuplicateEntry.RowHeadersVisible = false;
            this.dtg_DuplicateEntry.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtg_DuplicateEntry.Size = new System.Drawing.Size(610, 351);
            this.dtg_DuplicateEntry.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "List of Duplicates Entry in the database";
            // 
            // lbl_TotalDuplicates
            // 
            this.lbl_TotalDuplicates.AutoSize = true;
            this.lbl_TotalDuplicates.Location = new System.Drawing.Point(484, 393);
            this.lbl_TotalDuplicates.Name = "lbl_TotalDuplicates";
            this.lbl_TotalDuplicates.Size = new System.Drawing.Size(133, 13);
            this.lbl_TotalDuplicates.TabIndex = 23;
            this.lbl_TotalDuplicates.Text = "Total of Employees: 99999";
            // 
            // ViewDuplicate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 413);
            this.Controls.Add(this.lbl_TotalDuplicates);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_DuplicateEntry);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewDuplicate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ViewDuplicate";
            this.Load += new System.EventHandler(this.ViewDuplicate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DuplicateEntry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dtg_DuplicateEntry;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_TotalDuplicates;
    }
}