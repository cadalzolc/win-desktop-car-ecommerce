using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public class DB
    {

        private static string ConnectionString => string.Format("Provider={0};Data Source={1}", Config.GetValue("Provider"), Config.GetValue("DB"));

        #region " Connection "

        public static OleDbConnection Connection
        {
            get
            {
                try
                {
                    var Con = new OleDbConnection(ConnectionString);
                    Con.Open();
                    return Con;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }

        #endregion

        #region " Is Connected "

        public static bool IsConnected()
        {
            try
            {
                using (var Con = new OleDbConnection(ConnectionString))
                {
                    Con.Open();
                    Con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        #endregion

        #region " Data "

        public static DataTable ToData(string Query)
        {
            try
            {
                using (var Con = new OleDbConnection(ConnectionString))
                {
                    Con.Open();
                    var DA = new DataTable();
                    var DS = new OleDbDataAdapter(Query, Con);
                    DS.Fill(DA);
                    return DA;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static DataTable ToData(OleDbCommand Cmd)
        {
            try
            {
                var DA = new DataTable();
                var DS = new OleDbDataAdapter(Cmd);
                DS.Fill(DA);
                return DA;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        
        #endregion
        
        #region " Rows "

        public static IEnumerable<DataRow> ToRows(string Query)
        {
            try
            {
                using (var Con = new OleDbConnection(ConnectionString))
                {
                    Con.Open();
                    var DT = new DataTable();
                    var DS = new OleDbDataAdapter(Query, Con);
                    DS.Fill(DT);
                    return DT.AsEnumerable();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<DataRow>();
            }
        }

        public static IEnumerable<DataRow> ToRows(OleDbCommand Cmd)
        {
            try
            {
                var DT = new DataTable();
                var DS = new OleDbDataAdapter(Cmd);
                DS.Fill(DT);
                return DT.AsEnumerable();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<DataRow>();
            }
        }

        #endregion

        #region " To Row "

        public static DataRow ToRow(string Query)
        {
            try
            {
                using (var Con = new OleDbConnection(ConnectionString))
                {
                    Con.Open();

                    var DT = new DataTable();
                    var DS = new OleDbDataAdapter(Query, Con);

                    DS.Fill(DT);

                    if (DT == null) return null;
                    if (DT.Rows.Count.Equals(0)) return null;

                    return DT.Rows[0];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static DataRow ToRow(OleDbCommand Cmd)
        {
            try
            {
                var DT = new DataTable();
                var DS = new OleDbDataAdapter(Cmd);

                DS.Fill(DT);

                if (DT == null) return null;
                if (DT.Rows.Count.Equals(0)) return null;
                return DT.Rows[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        #endregion

        #region " Command "

        public static OleDbCommand Command(string Text, OleDbConnection Con)
        {
            var Cmd = new OleDbCommand(Text, Con)
            {
                CommandType = CommandType.Text
            };
            return Cmd;
        }

        public static OleDbCommand Command(string Text, OleDbConnection Con, OleDbTransaction Trans)
        {
            var Cmd = new OleDbCommand(Text, Con, Trans)
            {
                CommandType = CommandType.Text
            };
            return Cmd;
        }

        #endregion

    }

}