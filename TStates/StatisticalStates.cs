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
    public partial class StatisticalStates : Form
    {
        SqlCommands cmd = new SqlCommands(DBCatalog.DB_Tagneed.ToString());
        FillComboValues fcmb = new FillComboValues();

        public StatisticalStates()
        {
            InitializeComponent();

            //fcmb.GetTagneedAreas(new DummyCombo { Text = "مراكز تدريب", Value = 1 }, tgneedDrp);
            GetStages();
            GetAllExamsIds();
        }



        public void GetStages()
        {
            cmd.ReaderCMD("select stage from states group by stage", _reader =>
            {
                while (_reader.Read()) stageDrp.Items.Add(_reader.GetValue(0));
                stageDrp.SelectedIndex = 0;
            });
        }
        public void LoopStatesAgg()
        {
            var stage = stageDrp.SelectedItem;
            if (stage != null)
                cmd.SPDataTable("sp_getState_Agg_by_Id", dt =>
                {
                    dgStatistically.DataSource = dt;
                    ApplyReportViewer(dgStatistically, lblStates.Text, "AppSound.Reports.STSEXM.rdlc");
                }, new SqlParameter[] { 
                new SqlParameter{ParameterName="@stage",Value=stage}
            });
        }


        public void ApplyReportViewer(DataGridView dgv,string header,string source)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = source;
            var rds = new ReportDataSource("RSTS", dgv.DataSource);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.LocalReport.SetParameters(new ReportParameter("rpHeader", header));
           


            this.reportViewer1.RefreshReport();
        }


        private void dgStatistically_SelectionChanged(object sender, EventArgs e)
        {
            var _list = new List<int>();

            var stage = stageDrp.SelectedItem.ToString();
            if (dgStatistically.SelectedRows.Count > 0)
            {
                var dgv = dgStatistically.SelectedRows[0];
                var curr_sateCode = int.Parse(dgv.Cells[2].Value.ToString());
                var query = String.Format(@"select distinct ex_id  from states where state_code={0} and stage='{1}'", curr_sateCode, stage);
                cmd.ReaderCMD(query, _reader =>
                {
                    while (_reader.Read()) _list.Add(int.Parse(_reader.GetValue(0).ToString()));
                });
                GetStExams(_list, stage, curr_sateCode);
            }
        }


        public void GetAllExamsIds()
        {
            var _list = new List<int>();

            var stage = stageDrp.SelectedItem.ToString();
            var query = String.Format(@"select distinct s.ex_id  from states s inner join exams e on e.ex_id=s.ex_id where ex_obsv is not null");
            cmd.ReaderCMD(query, _reader =>
            {
                while (_reader.Read()) _list.Add(int.Parse(_reader.GetValue(0).ToString()));
            });

            GetAllSTSEXM(_list, stage);

            

        }

        public void GetAllSTSEXM(List<int> _list,string stage){
            var _listExs = new List<Results>();
            var i = 1;
            foreach (var item in _list)
            {
                cmd.GetCMDConnection("sp_GTSTS_Exames", _cmd =>
                {
                    _cmd.CommandType = CommandType.StoredProcedure;
                    _cmd.Parameters.AddWithValue("@stage", stage);
                    _cmd.Parameters.AddWithValue("@exam_id", item);

                    var reader = _cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        _listExs.Add(new Results
                        {
                            ID = i++,
                            Exam_id = ReturnInt(reader.GetValue(0)),
                            Name = reader.GetValue(1).ToString(),
                            Total = ReturnInt(reader.GetValue(2)),
                            Noticed = ReturnInt(reader.GetValue(3)),
                            Downfull = ReturnInt(reader.GetValue(4))
                        });
                    }
                });
            }

            dgvSTS.DataSource = _listExs;

        }
        public void GetStExams(List<int> _list, string stage, int curr_sateCode)
        {
            var _listExs = new List<Results>();
            var i = 1;
            foreach (var item in _list)
            {
                cmd.GetCMDConnection("sp_getState_Exames_by_Id", _cmd =>
                {
                    _cmd.CommandType = CommandType.StoredProcedure;
                    _cmd.Parameters.AddWithValue("@stage", stage);
                    _cmd.Parameters.AddWithValue("@stateCode", curr_sateCode);
                    _cmd.Parameters.AddWithValue("@exam_id", item);

                    var reader = _cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        _listExs.Add(new Results
                        {
                            ID=i++,
                            Exam_id = ReturnInt(reader.GetValue(0)),
                            Name = reader.GetValue(1).ToString(),
                            Total = ReturnInt(reader.GetValue(2)),
                            Noticed = ReturnInt(reader.GetValue(3)),
                            Downfull = ReturnInt(reader.GetValue(4))
                        });
                    }
                });
            }

            dgvExms.DataSource = _listExs;
        }

       
        public int ReturnInt(object value)
        {
            return int.Parse(value.ToString());
        }
        private void stageDrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoopStatesAgg();
            GetAllExamsIds();
        }

        private void StatisticalStates_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var str = String.Format("{0} - {1} ", lblStates.Text, stageDrp.SelectedItem.ToString());

            ApplyReportViewer(dgStatistically, lblStates.Text, "AppSound.Reports.STSEXM.rdlc");
        }

        private void btnExams_Click(object sender, EventArgs e)
        {
            var str = String.Format("{0} - {1} - {2}", lblExams.Text, dgStatistically.SelectedRows[0].Cells[1].Value.ToString(), stageDrp.SelectedItem.ToString());
            ApplyReportViewer(dgvExms, str, "AppSound.Reports.STSEXM_noAgg.rdlc");

        }

        private void btnTotalExams_Click(object sender, EventArgs e)
        {
            var str = String.Format("{0} - {1}", lblTotalExams.Text,  stageDrp.SelectedItem.ToString());

            ApplyReportViewer(dgvSTS, lblTotalExams.Text, "AppSound.Reports.STSEXM_noAgg.rdlc");

        }
    }
}
