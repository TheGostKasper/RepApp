namespace AppSound.TagneedR
{
    partial class Evaluation
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
            this.label3 = new System.Windows.Forms.Label();
            this.drpQualification = new System.Windows.Forms.ComboBox();
            this.btnHight = new System.Windows.Forms.Button();
            this.btnForce = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblhight = new System.Windows.Forms.Label();
            this.lblforce = new System.Windows.Forms.Label();
            this.dgvModr3at = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stageDrp = new System.Windows.Forms.ComboBox();
            this.dgvWalkers = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModr3at)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWalkers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.drpQualification);
            this.panel1.Controls.Add(this.btnHight);
            this.panel1.Controls.Add(this.btnForce);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Controls.Add(this.lblhight);
            this.panel1.Controls.Add(this.lblforce);
            this.panel1.Controls.Add(this.dgvModr3at);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.stageDrp);
            this.panel1.Controls.Add(this.dgvWalkers);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1635, 815);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(777, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 29);
            this.label3.TabIndex = 82;
            this.label3.Text = "المؤهل";
            // 
            // drpQualification
            // 
            this.drpQualification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpQualification.Font = new System.Drawing.Font("Tahoma", 12F);
            this.drpQualification.FormattingEnabled = true;
            this.drpQualification.Location = new System.Drawing.Point(532, 68);
            this.drpQualification.Name = "drpQualification";
            this.drpQualification.Size = new System.Drawing.Size(223, 27);
            this.drpQualification.TabIndex = 81;
            this.drpQualification.SelectedIndexChanged += new System.EventHandler(this.stageDrp_SelectedIndexChanged_1);
            // 
            // btnHight
            // 
            this.btnHight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHight.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHight.ForeColor = System.Drawing.Color.Yellow;
            this.btnHight.Location = new System.Drawing.Point(706, 206);
            this.btnHight.Name = "btnHight";
            this.btnHight.Size = new System.Drawing.Size(157, 47);
            this.btnHight.TabIndex = 80;
            this.btnHight.Text = "تقرير الاطوال";
            this.btnHight.UseVisualStyleBackColor = false;
            this.btnHight.Click += new System.EventHandler(this.btnHight_Click);
            // 
            // btnForce
            // 
            this.btnForce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnForce.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForce.ForeColor = System.Drawing.Color.Yellow;
            this.btnForce.Location = new System.Drawing.Point(532, 206);
            this.btnForce.Name = "btnForce";
            this.btnForce.Size = new System.Drawing.Size(157, 47);
            this.btnForce.TabIndex = 79;
            this.btnForce.Text = "تقرير القدرات البدنية";
            this.btnForce.UseVisualStyleBackColor = false;
            this.btnForce.Click += new System.EventHandler(this.btnForce_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppSound.Reports.TagneedReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(889, 53);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(719, 750);
            this.reportViewer1.TabIndex = 78;
            // 
            // lblhight
            // 
            this.lblhight.AutoSize = true;
            this.lblhight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblhight.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhight.ForeColor = System.Drawing.Color.Yellow;
            this.lblhight.Location = new System.Drawing.Point(118, 15);
            this.lblhight.Name = "lblhight";
            this.lblhight.Size = new System.Drawing.Size(21, 22);
            this.lblhight.TabIndex = 77;
            this.lblhight.Text = "0";
            // 
            // lblforce
            // 
            this.lblforce.AutoSize = true;
            this.lblforce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblforce.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforce.ForeColor = System.Drawing.Color.Yellow;
            this.lblforce.Location = new System.Drawing.Point(118, 400);
            this.lblforce.Name = "lblforce";
            this.lblforce.Size = new System.Drawing.Size(21, 22);
            this.lblforce.TabIndex = 76;
            this.lblforce.Text = "0";
            // 
            // dgvModr3at
            // 
            this.dgvModr3at.AllowUserToAddRows = false;
            this.dgvModr3at.AllowUserToDeleteRows = false;
            this.dgvModr3at.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModr3at.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModr3at.Location = new System.Drawing.Point(28, 53);
            this.dgvModr3at.Name = "dgvModr3at";
            this.dgvModr3at.ReadOnly = true;
            this.dgvModr3at.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModr3at.Size = new System.Drawing.Size(490, 325);
            this.dgvModr3at.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(171, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 22);
            this.label4.TabIndex = 74;
            this.label4.Text = "ترتيب حسب الاطوال";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(776, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 29);
            this.label5.TabIndex = 72;
            this.label5.Text = "المرحلة";
            // 
            // stageDrp
            // 
            this.stageDrp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stageDrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stageDrp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.stageDrp.FormattingEnabled = true;
            this.stageDrp.Location = new System.Drawing.Point(532, 129);
            this.stageDrp.Name = "stageDrp";
            this.stageDrp.Size = new System.Drawing.Size(223, 27);
            this.stageDrp.TabIndex = 71;
            this.stageDrp.SelectedIndexChanged += new System.EventHandler(this.stageDrp_SelectedIndexChanged_1);
            // 
            // dgvWalkers
            // 
            this.dgvWalkers.AllowUserToAddRows = false;
            this.dgvWalkers.AllowUserToDeleteRows = false;
            this.dgvWalkers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWalkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWalkers.Location = new System.Drawing.Point(28, 443);
            this.dgvWalkers.Name = "dgvWalkers";
            this.dgvWalkers.ReadOnly = true;
            this.dgvWalkers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWalkers.Size = new System.Drawing.Size(490, 360);
            this.dgvWalkers.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(171, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "ترتيب حسب القدرات البدنية";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(1034, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "بيان بأسماء المرشحين لكل سلاح الاطوال والقدرات البدنية ";
            // 
            // Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1659, 839);
            this.Controls.Add(this.panel1);
            this.Name = "Evaluation";
            this.Text = "Weapons";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Evaluation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModr3at)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWalkers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvWalkers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox stageDrp;
        private System.Windows.Forms.DataGridView dgvModr3at;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblhight;
        private System.Windows.Forms.Label lblforce;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnHight;
        private System.Windows.Forms.Button btnForce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox drpQualification;
    }
}