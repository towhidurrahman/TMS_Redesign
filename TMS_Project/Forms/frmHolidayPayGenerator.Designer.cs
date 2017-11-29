namespace TMS_Project
{
    partial class frmHolidayPayGenerator
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
            this.lblRegularDay = new System.Windows.Forms.Label();
            this.dtpDateForCalculation = new System.Windows.Forms.DateTimePicker();
            this.dtpRegularDay = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblDateForCalculation = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRegularDay);
            this.groupBox1.Controls.Add(this.dtpDateForCalculation);
            this.groupBox1.Controls.Add(this.dtpRegularDay);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnProcess);
            this.groupBox1.Controls.Add(this.lblDateForCalculation);
            this.groupBox1.Location = new System.Drawing.Point(9, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 88);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblRegularDay
            // 
            this.lblRegularDay.AutoSize = true;
            this.lblRegularDay.Location = new System.Drawing.Point(115, 19);
            this.lblRegularDay.Name = "lblRegularDay";
            this.lblRegularDay.Size = new System.Drawing.Size(66, 13);
            this.lblRegularDay.TabIndex = 14;
            this.lblRegularDay.Text = "Regular Day";
            // 
            // dtpDateForCalculation
            // 
            this.dtpDateForCalculation.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateForCalculation.Location = new System.Drawing.Point(356, 14);
            this.dtpDateForCalculation.Name = "dtpDateForCalculation";
            this.dtpDateForCalculation.Size = new System.Drawing.Size(101, 20);
            this.dtpDateForCalculation.TabIndex = 13;
            // 
            // dtpRegularDay
            // 
            this.dtpRegularDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRegularDay.Location = new System.Drawing.Point(8, 16);
            this.dtpRegularDay.Name = "dtpRegularDay";
            this.dtpRegularDay.Size = new System.Drawing.Size(101, 20);
            this.dtpRegularDay.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(392, 51);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 25);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(8, 50);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(65, 23);
            this.btnProcess.TabIndex = 10;
            this.btnProcess.Text = "&Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            // 
            // lblDateForCalculation
            // 
            this.lblDateForCalculation.AutoSize = true;
            this.lblDateForCalculation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateForCalculation.Location = new System.Drawing.Point(248, 16);
            this.lblDateForCalculation.Name = "lblDateForCalculation";
            this.lblDateForCalculation.Size = new System.Drawing.Size(102, 13);
            this.lblDateForCalculation.TabIndex = 9;
            this.lblDateForCalculation.Text = "Date for Calculation";
            // 
            // frmHolidayPayGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 96);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHolidayPayGenerator";
            this.Text = "Holiday Pay Generator";
            this.Load += new System.EventHandler(this.frmHolidayPayGenerator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRegularDay;
        private System.Windows.Forms.DateTimePicker dtpDateForCalculation;
        private System.Windows.Forms.DateTimePicker dtpRegularDay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblDateForCalculation;
    }
}