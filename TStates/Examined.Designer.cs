namespace AppSound
{
    partial class Examined
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
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label5 = new System.Windows.Forms.Label();
            this.drpRepo = new System.Windows.Forms.ComboBox();
            this.drpDates = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lobsDrp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tgneedDrp = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.stageDrp = new System.Windows.Forms.ComboBox();
            this.pcf = new System.Windows.Forms.PictureBox();
            this.ResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ExaminerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTagneedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_TagneedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcf)).BeginInit();
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
            // reportViewer2
            // 
            reportDataSource1.Name = "ObsvTot";
            reportDataSource1.Value = this.ExaminerBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "AppSound.Reports.mainTagneed.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 2);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(753, 752);
            this.reportViewer2.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1175, 611);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 29);
            this.label5.TabIndex = 90;
            this.label5.Text = "نوع الخطاب";
            // 
            // drpRepo
            // 
            this.drpRepo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpRepo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.drpRepo.ForeColor = System.Drawing.Color.Black;
            this.drpRepo.FormattingEnabled = true;
            this.drpRepo.Location = new System.Drawing.Point(762, 611);
            this.drpRepo.Name = "drpRepo";
            this.drpRepo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.drpRepo.Size = new System.Drawing.Size(379, 27);
            this.drpRepo.TabIndex = 89;
            this.drpRepo.SelectionChangeCommitted += new System.EventHandler(this.tgneedDrp_SelectedIndexChanged);
            // 
            // drpDates
            // 
            this.drpDates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpDates.Font = new System.Drawing.Font("Tahoma", 12F);
            this.drpDates.ForeColor = System.Drawing.Color.Black;
            this.drpDates.FormattingEnabled = true;
            this.drpDates.Location = new System.Drawing.Point(762, 555);
            this.drpDates.Name = "drpDates";
            this.drpDates.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.drpDates.Size = new System.Drawing.Size(379, 27);
            this.drpDates.TabIndex = 88;
            this.drpDates.SelectedIndexChanged += new System.EventHandler(this.tgneedDrp_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1212, 555);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 29);
            this.label1.TabIndex = 87;
            this.label1.Text = "التاريخ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1214, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 29);
            this.label3.TabIndex = 86;
            this.label3.Text = "السمات";
            // 
            // lobsDrp
            // 
            this.lobsDrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lobsDrp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lobsDrp.ForeColor = System.Drawing.Color.Black;
            this.lobsDrp.FormattingEnabled = true;
            this.lobsDrp.Location = new System.Drawing.Point(762, 502);
            this.lobsDrp.Name = "lobsDrp";
            this.lobsDrp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lobsDrp.Size = new System.Drawing.Size(379, 27);
            this.lobsDrp.TabIndex = 85;
            this.lobsDrp.SelectedIndexChanged += new System.EventHandler(this.tgneedDrp_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1167, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 84;
            this.label4.Text = "مركز التدريب";
            // 
            // tgneedDrp
            // 
            this.tgneedDrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tgneedDrp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tgneedDrp.ForeColor = System.Drawing.Color.Black;
            this.tgneedDrp.FormattingEnabled = true;
            this.tgneedDrp.Location = new System.Drawing.Point(762, 391);
            this.tgneedDrp.Name = "tgneedDrp";
            this.tgneedDrp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tgneedDrp.Size = new System.Drawing.Size(379, 27);
            this.tgneedDrp.TabIndex = 83;
            this.tgneedDrp.SelectedIndexChanged += new System.EventHandler(this.tgneedDrp_SelectedIndexChanged);
            this.tgneedDrp.SelectionChangeCommitted += new System.EventHandler(this.tgneedDrp_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1212, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 29);
            this.label6.TabIndex = 82;
            this.label6.Text = "المرحلة";
            // 
            // stageDrp
            // 
            this.stageDrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stageDrp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.stageDrp.ForeColor = System.Drawing.Color.Black;
            this.stageDrp.FormattingEnabled = true;
            this.stageDrp.Location = new System.Drawing.Point(762, 447);
            this.stageDrp.Name = "stageDrp";
            this.stageDrp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.stageDrp.Size = new System.Drawing.Size(379, 27);
            this.stageDrp.TabIndex = 81;
            this.stageDrp.SelectedIndexChanged += new System.EventHandler(this.tgneedDrp_SelectedIndexChanged);
            this.stageDrp.SelectionChangeCommitted += new System.EventHandler(this.tgneedDrp_SelectionChangeCommitted);
            // 
            // pcf
            // 
            this.pcf.Image = global::AppSound.Properties.Resources._123;
            this.pcf.InitialImage = null;
            this.pcf.Location = new System.Drawing.Point(762, 2);
            this.pcf.Name = "pcf";
            this.pcf.Size = new System.Drawing.Size(523, 360);
            this.pcf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcf.TabIndex = 108;
            this.pcf.TabStop = false;
            // 
            // ResultsBindingSource
            // 
            this.ResultsBindingSource.DataSource = typeof(AppSound.Results);
            // 
            // Examined
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1298, 755);
            this.Controls.Add(this.pcf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.drpRepo);
            this.Controls.Add(this.drpDates);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lobsDrp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tgneedDrp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stageDrp);
            this.Controls.Add(this.reportViewer2);
            this.Name = "Examined";
            this.Text = "نتيجة الجنود بالفرع";
            this.Load += new System.EventHandler(this.StateReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExaminerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTagneedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_TagneedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource MainTagneedBindingSource;
        private DB_TagneedDataSet DB_TagneedDataSet;
        private DB_TagneedDataSetTableAdapters.MainTagneedTableAdapter MainTagneedTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource ResultsBindingSource;
        private System.Windows.Forms.BindingSource ExaminerBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox drpRepo;
        private System.Windows.Forms.ComboBox drpDates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox lobsDrp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tgneedDrp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox stageDrp;
        private System.Windows.Forms.PictureBox pcf;
    }
}