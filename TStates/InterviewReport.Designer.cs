namespace AppSound
{
    partial class InterviewReport
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
            this.label3 = new System.Windows.Forms.Label();
            this.lobsDrp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tgneedDrp = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.stageDrp = new System.Windows.Forms.ComboBox();
            this.drpDates = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.drpHosResults = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.drpSoldSituation = new System.Windows.Forms.ComboBox();
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
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "AppSound.Reports.results.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(2, 12);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(744, 845);
            this.reportViewer2.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1115, 536);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 29);
            this.label3.TabIndex = 86;
            this.label3.Text = "رأي القائم بالمقابلة";
            // 
            // lobsDrp
            // 
            this.lobsDrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lobsDrp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lobsDrp.FormattingEnabled = true;
            this.lobsDrp.Location = new System.Drawing.Point(757, 536);
            this.lobsDrp.Name = "lobsDrp";
            this.lobsDrp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lobsDrp.Size = new System.Drawing.Size(337, 27);
            this.lobsDrp.TabIndex = 85;
            this.lobsDrp.SelectedIndexChanged += new System.EventHandler(this.tgneedDrp_SelectedIndexChanged);
            this.lobsDrp.SelectionChangeCommitted += new System.EventHandler(this.lobsDrp_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1125, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 84;
            this.label4.Text = "مركز التدريب";
            // 
            // tgneedDrp
            // 
            this.tgneedDrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tgneedDrp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tgneedDrp.FormattingEnabled = true;
            this.tgneedDrp.Location = new System.Drawing.Point(757, 360);
            this.tgneedDrp.Name = "tgneedDrp";
            this.tgneedDrp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tgneedDrp.Size = new System.Drawing.Size(337, 27);
            this.tgneedDrp.TabIndex = 83;
            this.tgneedDrp.SelectedIndexChanged += new System.EventHandler(this.tgneedDrp_SelectedIndexChanged);
            this.tgneedDrp.SelectionChangeCommitted += new System.EventHandler(this.tgneedDrp_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1150, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 29);
            this.label6.TabIndex = 82;
            this.label6.Text = "المرحلة";
            // 
            // stageDrp
            // 
            this.stageDrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stageDrp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.stageDrp.FormattingEnabled = true;
            this.stageDrp.Location = new System.Drawing.Point(757, 416);
            this.stageDrp.Name = "stageDrp";
            this.stageDrp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.stageDrp.Size = new System.Drawing.Size(337, 27);
            this.stageDrp.TabIndex = 81;
            this.stageDrp.SelectedIndexChanged += new System.EventHandler(this.tgneedDrp_SelectedIndexChanged);
            this.stageDrp.SelectionChangeCommitted += new System.EventHandler(this.tgneedDrp_SelectionChangeCommitted);
            // 
            // drpDates
            // 
            this.drpDates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpDates.Font = new System.Drawing.Font("Tahoma", 12F);
            this.drpDates.FormattingEnabled = true;
            this.drpDates.Location = new System.Drawing.Point(757, 474);
            this.drpDates.Name = "drpDates";
            this.drpDates.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.drpDates.Size = new System.Drawing.Size(337, 27);
            this.drpDates.TabIndex = 90;
            this.drpDates.SelectedIndexChanged += new System.EventHandler(this.tgneedDrp_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1156, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 29);
            this.label1.TabIndex = 89;
            this.label1.Text = "التاريخ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(1100, 689);
            this.label25.Name = "label25";
            this.label25.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label25.Size = new System.Drawing.Size(219, 29);
            this.label25.TabIndex = 95;
            this.label25.Text = "نتيجة العرض علي المست";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drpHosResults
            // 
            this.drpHosResults.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpHosResults.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpHosResults.FormattingEnabled = true;
            this.drpHosResults.Items.AddRange(new object[] {
            "لا يوجد",
            "عودة للوحدة",
            "علاج وعودة للوحدة",
            "رفت طبي",
            "رفت نفسى"});
            this.drpHosResults.Location = new System.Drawing.Point(757, 689);
            this.drpHosResults.Name = "drpHosResults";
            this.drpHosResults.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.drpHosResults.Size = new System.Drawing.Size(337, 30);
            this.drpHosResults.TabIndex = 96;
            this.drpHosResults.SelectionChangeCommitted += new System.EventHandler(this.tgneedDrp_SelectedIndexChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(1140, 604);
            this.label24.Name = "label24";
            this.label24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label24.Size = new System.Drawing.Size(115, 29);
            this.label24.TabIndex = 93;
            this.label24.Text = "موقف المجند";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drpSoldSituation
            // 
            this.drpSoldSituation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpSoldSituation.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpSoldSituation.FormattingEnabled = true;
            this.drpSoldSituation.Items.AddRange(new object[] {
            "لا يوجد",
            "لائق",
            "غياب",
            "ترحيل",
            "عرض مست طبي",
            "عرض مست نفسي"});
            this.drpSoldSituation.Location = new System.Drawing.Point(757, 603);
            this.drpSoldSituation.Name = "drpSoldSituation";
            this.drpSoldSituation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.drpSoldSituation.Size = new System.Drawing.Size(337, 30);
            this.drpSoldSituation.TabIndex = 94;
            this.drpSoldSituation.SelectionChangeCommitted += new System.EventHandler(this.tgneedDrp_SelectedIndexChanged);
            // 
            // pcf
            // 
            this.pcf.Image = global::AppSound.Properties.Resources._123;
            this.pcf.InitialImage = null;
            this.pcf.Location = new System.Drawing.Point(757, 0);
            this.pcf.Name = "pcf";
            this.pcf.Size = new System.Drawing.Size(582, 332);
            this.pcf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcf.TabIndex = 112;
            this.pcf.TabStop = false;
            // 
            // ResultsBindingSource
            // 
            this.ResultsBindingSource.DataSource = typeof(AppSound.Results);
            // 
            // InterviewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1340, 869);
            this.Controls.Add(this.pcf);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.drpHosResults);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.drpSoldSituation);
            this.Controls.Add(this.drpDates);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lobsDrp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tgneedDrp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stageDrp);
            this.Controls.Add(this.reportViewer2);
            this.Name = "InterviewReport";
            this.Text = "مواقف المجندين بالمقابلة الشخصية";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox lobsDrp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tgneedDrp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox stageDrp;
        private System.Windows.Forms.ComboBox drpDates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox drpHosResults;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox drpSoldSituation;
        private System.Windows.Forms.PictureBox pcf;
    }
}