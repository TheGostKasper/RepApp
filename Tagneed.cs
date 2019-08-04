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
using System.Windows.Forms.DataVisualization.Charting;

namespace AppSound
{
    public partial class Tagneed : Form
    {
        FillComboValues fcmb = new FillComboValues();
        SqlCommands cmd = new SqlCommands("DB_Tagneed");
        public Tagneed()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            GetStages();
            GetExams();
            fcmb.GetTagneedAreas(tgneedDrp);
            fcmb.GetQualificationAreas(qualiDrp);

           // StatsAggTagneedArea();
            FillGridView();
            GetReports("GetExaminersNoticedExamsND");

        }
        public void GetStages()
        {
            cmd.ReaderCMD("select stage from maintagneed group by stage", _reader =>
            {
                while (_reader.Read()) stageDrp.Items.Add(_reader.GetValue(0));
                stageDrp.SelectedIndex = 0;
            });
        }

        public void GetExams()
        {
            var query = string.Format(@"select ex_id,ex_name from exams ");
            fcmb.GetReaderList(query, drpExams);
        }

      

        //public void StatsAggTagneedArea()
        //{
        //    var exsDrp = (DummyCombo)drpExams.SelectedItem;
        //    cmd.TableCMDStoredP("GetExamsTGAS", (_cmd) =>
        //    {
        //        _cmd.CommandType = CommandType.StoredProcedure;
        //        _cmd.Parameters.AddWithValue("@ex_id", exsDrp.Value);
        //        var dt = new DataTable();
        //        var oldb = new SqlDataAdapter(_cmd);
        //        oldb.Fill(dt);

        //        dataGridView1.DataSource = dt;
        //    });
        //}
        //public void FillChart(string query, Chart chrt)
        //{
        //    var quaDrp = (DummyCombo)qualiDrp.SelectedItem;
        //    var stgDrp = stageDrp.SelectedItem;

        //    if (quaDrp != null && stgDrp != null)
        //        cmd.GetCMDConnection(query, _cmd =>
        //        {
        //            _cmd.CommandType = CommandType.StoredProcedure;
        //            _cmd.Parameters.AddWithValue("@qu_no", quaDrp.Value);
        //            _cmd.Parameters.AddWithValue("@stage", stgDrp.ToString());

        //            var _reader = _cmd.ExecuteReader();
        //            var _list = new List<DummyCombo>();
        //            while (_reader.Read())
        //            {
        //                _list.Add(new DummyCombo
        //                {
        //                    Text = _reader.GetValue(2).ToString(),
        //                    Value = int.Parse(_reader.GetValue(1).ToString())
        //                });
        //            }
        //            chrt.Series.Clear();
        //            if (_list.Count > 0) chrt.DataBindTable(_list, "Text");
        //            else chrt.Visible = true;
        //        });
        //}
        public void FillGridView()
        {
            var quaDrp = (DummyCombo)qualiDrp.SelectedItem;
            var tgdDrp = (DummyCombo)tgneedDrp.SelectedItem;

            if (quaDrp != null && tgdDrp != null && stageDrp.SelectedItem!=null)
            {
                var qury = String.Format(@" select distinct FullName 'Name',trible_sequence 'Trible Number',moh_name 'State' from maintagneed 
                                        inner join regions on tagneed_code=rg_id
                                        inner join qualifications on serv_code=qualification_no
                                        where tagneed_code={0} and qualification_no = {1} and stage='{2}'",
               tgdDrp.Value, quaDrp.Value, stageDrp.SelectedItem);


                cmd.TableCMD(qury, _dt =>
                {
                    dataGridView2.DataSource = _dt;
                });
            }
            GetCountable();

        }
        private void stageDrp_SelectedIndexChanged(object sender, EventArgs e)
        {

            FillGridView();
        }

