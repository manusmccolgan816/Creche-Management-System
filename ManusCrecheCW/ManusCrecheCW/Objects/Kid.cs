using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManusCrecheCW.Objects
{
    public class Kid
    {
        private int id;
        private int parentID;
        private string forename;
        private string surname;
        private string dateOfBirth;
        private bool deleted;

        public Kid()
        {

        }

        public Kid(int id, int parentID, string forename, string surname, string dateOfBirth, bool deleted)
        {
            ID = id;
            parentID = ParentID;
            Forename = forename;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Deleted = deleted;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int ParentID
        {
            get { return parentID; }
            set { parentID = value; }
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

        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public bool Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }
    }
}
