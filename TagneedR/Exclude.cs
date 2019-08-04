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
    public partial class Exclude : Form
    {
        FillComboValues fcmb = new FillComboValues();
        SqlCommands cmd = new SqlCommands("DB_Tagneed");
        static bool currValue = true;

        public Exclude()
        {
            InitializeComponent();
            Init();
            // GetExcluded();
        }
        public void Init()
        {
            //fcmb.GetTagneedAreas(new DummyCombo { Text = "مناطق تجنيد", Value = 2 }, tgneedDrp);
            GetStages();
            // fcmb.GetTagneedAreas(tgneedDrp);
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


        public void GetReports()
        {
            var semat = (DummyCombo)lobsDrp.SelectedItem;
            if (semat != null)
            {
                if (semat.Value == 1)
                {

                    currValue = true;
                    Noticed();
                    //BindToReport(GetNCDExamsResults(Noticed()));
                }
                else
                {
                    currValue = false;
                    Normal();
                    //BindToReport(GetNCDExamsResults(Normal()));
                }
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


        public void Noticed()
        {
            var semat = (DummyCombo)lobsDrp.SelectedItem;
            var quf = (DummyCombo)drpQualification.SelectedItem;
            var stgDrp = stageDrp.SelectedItem;

            var _list = new List<Object>();

            if (quf != null && semat != null && stgDrp != null)
            {

                cmd.SPDataTable("sp_Tagneed_Noticed", dt =>
               {
                   SetToReport<object, string>("AppSound.Reports.EXTG.rdlc", String.Format(@"", stgDrp), dt, "DataSetTG");
               }, new SqlParameter[] { 
                new SqlParameter{ParameterName="@stage",Value=stgDrp},
                new SqlParameter{ParameterName="@qualification",Value=quf.Value}
            });
            }
        }

        public List<TYTGExaminer> GetNCDExamsResults(List<TYouth> _list)
        {
            var exList = new List<TYTGExaminer>();
            var i = 1;
            foreach (var item in _list)
            {
                var query = String.Format(@"
                select  distinct fullname ,trible_sequence  ,
				((select rs_value  from maintagneed res  where res.ex_id=92 and trible_sequence='{0}' )) as 'بعد الإنطوائية' ,
				((select res.rs_value  from maintagneed res  where res.ex_id=93 and trible_sequence='{0}')) as ' بعد العدوانية -الجريمة ' ,
                ((select res.rs_value  from maintagneed res  where res.ex_id=121 and trible_sequence='{0}')) as 'بعد الذهانية' ,
                ((select res.rs_value  from maintagneed res  where res.ex_id=122 and trible_sequence='{0}')) as 'بعد العصابيه ',
                ((select res.rs_value  from maintagneed res  where res.ex_id=101 and trible_sequence='{0}')) as 'بعد التطرف'
                ,moh_name,rg_name
				  from maintagneed t inner join exams ex on t.ex_id= ex.ex_id inner join regions on tagneed_code =rg_id  where  trible_sequence='{0}' ", item.Trible_Sequence);


                cmd.ReaderCMD(query, _reader =>
                {
                    while (_reader.Read())
                    {
                        exList.Add(new TYTGExaminer
                        {
                            ID = i++,
                            Name = _reader.GetValue(0).ToString(),
                            TYID = _reader.GetValue(1).ToString(),
                            State = _reader.GetValue(7).ToString(),
                            Tagneed = _reader.GetValue(8).ToString(),
                            Isolation = DisplaySq(_reader.GetValue(2).ToString(), 18),
                            Crime = DisplaySq(_reader.GetValue(3).ToString(), 18),
                            Zhania = DisplaySq(_reader.GetValue(4).ToString(), 18),
                            Anger = DisplaySq(_reader.GetValue(5).ToString(), 18),
                            TTrof = DisplaySq(_reader.GetValue(6).ToString(), 18)
                        });
                    }
                    _reader.Close();
                });
            }
            return exList;
        }

        #region GetDWNExamsResults
        public List<TYTGExaminer> GetNoticedByDegrees()
        {
            var stage = stageDrp.SelectedItem;
            var exList = new List<TYTGExaminer>();
            cmd.GetCMDConnection("sp_excd_ncd", _cmd =>
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@stage", "20193");

                var _reader = _cmd.ExecuteReader();


                while (_reader.Read())
                {
                    exList.Add(new TYTGExaminer
                    {
                        ID = int.Parse(_reader.GetValue(0).ToString()),
                        TYID = _reader.GetValue(1).ToString(),
                        Name = _reader.GetValue(2).ToString(),
                        State = _reader.GetValue(3).ToString(),
                        Tagneed = _reader.GetValue(4).ToString(),
                        Isolation = _reader.GetValue(5).ToString(),
                        Crime = _reader.GetValue(6).ToString(),
                        Zhania = _reader.GetValue(7).ToString(),
                        Anger = _reader.GetValue(8).ToString(),
                        TTrof = _reader.GetValue(9).ToString()
                    });
                }
                _reader.Close();
            });
            return exList;
        }


        #endregion

        public string DisplaySq(string _value, int max)
        {
            if (_value != null)
            {
                var val = (_value == "") ? 0 : int.Parse(_value.Split('.')[0].ToString());
                if (val >= max && currValue) return val.ToString();
                else if (!currValue)
                    return val.ToString();
            }
            return "";
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
            var stgDrp = stageDrp.SelectedItem;

            var _list = new List<Object>();

            if (quf != null && semat != null && stgDrp != null)
            {

                cmd.SPDataTable("sp_Tagneed_Normal", dt =>
                {
                    SetToReport<object, string>("AppSound.Reports.EXTG.rdlc", String.Format(@"", stgDrp), dt, "DataSetTG");
                }, new SqlParameter[] { 
                new SqlParameter{ParameterName="@stage",Value=stgDrp},
                new SqlParameter{ParameterName="@qualification",Value=quf.Value}
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
