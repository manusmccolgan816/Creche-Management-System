using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManusCrecheCW.Objects
{
    public class StaffGroup
    {
        private int id;
        private int staffID;
        private int groupID;
        private string date;

        public StaffGroup()
        {

        }

        public StaffGroup(int id, int staffID, int groupID, string date)
        {
            ID = id;
            StaffID = staffID;
            GroupID = GroupID;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public int GroupID
        {
            get { return groupID; }
            set { groupID = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }
    }
}
