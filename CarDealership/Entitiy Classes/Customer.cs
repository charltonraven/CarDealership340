using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CarDealership;


namespace CarDealership
{
    class Customer
    {
        public String CustomerID;
        public String CusFirstName;
        public String CusLastName;
        public String CusDOB;
        public String CusPhone;
        public String CusAddress;
        public String CusCity;
        public String CusState;
        public String CusZipCode;
        bool CarWashCoupon = false;

           


     public Customer(String CustomerID, String CusFirstName, String CusLastName, String CusDOB, String CusPhone,
         String CusAddress, String CusCity, String CusState, String CusZipCode, double SaleAmount)
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
         CheckSaleCoupon(SaleAmount);


     }

     public Customer(AddCustomer addWindow)
     {
         addWindow.Show();
     }


     public Customer(String CustomerID, String CusFirstName, String CusLastName, String CusDOB, String CusPhone,
     String CusAddress, String CusCity, String CusState, String CusZipCode)
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

     public void CheckSaleCoupon(double amount)
     {
         if (amount > 50000)
         {
             CarWashCoupon = true;

         }
     }

    }
}
