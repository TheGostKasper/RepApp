using AppSound.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSound
{
    public class FillComboValues
    {
        SqlCommands cmd = new SqlCommands();
        public void FillCombo(List<DummyCombo> _list, ComboBox cmx)
        {
            cmx.DataSource = _list;
            cmx.DisplayMember = "Text";
            if (cmx.Items.Count > 0)
                cmx.SelectedIndex = 0;
        }
        public void GetTagneedAreas(ComboBox cmx)
        {
            var _list = new List<DummyCombo>(){
                new DummyCombo {Text="القاهرة",Value=1},
                new DummyCombo {Text="الجيزة",Value=2},
                new DummyCombo {Text="اسكندريه",Value=3},
                new DummyCombo {Text="الزقازيق",Value=4},
                new DummyCombo {Text="اسيوط",Value=5},
                new DummyCombo {Text="طنطا",Value=6},
                new DummyCombo {Text="قنا",Value=7},
                new DummyCombo {Text="المنصورة",Value=8},
                new DummyCombo {Text="المنيا",Value=9},
            };
            FillCombo(_list, cmx);
        }

        public void GetWorthyRepo(ComboBox cmx)
        {
            var _list = new List<DummyCombo>(){
                new DummyCombo {Text="اداري",Value=1},
                new DummyCombo {Text="اقتصادي",Value=2}
            };
            FillCombo(_list, cmx);
        }
        public void GetQualificationAreas(ComboBox cmx)
        {
            cmd.Catalog = DBCatalog.DB_Tagneed.ToString();
            cmd.ReaderCMD(String.Format(@"select * from qualifications"), _reader =>
            {
                FillFReader(_reader, cmx);
            });
        }
        public void GetExams(ComboBox cmx)
        {
            cmd.Catalog = DBCatalog.DB_Tagneed.ToString();
            cmd.ReaderCMD(String.Format(@"select * from exams"), _reader =>
            {
                FillFReader(_reader, cmx);
            });
        }
        public void GetInterviewers(ComboBox cmx)
        {
            cmd.Catalog = DBCatalog.DB_Tagneed.ToString();
            cmd.ReaderCMD(String.Format(@"select r.id,Username from users inner join roles r on role_id=r.id where r.role_name='User'"), _reader =>
            {
                FillFReader(_reader, cmx);
            });
        }
        public void GetStages(ComboBox cmx)
        {
            cmd.ReaderCMD("select stage from states group by stage", _reader =>
            {
                while (_reader.Read()) cmx.Items.Add(_reader.GetValue(0));
                cmx.SelectedIndex = 0;
            });
        }
       
        public void GetInterviewStages(ComboBox cmx)
        {
            cmd.ReaderCMD("select stage from interview group by stage", _reader =>
            {
                while (_reader.Read()) cmx.Items.Add(_reader.GetValue(0));
                cmx.SelectedIndex = 0;
            });
        }
        public void GetGoverns(ComboBox cmx)
        {
            cmd.ReaderCMD(String.Format(@"select * from t_governs"), _reader =>
            {
                FillFReader(_reader, cmx);
            });
        }
        public void GetObsv(ComboBox cmx)
        {
            var _list = new List<DummyCombo>(){
                new DummyCombo {Text="ملحوظ",Value=1},
                new DummyCombo {Text="مقصر",Value=2}
            };
            FillCombo(_list, cmx);
        }

        public void GetTGDObsv(ComboBox cmx)
        {
            var _list = new List<DummyCombo>(){
                new DummyCombo {Text="ملحوظ",Value=1},
                new DummyCombo {Text="طبيعي",Value=2}
            };
            FillCombo(_list, cmx);
        }
        public void FillFReader(System.Data.SqlClient.SqlDataReader _reader, ComboBox cmx)
        {
            cmx.Items.Clear();
            while (_reader.Read())
                cmx.Items.Add(new DummyCombo { Value = int.Parse(_reader.GetValue(0).ToString()), Text = _reader.GetValue(1).ToString() });
            cmx.DisplayMember = "Text";
            if (cmx.Items.Count > 0)
                cmx.SelectedIndex = 0;
        }

        public void GetReaderList(string query, ComboBox tgneedDrp)
        {
            cmd.ReaderCMD(query, _reader =>
            {
                FillFReader(_reader, tgneedDrp);
            });
        }
        public void GetTagneedAreas(DummyCombo p, ComboBox tgneedDrp)
        {
            cmd.Catalog = DBCatalog.DB_Tagneed.ToString();
            cmd.ReaderCMD(String.Format(@"select rg_id,rg_name from regions where role_id= {0}", p.Value), _reader =>
            {
                FillFReader(_reader, tgneedDrp);
            });
        }

        public void GetAreas( ComboBox tgneedDrp)
        {
            cmd.Catalog = DBCatalog.DB_Tagneed.ToString();
            cmd.ReaderCMD(String.Format(@"select rg_id,rg_name from regions where role_id in (1,3)"), _reader =>
            {
                FillFReader(_reader, tgneedDrp);
            });
        }
        public void GetDelieveredDates(ComboBox tgneedDrp, int code,string stage)
        {
            cmd.GetCMDConnection("sp_get_deliver_date", _cmd =>
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@state_code", code);
                _cmd.Parameters.AddWithValue("@stage", stage);
                FillFReader(_cmd.ExecuteReader(), tgneedDrp);
            });
        }
        public void GetExaminedDates(ComboBox tgneedDrp, int code,string stage)
        {
            cmd.GetCMDConnection("sp_get_examined_date", _cmd =>
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@state_code", code);
                _cmd.Parameters.AddWithValue("@stage", stage);
                FillFReader(_cmd.ExecuteReader(), tgneedDrp);
            });
        }
        public void GetInterviewedDates(ComboBox tgneedDrp, string stage)
        {
            cmd.GetCMDConnection("sp_get_interviewed_date", _cmd =>
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@stage", stage);
                FillFReader(_cmd.ExecuteReader(), tgneedDrp);
            });
        }
        public void GetInterviewedDates(ComboBox tgneedDrp, int code, string stage)
        {
            cmd.GetCMDConnection("sp_get_interview_date", _cmd =>
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@state_code", code);
                _cmd.Parameters.AddWithValue("@stage", stage);
                FillFReader(_cmd.ExecuteReader(), tgneedDrp);
            });
        }

        internal void getRepoTypes(ComboBox cmx)
        {
            var _list = new List<DummyCombo>(){
                new DummyCombo {Text="خطاب مقابلة",Value=1},
                new DummyCombo {Text="خطاب اعادة",Value=2}
            };
            FillCombo(_list, cmx);
        }

        internal void getResultsTypes(ComboBox cmx)
        {
            var _list = new List<DummyCombo>(){
                new DummyCombo {Text="نتيجة بالدرجات",Value=1},
                new DummyCombo {Text="نتيجة بغير الدرجات",Value=2}
            };
            FillCombo(_list, cmx);
        }

        internal void GetTagneedStages(ComboBox stageDrp)
        {
            cmd.Catalog = DBCatalog.DB_Tagneed.ToString();
            cmd.ReaderCMD("select stage from maintagneed group by stage", _reader =>
            {
                while (_reader.Read()) stageDrp.Items.Add(_reader.GetValue(0));
                stageDrp.SelectedIndex = 0;
            });
        }

        public void RTInterviewerOpnion(ComboBox cmx)
        {
            var _list = new List<DummyCombo>(){
                new DummyCombo {Text="لا يعاني من أي مشاكل",Value=1},
                new DummyCombo {Text="عرضه علي فرع الانتقاء والتوجيه",Value=2},
                new DummyCombo {Text="عرضه علي المست من قبل المركز",Value=3}
            };
            FillCombo(_list, cmx);
        }

        public void Recommendations(ComboBox cmx)
        {
            var _list = new List<DummyCombo>(){
                new DummyCombo {Text="مست أحمد جلال",Value=1},
                new DummyCombo {Text="مست كوبري القبة",Value=2}
            };
            FillCombo(_list, cmx);
        }
    }

    public class DummyCombo
    {
        public string Text { get; set; }
        public int Value { get; set; }
        public string TextValue { get; set; }

        public int Qus_Id { get; set; }

        public bool IsPic { get; set; }
    }
}
