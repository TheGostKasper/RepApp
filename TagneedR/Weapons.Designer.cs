namespace AppSound.TagneedR
{
    partial class Weapons
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tgtank = new System.Windows.Forms.Button();
            this.tgwalkers = new System.Windows.Forms.Button();
            this.tgarti = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.drpQualification = new System.Windows.Forms.ComboBox();
            this.btntanks = new System.Windows.Forms.Button();
            this.btnWalkers = new System.Windows.Forms.Button();
            this.btnForce = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label5 = new System.Windows.Forms.Label();
            this.stageDrp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pcf = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcf)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pcf);
            this.panel1.Controls.Add(this.tgtank);
            this.panel1.Controls.Add(this.tgwalkers);
            this.panel1.Controls.Add(this.tgarti);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.drpQualification);
            this.panel1.Controls.Add(this.btntanks);
            this.panel1.Controls.Add(this.btnWalkers);
            this.panel1.Controls.Add(this.btnForce);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.stageDrp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1338, 837);
            this.panel1.TabIndex = 0;
            // 
            // tgtank
            // 
            this.tgtank.BackColor = System.Drawing.Color.Moccasin;
            this.tgtank.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgtank.ForeColor = System.Drawing.Color.Black;
            this.tgtank.Location = new System.Drawing.Point(793, 707);
            this.tgtank.Name = "tgtank";
            this.tgtank.Size = new System.Drawing.Size(223, 47);
            this.tgtank.TabIndex = 91;
            this.tgtank.Text = "تقرير المدفعية بمناطق التجنيد";
            this.tgtank.UseVisualStyleBackColor = false;
            this.tgtank.Click += new System.EventHandler(this.tgtank_Click);
            // 
            // tgwalkers
            // 
            this.tgwalkers.BackColor = System.Drawing.Color.Moccasin;
            this.tgwalkers.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgwalkers.ForeColor = System.Drawing.Color.Black;
            this.tgwalkers.Location = new System.Drawing.Point(793, 564);
            this.tgwalkers.Name = "tgwalkers";
            this.tgwalkers.Size = new System.Drawing.Size(223, 47);
            this.tgwalkers.TabIndex = 90;
            this.tgwalkers.Text = "تقرير المشاة بمناطق التجنيد";
            this.tgwalkers.UseVisualStyleBackColor = false;
            this.tgwalkers.Click += new System.EventHandler(this.tgwalkers_Click);
            // 
            // tgarti
            // 
            this.tgarti.BackColor = System.Drawing.Color.Moccasin;
            this.tgarti.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgarti.ForeColor = System.Drawing.Color.Black;
            this.tgarti.Location = new System.Drawing.Point(793, 634);
            this.tgarti.Name = "tgarti";
            this.tgarti.Size = new System.Drawing.Size(223, 47);
            this.tgarti.TabIndex = 89;
            this.tgarti.Text = "تقرير المدرعات بمناطق التجنيد";
            this.tgarti.UseVisualStyleBackColor = false;
            this.tgarti.Click += new System.EventHandler(this.tgarti_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(1232, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 29);
            this.label6.TabIndex = 85;
            this.label6.Text = "المؤهل";
            // 
            // drpQualification
            // 
            this.drpQualification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpQualification.Font = new System.Drawing.Font("Tahoma", 12F);
            this.drpQualification.FormattingEnabled = true;
            this.drpQualification.Location = new System.Drawing.Point(793, 426);
            this.drpQualification.Name = "drpQualification";
            this.drpQualification.Size = new System.Drawing.Size(414, 27);
            this.drpQualification.TabIndex = 84;
            this.drpQualification.SelectedIndexChanged += new System.EventHandler(this.drpQualification_SelectedIndexChanged);
            // 
            // btntanks
            // 
            this.btntanks.BackColor = System.Drawing.Color.LightPink;
            this.btntanks.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntanks.ForeColor = System.Drawing.Color.Black;
            this.btntanks.Location = new System.Drawing.Point(1044, 709);
            this.btntanks.Name = "btntanks";
            this.btntanks.Size = new System.Drawing.Size(223, 47);
            this.btntanks.TabIndex = 83;
            this.btntanks.Text = "بيان المدفعية بالاسماء";
            this.btntanks.UseVisualStyleBackColor = false;
            this.btntanks.Click += new System.EventHandler(this.btntanks_Click);
            // 
            // btnWalkers
            // 
            this.btnWalkers.BackColor = System.Drawing.Color.LightPink;
            this.btnWalkers.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWalkers.ForeColor = System.Drawing.Color.Black;
            this.btnWalkers.Location = new System.Drawing.Point(1044, 564);
            this.btnWalkers.Name = "btnWalkers";
            this.btnWalkers.Size = new System.Drawing.Size(223, 47);
            this.btnWalkers.TabIndex = 82;
            this.btnWalkers.Text = "بيان المشاة بالاسماء";
            this.btnWalkers.UseVisualStyleBackColor = false;
            this.btnWalkers.Click += new System.EventHandler(this.btnWalkers_Click);
            // 
            // btnForce
            // 
            this.btnForce.BackColor = System.Drawing.Color.LightPink;
            this.btnForce.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForce.ForeColor = System.Drawing.Color.Black;
            this.btnForce.Location = new System.Drawing.Point(1044, 634);
            this.btnForce.Name = "btnForce";
            this.btnForce.Size = new System.Drawing.Size(223, 47);
            this.btnForce.TabIndex = 81;
            this.btnForce.Text = "بيان المدرعات بالاسماء";
            this.btnForce.UseVisualStyleBackColor = false;
            this.btnForce.Click += new System.EventHandler(this.btnForce_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppSound.Reports.TagneedReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(761, 837);
            this.reportViewer1.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(1229, 481);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 29);
            this.label5.TabIndex = 72;
            this.label5.Text = "المرحلة";
            // 
            // stageDrp
            // 
            this.stageDrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stageDrp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.stageDrp.FormattingEnabled = true;
            this.stageDrp.Location = new System.Drawing.Point(793, 481);
            this.stageDrp.Name = "stageDrp";
            this.stageDrp.Size = new System.Drawing.Size(414, 27);
            this.stageDrp.TabIndex = 71;
            this.stageDrp.SelectedIndexChanged += new System.EventHandler(this.drpQualification_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(850, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "بيان بأسماء المرشحين لكل سلاح حسب الاختبارات المحددة لكل منها";
            // 
            // pcf
            // 
            this.pcf.Image = global::AppSound.Properties.Resources._123;
            this.pcf.InitialImage = null;
            this.pcf.Location = new System.Drawing.Point(793, 43);
            this.pcf.Name = "pcf";
            this.pcf.Size = new System.Drawing.Size(512, 364);
            this.pcf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcf.TabIndex = 104;
            this.pcf.TabStop = false;
            // 
            // Weapons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1339, 839);
            this.Controls.Add(this.panel1);
            this.Name = "Weapons";
            this.Text = "Weapons";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Weapons_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox stageDrp;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btntanks;
        private System.Windows.Forms.Button btnWalkers;
        private System.Windows.Forms.Button btnForce;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox drpQualification;
        private System.Windows.Forms.Button tgtank;
        private System.Windows.Forms.Button tgwalkers;
        private System.Windows.Forms.Button tgarti;
        private System.Windows.Forms.PictureBox pcf;
    }
}