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

namespace AppSound
{
    public partial class HospitalReport : Form
    {
        FillComboValues fcmb = new FillComboValues();
        SqlCommands cmd = new SqlCommands("DB_Tagneed");
        _helper _hel = new _helper();

        public HospitalReport()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            fcmb.Recommendations(drpRepo);
        }



        public void GetReports()
        {
            BindToObservablesExaminerseport();
        }


        public void BindToObservablesExaminerseport()
        {

            var drpType = (DummyCombo)drpRepo.SelectedItem;
            var cmbList = new List<DummyCombo>();

            var spSrc = (drpType.Value == 1) ? "AppSound.Reports.galalReport.rdlc" : "AppSound.Reports.kobbaReport.rdlc";
            cmbList.Clear();
            if (drpType.Value == 2)
            {
                cmbList.Add(new DummyCombo { Text = "hopCdn", TextValue = txtComplain.Text });
            }
            cmbList.Add(new DummyCombo { Text = "edara", TextValue = txtEdara.Text });
            _hel.SetReportConfigurationedTable(reportViewer2, spSrc, "ObsvTot", "sp_get_interviewed_Soldidres",
                new SqlParameter[]{
                            new SqlParameter {  ParameterName = "@sold_id", Value = txtSoldId.Text }
                }, cmbList.ToArray<DummyCombo>());
        }

        private void tgneedDrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            // GetReports();
        }

        private void StateReports_Load(object sender, EventArgs e)
        {

            this.reportViewer2.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindToObservablesExaminerseport();
        }

        private void drpRepo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var drpType = (DummyCombo)drpRepo.SelectedItem;
            if (drpType.Value == 1)
            {
                 txtComplain.Visible =  label3.Visible = false;
            }
            else
            {
                 txtComplain.Visible =  label3.Visible = true;
            }
        }
    }
}
