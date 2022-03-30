namespace CalculatorTask
{
    internal class Product
    {
        private string productName;
        private int universalProductCode;
        private double productPrice;
        private double productTaxPercentage=0.2;
        private double productDiscountPercentage = 0.15;
        private double productDiscountAmount;
        private double productTaxAmount;
        public Product()
        {
        }

        public Product(string productName, int universalProductCode,  double productPrice)
        {
            this.productName = productName;
            this.universalProductCode = universalProductCode;
            this.productPrice = productPrice;
        }

        internal double addPriceDiscount()
        {
            if (this != null)
            {
                this.productDiscountAmount =  (this.productPrice * productDiscountPercentage);    
            }
            return this.productDiscountAmount;
        }

        internal void getFinalPrice()
        {
            Console.WriteLine($"Product price reported as ${Math.Round(this.productPrice, 2)} before discount and tax");
            this.productPrice = this.productPrice - addPriceDiscount()+ addPriceTax();
            Console.WriteLine($"and ${ Math.Round(this.productPrice, 2)} after { productTaxPercentage * 100}% tax and discount.");

        }

        internal double addPriceTax()
        {
           if (this  != null) 
            {
               this.productTaxAmount = this.productPrice * productTaxPercentage;
            }
           return productTaxAmount;
        }
    }
}