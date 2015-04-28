using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeleteCustomerNamesapce
{
    public class Delete
    {

        //instance variable
        private String custID;

        //Constructor
        public Delete()
        {
            custID = "";
        }

        //properties
        public String CustID
        {
            get { return custID; }
            set { custID = value; }
        }


    }
}
