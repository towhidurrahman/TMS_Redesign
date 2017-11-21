namespace TMS_Project
{
    partial class frmWeeklyHolidayPayGenerator
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
            this.lblWeekStartDate = new System.Windows.Forms.Label();
            this.dtTimePickerWeekStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWeekStartDate
            // 
            this.lblWeekStartDate.AutoSize = true;
            this.lblWeekStartDate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeekStartDate.Location = new System.Drawing.Point(12, 28);
            this.lblWeekStartDate.Name = "lblWeekStartDate";
            this.lblWeekStartDate.Size = new System.Drawing.Size(87, 13);
            this.lblWeekStartDate.TabIndex = 0;
            this.lblWeekStartDate.Text = "Week Start Date";
            // 
            // dtTimePickerWeekStartDate
            // 
            this.dtTimePickerWeekStartDate.Location = new System.Drawing.Point(161, 25);
            this.dtTimePickerWeekStartDate.Name = "dtTimePickerWeekStartDate";
            this.dtTimePickerWeekStartDate.Size = new System.Drawing.Size(74, 20);
            this.dtTimePickerWeekStartDate.TabIndex = 1;
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(15, 59);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(102, 23);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(310, 59);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmWeeklyHolidayPayGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 94);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.dtTimePickerWeekStartDate);
            this.Controls.Add(this.lblWeekStartDate);
            this.Name = "frmWeeklyHolidayPayGenerator";
            this.Text = "Weekly Holiday Wages Collection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWeekStartDate;
        private System.Windows.Forms.DateTimePicker dtTimePickerWeekStartDate;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnCancel;
    }
}