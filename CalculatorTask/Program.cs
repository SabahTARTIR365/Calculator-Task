﻿using System;
namespace CalculatorTask
{
    class Program
    {
        static void Main(string[] args)
        { 
            Product product = new Product("The Little Prince", 12345, 20.25);
           // product.addPriceDiscount(0.15, false);
           // product.priceReport();

            VipProduct productt = new VipProduct("The Little Princes Tia", 10345, 22.25);
           // productt.addPriceDiscount(0.15, true);
            productt.addPriceUpcDiscount(0.15, false);
            productt.priceReport(); 
                 
         

        }

    }
}



