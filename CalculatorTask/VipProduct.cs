namespace CalculatorTask
{
    internal class VipProduct : Product
    {
        private double upcDiscountPercentage=0.07;
        private double upcDiscountAmount;

        public double UpcDiscountPercentage { get => upcDiscountPercentage; set => upcDiscountPercentage = value; }

        public VipProduct(string productName, int universalProductCode, double productPrice) : base(productName, universalProductCode, productPrice)
        {

        }

        internal double addUpcDiscount()
        {
            upcDiscountAmount = this.ProductPrice * upcDiscountPercentage;
            return upcDiscountAmount;
        }

        protected void getFinalPrice()
        {
            this.ProductPrice = this.ProductPrice - addPriceDiscount() + addPriceTax()- addUpcDiscount();
        }

        internal void priceReport()
        {
            if (notOfferDiscount())
            {
                Console.WriteLine($"TAX = {ProductTaxPercentage * 100}%, no discount ");
                getFinalPrice();
                Console.WriteLine($"Final price = ${Math.Round(this.ProductPrice, 2)} ");
            }
            else
            {
                Console.WriteLine($"TAX = {ProductTaxPercentage * 100}%, Discount= {ProductDiscountPercentage * 100}%, UPC Discount= { Math.Round(upcDiscountPercentage *100,2)}% ");
                getFinalPrice();
                Console.WriteLine($"Final price = $ {Math.Round(this.ProductPrice, 2)}  with total ${Math.Round(this.ProductDiscountAmount +this.upcDiscountAmount, 2)} discount .");
            }
        }
    }
}