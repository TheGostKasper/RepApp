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
    public partial class SpecificTG : Form
    {
        FillComboValues fcmb = new FillComboValues();
        SqlCommands cmd = new SqlCommands("DB_Tagneed");
        static bool currValue = true;

        public SpecificTG()
        {
            InitializeComponent();
            Init();
            // GetExcluded();
        }
        public void Init()
        {
            fcmb.GetTagneedAreas(new DummyCombo { Text = "مناطق تجنيد", Value = 2 }, drpTagneed);
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
            var stgDrp = stageDrp.SelectedItem;


            if (semat!=null && quf != null && semat != null && stgDrp != null && tgd != null)
            {
                if (semat.Value == 1)
                {
                    currValue = true; 
                    Noticed();
                }
                else
                {
                    currValue = false;
                    Normal();
                }
            }
        }

        public void Noticed()
        {
            var semat = (DummyCombo)lobsDrp.SelectedItem;
            var quf = (DummyCombo)drpQualification.SelectedItem;
            var stgDrp = stageDrp.SelectedItem;
            var tgd = (DummyCombo)drpTagneed.SelectedItem;

            var _list = new List<Object>();

            if (quf != null && semat != null && stgDrp != null)
            {

                cmd.SPDataTable("sp_specific_Tagneed_Noticed", dt =>
                {
                    SetToReport<object, string>("AppSound.Reports.EXTG.rdlc", String.Format(@"", stgDrp), dt, "DataSetTG");
                }, new SqlParameter[] { 
                new SqlParameter{ParameterName="@stage",Value=stgDrp},
                new SqlParameter{ParameterName="@qualification",Value=quf.Value},
                new SqlParameter{ParameterName="@tagneed_code",Value=tgd.Value},
            });
            }
        }
        public void SetToReport<T, Y>(string reportName, string header, T src, Y ds)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = reportName;

            var rds = new ReportDataSource(ds.ToString(), src);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            // reportViewer1.LocalReport.SetParameters(new ReportParameter("rpHeader", header));


            this.reportViewer1.RefreshReport();
        }
      
        public void BindToReport(List<TYTGExaminer> _list)
        {
            var rds = new ReportDataSource("DataSetTG", _list);
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
            var stgDrp = stageDrp.SelectedItem;

           

            if (quf != null && semat != null && stgDrp != null)
            {

                cmd.SPDataTable("sp_specific_Tagneed_Normal", dt =>
                {
                    SetToReport<object, string>("AppSound.Reports.EXTG.rdlc", String.Format(@"", stgDrp), dt, "DataSetTG");
                }, new SqlParameter[] { 
                new SqlParameter{ParameterName="@stage",Value=stgDrp},
                new SqlParameter{ParameterName="@qualification",Value=quf.Value},
                new SqlParameter{ParameterName="@tagneed_code",Value=tgd.Value},
            });
            }
        }
        public string DisplaySq(string _value, int max)
        {
            if (_value != null)
            {
                var val = (_value == "") ? 0 : int.Parse(_value.ToString());
                if (val >= max && currValue) return val.ToString();
                else if (!currValue)
                    return val.ToString();
            }
            return "";
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
