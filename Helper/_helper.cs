using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSound.Helper
{

    public class _helper
    {
        FillComboValues fcmb;
        SqlCommands cmd;

        public _helper()
        {
            fcmb = new FillComboValues();
            cmd = new SqlCommands("DB_Tagneed");
        }

        /// <summary>
        /// Congiuration Function To get DATASOURCE as a synamic return from StoredProcedures as a return of DATATable 
        /// </summary>
        /// <param name="_repViewer"></param>
        /// <param name="reportSrc"></param>
        /// <param name="dataSrc"></param>
        /// <param name="spQuery"></param>
        /// <param name="_sqlParams"></param>
        /// <param name="_dumParameters"></param>
        public void SetReportConfigurationedTable(ReportViewer _repViewer, string reportSrc, string dataSrc, string spQuery,  SqlParameter[] _sqlParams, params DummyCombo[] _dumParameters)
        {

            cmd.SPDataTable(spQuery, _dt =>
            {
                _repViewer.LocalReport.ReportEmbeddedResource = reportSrc;

                var rds = new ReportDataSource(dataSrc, _dt);
               
                foreach (var item in _dumParameters)
                {
                    _repViewer.LocalReport.SetParameters(new ReportParameter(item.Text, item.TextValue));

                }
                _repViewer.LocalReport.DataSources.Clear();
                _repViewer.LocalReport.DataSources.Add(rds);

                _repViewer.RefreshReport();
            }, _sqlParams);
        }

        /// <summary>
        /// Get Basic Info of a report as a return of DATAREADER List<Examiner>  
        /// </summary>
        /// <param name="_reader"></param>
        /// <param name="basicInfo"></param>
        /// <returns></returns>
        public List<Examiner> SetFuncConfig(SqlDataReader _reader,bool basicInfo)
        {
            var _list = new List<Examiner>();
            while (_reader.Read())
            {
                if (basicInfo)
                {

                    _list.Add(new Examiner
                    {
                        ID = int.Parse(_reader.GetValue(0).ToString()),
                        Sold_id = _reader.GetValue(1).ToString(),
                        Name = _reader.GetValue(2).ToString(),
                        Drugs = _reader.GetValue(3).ToString(),
                        Suicide = _reader.GetValue(4).ToString(),
                        TTrof = _reader.GetValue(5).ToString(),
                        HomoSexual = _reader.GetValue(6).ToString(),
                        Athiest = _reader.GetValue(7).ToString()
                    });
                }
                else
                {
                    _list.Add(new Examiner
                    {
                        ID = int.Parse(_reader.GetValue(0).ToString()),
                        Sold_id = _reader.GetValue(1).ToString(),
                        Name = _reader.GetValue(2).ToString()
                    });
                }
            }
            _reader.Close();
            return _list;
        }
        /// <summary>
        /// Congiuration Function To get DATASOURCE as a synamic return from StoredProcedures as a return of DATAREADER  
        /// </summary>
        /// <param name="spQuery"></param>
        /// <param name="stateCode"></param>
        /// <param name="stage"></param>
        /// <param name="date"></param>
        /// <param name="basicInfo"></param>
        /// <param name="callback"></param>
        public void GetBasicTypedInfo(string spQuery, int stateCode, string stage, string date, bool basicInfo, Action<List<Examiner>, string> callback)
        {

            cmd.TableCMDStoredP(spQuery, (_cmd) =>
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@state_code", stateCode);
                _cmd.Parameters.AddWithValue("@stage", stage);
                _cmd.Parameters.AddWithValue("@date",DateTime.Parse( date) );

                _cmd.Parameters.Add(new SqlParameter { Direction = ParameterDirection.ReturnValue, ParameterName = "Return_Value", SqlDbType = SqlDbType.Int });

                _cmd.Parameters.Add(new SqlParameter { Direction = ParameterDirection.Output, ParameterName = "@noticed", SqlDbType = SqlDbType.Int });
                _cmd.Parameters.Add(new SqlParameter { Direction = ParameterDirection.Output, ParameterName = "@downfull", SqlDbType = SqlDbType.Int });

                var _reader = _cmd.ExecuteReader();

                var _list = SetFuncConfig(_reader, basicInfo);

                string strColl = String.Format("الاجمالي : {0} , الملحوظ : {1} , المقصر :{2} ", _cmd.Parameters["Return_Value"].Value.ToString(), _cmd.Parameters["@noticed"].Value.ToString(), _cmd.Parameters["@downfull"].Value.ToString());

                callback(_list, strColl);
            });

        }
    }
}
