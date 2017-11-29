namespace TMS_Project
{
    partial class frmFactoryyWorkCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactoryyWorkCategory));
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.lblCategoryDescription = new System.Windows.Forms.Label();
            this.lblNirik = new System.Windows.Forms.Label();
            this.lblProductive = new System.Windows.Forms.Label();
            this.lblRegularRate = new System.Windows.Forms.Label();
            this.lblPayableControl = new System.Windows.Forms.Label();
            this.lblClearingControl = new System.Windows.Forms.Label();
            this.lblInactive = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtCategoryDescription = new System.Windows.Forms.TextBox();
            this.txtNirik = new System.Windows.Forms.TextBox();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.txtRegularRate = new System.Windows.Forms.TextBox();
            this.lblExtraRate = new System.Windows.Forms.Label();
            this.txtExtraRate = new System.Windows.Forms.TextBox();
            this.txtPayableControl = new System.Windows.Forms.TextBox();
            this.txtClearingControl = new System.Windows.Forms.TextBox();
            this.btnSearchClearingControl = new System.Windows.Forms.Button();
            this.btnSearchPayableControl = new System.Windows.Forms.Button();
            this.chkBoxProductive = new System.Windows.Forms.CheckBox();
            this.chkBoxInactive = new System.Windows.Forms.CheckBox();
            this.lblDateOfInactive = new System.Windows.Forms.Label();
            this.dtPickerDateOfInactive = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryId.Location = new System.Drawing.Point(13, 14);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(65, 13);
            this.lblCategoryId.TabIndex = 0;
            this.lblCategoryId.Text = "Category Id";
            // 
            // lblCategoryDescription
            // 
            this.lblCategoryDescription.AutoSize = true;
            this.lblCategoryDescription.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryDescription.Location = new System.Drawing.Point(13, 38);
            this.lblCategoryDescription.Name = "lblCategoryDescription";
            this.lblCategoryDescription.Size = new System.Drawing.Size(108, 13);
            this.lblCategoryDescription.TabIndex = 1;
            this.lblCategoryDescription.Text = "Category Description";
            // 
            // lblNirik
            // 
            this.lblNirik.AutoSize = true;
            this.lblNirik.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNirik.Location = new System.Drawing.Point(14, 65);
            this.lblNirik.Name = "lblNirik";
            this.lblNirik.Size = new System.Drawing.Size(27, 13);
            this.lblNirik.TabIndex = 2;
            this.lblNirik.Text = "Nirik";
            // 
            // lblProductive
            // 
            this.lblProductive.AutoSize = true;
            this.lblProductive.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductive.Location = new System.Drawing.Point(14, 178);
            this.lblProductive.Name = "lblProductive";
            this.lblProductive.Size = new System.Drawing.Size(58, 13);
            this.lblProductive.TabIndex = 4;
            this.lblProductive.Text = "Productive";
            // 
            // lblRegularRate
            // 
            this.lblRegularRate.AutoSize = true;
            this.lblRegularRate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegularRate.Location = new System.Drawing.Point(14, 91);
            this.lblRegularRate.Name = "lblRegularRate";
            this.lblRegularRate.Size = new System.Drawing.Size(70, 13);
            this.lblRegularRate.TabIndex = 7;
            this.lblRegularRate.Text = "Regular Rate";
            // 
            // lblPayableControl
            // 
            this.lblPayableControl.AutoSize = true;
            this.lblPayableControl.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayableControl.Location = new System.Drawing.Point(14, 123);
            this.lblPayableControl.Name = "lblPayableControl";
            this.lblPayableControl.Size = new System.Drawing.Size(83, 13);
            this.lblPayableControl.TabIndex = 8;
            this.lblPayableControl.Text = "Payable Control";
            this.lblPayableControl.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblClearingControl
            // 
            this.lblClearingControl.AutoSize = true;
            this.lblClearingControl.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClearingControl.Location = new System.Drawing.Point(14, 148);
            this.lblClearingControl.Name = "lblClearingControl";
            this.lblClearingControl.Size = new System.Drawing.Size(84, 13);
            this.lblClearingControl.TabIndex = 9;
            this.lblClearingControl.Text = "Clearing Control";
            // 
            // lblInactive
            // 
            this.lblInactive.AutoSize = true;
            this.lblInactive.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInactive.Location = new System.Drawing.Point(14, 199);
            this.lblInactive.Name = "lblInactive";
            this.lblInactive.Size = new System.Drawing.Size(46, 13);
            this.lblInactive.TabIndex = 10;
            this.lblInactive.Text = "Inactive";
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.Location = new System.Drawing.Point(133, 10);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(29, 21);
            this.btnFirst.TabIndex = 11;
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.Location = new System.Drawing.Point(160, 10);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(29, 21);
            this.btnPrevious.TabIndex = 16;
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryId.Location = new System.Drawing.Point(191, 10);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(100, 20);
            this.txtCategoryId.TabIndex = 17;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.Location = new System.Drawing.Point(368, 10);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(29, 21);
            this.btnNew.TabIndex = 18;
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(344, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(29, 21);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.Location = new System.Drawing.Point(317, 10);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(29, 21);
            this.btnLast.TabIndex = 20;
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(290, 10);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(29, 21);
            this.btnNext.TabIndex = 21;
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryDescription.Location = new System.Drawing.Point(133, 38);
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.Size = new System.Drawing.Size(264, 20);
            this.txtCategoryDescription.TabIndex = 22;
            // 
            // txtNirik
            // 
            this.txtNirik.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNirik.Location = new System.Drawing.Point(133, 65);
            this.txtNirik.Name = "txtNirik";
            this.txtNirik.Size = new System.Drawing.Size(56, 20);
            this.txtNirik.TabIndex = 23;
            // 
            // cmbHour
            // 
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Location = new System.Drawing.Point(202, 65);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(71, 21);
            this.cmbHour.TabIndex = 27;
            // 
            // txtRegularRate
            // 
            this.txtRegularRate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegularRate.Location = new System.Drawing.Point(133, 91);
            this.txtRegularRate.Name = "txtRegularRate";
            this.txtRegularRate.Size = new System.Drawing.Size(56, 20);
            this.txtRegularRate.TabIndex = 28;
            // 
            // lblExtraRate
            // 
            this.lblExtraRate.AutoSize = true;
            this.lblExtraRate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraRate.Location = new System.Drawing.Point(199, 93);
            this.lblExtraRate.Name = "lblExtraRate";
            this.lblExtraRate.Size = new System.Drawing.Size(59, 13);
            this.lblExtraRate.TabIndex = 29;
            this.lblExtraRate.Text = "Extra Rate";
            // 
            // txtExtraRate
            // 
            this.txtExtraRate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtraRate.Location = new System.Drawing.Point(273, 92);
            this.txtExtraRate.Name = "txtExtraRate";
            this.txtExtraRate.Size = new System.Drawing.Size(56, 20);
            this.txtExtraRate.TabIndex = 30;
            // 
            // txtPayableControl
            // 
            this.txtPayableControl.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayableControl.Location = new System.Drawing.Point(133, 120);
            this.txtPayableControl.Name = "txtPayableControl";
            this.txtPayableControl.Size = new System.Drawing.Size(264, 20);
            this.txtPayableControl.TabIndex = 31;
            this.txtPayableControl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtClearingControl
            // 
            this.txtClearingControl.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClearingControl.Location = new System.Drawing.Point(133, 148);
            this.txtClearingControl.Name = "txtClearingControl";
            this.txtClearingControl.Size = new System.Drawing.Size(264, 20);
            this.txtClearingControl.TabIndex = 32;
            // 
            // btnSearchClearingControl
            // 
            this.btnSearchClearingControl.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClearingControl.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchClearingControl.Image")));
            this.btnSearchClearingControl.Location = new System.Drawing.Point(403, 148);
            this.btnSearchClearingControl.Name = "btnSearchClearingControl";
            this.btnSearchClearingControl.Size = new System.Drawing.Size(29, 21);
            this.btnSearchClearingControl.TabIndex = 33;
            this.btnSearchClearingControl.UseVisualStyleBackColor = true;
            // 
            // btnSearchPayableControl
            // 
            this.btnSearchPayableControl.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPayableControl.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchPayableControl.Image")));
            this.btnSearchPayableControl.Location = new System.Drawing.Point(403, 119);
            this.btnSearchPayableControl.Name = "btnSearchPayableControl";
            this.btnSearchPayableControl.Size = new System.Drawing.Size(29, 21);
            this.btnSearchPayableControl.TabIndex = 34;
            this.btnSearchPayableControl.UseVisualStyleBackColor = true;
            // 
            // chkBoxProductive
            // 
            this.chkBoxProductive.AutoSize = true;
            this.chkBoxProductive.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxProductive.Location = new System.Drawing.Point(133, 177);
            this.chkBoxProductive.Name = "chkBoxProductive";
            this.chkBoxProductive.Size = new System.Drawing.Size(15, 14);
            this.chkBoxProductive.TabIndex = 35;
            this.chkBoxProductive.UseVisualStyleBackColor = true;
            // 
            // chkBoxInactive
            // 
            this.chkBoxInactive.AutoSize = true;
            this.chkBoxInactive.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxInactive.Location = new System.Drawing.Point(133, 198);
            this.chkBoxInactive.Name = "chkBoxInactive";
            this.chkBoxInactive.Size = new System.Drawing.Size(15, 14);
            this.chkBoxInactive.TabIndex = 36;
            this.chkBoxInactive.UseVisualStyleBackColor = true;
            // 
            // lblDateOfInactive
            // 
            this.lblDateOfInactive.AutoSize = true;
            this.lblDateOfInactive.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfInactive.Location = new System.Drawing.Point(171, 199);
            this.lblDateOfInactive.Name = "lblDateOfInactive";
            this.lblDateOfInactive.Size = new System.Drawing.Size(87, 13);
            this.lblDateOfInactive.TabIndex = 37;
            this.lblDateOfInactive.Text = "Date Of Inactive";
            // 
            // dtPickerDateOfInactive
            // 
            this.dtPickerDateOfInactive.Location = new System.Drawing.Point(264, 196);
            this.dtPickerDateOfInactive.Name = "dtPickerDateOfInactive";
            this.dtPickerDateOfInactive.Size = new System.Drawing.Size(82, 20);
            this.dtPickerDateOfInactive.TabIndex = 38;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(15, 238);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 26);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(368, 238);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(67, 26);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(95, 238);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 26);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmFactoryyWorkCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 278);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtPickerDateOfInactive);
            this.Controls.Add(this.lblDateOfInactive);
            this.Controls.Add(this.chkBoxInactive);
            this.Controls.Add(this.chkBoxProductive);
            this.Controls.Add(this.btnSearchPayableControl);
            this.Controls.Add(this.btnSearchClearingControl);
            this.Controls.Add(this.txtClearingControl);
            this.Controls.Add(this.txtPayableControl);
            this.Controls.Add(this.txtExtraRate);
            this.Controls.Add(this.lblExtraRate);
            this.Controls.Add(this.txtRegularRate);
            this.Controls.Add(this.cmbHour);
            this.Controls.Add(this.txtNirik);
            this.Controls.Add(this.txtCategoryDescription);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.lblInactive);
            this.Controls.Add(this.lblClearingControl);
            this.Controls.Add(this.lblPayableControl);
            this.Controls.Add(this.lblRegularRate);
            this.Controls.Add(this.lblProductive);
            this.Controls.Add(this.lblNirik);
            this.Controls.Add(this.lblCategoryDescription);
            this.Controls.Add(this.lblCategoryId);
            this.MaximizeBox = false;
            this.Name = "frmFactoryyWorkCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factory Work Category";
            this.Load += new System.EventHandler(this.frmFactoryyWorkCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Label lblCategoryDescription;
        private System.Windows.Forms.Label lblNirik;
        private System.Windows.Forms.Label lblProductive;
        private System.Windows.Forms.Label lblRegularRate;
        private System.Windows.Forms.Label lblPayableControl;
        private System.Windows.Forms.Label lblClearingControl;
        private System.Windows.Forms.Label lblInactive;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtCategoryDescription;
        private System.Windows.Forms.TextBox txtNirik;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.TextBox txtRegularRate;
        private System.Windows.Forms.Label lblExtraRate;
        private System.Windows.Forms.TextBox txtExtraRate;
        private System.Windows.Forms.TextBox txtPayableControl;
        private System.Windows.Forms.TextBox txtClearingControl;
        private System.Windows.Forms.Button btnSearchClearingControl;
        private System.Windows.Forms.Button btnSearchPayableControl;
        private System.Windows.Forms.CheckBox chkBoxProductive;
        private System.Windows.Forms.CheckBox chkBoxInactive;
        private System.Windows.Forms.Label lblDateOfInactive;
        private System.Windows.Forms.DateTimePicker dtPickerDateOfInactive;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
    }
}