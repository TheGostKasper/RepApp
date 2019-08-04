using AppSound.Helper;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSound.TagneedR
{

    public partial class Evaluation : Form
    {
        FillComboValues fcmb = new FillComboValues();
        SqlCommands cmd = new SqlCommands("DB_Tagneed");
        public Evaluation()
        {
            InitializeComponent();
            fcmb.GetTagneedStages(stageDrp);
            fcmb.GetQualificationAreas(drpQualification);

        }

       
        public void Init()
        {
            GetWalkers();
            GetModr3at();
        }
        public void GetWalkers()
        {
            var quf = (DummyCombo)drpQualification.SelectedItem;

            cmd.Catalog = DBCatalog.DB_Tagneed.ToString();
            var query = String.Format(@"select  distinct fullname,trible_sequence,moh_name , sum(rs_value)  'Summition' from maintagneed where ex_id in (46,39,37,38) 
                                        and trible_sequence  not in (select distinct trible_sequence from maintagneed  d inner join exams de on d.ex_id=de.ex_id  where rs_value>=de.ex_obsv )
                                        and stage='{0}' and qualification_no ={1} group by fullname,trible_sequence,moh_name order by  Summition desc ", stageDrp.SelectedItem, quf.Value);

            cmd.TableCMD(query, _dt =>
            {
                dgvWalkers.DataSource = _dt;
                lblforce.Text = (dgvWalkers.RowCount).ToString();
            });
        }


        public void GetModr3at()
        {
            var quf = (DummyCombo)drpQualification.SelectedItem;

            var query = String.Format(@"select  distinct fullname,trible_sequence,moh_name , sum(rs_value)  'Summition' from maintagneed  where ex_id in (47) 
                                        and trible_sequence  not in (select distinct trible_sequence from maintagneed d inner join exams de on d.ex_id=de.ex_id  where rs_value>=de.ex_obsv)
                                        and stage='{0}' and qualification_no ={1} group by fullname,trible_sequence,moh_name order by  Summition desc ", stageDrp.SelectedItem, quf.Value);
            cmd.TableCMD(query, _dt =>
            {
                dgvModr3at.DataSource = _dt;
                lblhight.Text = (dgvModr3at.RowCount).ToString();
            });
        }

        private void stageDrp_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var quf = (DummyCombo)drpQualification.SelectedItem;

            if (quf != null)
            {
                Init();
                SetReportViewer(dgvModr3at,String.Format("تقرير بأسماء المرشحين حسب الاطوال "));
            }
        }

        private void Evaluation_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btnHight_Click(object sender, EventArgs e)
        {
            SetReportViewer(dgvModr3at,String.Format("تقرير بأسماء المرشحين حسب الاطوال "));
        }

        private void btnForce_Click(object sender, EventArgs e)
        {
            SetReportViewer(dgvWalkers,String.Format("تقرير بأسماء المرشحين حسب القدرات البدنية "));
        }

        public void SetReportViewer(DataGridView dgv,string header)
        {
            var rds = new ReportDataSource("MTGND", dgv.DataSource);

            reportViewer1.LocalReport.SetParameters(new ReportParameter("rpHeader", header));
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }

    }
}
