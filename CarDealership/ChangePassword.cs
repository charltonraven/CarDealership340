using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CarDealership
{
    public partial class ChangePassword : Form
    {
        private static int i = 0;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String myConnString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
            MySqlConnection conn = new MySqlConnection(myConnString);

            conn.Open();

            String password = "Select Password FROM EMPLOYEE Where EmployeeID=" + Login.EmployeeID + " AND BINARY Password='" + txtCurrentPassword.Text + "';";
            MySqlDataReader MyReader;
            MySqlCommand PasswordMatch = new MySqlCommand(password, conn);
            MyReader = PasswordMatch.ExecuteReader();

          
            int count = 0;

            if (i <= 3)
            {
                i++;
                while (MyReader.Read())
                {
                    count++;
                }

                if (count == 1)
                {
                    MyReader.Close();
                    String UpdatePassword = "UPDATE EMPLOYEE SET Password='" + txtNewPassword.Text + "' where EmployeeID=" + Login.EmployeeID + ";";
                    MySqlCommand UpdatePasswordSQL = new MySqlCommand(UpdatePassword, conn);
                    UpdatePasswordSQL.ExecuteNonQuery();
                    MessageBox.Show("Password Changed");
                    this.Close();
                }
                else
                {
                    if (i == 3)
                    {

                        MessageBox.Show("Too Many Tries, Goodbye");
                        this.Close();
                    }
                    else if (i < 3)
                    {
                        MessageBox.Show("Incorrect Password Try Again " + i);
                        txtCurrentPassword.Clear();
                        txtNewPassword.Clear();
                    }
                    
                }
            }
           

        }
        }
    }
