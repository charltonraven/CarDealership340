using System;

namespace CarDealership
//Creates Inventory Objects to hold various information about the Inventory
{
    internal class Inventory

    {
        public double Amount;
        public string Color;
        public string Condition;
        public string CustomerID;
        public int Damaged;
        public string Make;
        public string Model;
        public string OnLot;
        public string VinNumber;
        public string Year;
        public double Price;




     
        public Inventory(string VinNumber, string Year, string Make, string Model, string Condition, int Damaged, string Color, double Price,
           string CustomerID)
        {
            this.VinNumber = VinNumber;
            this.Year = Year;
            this.Make = Make;
            this.Model = Model;
            this.Condition = Condition;
            this.Color = Color;
            this.Price = Price;
            this.Damaged = Damaged;
            this.CustomerID = CustomerID;
        }
    }
}