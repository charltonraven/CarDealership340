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
    public partial class FindCustomer : Form
    {
        public static DataTable dTable = new DataTable();
        public static MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
        public static MySqlCommand FindCustomerSQL;
        public static String FindCusStatement;
   



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
            String myConnString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
            MySqlConnection conn = new MySqlConnection(myConnString);

            try
            {
                conn.Open();
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

            FindCusStatement = "Select * from CUSTOMER Where CustomerID='" + txtCustomerID.Text + "' OR CusFirstName='" + txtFirstName.Text +
                "' OR CusLastName='" + txtLastName.Text + "' OR City='" + txtCity.Text + "';";
            MessageBox.Show(FindCusStatement);
            FindCustomerSQL = new MySqlCommand(FindCusStatement, conn);
            MyAdapter.SelectCommand = FindCustomerSQL;
            DisplayC DisplayCustomer = new DisplayC();
            DisplayCustomer.Show();
            this.Hide();





            txtCustomerID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
        }

        private void FindCustomer_Load(object sender, EventArgs e)
        {
         dTable.Clear();
        }
    }
}
