namespace CalculatorTask
{
    internal class Product
    {
        private string productName;
        private int universalProductCode;
        private double productPrice;
        private double productTaxPercentage=0.2;
        private double productDiscountPercentage = 0.15;

        internal void priceReport()
        {
           if (productDiscountPercentage == 0.0)
            {
                Console.WriteLine($"TAX = {productTaxPercentage*100}%, no discount ");
                getFinalPrice();
                Console.WriteLine($"Final price = ${Math.Round(this.productPrice, 2)} ");
            }
           else
            {
                Console.WriteLine($"TAX = {productTaxPercentage * 100}%, Discount= {productDiscountPercentage*100}% ");
                getFinalPrice();
                Console.WriteLine($"Final price = $ {Math.Round(this.productPrice, 2)}  with ${Math.Round(this.productDiscountAmount,2)} discount .");
            }
        }

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
            
            this.productPrice = this.productPrice - addPriceDiscount()+ addPriceTax();
          

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