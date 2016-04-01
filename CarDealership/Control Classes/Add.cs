using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CarDealership
{
    class Add
    {
       public  String myConnString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
       public Add(Customer C)
        {

            DateTime DateValue = DateTime.Parse(C.CusDOB);
            String ConvertDateFormat = DateValue.ToString("yyyy-MM-dd");
            C.CusDOB = ConvertDateFormat;
            MySqlConnection conn = new MySqlConnection(myConnString);


            conn.Open();


            String addCustomerSr = "INSERT INTO CUSTOMER VALUES(CustomerID,'" + C.CusFirstName
                                                                + "','" + C.CusLastName + "','" + C.CusDOB
                                                                + "','" + C.CusPhone + "','" + C.CusAddress
                                                                + "','" + C.CusCity + "','" + C.CusState
                                                                + "','" + C.CusZipCode + "')";

            System.Console.WriteLine(addCustomerSr);
            MySqlCommand addCustomerSQL = new MySqlCommand(addCustomerSr, conn);
            addCustomerSQL.ExecuteNonQuery();
        }
       public Add(Employee E)
        {
            
            MySqlConnection conn = new MySqlConnection(myConnString);


            conn.Open();
            if (E.EmployeeID == "" || E.EmployeeID == null)
            {
                E.EmployeeID = "EmployeeID";
            }

            String addEmployeeSr = "INSERT INTO EMPLOYEE VALUES(" + E.EmployeeID + ",'" + E.EmployeeFirstName + "','" + E.EmployeeLastName + "','"
                + E.HireDate + "','" + E.Salary + "','" + E.Position + "','NULL');";
            MySqlCommand addEmployeeSQL = new MySqlCommand(addEmployeeSr, conn);
            addEmployeeSQL.ExecuteNonQuery();


        }
       public Add(Inventory I)
        {
            if (I.CustomerID == "" || I.CustomerID == null)
            {
                I.CustomerID = "NULL";
            }
           // String myConn String = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
            MySqlConnection conn = new MySqlConnection(myConnString);


            conn.Open();




            String addVehicleSr = "INSERT INTO Inventory VALUES('" + I.VinNumber + "'," + I.Year +
                ",'" + I.Make + "','" + I.Model + "','"
                + I.Condition + "','" + I.Color + "', " + I.CustomerID + ")";


            MySqlCommand addVehicleSQL = new MySqlCommand(addVehicleSr, conn);




            addVehicleSQL.ExecuteNonQuery();


        }
    }
}
