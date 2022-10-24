using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManusCrecheCW.Objects;
using System.Data.SqlClient;

namespace ManusCrecheCW.DBAccess
{
    class GroupDBAccess
    {
        private Database db;

        public GroupDBAccess(Database db)
        {
            this.db = db;
        }

        public List<Group> getAllGroups()
        {
            List<Group> results = new List<Group>();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM [Group]";
            db.Rdr = db.Cmd.ExecuteReader();
            while (db.Rdr.Read())
            {
                results.Add(getGroupsFromReader(db.Rdr));
            }
            db.Rdr.Close();
            return results;
        }

        public Group getGroupsFromReader(SqlDataReader reader)
        {
            Group newGroup = new Group();
            newGroup.ID = reader.GetInt32(0);
            newGroup.MaxNoKids = reader.GetInt32(1);
            newGroup.AgeRange = reader.GetString(2);
            return newGroup;
        }
    }
}
