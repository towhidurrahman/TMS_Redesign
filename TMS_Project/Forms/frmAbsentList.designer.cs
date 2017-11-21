namespace TMS_Project
{
    partial class frmAbsentList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbsentList));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dTPickerAbsentLToDate = new System.Windows.Forms.DateTimePicker();
            this.dTPickerAbsentLFromDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FrmWekklyRationtoDate = new System.Windows.Forms.Label();
            this.FrmWekklyRationFrmDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbAbsencelSex = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbAbsencelArea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtAbsencelWorkerTo = new System.Windows.Forms.TextBox();
            this.txtAbsencelWorkerFrom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dTPickerAbsentLToDate);
            this.groupBox1.Controls.Add(this.dTPickerAbsentLFromDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.FrmWekklyRationtoDate);
            this.groupBox1.Controls.Add(this.FrmWekklyRationFrmDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.CmbAbsencelSex);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CmbAbsencelArea);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.txtAbsencelWorkerTo);
            this.groupBox1.Controls.Add(this.txtAbsencelWorkerFrom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(2, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Preview Range";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dTPickerAbsentLToDate
            // 
            this.dTPickerAbsentLToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPickerAbsentLToDate.Location = new System.Drawing.Point(419, 26);
            this.dTPickerAbsentLToDate.Name = "dTPickerAbsentLToDate";
            this.dTPickerAbsentLToDate.Size = new System.Drawing.Size(164, 20);
            this.dTPickerAbsentLToDate.TabIndex = 84;
            // 
            // dTPickerAbsentLFromDate
            // 
            this.dTPickerAbsentLFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPickerAbsentLFromDate.Location = new System.Drawing.Point(116, 26);
            this.dTPickerAbsentLFromDate.Name = "dTPickerAbsentLFromDate";
            this.dTPickerAbsentLFromDate.Size = new System.Drawing.Size(154, 20);
            this.dTPickerAbsentLFromDate.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(403, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 16);
            this.label3.TabIndex = 82;
            this.label3.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 81;
            this.label6.Text = ":";
            // 
            // FrmWekklyRationtoDate
            // 
            this.FrmWekklyRationtoDate.AutoSize = true;
            this.FrmWekklyRationtoDate.Location = new System.Drawing.Point(332, 27);
            this.FrmWekklyRationtoDate.Name = "FrmWekklyRationtoDate";
            this.FrmWekklyRationtoDate.Size = new System.Drawing.Size(46, 13);
            this.FrmWekklyRationtoDate.TabIndex = 80;
            this.FrmWekklyRationtoDate.Text = "To Date";
            // 
            // FrmWekklyRationFrmDate
            // 
            this.FrmWekklyRationFrmDate.AutoSize = true;
            this.FrmWekklyRationFrmDate.Location = new System.Drawing.Point(11, 28);
            this.FrmWekklyRationFrmDate.Name = "FrmWekklyRationFrmDate";
            this.FrmWekklyRationFrmDate.Size = new System.Drawing.Size(56, 13);
            this.FrmWekklyRationFrmDate.TabIndex = 79;
            this.FrmWekklyRationFrmDate.Text = "From Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(100, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 78;
            this.label8.Text = ":";
            // 
            // CmbAbsencelSex
            // 
            this.CmbAbsencelSex.FormattingEnabled = true;
            this.CmbAbsencelSex.Location = new System.Drawing.Point(116, 106);
            this.CmbAbsencelSex.Name = "CmbAbsencelSex";
            this.CmbAbsencelSex.Size = new System.Drawing.Size(154, 21);
            this.CmbAbsencelSex.TabIndex = 77;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 76;
            this.label9.Text = "Sex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = ":";
            // 
            // CmbAbsencelArea
            // 
            this.CmbAbsencelArea.FormattingEnabled = true;
            this.CmbAbsencelArea.Location = new System.Drawing.Point(116, 78);
            this.CmbAbsencelArea.Name = "CmbAbsencelArea";
            this.CmbAbsencelArea.Size = new System.Drawing.Size(154, 21);
            this.CmbAbsencelArea.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Area";
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(275, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 21);
            this.button3.TabIndex = 72;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(589, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(25, 21);
            this.btnSearch.TabIndex = 71;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = ":";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(100, 56);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(10, 13);
            this.label25.TabIndex = 36;
            this.label25.Text = ":";
            // 
            // txtAbsencelWorkerTo
            // 
            this.txtAbsencelWorkerTo.Location = new System.Drawing.Point(418, 60);
            this.txtAbsencelWorkerTo.Name = "txtAbsencelWorkerTo";
            this.txtAbsencelWorkerTo.Size = new System.Drawing.Size(165, 20);
            this.txtAbsencelWorkerTo.TabIndex = 8;
            // 
            // txtAbsencelWorkerFrom
            // 
            this.txtAbsencelWorkerFrom.Location = new System.Drawing.Point(116, 52);
            this.txtAbsencelWorkerFrom.Name = "txtAbsencelWorkerFrom";
            this.txtAbsencelWorkerFrom.Size = new System.Drawing.Size(154, 20);
            this.txtAbsencelWorkerFrom.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Worker From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Worker To";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(11, 154);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(87, 26);
            this.btnPreview.TabIndex = 1;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(557, 154);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(73, 26);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // frmAbsentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 186);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAbsentList";
            this.Text = "Absence List";
            this.Load += new System.EventHandler(this.Absent_list_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAbsencelWorkerTo;
        private System.Windows.Forms.TextBox txtAbsencelWorkerFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbAbsencelSex;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbAbsencelArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dTPickerAbsentLToDate;
        private System.Windows.Forms.DateTimePicker dTPickerAbsentLFromDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label FrmWekklyRationtoDate;
        private System.Windows.Forms.Label FrmWekklyRationFrmDate;
    }
}