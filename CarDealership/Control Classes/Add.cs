using System;
using MySql.Data.MySqlClient;

namespace CarDealership
{
    //This class handles Acts as the control class to add entities to the database
    //using methods for each entity needed.
    internal class Add
    {
        public string myConnString;
        private MySqlConnection conn;

        public Add()
        {
              myConnString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
              conn = new MySqlConnection(myConnString);
            
        }
        public String  AddCustomer(Customer C)
        {
            String CustomerID = "";
            var DateValue = DateTime.Parse(C.CusDOB);
            var ConvertDateFormat = DateValue.ToString("yyyy-MM-dd");
            C.CusDOB = ConvertDateFormat;
            var conn = new MySqlConnection(myConnString);


            conn.Open();


            var addCustomerSr = "INSERT INTO CUSTOMER VALUES(CustomerID,'" + C.CusFirstName
                                + "','" + C.CusLastName + "','" + C.CusDOB
                                + "','" + C.CusPhone + "','" + C.CusAddress
                                + "','" + C.CusCity + "','" + C.CusState
                                + "','" + C.CusZipCode + "',NULL)";

           
            var addCustomerSQL = new MySqlCommand(addCustomerSr, conn);
            addCustomerSQL.ExecuteNonQuery();

            String GetCustomerID = "Select CustomerID from Customer Where CusFirstName='" + C.CusFirstName +
                                   "'AND CusLastName='" + C.CusLastName + "'AND CusPhone='" + C.CusPhone + "'";
            MySqlDataReader ReadCustomerID;
            MySqlCommand CustomerIDSQL=new MySqlCommand(GetCustomerID,conn);
            ReadCustomerID = CustomerIDSQL.ExecuteReader();
            ReadCustomerID.Read();
          CustomerID=ReadCustomerID.GetString(0);
          conn.Close();

            return CustomerID;





        }
        

        public void AddEmployee(Employee E)
        {
            var PutInDateFormat = DateTime.Parse(E.HireDate);
            var DateFormatted = PutInDateFormat.ToString("yyyy-MM-dd");

            var conn = new MySqlConnection(myConnString);

            var DefaultPassword = "ChangePassword";
            conn.Open();
            if (E.EmployeeID == "" || E.EmployeeID == null)
            {
                E.EmployeeID = "EmployeeID";
            }

            var addEmployeeSr = "INSERT INTO EMPLOYEE VALUES(" + E.EmployeeID + ",'" + E.EmployeeFirstName + "','" +
                                E.EmployeeLastName + "','"
                                + DateFormatted + "','" + E.Salary + "','" + E.Position + "','" + DefaultPassword +
                                "',0);";
            var addEmployeeSQL = new MySqlCommand(addEmployeeSr, conn);
            addEmployeeSQL.ExecuteNonQuery();
        }

        public void AddInventory(Inventory I)
        {
            if (I.CustomerID == "" || I.CustomerID == null)
            {
                I.CustomerID = "NULL";
            }
            // String myConn String = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
            var conn = new MySqlConnection(myConnString);


            conn.Open();


            var addVehicleSr = "INSERT INTO Inventory VALUES('" + I.VinNumber + "'," + I.Year +
                               ",'" + I.Make + "','" + I.Model + "','"
                               + I.Condition + "',"+I.Damaged+",'" + I.Color + "',"+I.Price+", " + I.CustomerID + ")";


            var addVehicleSQL = new MySqlCommand(addVehicleSr, conn);


            addVehicleSQL.ExecuteNonQuery();
        }
        public void AddTradeIN(Inventory I)
        {
           
            if (I.CustomerID == "" || I.CustomerID == null)
            {
                I.CustomerID = "NULL";
            }
            var conn = new MySqlConnection(myConnString);


            conn.Open();


            var addVehicleSr = "INSERT INTO Inventory VALUES('" + I.VinNumber + "'," + I.Year +
                               ",'" + I.Make + "','" + I.Model + "','"
                               + I.Condition + "'," + I.Damaged + ",'" + I.Color + "',"+I.Price+",NULL)";


            var addVehicleSQL = new MySqlCommand(addVehicleSr, conn);


            addVehicleSQL.ExecuteNonQuery();
        }

        public void AddInvoice(Invoices invoice)
        {
            if (invoice.TradeinVINnumber == "")
            {
                
            }
            String VINs = String.Join(",", invoice.ListofVINnumbers.ToArray());
            conn.Open();
            String Vin = "";
            DateTime ConvertDateFormat = DateTime.Now;
            String CurrentDate = ConvertDateFormat.ToString("yyyy-MM-dd");

            String MakeInvoices = "INSERT INTO INVOICES VALUES('" + CurrentDate + "'," + invoice.CustomerID + ",'" +VINs +
                                  "','" + invoice.TradeinVINnumber + "'," + invoice.EmployeeID + ");";

            MySqlCommand ExecuteInvoices=new MySqlCommand(MakeInvoices,conn);
            ExecuteInvoices.ExecuteNonQuery();


        }

        public void AddCreditCard(CreditCard Card)
        {
            conn.Open();

            String CreditCardSTR = "INSERT INTO CREDIT_CARD VALUES('" + Card.CardNumber + "','" + Card.NameOnCard +
                                   "','" + Card.CVV + "','" + Card.ExpirationDate + "'," + Card.CustomerID + ");";

            MySqlCommand CreditCardSQL=new MySqlCommand(CreditCardSTR,conn);
            CreditCardSQL.ExecuteNonQuery();
            conn.Close();
        }

    }
}