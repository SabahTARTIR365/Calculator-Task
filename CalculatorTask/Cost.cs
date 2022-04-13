namespace CalculatorTask
{
    internal class Cost
    {
        private double costValue;
        private double costpercentage;
        private bool   iscostFromPrice=false; 

        public Cost(double costValue)
        {
            this.CostValue = costValue;
        }

        public Cost(double costpercentage, bool costFromPrice) 
        {
            this.Costpercentage = costpercentage;
            this.CostFromPrice = costFromPrice;

        }

        public double CostValue { get => costValue; set => costValue = value; }
        public double Costpercentage { get => costpercentage; set => costpercentage = value; }
        public bool CostFromPrice { get => iscostFromPrice; set => iscostFromPrice = value; }
    }
}