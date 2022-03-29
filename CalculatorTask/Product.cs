namespace CalculatorTask
{
    internal class Product
    {
        private string productName;
        private int universalProductCode;
        private double dproductPrice;

        public Product()
        {
        }

        public Product(string v1, int v2,  double v3)
        {
            this.productName = v1;
            this.universalProductCode = v2;
            this.dproductPrice = v3;
        }
    }
}