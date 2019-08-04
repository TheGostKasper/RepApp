namespace AppSound.TStates
{
    partial class StatisticalStates
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
            this.resultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExams = new System.Windows.Forms.Button();
            this.btnTotalExams = new System.Windows.Forms.Button();
            this.btnStates = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblTotalExams = new System.Windows.Forms.Label();
            this.dgvSTS = new System.Windows.Forms.DataGridView();
            this.lblExams = new System.Windows.Forms.Label();
            this.dgvExms = new System.Windows.Forms.DataGridView();
            this.lblStates = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stageDrp = new System.Windows.Forms.ComboBox();
            this.dgStatistically = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStatistically)).BeginInit();
            this.SuspendLayout();
            // 
            // resultsBindingSource
            // 
            this.resultsBindingSource.DataSource = typeof(AppSound.Results);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnExams);
            this.panel1.Controls.Add(this.btnTotalExams);
            this.panel1.Controls.Add(this.btnStates);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Controls.Add(this.lblTotalExams);
            this.panel1.Controls.Add(this.dgvSTS);
            this.panel1.Controls.Add(this.lblExams);
            this.panel1.Controls.Add(this.dgvExms);
            this.panel1.Controls.Add(this.lblStates);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.stageDrp);
            this.panel1.Controls.Add(this.dgStatistically);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1596, 851);
            this.panel1.TabIndex = 0;
            // 
            // btnExams
            // 
            this.btnExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExams.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExams.ForeColor = System.Drawing.Color.Yellow;
            this.btnExams.Location = new System.Drawing.Point(229, 79);
            this.btnExams.Name = "btnExams";
            this.btnExams.Size = new System.Drawing.Size(162, 50);
            this.btnExams.TabIndex = 104;
            this.btnExams.Text = "عرض الاختبارات";
            this.btnExams.UseVisualStyleBackColor = false;
            this.btnExams.Click += new System.EventHandler(this.btnExams_Click);
            // 
            // btnTotalExams
            // 
            this.btnTotalExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTotalExams.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalExams.ForeColor = System.Drawing.Color.Yellow;
            this.btnTotalExams.Location = new System.Drawing.Point(15, 79);
            this.btnTotalExams.Name = "btnTotalExams";
            this.btnTotalExams.Size = new System.Drawing.Size(162, 50);
            this.btnTotalExams.TabIndex = 103;
            this.btnTotalExams.Text = "عرض الاجمالي";
            this.btnTotalExams.UseVisualStyleBackColor = false;
            this.btnTotalExams.Click += new System.EventHandler(this.btnTotalExams_Click);
            // 
            // btnStates
            // 
            this.btnStates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStates.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStates.ForeColor = System.Drawing.Color.Yellow;
            this.btnStates.Location = new System.Drawing.Point(458, 79);
            this.btnStates.Name = "btnStates";
            this.btnStates.Size = new System.Drawing.Size(162, 50);
            this.btnStates.TabIndex = 101;
            this.btnStates.Text = "عرض المراكز";
            this.btnStates.UseVisualStyleBackColor = false;
            this.btnStates.Click += new System.EventHandler(this.button2_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "RSTS";
            reportDataSource1.Value = this.resultsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppSound.Reports.STSEXM.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(15, 157);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(605, 637);
            this.reportViewer1.TabIndex = 99;
            // 
            // lblTotalExams
            // 
            this.lblTotalExams.AutoSize = true;
            this.lblTotalExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalExams.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalExams.ForeColor = System.Drawing.Color.Yellow;
            this.lblTotalExams.Location = new System.Drawing.Point(669, 463);
            this.lblTotalExams.Name = "lblTotalExams";
            this.lblTotalExams.Size = new System.Drawing.Size(398, 22);
            this.lblTotalExams.TabIndex = 98;
            this.lblTotalExams.Text = "احصائية عددية للاختبارات(الاجمالي - المقصرين -  الملحوظين )";
            // 
            // dgvSTS
            // 
            this.dgvSTS.AllowUserToAddRows = false;
            this.dgvSTS.AllowUserToDeleteRows = false;
            this.dgvSTS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSTS.Location = new System.Drawing.Point(642, 501);
            this.dgvSTS.MultiSelect = false;
            this.dgvSTS.Name = "dgvSTS";
            this.dgvSTS.ReadOnly = true;
            this.dgvSTS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSTS.Size = new System.Drawing.Size(452, 293);
            this.dgvSTS.TabIndex = 97;
            // 
            // lblExams
            // 
            this.lblExams.AutoSize = true;
            this.lblExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblExams.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExams.ForeColor = System.Drawing.Color.Yellow;
            this.lblExams.Location = new System.Drawing.Point(657, 107);
            this.lblExams.Name = "lblExams";
            this.lblExams.Size = new System.Drawing.Size(422, 22);
            this.lblExams.TabIndex = 96;
            this.lblExams.Text = "اجمالي اختبارات مركز التدريب(الاجمالي - المقصرين -  الملحوظين )";
            // 
            // dgvExms
            // 
            this.dgvExms.AllowUserToAddRows = false;
            this.dgvExms.AllowUserToDeleteRows = false;
            this.dgvExms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExms.Location = new System.Drawing.Point(642, 157);
            this.dgvExms.MultiSelect = false;
            this.dgvExms.Name = "dgvExms";
            this.dgvExms.ReadOnly = true;
            this.dgvExms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExms.Size = new System.Drawing.Size(452, 282);
            this.dgvExms.TabIndex = 95;
            // 
            // lblStates
            // 
            this.lblStates.AutoSize = true;
            this.lblStates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStates.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStates.ForeColor = System.Drawing.Color.Yellow;
            this.lblStates.Location = new System.Drawing.Point(1128, 107);
            this.lblStates.Name = "lblStates";
            this.lblStates.Size = new System.Drawing.Size(430, 22);
            this.lblStates.TabIndex = 94;
            this.lblStates.Text = "احصائية عددية لمراكز التدريب (الاجمالي - المقصرين -  الملحوظين )";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(979, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 91;
            this.label1.Text = "المرحلة";
            // 
            // stageDrp
            // 
            this.stageDrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stageDrp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.stageDrp.FormattingEnabled = true;
            this.stageDrp.Location = new System.Drawing.Point(702, 37);
            this.stageDrp.Name = "stageDrp";
            this.stageDrp.Size = new System.Drawing.Size(253, 27);
            this.stageDrp.TabIndex = 90;
            this.stageDrp.SelectedIndexChanged += new System.EventHandler(this.stageDrp_SelectedIndexChanged);
            // 
            // dgStatistically
            // 
            this.dgStatistically.AllowUserToAddRows = false;
            this.dgStatistically.AllowUserToDeleteRows = false;
            this.dgStatistically.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgStatistically.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStatistically.Location = new System.Drawing.Point(1105, 157);
            this.dgStatistically.MultiSelect = false;
            this.dgStatistically.Name = "dgStatistically";
            this.dgStatistically.ReadOnly = true;
            this.dgStatistically.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgStatistically.Size = new System.Drawing.Size(477, 637);
            this.dgStatistically.TabIndex = 0;
            this.dgStatistically.SelectionChanged += new System.EventHandler(this.dgStatistically_SelectionChanged);
            // 
            // StatisticalStates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1598, 851);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "StatisticalStates";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "احصائيات مراكز التدريب";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StatisticalStates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStatistically)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgStatistically;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox stageDrp;
        private System.Windows.Forms.Label lblStates;
        private System.Windows.Forms.Label lblExams;
        private System.Windows.Forms.DataGridView dgvExms;
        private System.Windows.Forms.Label lblTotalExams;
        private System.Windows.Forms.DataGridView dgvSTS;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource resultsBindingSource;
        private System.Windows.Forms.Button btnExams;
        private System.Windows.Forms.Button btnTotalExams;
        private System.Windows.Forms.Button btnStates;
    }
}