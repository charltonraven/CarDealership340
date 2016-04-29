using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    class Invoices
    {
        public String PurchaseDate;
        public String CustomerID;
        public String TradeinVINnumber;
        public List<String> ListofVINnumbers;
        public String EmployeeID;


        public Invoices(String PurchaseDate, String CustomerID, List<String> ListofVINnumbers,
            String EmployeeID, String TradeinVINnumber)
        {
            this.PurchaseDate = PurchaseDate;
            this.CustomerID = CustomerID;
            this.TradeinVINnumber = TradeinVINnumber;
            this.ListofVINnumbers = ListofVINnumbers;
            this.EmployeeID = EmployeeID;
        }
        //public Invoices(String PurchaseDate, String CustomerID, List<String> ListofVINnumbers,
        //  String EmployeeID)
        //{
        //    this.PurchaseDate = PurchaseDate;
        //    this.CustomerID = CustomerID;
        //    this.ListofVINnumbers = ListofVINnumbers;
        //    this.EmployeeID = EmployeeID;
        //}
         

    }
}
