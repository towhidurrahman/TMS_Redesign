namespace TMS_Project
{
    partial class frmWeeklyPayManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSelectedTk = new System.Windows.Forms.Label();
            this.lblTotalTk = new System.Windows.Forms.Label();
            this.lblSelectedEmployee = new System.Windows.Forms.Label();
            this.lblTotalEmployee = new System.Windows.Forms.Label();
            this.dateTimePickerPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.dtPickerPaymentMonth = new System.Windows.Forms.DateTimePicker();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BtnPost = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.lblSelectedTk);
            this.groupBox1.Controls.Add(this.lblTotalTk);
            this.groupBox1.Controls.Add(this.lblSelectedEmployee);
            this.groupBox1.Controls.Add(this.lblTotalEmployee);
            this.groupBox1.Controls.Add(this.dateTimePickerPaymentDate);
            this.groupBox1.Controls.Add(this.dtPickerPaymentMonth);
            this.groupBox1.Controls.Add(this.lblDateFrom);
            this.groupBox1.Location = new System.Drawing.Point(13, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 423);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Payment Date               :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(778, 331);
            this.dataGridView1.TabIndex = 10;
            // 
            // lblSelectedTk
            // 
            this.lblSelectedTk.AutoSize = true;
            this.lblSelectedTk.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedTk.ForeColor = System.Drawing.Color.Black;
            this.lblSelectedTk.Location = new System.Drawing.Point(501, 41);
            this.lblSelectedTk.Name = "lblSelectedTk";
            this.lblSelectedTk.Size = new System.Drawing.Size(126, 13);
            this.lblSelectedTk.TabIndex = 9;
            this.lblSelectedTk.Text = "Selected Tk                    :";
            // 
            // lblTotalTk
            // 
            this.lblTotalTk.AutoSize = true;
            this.lblTotalTk.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTk.ForeColor = System.Drawing.Color.Black;
            this.lblTotalTk.Location = new System.Drawing.Point(258, 41);
            this.lblTotalTk.Name = "lblTotalTk";
            this.lblTotalTk.Size = new System.Drawing.Size(136, 13);
            this.lblTotalTk.TabIndex = 8;
            this.lblTotalTk.Text = "Total Tk                             :";
            // 
            // lblSelectedEmployee
            // 
            this.lblSelectedEmployee.AutoSize = true;
            this.lblSelectedEmployee.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedEmployee.ForeColor = System.Drawing.Color.Black;
            this.lblSelectedEmployee.Location = new System.Drawing.Point(501, 18);
            this.lblSelectedEmployee.Name = "lblSelectedEmployee";
            this.lblSelectedEmployee.Size = new System.Drawing.Size(125, 13);
            this.lblSelectedEmployee.TabIndex = 7;
            this.lblSelectedEmployee.Text = "Selected Employee        :";
            // 
            // lblTotalEmployee
            // 
            this.lblTotalEmployee.AutoSize = true;
            this.lblTotalEmployee.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmployee.ForeColor = System.Drawing.Color.Black;
            this.lblTotalEmployee.Location = new System.Drawing.Point(258, 16);
            this.lblTotalEmployee.Name = "lblTotalEmployee";
            this.lblTotalEmployee.Size = new System.Drawing.Size(138, 13);
            this.lblTotalEmployee.TabIndex = 6;
            this.lblTotalEmployee.Text = "Total Employee                  :";
            // 
            // dateTimePickerPaymentDate
            // 
            this.dateTimePickerPaymentDate.CalendarFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerPaymentDate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPaymentDate.Location = new System.Drawing.Point(146, 49);
            this.dateTimePickerPaymentDate.Name = "dateTimePickerPaymentDate";
            this.dateTimePickerPaymentDate.Size = new System.Drawing.Size(91, 20);
            this.dateTimePickerPaymentDate.TabIndex = 5;
            // 
            // dtPickerPaymentMonth
            // 
            this.dtPickerPaymentMonth.CalendarFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerPaymentMonth.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerPaymentMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerPaymentMonth.Location = new System.Drawing.Point(146, 14);
            this.dtPickerPaymentMonth.Name = "dtPickerPaymentMonth";
            this.dtPickerPaymentMonth.Size = new System.Drawing.Size(91, 20);
            this.dtPickerPaymentMonth.TabIndex = 3;
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFrom.ForeColor = System.Drawing.Color.Black;
            this.lblDateFrom.Location = new System.Drawing.Point(12, 16);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(131, 13);
            this.lblDateFrom.TabIndex = 2;
            this.lblDateFrom.Text = "Payment Month               :";
            // 
            // BtnPost
            // 
            this.BtnPost.Location = new System.Drawing.Point(20, 420);
            this.BtnPost.Name = "BtnPost";
            this.BtnPost.Size = new System.Drawing.Size(75, 23);
            this.BtnPost.TabIndex = 10;
            this.BtnPost.Text = "&Post";
            this.BtnPost.UseVisualStyleBackColor = true;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(257, 420);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 11;
            this.btnSelectAll.Text = "&Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(523, 420);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAll.TabIndex = 12;
            this.btnRemoveAll.Text = "&Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(727, 420);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmWeeklyPayManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 453);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.BtnPost);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmWeeklyPayManager";
            this.Text = "Weekly Pay Manager";
            this.Load += new System.EventHandler(this.frmWeeklyPayManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblSelectedTk;
        private System.Windows.Forms.Label lblTotalTk;
        private System.Windows.Forms.Label lblSelectedEmployee;
        private System.Windows.Forms.Label lblTotalEmployee;
        private System.Windows.Forms.DateTimePicker dateTimePickerPaymentDate;
        private System.Windows.Forms.DateTimePicker dtPickerPaymentMonth;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnPost;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
    }
}