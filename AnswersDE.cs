using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSound
{
    public partial class AnswersDE : Form
    {
        Audio audio = new Audio();
        SqlCommands cmd = new SqlCommands("DB_Exam_engine");
        FillComboValues fcmb = new FillComboValues();
        public AnswersDE()
        {
            InitializeComponent();
            Init();
            timer1.Start();
        }


        void Init()
        {
            cmd.TableCMD(@"select qus_text,ans_id, ans_text , ans_value 'Value'  from t_answers inner join t_questions on qus_id=ans_qus_id
                            ", td => { dataGridView1.DataSource = td; });
            GetExams();
        }
        public void GetExams()
        {
            cmd.ReaderCMD(@"select exm_id, Exm_name from t_exams", rd =>
            {
                fcmb.FillFReader(rd, drpExams);
            });
        }
        private void button1_Click(object sender, EventArgs e)
        {
            audio.Record();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                var dgc = dataGridView1.SelectedRows[0].Cells;
                audio.CloseRecord(dgc[1].Value.ToString());
                var filePath = String.Format(@"C:\app\testDemo.mp3", dgc[1].Value.ToString());
                var player = new System.Media.SoundPlayer(filePath);
                player.Play();
                UpdateQuestionAudio(int.Parse(dgc[1].Value.ToString()), File.ReadAllBytes(filePath));
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void drpExams_SelectedValueChanged(object sender, EventArgs e)
        {
            var value =(DummyCombo) drpExams.SelectedItem;
            cmd.TableCMD(String.Format(@"select qus_text,ans_id,qus_id, ans_text ,ans_value  'Value'  from t_answers inner join t_questions on qus_id=ans_qus_id
                            where ans_qus_id in (select qus_id from t_questions where qus_exm_id={0})
                            ", value.Value), td => { dataGridView1.DataSource = td; });
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                qus_image.Image = null;
                var dgc = dataGridView1.SelectedRows[0].Cells;
                txtExam.Text = dgc[2].Value.ToString();
                GetAudioFile(int.Parse(dgc[1].Value.ToString()));
            }
        }
        public void GetAudioFile(int qId)
        {
            cmd.ReaderCMD(String.Format(@"select ans_audio , ans_image from t_answers where ans_id={0}", qId),
           _reader =>
           {

               while (_reader.Read())
               {
                   audio.Read(_reader.GetValue(0));
                   var img = _reader.GetValue(1);
                   if (img != null && !String.IsNullOrEmpty(img.ToString()))
                       using (var s = new MemoryStream((byte[])img))
                       {
                           qus_image.Image = Image.FromStream(s);
                       }
               }
           });
        }
        public void UpdateQuestionAudio(int ques_id, byte[] audioByte)
        {
            cmd.GetCMDConnection(String.Format("update t_answers set ans_audio = @audio where ans_id = {1}", audioByte, ques_id), _cmd =>
            {
                var param = _cmd.Parameters.Add("@audio", SqlDbType.VarBinary).Value = audioByte;
                var ret = _cmd.ExecuteNonQuery();
                if (ret > 0) dataGridView1.SelectedRows[0].Cells[3].Value = " يوجد ملف صوت";
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var results = openFileDialog1.ShowDialog();
            if (results == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                qus_image.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {

            cmd.GetCMDConnection(String.Format(@"update t_answers set ans_image = @image where ans_id = {0}", int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString())), _cmd =>
            {
                var param = _cmd.Parameters.Add("@image", SqlDbType.VarBinary).Value = File.ReadAllBytes(openFileDialog1.FileName);
                var ret = _cmd.ExecuteNonQuery();
                if (ret > 0) MessageBox.Show("تم الحفظ");
            });
        }

       
    }
}
