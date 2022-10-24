using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManusCrecheCW.Objects
{
    public class Parent
    {
        private int id;
        private string forename;
        private string surname;
        private string telNo;
        private string city;
        private string postcode;
        private string address;
        private bool deleted;

        public Parent()
        {

        }

        public Parent(int id, string forename, string surname, string telNo, string city, string postcode, string address, bool deleted)
        {
            ID = id;
            Forename = forename;
            Surname = surname;
            TelNo = telNo;
            City = city;
            Postcode = postcode;
            Address = address;
            Deleted = deleted;
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

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public bool Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }
    }
}
