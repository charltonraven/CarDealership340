using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    class Employee
    {
        public char EmployeeID;
        public char EmployeeFirstName;
        public char EmployeeLastName;
        public DateTime HireDate;
        public char Salary;
        public char Position;



        public Employee(char EmployeeID, char EmployeeFirstName, char EmployeeLastName,
            DateTime HireDate, char Salary, char Position)
        {
            this.EmployeeID = EmployeeID;
            this.EmployeeFirstName = EmployeeFirstName;
            this.EmployeeLastName = EmployeeLastName;
            this.HireDate = HireDate;
            this.Salary = Salary;
            this.Position = Position;


        }
    }
}