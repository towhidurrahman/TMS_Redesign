namespace TMS_Project
{
    partial class frmRubberDailyAnalysisCashReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRubberDailyAnalysisCashReport));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DTPDateFrom = new System.Windows.Forms.DateTimePicker();
            this.btnCategoryTo = new System.Windows.Forms.Button();
            this.btnCategoryFrom = new System.Windows.Forms.Button();
            this.txtCategoryTo = new System.Windows.Forms.TextBox();
            this.lblCategoryTo = new System.Windows.Forms.Label();
            this.txtCategoryFrom = new System.Windows.Forms.TextBox();
            this.lblCategoryFrom = new System.Windows.Forms.Label();
            this.cmbGarden = new System.Windows.Forms.ComboBox();
            this.lblGarden = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.cmbWorkStation = new System.Windows.Forms.ComboBox();
            this.lblWorkStation = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.DTPDateFrom);
            this.groupBox1.Controls.Add(this.btnCategoryTo);
            this.groupBox1.Controls.Add(this.btnCategoryFrom);
            this.groupBox1.Controls.Add(this.txtCategoryTo);
            this.groupBox1.Controls.Add(this.lblCategoryTo);
            this.groupBox1.Controls.Add(this.txtCategoryFrom);
            this.groupBox1.Controls.Add(this.lblCategoryFrom);
            this.groupBox1.Controls.Add(this.cmbGarden);
            this.groupBox1.Controls.Add(this.lblGarden);
            this.groupBox1.Controls.Add(this.lblDateTo);
            this.groupBox1.Controls.Add(this.cmbWorkStation);
            this.groupBox1.Controls.Add(this.lblWorkStation);
            this.groupBox1.Controls.Add(this.lblDateFrom);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reports Preview Range";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(372, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 20);
            this.dateTimePicker1.TabIndex = 83;
            // 
            // DTPDateFrom
            // 
            this.DTPDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPDateFrom.Location = new System.Drawing.Point(103, 23);
            this.DTPDateFrom.Name = "DTPDateFrom";
            this.DTPDateFrom.Size = new System.Drawing.Size(111, 20);
            this.DTPDateFrom.TabIndex = 82;
            // 
            // btnCategoryTo
            // 
            this.btnCategoryTo.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoryTo.Image")));
            this.btnCategoryTo.Location = new System.Drawing.Point(489, 92);
            this.btnCategoryTo.Name = "btnCategoryTo";
            this.btnCategoryTo.Size = new System.Drawing.Size(25, 21);
            this.btnCategoryTo.TabIndex = 80;
            this.btnCategoryTo.UseVisualStyleBackColor = true;
            // 
            // btnCategoryFrom
            // 
            this.btnCategoryFrom.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoryFrom.Image")));
            this.btnCategoryFrom.Location = new System.Drawing.Point(224, 92);
            this.btnCategoryFrom.Name = "btnCategoryFrom";
            this.btnCategoryFrom.Size = new System.Drawing.Size(25, 21);
            this.btnCategoryFrom.TabIndex = 79;
            this.btnCategoryFrom.UseVisualStyleBackColor = true;
            // 
            // txtCategoryTo
            // 
            this.txtCategoryTo.Location = new System.Drawing.Point(370, 91);
            this.txtCategoryTo.Name = "txtCategoryTo";
            this.txtCategoryTo.Size = new System.Drawing.Size(111, 20);
            this.txtCategoryTo.TabIndex = 73;
            // 
            // lblCategoryTo
            // 
            this.lblCategoryTo.AutoSize = true;
            this.lblCategoryTo.Location = new System.Drawing.Point(278, 92);
            this.lblCategoryTo.Name = "lblCategoryTo";
            this.lblCategoryTo.Size = new System.Drawing.Size(65, 13);
            this.lblCategoryTo.TabIndex = 72;
            this.lblCategoryTo.Text = "Category To";
            // 
            // txtCategoryFrom
            // 
            this.txtCategoryFrom.Location = new System.Drawing.Point(104, 91);
            this.txtCategoryFrom.Name = "txtCategoryFrom";
            this.txtCategoryFrom.Size = new System.Drawing.Size(111, 20);
            this.txtCategoryFrom.TabIndex = 71;
            // 
            // lblCategoryFrom
            // 
            this.lblCategoryFrom.AutoSize = true;
            this.lblCategoryFrom.Location = new System.Drawing.Point(11, 92);
            this.lblCategoryFrom.Name = "lblCategoryFrom";
            this.lblCategoryFrom.Size = new System.Drawing.Size(75, 13);
            this.lblCategoryFrom.TabIndex = 70;
            this.lblCategoryFrom.Text = "Category From";
            // 
            // cmbGarden
            // 
            this.cmbGarden.FormattingEnabled = true;
            this.cmbGarden.Location = new System.Drawing.Point(368, 54);
            this.cmbGarden.Name = "cmbGarden";
            this.cmbGarden.Size = new System.Drawing.Size(111, 21);
            this.cmbGarden.TabIndex = 69;
            // 
            // lblGarden
            // 
            this.lblGarden.AutoSize = true;
            this.lblGarden.Location = new System.Drawing.Point(278, 59);
            this.lblGarden.Name = "lblGarden";
            this.lblGarden.Size = new System.Drawing.Size(42, 13);
            this.lblGarden.TabIndex = 68;
            this.lblGarden.Text = "Garden";
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Location = new System.Drawing.Point(276, 23);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(46, 13);
            this.lblDateTo.TabIndex = 66;
            this.lblDateTo.Text = "Date To";
            // 
            // cmbWorkStation
            // 
            this.cmbWorkStation.FormattingEnabled = true;
            this.cmbWorkStation.Location = new System.Drawing.Point(103, 57);
            this.cmbWorkStation.Name = "cmbWorkStation";
            this.cmbWorkStation.Size = new System.Drawing.Size(111, 21);
            this.cmbWorkStation.TabIndex = 65;
            // 
            // lblWorkStation
            // 
            this.lblWorkStation.AutoSize = true;
            this.lblWorkStation.Location = new System.Drawing.Point(11, 59);
            this.lblWorkStation.Name = "lblWorkStation";
            this.lblWorkStation.Size = new System.Drawing.Size(69, 13);
            this.lblWorkStation.TabIndex = 64;
            this.lblWorkStation.Text = "Work Station";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Location = new System.Drawing.Point(11, 26);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(53, 13);
            this.lblDateFrom.TabIndex = 62;
            this.lblDateFrom.Text = "DateFrom";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 22);
            this.button1.TabIndex = 80;
            this.button1.Text = "&Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(16, 148);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(59, 22);
            this.btnPreview.TabIndex = 79;
            this.btnPreview.Text = "&Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // frmRubberDailyAnalysisCashReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 184);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRubberDailyAnalysisCashReport";
            this.Text = "Rubber Daily Analysis Cash Report";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCategoryTo;
        private System.Windows.Forms.Button btnCategoryFrom;
        private System.Windows.Forms.TextBox txtCategoryTo;
        private System.Windows.Forms.Label lblCategoryTo;
        private System.Windows.Forms.TextBox txtCategoryFrom;
        private System.Windows.Forms.Label lblCategoryFrom;
        private System.Windows.Forms.ComboBox cmbGarden;
        private System.Windows.Forms.Label lblGarden;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.ComboBox cmbWorkStation;
        private System.Windows.Forms.Label lblWorkStation;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker DTPDateFrom;
    }
}