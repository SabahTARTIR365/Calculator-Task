using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTask
{
    internal class Tax
    {
        
        private double taxPercentage;
        

        public Tax(double taxPercentage)
        {
            this.TaxPercentage = taxPercentage;
        }

     
        public double TaxPercentage { get => taxPercentage; set => taxPercentage = value; }
    }
}
