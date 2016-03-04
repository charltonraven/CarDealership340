using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealership;

namespace CarDealership
{
    class Customer
    {
        public char CustomerID;
        public char CusFirstName;
        public char CusLastName;
        public DateTime CusDOB;
        public char CusPhone;
        public char CusAddress;
        public char CusCity;
        public char CusState;
        public char CusZipCode;
           


     public Customer(char CustomerID, char CusFirstName, char CusLastName, DateTime CusDOB, char CusPhone,
         char CusAddress, char CusCity, char CusState, char CusZipCode)
     {
         this.CustomerID = CustomerID;
         this.CusFirstName = CusFirstName;
         this.CusLastName = CusLastName;
         this.CusDOB = CusDOB;
         this.CusPhone = CusPhone;
         this.CusAddress = CusAddress;
         this.CusCity = CusCity;
         this.CusState = CusState;
         this.CusZipCode = CusZipCode;

     }












    }
}
