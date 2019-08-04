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

namespace AppSound.TStates
{
    public partial class ResultsCollection : Form
    {
        FillComboValues fcmb = new FillComboValues();
        SqlCommands cmd = new SqlCommands("DB_Tagneed");
        _helper _hel = new _helper();
        public ResultsCollection()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            fcmb.GetTagneedAreas(new DummyCombo { Text = "مركز تدريب", Value = 1 }, tgneedDrp);
            GetStages();
            fcmb.getRepoTypes(drpRepo);
            fcmb.GetObsv(lobsDrp);
            GetReports();
            getDates();
        }

        private void getDates()
        {
            var exsDrp = (DummyCombo)tgneedDrp.SelectedItem;
            if (exsDrp != null)
                fcmb.GetDelieveredDates(drpDates, exsDrp.Value, stageDrp.SelectedItem.ToString());
        }
        public void GetStages()
        {
            cmd.ReaderCMD("select stage from states group by stage", _reader =>
            {
                while (_reader.Read()) stageDrp.Items.Add(_reader.GetValue(0));
                stageDrp.SelectedIndex = 0;
            });
        }


        public void GetReports()
        {
            BindToBasicExaminerInfoReport();
        }

        

        public void BindToBasicExaminerInfoReport()
        {
            var exsDrp = (DummyCombo)tgneedDrp.SelectedItem;
            var lpsDrp = (DummyCombo)lobsDrp.SelectedItem;
            var dates = (DummyCombo)drpDates.SelectedItem;
            var stgDrp = stageDrp.SelectedItem;
            var drpType = (DummyCombo)drpRepo.SelectedItem;

           
            if (exsDrp != null && lpsDrp != null && dates != null)
            {
                var spQuery = (lpsDrp.Value == 1) ? "sp_get_Ncd_By_STADate" : "sp_get_dwnf_By_STADate";
                
                _hel.GetBasicTypedInfo(spQuery, exsDrp.Value, stgDrp.ToString(), dates.Text,false, (_list,sstr) =>
                {
                    reportViewer1.LocalReport.ReportEmbeddedResource = (drpType.Value == 1) ? "AppSound.Reports.STSReport.rdlc" : "AppSound.Reports.repRep.rdlc";
                    
                    var rds = new ReportDataSource("ObsvTot", _list);

                    reportViewer1.LocalReport.SetParameters(new ReportParameter("date", DateTime.Now.AddDays(2).ToShortDateString()));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("edara", txtEdara.Text));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("stateName", exsDrp.Text));
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rds);

                    this.reportViewer1.RefreshReport();
                });
            }
        }

        private void tgneedDrp_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            GetReports();
        }


        private void ResultsCollection_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void dtm_ValueChanged(object sender, EventArgs e)
        {
            GetReports();
        }

        private void tgneedDrp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var exsDrp = (DummyCombo)tgneedDrp.SelectedItem;
            if (exsDrp != null)
                fcmb.GetDelieveredDates(drpDates, exsDrp.Value, stageDrp.SelectedItem.ToString());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetReports();
        }
    }
}
