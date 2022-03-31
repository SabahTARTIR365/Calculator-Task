namespace CalculatorTask
{
    internal class VipProduct : Product
    {
        private double UpcDiscountPercentage;
        private double UpcDiscountAmount;

        public VipProduct(string productName, int universalProductCode, double productPrice) : base(productName, universalProductCode, productPrice)
        {

        }

        internal double addUpcDiscount()
        {
            UpcDiscountAmount = this.ProductPrice * UpcDiscountPercentage;
            return UpcDiscountAmount;
        }


    }
}