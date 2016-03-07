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
using System.Threading;


namespace CarDealership
{
    public partial class Login : Form
    {
        public String myConString = "SERVER=localhost;Port=3306;Database=carDealership;uid=root;Password=Raven47946$;";
        public static String Username;
        public static String Password;
        public static String Position = "";


        public Login()
        {

            InitializeComponent();



        }

        private void Login_Click(object sender, EventArgs e)
        {
            //Try Catch for checking the connections of the database
            try
            {
                MySqlConnection conn = new MySqlConnection(myConString);
                //  conn.ConnectionString = myConString;
                conn.Open();
                try
                {
                    String SelectCommand = "Select * from Employee where employeeID='" + txtID.Text + "' And password='" + txtPassword.Text + "'";
                    MySqlDataReader MyReader;
                    MySqlCommand Match = new MySqlCommand(SelectCommand, conn);
                    MyReader = Match.ExecuteReader();
                    int count = 0;
                    while (MyReader.Read()&& count !=3)
                    {
                        count++;
                    }
                    if (count == 1)
                    {
                        MyReader.Close();
                        String Position = "Select Position from Employee where employeeID='" + txtID.Text + "';";
                        MySqlCommand PositionWindow = new MySqlCommand(Position, conn);
                        MyReader = PositionWindow.ExecuteReader();
                        count = 0;
                        while (MyReader.Read())
                        {
                            Login.Position = MyReader.GetString(0);
                        }
                        this.Hide();
                        CarDealership OpenMain = new CarDealership();
                        OpenMain.Show();

                    }
                    else if (count == 0)
                        MessageBox.Show("Incorrect Password Bruh !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
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


          

            //try catch for something else

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
    }
}
