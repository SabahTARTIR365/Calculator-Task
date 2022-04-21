using System;
namespace CalculatorTask
{
    class Program
    {
        static void Main(string[] args)
        { 
            Product product = new Product("The Little Prince", 12345, 20.25);
            Tax tax = new Tax(0.21);
            List<Discount> Discounts = new List<Discount>();
            Discount UniDiscount = new Discount(0.15, false,"universal");
            Discount Upc = new Discount(0.07,false,"UPC");
            Discounts.Add(Upc);
            Discounts.Add(UniDiscount);
            Cost packaging = new Cost(0.01, true,"Packaging cost");
            Cost transport = new Cost(2.2,false, "Transport cost");
            List <Cost> costs = new List<Cost>();
            DiscountManager discountManager = new DiscountManager(Discounts, true);
            costs.Add(packaging);
            costs.Add(transport);

            Calculator calculator = new Calculator(product,tax, discountManager, costs);
            double price =calculator.getFinalPrice();





        }

    }
}