        private void qualiDrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGridView();
        }

        private void tgneedDrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGridView();

        }

        private void drpExams_SelectedIndexChanged(object sender, EventArgs e)
        {
            //StatsAggTagneedArea();
            GetCountable();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
        }
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var query = String.Format(@"select ex.ex_id , ex.ex_name , rs_value , (select 'True' where rs_value<= ex_down ) 'DownFull' , (select 'True' where rs_value>= ex_obsv ) 'Noticed' 
                                        from maintagneed t inner join exams ex on t.ex_id= ex.ex_id  where trible_sequence ='{0}'", dataGridView2.SelectedRows[0].Cells[1].Value);
                cmd.TableCMD(query, _dt =>
                {
                    dataGridView3.DataSource = _dt;
                });
            }
        }
        public void GetCountable()
        {
             var quaDrp = (DummyCombo)qualiDrp.SelectedItem;
             var stgDrp = stageDrp.SelectedItem;
             var tgdDrp = (DummyCombo)tgneedDrp.SelectedItem;
             var exsDrp = (DummyCombo)drpExams.SelectedItem;

             if (quaDrp != null && stgDrp != null && tgdDrp != null && exsDrp!=null)
                cmd.GetCMDConnection("GetCountableExamsND", _cmd =>
                {
                    _cmd.CommandType = CommandType.StoredProcedure;
                    _cmd.Parameters.AddWithValue("@qu_no", quaDrp.Value);
                    _cmd.Parameters.AddWithValue("@stage", stgDrp.ToString());
                    _cmd.Parameters.AddWithValue("@tgneed_code", int.Parse(tgdDrp.Value.ToString()));
                    _cmd.Parameters.AddWithValue("@ex_id",int.Parse(exsDrp.Value.ToString()));

                    var _reader = _cmd.ExecuteReader();

                    while (_reader.Read())
                    {
                        lblNoticed.Text = _reader.GetValue(0).ToString();
                        lblDown.Text = _reader.GetValue(1).ToString();
                    }
                });

            

           
        }
        public void GetReports(string query)
        {
            var quaDrp = (DummyCombo)qualiDrp.SelectedItem;
            var stgDrp = stageDrp.SelectedItem;
            var tgdDrp = (DummyCombo)tgneedDrp.SelectedItem;
            var exsDrp = (DummyCombo)drpExams.SelectedItem;



            if (quaDrp != null && stgDrp != null && tgdDrp != null && exsDrp != null)
            {
                cmd.GetCMDConnection(query, _cmd =>
                {
                    _cmd.CommandType = CommandType.StoredProcedure;
                    _cmd.Parameters.AddWithValue("@qu_no", int.Parse(quaDrp.Value.ToString()));
                    _cmd.Parameters.AddWithValue("@stage", stgDrp.ToString());
                    _cmd.Parameters.AddWithValue("@tgneed_code", int.Parse(tgdDrp.Value.ToString()));
                    _cmd.Parameters.AddWithValue("@ex_id", int.Parse(exsDrp.Value.ToString()));

                    var dt = new DataTable();
                    var oldb = new SqlDataAdapter(_cmd);
                    oldb.Fill(dt);

                    dataGridView2.DataSource = dt;



                    var rds = new ReportDataSource("DataSet1", dt);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rds);

                    reportViewer1.LocalReport.SetParameters(new ReportParameter("rpHeader",String.Format("بيان بعدد الجنود {4} باختبار ( {0} ) عن منطقة تجنيد ({1}) ({2}) مرحلة {3} ", exsDrp.Text, tgdDrp.Text, quaDrp.Text, stgDrp,header)));
                    
                    this.reportViewer1.RefreshReport();

                });
            }
        }
        private string header = "الملحوظين";
        private void btnDown_Click(object sender, EventArgs e)
        {
            header = "المقصرين";
            GetReports("GetExaminersDownFullExamsND");
        }

        private void btnNoticed_Click(object sender, EventArgs e)
        {
            header = "الملحوظين";
            GetReports("GetExaminersNoticedExamsND");
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            FillGridView();
        }

        private void Tagneed_Load(object sender, EventArgs e)
        {
            
        }

    }
}
