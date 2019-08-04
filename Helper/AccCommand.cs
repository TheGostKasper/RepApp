using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSound.Helper
{
    public class AccCommand
    {
        string fileName = @"C:\app\etb.mdb";
        string coreConnString = "";

        public AccCommand()
        {
            coreConnString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", fileName);
        }

        /// <summary>
        /// Set ConnectionString for access DB , Initial a Datatable command to return a Datasource Datatable
        /// </summary>
        /// <param name="query"></param>
        /// <param name="_fileName"></param>
        /// <returns></returns>
        public DataTable InitDb(string query, string _fileName)
        {
            try
            {
                fileName = (_fileName == "") ? coreConnString : _fileName;
                using (var connection = new OleDbConnection(fileName))
                {
                    OleDbCommand cmd = new OleDbCommand(query, connection);
                    OleDbDataAdapter olda = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    olda.Fill(dt);
                    return dt;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        /// <summary>
        /// Set Default Connectio and getback an OLEDBCOMMAND callback
        /// </summary>
        /// <param name="query"></param>
        /// <param name="callback"></param>
        public void GetCallBackRow(string query, Action<OleDbCommand> callback)
        {
            using (var connection = new OleDbConnection(coreConnString))
            {
                try
                {
                    connection.Open();
                    OleDbCommand myCommand = new OleDbCommand(query, connection);
                    callback(myCommand);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// EXCUTE an ExecuteNonQuery command by using a query parameter 
        /// </summary>
        /// <param name="query"></param>
        public void ACCExecuteNonQuery(string query)
        {
            using (var connection = new OleDbConnection(coreConnString))
            {
                try
                {
                    connection.Open();
                    OleDbCommand myCommand = new OleDbCommand(query, connection);
                    myCommand.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    connection.Close();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void Dispose(OleDbConnection connection)
        {
            connection.Close();
        }
    }
}
