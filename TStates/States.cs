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
    public partial class States : Form
    {
        FillComboValues fcmb = new FillComboValues();
        SqlCommands cmd = new SqlCommands("DB_Tagneed");
        private string header = "الملحوظين";

        public States()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            fcmb.GetTagneedAreas(new DummyCombo { Text = "مركز تدريب", Value = 1 }, tgneedDrp);
            fcmb.GetStages(stageDrp);
            GetExams();

           // fcmb.GetTagneedAreas(tgneedDrp);
            FillGridView();

            GetReports("sp_ntc_states");

        }

        public void GetExams()
        {
            var query = string.Format(@"select ex_id,ex_name from exams ");
            fcmb.GetReaderList(query, drpExams);
        }
       

        public void GetReports(string query)
        {
            var stgDrp = stageDrp.SelectedItem;
            var tgdDrp = (DummyCombo)tgneedDrp.SelectedItem;
            var exsDrp = (DummyCombo)drpExams.SelectedItem;

            var _list = new List<TYResults>();

            if (stgDrp != null && tgdDrp != null && exsDrp != null)
            {
                cmd.GetCMDConnection(query, _cmd =>
                {
                    _cmd.CommandType = CommandType.StoredProcedure;
                    _cmd.Parameters.AddWithValue("@stage", stgDrp.ToString());
                    _cmd.Parameters.AddWithValue("@state_code", int.Parse(tgdDrp.Value.ToString()));
                    _cmd.Parameters.AddWithValue("@ex_id", int.Parse(exsDrp.Value.ToString()));

                    var _reader = _cmd.ExecuteReader();
                    var i=1;
                    while (_reader.Read())
                    {
                        _list.Add(new TYResults
                        {
                            ID = i++,
                            Ex_Name = _reader.GetValue(0).ToString(),
                            Trible_Sequence = _reader.GetValue(1).ToString(),
                            Rs_value = int.Parse(_reader.GetValue(2).ToString())
                        });
                    }

                    dataGridView2.DataSource = _list;



                    var rds = new ReportDataSource("DataSet1", _list);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rds);

                    reportViewer1.LocalReport.SetParameters(new ReportParameter("rpHeader", String.Format("بيان بعدد الجنود {3} باختبار ( {0} ) عن مركز تدريب ({1}) مرحلة {2} ", exsDrp.Text, tgdDrp.Text, stgDrp, header)));

                    this.reportViewer1.RefreshReport();

                });
            }
        }
       

        private void btnDown_Click(object sender, EventArgs e)
        {
            header = "المقصرين";
            GetReports("sp_dn_states");
        }

        private void btnNoticed_Click(object sender, EventArgs e)
        {
            header = "الملحوظين";
            GetReports("sp_ntc_states");
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
           
        }

        public void FillGridView()
        {
            var tgdDrp = (DummyCombo)tgneedDrp.SelectedItem;

            if (tgdDrp != null && stageDrp.SelectedItem != null)
            {
                var qury = String.Format(@" select distinct FullName 'Name',sold_id 'Solider ID',moh_name 'State' from states 
                                        inner join regions on state_code=rg_id
                                        where state_code={0} and stage='{1}'",
               tgdDrp.Value, stageDrp.SelectedItem);


                cmd.TableCMD(qury, _dt =>
                {
                    dataGridView2.DataSource = _dt;
                });
            }
            GetCountable();

        }
        public void GetCountable()
        {
            var stgDrp = stageDrp.SelectedItem;
            var tgdDrp = (DummyCombo)tgneedDrp.SelectedItem;
            var exsDrp = (DummyCombo)drpExams.SelectedItem;

            if ( stgDrp != null && tgdDrp != null && exsDrp != null)
                cmd.GetCMDConnection("sp_cnt_exams_states", _cmd =>
                {
                    _cmd.CommandType = CommandType.StoredProcedure;
                    _cmd.Parameters.AddWithValue("@stage", stgDrp.ToString());
                    _cmd.Parameters.AddWithValue("@state_code", int.Parse(tgdDrp.Value.ToString()));
                    _cmd.Parameters.AddWithValue("@ex_id", int.Parse(exsDrp.Value.ToString()));

                    var _reader = _cmd.ExecuteReader();

                    while (_reader.Read())
                    {
                        lblNoticed.Text = _reader.GetValue(0).ToString();
                        lblDown.Text = _reader.GetValue(1).ToString();
                    }
                });




        }
        private void stageDrp_SelectedIndexChanged(object sender, EventArgs e)
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

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var query = String.Format(@"select ex.ex_id , ex.ex_name , rs_value , (select 'True' where rs_value<= ex_down ) 'DownFull' , (select 'True' where rs_value>= ex_obsv ) 'Noticed' 
                                        from states t inner join exams ex on t.ex_id= ex.ex_id  where sold_id ='{0}'", dataGridView2.SelectedRows[0].Cells[1].Value);
                cmd.TableCMD(query, _dt =>
                {
                    dataGridView3.DataSource = _dt;
                });
            }
        }

        private void StateReports_Load(object sender, EventArgs e)
        {

        }

       
    }
}
