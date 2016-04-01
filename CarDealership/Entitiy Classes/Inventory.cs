using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    class Inventory
    {
        public String VinNumber;
        public String Year;
        public String Make;
        public String Model;
        public String Condition;
        public String Color;
        public String CustomerID;
        public String OnLot;
        public Double Amount;
       

       public  Inventory(String VinNumber, String Year, String Make, String Model, String Condition, String Color)
        {
            this.VinNumber = VinNumber;
            this.Year = Year;
            this.Make = Make;
            this.Model = Model;
            this.Condition = Condition;
            this.Color = Color;
        }
       public  Inventory(String VinNumber, String Year, String Make, String Model, String Condition, String Color, String CustomerID)
        {
            this.VinNumber = VinNumber;
            this.Year = Year;
            this.Make = Make;
            this.Model = Model;
            this.Condition = Condition;
            this.Color = Color;
            this.CustomerID = CustomerID;
        }
    }
}
