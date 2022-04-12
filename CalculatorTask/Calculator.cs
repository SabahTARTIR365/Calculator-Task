namespace CalculatorTask
{
    internal class Calculator
    {
        private Product _product;
        private Tax _tax;
        private List <Discount> _discounts;

        public double countAmountBeforeTax=0.0;
        public double countAmountAfterTax=0.0;


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
            reportForProductInput();
            double price = this.Product.ProductPrice;
            setFinalDiscount();
            Console.WriteLine(price);
            price = Math.Round(price - countAmountBeforeTax, 2);
            Console.WriteLine(price);
            price = Math.Round(price + getTaxAmount() - countAmountAfterTax,2) ;
            Console.WriteLine(price);
          

            return price;
        }

        private void setFinalDiscount()
        {
            for (int i = 0; i < Discounts.Count; i++)
            {
                if (Discounts[i].DoDiscountBeforeApplyingTax)
                {
                    this.countAmountBeforeTax = this.countAmountBeforeTax + getDiscountAmount(Discounts[i].DiscountPercentage);
                    this.Product.ProductPrice = this.Product.ProductPrice - this.countAmountBeforeTax;

                }
                else
                {
                    this.countAmountAfterTax = this.countAmountAfterTax + getDiscountAmount(Discounts[i].DiscountPercentage);
                }
            }
        }

        private void reportForProductInput()
        {
            Console.WriteLine($"TAX = {Tax.TaxPercentage * 100}%,");
            for (int i = 0; i < Discounts.Count; i++)
            {
                Console.WriteLine($"Discount {Discounts[i].DiscountType}= { Math.Round(Discounts[i].DiscountPercentage * 100, 2)}% ");
            }
        }

        private double getDiscountAmount(double discountPercentage)
        {
            double amount = 0; 
            if (this != null)
            {
                amount = Math.Round(this.Product.ProductPrice * discountPercentage,2);
            }
            Console.WriteLine($"discount amount = {amount}");
            return amount;


        }

        private double getTaxAmount()
        {
            double taxAmount = 0.0;
            if (this != null)
            {
                taxAmount = Math.Round(this.Product.ProductPrice * this.Tax.TaxPercentage,2);
            }
            Console.WriteLine($"tax amount = {taxAmount}");
            return taxAmount;
        }
    }
}