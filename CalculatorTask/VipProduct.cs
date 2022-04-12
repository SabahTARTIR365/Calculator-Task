namespace CalculatorTask
{
    internal class VipProduct : Product
    {
        private double upcDiscountPercentage=0.07;
        private double upcDiscountAmount;
        private bool   upcdiscountBeforeTax = false;
        public double UpcDiscountPercentage { get => upcDiscountPercentage; set => upcDiscountPercentage = value; }

        public VipProduct(string productName, int universalProductCode, double productPrice) : base(productName, universalProductCode, productPrice)
        {

        }
      /*  internal void addPriceUpcDiscount(double discount, bool beforTax)
        {
            this.upcDiscountPercentage = discount;
            this.upcdiscountBeforeTax = beforTax;
        }
    internal double getUpcDiscount()
        {
            upcDiscountAmount = this.ProductPrice * upcDiscountPercentage;
            return upcDiscountAmount;
        }
        protected void getFinalPrice()
        { //start here 
            this.ProductPrice = this.ProductPrice - getPriceDiscount() + getPriceTax()- getUpcDiscount();
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
        }*/
    }
}