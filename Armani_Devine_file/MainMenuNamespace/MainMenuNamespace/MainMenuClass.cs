using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace MainMenuNamespace
{
    public class MainMenuClass
    {
        private string menuSelection;
        private String[] menu = new String[] {"Cash Sale", "Customer Enquiry", "Print Monthly Reports","Appointments"};

        //constructor
        public MainMenuClass(){
            menuSelection = "";
        }

        public string[] Menu
        {
            get { return menu; }
            set { menu = value; }
        }

        public string MenuSelection
        {
            get { return menuSelection; }
            set { menuSelection = value; }
        }



    }
}
