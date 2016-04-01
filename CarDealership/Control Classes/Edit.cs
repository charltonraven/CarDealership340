using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CarDealership
{
    class Edit
    {

 public  String myConnString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
       public Edit(Customer C)
        {
           // String myConnString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
            MySqlConnection conn = new MySqlConnection(myConnString);


            conn.Open();
           //delete then add back
            String EditCustomerSr = "INSERT INTO CUSTOMER VALUES("+C.CustomerID+",'" + C.CusFirstName
                                                                  + "','" + C.CusLastName + "','" + C.CusDOB
                                                                  + "','" + C.CusPhone + "','" + C.CusAddress
                                                                  + "','" + C.CusCity + "','" + C.CusState
                                                                  + "','" + C.CusZipCode + "')";

            System.Console.WriteLine(EditCustomerSr);
            MySqlCommand addCustomerSQL = new MySqlCommand(EditCustomerSr, conn);
            addCustomerSQL.ExecuteNonQuery();
        }
       public Edit(Employee E)
        {
            MySqlConnection conn = new MySqlConnection(myConnString);


            conn.Open();
            if (E.EmployeeID == "" || E.EmployeeID == null)
            {
                E.EmployeeID = "EmployeeID";
            }
           

            String addEmployeeSr = "INSERT INTO EMPLOYEE VALUES(" + E.EmployeeID + ",'" + E.EmployeeFirstName + "','" + E.EmployeeLastName + "','"
                + E.HireDate + "','" + E.Salary + "','" + E.Position + "','"+E.Password+"');";
            MySqlCommand addEmployeeSQL = new MySqlCommand(addEmployeeSr, conn);
            addEmployeeSQL.ExecuteNonQuery();

        }
       public Edit(Inventory I)
        {
            if (I.CustomerID == "" || I.CustomerID == null)
            {
                I.CustomerID = "NULL";
            }
           // String myConn String = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
            MySqlConnection conn = new MySqlConnection(myConnString);


            conn.Open();



            //String EditInventorySr = "UPDATE Inventory SET VINnumber='" + E.EmployeeID + "', Year='" + E.EmployeeFirstName + "',Make='" + E.EmployeeLastName + "',Model='" + E.HireDate +
            //               "',Salary=" + E.Salary + ",Position='" + E.Position + "',Password='ChangePassword';";
            //MySqlCommand EditInventorySQL = new MySqlCommand(EditInventorySr, conn);
            //EditInventorySQL.ExecuteNonQuery();


           


        }
    }
}
