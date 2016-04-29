using System;

namespace CarDealership
{
    public class Customer
    {
        //Creates Customer Objects to hold various information about the customer
        public DateTime Coupon;
        public string CusAddress;
        public string CusCity;
        public string CusDOB;
        public string CusFirstName;
        public string CusLastName;
        public string CusPhone;
        public string CusState;
        public string CustomerID;
        public string CusZipCode;


        public Customer(string CusFirstName, string CusLastName, string CusDOB, string CusPhone,
            string CusAddress, string CusCity, string CusState, string CusZipCode) //SALE AMOUNT WAS IN HERE
        {
            this.CusFirstName = CusFirstName;
            this.CusLastName = CusLastName;
            this.CusDOB = CusDOB;
            this.CusPhone = CusPhone;
            this.CusAddress = CusAddress;
            this.CusCity = CusCity;
            this.CusState = CusState;
            this.CusZipCode = CusZipCode;
            // CheckSaleCoupon(SaleAmount);
        }
        public Customer(string CustomerID,string CusFirstName, string CusLastName, string CusDOB, string CusPhone,
        string CusAddress, string CusCity, string CusState, string CusZipCode, DateTime Coupon) //SALE AMOUNT WAS IN HERE
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
            this.Coupon = Coupon;
            
        }

      


        public Customer(string CustomerID, string CusFirstName, string CusLastName, string CusDOB, string CusPhone,
            string CusAddress, string CusCity, string CusState, string CusZipCode)
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

        public Customer(string CustomerID)
        {
            this.CustomerID = CustomerID;
        }

    }
}