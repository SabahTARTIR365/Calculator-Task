using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTask
{
    interface IPriceOpearation
    {
        double addDiscountBeforeTax( double price, double taxPercentage, double discountPercentage);
        double addDiscountAfterTax(double price, double taxPercentage, double discountPercentage);
    }
    internal class PriceOpearation : IPriceOpearation
    {
        private double price;
        private double taxPercentage;
        private double discountPercentage;
        private bool   discountAfterTax= false;

        double IPriceOpearation.addDiscountAfterTax(double price, double taxPercentage, double discountPercentage)
        {  
             

              return price;
        }

        double IPriceOpearation.addDiscountBeforeTax(double price, double taxPercentage, double discountPercentage)
        {
            return price;
        }
    }
}
