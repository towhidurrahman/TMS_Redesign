namespace TMS_Project
{
    partial class frmFiscalCalendar
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
            this.lblYear = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.DTPFiscalCalendar1 = new System.Windows.Forms.DateTimePicker();
            this.DTPFiscalCalendar2 = new System.Windows.Forms.DateTimePicker();
            this.DTPFiscalCalendar3 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(12, 17);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Year";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(74, 43);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 25);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(355, 43);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 25);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DTPFiscalCalendar1
            // 
            this.DTPFiscalCalendar1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPFiscalCalendar1.Location = new System.Drawing.Point(74, 17);
            this.DTPFiscalCalendar1.Name = "DTPFiscalCalendar1";
            this.DTPFiscalCalendar1.Size = new System.Drawing.Size(111, 20);
            this.DTPFiscalCalendar1.TabIndex = 82;
            // 
            // DTPFiscalCalendar2
            // 
            this.DTPFiscalCalendar2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPFiscalCalendar2.Location = new System.Drawing.Point(198, 17);
            this.DTPFiscalCalendar2.Name = "DTPFiscalCalendar2";
            this.DTPFiscalCalendar2.Size = new System.Drawing.Size(111, 20);
            this.DTPFiscalCalendar2.TabIndex = 83;
            // 
            // DTPFiscalCalendar3
            // 
            this.DTPFiscalCalendar3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPFiscalCalendar3.Location = new System.Drawing.Point(318, 17);
            this.DTPFiscalCalendar3.Name = "DTPFiscalCalendar3";
            this.DTPFiscalCalendar3.Size = new System.Drawing.Size(111, 20);
            this.DTPFiscalCalendar3.TabIndex = 84;
            // 
            // frmFiscalCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 82);
            this.Controls.Add(this.DTPFiscalCalendar3);
            this.Controls.Add(this.DTPFiscalCalendar2);
            this.Controls.Add(this.DTPFiscalCalendar1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblYear);
            this.MaximizeBox = false;
            this.Name = "frmFiscalCalendar";
            this.Text = "Fiscal Calendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker DTPFiscalCalendar1;
        private System.Windows.Forms.DateTimePicker DTPFiscalCalendar2;
        private System.Windows.Forms.DateTimePicker DTPFiscalCalendar3;
    }
}