namespace TMS_Project
{
    partial class frmDatabaseBackup
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbBackup = new System.Windows.Forms.ComboBox();
            this.txtbackupf = new System.Windows.Forms.TextBox();
            this.txtbackupdetail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmbBackFilePathRstore = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBackFilePathRstoreFile = new System.Windows.Forms.TextBox();
            this.listBoxBackFilePathRstore = new System.Windows.Forms.ListBox();
            this.txtBackFilePathRstoreF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(6, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(626, 348);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.cmbBackup);
            this.tabPage1.Controls.Add(this.txtbackupf);
            this.tabPage1.Controls.Add(this.txtbackupdetail);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(618, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Backup";
            // 
            // cmbBackup
            // 
            this.cmbBackup.FormattingEnabled = true;
            this.cmbBackup.Location = new System.Drawing.Point(17, 33);
            this.cmbBackup.Name = "cmbBackup";
            this.cmbBackup.Size = new System.Drawing.Size(580, 21);
            this.cmbBackup.TabIndex = 4;
            // 
            // txtbackupf
            // 
            this.txtbackupf.Location = new System.Drawing.Point(16, 282);
            this.txtbackupf.Name = "txtbackupf";
            this.txtbackupf.Size = new System.Drawing.Size(581, 20);
            this.txtbackupf.TabIndex = 3;
            // 
            // txtbackupdetail
            // 
            this.txtbackupdetail.Location = new System.Drawing.Point(17, 67);
            this.txtbackupdetail.Multiline = true;
            this.txtbackupdetail.Name = "txtbackupdetail";
            this.txtbackupdetail.Size = new System.Drawing.Size(580, 202);
            this.txtbackupdetail.TabIndex = 2;
            this.txtbackupdetail.Resize += new System.EventHandler(this.textBox2_Resize);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Backup to :";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.Controls.Add(this.cmbBackFilePathRstore);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.txtBackFilePathRstoreFile);
            this.tabPage3.Controls.Add(this.listBoxBackFilePathRstore);
            this.tabPage3.Controls.Add(this.txtBackFilePathRstoreF);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(618, 322);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Restore";
            // 
            // cmbBackFilePathRstore
            // 
            this.cmbBackFilePathRstore.FormattingEnabled = true;
            this.cmbBackFilePathRstore.Location = new System.Drawing.Point(16, 40);
            this.cmbBackFilePathRstore.Name = "cmbBackFilePathRstore";
            this.cmbBackFilePathRstore.Size = new System.Drawing.Size(519, 21);
            this.cmbBackFilePathRstore.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "File Available :";
            // 
            // txtBackFilePathRstoreFile
            // 
            this.txtBackFilePathRstoreFile.Location = new System.Drawing.Point(253, 117);
            this.txtBackFilePathRstoreFile.Multiline = true;
            this.txtBackFilePathRstoreFile.Name = "txtBackFilePathRstoreFile";
            this.txtBackFilePathRstoreFile.Size = new System.Drawing.Size(164, 140);
            this.txtBackFilePathRstoreFile.TabIndex = 5;
            // 
            // listBoxBackFilePathRstore
            // 
            this.listBoxBackFilePathRstore.FormattingEnabled = true;
            this.listBoxBackFilePathRstore.Location = new System.Drawing.Point(16, 78);
            this.listBoxBackFilePathRstore.Name = "listBoxBackFilePathRstore";
            this.listBoxBackFilePathRstore.Size = new System.Drawing.Size(190, 186);
            this.listBoxBackFilePathRstore.TabIndex = 4;
            // 
            // txtBackFilePathRstoreF
            // 
            this.txtBackFilePathRstoreF.Location = new System.Drawing.Point(16, 270);
            this.txtBackFilePathRstoreF.Name = "txtBackFilePathRstoreF";
            this.txtBackFilePathRstoreF.Size = new System.Drawing.Size(519, 20);
            this.txtBackFilePathRstoreF.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Back File Path :";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(12, 351);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(61, 22);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "OK";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(493, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 24);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmDatabaseBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 382);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDatabaseBackup";
            this.Text = "Database Backup";
            this.Load += new System.EventHandler(this.Database_Backup_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtbackupf;
        private System.Windows.Forms.TextBox txtbackupdetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtBackFilePathRstoreFile;
        private System.Windows.Forms.ListBox listBoxBackFilePathRstore;
        private System.Windows.Forms.TextBox txtBackFilePathRstoreF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbBackup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBackFilePathRstore;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}