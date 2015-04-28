using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CashSaleChangeNamespace
{
    public class CashChange
    {

        //Varibales
        private double cust_money,total;
        
        public CashChange()
        {
            cust_money = 0;
            total = 0;
        }

        //properties
        public double Cust_Money
        {
            get { return cust_money; }
            set { cust_money = value; }
        }

        public double Total
        {
            get { return total; }
            set { total = value; }

        }

        
    }
}
