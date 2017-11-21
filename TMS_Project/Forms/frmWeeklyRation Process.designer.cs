namespace TMS_Project
{
    partial class frmWeeklyRationProcess
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
            this.dTPickerWeeklyRationProcessToDate = new System.Windows.Forms.DateTimePicker();
            this.dTPickerWeeklyRationProcessFromDate = new System.Windows.Forms.DateTimePicker();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnProcess = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FrmWekklyRationtoDate = new System.Windows.Forms.Label();
            this.FrmWekklyRationFrmDate = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dTPickerWeeklyRationProcessToDate);
            this.groupBox1.Controls.Add(this.dTPickerWeeklyRationProcessFromDate);
            this.groupBox1.Controls.Add(this.BtnCancel);
            this.groupBox1.Controls.Add(this.BtnProcess);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FrmWekklyRationtoDate);
            this.groupBox1.Controls.Add(this.FrmWekklyRationFrmDate);
            this.groupBox1.Location = new System.Drawing.Point(2, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dTPickerWeeklyRationProcessToDate
            // 
            this.dTPickerWeeklyRationProcessToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPickerWeeklyRationProcessToDate.Location = new System.Drawing.Point(379, 20);
            this.dTPickerWeeklyRationProcessToDate.Name = "dTPickerWeeklyRationProcessToDate";
            this.dTPickerWeeklyRationProcessToDate.Size = new System.Drawing.Size(200, 20);
            this.dTPickerWeeklyRationProcessToDate.TabIndex = 9;
            // 
            // dTPickerWeeklyRationProcessFromDate
            // 
            this.dTPickerWeeklyRationProcessFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPickerWeeklyRationProcessFromDate.Location = new System.Drawing.Point(98, 19);
            this.dTPickerWeeklyRationProcessFromDate.Name = "dTPickerWeeklyRationProcessFromDate";
            this.dTPickerWeeklyRationProcessFromDate.Size = new System.Drawing.Size(176, 20);
            this.dTPickerWeeklyRationProcessFromDate.TabIndex = 8;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(498, 48);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnProcess
            // 
            this.BtnProcess.Location = new System.Drawing.Point(17, 48);
            this.BtnProcess.Name = "BtnProcess";
            this.BtnProcess.Size = new System.Drawing.Size(75, 23);
            this.BtnProcess.TabIndex = 4;
            this.BtnProcess.Text = "Process";
            this.BtnProcess.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(362, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = ":";
            // 
            // FrmWekklyRationtoDate
            // 
            this.FrmWekklyRationtoDate.AutoSize = true;
            this.FrmWekklyRationtoDate.Location = new System.Drawing.Point(299, 23);
            this.FrmWekklyRationtoDate.Name = "FrmWekklyRationtoDate";
            this.FrmWekklyRationtoDate.Size = new System.Drawing.Size(46, 13);
            this.FrmWekklyRationtoDate.TabIndex = 1;
            this.FrmWekklyRationtoDate.Text = "To Date";
            // 
            // FrmWekklyRationFrmDate
            // 
            this.FrmWekklyRationFrmDate.AutoSize = true;
            this.FrmWekklyRationFrmDate.Location = new System.Drawing.Point(20, 20);
            this.FrmWekklyRationFrmDate.Name = "FrmWekklyRationFrmDate";
            this.FrmWekklyRationFrmDate.Size = new System.Drawing.Size(56, 13);
            this.FrmWekklyRationFrmDate.TabIndex = 0;
            this.FrmWekklyRationFrmDate.Text = "From Date";
            // 
            // frmWeeklyRationProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 102);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmWeeklyRationProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weekly Ration Process";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnProcess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label FrmWekklyRationtoDate;
        private System.Windows.Forms.Label FrmWekklyRationFrmDate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dTPickerWeeklyRationProcessToDate;
        private System.Windows.Forms.DateTimePicker dTPickerWeeklyRationProcessFromDate;
    }
}