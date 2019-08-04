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

namespace AppSound.TStates
{
    public partial class UpInterview : Form
    {
        SqlCommands cmd = new SqlCommands("DB_Tagneed");
        FillComboValues fcmb = new FillComboValues();

        public UpInterview()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            cmd.ReaderCMD(@"select role_id,role_name from regionroles", _reader =>
            {
                fcmb.GetAreas(tgneedDrp);
                InitData();
            });
        }
        private void InitData()
        {
            var query = String.Format(@"select n.*,ex_name from interview n  inner join t_examiners x on n.sold_id=x.sold_id");
            cmd.Catalog = DBCatalog.DB_Core.ToString();
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

               var query = string.Format(@"insert into interview values('{0}','{1}',{2},'{3}','{4}','{5}',
                                                                         '{6}','{7}','{8}','{9}','{10}',
                                                                         '{11}','{12}','{13}','{14}','{15}',
                                                                         '{16}', '{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}')",
                   dgv[1].Value, dgv[2].Value, int.Parse(dgv[3].Value.ToString()), dgv[4].Value, dgv[5].Value,
                   dgv[6].Value, dgv[7].Value, dgv[8].Value,dgv[9].Value, dgv[10].Value.ToString(),
                   int.Parse(dgv[11].Value.ToString()), dgv[12].Value, dgv[13].Value, dgv[14].Value, dgv[15].Value,
                   dgv[16].Value, dgv[17].Value,dgv[18].Value, dgv[19].Value, dgv[20].Value,
                   dgv[21].Value, dgv[22].Value, dgv[23].Value, tgdDrp.Value, DateTime.Now.ToShortDateString(), dgv[26].Value,dgv[25].Value);


                progressBar1.Value = i;


                if (!CheckIfExist(dgv[1].Value.ToString()))
                {
                    cmd.GetCMDConnection(query, _cmd =>
                    {
                        var res = _cmd.ExecuteNonQuery();
                    });
                }
                else
                {
                    //Update(dgv);
                }

            }
            MessageBox.Show("تم الحفظ ");
            dataGridView1.Visible = true;
            progressBar1.Visible = false;
        }

        private void Update(DataGridViewCellCollection dgv)
        {
            var query = string.Format(@"update interview set  age={2},qualification='{5}'",
                   dgv[1].Value, dgv[2].Value, int.Parse(dgv[3].Value.ToString()), dgv[4].Value, dgv[5].Value,
                   dgv[6].Value, dgv[7].Value, dgv[8].Value, dgv[9].Value, dgv[10].Value.ToString(),
                   dgv[11].Value, dgv[12].Value, dgv[13].Value, dgv[14].Value, dgv[15].Value,
                   dgv[16].Value, dgv[17].Value, dgv[18].Value, dgv[19].Value, dgv[20].Value,
                   dgv[21].Value, dgv[22].Value);

            cmd.GetCMDConnection(query, _cmd =>
            {
                var res = _cmd.ExecuteNonQuery();
            });
        }

        public bool CheckIfExist(string sold_id)
        {
            var _rss = false;
            var queryTable = String.Format("select count(*) from interview where sold_id='{0}'", sold_id);

            cmd.GetCMDConnection("DB_Tagneed", queryTable, _cmd =>
            {
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
                    _cmd.Parameters.AddWithValue("@barcode", dgv[8].Value.ToString());
                    _cmd.Parameters.AddWithValue("@sold_id", dgv[2].Value.ToString());
                    _cmd.Parameters.AddWithValue("@ex_id", int.Parse(dgv[0].Value.ToString()));

                    var res = _cmd.ExecuteNonQuery();
                });
            }

            MessageBox.Show("تم الحذف ");

            dataGridView1.Visible = true;
            progressBar1.Visible = false;
        }
        private void tgneedDrp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
