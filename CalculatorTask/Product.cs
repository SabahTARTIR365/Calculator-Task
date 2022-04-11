﻿namespace CalculatorTask
{
    internal class Product
    {
        private string productName;
        private int universalProductCode;
        private double productPrice;
       
        public double ProductPrice { get => productPrice; set => productPrice = value; }


        public Product()
        {
        }

        public Product(string productName, int universalProductCode,  double productPrice)
        {
            this.productName = productName;
            this.universalProductCode = universalProductCode;
            this.productPrice = productPrice;
        }

        
    }
}