namespace CalculatorTask
{
    internal class Calculator
    {
        private Product _product;
        private Tax _tax;
        private List <Discount> _discounts;

        internal Product Product { get => _product; set => _product = value; }
        internal Tax Tax { get => _tax; set => _tax = value; }
        internal List<Discount> Discounts { get => _discounts; set => _discounts = value; }

        public Calculator()
        {
        }
        public Calculator(Product product, Tax tax, List <Discount> discount)
        {
            this.Product = product;
            this.Tax = tax;
            this.Discounts = discount;
        }



        internal double getFinalPrice()
        {
            double price = this.Product.ProductPrice; 
             

            return price;
        }


    }
}