using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManusCrecheCW.Objects
{
    public class Group
    {
        private int id;
        private int maxNoKids;
        private string ageRange;

        public Group()
        {

        }

        public Group(int id, int maxNoKids, string ageRange)
        {
            ID = id;
            MaxNoKids = maxNoKids;
            AgeRange = ageRange;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int MaxNoKids
        {
            get { return maxNoKids; }
            set { maxNoKids = value; }
        }

        public string AgeRange
        {
            get { return ageRange; }
            set { ageRange = value; }
        }
    }
}
