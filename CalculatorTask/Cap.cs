namespace CalculatorTask
{
    internal class Cap
    {
        private double value;
        private bool isCapPersentage;

        public Cap(double value, bool isPercentage)
        {
            this.Value = value;
            this.IsCapPersentage = isPercentage;
        }

        public double Value { get => value; set => this.value = value; }
        public bool IsCapPersentage { get => isCapPersentage; set => isCapPersentage = value; }
    }
}