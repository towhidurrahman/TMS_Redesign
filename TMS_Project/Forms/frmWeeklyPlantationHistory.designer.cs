namespace TMS_Project
{
    partial class frmWeeklyPlantationHistory
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
            this.DTPWorkStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblWorkStartDate = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DTPWorkStartDate);
            this.groupBox1.Controls.Add(this.lblWorkStartDate);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reports Preview Range";
            // 
            // DTPWorkStartDate
            // 
            this.DTPWorkStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPWorkStartDate.Location = new System.Drawing.Point(118, 27);
            this.DTPWorkStartDate.Name = "DTPWorkStartDate";
            this.DTPWorkStartDate.Size = new System.Drawing.Size(138, 20);
            this.DTPWorkStartDate.TabIndex = 79;
            // 
            // lblWorkStartDate
            // 
            this.lblWorkStartDate.AutoSize = true;
            this.lblWorkStartDate.Location = new System.Drawing.Point(9, 30);
            this.lblWorkStartDate.Name = "lblWorkStartDate";
            this.lblWorkStartDate.Size = new System.Drawing.Size(84, 13);
            this.lblWorkStartDate.TabIndex = 77;
            this.lblWorkStartDate.Text = "Work Start Date";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(415, 77);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(59, 22);
            this.btnCancel.TabIndex = 80;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(7, 77);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(59, 22);
            this.btnPreview.TabIndex = 79;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // frmWeeklyPlantationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 109);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmWeeklyPlantationHistory";
            this.Text = "Weekly Plantation History";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblWorkStartDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.DateTimePicker DTPWorkStartDate;
    }
}