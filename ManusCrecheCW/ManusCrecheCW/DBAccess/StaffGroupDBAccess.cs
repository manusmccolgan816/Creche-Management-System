using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManusCrecheCW.Objects;
using System.Data.SqlClient;

namespace ManusCrecheCW.DBAccess
{
    class StaffGroupDBAccess
    {
        private Database db;

        public StaffGroupDBAccess(Database db)
        {
            this.db = db;
        }

        public List<StaffGroup> getAllStaffGroups()
        {
            List<StaffGroup> results = new List<StaffGroup>();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM StaffGroup";
            db.Rdr = db.Cmd.ExecuteReader();
            while (db.Rdr.Read())
            {
                results.Add(getStaffGroupsFromReader(db.Rdr));
            }
            db.Rdr.Close();
            return results;
        }

        public StaffGroup getStaffGroupsFromReader(SqlDataReader reader)
        {
            StaffGroup newStaffGroup = new StaffGroup();
            newStaffGroup.ID = reader.GetInt32(0);
            newStaffGroup.StaffID = reader.GetInt32(1);
            newStaffGroup.GroupID = reader.GetInt32(2);
            newStaffGroup.Date = reader.GetString(3);
            return newStaffGroup;
        }

        public void addStaffGroup(StaffGroup staffGroup)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "INSERT INTO StaffGroup (StaffGroupID, StaffID, GroupID, Date) VALUES('"
                + staffGroup.ID + "', '"
                + staffGroup.StaffID + "', '"
                + staffGroup.GroupID + "', '"
                + staffGroup.Date + "')";
            db.Cmd.ExecuteNonQuery();
        }
    }
}
