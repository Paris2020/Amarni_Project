using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashSaleNamespace
{
    public class CashSaleClass
    {
        //variables

        String[] weaves = new String[]{"Brazillian Hair","Indian Hair","Premium","Joe Dear","Lace Weave","Diva"};
        String[] hairstyles = new String[] {"Relax","Brush","Wash","Dye","Cheese Kop","Treatment (Hair)","Treatment (Dreads)","Perm","S-Curl"};
        String[] products = new String[] {"Soft 'n Free","Black Like Me","Easy Wave","Dark and Lovely","Revlon","Black Chick"};

        Double[] weavePrices = new Double[] {150,250,150,350,450,150};
        Double[] hairstylePrices = new Double[] {120,60,25.5,80,50,130,150,150,150};
        Double[] productPrices = new Double[] {120,150,100,150,110,150};

        private double total;
        private double discount, discount2;
        private double discount_total;

        //Constructor
        public CashSaleClass()
        {
            discount = 0.15;
            discount2 = 0.3;
            total = 0.0;
        }

        //=================================================

        //properties for weaves
        public String[] Weaves
        {
            get { return weaves; }
            set { weaves = value; }
        }

        public double[] WeavePrices
        {
            get { return weavePrices; }
            set { weavePrices = value; }
        }

        //=======================================================

        //properties for hairstyles

        public String[] Hairstyles
        {
            get { return hairstyles; }
            set { hairstyles = value; }
        }

        public double[] HairstylePrices
        {
            get { return hairstylePrices; }
            set { hairstylePrices = value; }
        }
        
       //======================================================

        //properties for products
        public String[] Products
        {
            get { return products; }
            set { products = value; }
        }

        public double[] ProductPrices
        {
            get { return productPrices; }
            set { productPrices = value; }
        }

        //========================================================

        //properties

        public double Total
        {
            get { return total; }
            set { total = value;}
        }

        //properties for discounts and total
        public double Discount
        {
            get { return discount; }
            set 
            { 
                discount = value;
                CalculateDiscount();
            }
        }

        public double Discount2
        {
            get 
            { return discount2;}
            set 
            { 
                discount2 = value;
                CalculateDiscount();
            }
        }

        public double Discount_Total
        {
            get { return discount_total; }
            set {discount_total = value;}
        }

        //========================================================

        private double CalculateDiscount()
        {
            if (total >= 600 && total <= 900)
            {
                discount_total = total - (total * discount);
            }
            else if (total >= 1000)
            {
                discount_total = (total - (total * discount2));
            }
            return discount_total;
        }
        

    }
}
