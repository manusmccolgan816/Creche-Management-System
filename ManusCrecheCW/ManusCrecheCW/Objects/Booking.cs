using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManusCrecheCW.Objects
{
    public class Booking
    {
        private int id;
        private int kidID;
        private int groupID;
        private string startDate;
        private string endDate;
        private bool mon;
        private bool tue;
        private bool wed;
        private bool thurs;
        private bool fri;
        private bool deleted;

        public Booking()
        {

        }

        public Booking(int id, int kidID, int groupID, string startDate, string endDate, bool mon, bool tue, bool wed, bool thurs, bool fri, bool deleted)
        {
            ID = id;
            KidID = kidID;
            GroupID = groupID;
            StartDate = startDate;
            EndDate = endDate;
            Mon = mon;
            Tue = tue;
            Wed = wed;
            Thurs = thurs;
            Fri = fri;
            Deleted = deleted;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int KidID
        {
            get { return kidID; }
            set { kidID = value; }
        }

        public int GroupID
        {
            get { return groupID; }
            set { groupID = value; }
        }

        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public string EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public bool Mon
        {
            get { return mon; }
            set { mon = value; }
        }

        public bool Tue
        {
            get { return tue; }
            set { tue = value; }
        }

        public bool Wed
        {
            get { return wed; }
            set { wed = value; }
        }

        public bool Thurs
        {
            get { return thurs; }
            set { thurs = value; }
        }

        public bool Fri
        {
            get { return fri; }
            set { fri = value; }
        }

        public bool Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }
    }
}
