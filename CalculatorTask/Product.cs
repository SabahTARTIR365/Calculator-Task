namespace CalculatorTask
{
    internal class Product
    {
        private string productName;
        private int universalProductCode;
        private double productPrice;
        private double productTaxPercentage=0.2;
        private double productDiscountPercentage = 0.15;
        private double productDiscountAmount;
        private double productTaxAmount;
        private bool   discountBeforeTax = false;
        public double ProductPrice { get => productPrice; set => productPrice = value; }

   

        public double ProductTaxPercentage { get => productTaxPercentage; set => productTaxPercentage = value; }
        public double ProductDiscountAmount { get => productDiscountAmount; set => productDiscountAmount = value; }
        public double ProductDiscountPercentage { get => productDiscountPercentage; set => productDiscountPercentage = value; }

        internal bool notOfferDiscount()
        {
           return productDiscountPercentage == 0.0;
        }
        internal void addPriceDiscount(double discount, bool beforTax)
        {
            this.productDiscountPercentage = discount;
            this.discountBeforeTax = beforTax;
        }
        internal void priceReport()
        {
           if (notOfferDiscount())
            {
                Console.WriteLine($"TAX = {productTaxPercentage*100}%, no discount ");
                getFinalPrice();
                Console.WriteLine($"Final price = ${Math.Round(this.productPrice, 2)} ");
            }
           else
            {
                Console.WriteLine($"TAX = {productTaxPercentage * 100}%, Discount= {productDiscountPercentage*100}% ");
                getFinalPrice();
                Console.WriteLine($"Final price = $ {Math.Round(this.productPrice, 2)}  with ${Math.Round(this.productDiscountAmount,2)} discount .");
            }
        }


        public Product()
        {
        }

        public Product(string productName, int universalProductCode,  double productPrice)
        {
            this.productName = productName;
            this.universalProductCode = universalProductCode;
            this.productPrice = productPrice;
        }

        internal double getPriceDiscount()
        {
            if (this != null)
            {
                this.productDiscountAmount =  (this.productPrice * productDiscountPercentage);    
            }
            return this.productDiscountAmount;
        }

         protected void getFinalPrice()
        {   
            this.productPrice = discountBeforeTax? getPriceWithDiscountFirst() : getPriceWithTaxFirst();
        }
        internal double getPriceWithDiscountFirst()
        {
            this.productPrice = this.productPrice - getPriceDiscount();
            this.productPrice= this.productPrice * this.productTaxPercentage+this.productPrice;

            return this.productPrice;
        }
        internal double getPriceWithTaxFirst()
        {
            return this.productPrice - getPriceDiscount() + getPriceTax(); ;
        }

        internal double getPriceTax()
        {
           if (this  != null) 
            {
               this.productTaxAmount = this.productPrice * productTaxPercentage;
            }
           return productTaxAmount;
        }
    }
}