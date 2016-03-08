using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    class Sales
    {

        public char EmployeeID;
        public char EmployeeFirstName;
        public char EmployeeLastName;
        public DateTime HireDate;
        public char Salary;
        public String Position = "Sales";
        private double commission;
        private double amountOfSales;

        public double AmountOfSales
        {
            get {
                return amountOfSales;
            }
            set {
                amountOfSales = value;
            }
        }


         public Sales(char EmployeeID, char EmployeeFirstName, char EmployeeLastName,
            DateTime HireDate, char Salary)
        {
            this.EmployeeID = EmployeeID;
            this.EmployeeFirstName = EmployeeFirstName;
            this.EmployeeLastName = EmployeeLastName;
            this.HireDate = HireDate;
            this.Salary = Salary;
            amountOfSales = 0;
            
        }
         public void addSales(double newSaleAmount)
         {
             amountOfSales += newSaleAmount;

             reCalculateCommission();
         }
         public void reCalculateCommission()
         {
             if (amountOfSales > 200000)
             {
                 commission = amountOfSales * .1;
             }
             else if (amountOfSales > 100000)
             {
                 commission = amountOfSales * .07;
             }
             else
             {
                 commission = amountOfSales * .05;
             }
         }


    }
}
