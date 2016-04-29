using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CarDealership
{
    public partial class FindCustomer : Form
    {
        public static DataTable dTable = new DataTable();
        public static MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
        public static MySqlCommand FindCustomerSQL;
        public static string FindCusStatement;


        public FindCustomer()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Had to make a connection to the database directly inorder to make this work
            //That is the only way that we found to do it.

            //Creates connection
            var myConnString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
            var conn = new MySqlConnection(myConnString);

            
            
                conn.Open();
            
             //uses the String Statement and the SQL command hold and execute for the Find Customer
            //which is then accessed by the Display form
            FindCusStatement = "Select * from CUSTOMER Where CustomerID='" + txtCustomerID.Text + "' OR CusFirstName='" +
                               txtFirstName.Text +
                               "' OR CusLastName='" + txtLastName.Text + "' OR City='" + txtCity.Text + "';";
            FindCustomerSQL = new MySqlCommand(FindCusStatement, conn);
            MyAdapter.SelectCommand = FindCustomerSQL;
           
            //opens Display Form
            Display DisplayFound = new Display();
            DisplayFound.Show();
            Hide();


            txtCustomerID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            Close();
        }

        private void FindCustomer_Load(object sender, EventArgs e)
        {
            dTable.Clear();
        }
    }
}