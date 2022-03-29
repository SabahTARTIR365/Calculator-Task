namespace CalculatorTask
{
    internal class Product
    {
        private string productName;
        private int universalProductCode;
        private double productPrice;
        private double productTax=0.2;
        public Product()
        {
        }


        public Product(string v1, int v2,  double v3)
        {
            this.productName = v1;
            this.universalProductCode = v2;
            this.productPrice = v3;
        }

        internal void addPriceTax()
        {
           if (this  != null) {
                Console.WriteLine($"Product price reported as ${Math.Round(this.productPrice, 2)} before tax");
               this.productPrice = this.productPrice+ (this.productPrice * 0.2);
                Console.WriteLine($"and ${ Math.Round(this.productPrice, 2)} after { productTax*100}% tax.");
        }
        }
    }
}