using System;

namespace CarDealership
{
    internal class Sales
    {
        private double commission;
        public char EmployeeFirstName;

        public char EmployeeID;
        public char EmployeeLastName;
        public DateTime HireDate;
        public string Position = "Sales";
        public char Salary;


        public Sales(char EmployeeID, char EmployeeFirstName, char EmployeeLastName,
            DateTime HireDate, char Salary)
        {
            this.EmployeeID = EmployeeID;
            this.EmployeeFirstName = EmployeeFirstName;
            this.EmployeeLastName = EmployeeLastName;
            this.HireDate = HireDate;
            this.Salary = Salary;
            AmountOfSales = 0;
        }

        public double AmountOfSales { get; set; }

        public void addSales(double newSaleAmount)
        {
            AmountOfSales += newSaleAmount;

            reCalculateCommission();
        }

        public void reCalculateCommission()
        {
            if (AmountOfSales > 200000)
            {
                commission = AmountOfSales*.1;
            }
            else if (AmountOfSales > 100000)
            {
                commission = AmountOfSales*.07;
            }
            else
            {
                commission = AmountOfSales*.05;
            }
        }
    }
}