//namespace HRMS
//{
//    partial class frmMain
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
//            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
//            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
//            this.treeView1 = new System.Windows.Forms.TreeView();
//            this.button1 = new System.Windows.Forms.Button();
//            this.listView1 = new System.Windows.Forms.ListView();
//            this.smallImageList = new System.Windows.Forms.ImageList(this.components);
//            this.panel1 = new System.Windows.Forms.Panel();
//            this.pictureBox1 = new System.Windows.Forms.PictureBox();
//            this.textBox1 = new System.Windows.Forms.TextBox();
//            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
//            this.bigImageList = new System.Windows.Forms.ImageList(this.components);
//            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
//            this.menuStrip1.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
//            this.splitContainer1.Panel1.SuspendLayout();
//            this.splitContainer1.Panel2.SuspendLayout();
//            this.splitContainer1.SuspendLayout();
//            this.panel1.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // menuStrip1
//            // 
//            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.fileToolStripMenuItem,
//            this.helpToolStripMenuItem});
//            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
//            this.menuStrip1.Name = "menuStrip1";
//            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
//            this.menuStrip1.Size = new System.Drawing.Size(1194, 24);
//            this.menuStrip1.TabIndex = 5;
//            this.menuStrip1.Text = "menuStrip1";
//            // 
//            // fileToolStripMenuItem
//            // 
//            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.closeToolStripMenuItem});
//            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
//            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
//            this.fileToolStripMenuItem.Text = "File";
//            // 
//            // closeToolStripMenuItem
//            // 
//            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
//            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
//            this.closeToolStripMenuItem.Text = "&Close";
//            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
//            // 
//            // helpToolStripMenuItem
//            // 
//            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.documentationToolStripMenuItem});
//            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
//            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
//            this.helpToolStripMenuItem.Text = "Help";
//            // 
//            // documentationToolStripMenuItem
//            // 
//            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
//            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
//            this.documentationToolStripMenuItem.Text = "Documentation";
//            // 
//            // splitContainer1
//            // 
//            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
//            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
//            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            this.splitContainer1.Name = "splitContainer1";
//            // 
//            // splitContainer1.Panel1
//            // 
//            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
//            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
//            // 
//            // splitContainer1.Panel2
//            // 
//            this.splitContainer1.Panel2.Controls.Add(this.button1);
//            this.splitContainer1.Panel2.Controls.Add(this.listView1);
//            this.splitContainer1.Panel2.Controls.Add(this.panel1);
//            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
//            this.splitContainer1.Size = new System.Drawing.Size(1194, 464);
//            this.splitContainer1.SplitterDistance = 300;
//            this.splitContainer1.SplitterWidth = 6;
//            this.splitContainer1.TabIndex = 6;
//            // 
//            // treeView1
//            // 
//            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.treeView1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.treeView1.Location = new System.Drawing.Point(0, 0);
//            this.treeView1.Name = "treeView1";
//            this.treeView1.Size = new System.Drawing.Size(296, 460);
//            this.treeView1.TabIndex = 2;
//            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
//            // 
//            // button1
//            // 
//            this.button1.Location = new System.Drawing.Point(689, 452);
//            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            this.button1.Name = "button1";
//            this.button1.Size = new System.Drawing.Size(83, 81);
//            this.button1.TabIndex = 2;
//            this.button1.Text = "button1";
//            this.button1.UseVisualStyleBackColor = true;
//            this.button1.Visible = false;
//            // 
//            // listView1
//            // 
//            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.listView1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.listView1.LargeImageList = this.smallImageList;
//            this.listView1.Location = new System.Drawing.Point(0, 100);
//            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            this.listView1.Name = "listView1";
//            this.listView1.Size = new System.Drawing.Size(884, 360);
//            this.listView1.SmallImageList = this.smallImageList;
//            this.listView1.TabIndex = 1;
//            this.listView1.UseCompatibleStateImageBehavior = false;
//            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
//            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
//            // 
//            // smallImageList
//            // 
//            this.smallImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallImageList.ImageStream")));
//            this.smallImageList.TransparentColor = System.Drawing.Color.Transparent;
//            this.smallImageList.Images.SetKeyName(0, "User.JPG");
//            this.smallImageList.Images.SetKeyName(1, "Role.JPG");
//            this.smallImageList.Images.SetKeyName(2, "UserAuthorization.JPG");
//            this.smallImageList.Images.SetKeyName(3, "Folder.JPG");
//            this.smallImageList.Images.SetKeyName(4, "Setup1.JPG");
//            this.smallImageList.Images.SetKeyName(5, "Transactions.JPG");
//            this.smallImageList.Images.SetKeyName(6, "YearEnd1.JPG");
//            this.smallImageList.Images.SetKeyName(7, "Employee.JPG");
//            this.smallImageList.Images.SetKeyName(8, "Organization.JPG");
//            this.smallImageList.Images.SetKeyName(9, "Calendar.JPG");
//            this.smallImageList.Images.SetKeyName(10, "MonthEnd.JPG");
//            this.smallImageList.Images.SetKeyName(11, "Bank1.JPG");
//            // 
//            // panel1
//            // 
//            this.panel1.BackColor = System.Drawing.Color.White;
//            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            this.panel1.Controls.Add(this.pictureBox1);
//            this.panel1.Controls.Add(this.textBox1);
//            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
//            this.panel1.Location = new System.Drawing.Point(0, 0);
//            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            this.panel1.Name = "panel1";
//            this.panel1.Size = new System.Drawing.Size(884, 100);
//            this.panel1.TabIndex = 0;
//            // 
//            // pictureBox1
//            // 
//            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
//            this.pictureBox1.Location = new System.Drawing.Point(166, 20);
//            this.pictureBox1.Name = "pictureBox1";
//            this.pictureBox1.Size = new System.Drawing.Size(32, 44);
//            this.pictureBox1.TabIndex = 1;
//            this.pictureBox1.TabStop = false;
//            this.pictureBox1.Visible = false;
//            // 
//            // textBox1
//            // 
//            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
//            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.textBox1.ForeColor = System.Drawing.Color.DarkRed;
//            this.textBox1.Location = new System.Drawing.Point(3, 42);
//            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            this.textBox1.Name = "textBox1";
//            this.textBox1.Size = new System.Drawing.Size(453, 22);
//            this.textBox1.TabIndex = 0;
//            this.textBox1.Text = "HR Solution";
//            // 
//            // statusStrip1
//            // 
//            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
//            this.statusStrip1.Location = new System.Drawing.Point(0, 488);
//            this.statusStrip1.Name = "statusStrip1";
//            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
//            this.statusStrip1.Size = new System.Drawing.Size(1194, 0);
//            this.statusStrip1.TabIndex = 7;
//            this.statusStrip1.Text = "statusStrip1";
//            // 
//            // bigImageList
//            // 
//            this.bigImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("bigImageList.ImageStream")));
//            this.bigImageList.TransparentColor = System.Drawing.Color.Transparent;
//            this.bigImageList.Images.SetKeyName(0, "Green Dollar.ico");
//            // 
//            // imageList1
//            // 
//            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
//            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
//            this.imageList1.Images.SetKeyName(0, "TranscomLogo.JPG");
//            // 
//            // frmMain
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(1194, 488);
//            this.Controls.Add(this.statusStrip1);
//            this.Controls.Add(this.splitContainer1);
//            this.Controls.Add(this.menuStrip1);
//            this.Name = "frmMain";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "Main Form";
//            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
//            this.Load += new System.EventHandler(this.frmMain_Load);
//            this.menuStrip1.ResumeLayout(false);
//            this.menuStrip1.PerformLayout();
//            this.splitContainer1.Panel1.ResumeLayout(false);
//            this.splitContainer1.Panel2.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
//            this.splitContainer1.ResumeLayout(false);
//            this.panel1.ResumeLayout(false);
//            this.panel1.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.MenuStrip menuStrip1;
//        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
//        private System.Windows.Forms.SplitContainer splitContainer1;
//        private System.Windows.Forms.Button button1;
//        private System.Windows.Forms.ListView listView1;
//        private System.Windows.Forms.Panel panel1;
//        private System.Windows.Forms.PictureBox pictureBox1;
//        private System.Windows.Forms.TextBox textBox1;
//        private System.Windows.Forms.StatusStrip statusStrip1;
//        private System.Windows.Forms.ImageList smallImageList;
//        private System.Windows.Forms.ImageList bigImageList;
//        private System.Windows.Forms.ImageList imageList1;
//        private System.Windows.Forms.TreeView treeView1;
//    }
//}