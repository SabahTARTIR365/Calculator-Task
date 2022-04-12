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
        private bool   doDiscountBeforeApplyingTax=false;
        private string discountType;


        public Discount(double discountPercentage, bool doDiscountBeforeApplyingTax, string discountType)
        {
            this.discountPercentage = discountPercentage;
            this.doDiscountBeforeApplyingTax = doDiscountBeforeApplyingTax;
            this.discountType = discountType;
        }



      
        public double DiscountPercentage { get => discountPercentage; set => discountPercentage = value; }
        public string DiscountType { get => discountType; set => discountType = value; }
        public bool DoDiscountBeforeApplyingTax { get => doDiscountBeforeApplyingTax; set => doDiscountBeforeApplyingTax = value; }

        internal bool notOfferDiscount()
        {
            return discountPercentage == 0.0;
        }


    }
}
