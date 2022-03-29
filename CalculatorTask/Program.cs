using System;
namespace CalculatorTask
{
    class Program
    {
        static void Main(string[] args)
        { 
            Product product = new Product("The Little Prince", 12345,20.25);
           // product.addPriceTax();
            product.getFinalPrice();
          

        }

    }
}



