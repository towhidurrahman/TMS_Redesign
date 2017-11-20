namespace TMS_Project
{
    partial class frmLeave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeave));
            this.grpBoxLeave = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbLeaveType = new System.Windows.Forms.ComboBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.dtPickerToDate = new System.Windows.Forms.DateTimePicker();
            this.dtPickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.lblLeaveType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dtLeave = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpBoxLeave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtLeave)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxLeave
            // 
            this.grpBoxLeave.Controls.Add(this.btnSearch);
            this.grpBoxLeave.Controls.Add(this.cmbLeaveType);
            this.grpBoxLeave.Controls.Add(this.txtEmployeeName);
            this.grpBoxLeave.Controls.Add(this.txtEmployeeId);
            this.grpBoxLeave.Controls.Add(this.dtPickerToDate);
            this.grpBoxLeave.Controls.Add(this.dtPickerFromDate);
            this.grpBoxLeave.Controls.Add(this.lblEmployeeId);
            this.grpBoxLeave.Controls.Add(this.lblLeaveType);
            this.grpBoxLeave.Controls.Add(this.label2);
            this.grpBoxLeave.Controls.Add(this.lblToDate);
            this.grpBoxLeave.Controls.Add(this.lblFromDate);
            this.grpBoxLeave.Location = new System.Drawing.Point(13, 13);
            this.grpBoxLeave.Name = "grpBoxLeave";
            this.grpBoxLeave.Size = new System.Drawing.Size(548, 141);
            this.grpBoxLeave.TabIndex = 0;
            this.grpBoxLeave.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(183, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(27, 21);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // cmbLeaveType
            // 
            this.cmbLeaveType.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLeaveType.FormattingEnabled = true;
            this.cmbLeaveType.Location = new System.Drawing.Point(280, 64);
            this.cmbLeaveType.Name = "cmbLeaveType";
            this.cmbLeaveType.Size = new System.Drawing.Size(85, 21);
            this.cmbLeaveType.TabIndex = 10;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.Location = new System.Drawing.Point(92, 104);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(273, 20);
            this.txtEmployeeName.TabIndex = 9;
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeId.Location = new System.Drawing.Point(92, 64);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(85, 20);
            this.txtEmployeeId.TabIndex = 8;
            // 
            // dtPickerToDate
            // 
            this.dtPickerToDate.Location = new System.Drawing.Point(280, 20);
            this.dtPickerToDate.Name = "dtPickerToDate";
            this.dtPickerToDate.Size = new System.Drawing.Size(85, 20);
            this.dtPickerToDate.TabIndex = 7;
            // 
            // dtPickerFromDate
            // 
            this.dtPickerFromDate.Location = new System.Drawing.Point(92, 20);
            this.dtPickerFromDate.Name = "dtPickerFromDate";
            this.dtPickerFromDate.Size = new System.Drawing.Size(85, 20);
            this.dtPickerFromDate.TabIndex = 6;
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(7, 66);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(65, 13);
            this.lblEmployeeId.TabIndex = 5;
            this.lblEmployeeId.Text = "Employee Id";
            // 
            // lblLeaveType
            // 
            this.lblLeaveType.AutoSize = true;
            this.lblLeaveType.Location = new System.Drawing.Point(216, 67);
            this.lblLeaveType.Name = "lblLeaveType";
            this.lblLeaveType.Size = new System.Drawing.Size(64, 13);
            this.lblLeaveType.TabIndex = 4;
            this.lblLeaveType.Text = "Leave Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee Name";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(214, 23);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(46, 13);
            this.lblToDate.TabIndex = 1;
            this.lblToDate.Text = "To Date";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(7, 23);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(56, 13);
            this.lblFromDate.TabIndex = 0;
            this.lblFromDate.Text = "From Date";
            // 
            // dtLeave
            // 
            this.dtLeave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLeave.Location = new System.Drawing.Point(13, 161);
            this.dtLeave.Name = "dtLeave";
            this.dtLeave.Size = new System.Drawing.Size(548, 150);
            this.dtLeave.TabIndex = 1;
            this.dtLeave.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLeave_CellContentClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 322);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(105, 322);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(392, 322);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 4;
            this.btnPost.Text = "&Post";
            this.btnPost.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(486, 322);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 357);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtLeave);
            this.Controls.Add(this.grpBoxLeave);
            this.Name = "frmLeave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leave";
            this.grpBoxLeave.ResumeLayout(false);
            this.grpBoxLeave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtLeave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxLeave;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Label lblLeaveType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.ComboBox cmbLeaveType;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.DateTimePicker dtPickerToDate;
        private System.Windows.Forms.DateTimePicker dtPickerFromDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dtLeave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnCancel;
    }
}