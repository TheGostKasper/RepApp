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
    public partial class CompareResuls : Form
    {
        SqlCommands cmd = new SqlCommands("db_tagneed");
        public CompareResuls()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var currSold = new List<T_Examiners>();
            var institute = new List<TResults>();
            var states = new List<TResults>();

            cmd.GetCMDConnection("sp_compare_info_state", _cmd =>
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@sold_id", txtsold.Text);

                var _reader = _cmd.ExecuteReader();
                while (_reader.Read())
                {
                    currSold.Add(new T_Examiners
                    {
                        Sold_Id = txtsold.Text,
                        FullName = _reader.GetValue(1).ToString(),
                        Region = _reader.GetValue(4).ToString(),
                        State = _reader.GetValue(3).ToString()
                    });


                    states.Add(new TResults
                    {
                        ID = int.Parse(_reader.GetValue(0).ToString()),
                        Ex_name = _reader.GetValue(5).ToString(),
                        Rs_results = int.Parse(_reader.GetValue(6).ToString().Split('.')[0]),
                        Rs_date = DateTime.Parse(_reader.GetValue(7).ToString()).ToShortDateString()
                    });
                }
                _reader.Close();
            });

            cmd.GetCMDConnection("sp_compare_info_institute", _cmd =>
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@sold_id", txtsold.Text);

                var _reader = _cmd.ExecuteReader();
                while (_reader.Read())
                {
                    institute.Add(new TResults
                    {
                        ID = int.Parse(_reader.GetValue(0).ToString()),
                        Ex_name = _reader.GetValue(5).ToString(),
                        Rs_results = int.Parse(_reader.GetValue(6).ToString().Split('.')[0]),
                        Rs_date =DateTime.Parse( _reader.GetValue(7).ToString()).ToShortDateString()
                    });
                }
                _reader.Close();
            });


            var BasicInfo = new ReportDataSource("BasicInfo", currSold);
            var stateResults = new ReportDataSource("stateResults", states);
            var InstituteResults = new ReportDataSource("InstituteResults", institute);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(BasicInfo);
            reportViewer1.LocalReport.DataSources.Add(stateResults);
            reportViewer1.LocalReport.DataSources.Add(InstituteResults);

            this.reportViewer1.RefreshReport();
        }

        private void CompareResuls_Load(object sender, EventArgs e)
        {

        }



    }
}
