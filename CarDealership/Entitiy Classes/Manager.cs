using System;

namespace CarDealership
{
    internal class Manager
    {
        public char EmployeeFirstName;
        public char EmployeeID;
        public char EmployeeLastName;
        public DateTime HireDate;
        public string Password;
        public string Position = "Manager";
        public char Salary;


        public Manager(char EmployeeID, char EmployeeFirstName, char EmployeeLastName,
            DateTime HireDate, char Salary, string Password)
        {
            this.EmployeeID = EmployeeID;
            this.EmployeeFirstName = EmployeeFirstName;
            this.EmployeeLastName = EmployeeLastName;
            this.HireDate = HireDate;
            this.Salary = Salary;
            Position = "Manager";
            this.Password = Password;
        }
    }
}