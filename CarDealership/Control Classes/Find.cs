using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using MySql.Data.MySqlClient;

namespace CarDealership
{
    internal class Find
    //This class handles Acts as the control class to handle anything that have to do with looking up something 
    //Find Entites in  the database using methods for each entity needed. This also cooperates with the Edit
    // Control Class. Using a MySqlConnection is essential inorder to connect to the database.
    {
        private String myConnString;
        MySqlConnection conn;
        public Find()
        {
             myConnString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
            conn=new MySqlConnection(myConnString);

        }

        //Finds a customer using specific fields that pertain to customer. 
        //First Name, Last Name, City, CustomerID
        public void FindCustomer(Customer C)
        {
            conn.Open();

           MySqlDataAdapter MyAdapter=new MySqlDataAdapter();
           String FindCusStatement = "Select * from CUSTOMER Where CustomerID='" + C.CustomerID + "' OR CusFirstName='" +
                              C.CusFirstName +
                              "' OR CusLastName='" + C.CusLastName + "' OR City='" + C.CusCity + "';";
           MySqlCommand FindCustomerSQL = new MySqlCommand(FindCusStatement, conn);
            MyAdapter.SelectCommand = FindCustomerSQL;
            DataTable dTable=new DataTable();
            Display DisplayResults=new Display(FindCustomerSQL,MyAdapter,dTable,FindCusStatement);
            DisplayResults.Show();

        }

        //Finds a customer using specific fields that pertain to customer. 
        //First Name, Last Name, City, CustomerID
        public void FindEmployee()
        {
            conn.Open();


        }
        public void FindInventory()
        {
            conn.Open();

        }

        //Gets the total price from the list of VIN#s
        public double getPrice(List<String> VINnumbers)
        {
            conn.Open();
            MySqlCommand Price;
            MySqlDataReader myReader;
            double total = 0;

            for (int i = 0; i < VINnumbers.Count; i++)
            {
                String SelectStatement = "Select Price from Inventory where  VINnumber='" + VINnumbers.ElementAt(i).ToString() + "';";
                Price = new MySqlCommand(SelectStatement, conn);
                myReader = Price.ExecuteReader();
                myReader.Read();
                total += Convert.ToDouble(myReader.GetString(0));
                myReader.Close();
            }
            return total;

        }

        //Check to see if the Employee is eligible for a coupon, by first taking
        //the List of VIN# and getting an overall total. If it meets the requirements,
        //we then connect to the database and UPDATE the VIN# with the CustomerID.
        public String CheckCoupon(List<String>VINnumbers,String CustomerID)
        {
            String Coupon="";
            conn.Open();
            MySqlCommand Price;
            MySqlDataReader myReader;
            double total = 0;

            for (int i = 0; i < VINnumbers.Count; i++)
            {
                String SelectStatement = "Select Price from Inventory where  VINnumber='" + VINnumbers.ElementAt(i).ToString() + "';";
                Price=new MySqlCommand(SelectStatement,conn);
                myReader = Price.ExecuteReader();
                myReader.Read();
               total+= Convert.ToDouble(myReader.GetString(0));
                myReader.Close();
            }

            if (total >= 50000)
            {
                //format date
                DateTime currentDate=DateTime.Now.AddYears(1);
                String CurrentDateString = currentDate.ToString("yyyy-MM-dd");

                String UpdateCoupon = "UPDATE Customer SET Coupon='" +CurrentDateString + "' where CustomerID='" +
                                    CustomerID + "';";

                MySqlCommand UpdateCouponSQL=new MySqlCommand(UpdateCoupon,conn);
                UpdateCouponSQL.ExecuteNonQuery();
                Coupon = "Coupon Awarded!!!!!!!!!!!!!!!: Expires: " + currentDate.ToString();
            }

            return Coupon;


        }

        //Gets a CustomerID so we can use it in the form
        public Customer GetCustomer(String CustomerID)
        {
            conn.Open();
            String Customer = "Select * from Customer Where CustomerID="+CustomerID+";";
            MySqlCommand CustomerData=new MySqlCommand(Customer,conn);
            MySqlDataReader MyReader = CustomerData.ExecuteReader();
            MyReader.Read();
            if (String.IsNullOrEmpty(CustomerID))
            {
                CustomerID = "Null";
            }

            return new Customer(CustomerID, MyReader.GetString(1), MyReader.GetString(2), MyReader.GetString(3), MyReader.GetString(4), MyReader.GetString(5), MyReader.GetString(6), MyReader.GetString(7),MyReader.GetString(8),DateTime.Parse(MyReader.GetString(9)));
        }

    }
}