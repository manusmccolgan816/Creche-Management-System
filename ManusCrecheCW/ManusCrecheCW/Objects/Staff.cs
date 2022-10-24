using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManusCrecheCW.Objects
{
    public class Staff
    {
        private int id;
        private string forename;
        private string surname;
        private string telNo;

        public Staff()
        {

        }

        public Staff(int id, string forename, string surname, string telNo)
        {
            ID = id;
            Forename = forename;
            Surname = surname;
            TelNo = telNo;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Forename
        {
            get { return forename; }
            set { forename = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string TelNo
        {
            get { return telNo; }
            set { telNo = value; }
        }
    }
}
