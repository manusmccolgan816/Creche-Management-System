using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms; //Allows use of Application.StartupPath

namespace ManusCrecheCW.Objects
{
    public class Database
    {
        private SqlCommand cmd;
        private SqlConnection conn;
        private SqlDataReader rdr;

        public Database()
        {

        }

        public bool connect()
        {
            SqlConnectionStringBuilder scStrBuilder = new SqlConnectionStringBuilder();

            string databasePath = Application.StartupPath;
            databasePath = databasePath.Remove((Convert.ToInt16(databasePath.Length) - 9));
            scStrBuilder.AttachDBFilename = databasePath + "Creche.mdf";
            scStrBuilder.DataSource = "(LocalDB)\\MSSQLLocalDB";
            scStrBuilder.IntegratedSecurity = true;

            conn = new SqlConnection(scStrBuilder.ToString());
            try
            {
                conn.Open();
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex);
            }

            if(conn.State == ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConnectionOpen()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return connect();
            }
        }

        public SqlCommand Cmd
        {
            get { return cmd; }
            set { cmd = value; }
        }

        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }

        public SqlDataReader Rdr
        {
            get { return rdr; }
            set { rdr = value; }
        }
    }
}
