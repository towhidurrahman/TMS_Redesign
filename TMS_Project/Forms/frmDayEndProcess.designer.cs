namespace TMS_Project
{
    partial class frmDayEndProcess
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
            this.dTPickerDayEndDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lbldayendP = new System.Windows.Forms.Label();
            this.btnDayEndProcess = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dTPickerDayEndDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbldayendP);
            this.groupBox1.Location = new System.Drawing.Point(6, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dTPickerDayEndDate
            // 
            this.dTPickerDayEndDate.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.dTPickerDayEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPickerDayEndDate.Location = new System.Drawing.Point(118, 18);
            this.dTPickerDayEndDate.Name = "dTPickerDayEndDate";
            this.dTPickerDayEndDate.Size = new System.Drawing.Size(167, 20);
            this.dTPickerDayEndDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
            // 
            // lbldayendP
            // 
            this.lbldayendP.AutoSize = true;
            this.lbldayendP.Location = new System.Drawing.Point(12, 22);
            this.lbldayendP.Name = "lbldayendP";
            this.lbldayendP.Size = new System.Drawing.Size(74, 13);
            this.lbldayendP.TabIndex = 0;
            this.lbldayendP.Text = "Day End Date";
            // 
            // btnDayEndProcess
            // 
            this.btnDayEndProcess.Location = new System.Drawing.Point(6, 67);
            this.btnDayEndProcess.Name = "btnDayEndProcess";
            this.btnDayEndProcess.Size = new System.Drawing.Size(56, 25);
            this.btnDayEndProcess.TabIndex = 1;
            this.btnDayEndProcess.Text = "Process";
            this.btnDayEndProcess.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(388, 67);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 25);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnbtndayendPcancel_Click);
            // 
            // frmDayEndProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 97);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDayEndProcess);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmDayEndProcess";
            this.Text = "Day End Process";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldayendP;
        private System.Windows.Forms.Button btnDayEndProcess;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dTPickerDayEndDate;
    }
}