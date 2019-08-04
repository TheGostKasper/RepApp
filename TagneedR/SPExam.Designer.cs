namespace AppSound.TagneedR
{
    partial class SPExam
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
            this.label3 = new System.Windows.Forms.Label();
            this.lobsDrp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stageDrp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.drpQualification = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label4 = new System.Windows.Forms.Label();
            this.drpTagneed = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.drpExams = new System.Windows.Forms.ComboBox();
            this.TYTGExaminerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TYTGExaminerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(948, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 74;
            this.label3.Text = "الاختبار";
            // 
            // lobsDrp
            // 
            this.lobsDrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lobsDrp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lobsDrp.FormattingEnabled = true;
            this.lobsDrp.Location = new System.Drawing.Point(802, 581);
            this.lobsDrp.Name = "lobsDrp";
            this.lobsDrp.Size = new System.Drawing.Size(223, 27);
            this.lobsDrp.TabIndex = 73;
            this.lobsDrp.SelectedValueChanged += new System.EventHandler(this.tgneedDrp_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(952, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 29);
            this.label2.TabIndex = 70;
            this.label2.Text = "المرحلة";
            // 
            // stageDrp
            // 
            this.stageDrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stageDrp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.stageDrp.FormattingEnabled = true;
            this.stageDrp.Location = new System.Drawing.Point(802, 267);
            this.stageDrp.Name = "stageDrp";
            this.stageDrp.Size = new System.Drawing.Size(223, 27);
            this.stageDrp.TabIndex = 69;
            this.stageDrp.SelectedValueChanged += new System.EventHandler(this.tgneedDrp_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(958, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 29);
            this.label1.TabIndex = 76;
            this.label1.Text = "المؤهل";
            // 
            // drpQualification
            // 
            this.drpQualification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpQualification.Font = new System.Drawing.Font("Tahoma", 12F);
            this.drpQualification.FormattingEnabled = true;
            this.drpQualification.Location = new System.Drawing.Point(802, 379);
            this.drpQualification.Name = "drpQualification";
            this.drpQualification.Size = new System.Drawing.Size(223, 27);
            this.drpQualification.TabIndex = 75;
            this.drpQualification.SelectedValueChanged += new System.EventHandler(this.tgneedDrp_SelectedValueChanged);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetTG";
            reportDataSource1.Value = this.TYTGExaminerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppSound.Reports.SPExamRepo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(14, 117);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(749, 699);
            this.reportViewer1.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(906, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 29);
            this.label4.TabIndex = 79;
            this.label4.Text = "منطقة التجنيد";
            // 
            // drpTagneed
            // 
            this.drpTagneed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpTagneed.Font = new System.Drawing.Font("Tahoma", 12F);
            this.drpTagneed.FormattingEnabled = true;
            this.drpTagneed.Location = new System.Drawing.Point(802, 164);
            this.drpTagneed.Name = "drpTagneed";
            this.drpTagneed.Size = new System.Drawing.Size(223, 27);
            this.drpTagneed.TabIndex = 78;
            this.drpTagneed.SelectedValueChanged += new System.EventHandler(this.tgneedDrp_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(952, 536);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 29);
            this.label5.TabIndex = 81;
            this.label5.Text = "السمات";
            // 
            // drpExams
            // 
            this.drpExams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpExams.Font = new System.Drawing.Font("Tahoma", 12F);
            this.drpExams.FormattingEnabled = true;
            this.drpExams.Location = new System.Drawing.Point(800, 487);
            this.drpExams.Name = "drpExams";
            this.drpExams.Size = new System.Drawing.Size(223, 27);
            this.drpExams.TabIndex = 80;
            this.drpExams.SelectedValueChanged += new System.EventHandler(this.tgneedDrp_SelectedValueChanged);
            // 
            // TYTGExaminerBindingSource
            // 
            this.TYTGExaminerBindingSource.DataSource = typeof(AppSound.Modals.TYTGExaminer);
            // 
            // SPExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1037, 818);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.drpExams);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.drpTagneed);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drpQualification);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lobsDrp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stageDrp);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "SPExam";
            this.Text = "Exclude";
            this.Load += new System.EventHandler(this.Exclude_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TYTGExaminerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox lobsDrp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox stageDrp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox drpQualification;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TYTGExaminerBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox drpTagneed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox drpExams;
    }
}