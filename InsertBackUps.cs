using AppSound.Helper;
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
    public partial class InsertBackUps : Form
    {
        SqlCommands cmd = new SqlCommands("DB_Tagneed");
        FillComboValues fcmb = new FillComboValues();
        public InsertBackUps()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            cmd.ReaderCMD(@"select role_id,role_name from regionroles", _reader =>
            {
                fcmb.GetAreas( tgneedDrp);
                InitData();
            });
        }
        private void InitData()
        {
            var query = String.Format(@"
                            select rs_exam_id 'Ex_ID',ex_name 'Name' , sold_id 'Sold_id',ex_year+ex_stage 'Stage', 
                           rs_exam_name 'Exam Name', rs_value 'Value',gv_id 'State Id', gv_name 'State',ex_barcode 'Barcode'  ,ex_qualification_code,rs_saving_date
						   from t_examiners inner join t_results on  ex_barcode = rs_barcode inner join t_governs on ex_mohafza_code = gv_id");
            cmd.Catalog = "db_core";
            cmd.TableCMD(query, _dt =>
            {
                dataGridView1.DataSource = _dt;
            });
        }
        private void button1_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = dataGridView1.Visible = false;
            var rowCount = dataGridView1.RowCount;
            progressBar1.Visible = true;
            progressBar1.Maximum = rowCount;
            progressBar1.Step = 1;
            cmd.Catalog = DBCatalog.DB_Nazary.ToString();
            for (int i = 0; i < rowCount; i++)
            {
                var dgv = dataGridView1.Rows[i].Cells;
                var tgdDrp = (DummyCombo)tgneedDrp.SelectedItem;

                var paras = string.Format(@"insert into states values({0},'{1}','{2}','{3}','{4}',{5},{6},{7},{8},'{9}','{10}','{11}',NULL,'{12}')",
                   dgv[0].Value, dgv[1].Value, dgv[2].Value, dgv[3].Value, dgv[4].Value, dgv[5].Value, dgv[9].Value,
                   tgdDrp.Value, dgv[6].Value, dgv[7].Value, dgv[8].Value, DateTime.UtcNow.ToShortDateString(), dgv[10].Value.ToString());

                progressBar1.Value = i;


                if (!CheckIfExist(dgv[1].Value.ToString(), dgv[2].Value.ToString(), Convert.ToInt32(dgv[5].Value), Convert.ToInt32(dgv[0].Value), dgv[10].Value.ToString()))
                {
                    cmd.GetCMDConnection(paras, _cmd =>
                    {
                        var res = _cmd.ExecuteNonQuery();
                    });
                }
                else
                {
                    Update( dgv); 
                }
                    
            }
            MessageBox.Show("تم الحفظ ");
            dataGridView1.Visible = true;
            progressBar1.Visible = false;
        }

        private void Update( DataGridViewCellCollection dgv)
        {
            var query = String.Format(@"update states set rs_value={0} , updated_date='{3}' where sold_id='{1}' and ex_id={2}", dgv[5].Value, dgv[2].Value, dgv[0].Value,DateTime.UtcNow.ToShortDateString());
            cmd.GetCMDConnection(query, _cmd =>
            {
                var res = _cmd.ExecuteNonQuery();
            });
        }

        public bool CheckIfExist(string fullName, string barcode,int value, int ex_id, string rs_saving_date)
        {
            var _rss = false;
            var queryTable =  "CheckStatesIFExaminerExist";


            cmd.GetCMDConnection("DB_Tagneed",  queryTable, _cmd =>
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@barcode", barcode);
                _cmd.Parameters.AddWithValue("@fullname", fullName);
                _cmd.Parameters.AddWithValue("@rs_value", value);
                _cmd.Parameters.AddWithValue("@ex_id", ex_id);
                _cmd.Parameters.AddWithValue("@rs_saving_date", rs_saving_date);

                _rss = (int.Parse(_cmd.ExecuteScalar().ToString()) > 0) ? true : false;
            });
            return _rss;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = dataGridView1.Visible = false;
            var rowCount = dataGridView1.RowCount;
            progressBar1.Visible = true;
            progressBar1.Maximum = rowCount;
            progressBar1.Step = 1;

            var queryTable = (cmd.Catalog == "DB_Nazary") ? "DeleteExaminerTagneedExist" : "DeleteExaminerStateExist";

            for (int i = 0; i < rowCount; i++)
            {
                var dgv = dataGridView1.Rows[i].Cells;

                progressBar1.Value = i;
                cmd.GetCMDConnection("DB_Tagneed", queryTable, _cmd =>
                {
                    _cmd.CommandType = CommandType.StoredProcedure;
                    _cmd.Parameters.AddWithValue("@barcode",  dgv[8].Value.ToString());
                    _cmd.Parameters.AddWithValue("@sold_id", dgv[2].Value.ToString());
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
