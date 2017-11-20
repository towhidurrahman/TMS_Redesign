namespace TMS_Project
{
    partial class frmWeather
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWeather));
            this.grpRainFall = new System.Windows.Forms.GroupBox();
            this.txtRainfallNight = new System.Windows.Forms.TextBox();
            this.lblRainfallNight = new System.Windows.Forms.Label();
            this.txtRainfallDay = new System.Windows.Forms.TextBox();
            this.lblRainfallDay = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpTemperature = new System.Windows.Forms.GroupBox();
            this.txtTempWetBulb = new System.Windows.Forms.TextBox();
            this.lblWetBulb = new System.Windows.Forms.Label();
            this.txtTempDryBulb = new System.Windows.Forms.TextBox();
            this.lblTempDrybulb = new System.Windows.Forms.Label();
            this.txtTempMin = new System.Windows.Forms.TextBox();
            this.lblTempMin = new System.Windows.Forms.Label();
            this.txtTempMax = new System.Windows.Forms.TextBox();
            this.lblTempMax = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblGardenName = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.grpRainFall.SuspendLayout();
            this.grpTemperature.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRainFall
            // 
            this.grpRainFall.Controls.Add(this.txtRainfallNight);
            this.grpRainFall.Controls.Add(this.lblRainfallNight);
            this.grpRainFall.Controls.Add(this.txtRainfallDay);
            this.grpRainFall.Controls.Add(this.lblRainfallDay);
            this.grpRainFall.Location = new System.Drawing.Point(18, 41);
            this.grpRainFall.Name = "grpRainFall";
            this.grpRainFall.Size = new System.Drawing.Size(361, 59);
            this.grpRainFall.TabIndex = 0;
            this.grpRainFall.TabStop = false;
            this.grpRainFall.Text = "Rainfall";
            // 
            // txtRainfallNight
            // 
            this.txtRainfallNight.Location = new System.Drawing.Point(250, 21);
            this.txtRainfallNight.Name = "txtRainfallNight";
            this.txtRainfallNight.Size = new System.Drawing.Size(91, 20);
            this.txtRainfallNight.TabIndex = 6;
            // 
            // lblRainfallNight
            // 
            this.lblRainfallNight.AutoSize = true;
            this.lblRainfallNight.Location = new System.Drawing.Point(189, 24);
            this.lblRainfallNight.Name = "lblRainfallNight";
            this.lblRainfallNight.Size = new System.Drawing.Size(32, 13);
            this.lblRainfallNight.TabIndex = 5;
            this.lblRainfallNight.Text = "Night";
            // 
            // txtRainfallDay
            // 
            this.txtRainfallDay.Location = new System.Drawing.Point(79, 21);
            this.txtRainfallDay.Name = "txtRainfallDay";
            this.txtRainfallDay.Size = new System.Drawing.Size(91, 20);
            this.txtRainfallDay.TabIndex = 4;
            // 
            // lblRainfallDay
            // 
            this.lblRainfallDay.AutoSize = true;
            this.lblRainfallDay.Location = new System.Drawing.Point(9, 25);
            this.lblRainfallDay.Name = "lblRainfallDay";
            this.lblRainfallDay.Size = new System.Drawing.Size(26, 13);
            this.lblRainfallDay.TabIndex = 3;
            this.lblRainfallDay.Text = "Day";
            // 
            // grpTemperature
            // 
            this.grpTemperature.Controls.Add(this.txtTempWetBulb);
            this.grpTemperature.Controls.Add(this.lblWetBulb);
            this.grpTemperature.Controls.Add(this.txtTempDryBulb);
            this.grpTemperature.Controls.Add(this.lblTempDrybulb);
            this.grpTemperature.Controls.Add(this.txtTempMin);
            this.grpTemperature.Controls.Add(this.lblTempMin);
            this.grpTemperature.Controls.Add(this.txtTempMax);
            this.grpTemperature.Controls.Add(this.lblTempMax);
            this.grpTemperature.Location = new System.Drawing.Point(20, 111);
            this.grpTemperature.Name = "grpTemperature";
            this.grpTemperature.Size = new System.Drawing.Size(361, 83);
            this.grpTemperature.TabIndex = 1;
            this.grpTemperature.TabStop = false;
            this.grpTemperature.Text = "Temperature";
            // 
            // txtTempWetBulb
            // 
            this.txtTempWetBulb.Location = new System.Drawing.Point(249, 54);
            this.txtTempWetBulb.Name = "txtTempWetBulb";
            this.txtTempWetBulb.Size = new System.Drawing.Size(91, 20);
            this.txtTempWetBulb.TabIndex = 14;
            // 
            // lblWetBulb
            // 
            this.lblWetBulb.AutoSize = true;
            this.lblWetBulb.Location = new System.Drawing.Point(181, 55);
            this.lblWetBulb.Name = "lblWetBulb";
            this.lblWetBulb.Size = new System.Drawing.Size(66, 13);
            this.lblWetBulb.TabIndex = 13;
            this.lblWetBulb.Text = "Wetbulb(oC)";
            // 
            // txtTempDryBulb
            // 
            this.txtTempDryBulb.Location = new System.Drawing.Point(78, 53);
            this.txtTempDryBulb.Name = "txtTempDryBulb";
            this.txtTempDryBulb.Size = new System.Drawing.Size(91, 20);
            this.txtTempDryBulb.TabIndex = 12;
            // 
            // lblTempDrybulb
            // 
            this.lblTempDrybulb.AutoSize = true;
            this.lblTempDrybulb.Location = new System.Drawing.Point(7, 54);
            this.lblTempDrybulb.Name = "lblTempDrybulb";
            this.lblTempDrybulb.Size = new System.Drawing.Size(62, 13);
            this.lblTempDrybulb.TabIndex = 11;
            this.lblTempDrybulb.Text = "Drybulb(oC)";
            // 
            // txtTempMin
            // 
            this.txtTempMin.Location = new System.Drawing.Point(249, 22);
            this.txtTempMin.Name = "txtTempMin";
            this.txtTempMin.Size = new System.Drawing.Size(91, 20);
            this.txtTempMin.TabIndex = 10;
            // 
            // lblTempMin
            // 
            this.lblTempMin.AutoSize = true;
            this.lblTempMin.Location = new System.Drawing.Point(180, 23);
            this.lblTempMin.Name = "lblTempMin";
            this.lblTempMin.Size = new System.Drawing.Size(67, 13);
            this.lblTempMin.TabIndex = 9;
            this.lblTempMin.Text = "Minimum(oC)";
            // 
            // txtTempMax
            // 
            this.txtTempMax.Location = new System.Drawing.Point(78, 21);
            this.txtTempMax.Name = "txtTempMax";
            this.txtTempMax.Size = new System.Drawing.Size(91, 20);
            this.txtTempMax.TabIndex = 8;
            // 
            // lblTempMax
            // 
            this.lblTempMax.AutoSize = true;
            this.lblTempMax.Location = new System.Drawing.Point(5, 22);
            this.lblTempMax.Name = "lblTempMax";
            this.lblTempMax.Size = new System.Drawing.Size(70, 13);
            this.lblTempMax.TabIndex = 7;
            this.lblTempMax.Text = "Maximum(oC)";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(322, 210);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 22);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(177, 209);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(59, 22);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(22, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 22);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblGardenName
            // 
            this.lblGardenName.AutoSize = true;
            this.lblGardenName.Location = new System.Drawing.Point(30, 280);
            this.lblGardenName.Name = "lblGardenName";
            this.lblGardenName.Size = new System.Drawing.Size(0, 13);
            this.lblGardenName.TabIndex = 10;
            // 
            // btnNew
            // 
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.Location = new System.Drawing.Point(307, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(25, 21);
            this.btnNew.TabIndex = 78;
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(283, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(25, 21);
            this.btnSearch.TabIndex = 77;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.Location = new System.Drawing.Point(259, 12);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(25, 21);
            this.btnLast.TabIndex = 76;
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(235, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(25, 21);
            this.btnNext.TabIndex = 75;
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.Location = new System.Drawing.Point(103, 12);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(25, 21);
            this.btnFirst.TabIndex = 74;
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.Location = new System.Drawing.Point(128, 12);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(25, 21);
            this.btnPrevious.TabIndex = 73;
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(153, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(85, 20);
            this.textBox3.TabIndex = 72;
            // 
            // frmWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 255);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblGardenName);
            this.Controls.Add(this.grpTemperature);
            this.Controls.Add(this.grpRainFall);
            this.Name = "frmWeather";
            this.Text = "Weather";
            this.grpRainFall.ResumeLayout(false);
            this.grpRainFall.PerformLayout();
            this.grpTemperature.ResumeLayout(false);
            this.grpTemperature.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRainFall;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpTemperature;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblGardenName;
        private System.Windows.Forms.TextBox txtRainfallNight;
        private System.Windows.Forms.Label lblRainfallNight;
        private System.Windows.Forms.TextBox txtRainfallDay;
        private System.Windows.Forms.Label lblRainfallDay;
        private System.Windows.Forms.TextBox txtTempWetBulb;
        private System.Windows.Forms.Label lblWetBulb;
        private System.Windows.Forms.TextBox txtTempDryBulb;
        private System.Windows.Forms.Label lblTempDrybulb;
        private System.Windows.Forms.TextBox txtTempMin;
        private System.Windows.Forms.Label lblTempMin;
        private System.Windows.Forms.TextBox txtTempMax;
        private System.Windows.Forms.Label lblTempMax;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox textBox3;
    }
}