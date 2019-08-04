namespace AppSound.TStates
{
    partial class CompareResuls
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.T_ExaminersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcf = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtsold = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.T_ExaminersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TResultsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcf)).BeginInit();
            this.SuspendLayout();
            // 
            // T_ExaminersBindingSource
            // 
            this.T_ExaminersBindingSource.DataSource = typeof(AppSound.Modals.T_Examiners);
            // 
            // TResultsBindingSource
            // 
            this.TResultsBindingSource.DataSource = typeof(AppSound.Modals.TResults);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtsold);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pcf);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 857);
            this.panel1.TabIndex = 1;
            // 
            // pcf
            // 
            this.pcf.Image = global::AppSound.Properties.Resources._123;
            this.pcf.InitialImage = null;
            this.pcf.Location = new System.Drawing.Point(792, 7);
            this.pcf.Name = "pcf";
            this.pcf.Size = new System.Drawing.Size(512, 364);
            this.pcf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcf.TabIndex = 102;
            this.pcf.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            reportDataSource7.Name = "BasicInfo";
            reportDataSource7.Value = this.T_ExaminersBindingSource;
            reportDataSource8.Name = "stateResults";
            reportDataSource8.Value = this.TResultsBindingSource;
            reportDataSource9.Name = "InstituteResults";
            reportDataSource9.Value = this.TResultsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppSound.Reports.compare_rs.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(772, 844);
            this.reportViewer1.TabIndex = 18;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Maroon;
            this.btnSearch.Location = new System.Drawing.Point(792, 478);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(512, 53);
            this.btnSearch.TabIndex = 104;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtsold
            // 
            this.txtsold.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsold.Location = new System.Drawing.Point(792, 409);
            this.txtsold.MaxLength = 13;
            this.txtsold.Name = "txtsold";
            this.txtsold.Size = new System.Drawing.Size(309, 35);
            this.txtsold.TabIndex = 103;
            this.txtsold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1134, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 105;
            this.label1.Text = "ادخل الرقم العسكري";
            // 
            // CompareResuls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1317, 858);
            this.Controls.Add(this.panel1);
            this.Name = "CompareResuls";
            this.Text = "مقارنة نتائج الاختبارات";
            this.Load += new System.EventHandler(this.CompareResuls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.T_ExaminersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TResultsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource T_ExaminersBindingSource;
        private System.Windows.Forms.BindingSource TResultsBindingSource;
        private System.Windows.Forms.PictureBox pcf;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtsold;
        private System.Windows.Forms.Label label1;

    }
}