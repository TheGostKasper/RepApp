using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSound
{
    public partial class Form1 : Form
    {
        Audio audio = new Audio();
        SqlCommands cmd = new SqlCommands("DB_Exam_engine");
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            cmd.TableCMD(@"select exm_id, qus_id ID, qus_text 'Text', (select ' يوجد ملف صوت' where qus_audio is not null ) 'Value'  from t_questions q inner join t_exams t on q.Qus_Exm_ID = t.Exm_ID
                            ", td => { dataGridView1.DataSource = td; });
            GetExams();
        }
        public void GetExams()
        {
            cmd.ReaderCMD(@"select Exm_name from t_exams", rd =>
            {
                while (rd.Read())
                    drpExams.Items.Add(rd.GetValue(0).ToString());

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
            var value = drpExams.SelectedItem.ToString();
            cmd.TableCMD(String.Format(@"select exm_id, qus_id ID, qus_text 'Text', (select ' يوجد ملف صوت' where qus_audio is not null ) 'Value' from t_questions q inner join t_exams t 
                            on q.Qus_Exm_ID = t.Exm_ID where exm_name like '%{0}%'
                            ", value), td => { dataGridView1.DataSource = td; });
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    qus_image.Image = null;
                    var dgc = dataGridView1.SelectedRows[0].Cells;
                    txtExam.Text = dgc[2].Value.ToString();
                    GetAudioFileData(int.Parse(dgc[0].Value.ToString()));
                    GetAudioFile(int.Parse(dgc[1].Value.ToString()));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
              
            }
        }

        public void GetAudioFileData(int examId)
        {
            //            cmd.ReaderCMD(String.Format(@"select cat_name , exm_name , exm_display_name , exm_duration_in_mins from t_exams 
            //                                                    inner join t_Categories on cat_id=exm_cat_id where exm_id={0}", examId),
            //            _reader =>
            //            {
            //                while (_reader.Read())
            //                {
            //                    txtCat.Text = _reader.GetValue(0).ToString();
            //                    txtExm.Text = _reader.GetValue(1).ToString();
            //                    txtDisplay.Text = _reader.GetValue(2).ToString();
            //                    txtDuration.Text = _reader.GetValue(3).ToString();
            //                }

            //            });
        }

        public void GetAudioFile(int qId)
        {
            cmd.ReaderCMD(String.Format(@"select qus_audio , Qus_image from t_questions where qus_id={0}", qId),
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
            cmd.GetCMDConnection(String.Format("update t_questions set qus_audio = @audio where qus_id = {1}", audioByte, ques_id), _cmd =>
            {
                var param = _cmd.Parameters.Add("@audio", SqlDbType.VarBinary).Value = audioByte;
               var ret= _cmd.ExecuteNonQuery();
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

            cmd.GetCMDConnection(String.Format(@"update t_questions set qus_image = @image where qus_id = {0}",int.Parse( dataGridView1.SelectedRows[0].Cells[1].Value.ToString())), _cmd =>
            {
                var param = _cmd.Parameters.Add("@image", SqlDbType.VarBinary).Value = File.ReadAllBytes(openFileDialog1.FileName);
               var ret= _cmd.ExecuteNonQuery();
               if (ret > 0) MessageBox.Show("تم الحفظ");
            });
        }



    }
}
