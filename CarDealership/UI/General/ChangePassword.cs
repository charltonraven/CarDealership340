using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CarDealership
{
    public partial class ChangePassword : Form
    {
        private static int i;

        public ChangePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myConnString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
            var conn = new MySqlConnection(myConnString);

            conn.Open();

            String password = "Select Password FROM EMPLOYEE Where EmployeeID=" + Login.EmployeeID +
                           " AND BINARY Password='" + txtCurrentPassword.Text + "';";
            MySqlDataReader MyReader;
            var PasswordMatch = new MySqlCommand(password, conn);
            MyReader = PasswordMatch.ExecuteReader();


            var count = 0;

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
                    Edit ChangePassword=new Edit();
                    ChangePassword.ChangePassword(txtNewPassword.Text);
                    MessageBox.Show("Password Changed");
                    Close();
                }
                else
                {
                    if (i == 3)
                    {
                        MessageBox.Show("Too Many Tries, Goodbye");
                        Close();
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