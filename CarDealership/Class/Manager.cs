using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    class Manager
    {
        public char EmployeeID;
        public char EmployeeFirstName;
        public char EmployeeLastName;
        public DateTime HireDate;
        public char Salary;
        public String Position = "Manager";
        public String Password;


         public Manager(char EmployeeID, char EmployeeFirstName, char EmployeeLastName,
            DateTime HireDate, char Salary, String Password)
        {
            this.EmployeeID = EmployeeID;
            this.EmployeeFirstName = EmployeeFirstName;
            this.EmployeeLastName = EmployeeLastName;
            this.HireDate = HireDate;
            this.Salary = Salary;
            this.Position="Manager";
            this.Password = Password;
            


        }
    }


}
