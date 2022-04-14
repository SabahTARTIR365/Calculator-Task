
namespace CalculatorTask
{
    internal class DiscountManager
    {
        private List<Discount> discounts;
        private bool isMultiplicativeDiscount;

        public DiscountManager(List<Discount> discounts, bool isMultiplicativeDiscount)
        {
            this.Discounts = discounts;
            this.IsMultiplicativeDiscount = isMultiplicativeDiscount;
        }

        public bool IsMultiplicativeDiscount { get => isMultiplicativeDiscount; set => isMultiplicativeDiscount = value; }
        internal List<Discount> Discounts { get => discounts; set => discounts = value; }
    }
}