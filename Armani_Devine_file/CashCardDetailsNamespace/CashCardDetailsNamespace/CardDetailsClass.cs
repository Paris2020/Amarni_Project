using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashCardDetailsNamespace
{
    public class CardDetailsClass
    {

        private String accType;
        private int pin;

        //Constructor
        public CardDetailsClass()
        {
            accType = "";
            pin = 0;
        }


        //Properties 
        public String AccType
        {
            get { return accType; }
            set { accType = value; }
        }

        public int Pin
        {
            get { return pin; }
            set { pin = value; }
        }

    }
}
