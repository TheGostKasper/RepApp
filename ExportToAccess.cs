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
    public partial class ExportToAccess : Form
    {
        FillComboValues fcmb = new FillComboValues();
        SqlCommands cmd = new SqlCommands("DB_Tagneed");
        AccCommand acc = new AccCommand();
        public ExportToAccess()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            fcmb.GetTagneedAreas(new DummyCombo { Text = "مناطق تجنيد", Value = 2 }, drpTagneed);
            GetStages();
            fcmb.GetQualificationAreas(drpQualification);
            //GetData();
        }
        private void GetStages()
        {
            cmd.ReaderCMD("select stage from maintagneed group by stage", _reader =>
            {
                while (_reader.Read()) stageDrp.Items.Add(_reader.GetValue(0));
                stageDrp.SelectedIndex = 0;
            });
        }

        private void GetData()
        {
            var query = String.Format(@"select row_number() over(order by id) ,* from maintagneed");
            cmd.TableCMD(query, _dt =>
            {
                dataGridView1.DataSource = _dt;
            });
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                var rowCount = dataGridView1.Rows.Count;
                progressBar1.Maximum = rowCount;
                progressBar1.Step = 1;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    var query = String.Format(@"insert into enteqa_fahs_d values (@milad,@c_mar1,@mosalsal,@c_fahs,@v_fahs,@reads_no,@natega1,@natega2,@natega3,@trials_no,@test_trials)");
                    acc.GetCallBackRow(query, _cmd =>
                    {


                        var _list = dataGridView1.Rows[i].Cells;
                        var solasy = _list[4].Value.ToString().Split('/');

                        _cmd.Parameters.AddWithValue("@milad", int.Parse(solasy[2].ToString()));
                        _cmd.Parameters.AddWithValue("@c_mar1", int.Parse(solasy[1].ToString()));
                        _cmd.Parameters.AddWithValue("@mosalsal", int.Parse(solasy[0].ToString()));

                        _cmd.Parameters.AddWithValue("@c_fahs", int.Parse(_list[2].Value.ToString()));
                        _cmd.Parameters.AddWithValue("@v_fahs", _list[6].Value.ToString());

                        _cmd.Parameters.AddWithValue("@reads_no", 0);

                        _cmd.Parameters.AddWithValue("@natega1", int.Parse(_list[7].Value.ToString()));
                        _cmd.Parameters.AddWithValue("@natega2", 0);
                        _cmd.Parameters.AddWithValue("@natega3", 0);

                        _cmd.Parameters.AddWithValue("@trials_no", int.Parse(_list[12].Value.ToString()));
                        _cmd.Parameters.AddWithValue("@test_trials", "");


                        var ret = _cmd.ExecuteNonQuery();
                        if (ret == 0) MessageBox.Show("Fucking shit it happened again");
                        else
                        {
                            progressBar1.Value = i;
                        }

                    });
                }
                MessageBox.Show("تم الحفظ بنجاح");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void drpTagneed_SelectedValueChanged(object sender, EventArgs e)
        {
            var quf = (DummyCombo)drpQualification.SelectedItem;
            var tgd = (DummyCombo)drpTagneed.SelectedItem;
            var stgDrp = stageDrp.SelectedItem;


            if ( quf != null  && stgDrp != null && tgd != null )
            {
                var query = String.Format(@"select row_number() over(order by id) ,* from maintagneed where stage='{0}' and qualification_no={1} and tagneed_code={2}",stgDrp,quf.Value,tgd.Value);
                cmd.TableCMD(query, _dt =>
                {
                    dataGridView1.DataSource = _dt;
                    txtnameSrch.Text = "";
                });
            }
        }

        private void txtnameSrch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var quf = (DummyCombo)drpQualification.SelectedItem;
            var tgd = (DummyCombo)drpTagneed.SelectedItem;
            var stgDrp = stageDrp.SelectedItem;

            if (quf != null && stgDrp != null && tgd != null)
            {
                var query = String.Format(@"select row_number() over(order by id) ,* from maintagneed where stage='{0}' and qualification_no={1} and tagneed_code={2} and (fullname like '%{3}%' or trible_sequence like '%{3}%' or ex_name like '%{3}%') ", stgDrp, quf.Value, tgd.Value, txtnameSrch.Text);
                cmd.TableCMD(query, _dt =>
                {
                    dataGridView1.DataSource = _dt;
                });
            }
        }

        private void btnTagneedPull_Click(object sender, EventArgs e)
        {
            var tgd = (DummyCombo)drpTagneed.SelectedItem;
            var stgDrp = stageDrp.SelectedItem;

            if (stgDrp != null && tgd != null)
            {
                var query = String.Format(@"select row_number() over(order by id) ,* from maintagneed where stage='{0}' and  tagneed_code={1} and (fullname like '%{2}%' or trible_sequence like '%{2}%' or ex_name like '%{2}%') ", stgDrp, tgd.Value, txtnameSrch.Text);
                cmd.TableCMD(query, _dt =>
                {
                    dataGridView1.DataSource = _dt;
                });
            }
        }
    }
}
