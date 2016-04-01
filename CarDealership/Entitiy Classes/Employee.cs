using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    class Employee
    {
        public String EmployeeID;
        public String EmployeeFirstName;
        public String EmployeeLastName;
        public String HireDate;
        public String Salary;
        public String Position;
        public String Password;
        



        public Employee(String EmployeeID, String EmployeeFirstName, String EmployeeLastName,
            String HireDate, String Salary, String Position,String password)
        {
            this.EmployeeID = EmployeeID;
            this.EmployeeFirstName = EmployeeFirstName;
            this.EmployeeLastName = EmployeeLastName;
            this.HireDate = HireDate;
            this.Salary = Salary;
            this.Position = Position;
            this.Password = password;


        }
        public Employee(String EmployeeID, String EmployeeFirstName, String EmployeeLastName,
            String HireDate, String Salary, String Position)
        {
            this.EmployeeID = EmployeeID;
            this.EmployeeFirstName = EmployeeFirstName;
            this.EmployeeLastName = EmployeeLastName;
            this.HireDate = HireDate;
            this.Salary = Salary;
            this.Position = Position;
        }
        public Employee(String EmployeeID, String Password)
        {

        }

    }
}