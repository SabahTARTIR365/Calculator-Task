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
    }
}