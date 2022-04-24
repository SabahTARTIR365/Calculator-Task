namespace CalculatorTask
{
    internal class Cost
    {
        private double costValue;
  
        private bool   iscostPercentage=false;
        private string costType;

        public Cost(double costValue,bool iscostPercentage, string costType)
        {
            this.CostValue = costValue;
            this.CostType = costType;
            this.IscostPercentage = iscostPercentage;
        }


        public double CostValue { get => costValue; set => costValue = value; }
      
        public string CostType { get => costType; set => costType = value; }
        public bool IscostPercentage { get => iscostPercentage; set => iscostPercentage = value; }
    }
}