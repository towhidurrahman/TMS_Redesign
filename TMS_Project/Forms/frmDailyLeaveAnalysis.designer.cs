namespace TMS_Project
{
    partial class frmDailyLeaveAnalysis
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbLeaveType = new System.Windows.Forms.ComboBox();
            this.cmbGarden = new System.Windows.Forms.ComboBox();
            this.dtPickerDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtPickerDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblLeaveType = new System.Windows.Forms.Label();
            this.lblGarden = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reports Preview Range";
            // 
            // cmbLeaveType
            // 
            this.cmbLeaveType.FormattingEnabled = true;
            this.cmbLeaveType.Location = new System.Drawing.Point(422, 83);
            this.cmbLeaveType.Name = "cmbLeaveType";
            this.cmbLeaveType.Size = new System.Drawing.Size(91, 21);
            this.cmbLeaveType.TabIndex = 16;
            // 
            // cmbGarden
            // 
            this.cmbGarden.FormattingEnabled = true;
            this.cmbGarden.Location = new System.Drawing.Point(162, 83);
            this.cmbGarden.Name = "cmbGarden";
            this.cmbGarden.Size = new System.Drawing.Size(91, 21);
            this.cmbGarden.TabIndex = 15;
            // 
            // dtPickerDateTo
            // 
            this.dtPickerDateTo.CalendarFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerDateTo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerDateTo.Location = new System.Drawing.Point(422, 45);
            this.dtPickerDateTo.Name = "dtPickerDateTo";
            this.dtPickerDateTo.Size = new System.Drawing.Size(91, 20);
            this.dtPickerDateTo.TabIndex = 14;
            // 
            // dtPickerDateFrom
            // 
            this.dtPickerDateFrom.CalendarFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerDateFrom.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerDateFrom.Location = new System.Drawing.Point(162, 45);
            this.dtPickerDateFrom.Name = "dtPickerDateFrom";
            this.dtPickerDateFrom.Size = new System.Drawing.Size(91, 20);
            this.dtPickerDateFrom.TabIndex = 10;
            // 
            // lblLeaveType
            // 
            this.lblLeaveType.AutoSize = true;
            this.lblLeaveType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaveType.ForeColor = System.Drawing.Color.Black;
            this.lblLeaveType.Location = new System.Drawing.Point(284, 86);
            this.lblLeaveType.Name = "lblLeaveType";
            this.lblLeaveType.Size = new System.Drawing.Size(118, 13);
            this.lblLeaveType.TabIndex = 13;
            this.lblLeaveType.Text = "Leave Type                 :";
            // 
            // lblGarden
            // 
            this.lblGarden.AutoSize = true;
            this.lblGarden.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGarden.ForeColor = System.Drawing.Color.Black;
            this.lblGarden.Location = new System.Drawing.Point(37, 86);
            this.lblGarden.Name = "lblGarden";
            this.lblGarden.Size = new System.Drawing.Size(121, 13);
            this.lblGarden.TabIndex = 12;
            this.lblGarden.Text = "Garden                         :";
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTo.ForeColor = System.Drawing.Color.Black;
            this.lblDateTo.Location = new System.Drawing.Point(284, 48);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(118, 13);
            this.lblDateTo.TabIndex = 11;
            this.lblDateTo.Text = "Date To                       :";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFrom.ForeColor = System.Drawing.Color.Black;
            this.lblDateFrom.Location = new System.Drawing.Point(34, 48);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(124, 13);
            this.lblDateFrom.TabIndex = 9;
            this.lblDateFrom.Text = "Date From                     :";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(459, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(13, 127);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 17;
            this.btnPreview.Text = "&Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // frmDailyLeaveAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 160);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.cmbLeaveType);
            this.Controls.Add(this.cmbGarden);
            this.Controls.Add(this.dtPickerDateTo);
            this.Controls.Add(this.dtPickerDateFrom);
            this.Controls.Add(this.lblLeaveType);
            this.Controls.Add(this.lblGarden);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmDailyLeaveAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Leave Analysis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbLeaveType;
        private System.Windows.Forms.ComboBox cmbGarden;
        private System.Windows.Forms.DateTimePicker dtPickerDateTo;
        private System.Windows.Forms.DateTimePicker dtPickerDateFrom;
        private System.Windows.Forms.Label lblLeaveType;
        private System.Windows.Forms.Label lblGarden;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPreview;
    }
}