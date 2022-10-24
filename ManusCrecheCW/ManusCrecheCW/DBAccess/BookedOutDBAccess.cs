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
    class BookedOutDBAccess
    {
        private Database db;

        public BookedOutDBAccess(Database db)
        {
            this.db = db;
        }

        public List<BookedOut> getAllBookedOuts()
        {
            List<BookedOut> results = new List<BookedOut>();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM BookedOut";
            db.Rdr = db.Cmd.ExecuteReader();
            while (db.Rdr.Read())
            {
                results.Add(getBookedOutsFromReader(db.Rdr));
            }
            db.Rdr.Close();
            return results;
        }

        public BookedOut getBookedOutsFromReader(SqlDataReader reader)
        {
            BookedOut newBookedOut = new BookedOut();
            newBookedOut.ID = reader.GetInt32(0);
            newBookedOut.BookingID = reader.GetInt32(1);
            newBookedOut.Date = reader.GetString(2);
            return newBookedOut;
        }

        public void addBookedOut(BookedOut bookedOut)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "INSERT INTO BookedOut (BookedOutID, BookingID, Date) VALUES('"
                + bookedOut.ID + "', '"
                + bookedOut.BookingID + "', '"
                + bookedOut.Date + "')";
            db.Cmd.ExecuteNonQuery();
        }
    }
}
