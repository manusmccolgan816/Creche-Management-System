using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManusCrecheCW.Objects
{
    class BookedOut
    {
        int id;
        int bookingID;
        string date;

        public BookedOut()
        {

        }

        public BookedOut(int id, int bookingID, string date)
        {
            ID = id;
            BookingID = bookingID;
            Date = date;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }
    }
}
