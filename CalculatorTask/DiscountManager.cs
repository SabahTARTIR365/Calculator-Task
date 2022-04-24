
namespace CalculatorTask
{
    internal class DiscountManager
    {
        private List<Discount> discounts;
        private bool isMultiplicativeDiscount;
        private Cap discontCap;
        public DiscountManager(List<Discount> discounts, bool isMultiplicativeDiscount, Cap discountCap)
        {
            this.Discounts = discounts;
            this.IsMultiplicativeDiscount = isMultiplicativeDiscount;
            this.DiscontCap= discountCap;
        }

        public bool IsMultiplicativeDiscount { get => isMultiplicativeDiscount; set => isMultiplicativeDiscount = value; }
        internal List<Discount> Discounts { get => discounts; set => discounts = value; }
        internal Cap DiscontCap { get => discontCap; set => discontCap = value; }
    }
}