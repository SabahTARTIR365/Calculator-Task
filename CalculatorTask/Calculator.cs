namespace CalculatorTask
{
    internal class Calculator
    {
        private Product product;
        private Tax tax;
        private Discount discount;

        public Calculator()
        {
        }

        public Calculator(Product product, Tax tax, Discount discount)
        {
            this.product = product;
            this.tax = tax;
            this.discount = discount;
        }
    }
}