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

        internal void addPriceDiscount()
        {
            if (this != null)
            {
                Console.WriteLine($"Product price reported as ${Math.Round(this.productPrice, 2)} before discount");
                this.productDiscountAmount =  (this.productPrice * productDiscountPercentage);
                this.productPrice = this.productPrice - this.productDiscountAmount;
                Console.WriteLine($"and ${ Math.Round(this.productPrice, 2)} after { this.productDiscountPercentage * 100}% discount.");
            }
        }

        internal void getFinalPrice()
        {
            this.addPriceTax();
            this.addPriceDiscount();
        }

        internal void addPriceTax()
        {
           if (this  != null) {
                Console.WriteLine($"Product price reported as ${Math.Round(this.productPrice, 2)} before tax");
               this.productTaxAmount = this.productPrice * productTaxPercentage;
                this.productPrice = this.productPrice + this.productTaxAmount;
                Console.WriteLine($"and ${ Math.Round(this.productPrice, 2)} after { productTaxPercentage*100}% tax.");
        }
        }
    }
}