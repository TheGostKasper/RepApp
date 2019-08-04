using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSound.TagneedR
{

    public partial class Weapons : Form
    {
        FillComboValues fcmb = new FillComboValues();
        SqlCommands cmd = new SqlCommands("DB_Tagneed");
        public Weapons()
        {
            InitializeComponent();
            GetStages();
            fcmb.GetQualificationAreas(drpQualification);
        }

        public void GetStages()
        {
            cmd.ReaderCMD("select stage from maintagneed group by stage", _reader =>
            {
                while (_reader.Read()) stageDrp.Items.Add(_reader.GetValue(0));
                stageDrp.SelectedIndex = 0;
            });
        }
        public void Init()
        {
            GetWalkers();
        }


        private void stageDrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            Init();
        }

        private void Weapons_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
        public void SetReportViewer<T>(T dgv, string src, string reportname,string header)
        {
            var rds = new ReportDataSource(src, dgv);
            reportViewer1.LocalReport.ReportEmbeddedResource = reportname;
            reportViewer1.LocalReport.SetParameters(new ReportParameter("rpHeader", header));

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }


        private void btnWalkers_Click(object sender, EventArgs e)
        {
            GetWalkers();
        }

        private void GetWalkers()
        {
            var quf = (DummyCombo)drpQualification.SelectedItem;

            var stage = stageDrp.SelectedItem;
            if (stage != null && quf != null)
            {
                var query = String.Format(@"select ROW_NUMBER() OVER (Order by trible_sequence) AS ID,* from (select  distinct fullname,trible_sequence,moh_name , rs_value  'Summition' from maintagneed d inner join exams de on d.ex_id=de.ex_id
                                        where trible_sequence  not in (select distinct trible_sequence from maintagneed  where rs_value>=de.ex_obsv )
                                        and stage='{0}' and qualification_no ={1} and de.ex_id=28 and rs_value >=de.ex_dist )s ", stage, quf.Value);

                cmd.TableCMD(query, _dt =>
                {
                    var header = String.Format(@"بيان بأسماء المرشحين لسلاح المشاة - مرحلة {0} - مؤهل {1}",stage,quf.Text);
                    SetReportViewer(_dt, "MTGND", "AppSound.Reports.TagneedReport.rdlc", header);
                });
            }
           
        }

        private void btnForce_Click(object sender, EventArgs e)
        {
            var quf = (DummyCombo)drpQualification.SelectedItem;

            var stage = stageDrp.SelectedItem;
            var query = String.Format(@"select ROW_NUMBER() OVER (Order by trible_sequence) AS ID,* from (select  distinct fullname,trible_sequence,moh_name , rs_value  'Summition' from maintagneed  d inner join exams de on d.ex_id=de.ex_id
                                        where trible_sequence  not in (select distinct trible_sequence from maintagneed  where rs_value>=de.ex_obsv  )
                                        and stage='{0}' and (d.ex_id=29 and rs_value >=de.ex_dist ) and qualification_no ={1})s ", stage, quf.Value);
            cmd.TableCMD(query, _dt =>
            {
                var header = String.Format(@"بيان بأسماء المرشحين لسلاح المدرعات - مرحلة {0} - مؤهل {1}", stage, quf.Text);
                SetReportViewer(_dt, "MTGND", "AppSound.Reports.TagneedReport.rdlc", header);
            });
        }

        private void btntanks_Click(object sender, EventArgs e)
        {
            var quf = (DummyCombo)drpQualification.SelectedItem;
            var stage = stageDrp.SelectedItem;
            var query = String.Format(@"select ROW_NUMBER() OVER (Order by trible_sequence) AS ID,* from (select  distinct fullname,trible_sequence,moh_name from maintagneed d inner join exams de on d.ex_id=de.ex_id
                                        where trible_sequence  not in (select distinct trible_sequence from maintagneed  where rs_value>=de.ex_obsv )
                                        and trible_sequence in (select trible_sequence from maintagneed dd inner join exams dde on dd.ex_id=dde.ex_id where (dd.ex_id=6 and rs_value>=dde.ex_dist))
                                        and stage='{0}' and qualification_no ={1} and (d.ex_id=1 and rs_value >=de.ex_dist))s ", stage, quf.Value);
            cmd.TableCMD(query, _dt =>
            {
                var header = String.Format(@"بيان بأسماء المرشحين لسلاح المدفعية - مرحلة {0} - مؤهل {1}", stage, quf.Text);
                SetReportViewer(_dt, "MTGND", "AppSound.Reports.TagneedReport.rdlc", header);
            });
        }

        private void drpQualification_SelectedIndexChanged(object sender, EventArgs e)
        {
            Init();
        }

      



        public void GetReportsOfSpecificExams(string command,string report,string header)
        {
            var stage = stageDrp.SelectedItem;

            cmd.GetCMDConnection(command, _cmd =>
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@stage", stage);

                var dt = new DataTable();
                var oldb = new SqlDataAdapter(_cmd);
                oldb.Fill(dt);


                SetReportViewer(dt, "DSTS", report, header);
            });
        }
        private void tgwalkers_Click(object sender, EventArgs e)
        {
            var header = String.Format(@"تقرير المرشحين لسلاح المشاة - مناطق - مرحلة {0}", stageDrp.SelectedItem);
            GetReportsOfSpecificExams("sp_report_tagneed_walkers", "AppSound.Reports.TGEXMS.rdlc", header);
        }

        private void tgarti_Click(object sender, EventArgs e)
        {
            var header = String.Format(@"تقرير المرشحين لسلاح المدرعات - مناطق - مرحلة {0}", stageDrp.SelectedItem);
            GetReportsOfSpecificExams("sp_report_tagneed_arti", "AppSound.Reports.TGEXMS.rdlc", header);
        }

        private void tgtank_Click(object sender, EventArgs e)
        {
            var header = String.Format(@"تقرير المرشحين لسلاح المدفعية - مناطق- مرحلة {0}", stageDrp.SelectedItem);
            GetReportsOfSpecificExams("sp_report_tagneed_tank", "AppSound.Reports.TGEXMS.rdlc", header);
        }
    }
}
