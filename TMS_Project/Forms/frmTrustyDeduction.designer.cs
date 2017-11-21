namespace TMS_Project
{
    partial class frmTrustyDeduction
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
            this.lblFTDedDateFrom = new System.Windows.Forms.Label();
            this.lblFTDedUnion = new System.Windows.Forms.Label();
            this.lblFTDedDateTo = new System.Windows.Forms.Label();
            this.lblFTDedPuja = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnFTDedProcess = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dTPickerTrustyDeducToDate = new System.Windows.Forms.DateTimePicker();
            this.dTPickerTrustyDeducFromDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.btnFTDedCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFTDedDateFrom
            // 
            this.lblFTDedDateFrom.AutoSize = true;
            this.lblFTDedDateFrom.Location = new System.Drawing.Point(8, 27);
            this.lblFTDedDateFrom.Name = "lblFTDedDateFrom";
            this.lblFTDedDateFrom.Size = new System.Drawing.Size(56, 13);
            this.lblFTDedDateFrom.TabIndex = 0;
            this.lblFTDedDateFrom.Text = "Date From";
            // 
            // lblFTDedUnion
            // 
            this.lblFTDedUnion.AutoSize = true;
            this.lblFTDedUnion.Location = new System.Drawing.Point(8, 66);
            this.lblFTDedUnion.Name = "lblFTDedUnion";
            this.lblFTDedUnion.Size = new System.Drawing.Size(57, 13);
            this.lblFTDedUnion.TabIndex = 1;
            this.lblFTDedUnion.Text = "Union (Tk)";
            // 
            // lblFTDedDateTo
            // 
            this.lblFTDedDateTo.AutoSize = true;
            this.lblFTDedDateTo.Location = new System.Drawing.Point(276, 27);
            this.lblFTDedDateTo.Name = "lblFTDedDateTo";
            this.lblFTDedDateTo.Size = new System.Drawing.Size(46, 13);
            this.lblFTDedDateTo.TabIndex = 2;
            this.lblFTDedDateTo.Text = "Date To";
            this.lblFTDedDateTo.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblFTDedPuja
            // 
            this.lblFTDedPuja.AutoSize = true;
            this.lblFTDedPuja.Location = new System.Drawing.Point(276, 63);
            this.lblFTDedPuja.Name = "lblFTDedPuja";
            this.lblFTDedPuja.Size = new System.Drawing.Size(48, 13);
            this.lblFTDedPuja.TabIndex = 5;
            this.lblFTDedPuja.Text = "Puja(TK)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(349, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 20);
            this.textBox2.TabIndex = 11;
            // 
            // btnFTDedProcess
            // 
            this.btnFTDedProcess.Location = new System.Drawing.Point(9, 91);
            this.btnFTDedProcess.Name = "btnFTDedProcess";
            this.btnFTDedProcess.Size = new System.Drawing.Size(75, 23);
            this.btnFTDedProcess.TabIndex = 12;
            this.btnFTDedProcess.Text = "Process";
            this.btnFTDedProcess.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dTPickerTrustyDeducToDate);
            this.groupBox1.Controls.Add(this.dTPickerTrustyDeducFromDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.btnFTDedCancel);
            this.groupBox1.Controls.Add(this.btnFTDedProcess);
            this.groupBox1.Controls.Add(this.lblFTDedDateFrom);
            this.groupBox1.Controls.Add(this.lblFTDedUnion);
            this.groupBox1.Controls.Add(this.lblFTDedPuja);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblFTDedDateTo);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 135);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // dTPickerTrustyDeducToDate
            // 
            this.dTPickerTrustyDeducToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPickerTrustyDeducToDate.Location = new System.Drawing.Point(349, 27);
            this.dTPickerTrustyDeducToDate.Name = "dTPickerTrustyDeducToDate";
            this.dTPickerTrustyDeducToDate.Size = new System.Drawing.Size(178, 20);
            this.dTPickerTrustyDeducToDate.TabIndex = 41;
            // 
            // dTPickerTrustyDeducFromDate
            // 
            this.dTPickerTrustyDeducFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPickerTrustyDeducFromDate.Location = new System.Drawing.Point(85, 27);
            this.dTPickerTrustyDeducFromDate.Name = "dTPickerTrustyDeducFromDate";
            this.dTPickerTrustyDeducFromDate.Size = new System.Drawing.Size(178, 20);
            this.dTPickerTrustyDeducFromDate.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = ":";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(333, 27);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(10, 13);
            this.label25.TabIndex = 36;
            this.label25.Text = ":";
            // 
            // btnFTDedCancel
            // 
            this.btnFTDedCancel.Location = new System.Drawing.Point(452, 91);
            this.btnFTDedCancel.Name = "btnFTDedCancel";
            this.btnFTDedCancel.Size = new System.Drawing.Size(75, 23);
            this.btnFTDedCancel.TabIndex = 14;
            this.btnFTDedCancel.Text = "Cancel";
            this.btnFTDedCancel.UseVisualStyleBackColor = true;
            // 
            // frmTrustyDeduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 144);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTrustyDeduction";
            this.Text = "Trusty Deduction";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFTDedDateFrom;
        private System.Windows.Forms.Label lblFTDedUnion;
        private System.Windows.Forms.Label lblFTDedDateTo;
        private System.Windows.Forms.Label lblFTDedPuja;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnFTDedProcess;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFTDedCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DateTimePicker dTPickerTrustyDeducToDate;
        private System.Windows.Forms.DateTimePicker dTPickerTrustyDeducFromDate;
    }
}