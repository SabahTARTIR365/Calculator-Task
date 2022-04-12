using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTask
{
    internal class Discount
    {  
       
        private double discountPercentage;
        private double discountAmount;
        private double v;

        public Discount(double v)
        {
            this.v = v;
        }

        /* enum discountType
{
   normal,
   upc
};*/

        public double ProductDiscountAmount { get => discountAmount; set => discountAmount = value; }
        public double ProductDiscountPercentage { get => discountPercentage; set => discountPercentage = value; }
      

        internal bool notOfferDiscount()
        {
            return discountPercentage == 0.0;
        }


    }
}
