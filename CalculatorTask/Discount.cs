using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTask
{
    internal class Discount
    {   private Product product; 
        private double productTaxPercentage = 0.2;
        private double productDiscountPercentage = 0.15;
        private double productDiscountAmount;
        private double productTaxAmount;
        private bool   discountBeforeTax = false;


        public double ProductTaxPercentage { get => productTaxPercentage; set => productTaxPercentage = value; }
        public double ProductDiscountAmount { get => productDiscountAmount; set => productDiscountAmount = value; }
        public double ProductDiscountPercentage { get => productDiscountPercentage; set => productDiscountPercentage = value; }
        public double ProductTaxAmount { get => productTaxAmount; set => productTaxAmount = value; }

        internal bool notOfferDiscount()
        {
            return productDiscountPercentage == 0.0;
        }


    }
}
