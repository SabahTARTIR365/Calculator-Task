namespace CalculatorTask
{
    internal class Product
    {
        private string productName;
        private int universalProductCode;
        private Price productPrice;
      

        public Price ProductPrice { get => productPrice; set => productPrice = value; }
        public int UniversalProductCode { get => universalProductCode; set => universalProductCode = value; }
        public string ProductName { get => productName; set => productName = value; }

        public Product()
        {
        }

        public Product(string productName, int universalProductCode,  Price productPrice)
        {
            this.productName = productName;
            this.universalProductCode = universalProductCode;
            this.productPrice = productPrice;
        }

        
    }
}