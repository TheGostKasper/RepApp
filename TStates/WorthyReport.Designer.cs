namespace AppSound.TStates
{
    partial class WorthyReport
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
            this.T_ExaminersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcf = new System.Windows.Forms.PictureBox();
            this.txtDest = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpnion = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.repType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsold = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.pcf);
            this.panel1.Controls.Add(this.txtDest);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtOpnion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.repType);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtsold);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1272, 813);
            this.panel1.TabIndex = 50;
            // 
            // pcf
            // 
            this.pcf.Image = global::AppSound.Properties.Resources._123;
            this.pcf.InitialImage = null;
            this.pcf.Location = new System.Drawing.Point(759, 11);
            this.pcf.Name = "pcf";
            this.pcf.Size = new System.Drawing.Size(502, 205);
            this.pcf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcf.TabIndex = 113;
            this.pcf.TabStop = false;
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(780, 335);
            this.txtDest.Name = "txtDest";
            this.txtDest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDest.Size = new System.Drawing.Size(292, 54);
            this.txtDest.TabIndex = 25;
            this.txtDest.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1138, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "صورة الي";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1047, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "رأي القائم بالمقابلة";
            // 
            // txtOpnion
            // 
            this.txtOpnion.Location = new System.Drawing.Point(780, 481);
            this.txtOpnion.Name = "txtOpnion";
            this.txtOpnion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOpnion.Size = new System.Drawing.Size(431, 182);
            this.txtOpnion.TabIndex = 21;
            this.txtOpnion.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1128, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "نوع الخطاب";
            // 
            // repType
            // 
            this.repType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.repType.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repType.FormattingEnabled = true;
            this.repType.Location = new System.Drawing.Point(780, 282);
            this.repType.Name = "repType";
            this.repType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.repType.Size = new System.Drawing.Size(292, 37);
            this.repType.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(780, 687);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(431, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ObsvTot";
            reportDataSource1.Value = this.T_ExaminersBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppSound.Reports.worthRep.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 11);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(747, 733);
            this.reportViewer1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1078, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "ادخل الرقم العسكري";
            // 
            // txtsold
            // 
            this.txtsold.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsold.Location = new System.Drawing.Point(780, 234);
            this.txtsold.MaxLength = 13;
            this.txtsold.Name = "txtsold";
            this.txtsold.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtsold.Size = new System.Drawing.Size(292, 35);
            this.txtsold.TabIndex = 2;
            this.txtsold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsold.Leave += new System.EventHandler(this.txtsold_Leave);
            // 
            // WorthyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 816);
            this.Controls.Add(this.panel1);
            this.Name = "WorthyReport";
            this.Text = "خطاب توصية";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsold;
        private System.Windows.Forms.BindingSource T_ExaminersBindingSource;
        private System.Windows.Forms.BindingSource TResultsBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox repType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtOpnion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtDest;
        private System.Windows.Forms.PictureBox pcf;

    }
}