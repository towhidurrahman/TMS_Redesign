namespace TMS_Project
{
    partial class frmHolidayCalender
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            this.mnthCalender = new System.Windows.Forms.MonthCalendar();
            this.lblHolidayName = new System.Windows.Forms.Label();
            this.txtHolidayName = new System.Windows.Forms.TextBox();
            this.chkBoxNationalHoliday = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // mnthCalender
            // 
            this.mnthCalender.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mnthCalender.Location = new System.Drawing.Point(13, 80);
            this.mnthCalender.MaximumSize = new System.Drawing.Size(250, 0);
            this.mnthCalender.Name = "mnthCalender";
            this.mnthCalender.TabIndex = 0;
            // 
            // lblHolidayName
            // 
            this.lblHolidayName.AutoSize = true;
            this.lblHolidayName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHolidayName.ForeColor = System.Drawing.Color.Blue;
            this.lblHolidayName.Location = new System.Drawing.Point(13, 12);
            this.lblHolidayName.Name = "lblHolidayName";
            this.lblHolidayName.Size = new System.Drawing.Size(90, 13);
            this.lblHolidayName.TabIndex = 1;
            this.lblHolidayName.Text = "Holiday Name :";
            // 
            // txtHolidayName
            // 
            this.txtHolidayName.Location = new System.Drawing.Point(110, 10);
            this.txtHolidayName.Name = "txtHolidayName";
            this.txtHolidayName.Size = new System.Drawing.Size(130, 20);
            this.txtHolidayName.TabIndex = 2;
            this.txtHolidayName.TextChanged += new System.EventHandler(this.txtHolidayName_TextChanged);
            // 
            // chkBoxNationalHoliday
            // 
            this.chkBoxNationalHoliday.AutoSize = true;
            this.chkBoxNationalHoliday.Location = new System.Drawing.Point(13, 35);
            this.chkBoxNationalHoliday.Name = "chkBoxNationalHoliday";
            this.chkBoxNationalHoliday.Size = new System.Drawing.Size(103, 17);
            this.chkBoxNationalHoliday.TabIndex = 3;
            this.chkBoxNationalHoliday.Text = "National Holiday";
            this.chkBoxNationalHoliday.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(13, 249);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(62, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(96, 248);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(178, 248);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // cmbMonth
            // 
            this.cmbMonth.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(101, 52);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(77, 21);
            this.cmbMonth.TabIndex = 7;
            // 
            // cmbYear
            // 
            this.cmbYear.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(184, 52);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(56, 21);
            this.cmbYear.TabIndex = 8;
            // 
            // frmHolidayCalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 284);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chkBoxNationalHoliday);
            this.Controls.Add(this.txtHolidayName);
            this.Controls.Add(this.lblHolidayName);
            this.Controls.Add(this.mnthCalender);
            this.Name = "frmHolidayCalender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yearly Holiday";
            this.Load += new System.EventHandler(this.frmHolidayCalender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mnthCalender;
        private System.Windows.Forms.Label lblHolidayName;
        private System.Windows.Forms.TextBox txtHolidayName;
        private System.Windows.Forms.CheckBox chkBoxNationalHoliday;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbYear;
    }
}