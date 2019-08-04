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
    public partial class ExamEngine : Form
    {
        SqlCommands cmd = new SqlCommands("DB_Tagneed");
        public ExamEngine()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            cmd.TableCMD("select ex_id 'ID' , ex_name 'Name', ex_display 'Display', Ex_down 'Down', ex_Obsv 'Observable',ex_dist 'Dist' from Exams ", _dt =>
            {
                dataGridView1.DataSource = _dt;
            });
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var dgv = dataGridView1.SelectedRows[0].Cells;
                txtDown.Text = dgv[3].Value.ToString();
                txtObsv.Text = dgv[4].Value.ToString();
                txtDisplay.Text = dgv[2].Value.ToString();
                txtDist.Text = dgv[5].Value.ToString();
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var query = String.Format(@"update Exams set ex_obsv={0},ex_down={1} ,ex_display='{2}',ex_dist={4} where ex_id={3}",
                SetValues(txtObsv.Text),
                SetValues(txtDown.Text),
                txtDisplay.Text,
                dataGridView1.SelectedRows[0].Cells[0].Value,
                SetValues(txtDist.Text));

            cmd.GetCMDConnection(query, _cmd =>
                {
                   var results= (_cmd.ExecuteNonQuery()>0)?"saved successfully":"Nothing Updated";
                   var dgv = dataGridView1.SelectedRows[0].Cells;
                   dgv[4].Value = SetValues(txtObsv.Text);
                   dgv[3].Value = (txtDown.Text);
                   dgv[2].Value = txtDisplay.Text;
                   dgv[5].Value = SetValues(txtDist.Text);
               
                   MessageBox.Show(results);
                });
        }

        public object SetValues(string val)
        {
            return (val == "") ? 0 :int.Parse( val);
        }
    }
}
