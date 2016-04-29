using System;

namespace CarDealership
{
    internal class Employee
    {
        //Creates Employee Objects to hold various information about the Employee
        public string EmployeeFirstName;
        public string EmployeeID;
        public string EmployeeLastName;
        public string HireDate;
        public string Password;
        public string Position;
        public string Salary;


        public Employee(string EmployeeID, string EmployeeFirstName, string EmployeeLastName,
            string HireDate, string Salary, string Position, string password)
        {
            this.EmployeeID = EmployeeID;
            this.EmployeeFirstName = EmployeeFirstName;
            this.EmployeeLastName = EmployeeLastName;
            this.HireDate = HireDate;
            this.Salary = Salary;
            this.Position = Position;
            Password = password;
        }

        public Employee(string EmployeeID, string EmployeeFirstName, string EmployeeLastName,
            string HireDate, string Salary, string Position)
        {
            this.EmployeeID = EmployeeID;
            this.EmployeeFirstName = EmployeeFirstName;
            this.EmployeeLastName = EmployeeLastName;
            this.HireDate = HireDate;
            this.Salary = Salary;
            this.Position = Position;
        }

        public Employee(String EmployeeID)
        {
            this.EmployeeID = EmployeeID;
        }

       
    }
}