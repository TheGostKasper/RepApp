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
    public partial class StateReports : Form
    {
        FillComboValues fcmb = new FillComboValues();
        SqlCommands cmd = new SqlCommands("DB_Tagneed");
        _helper _hel = new _helper();
        public StateReports()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            fcmb.GetTagneedAreas(new DummyCombo { Text = "مركز تدريب", Value = 1 }, tgneedDrp);
            fcmb.GetStages(stageDrp);
            fcmb.getResultsTypes(drpRepo);
            fcmb.GetObsv(lobsDrp);
            GetReports();
            getDates();
        }

        private void getDates()
        {
            var exsDrp = (DummyCombo)tgneedDrp.SelectedItem;
            var stgDrp = stageDrp.SelectedItem;

            if (exsDrp != null)
                fcmb.GetDelieveredDates(drpDates, exsDrp.Value, stgDrp.ToString());
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
            var drpType = (DummyCombo)drpRepo.SelectedItem;

           
            if (exsDrp != null && lpsDrp != null && dates != null)
            {

               var spQuery = (lpsDrp.Value == 1) ? "sp_Ncd_state" : "sp_dwm_state";

                var dts = new List<Examiner>();
                string sstr = "";
                if (drpType.Value == 1)
                {
                    _hel.GetBasicTypedInfo(spQuery, exsDrp.Value, stgDrp.ToString(), dates.Text,true, (_list, _str) =>
                    {
                       sstr = _str; dts = _list;
                        reportViewer2.LocalReport.ReportEmbeddedResource = "AppSound.Reports.mainTagneed.rdlc";
                    });
                }
                else
                {
                    _hel.GetBasicTypedInfo(spQuery, exsDrp.Value, stgDrp.ToString(), dates.Text,true, (_list, _str) =>
                    {
                        sstr = _str; dts = _list;
                        reportViewer2.LocalReport.ReportEmbeddedResource = "AppSound.Reports.results.rdlc";
                    });
                }
                var rds = new ReportDataSource("ObsvTot", dts);
                reportViewer2.LocalReport.SetParameters(new ReportParameter("rpHeader", String.Format("بيان بأسماء الجنود {2} - عن مركز تدريب {0} - مرحلة {1} ", exsDrp.Text, stageDrp.Text, lpsDrp.Text)));
                reportViewer2.LocalReport.SetParameters(new ReportParameter("agg", String.Format("{0} ", sstr)));
                reportViewer2.LocalReport.DataSources.Clear();
                reportViewer2.LocalReport.DataSources.Add(rds);
                this.reportViewer2.RefreshReport();
            }
        }
    
        private void tgneedDrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetReports();
        }

        private void StateReports_Load(object sender, EventArgs e)
        {

            this.reportViewer2.RefreshReport();
        }

       
        private void tgneedDrp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var exsDrp = (DummyCombo)tgneedDrp.SelectedItem;

            if (exsDrp != null)
                fcmb.GetDelieveredDates(drpDates, exsDrp.Value, stageDrp.SelectedItem.ToString());
        }
    }
}
