using Bogus.DataSets;
using System;
using System.Globalization;
namespace CalculatorTask
{
    class Program
    {
        static void Main(string[] args)
        {
      
           Price price = new Price(20.25, "USD");

            Product product = new Product("The Little Prince", 12345, price);
            Tax tax = new Tax(0.21);
            List<Discount> Discounts = new List<Discount>();
            Discount Upc = new Discount(0.07,false,"UPC");
            //Discount Upc1 = new Discount(0.07, true, "UPC test1");
            Discount UniDiscount = new Discount(0.15, false, "universal");
            Discounts.Add(Upc);
            //Discounts.Add(Upc1);
            Discounts.Add(UniDiscount);
            Cost packaging = new Cost(0.01, true, "Packaging cost");
            Cost transport = new Cost(2.2,false, "Transport cost");
            List <Cost> costs = new List<Cost>();
            Cap discontCap = new Cap(0.20,true);
            DiscountManager discountManager = new DiscountManager(Discounts, false, discontCap);
            costs.Add(packaging);
            costs.Add(transport);

            Calculator calculator = new Calculator(product,tax, discountManager, costs);
            calculator.getFinalPrice();






        }

    }
}



