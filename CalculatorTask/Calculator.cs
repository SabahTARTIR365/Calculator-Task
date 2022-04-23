namespace CalculatorTask
{
    internal class Calculator
    {
        private Product _product;
        private Tax _tax;
        //private List <Discount> _discounts;
        private DiscountManager _discountManager;
        private List<Cost> _costs;

        public double countAmountBeforeTax=0.0;
        public double countAmountAfterTax=0.0;


        internal Product Product { get => _product; set => _product = value; }
        internal Tax Tax { get => _tax; set => _tax = value; }
        //internal List<Discount> Discounts { get => _discounts; set => _discounts = value; }
        internal List<Cost> Costs { get => _costs; set => _costs = value; }
        internal DiscountManager DiscountManager { get => _discountManager; set => _discountManager = value; }

        public Calculator()
        {
        }
        public Calculator(Product product, Tax tax, DiscountManager discountManager, List<Cost> _costs)
        {
            this.Product = product;
            this.Tax = tax;
           // this.Discounts = discount;
            this.DiscountManager =discountManager;
            this._costs = _costs;
        }


        internal double getFinalPrice()
        {
            
            double price = this.Product.ProductPrice;
            reportForProductInput();

            if (isMultiplicativeDiscount()) {
                //YES SIR HERE
                
            }
            else
            {
                setFinalDiscount();
                Console.WriteLine("==========================================================");
                Console.WriteLine($"Cost (pure price)= ${price}");
                price = Math.Round(price - countAmountBeforeTax, 2);
                price = Math.Round(price + getTaxAmount(price) - countAmountAfterTax + getTotalCosts(), 2);

                Console.WriteLine($"TOTAL={price}");
                
            }
            return price;
        }

        private void getMultiplicativeDiscount()
        {
            double total_Discount=0.0;
            double price = Product.ProductPrice;
            double initialDiscount = 0.0;
            double discountBeforTax = 0.0;
            double discountAfterTax = 0.0;
            initialDiscount = initialDiscount + getDiscountAmount(DiscountManager.Discounts[0].DiscountPercentage, DiscountManager.Discounts[0].DiscountType);
                
            for (int i = 1; i < this.DiscountManager.Discounts.Count; i++)
                {
                    if (DiscountManager.Discounts[i].DoDiscountBeforeApplyingTax)
                    {
                   
                    discountBeforTax = discountBeforTax + getDiscountAmount(DiscountManager.Discounts[i].DiscountPercentage, DiscountManager.Discounts[i].DiscountType);
                      price =price- discountBeforTax;

                    /* if (i == 0) { dis = dis + getDiscountAmount(DiscountManager.Discounts[i].DiscountPercentage, DiscountManager.Discounts[i].DiscountType); }
                     else { dis = (this.Product.ProductPrice - dis + getTaxAmount()) * DiscountManager.Discounts[i].DiscountPercentage; }
                   */
                    //ESMATE DISCOUNT FOR TAX SCENARIO
                    }

                }


            Console.WriteLine($"Discount=${total_Discount}");
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

        private void setFinalDiscount()
        {
            for (int i = 0; i < DiscountManager.Discounts.Count; i++)
            {
             
                                
                   if (DiscountManager.Discounts[i].DoDiscountBeforeApplyingTax)
                   {
                    this.countAmountBeforeTax = this.countAmountBeforeTax + getDiscountAmount(DiscountManager.Discounts[i].DiscountPercentage, DiscountManager.Discounts[i].DiscountType);
                    this.Product.ProductPrice = this.Product.ProductPrice - this.countAmountBeforeTax;

                   }
                   else
                   {
                    this.countAmountAfterTax = this.countAmountAfterTax + getDiscountAmount(DiscountManager.Discounts[i].DiscountPercentage, DiscountManager.Discounts[i].DiscountType);
                   }

                
              


            }
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

        private double getDiscountAmount(double discountPercentage, string discountType )
        {
            double amount = 0; 
            if (this != null)
            {
                amount = Math.Round(this.Product.ProductPrice * discountPercentage,2);
            }
            Console.WriteLine($"{discountType } Discount amount = ${this.Product.ProductPrice}* { Math.Round(discountPercentage * 100, 2)}%= ${amount},");
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