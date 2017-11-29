namespace TMS_Project
{
    partial class frmMisProcess
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
            this.dTPickerMisProcessDayEndDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMisP = new System.Windows.Forms.Label();
            this.btndayendProcess = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dTPickerMisProcessDayEndDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblMisP);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dTPickerMisProcessDayEndDate
            // 
            this.dTPickerMisProcessDayEndDate.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.dTPickerMisProcessDayEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPickerMisProcessDayEndDate.Location = new System.Drawing.Point(131, 25);
            this.dTPickerMisProcessDayEndDate.Name = "dTPickerMisProcessDayEndDate";
            this.dTPickerMisProcessDayEndDate.Size = new System.Drawing.Size(167, 20);
            this.dTPickerMisProcessDayEndDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
            // 
            // lblMisP
            // 
            this.lblMisP.AutoSize = true;
            this.lblMisP.Location = new System.Drawing.Point(23, 25);
            this.lblMisP.Name = "lblMisP";
            this.lblMisP.Size = new System.Drawing.Size(74, 13);
            this.lblMisP.TabIndex = 0;
            this.lblMisP.Text = "Day End Date";
            this.lblMisP.Click += new System.EventHandler(this.lbldayendP_Click);
            // 
            // btndayendProcess
            // 
            this.btndayendProcess.Location = new System.Drawing.Point(12, 70);
            this.btndayendProcess.Name = "btndayendProcess";
            this.btndayendProcess.Size = new System.Drawing.Size(75, 23);
            this.btndayendProcess.TabIndex = 1;
            this.btndayendProcess.Text = "Process";
            this.btndayendProcess.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(482, 72);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmMisProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 102);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btndayendProcess);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMisProcess";
            this.Text = "Mis Processing";
            this.Load += new System.EventHandler(this.FrmMisProcess_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMisP;
        private System.Windows.Forms.Button btndayendProcess;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dTPickerMisProcessDayEndDate;
    }
}