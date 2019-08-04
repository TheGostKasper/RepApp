namespace AppSound
{
    partial class HospitalReport
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
            this.MainTagneedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DB_TagneedDataSet = new AppSound.DB_TagneedDataSet();
            this.MainTagneedTableAdapter = new AppSound.DB_TagneedDataSetTableAdapters.MainTagneedTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label5 = new System.Windows.Forms.Label();
            this.drpRepo = new System.Windows.Forms.ComboBox();
            this.pcf = new System.Windows.Forms.PictureBox();
            this.txtEdara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComplain = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoldId = new System.Windows.Forms.TextBox();
            this.T_ExaminersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ExaminerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainTagneedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_TagneedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_ExaminersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExaminerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.reportViewer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            reportDataSource1.Name = "ObsvTot";
            reportDataSource1.Value = this.T_ExaminersBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "AppSound.Reports.galalReport.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(4, 2);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(752, 757);
            this.reportViewer2.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1147, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 29);
            this.label5.TabIndex = 90;
            this.label5.Text = "نوع الخطاب";
            // 
            // drpRepo
            // 
            this.drpRepo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpRepo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpRepo.ForeColor = System.Drawing.Color.Black;
            this.drpRepo.FormattingEnabled = true;
            this.drpRepo.Location = new System.Drawing.Point(764, 446);
            this.drpRepo.Name = "drpRepo";
            this.drpRepo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.drpRepo.Size = new System.Drawing.Size(352, 37);
            this.drpRepo.TabIndex = 89;
            this.drpRepo.SelectedIndexChanged += new System.EventHandler(this.tgneedDrp_SelectedIndexChanged);
            this.drpRepo.SelectionChangeCommitted += new System.EventHandler(this.drpRepo_SelectionChangeCommitted);
            // 
            // pcf
            // 
            this.pcf.Image = global::AppSound.Properties.Resources._123;
            this.pcf.InitialImage = null;
            this.pcf.Location = new System.Drawing.Point(764, 2);
            this.pcf.Name = "pcf";
            this.pcf.Size = new System.Drawing.Size(493, 341);
            this.pcf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcf.TabIndex = 108;
            this.pcf.TabStop = false;
            // 
            // txtEdara
            // 
            this.txtEdara.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdara.Location = new System.Drawing.Point(764, 500);
            this.txtEdara.Name = "txtEdara";
            this.txtEdara.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEdara.Size = new System.Drawing.Size(352, 35);
            this.txtEdara.TabIndex = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1154, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 110;
            this.label2.Text = "اسم الادارة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1143, 558);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 29);
            this.label3.TabIndex = 112;
            this.label3.Text = "الشكوي الطبية";
            this.label3.Visible = false;
            // 
            // txtComplain
            // 
            this.txtComplain.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplain.Location = new System.Drawing.Point(764, 558);
            this.txtComplain.Name = "txtComplain";
            this.txtComplain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtComplain.Size = new System.Drawing.Size(352, 35);
            this.txtComplain.TabIndex = 111;
            this.txtComplain.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(764, 617);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(504, 55);
            this.button1.TabIndex = 113;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1136, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 115;
            this.label1.Text = "الرقم العسكري";
            // 
            // txtSoldId
            // 
            this.txtSoldId.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoldId.Location = new System.Drawing.Point(764, 382);
            this.txtSoldId.Name = "txtSoldId";
            this.txtSoldId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSoldId.Size = new System.Drawing.Size(352, 35);
            this.txtSoldId.TabIndex = 114;
            // 
            // T_ExaminersBindingSource
            // 
            this.T_ExaminersBindingSource.DataSource = typeof(AppSound.Modals.T_Examiners);
            // 
            // ExaminerBindingSource
            // 
            this.ExaminerBindingSource.DataSource = typeof(AppSound.Examiner);
            // 
            // ResultsBindingSource
            // 
            this.ResultsBindingSource.DataSource = typeof(AppSound.Results);
            // 
            // HospitalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1280, 760);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoldId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtComplain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEdara);
            this.Controls.Add(this.pcf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.drpRepo);
            this.Controls.Add(this.reportViewer2);
            this.Name = "HospitalReport";
            this.Text = "خطاب تحويل لمستشفي";
            this.Load += new System.EventHandler(this.StateReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainTagneedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_TagneedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_ExaminersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExaminerBindingSource)).EndInit();
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
        private System.Windows.Forms.PictureBox pcf;
        private System.Windows.Forms.BindingSource T_ExaminersBindingSource;
        private System.Windows.Forms.TextBox txtEdara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComplain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoldId;
    }
}