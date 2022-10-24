using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManusCrecheCW.Objects;
using System.Data.SqlClient;

namespace ManusCrecheCW.DBAccess
{
    class StaffDBAccess
    {
        private Database db;

        public StaffDBAccess(Database db)
        {
            this.db = db;
        }

        public List<Staff> getAllStaff()
        {
            List<Staff> results = new List<Staff>();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Staff";
            db.Rdr = db.Cmd.ExecuteReader();
            while (db.Rdr.Read())
            {
                results.Add(getStaffFromReader(db.Rdr));
            }
            db.Rdr.Close();
            return results;
        }

        public Staff getStaffFromReader(SqlDataReader reader)
        {
            Staff newStaff = new Staff();
            newStaff.ID = reader.GetInt32(0);
            newStaff.Forename = reader.GetString(1);
            newStaff.Surname = reader.GetString(2);
            newStaff.TelNo = reader.GetString(3);
            return newStaff;
        }
    }
}