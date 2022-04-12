using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTask
{
    internal class Tax
    {
        private double taxAmount;
        private double taxPercentage = 0.2;
        

        public Tax(double taxPercentage)
        {
            this.taxPercentage = taxPercentage;
        }

        public double ProductTaxAmount { get => taxAmount; set => taxAmount = value; }
        public double ProductTaxPercentage { get => taxPercentage; set => taxPercentage = value; }

    }
}
