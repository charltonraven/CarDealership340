using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CarDealership
{
    public partial class Login : Form
    {
        public static string Username;
        public static string Password;
        public static string Position = "";
        public static string EmployeeID;
        public string myConString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";


        public Login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            var i = 1;
            //Try Catch for checking the connections of the database
            try
            {
                var conn = new MySqlConnection(myConString);
                //  conn.ConnectionString = myConString;
                conn.Open();

                try
                {
                    //Using the BINARY keyword with the password makes it case sensitive when (by default) mysql is not case sensitive.
                    var SelectCommand = "Select * from Employee where BINARY employeeID='" + txtID.Text +
                                        "' And BINARY password='" + txtPassword.Text + "'";
                    MySqlDataReader MyReader;
                    var Match = new MySqlCommand(SelectCommand, conn);
                    MyReader = Match.ExecuteReader();
                    var count = 0;

                    while (MyReader.Read())
                    {
                        count++;
                    }
                    if (count == 1)
                    {
                        MyReader.Close();
                        var Position =
                            "Select EmployeeID, EmployeeFirstName, EmployeeLastName, Position from Employee where  employeeID='" +
                            txtID.Text + "';";
                        var PositionWindow = new MySqlCommand(Position, conn);
                        MyReader = PositionWindow.ExecuteReader();
                        count = 0;
                        while (MyReader.Read())
                        {
                            EmployeeID = MyReader.GetString(0);
                            Username = MyReader.GetString(1) + " " + MyReader.GetString(2);
                            Login.Position = MyReader.GetString(3);
                        }
                        Hide();
                        var OpenMain = new Main_Page();
                        OpenMain.Show();
                        Hide();
                    }
                    else if (count == 0)
                    {
                        MessageBox.Show("Incorrect Password, Try Again !");
                        txtID.Text = "";
                        txtPassword.Text = "";
                        i++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. ");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid Username/Password, Please try again");
                        break;
                }
            }

            if (i == 3)
            {
                MessageBox.Show("You ran out of tries");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }
    }
}