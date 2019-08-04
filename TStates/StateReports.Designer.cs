namespace AppSound
{
    partial class StateReports
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ExaminerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MainTagneedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DB_TagneedDataSet = new AppSound.DB_TagneedDataSet();
            this.MainTagneedTableAdapter = new AppSound.DB_TagneedDataSetTableAdapters.MainTagneedTableAdapter();
            this.pcf = new System.Windows.Forms.PictureBox();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.drpDates = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.drpRepo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lobsDrp = new System.Windows.Forms.ComboBox();
            this.tgneedDrp = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.stageDrp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ExaminerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTagneedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_TagneedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcf)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ExaminerBindingSource
            // 
            this.ExaminerBindingSource.DataSource = typeof(AppSound.Examiner);
            // 
            // MainTagneedBindingSource
            // 
            this.MainTagneedBindingSource.DataMember = "MainTagneed";
            this.MainTagneedBindingSource.DataSource = this.DB_TagneedDataSet;
            // 
            // DB_TagneedDataSet
            // 
            this.DB_TagneedDataSet.DataSetName = "DB_TagneedDataSet";
            this.DB_TagneedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainTagneedTableAdapter
            // 
            this.MainTagneedTableAdapter.ClearBeforeFill = true;
            // 
            // pcf
            // 
            this.pcf.Image = global::AppSound.Properties.Resources._123;
            this.pcf.InitialImage = null;
            this.pcf.Location = new System.Drawing.Point(762, 0);
            this.pcf.Name = "pcf";
            this.pcf.Size = new System.Drawing.Size(572, 378);
            this.pcf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcf.TabIndex = 101;
            this.pcf.TabStop = false;
            // 
            // reportViewer2
            // 
            reportDataSource1.Name = "ObsvTot";
            reportDataSource1.Value = this.ExaminerBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "AppSound.Reports.mainTagneed.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(756, 867);
            this.reportViewer2.TabIndex = 70;
            // 
            // drpDates
            // 
            this.drpDates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpDates.Font = new System.Drawing.Font("Tahoma", 12F);
            this.drpDates.ForeColor = System.Drawing.Color.Black;
            this.drpDates.FormattingEnabled = true;
            this.drpDates.Location = new System.Drawing.Point(18, 251);
            this.drpDates.Name = "drpDates";
            this.drpDates.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.drpDates.Size = new System.Drawing.Size(354, 27);
            this.drpDates.TabIndex = 98;
            this.drpDates.SelectedIndexChanged += new System.EventHandler(this.tgneedDrp_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(469, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 29);
            this.label1.TabIndex = 97;
            this.label1.Text = "التاريخ";
            // 
            // drpRepo
            // 
            this.drpRepo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpRepo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.drpRepo.ForeColor = System.Drawing.Color.Black;
            this.drpRepo.FormattingEnabled = true;
            this.drpRepo.Location = new System.Drawing.Point(18, 317);
            this.drpRepo.Name = "drpRepo";
            this.drpRepo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.drpRepo.Size = new System.Drawing.Size(354, 27);
            this.drpRepo.TabIndex = 99;
            this.drpRepo.SelectionChangeCommitted += new System.EventHandler(this.tgneedDrp_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(465, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 29);
            this.label3.TabIndex = 96;
            this.label3.Text = "السمات";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(428, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 29);
            this.label5.TabIndex = 100;
            this.label5.Text = "نوع الخطاب";
            // 
            // lobsDrp
            // 
            this.lobsDrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lobsDrp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lobsDrp.ForeColor = System.Drawing.Color.Black;
            this.lobsDrp.FormattingEnabled = true;
            this.lobsDrp.Location = new System.Drawing.Point(18, 190);
            this.lobsDrp.Name = "lobsDrp";
            this.lobsDrp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lobsDrp.Size = new System.Drawing.Size(354, 27);
            this.lobsDrp.TabIndex = 95;
            this.lobsDrp.SelectedIndexChanged += new System.EventHandler(this.tgneedDrp_SelectedIndexChanged);
            // 
            // tgneedDrp
            // 
            this.tgneedDrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tgneedDrp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tgneedDrp.ForeColor = System.Drawing.Color.Black;
            this.tgneedDrp.FormattingEnabled = true;
            this.tgneedDrp.Location = new System.Drawing.Point(18, 69);
            this.tgneedDrp.Name = "tgneedDrp";
            this.tgneedDrp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tgneedDrp.Size = new System.Drawing.Size(354, 27);
            this.tgneedDrp.TabIndex = 93;
            this.tgneedDrp.SelectedIndexChanged += new System.EventHandler(this.tgneedDrp_SelectedIndexChanged);
            this.tgneedDrp.SelectionChangeCommitted += new System.EventHandler(this.tgneedDrp_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(463, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 29);
            this.label6.TabIndex = 92;
            this.label6.Text = "المرحلة";
            // 
            // stageDrp
            // 
            this.stageDrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stageDrp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.stageDrp.ForeColor = System.Drawing.Color.Black;
            this.stageDrp.FormattingEnabled = true;
            this.stageDrp.Location = new System.Drawing.Point(18, 130);
            this.stageDrp.Name = "stageDrp";
            this.stageDrp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.stageDrp.Size = new System.Drawing.Size(354, 27);
            this.stageDrp.TabIndex = 91;
            this.stageDrp.SelectedIndexChanged += new System.EventHandler(this.tgneedDrp_SelectedIndexChanged);
            this.stageDrp.SelectionChangeCommitted += new System.EventHandler(this.tgneedDrp_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(420, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 94;
            this.label4.Text = "مركز التدريب";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.stageDrp);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tgneedDrp);
            this.groupBox1.Controls.Add(this.lobsDrp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.drpRepo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.drpDates);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(762, 384);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(572, 454);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات البحث";
            // 
            // ResultsBindingSource
            // 
            this.ResultsBindingSource.DataSource = typeof(AppSound.Results);
            // 
            // StateReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1348, 869);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pcf);
            this.Controls.Add(this.reportViewer2);
            this.Name = "StateReports";
            this.Text = "نتيجة الجنود بمراكز التدريب";
            this.Load += new System.EventHandler(this.StateReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExaminerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTagneedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_TagneedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcf)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource MainTagneedBindingSource;
        private DB_TagneedDataSet DB_TagneedDataSet;
        private DB_TagneedDataSetTableAdapters.MainTagneedTableAdapter MainTagneedTableAdapter;
        private System.Windows.Forms.BindingSource ResultsBindingSource;
        private System.Windows.Forms.BindingSource ExaminerBindingSource;
        private System.Windows.Forms.PictureBox pcf;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.ComboBox drpDates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox drpRepo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox lobsDrp;
        private System.Windows.Forms.ComboBox tgneedDrp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox stageDrp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}