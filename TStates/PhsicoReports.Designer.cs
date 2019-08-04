namespace AppSound
{
    partial class PhsicoReports
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
            this.PhsycoRepoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MainTagneedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DB_TagneedDataSet = new AppSound.DB_TagneedDataSet();
            this.MainTagneedTableAdapter = new AppSound.DB_TagneedDataSetTableAdapters.MainTagneedTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label4 = new System.Windows.Forms.Label();
            this.tgneedDrp = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.stageDrp = new System.Windows.Forms.ComboBox();
            this.btnAllStg = new System.Windows.Forms.Button();
            this.ExaminerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pcf = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PhsycoRepoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTagneedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_TagneedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExaminerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcf)).BeginInit();
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
            reportDataSource1.Name = "Phsy";
            reportDataSource1.Value = this.PhsycoRepoBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "AppSound.Reports.phsyco.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 2);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(756, 855);
            this.reportViewer2.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1137, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 84;
            this.label4.Text = "مركز التدريب";
            // 
            // tgneedDrp
            // 
            this.tgneedDrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tgneedDrp.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgneedDrp.ForeColor = System.Drawing.Color.Black;
            this.tgneedDrp.FormattingEnabled = true;
            this.tgneedDrp.Location = new System.Drawing.Point(767, 420);
            this.tgneedDrp.Name = "tgneedDrp";
            this.tgneedDrp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tgneedDrp.Size = new System.Drawing.Size(333, 30);
            this.tgneedDrp.TabIndex = 83;
            this.tgneedDrp.SelectedIndexChanged += new System.EventHandler(this.tgneedDrp_SelectedIndexChanged);
            this.tgneedDrp.SelectionChangeCommitted += new System.EventHandler(this.tgneedDrp_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1165, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 29);
            this.label6.TabIndex = 82;
            this.label6.Text = "المرحلة";
            // 
            // stageDrp
            // 
            this.stageDrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stageDrp.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stageDrp.ForeColor = System.Drawing.Color.Black;
            this.stageDrp.FormattingEnabled = true;
            this.stageDrp.Location = new System.Drawing.Point(767, 496);
            this.stageDrp.Name = "stageDrp";
            this.stageDrp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.stageDrp.Size = new System.Drawing.Size(333, 30);
            this.stageDrp.TabIndex = 81;
            this.stageDrp.SelectedIndexChanged += new System.EventHandler(this.tgneedDrp_SelectedIndexChanged);
            this.stageDrp.SelectionChangeCommitted += new System.EventHandler(this.tgneedDrp_SelectionChangeCommitted);
            // 
            // btnAllStg
            // 
            this.btnAllStg.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAllStg.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllStg.ForeColor = System.Drawing.Color.Maroon;
            this.btnAllStg.Location = new System.Drawing.Point(767, 580);
            this.btnAllStg.Name = "btnAllStg";
            this.btnAllStg.Size = new System.Drawing.Size(496, 53);
            this.btnAllStg.TabIndex = 85;
            this.btnAllStg.Text = "عرض كل المراكز";
            this.btnAllStg.UseVisualStyleBackColor = false;
            this.btnAllStg.Click += new System.EventHandler(this.btnAllStg_Click);
            // 
            // pcf
            // 
            this.pcf.Image = global::AppSound.Properties.Resources._123;
            this.pcf.InitialImage = null;
            this.pcf.Location = new System.Drawing.Point(767, 6);
            this.pcf.Name = "pcf";
            this.pcf.Size = new System.Drawing.Size(496, 373);
            this.pcf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcf.TabIndex = 112;
            this.pcf.TabStop = false;
            // 
            // PhsicoReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1275, 869);
            this.Controls.Add(this.pcf);
            this.Controls.Add(this.btnAllStg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tgneedDrp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stageDrp);
            this.Controls.Add(this.reportViewer2);
            this.Name = "PhsicoReports";
            this.Text = "احصائية المقابلة الشخصية  بمراكز التدريب";
            this.Load += new System.EventHandler(this.StateReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PhsycoRepoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTagneedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_TagneedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExaminerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcf)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tgneedDrp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox stageDrp;
        private System.Windows.Forms.Button btnAllStg;
        private System.Windows.Forms.BindingSource PhsycoRepoBindingSource;
        private System.Windows.Forms.PictureBox pcf;
    }
}