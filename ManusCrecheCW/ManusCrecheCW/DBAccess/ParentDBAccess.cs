using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManusCrecheCW.Objects;
using System.Data.SqlClient;

namespace ManusCrecheCW.DBAccess
{
    class ParentDBAccess
    {
        private Database db;

        public ParentDBAccess(Database Db)
        {
            this.db = Db;
        }

        public List<Parent> getAllParents()
        {
            List<Parent> results = new List<Parent>();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Parent";
            db.Rdr = db.Cmd.ExecuteReader();
            while (db.Rdr.Read())
            {
                results.Add(getParentsFromReader(db.Rdr));
            }
            db.Rdr.Close();
            return results;
        }

        public Parent getParentsFromReader(SqlDataReader reader)
        {
            Parent newParent = new Parent();
            newParent.ID = reader.GetInt32(0);
            newParent.Forename = reader.GetString(1);
            newParent.Surname = reader.GetString(2);
            newParent.TelNo = reader.GetString(3);
            newParent.City = reader.GetString(4);
            newParent.Postcode = reader.GetString(5);
            newParent.Address = reader.GetString(6);
            newParent.Deleted = reader.GetBoolean(7);
            return newParent;
        }

        public void updateParent(Parent parent)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "UPDATE Parent SET Forename ='"
                + parent.Forename + "', Surname = '"
                + parent.Surname + "', TelNo = '"
                + parent.TelNo + "', City = '"
                + parent.City + "', Postcode = '"
                + parent.Postcode + "', Address = '"
                + parent.Address + "', Deleted = '"
                + parent.Deleted + "' WHERE ParentID = " + parent.ID;
            db.Cmd.ExecuteNonQuery();
        }

        public void addParent(Parent parent)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "INSERT INTO Parent(ParentID, Forename, Surname, TelNo, City, Postcode, Address, Deleted) VALUES('"
                + parent.ID + "','"
                + parent.Forename + "','" 
                + parent.Surname + "', '" 
                + parent.TelNo + "', '" 
                + parent.City + "', '" 
                + parent.Postcode + "', '" 
                + parent.Address + "', '"
                + parent.Deleted + "')";
            db.Cmd.ExecuteNonQuery();
        }
    }
}
