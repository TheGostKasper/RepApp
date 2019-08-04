using AppSound.Helper;
using AppSound.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSound
{
    public partial class backUp : Form
    {
        SqlCommands cmd = new SqlCommands("DB_tagneed");
        FillComboValues fcmb = new FillComboValues();
        static List<TYouth> _list = new List<TYouth>();

        public backUp()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            cmd.ReaderCMD(@"select role_id,role_name from regionroles", _reader =>
            {
                fcmb.GetTagneedAreas(new DummyCombo { Value=2,Text="مناطق تجنيد"}, tgneedDrp);
                fcmb.GetQualificationAreas(qualiDrp);
                
               // dataGridView1.DataSource = GetTExaminers();

                InitData();

            });
        }
        private void InitData()
        {
            var query = String.Format(@"
                           select rs_exam_id 'Ex_ID',ex_name 'Name' ,mosalsal+'/'+c_mare+'/'+ Milad 'solasy',ex_year 'Stage', 
                           rs_exam_name 'Exam Name', rs_value 'Value',gv_id 'State Id', gv_name 'State',ex_barcode 'Barcode'  ,ex_qualification_code
						   from t_examiners inner join t_results on  ex_barcode = rs_barcode inner join t_governs on ex_mohafza_code = gv_id");
            cmd.Catalog = DBCatalog.DB_Nazary.ToString();
            cmd.TableCMD(query, _dt =>
            {
                dataGridView1.DataSource = _dt;
            });
            //INsertManyExaminers(_list);

            //INsertManyEXResults(GetTResults());
        }
        private void button1_Click(object sender, EventArgs e)
        {

            btnSave.Enabled = dataGridView1.Visible = false;
            var rowCount = dataGridView1.RowCount;
            progressBar1.Visible = true;
            progressBar1.Maximum = rowCount;
            progressBar1.Step = 1;
            var queryTable = "MainTagneed";

            for (int i = 0; i < rowCount; i++)
            {
                var dgv = dataGridView1.Rows[i].Cells;
                var quaDrp = (DummyCombo)qualiDrp.SelectedItem;
                var tgdDrp = (DummyCombo)tgneedDrp.SelectedItem;

                var paras = string.Format(@"insert into MainTagneed values({0},'{1}','{2}','{3}','{4}',{5},{6},{7},{8},'{9}','{10}','{12}')",
                   dgv[0].Value, dgv[1].Value, dgv[2].Value, dgv[3].Value, dgv[4].Value, dgv[5].Value, quaDrp.Value,
                   tgdDrp.Value, dgv[6].Value, dgv[7].Value, dgv[8].Value, queryTable, DateTime.UtcNow.ToShortDateString());

                progressBar1.Value = i;
                cmd.Catalog = DBCatalog.DB_Tagneed.ToString();
                if (!CheckIfExist(dgv[1].Value.ToString(), dgv[2].Value.ToString(), int.Parse(dgv[0].Value.ToString())))
                {
                    cmd.GetCMDConnection(paras, _cmd =>
                    {
                        var res = _cmd.ExecuteNonQuery();
                    });
                }
                else
                {
                    //Update(queryTable, dgv);

                }

            }
            MessageBox.Show("تم الحفظ ");
            dataGridView1.Visible = true;
            progressBar1.Visible = false;
        }


        #region Worthless
        public List<TYouth> GetTExaminers()
        {
            _list = new List<TYouth>();
            var query = String.Format(@"select ex_name , mosalsal+'/'+c_mare+'/'+ Milad 'solasy',ex_year 'Stage',gv_name from t_examiners inner join t_governs on ex_mohafza_code =gv_id");
            cmd.Catalog = DBCatalog.DB_Nazary.ToString();
            cmd.ReaderCMD(query, _reader =>
            {
                var i = 0;
                while (_reader.Read())
                {
                    _list.Add(new TYouth
                    {
                        ID = i++,
                        FullName = _reader.GetValue(0).ToString(),
                        Trible_Sequence = _reader.GetValue(1).ToString(),
                        Stage = _reader.GetValue(2).ToString(),
                        Region = _reader.GetValue(3).ToString()
                    });
                };
            });
            return _list;

        }

        public List<TYResults> GetTResults()
        {
            var _rsList = new List<TYResults>();
            var query = String.Format(@"select mosalsal+'/'+c_mare+'/'+ Milad 'solasy' ,rs_exam_id , rs_exam_name,rs_value from t_results inner join t_examiners on ex_barcode=rs_barcode");
            cmd.Catalog = DBCatalog.DB_Nazary.ToString();
            cmd.ReaderCMD(query, _reader =>
            {
                var i = 1;
                while (_reader.Read())
                {
                    _rsList.Add(new TYResults
                    {
                        ID = i++,
                        Trible_Sequence = _reader.GetValue(0).ToString(),
                        Ex_Id = int.Parse(_reader.GetValue(1).ToString()),
                        Ex_Name = _reader.GetValue(2).ToString(),
                        Rs_value = int.Parse(_reader.GetValue(3).ToString())
                    });
                };
            });
            return _rsList;

        }

        public void INsertManyExaminers(List<TYouth> _list)
        {
            var rowCount = dataGridView1.RowCount;
            cmd.Catalog = DBCatalog.DB_Tagneed.ToString();
            for (int i = 0; i < rowCount; i++)
            {
                var dgv = dataGridView1.Rows[i].Cells;
                InsertIntoTYouth(new TYouth { ID = int.Parse(dgv[0].Value.ToString()), FullName = dgv[1].Value.ToString(), Trible_Sequence = dgv[2].Value.ToString(), Stage = dgv[6].Value.ToString(), Region = dgv[3].Value.ToString() });
            }
            //foreach (var item in _list)
            //{
            //    InsertIntoTYouth(item);
            //}
        }

        public void INsertManyEXResults(List<TYResults> _rsList)
        {
            cmd.Catalog = DBCatalog.DB_Tagneed.ToString();
            foreach (var item in _rsList)
            {
                InsertIntoTYResults(item);
            }
        }

        public void InsertIntoTYouth(TYouth ty)
        {
            var exsDrp = (DummyCombo)tgneedDrp.SelectedItem;
            var qualDrp = (DummyCombo)qualiDrp.SelectedItem;

            cmd.GetCMDConnection("sp_chk_ex_insertion", _cmd =>
            {
                _cmd.CommandType = CommandType.StoredProcedure;

                _cmd.Parameters.AddWithValue("@trible_sequence", ty.Trible_Sequence);
                _cmd.Parameters.AddWithValue("@fullname", ty.FullName);
                _cmd.Parameters.AddWithValue("@stage", ty.Stage);
                _cmd.Parameters.AddWithValue("@state", exsDrp.Text);

                _cmd.Parameters.AddWithValue("@Qualification", qualDrp.Value);
                //_cmd.Parameters.AddWithValue("@Qualification", ty.ID);
                _cmd.Parameters.AddWithValue("@region", ty.Region);
                _cmd.Parameters.AddWithValue("@creation_date", DateTime.UtcNow);
                var res = _cmd.ExecuteNonQuery();
            });
        }
        public void InsertIntoTYResults(TYResults ty)
        {
            var query = String.Format(@"insert into TYouthResults values ('{0}',{1},'{2}',{3})", ty.Trible_Sequence, ty.Ex_Id, ty.Ex_Name, ty.Rs_value);
            cmd.GetCMDConnection("sp_chk_rs_insertion", _cmd =>
            {
                _cmd.CommandType = CommandType.StoredProcedure;

                _cmd.Parameters.AddWithValue("@trible_sequence", ty.Trible_Sequence);
                _cmd.Parameters.AddWithValue("@ex_Id", ty.Ex_Id);
                _cmd.Parameters.AddWithValue("@ex_Name", ty.Ex_Name);
                _cmd.Parameters.AddWithValue("@rs_value", ty.Rs_value);
                var res = _cmd.ExecuteNonQuery();
            });
        }

        #endregion
     


        private void Update(string queryTable, DataGridViewCellCollection dgv)
        {
            var query = String.Format(@"update MainTagneed set rs_value={1} where Trible_Sequence='{2}' ", queryTable, dgv[5].Value, dgv[2].Value, dgv[0].Value);
            cmd.GetCMDConnection(query, _cmd =>
            {
                var res = _cmd.ExecuteNonQuery();
            });
        }

        public bool CheckIfExist(string fullName, string trible_sequence, int ex_id)
        {
            var _rss = false;

            cmd.GetCMDConnection("DB_Tagneed",  "CheckMainTagneedIFExaminerExist", _cmd =>
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@trible_sequence", trible_sequence);
                _cmd.Parameters.AddWithValue("@ex_id", ex_id);

                var res=int.Parse(_cmd.ExecuteScalar().ToString());
                _rss = (res > 0) ? true : false;
            });
            return _rss;
        }

        private void drpRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
           InitData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = dataGridView1.Visible = false;
            var rowCount = dataGridView1.RowCount;
            progressBar1.Visible = true;
            progressBar1.Maximum = rowCount;
            progressBar1.Step = 1;

            var queryTable =  "DeleteExaminerTagneedExist" ;

            for (int i = 0; i < rowCount; i++)
            {
                var dgv = dataGridView1.Rows[i].Cells;

                progressBar1.Value = i;
                cmd.GetCMDConnection("DB_Tagneed", queryTable, _cmd =>
                {
                    _cmd.CommandType = CommandType.StoredProcedure;
                    _cmd.Parameters.AddWithValue("@barcode",  dgv[8].Value.ToString());
                    _cmd.Parameters.AddWithValue("@id", dgv[2].Value.ToString());
                    _cmd.Parameters.AddWithValue("@ex_id", int.Parse(dgv[0].Value.ToString()));

                    var res = _cmd.ExecuteNonQuery();
                });
            }

            MessageBox.Show("تم الحذف ");

            dataGridView1.Visible = true;
            progressBar1.Visible = false;
        }
    }


}
