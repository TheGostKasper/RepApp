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
    public partial class StatisticalTagneed : Form
    {
        SqlCommands cmd = new SqlCommands(DBCatalog.DB_Tagneed.ToString());
        FillComboValues fcmb = new FillComboValues();

        public StatisticalTagneed()
        {
            InitializeComponent();
            GetStages();
        }



        public void GetStages()
        {
            cmd.ReaderCMD("select stage from maintagneed group by stage", _reader =>
            {
                while (_reader.Read()) stageDrp.Items.Add(_reader.GetValue(0));
                stageDrp.SelectedIndex = 0;
            });
        }
        public void LoopStatesAgg()
        {
            var _list = new List<Object>();
            var stage = stageDrp.SelectedItem;
            if (stage != null)
                cmd.SPDataTable("sp_getTagneed_Agg_by_Id", dt =>
                {
                    dgStatistically.DataSource = dt;
                    SetToReport<object, string>("AppSound.Reports.STSEXM.rdlc", String.Format(@"احصائية عددية لمناطق التجنيد لجميع الفئات - مرحلة {0}", stage), dt, "RSTS");
                }, new SqlParameter[] { 
                new SqlParameter{ParameterName="@stage",Value=stage}
            });
        }
        public void LoopTGQFSAgg()
        {
            var stage = stageDrp.SelectedItem;
            if (stage != null)
                cmd.SPDataTable("sp_quf_tgd_Agg", dt =>
                {
                    SetToReport<object, string>("AppSound.Reports.QUFTG.rdlc", String.Format(@"احصائية عددية لكل فئة علي حدي - مرحلة {0}", stage), dt, "QUF");
                }, new SqlParameter[] { 
                new SqlParameter{ParameterName="@stage",Value=stage}
            });
        }


        private void dgStatistically_SelectionChanged(object sender, EventArgs e)
        {
            var _list = new List<int>();

            var stage = stageDrp.SelectedItem.ToString();
            if (dgStatistically.SelectedRows.Count > 0)
            {
                var dgv = dgStatistically.SelectedRows[0];
                var curr_sateCode = int.Parse(dgv.Cells[2].Value.ToString());
                var query = String.Format(@"select distinct ex_id  from maintagneed where tagneed_code={0} and stage='{1}'", curr_sateCode, stage);
                cmd.ReaderCMD(query, _reader =>
                {
                    while (_reader.Read()) _list.Add(int.Parse(_reader.GetValue(0).ToString()));
                });
                GetStExams(_list, stage, curr_sateCode);
            }
        }


        public List<Results> GetAllExamsIds()
        {
            var _list = new List<int>();

            var stage = stageDrp.SelectedItem.ToString();
            var query = String.Format(@"select distinct ex_id  from maintagneed");
            cmd.ReaderCMD(query, _reader =>
            {
                while (_reader.Read()) _list.Add(int.Parse(_reader.GetValue(0).ToString()));
            });

            return GetAllSTSEXM(_list, stage);
        }

        public List<Results> GetAllSTSEXM(List<int> _list, string stage)
        {
            var _listExs = new List<Results>();
            var i = 1;
            foreach (var item in _list)
            {
                cmd.GetCMDConnection("sp_GTSTS_Exames_tagneed", _cmd =>
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

            return _listExs.ToList();

        }
        public void GetStExams(List<int> _list, string stage, int curr_sateCode)
        {
            var _listExs = new List<Results>();
            var i = 1;
            foreach (var item in _list)
            {
                cmd.GetCMDConnection("sp_getTagneed_Exames_by_Id", _cmd =>
                {
                    _cmd.CommandType = CommandType.StoredProcedure;
                    _cmd.Parameters.AddWithValue("@stage", stage);
                    _cmd.Parameters.AddWithValue("@tagneedCode", curr_sateCode);
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
            //LoopTGQFSAgg();
        }

        private void StatisticalStates_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var str = String.Format("{0} - {1} ", lblStates.Text, stageDrp.SelectedItem.ToString());
            SetToReport<object, string>("AppSound.Reports.STSEXM.rdlc", str, dgStatistically.DataSource, "RSTS");
            lblNo.Text = "1";
        }

        private void btnExams_Click(object sender, EventArgs e)
        {
            var str = String.Format("{0} - {1} - {2}", "احصائية عددية للاختبارات المستخدمة لمنطقة تجنيد", dgStatistically.SelectedRows[0].Cells[1].Value.ToString(), stageDrp.SelectedItem.ToString());
            SetToReport<object, string>("AppSound.Reports.STSEXM_noAgg.rdlc", str, dgvExms.DataSource, "RSTS");
            lblNo.Text = "3";

        }

        private void btnTotalExams_Click(object sender, EventArgs e)
        {
            SetToReport<object, string>("AppSound.Reports.STSEXM_noAgg.rdlc", String.Format(@"احصائية عددية للاختبارات المستخدمة لجميع مناطق التجنيد - مرحلة {0}", stageDrp.SelectedItem.ToString()), GetAllExamsIds(), "RSTS");
            lblNo.Text = "4";

        }

        private void btnQual_Click(object sender, EventArgs e)
        {
            LoopTGQFSAgg();
            lblNo.Text = "2";

        }

        private void btnMFM_Click(object sender, EventArgs e)
        {
            var stage = stageDrp.SelectedItem;
            cmd.SPDataTable("sp_qualification_ncd", dt =>
            {
                SetToReport<object, string>("AppSound.Reports.STSEXM_noAgg.rdlc", String.Format(@"احصائية عددية للاختبارات المستخدمة لجميع الفئات بمناطق التجنيد- مرحلة {0}", stage), dt, "RSTS");
            }, new SqlParameter[] { 
                new SqlParameter{ParameterName="@stage",Value=stage}
            });

            lblNo.Text = "5";
        }

        private void btnQufExms_Click(object sender, EventArgs e)
        {
            var stage = stageDrp.SelectedItem;
            cmd.GetCMDConnection("sp_exms_ncd", _cmd =>
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@stage", stage);
                var dt = new DataTable();
                var oldb = new SqlDataAdapter(_cmd);
                oldb.Fill(dt);
                SetToReport<object, string>("AppSound.Reports.QUFEXM_noAgg.rdlc", String.Format(@"احصائية عددية بالاختبارات النظرية لجميع الفئات بمناطق التجنيد - الملحوظين - مرحلة {0}", stage), dt, "DSTS");
            });
            lblNo.Text = "6";

        }



        public void SetToReport<T, Y>(string reportName, string header, T src, Y ds)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = reportName;

            var rds = new ReportDataSource(ds.ToString(), src);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.LocalReport.SetParameters(new ReportParameter("rpHeader", header));


            this.reportViewer1.RefreshReport();
        }

        private void btnTGd_Click(object sender, EventArgs e)
        {
            var stage = stageDrp.SelectedItem;


            cmd.SPDataTable("sp_exmsTGD_ncd", dt =>
            {
                SetToReport<object, string>("AppSound.Reports.TGEXMS_noAgg.rdlc", String.Format(@"احصائية عددية بالاختبارات النظرية لجميع مناطق التجنيد - الملحوظين - مرحلة {0}", stage), dt, "DSTS");
            }, new SqlParameter[] { 
                new SqlParameter{ParameterName="@stage",Value=stage}
            });

            lblNo.Text = "7";

        }
    }
}
