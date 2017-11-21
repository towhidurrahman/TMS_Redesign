namespace TMS_Project
{
    partial class frmWeeklyNurseryInformation
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.dtTimePickerWeekStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblWeekStartDate = new System.Windows.Forms.Label();
            this.grpBoxReportPreviewRange = new System.Windows.Forms.GroupBox();
            this.grpBoxReportPreviewRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(375, 72);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(8, 72);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(79, 23);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // dtTimePickerWeekStartDate
            // 
            this.dtTimePickerWeekStartDate.Location = new System.Drawing.Point(143, 24);
            this.dtTimePickerWeekStartDate.Name = "dtTimePickerWeekStartDate";
            this.dtTimePickerWeekStartDate.Size = new System.Drawing.Size(74, 20);
            this.dtTimePickerWeekStartDate.TabIndex = 5;
            // 
            // lblWeekStartDate
            // 
            this.lblWeekStartDate.AutoSize = true;
            this.lblWeekStartDate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeekStartDate.Location = new System.Drawing.Point(27, 40);
            this.lblWeekStartDate.Name = "lblWeekStartDate";
            this.lblWeekStartDate.Size = new System.Drawing.Size(103, 13);
            this.lblWeekStartDate.TabIndex = 4;
            this.lblWeekStartDate.Text = "Week Start Date    :";
            // 
            // grpBoxReportPreviewRange
            // 
            this.grpBoxReportPreviewRange.Controls.Add(this.dtTimePickerWeekStartDate);
            this.grpBoxReportPreviewRange.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxReportPreviewRange.ForeColor = System.Drawing.Color.Blue;
            this.grpBoxReportPreviewRange.Location = new System.Drawing.Point(7, 13);
            this.grpBoxReportPreviewRange.Name = "grpBoxReportPreviewRange";
            this.grpBoxReportPreviewRange.Size = new System.Drawing.Size(441, 55);
            this.grpBoxReportPreviewRange.TabIndex = 8;
            this.grpBoxReportPreviewRange.TabStop = false;
            this.grpBoxReportPreviewRange.Text = "ReportPreviewRange";
            // 
            // frmWeeklyNurseryInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 108);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.lblWeekStartDate);
            this.Controls.Add(this.grpBoxReportPreviewRange);
            this.Name = "frmWeeklyNurseryInformation";
            this.Text = "Weekly Nursery Information";
            this.grpBoxReportPreviewRange.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.DateTimePicker dtTimePickerWeekStartDate;
        private System.Windows.Forms.Label lblWeekStartDate;
        private System.Windows.Forms.GroupBox grpBoxReportPreviewRange;
    }
}