using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReportsNamespace
{
    public class ReportsClass
    {
        //Variables
        private String search,search2;

        //constructor
        public ReportsClass()
        {
            search = string.Empty;
            search2 = string.Empty;
        }

        //properties
        public string Search
        {
            get { return search; }
            set { search = value; }
        }

        public string Search2
        {
            get { return search2; }
            set { search2 = value; }
        }
    }
}
