using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManusCrecheCW.Objects;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ManusCrecheCW.DBAccess
{
    class KidDBAccess
    {
        private Database db;

        public KidDBAccess(Database db)
        {
            this.db = db;
        }

        public List<Kid> getAllKids()
        {
            List<Kid> results = new List<Kid>();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Kid";
            db.Rdr = db.Cmd.ExecuteReader();
            while (db.Rdr.Read())
            {
                results.Add(getKidsFromReader(db.Rdr));
            }
            db.Rdr.Close();
            return results;
        }
        

        public Kid getKidsFromReader(SqlDataReader reader)
        {
            Kid newKid = new Kid();
            newKid.ID = reader.GetInt32(0);
            newKid.ParentID = reader.GetInt32(1);
            newKid.Forename = reader.GetString(2);
            newKid.Surname = reader.GetString(3);
            newKid.DateOfBirth = reader.GetString(4);
            newKid.Deleted = reader.GetBoolean(5);
            return newKid;
        }

        public void updateKid(Kid kid)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "UPDATE Kid SET ParentID ='"
                + kid.ParentID + "', Forename = '"
                + kid.Forename + "', Surname = '"
                + kid.Surname + "', DateOfBirth = '"
                + kid.DateOfBirth + "', Deleted = '"
                + kid.Deleted + "' WHERE KidID = " + kid.ID;
            db.Cmd.ExecuteNonQuery();
        }

        public void addKid(Kid kid)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "INSERT INTO Kid (KidID, ParentID, Forename, Surname, DateOfBirth, Deleted) VALUES('"
                + kid.ID + "', '"
                + kid.ParentID + "', '"
                + kid.Forename + "', '"
                + kid.Surname + "', '"
                + kid.DateOfBirth + "', '"
                + kid.Deleted + "')";
            db.Cmd.ExecuteNonQuery();
        }
    }
}
