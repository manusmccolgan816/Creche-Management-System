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
    class BookingDBAccess
    {
        private Database db;

        public BookingDBAccess(Database db)
        {
            this.db = db;
        }

        public List<Booking> getAllBookings()
        {
            List<Booking> results = new List<Booking>();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Booking";
            db.Rdr = db.Cmd.ExecuteReader();
            while (db.Rdr.Read())
            {
                results.Add(getBookingsFromReader(db.Rdr));
            }
            db.Rdr.Close();
            return results;
        }

        public Booking getBookingsFromReader(SqlDataReader reader)
        {
            Booking newBooking = new Booking();
            newBooking.ID = reader.GetInt32(0);
            newBooking.KidID = reader.GetInt32(1);
            newBooking.GroupID = reader.GetInt32(2);
            newBooking.StartDate = reader.GetString(3);
            newBooking.EndDate = reader.GetString(4);
            newBooking.Mon = reader.GetBoolean(5);
            newBooking.Tue = reader.GetBoolean(6);
            newBooking.Wed = reader.GetBoolean(7);
            newBooking.Thurs = reader.GetBoolean(8);
            newBooking.Fri = reader.GetBoolean(9);
            newBooking.Deleted = reader.GetBoolean(10);
            return newBooking;
        }

        public void updateBooking(Booking booking)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "UPDATE Booking SET StartDate ='"
                + booking.StartDate + "', EndDate = '"
                + booking.EndDate + "', Mon = '"
                + booking.Mon + "', Tue = '"
                + booking.Tue + "', Wed = '"
                + booking.Wed + "', Thurs = '"
                + booking.Thurs + "', Fri = '"
                + booking.Fri + "', Deleted = '"
                + booking.Deleted + "'WHERE BookingID = " + booking.ID;
            db.Cmd.ExecuteNonQuery();
        }

        public void addBooking(Booking booking)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "INSERT INTO Booking(BookingID, KidID, GroupID, StartDate, EndDate, Mon, Tue, Wed, Thurs, Fri, Deleted) VALUES('"
                + booking.ID + "', '"
                + booking.KidID + "', '"
                + booking.GroupID + "', '"
                + booking.StartDate + "', '"
                + booking.EndDate + "', '"
                + booking.Mon + "', '"
                + booking.Tue + "', '"
                + booking.Wed + "', '"
                + booking.Thurs + "', '"
                + booking.Fri + "', '"
                + booking.Deleted + "')";
            db.Cmd.ExecuteNonQuery();
        }
    }
}
