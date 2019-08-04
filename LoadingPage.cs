using AppSound.Modals;
using AppSound.TagneedR;
using AppSound.TStates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSound
{
    public partial class LoadingPage : Form
    {
        SqlCommands cmd = new SqlCommands("DB_Exam_engine");
        public LoadingPage()
        {
            InitializeComponent();
            AuthenticationManager();
        }

        private void LoadingPage_Load(object sender, EventArgs e)
        {
            AuthenticationManager();
        }



       

        public void AuthenticationManager()
        {
            switch (Users.RoleName)
            {
                case "Admin":
                    mnuAuth.Visible = true; break;
                case "Nozom":
                    SSTS.Visible = false;
                    mtsDT.Visible = false;
                    mstRs.Visible = false;
                    mtsUpload.Visible = true;
                    mnuAuth.Visible = true;
                    break;
                case "Khetat":
                    SSTS.Visible = false;
                    mtsDT.Visible = false;
                    mstRs.Visible = true;
                    mtsUpload.Visible = false;
                    mnuAuth.Visible = true;
                    break;
                case "Tahlel":
                    SSTS.Visible = true;
                    mtsDT.Visible = false;
                    mstRs.Visible = false;
                    mtsUpload.Visible = false;
                    mnuAuth.Visible = true;
                    break;
              
                default:
                    mnuAuth.Visible = false; break;
            }
        }
        private void audioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void questionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ExamEngine().Show();
        }


        private void examToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void answersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AnswersDE().Show();
        }


        public void resultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // new Tagneed().Show();
        }



       




        private void tagneedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Weapons().Show();
        }

        private void stateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new States().Show();
        }

        private void resultsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new Evaluation().Show();
        }

        private void stateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void STS_Click(object sender, EventArgs e)
        {

        }

        private void STSNames_Click(object sender, EventArgs e)
        {
            new ResultsCollection().Show();
        }

        private void SSTSResults_Click(object sender, EventArgs e)
        {
            new StateReports().Show();

        }

        private void SSTSSpecificExam_Click(object sender, EventArgs e)
        {
            new States().Show();
        }

        private void Statis_Click(object sender, EventArgs e)
        {
            new StatisticalStates().Show();
        }

        private void rsexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Examined().Show();
        }

        private void syreport_Click(object sender, EventArgs e)
        {
            new StateInterview().Show();
        }

        private void exc_Click(object sender, EventArgs e)
        {
            new Exclude().Show();
        }

        private void mrz_Click(object sender, EventArgs e)
        {
            new InsertBackUps().Show();
        }

        private void tgnd_Click(object sender, EventArgs e)
        {
          // GetExams();
            new backUp().Show();
        }

        private void tstsmenu_Click(object sender, EventArgs e)
        {
            new StatisticalTagneed().Show();
        }

        private void tgcMenu_Click(object sender, EventArgs e)
        {
            new SpecificTG().Show();
        }

        private void spexMmENU_Click(object sender, EventArgs e)
        {
            new SPExam().Show();
        }

        private void expTagneed_Click(object sender, EventArgs e)
        {
            new ExportToAccess().Show();
        }

        private void compareResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CompareResuls().Show();
        }

        private void mstUpIntv_Click(object sender, EventArgs e)
        {
            new UpInterview().ShowDialog();
        }

        private void mstate_Click(object sender, EventArgs e)
        {
            new BaseInterview().Show();
        }

        private void tsdInterviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InterviewReport().Show();
        }

        private void worthyRepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new WorthyReport().Show();
        }

        private void physToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PhsicoReports().Show();
        }

        private void minterviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AppSound.TStates.Interview().Show();
        }

        private void resHeadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Examined().Show();
        }

        private void resRepStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StateReports().Show();
        }

        private void resSpecificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new States().Show();
        }

        private void resCompareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CompareResuls().Show();
        }

        private void stateInterviewRepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BaseInterview().Show();
        }

        private void sycoInterviewRepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StateInterview().Show();
        }

        private void interviewLetterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ResultsCollection().Show();
        }

        private void recoIletterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new WorthyReport().Show();
        }

        private void comLetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InterviewReport().Show();
        }

        private void letIntvComToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AppSound.TStates.Interview().Show();
        }

        private void mionRepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PhsicoReports().Show();
        }

        private void hosTransToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HospitalReport().Show();
        }

        private void armForceRsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ArmedForces().Show();
        }
    }
}
