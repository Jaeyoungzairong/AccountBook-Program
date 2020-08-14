using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace AccountBookProgram
{
    public class SqlManager
    {
        public readonly static SqlManager Instance = new SqlManager();
        private SqlConnection m_SqlConnection;
        private string m_Path = null;

        private readonly string cmdInsert1 = "INSERT INTO tblAlarmData VALUES";
        private readonly string cmdInsert2 = "INSERT INTO tblMusicData VALUES";
        private readonly string cmdSelect1 = "SELECT * FROM tblAlarmData";
        private readonly string cmdSelect2 = "SELECT * FROM tblMusicData";
        private readonly string cmdDelete = "DELETE FROM tblMusicData WHERE Hour = '12' AND Minute = '0';";


        private readonly string m_DBName = "AccountBook";
        private readonly string m_Id = "sa";
        private readonly string m_Pw = "1111";
        private readonly string end = ";";

        private readonly string tblHourName = "HOUR = ";
        private readonly string tblMinuteName = "MINUTE = ";


        public SqlManager()
        {
            if (!Connect(m_DBName, m_Id, m_Pw))
            {
                MessageBox.Show("DB Connection Fail");
            }
        }

        public bool Connect(string DBName, string Id, string Pw)
        {
            string StartUpPath = "Data Source=.\\;"; //MSSQLSERVER
            string DBPath = "Initial Catalog=" + DBName + ";";
            string IdPath = "User ID=" + Id + ";";
            string PwPath = "Password=" + Pw + ";";
            m_Path = StartUpPath + DBPath + IdPath + PwPath;

            try
            {
                if (m_SqlConnection != null)
                {
                    m_SqlConnection.Dispose(); //Close도 된다고 함
                    m_SqlConnection = null;
                    return false;
                }
                else
                {
                    m_SqlConnection = new SqlConnection(m_Path); //접속
                    m_SqlConnection.Open();//DB열기
                    return true;
                }
            }
            catch
            {
                m_SqlConnection.Dispose(); //Close도 된다고 함
                m_SqlConnection = null;
                return false;
            }
        }

        public void Disconnect()
        {
            if (m_SqlConnection != null)
            {
                m_SqlConnection.Close();//DB Close
                m_SqlConnection.Dispose();
                m_SqlConnection = null;
            }
        }

        public DataTable Seclect(string TableName, string Range, string Condition = "")
        {
            DataTable ds = new DataTable();
            string cmd = "SELECT " + Range + " FROM " + TableName + " " + Condition;

            if (m_SqlConnection != null)
            {
                if (m_SqlConnection.State == ConnectionState.Open)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd, m_SqlConnection);
                    adapter.Fill(ds);
                    return ds;
                }
            }
            return ds;
        }

        public DataTable DistinctSeclect(string TableName, string Range = "*", string Condition = "")
        {
            DataTable ds = new DataTable();
            string cmd = "SELECT DISTINCT " + Range + " FROM " + TableName + " " + Condition;

            if (m_SqlConnection != null)
            {
                if (m_SqlConnection.State == ConnectionState.Open)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd, m_SqlConnection);
                    adapter.Fill(ds);
                    return ds;
                }
            }
            return ds;
        }

        public bool Insert(string TableName, string Value)
        {
            bool rv = false;
            string cmd = "INSERT INTO " + TableName + " VALUES (" + Value + ")";
            try
            {
                if (m_SqlConnection != null)
                {
                    if (m_SqlConnection.State == ConnectionState.Open)
                    {
                        SqlCommand sqlcmd = new SqlCommand(cmd, m_SqlConnection);
                        sqlcmd.ExecuteNonQuery();
                        rv = true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }

            return rv;
        }

        public bool Delete(string TableName, string Condition)
        {
            bool rv = false;
            string cmd = "DELETE FROM " + TableName + " " + Condition;
            try
            {
                if (m_SqlConnection != null)
                {
                    if (m_SqlConnection.State == ConnectionState.Open)
                    {
                        SqlCommand sqlcmd = new SqlCommand(cmd, m_SqlConnection);
                        sqlcmd.ExecuteNonQuery();
                        rv = true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }

            return rv;
        }

        public bool DeleteAll(string TableName)
        {
            bool rv = false;
            string cmd = "DELETE FROM " + TableName;
            try
            {
                if (m_SqlConnection != null)
                {
                    if (m_SqlConnection.State == ConnectionState.Open)
                    {
                        SqlCommand sqlcmd = new SqlCommand(cmd, m_SqlConnection);
                        sqlcmd.ExecuteNonQuery();
                        rv = true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }

            return rv;
        }

        public bool Update(string TableName, string Value, string Condition)
        {
            bool rv = false;
            string cmd = "UPDATE " + TableName + " SET " + Value + " " + Condition;
            try
            {
                if (m_SqlConnection != null)
                {
                    if (m_SqlConnection.State == ConnectionState.Open)
                    {
                        SqlCommand sqlcmd = new SqlCommand(cmd, m_SqlConnection);
                        sqlcmd.ExecuteNonQuery();
                        rv = true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }

            return rv;
        }

        public string ConvertToSqlcmd(string[] Value)
        {
            return "aa";
        }
    }
}
