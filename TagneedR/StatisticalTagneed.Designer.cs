namespace AppSound.TStates
{
    partial class StatisticalTagneed
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
            this.lblNo = new System.Windows.Forms.Label();
            this.btnTGd = new System.Windows.Forms.Button();
            this.btnQufExms = new System.Windows.Forms.Button();
            this.btnMFM = new System.Windows.Forms.Button();
            this.btnQual = new System.Windows.Forms.Button();
            this.btnExams = new System.Windows.Forms.Button();
            this.btnTotalExams = new System.Windows.Forms.Button();
            this.btnStates = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblTotalExams = new System.Windows.Forms.Label();
            this.lblExams = new System.Windows.Forms.Label();
            this.dgvExms = new System.Windows.Forms.DataGridView();
            this.lblStates = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stageDrp = new System.Windows.Forms.ComboBox();
            this.dgStatistically = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblNo);
            this.panel1.Controls.Add(this.btnTGd);
            this.panel1.Controls.Add(this.btnQufExms);
            this.panel1.Controls.Add(this.btnMFM);
            this.panel1.Controls.Add(this.btnQual);
            this.panel1.Controls.Add(this.btnExams);
            this.panel1.Controls.Add(this.btnTotalExams);
            this.panel1.Controls.Add(this.btnStates);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Controls.Add(this.lblTotalExams);
            this.panel1.Controls.Add(this.lblExams);
            this.panel1.Controls.Add(this.dgvExms);
            this.panel1.Controls.Add(this.lblStates);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.stageDrp);
            this.panel1.Controls.Add(this.dgStatistically);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1469, 851);
            this.panel1.TabIndex = 0;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.ForeColor = System.Drawing.Color.Yellow;
            this.lblNo.Location = new System.Drawing.Point(253, 793);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(21, 24);
            this.lblNo.TabIndex = 111;
            this.lblNo.Text = "1";
            // 
            // btnTGd
            // 
            this.btnTGd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTGd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTGd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTGd.ForeColor = System.Drawing.Color.Yellow;
            this.btnTGd.Location = new System.Drawing.Point(631, 700);
            this.btnTGd.Name = "btnTGd";
            this.btnTGd.Size = new System.Drawing.Size(239, 50);
            this.btnTGd.TabIndex = 110;
            this.btnTGd.Text = "7- الملحوظين بالاختبارات النظرية - مناطق";
            this.btnTGd.UseVisualStyleBackColor = false;
            this.btnTGd.Click += new System.EventHandler(this.btnTGd_Click);
            // 
            // btnQufExms
            // 
            this.btnQufExms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQufExms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnQufExms.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQufExms.ForeColor = System.Drawing.Color.Yellow;
            this.btnQufExms.Location = new System.Drawing.Point(631, 638);
            this.btnQufExms.Name = "btnQufExms";
            this.btnQufExms.Size = new System.Drawing.Size(239, 50);
            this.btnQufExms.TabIndex = 109;
            this.btnQufExms.Text = "6- الملحوظين بالاختبارات النظرية - فئات ";
            this.btnQufExms.UseVisualStyleBackColor = false;
            this.btnQufExms.Click += new System.EventHandler(this.btnQufExms_Click);
            // 
            // btnMFM
            // 
            this.btnMFM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMFM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMFM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMFM.ForeColor = System.Drawing.Color.Yellow;
            this.btnMFM.Location = new System.Drawing.Point(631, 562);
            this.btnMFM.Name = "btnMFM";
            this.btnMFM.Size = new System.Drawing.Size(239, 50);
            this.btnMFM.TabIndex = 108;
            this.btnMFM.Text = "5- اجمالي الفئات";
            this.btnMFM.UseVisualStyleBackColor = false;
            this.btnMFM.Click += new System.EventHandler(this.btnMFM_Click);
            // 
            // btnQual
            // 
            this.btnQual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnQual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQual.ForeColor = System.Drawing.Color.Yellow;
            this.btnQual.Location = new System.Drawing.Point(631, 305);
            this.btnQual.Name = "btnQual";
            this.btnQual.Size = new System.Drawing.Size(239, 50);
            this.btnQual.TabIndex = 107;
            this.btnQual.Text = "2-  اجمالي الفئات بمناطق التجنيد";
            this.btnQual.UseVisualStyleBackColor = false;
            this.btnQual.Click += new System.EventHandler(this.btnQual_Click);
            // 
            // btnExams
            // 
            this.btnExams.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExams.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExams.ForeColor = System.Drawing.Color.Yellow;
            this.btnExams.Location = new System.Drawing.Point(631, 392);
            this.btnExams.Name = "btnExams";
            this.btnExams.Size = new System.Drawing.Size(239, 50);
            this.btnExams.TabIndex = 104;
            this.btnExams.Text = "3-  اختبارات منطقة";
            this.btnExams.UseVisualStyleBackColor = false;
            this.btnExams.Click += new System.EventHandler(this.btnExams_Click);
            // 
            // btnTotalExams
            // 
            this.btnTotalExams.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTotalExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTotalExams.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalExams.ForeColor = System.Drawing.Color.Yellow;
            this.btnTotalExams.Location = new System.Drawing.Point(631, 479);
            this.btnTotalExams.Name = "btnTotalExams";
            this.btnTotalExams.Size = new System.Drawing.Size(239, 50);
            this.btnTotalExams.TabIndex = 103;
            this.btnTotalExams.Text = "4- اختبارات جميع مناطق التجنيد";
            this.btnTotalExams.UseVisualStyleBackColor = false;
            this.btnTotalExams.Click += new System.EventHandler(this.btnTotalExams_Click);
            // 
            // btnStates
            // 
            this.btnStates.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStates.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStates.ForeColor = System.Drawing.Color.Yellow;
            this.btnStates.Location = new System.Drawing.Point(631, 222);
            this.btnStates.Name = "btnStates";
            this.btnStates.Size = new System.Drawing.Size(239, 50);
            this.btnStates.TabIndex = 101;
            this.btnStates.Text = "1- اجمالي المناطق لجميع الفئات ";
            this.btnStates.UseVisualStyleBackColor = false;
            this.btnStates.Click += new System.EventHandler(this.button2_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            reportDataSource1.Name = "RSTS";
            reportDataSource1.Value = this.resultsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppSound.Reports.STSEXM.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(8, 128);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(598, 637);
            this.reportViewer1.TabIndex = 99;
            // 
            // lblTotalExams
            // 
            this.lblTotalExams.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalExams.AutoSize = true;
            this.lblTotalExams.BackColor = System.Drawing.Color.Black;
            this.lblTotalExams.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalExams.ForeColor = System.Drawing.Color.Yellow;
            this.lblTotalExams.Location = new System.Drawing.Point(649, 28);
            this.lblTotalExams.Name = "lblTotalExams";
            this.lblTotalExams.Size = new System.Drawing.Size(170, 22);
            this.lblTotalExams.TabIndex = 98;
            this.lblTotalExams.Text = "احصائية عددية للاختبارات";
            // 
            // lblExams
            // 
            this.lblExams.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExams.AutoSize = true;
            this.lblExams.BackColor = System.Drawing.Color.Black;
            this.lblExams.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExams.ForeColor = System.Drawing.Color.Yellow;
            this.lblExams.Location = new System.Drawing.Point(1054, 433);
            this.lblExams.Name = "lblExams";
            this.lblExams.Size = new System.Drawing.Size(197, 22);
            this.lblExams.TabIndex = 96;
            this.lblExams.Text = "اجمالي اختبارات مناطق التجنيد";
            // 
            // dgvExms
            // 
            this.dgvExms.AllowUserToAddRows = false;
            this.dgvExms.AllowUserToDeleteRows = false;
            this.dgvExms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvExms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExms.Location = new System.Drawing.Point(908, 458);
            this.dgvExms.MultiSelect = false;
            this.dgvExms.Name = "dgvExms";
            this.dgvExms.ReadOnly = true;
            this.dgvExms.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvExms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExms.Size = new System.Drawing.Size(505, 292);
            this.dgvExms.TabIndex = 95;
            // 
            // lblStates
            // 
            this.lblStates.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStates.AutoSize = true;
            this.lblStates.BackColor = System.Drawing.Color.Black;
            this.lblStates.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStates.ForeColor = System.Drawing.Color.Yellow;
            this.lblStates.Location = new System.Drawing.Point(1022, 78);
            this.lblStates.Name = "lblStates";
            this.lblStates.Size = new System.Drawing.Size(277, 22);
            this.lblStates.TabIndex = 94;
            this.lblStates.Text = "احصائية عددية لمناطق التجنيد لجميع الفئات";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(797, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 91;
            this.label1.Text = "المرحلة";
            // 
            // stageDrp
            // 
            this.stageDrp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stageDrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stageDrp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.stageDrp.FormattingEnabled = true;
            this.stageDrp.Location = new System.Drawing.Point(624, 167);
            this.stageDrp.Name = "stageDrp";
            this.stageDrp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.stageDrp.Size = new System.Drawing.Size(246, 27);
            this.stageDrp.TabIndex = 90;
            this.stageDrp.SelectedIndexChanged += new System.EventHandler(this.stageDrp_SelectedIndexChanged);
            // 
            // dgStatistically
            // 
            this.dgStatistically.AllowUserToAddRows = false;
            this.dgStatistically.AllowUserToDeleteRows = false;
            this.dgStatistically.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgStatistically.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgStatistically.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStatistically.Location = new System.Drawing.Point(908, 128);
            this.dgStatistically.MultiSelect = false;
            this.dgStatistically.Name = "dgStatistically";
            this.dgStatistically.ReadOnly = true;
            this.dgStatistically.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgStatistically.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgStatistically.Size = new System.Drawing.Size(505, 292);
            this.dgStatistically.TabIndex = 0;
            this.dgStatistically.SelectionChanged += new System.EventHandler(this.dgStatistically_SelectionChanged);
            // 
            // StatisticalTagneed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1469, 851);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "StatisticalTagneed";
            this.RightToLeftLayout = true;
            this.Text = "احصائيات مراكز التدريب";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StatisticalStates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource resultsBindingSource;
        private System.Windows.Forms.Button btnExams;
        private System.Windows.Forms.Button btnTotalExams;
        private System.Windows.Forms.Button btnStates;
        private System.Windows.Forms.Button btnQual;
        private System.Windows.Forms.Button btnMFM;
        private System.Windows.Forms.Button btnQufExms;
        private System.Windows.Forms.Button btnTGd;
        private System.Windows.Forms.Label lblNo;
    }
}