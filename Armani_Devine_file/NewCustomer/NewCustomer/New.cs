using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewCustomer
{
    public class New
    {

       //instance variables
        private String custID, name, surname, cell,address;
        private int age;
        private char gender;

        //constructor
        public New()
        {
            custID = "";
            name = "";
            surname = string.Empty;
            cell = string.Empty;
            address = string.Empty;
            gender = ' ';
            age = 0;
        }

        //Properties
        public String CustID
        {
            get { return custID; }
            set { custID = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public String Cell
        {
            get { return cell; }
            set { cell = value; }
        }

        public String Address 
        {
            get { return address; }
            set { address = value; }
        }

        public char Gender 
        {
            get { return gender; }
            set { gender = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }



    }
}
