namespace CalculatorTask
{
    internal class Price
    {
        private double priceValue;
        private string currencyType;

        public Price(double price, string currencyType)
        {
            this.PriceValue = price;
            this.CurrencyType = currencyType;
        }

        public double PriceValue { get => priceValue; set => priceValue = value; }
        public string CurrencyType { get => currencyType; set => currencyType = value; }
    }
}