namespace AppSound
{
    partial class Tagneed
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
            this.DB_TagneedDataSet = new DB_TagneedDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.stageDrp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.qualiDrp = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.drpExams = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tgneedDrp = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDown = new System.Windows.Forms.Label();
            this.lblNoticed = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnNoticed = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MainTagneedTableAdapter = new DB_TagneedDataSetTableAdapters.MainTagneedTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MainTagneedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_TagneedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(965, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "المرحلة";
            // 
            // stageDrp
            // 
            this.stageDrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stageDrp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.stageDrp.FormattingEnabled = true;
            this.stageDrp.Location = new System.Drawing.Point(828, 59);
            this.stageDrp.Name = "stageDrp";
            this.stageDrp.Size = new System.Drawing.Size(198, 27);
            this.stageDrp.TabIndex = 36;
            this.stageDrp.SelectedIndexChanged += new System.EventHandler(this.stageDrp_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(731, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "المؤهل";
            // 
            // qualiDrp
            // 
            this.qualiDrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qualiDrp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.qualiDrp.FormattingEnabled = true;
            this.qualiDrp.Location = new System.Drawing.Point(595, 59);
            this.qualiDrp.Name = "qualiDrp";
            this.qualiDrp.Size = new System.Drawing.Size(198, 27);
            this.qualiDrp.TabIndex = 38;
            this.qualiDrp.SelectedIndexChanged += new System.EventHandler(this.qualiDrp_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(515, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 53;
            this.label6.Text = "الاختبار";
            // 
            // drpExams
            // 
            this.drpExams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpExams.Font = new System.Drawing.Font("Tahoma", 12F);
            this.drpExams.FormattingEnabled = true;
            this.drpExams.Location = new System.Drawing.Point(379, 59);
            this.drpExams.Name = "drpExams";
            this.drpExams.Size = new System.Drawing.Size(193, 27);
            this.drpExams.TabIndex = 52;
            this.drpExams.SelectedIndexChanged += new System.EventHandler(this.drpExams_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(1138, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 55;
            this.label4.Text = "منطقة التجنيد";
            // 
            // tgneedDrp
            // 
            this.tgneedDrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tgneedDrp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tgneedDrp.FormattingEnabled = true;
            this.tgneedDrp.Location = new System.Drawing.Point(1043, 59);
            this.tgneedDrp.Name = "tgneedDrp";
            this.tgneedDrp.Size = new System.Drawing.Size(198, 27);
            this.tgneedDrp.TabIndex = 54;
            this.tgneedDrp.SelectedIndexChanged += new System.EventHandler(this.tgneedDrp_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(677, 118);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(564, 327);
            this.dataGridView2.TabIndex = 58;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(677, 451);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(564, 207);
            this.dataGridView3.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(243, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 60;
            this.label3.Text = "عدد المقصرين";
            // 
            // lblDown
            // 
            this.lblDown.AutoSize = true;
            this.lblDown.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblDown.Location = new System.Drawing.Point(198, 32);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(18, 19);
            this.lblDown.TabIndex = 61;
            this.lblDown.Text = "0";
            // 
            // lblNoticed
            // 
            this.lblNoticed.AutoSize = true;
            this.lblNoticed.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblNoticed.Location = new System.Drawing.Point(198, 81);
            this.lblNoticed.Name = "lblNoticed";
            this.lblNoticed.Size = new System.Drawing.Size(18, 19);
            this.lblNoticed.TabIndex = 63;
            this.lblNoticed.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(233, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 19);
            this.label7.TabIndex = 62;
            this.label7.Text = "عدد الملحوظين";
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(93, 24);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 38);
            this.btnDown.TabIndex = 64;
            this.btnDown.Text = "عرض";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnNoticed
            // 
            this.btnNoticed.Location = new System.Drawing.Point(93, 73);
            this.btnNoticed.Name = "btnNoticed";
            this.btnNoticed.Size = new System.Drawing.Size(75, 38);
            this.btnNoticed.TabIndex = 65;
            this.btnNoticed.Text = "عرض";
            this.btnNoticed.UseVisualStyleBackColor = true;
            this.btnNoticed.Click += new System.EventHandler(this.btnNoticed_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(11, 73);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 38);
            this.btnAll.TabIndex = 66;
            this.btnAll.Text = "عرض الكل";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MainTagneedBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppSound.Reports.exm.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 117);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(635, 541);
            this.reportViewer1.TabIndex = 67;
            // 
            // MainTagneedTableAdapter
            // 
            this.MainTagneedTableAdapter.ClearBeforeFill = true;
            // 
            // Tagneed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 662);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnNoticed);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.lblNoticed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tgneedDrp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.drpExams);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.qualiDrp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stageDrp);
            this.Name = "Tagneed";
            this.Text = "Tagneed";
            this.Load += new System.EventHandler(this.Tagneed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainTagneedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_TagneedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox stageDrp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox qualiDrp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox drpExams;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tgneedDrp;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDown;
        private System.Windows.Forms.Label lblNoticed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnNoticed;
        private System.Windows.Forms.Button btnAll;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MainTagneedBindingSource;
        private DB_TagneedDataSet DB_TagneedDataSet;
        private DB_TagneedDataSetTableAdapters.MainTagneedTableAdapter MainTagneedTableAdapter;
    }
}