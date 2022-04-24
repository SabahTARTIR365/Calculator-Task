namespace CalculatorTask
{
    internal class Calculator
    {
        private Product _product;
        private Tax _tax;
        private DiscountManager _discountManager;
        private List<Cost> _costs;

        internal Product Product { get => _product; set => _product = value; }
        internal Tax Tax { get => _tax; set => _tax = value; }
        internal List<Cost> Costs { get => _costs; set => _costs = value; }
        internal DiscountManager DiscountManager { get => _discountManager; set => _discountManager = value; }

        public Calculator()
        {
        }
        public Calculator(Product product, Tax tax, DiscountManager discountManager, List<Cost> _costs)
        {
            this.Product = product;
            this.Tax = tax;
            this.DiscountManager =discountManager;
            this._costs = _costs;
        }


        internal void getFinalPrice()
        {
            reportForProductInput();
            if (isMultiplicativeDiscount()) 
            { 
                getMultiplicativeDiscount(); 
            }
            else
            {
                getAdditiveDiscount();
            }
        }

        private void getAdditiveDiscount()
        {
            double price = this.Product.ProductPrice;
            double discountBeforTax = 0.0;
            double discountAfterTax = 0.0;
            double total_Discount = 0.0;
            discountBeforTax = getDiscountBeforeTax();
            price = Math.Round(price - discountBeforTax, 2);

            discountAfterTax = getDiscountAfterTax(price);
            total_Discount = Math.Round(discountBeforTax + discountAfterTax, 2);
            total_Discount = total_Discount > getTotalCap() ? getTotalCap() : total_Discount;
            Console.WriteLine("==========================================================");
            Console.WriteLine($"Cost (pure price)= ${this.Product.ProductPrice}");
            Console.WriteLine($"Discount=${total_Discount}");
            price = Math.Round(this.Product.ProductPrice + getTaxAmount(price) - total_Discount + getTotalCosts(), 2);
            Console.WriteLine($"TOTAL=${price}");
        }

        private double getDiscountAfterTax(double price)
        {
            double discount = 0.0;

            for (int i = 0; i < DiscountManager.Discounts.Count; i++)
            {
                if (!DiscountManager.Discounts[i].DoDiscountBeforeApplyingTax)
                {
                    discount = discount + getDiscountAmount(price, DiscountManager.Discounts[i].DiscountPercentage, DiscountManager.Discounts[i].DiscountType);
                }
            }
            return discount;
        }

        private double getDiscountBeforeTax()
        {
            double discount = 0.0;

            for (int i = 0; i < DiscountManager.Discounts.Count; i++)
            {

                if (DiscountManager.Discounts[i].DoDiscountBeforeApplyingTax)
                {
                    discount= discount + getDiscountAmount(this.Product.ProductPrice, DiscountManager.Discounts[i].DiscountPercentage, DiscountManager.Discounts[i].DiscountType);
                    
                }
            }
                return discount;
        }

        private void getMultiplicativeDiscount()
        {
            double total_Discount=0.0;
            double price = Product.ProductPrice;
            double discountBeforTax = 0.0;
            double discountAfterTax = 0.0;
            double temporareyPrice = 0.0;

            for (int i = 0; i < this.DiscountManager.Discounts.Count; i++)
            {
                if (DiscountManager.Discounts[i].DoDiscountBeforeApplyingTax)
                {
                    temporareyPrice = Math.Round(price - discountBeforTax, 2);
                    discountBeforTax = discountBeforTax + getDiscountAmount(temporareyPrice, DiscountManager.Discounts[i].DiscountPercentage, DiscountManager.Discounts[i].DiscountType);
                    price = Math.Round(price - discountBeforTax, 2);
                }
            }
            for (int i = 0; i < this.DiscountManager.Discounts.Count; i++)
                {
                if (!DiscountManager.Discounts[i].DoDiscountBeforeApplyingTax)
                {
                    temporareyPrice = Math.Round(price - discountAfterTax, 2);// i didn't subrtract after here becouse it's already subtracted from price
                    discountAfterTax = discountAfterTax + getDiscountAmount(temporareyPrice, DiscountManager.Discounts[i].DiscountPercentage, DiscountManager.Discounts[i].DiscountType);
                }
            }

            total_Discount= discountBeforTax + discountAfterTax;
            total_Discount = total_Discount > getTotalCap() ? getTotalCap() : total_Discount;
            Console.WriteLine("==========================================================");
            double tax = getTaxAmount(price);
            double purePrice= Math.Round(Product.ProductPrice+tax- total_Discount+ getTotalCosts(), 2);
            Console.WriteLine($"discount After Tax=${discountAfterTax}");
            Console.WriteLine($"discount Before Tax=${discountBeforTax}");
            Console.WriteLine($"Total Discount=${total_Discount}");
            Console.WriteLine($"Cost (Pure price)= ${purePrice}");
        }

        private double getTotalCosts()
        {
            double totalCostAmount = 0.0;
            double costFromPricePercentage=0;
            foreach (Cost cost in this.Costs)
            { if (cost.IscostPercentage)
                {
                    costFromPricePercentage  = Math.Round(this.Product.ProductPrice * cost.CostValue,2);
                    totalCostAmount = Math.Round(totalCostAmount + costFromPricePercentage, 2);
                    Console.WriteLine($"{cost.CostType}= ${costFromPricePercentage}");
                }
                else
                {
                    totalCostAmount = Math.Round(totalCostAmount + cost.CostValue,2);
                    Console.WriteLine($"{cost.CostType}= ${cost.CostValue}");
                }
            }
            return totalCostAmount;
        }

        private double getTotalCap()
        {
            double totalCapAmount = 0.0;
            totalCapAmount = DiscountManager.DiscontCap.IsCapPersentage?
                             Math.Round(this.Product.ProductPrice * DiscountManager.DiscontCap.Value, 2)
                            :Math.Round(DiscountManager.DiscontCap.Value, 2); 
            Console.WriteLine($"Cap= ${totalCapAmount}");
            return totalCapAmount;
        }


        private bool isMultiplicativeDiscount()
        {
            return this.DiscountManager.IsMultiplicativeDiscount;
        }

        private void reportForProductInput()
        {   
            Console.WriteLine($"TAX = {Tax.TaxPercentage * 100}%,");
            reportForCostsInputs();
            reportForDiscountsInputs();
        }

        private void reportForDiscountsInputs()
        {
            for (int i = 0; i < DiscountManager.Discounts.Count; i++)
            {
                Console.WriteLine($"{DiscountManager.Discounts[i].DiscountType} Discount = { Math.Round(DiscountManager.Discounts[i].DiscountPercentage * 100, 2)}% for UPC ={Product.UniversalProductCode} ");
            }
        }

        private void reportForCostsInputs()
        {
            for (int i = 0; i < Costs.Count; i++)
            {
                if (Costs[i].IscostPercentage)
                    Console.WriteLine($"{Costs[i].CostType} = { Math.Round(Costs[i].CostValue * 100, 2)}% of price ");
                else
                Console.WriteLine($"{Costs[i].CostType} Cost = { Math.Round(Costs[i].CostValue, 2)}$ ");
            }
        }

        private double getDiscountAmount(double price,double discountPercentage, string discountType )
        {
            double amount = 0; 
            if (this != null)
            {
                amount = Math.Round(price * discountPercentage,2);
            }
            Console.WriteLine($"{discountType } Discount amount = ${price}* { Math.Round(discountPercentage * 100, 2)}%= ${amount},");
            return amount;


        }

        private double getTaxAmount(double price)
        {
            double taxAmount = 0.0;
            if (this != null)
            {
                taxAmount = Math.Round(price * this.Tax.TaxPercentage,2);
            }
            Console.WriteLine($"Tax amount = ${taxAmount}");
            return taxAmount;
        }
    }
}