using AppSound.Modals;
using Microsoft.Reporting.WinForms;
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
    public partial class WorthyReport : Form
    {
        SqlCommands cmd = new SqlCommands("db_tagneed");
        List<T_Examiners> currSold = new List<T_Examiners>();
        FillComboValues fcmb = new FillComboValues();
        public WorthyReport()
        {
            InitializeComponent();
            fcmb.GetWorthyRepo(repType);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var rtp = (DummyCombo)repType.SelectedItem;

            if (rtp.Value == 1)
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "AppSound.Reports.worthRep_sec.rdlc" ;
            }
            else
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "AppSound.Reports.worthRep.rdlc";
                reportViewer1.LocalReport.SetParameters(new ReportParameter("interviwerOpnion", txtOpnion.Text));
                
            }

            reportViewer1.LocalReport.SetParameters(new ReportParameter("stateImg", txtDest.Text));

            var BasicInfo = new ReportDataSource("ObsvTot", currSold);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(BasicInfo);
           

            this.reportViewer1.RefreshReport();
        }

        private void CompareResuls_Load(object sender, EventArgs e)
        {

        }

        private void txtsold_Leave(object sender, EventArgs e)
        {
           
            var query = String.Format(@"select distinct sold_id,fullname,rg_name from states inner join regions on rg_id=state_code where sold_id='{0}' ", txtsold.Text);

            cmd.GetCMDConnection(query, _cmd =>
            {
                var i = 1;
                var _reader = _cmd.ExecuteReader();
                if (!_reader.HasRows) MessageBox.Show("تأكد من الرقم العسكري");
                currSold.Clear();
                while (_reader.Read())
                {
                    currSold.Add(new T_Examiners
                    {
                        ID = i++,
                        Sold_Id = _reader.GetValue(0).ToString(),
                        FullName = _reader.GetValue(1).ToString(),
                        State = _reader.GetValue(2).ToString()
                    });
                }
                _reader.Close();
            });
        }



    }
}
