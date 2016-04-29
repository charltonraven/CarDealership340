using System;
using MySql.Data.MySqlClient;

namespace CarDealership
{
    //This class handles Acts as the control class to Edit/commit changes for the entities to the database
    //using methods for each entity needed. 
    //Using a MySqlConnection is essential inorder to connect to the database.
    internal class Edit
    {
        public string myConnString;// = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
        private MySqlConnection conn;
        public Edit()
        {
            myConnString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
            conn = new MySqlConnection(myConnString);

        }

        //this method Deletes an Customer from the database
        public void DeleteCustomer(Customer C)
        {
            conn = new MySqlConnection(myConnString);


            conn.Open();
            

            var DeleteCustomerSr = "DELETE FROM CUSTOMER WHERE CustomerID=" + C.CustomerID + ";";
            var deleteCustomerSQL = new MySqlCommand(DeleteCustomerSr, conn);
            deleteCustomerSQL.ExecuteNonQuery();
        }
        //Connects to database to commit changes made by the EMPLOYEE
        public void EditCustomer(Customer C)
        {
            conn.Open();
            DateTime Date = Convert.ToDateTime(C.CusDOB);
            String DateFormat = Date.ToString("yyyy-MM-dd");

            String test = "Update CUSTOMER  SET CusFirstName='" + C.CusFirstName
                          + "',CusLastName='" + C.CusLastName
                          + "',CusDOB='" + DateFormat + "',CusPhone='" + C.CusPhone + "',CusAddress='" + C.CusAddress +
                          "',City='" + C.CusCity + "',State='" + C.CusState + "',ZipCode='" + C.CusZipCode +
                          "' Where CustomerID=" + C.CustomerID + ";";


            var addCustomerSQL = new MySqlCommand(test, conn);
            addCustomerSQL.ExecuteNonQuery();
            conn.Close();
        }


        //this method Deletes an employee from the database
        public void DeleteEmployee(Employee E)
        {
            conn.Open();
            if (E.EmployeeID == "" || E.EmployeeID == null)
            {
                E.EmployeeID = "EmployeeID";
            }

            var DeleteEmployeeSr = "DELETE FROM Employee WHERE EmployeeID=" + E.EmployeeID + ";";
            var deleteEmployeeSQL = new MySqlCommand(DeleteEmployeeSr, conn);
            deleteEmployeeSQL.ExecuteNonQuery();

            
        }
        //Connects to database to commit changes made by the MANAGER
        public void EditEmployee(Employee E)
        {
            DateTime Date = Convert.ToDateTime(E.HireDate);
            String DateFormat = Date.ToString("yyyy-MM-dd");
            var conn = new MySqlConnection(myConnString);


            conn.Open();


            String test = "Update EMPLOYEE  SET EmployeeFirstName='" + E.EmployeeFirstName
                           + "',EmployeeLastName='" + E.EmployeeLastName
                           + "',HireDate='" + DateFormat + "',Salary=" + E.Salary + ",Position='" +E.Position+
                           "',Password='" + E.Password + "' Where EmployeeID="+E.EmployeeID+";";
            var addEmployeeSQL = new MySqlCommand(test, conn);
            addEmployeeSQL.ExecuteNonQuery();
            conn.Close();
        }

        public void EditInventory(Inventory I)
        {
            if (I.CustomerID == "" || I.CustomerID == null)
            {
                I.CustomerID = "NULL";
            }
           
 

            conn.Open();
            String test = "Update INVENTORY  SET Year=" + I.Year
                           + ",Make='" + I.Make + "',Model='" + I.Model + "',Quality='" + I.Condition +
                           "',Damaged=" + I.Damaged + ", Color='"+I.Color+"',Price="+I.Price+" Where VINnumber='" +
                            I.VinNumber + "';";
            var addEmployeeSQL = new MySqlCommand(test, conn);
            addEmployeeSQL.ExecuteNonQuery();


          
        }

        public void UpdateInventory(String CustomerID, String VINnumber)
        {
            conn.Open();
            var Statement = "UPDATE INVENTORY SET CustomerID=" + CustomerID+ " where VINnumber='" +
                                   VINnumber + "';";
            var UpdateInventory = new MySqlCommand(Statement, conn);
            UpdateInventory.ExecuteNonQuery();
            conn.Close();
        }

        //Calculates the commission when a car is sold
        public void CalculateCommission(double Price, String EmployeeID)
        {
            conn.Open();
            double CurrentCommission = 0;
            String getCommission = "Select Commission from Employee Where EmployeeID=" + EmployeeID + ";";
            MySqlCommand getCommissionSQL = new MySqlCommand(getCommission, conn);
            MySqlDataReader Myreader = getCommissionSQL.ExecuteReader();
            Myreader.Read();
            CurrentCommission = double.Parse(Myreader.GetString(0));
            Myreader.Close();

            String UpdateCommission = "";
            MySqlCommand UpdateCommissionSQL;
            
            if (Price > 200000)
            {
                CurrentCommission+=Price*.1;
                UpdateCommission = "UPDATE EMPLOYEE SET COMMISSION=" + CurrentCommission + " Where EmployeeID=" +
                                   EmployeeID;
                UpdateCommissionSQL=new MySqlCommand(UpdateCommission,conn);
            }
            else if (Price > 100000)
            {


                CurrentCommission += Price * .07;
                UpdateCommission = "UPDATE EMPLOYEE SET COMMISSION=" + CurrentCommission + " Where EmployeeID=" +
                                   EmployeeID;
                UpdateCommissionSQL = new MySqlCommand(UpdateCommission, conn);
            }
            else
            {

                CurrentCommission += Price * .05;
                UpdateCommission = "UPDATE EMPLOYEE SET COMMISSION=" + CurrentCommission + " Where EmployeeID=" +
                                   EmployeeID;
                UpdateCommissionSQL = new MySqlCommand(UpdateCommission, conn);
                
            }

            UpdateCommissionSQL.ExecuteNonQuery();
            conn.Close();
            
        }

        public void ChangePassword(String password)
        {
            conn.Open();

            var UpdatePassword = "UPDATE EMPLOYEE SET Password='" +password + "' where EmployeeID=" +
                                         Login.EmployeeID + ";";
            var UpdatePasswordSQL = new MySqlCommand(UpdatePassword, conn);
            UpdatePasswordSQL.ExecuteNonQuery();
        }
    }
}