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
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;
namespace AppSound.TStates
{
    public partial class Interview : Form
    {
        SqlCommands cmd = new SqlCommands("db_tagneed");
        public Interview()
        {
            InitializeComponent();
        }

        private void Interview_Load(object sender, EventArgs e)
        {
           // this.reportViewer1.RefreshReport();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtsold.Text.Length == 13)
            {
                cmd.SPDataTable("sp_get_interview_info", _dt =>
                {
                    if (_dt.Rows.Count > 0)
                    {
                        var rds = new ReportDataSource("Interview", _dt);
                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(rds);
                        this.reportViewer1.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("تأكد من الرقم العسكري مرة أخري");
                    }
                   

                },new SqlParameter[]{
                new SqlParameter{ParameterName="@sold_id",Value=txtsold.Text}
                });
            }
            else
            {
                MessageBox.Show("تأكد من الرقم العسكري مرة أخري");
            }
           
        }

      
    }
}
