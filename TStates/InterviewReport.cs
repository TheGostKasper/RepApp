using AppSound.Helper;
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

namespace AppSound
{
    public partial class InterviewReport : Form
    {
        FillComboValues fcmb = new FillComboValues();
        SqlCommands cmd = new SqlCommands("DB_Tagneed");
        _helper _hel = new _helper();
        string currStr = "";
        public InterviewReport()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            SelectFirstIndex(new List<Control> { drpHosResults, drpSoldSituation });

            fcmb.GetTagneedAreas(new DummyCombo { Text = "مركز تدريب", Value = 1 }, tgneedDrp);
            fcmb.GetInterviewStages(stageDrp);
            fcmb.RTInterviewerOpnion(lobsDrp);

            //fcmb.getResultsTypes(drpRepo);
            //fcmb.GetObsv(lobsDrp);
            GetReports();
            getDates();


        }

        private void getDates()
        {
            var exsDrp = (DummyCombo)tgneedDrp.SelectedItem;
            var stgDrp = stageDrp.SelectedItem;
            if (exsDrp != null)
                fcmb.GetInterviewedDates(drpDates, exsDrp.Value, stgDrp.ToString());
        }

        public void GetReports()
        {
            BindToObservablesExaminerseport();
        }


        public void BindToObservablesExaminerseport()
        {
            var exsDrp = (DummyCombo)tgneedDrp.SelectedItem;
            var lpsDrp = (DummyCombo)lobsDrp.SelectedItem;
            var dates = (DummyCombo)drpDates.SelectedItem;
            var stgDrp = stageDrp.SelectedItem;


            if (exsDrp != null && lpsDrp != null && dates != null)
            {
                GetHeader();

                var query = String.Format(@"select ROW_NUMBER() OVER (Order by sold_id) AS ID,sold_id,name from interview where stage='{0}' and state_code='{1}' and saving_date='{2}' 
                                            and interviewer_opinion='{3}' and solider_situation='{4}' and hospital_results='{5}'"
                    , stageDrp.Text, exsDrp.Value,dates.Text , lpsDrp.Text, drpSoldSituation.Text, drpHosResults.Text);

                cmd.TableCMD(query, _dt =>
                {
                   // var str = String.Format("{0}-{1}", (drpSoldSituation.Text != "لا يوجد") ? drpSoldSituation.Text : "", (drpHosResults.Text != "لا يوجد") ? drpHosResults.Text : "");
                    var rds = new ReportDataSource("ObsvTot", _dt);
                    reportViewer2.LocalReport.SetParameters(new ReportParameter("rpHeader", String.Format("{0} - {1}", lpsDrp.Text, currStr)));
                    reportViewer2.LocalReport.SetParameters(new ReportParameter("agg", String.Format("{0} - {1}", exsDrp.Text, stageDrp.Text)));
                    reportViewer2.LocalReport.DataSources.Clear();
                    reportViewer2.LocalReport.DataSources.Add(rds);

                    this.reportViewer2.RefreshReport();
                });

            }
        }

        private void tgneedDrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            GetReports();
        }

        private void StateReports_Load(object sender, EventArgs e)
        {

        }
        public void SelectFirstIndex(List<Control> cmxs)
        {
            foreach (var item in cmxs)
            {
                var cmx = (ComboBox)item;
                if (cmx.Items.Count > 0)
                {
                    cmx.SelectedIndex = 0;
                }
            }

        }
        private void lobsDrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetHeader();
        }

        private void GetHeader()
        {
            var item = (DummyCombo)lobsDrp.SelectedItem;

            if (item.Value == 2 && drpSoldSituation.Text.Contains("مست"))
            {
                currStr = drpSoldSituation.Text+" - " + drpHosResults.Text;
            }
            else if (item.Value == 2)
            {
                currStr = drpSoldSituation.Text; ;
            }
            else if (item.Value == 3)
            {
                currStr = drpHosResults.Text;
            }
            else
            {
                currStr = "";
            }
        }

        private void tgneedDrp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var exsDrp = (DummyCombo)tgneedDrp.SelectedItem;
            if (exsDrp != null)
                fcmb.GetInterviewedDates(drpDates, exsDrp.Value, stageDrp.SelectedItem.ToString());
        }
    }
}
