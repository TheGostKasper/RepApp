namespace AppSound.TStates
{
    partial class ResultsCollection
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ExaminerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lobsDrp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tgneedDrp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stageDrp = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.drpDates = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.drpRepo = new System.Windows.Forms.ComboBox();
            this.pcf = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEdara = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ExaminerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcf)).BeginInit();
            this.SuspendLayout();
            // 
            // ExaminerBindingSource
            // 
            this.ExaminerBindingSource.DataSource = typeof(AppSound.Examiner);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1202, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 29);
            this.label3.TabIndex = 74;
            this.label3.Text = "السمات";
            // 
            // lobsDrp
            // 
            this.lobsDrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lobsDrp.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lobsDrp.FormattingEnabled = true;
            this.lobsDrp.Location = new System.Drawing.Point(759, 504);
            this.lobsDrp.Name = "lobsDrp";
            this.lobsDrp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lobsDrp.Size = new System.Drawing.Size(363, 31);
            this.lobsDrp.TabIndex = 73;
            this.lobsDrp.SelectedIndexChanged += new System.EventHandler(this.tgneedDrp_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1157, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 72;
            this.label4.Text = "مركز التدريب";
            // 
            // tgneedDrp
            // 
            this.tgneedDrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tgneedDrp.Font = new System.Drawing.Font("Tahoma", 14F);
            this.tgneedDrp.FormattingEnabled = true;
            this.tgneedDrp.Location = new System.Drawing.Point(759, 394);
            this.tgneedDrp.Name = "tgneedDrp";
            this.tgneedDrp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tgneedDrp.Size = new System.Drawing.Size(363, 31);
            this.tgneedDrp.TabIndex = 71;
            this.tgneedDrp.SelectedIndexChanged += new System.EventHandler(this.tgneedDrp_SelectedIndexChanged);
            this.tgneedDrp.SelectionChangeCommitted += new System.EventHandler(this.tgneedDrp_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1202, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 70;
            this.label1.Text = "المرحلة";
            // 
            // stageDrp
            // 
            this.stageDrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stageDrp.Font = new System.Drawing.Font("Tahoma", 14F);
            this.stageDrp.FormattingEnabled = true;
            this.stageDrp.Location = new System.Drawing.Point(759, 446);
            this.stageDrp.Name = "stageDrp";
            this.stageDrp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.stageDrp.Size = new System.Drawing.Size(363, 31);
            this.stageDrp.TabIndex = 69;
            this.stageDrp.SelectedIndexChanged += new System.EventHandler(this.tgneedDrp_SelectedIndexChanged);
            this.stageDrp.SelectionChangeCommitted += new System.EventHandler(this.tgneedDrp_SelectionChangeCommitted);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            reportDataSource1.Name = "SSTS";
            reportDataSource1.Value = this.ExaminerBindingSource;
            reportDataSource2.Name = "ObsvTot";
            reportDataSource2.Value = this.ExaminerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppSound.Reports.STSReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(747, 789);
            this.reportViewer1.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1202, 554);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 29);
            this.label2.TabIndex = 76;
            this.label2.Text = "التاريخ";
            // 
            // drpDates
            // 
            this.drpDates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpDates.Font = new System.Drawing.Font("Tahoma", 14F);
            this.drpDates.FormattingEnabled = true;
            this.drpDates.Location = new System.Drawing.Point(759, 558);
            this.drpDates.Name = "drpDates";
            this.drpDates.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.drpDates.Size = new System.Drawing.Size(363, 31);
            this.drpDates.TabIndex = 78;
            this.drpDates.SelectedIndexChanged += new System.EventHandler(this.tgneedDrp_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1165, 609);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 29);
            this.label5.TabIndex = 80;
            this.label5.Text = "نوع الخطاب";
            // 
            // drpRepo
            // 
            this.drpRepo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpRepo.Font = new System.Drawing.Font("Tahoma", 14F);
            this.drpRepo.FormattingEnabled = true;
            this.drpRepo.Location = new System.Drawing.Point(759, 613);
            this.drpRepo.Name = "drpRepo";
            this.drpRepo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.drpRepo.Size = new System.Drawing.Size(363, 31);
            this.drpRepo.TabIndex = 79;
            this.drpRepo.SelectionChangeCommitted += new System.EventHandler(this.tgneedDrp_SelectedIndexChanged);
            // 
            // pcf
            // 
            this.pcf.Image = global::AppSound.Properties.Resources._123;
            this.pcf.InitialImage = null;
            this.pcf.Location = new System.Drawing.Point(759, 3);
            this.pcf.Name = "pcf";
            this.pcf.Size = new System.Drawing.Size(548, 362);
            this.pcf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcf.TabIndex = 113;
            this.pcf.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1202, 672);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 29);
            this.label6.TabIndex = 115;
            this.label6.Text = "الادارة";
            // 
            // txtEdara
            // 
            this.txtEdara.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdara.Location = new System.Drawing.Point(759, 672);
            this.txtEdara.Name = "txtEdara";
            this.txtEdara.Size = new System.Drawing.Size(363, 35);
            this.txtEdara.TabIndex = 116;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(759, 725);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(516, 57);
            this.btnSearch.TabIndex = 117;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ResultsCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1319, 794);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtEdara);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pcf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.drpRepo);
            this.Controls.Add(this.drpDates);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lobsDrp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tgneedDrp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stageDrp);
            this.Name = "ResultsCollection";
            this.Text = "خطاب مقابلة";
            this.Load += new System.EventHandler(this.ResultsCollection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExaminerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox lobsDrp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tgneedDrp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox stageDrp;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ExaminerBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox drpDates;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox drpRepo;
        private System.Windows.Forms.PictureBox pcf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEdara;
        private System.Windows.Forms.Button btnSearch;
    }
}