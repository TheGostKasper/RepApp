using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data;
using System.Windows.Forms;
using AppSound.Helper;

namespace Tagneed.Helper
{
    
    public class ORCLCommands
    {
        public CurrExaminer ScanBarcode(string barcode)
        {
            var _examiner = new CurrExaminer();

            using (var con = new OracleConnection(global::AppSound.Properties.Settings.Default.tagned))
            {
                try
                {
                    con.Open();
                    var query = String.Format(@"
                                    SELECT g.SH_NAME, e.MOSALSAL, e.C_MAR1, e.MILAD, e.MARHLA, e.MOHAFZA_C, e.BARCODE_NO
                                    FROM  ESTEKBAL_D e, GOND g
                                    WHERE e.C_MAR1 = g.C_MARE AND e.MOSALSAL = g.MOSALSAL AND e.MILAD = g.MILAD AND (e.BARCODE_NO = '{0}') ", barcode);

                    var cmd = new OracleCommand(query, con);
                    var _reader = cmd.ExecuteReader();
                    while (_reader.Read())
                    {
                        _examiner.Barcode = barcode;
                        _examiner.Name = _reader.GetValue(0).ToString();
                        _examiner.Trible_sequence = String.Format("{0}/{1}/{2}", _reader.GetValue(1).ToString(), _reader.GetValue(2).ToString(), _reader.GetValue(3).ToString());
                        _examiner.Stage = _reader.GetValue(4).ToString();
                    }

                    return _examiner;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
