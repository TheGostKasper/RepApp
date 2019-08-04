using AppSound.Modals;
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
    public partial class SPExam : Form
    {
        FillComboValues fcmb = new FillComboValues();
        SqlCommands cmd = new SqlCommands("DB_Tagneed");

        public SPExam()
        {
            InitializeComponent();
            Init();
            // GetExcluded();
        }
        public void Init()
        {
            fcmb.GetTagneedAreas(new DummyCombo { Text = "مناطق تجنيد", Value = 2 }, drpTagneed);
            fcmb.GetExams( drpExams);
            GetStages();
            // fcmb.GetTagneedAreas(drpTagneed);
            fcmb.GetTGDObsv(lobsDrp);
            fcmb.GetQualificationAreas(drpQualification);
            GetReports();
        }
        public void GetStages()
        {
            cmd.ReaderCMD("select stage from maintagneed group by stage", _reader =>
            {
                while (_reader.Read()) stageDrp.Items.Add(_reader.GetValue(0));
                stageDrp.SelectedIndex = 0;
            });
        }

      
        public void GetReports(){
            var semat = (DummyCombo)lobsDrp.SelectedItem;
            var quf = (DummyCombo)drpQualification.SelectedItem;
            var tgd = (DummyCombo)drpTagneed.SelectedItem;
            var exm = (DummyCombo)drpExams.SelectedItem;
            var stgDrp = stageDrp.SelectedItem;


            if (semat!=null && quf != null && semat != null && stgDrp != null && tgd != null && exm != null)
            {
                if (semat.Value == 1) Noticed();
                else Normal();
            }
        }

        public void Noticed()
        {
            var semat = (DummyCombo)lobsDrp.SelectedItem;
            var quf = (DummyCombo)drpQualification.SelectedItem;
            var tgd = (DummyCombo)drpTagneed.SelectedItem;
            var exm = (DummyCombo)drpExams.SelectedItem;
            var stgDrp = stageDrp.SelectedItem;

            var _list = new List<TYouth>();

            if (quf != null && semat != null && stgDrp != null && tgd != null && exm != null)
            {
                var query = String.Format(@"
                    select  ROW_NUMBER() OVER (Order by trible_sequence) AS ID ,Fullname, trible_sequence , moh_name ,rs_value from maintagneed m inner join exams e on m.ex_id=e.ex_id 
                    where rs_value>=ex_obsv and m.ex_id={3} and qualification_no ={0} and stage='{1}' and tagneed_code='{2}'
				    ", quf.Value, stageDrp.Text, tgd.Value, exm.Value);

                cmd.TableCMD(query, _dt =>
                {
                    BindToReport(_dt);
                });
            }
        }

      

        public void BindToReport(DataTable _list)
        {
            var rds = new ReportDataSource("EXM", _list);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

           // reportViewer1.LocalReport.SetParameters(new ReportParameter("rpHeader", header));


            this.reportViewer1.RefreshReport();
        }
        public void Normal()
        {
            var semat = (DummyCombo)lobsDrp.SelectedItem;
            var quf = (DummyCombo)drpQualification.SelectedItem;
            var tgd = (DummyCombo)drpTagneed.SelectedItem;
            var exm = (DummyCombo)drpExams.SelectedItem;
            var stgDrp = stageDrp.SelectedItem;


            if (quf != null && semat != null && stgDrp != null && tgd != null)
            {
                var query = String.Format(@"
                    select ROW_NUMBER() OVER (Order by trible_sequence) AS ID , Fullname, trible_sequence , moh_name ,rs_value from maintagneed m inner join exams e on m.ex_id=e.ex_id 
                    where rs_value<ex_obsv and rs_value>ex_down and m.ex_id={3} and qualification_no ={0} and stage='{1}' and tagneed_code='{2}'", quf.Value, stageDrp.Text, tgd.Value, exm.Value);

                cmd.TableCMD(query, _dt =>
                {
                    BindToReport(_dt);
                });
            }
        }
      
        private void tgneedDrp_SelectedValueChanged(object sender, EventArgs e)
        {
            GetReports();
        }

        private void Exclude_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
