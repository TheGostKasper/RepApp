using AppSound.Helper;
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

namespace AppSound
{
    public partial class PhsicoReports : Form
    {
        FillComboValues fcmb = new FillComboValues();
        SqlCommands cmd = new SqlCommands("DB_Tagneed");
        _helper _hel = new _helper();

        public PhsicoReports()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            fcmb.GetTagneedAreas(new DummyCombo { Text = "مركز تدريب", Value = 1 }, tgneedDrp);
            fcmb.GetInterviewStages(stageDrp);
            GetReports();
        }



        public void GetReports()
        {
            BindToObservablesExaminerseport();
        }


        public void BindToObservablesExaminerseport()
        {
            var exsDrp = (DummyCombo)tgneedDrp.SelectedItem;

            var stgDrp = stageDrp.SelectedItem;

            if (exsDrp != null && stgDrp != null)
            {

                var _list = new List<RepoPhys>();
                cmd.SPDataReader("sp_st_rep", _reader =>
                {
                    ReadBindReportData(true, _reader, ref _list);

                    var rds = new ReportDataSource("Phsy", _list);
                    reportViewer2.LocalReport.SetParameters(new ReportParameter("rpHeader", String.Format("احصائية عددية عن المقابلة الشخصية - مركز تدريب {1}- مرحلة {0} ", stageDrp.Text, exsDrp.Text)));
                    reportViewer2.LocalReport.DataSources.Clear();
                    reportViewer2.LocalReport.DataSources.Add(rds);

                    this.reportViewer2.RefreshReport();
                }, new SqlParameter[] { 
                new SqlParameter{ParameterName="@stage",Value=stageDrp.SelectedItem.ToString()},
                new SqlParameter{ParameterName="@state_code",Value=exsDrp.Value},
            });
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

        }

        private void btnAllStg_Click(object sender, EventArgs e)
        {
            var _list = new List<RepoPhys>();

            cmd.SPDataReader("sp_st_rep_Agg", _reader =>
            {
                ReadBindReportData(false, _reader, ref _list);

                var rds = new ReportDataSource("Phsy", _list);
                reportViewer2.LocalReport.SetParameters(new ReportParameter("rpHeader", String.Format("احصائية عددية عن المقابلة الشخصية لكل مراكز التدريب - مرحلة {0} ", stageDrp.Text)));
                reportViewer2.LocalReport.DataSources.Clear();
                reportViewer2.LocalReport.DataSources.Add(rds);

                this.reportViewer2.RefreshReport();
            }, new SqlParameter[] { 
                new SqlParameter{ParameterName="@stage",Value=stageDrp.SelectedItem.ToString()}
            });
        }


        public void ReadBindReportData(bool _nmExist, SqlDataReader _reader, ref List<RepoPhys> _list)
        {
            var i = 1;
            while (_reader.Read())
            {
                var name = (_nmExist) ? _reader.GetValue(13).ToString() : "اجمالي كل مراكز التدريب";
                _list.Add(new RepoPhys
                {
                    ID = i++,
                    Total = int.Parse(_reader.GetValue(0).ToString()),
                    SeenByHospital = int.Parse(_reader.GetValue(1).ToString()),
                    SeenByHead = int.Parse(_reader.GetValue(2).ToString()),
                    noComplains = int.Parse(_reader.GetValue(3).ToString()),
                    Fit = int.Parse(_reader.GetValue(4).ToString()),
                    Absence = int.Parse(_reader.GetValue(5).ToString()),
                    Gone = int.Parse(_reader.GetValue(6).ToString()),
                    MHospital = int.Parse(_reader.GetValue(7).ToString()),
                    PYSICO = int.Parse(_reader.GetValue(8).ToString()),
                    Return = int.Parse(_reader.GetValue(9).ToString()),
                    BackWMedicine = int.Parse(_reader.GetValue(10).ToString()),
                    MedicalFired = int.Parse(_reader.GetValue(11).ToString()),
                    PYSICOFired = int.Parse(_reader.GetValue(12).ToString()),
                    Name = name
                });
            }
            _reader.Close();
        }
    }
}
