using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CarDealership
{
    public partial class FindInventory : Form
    {
        public static DataTable dTable = new DataTable();
        public static MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
        public static MySqlCommand FindInventorySQL;
        public static string FindInventoryStatement;

        public FindInventory()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnVehCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FindInventory_Load(object sender, EventArgs e)
        {
        }

        private void btnVehAdd_Click(object sender, EventArgs e)
        {

            //Had to make a connection to the database directly inorder to make this work
            //That is the only way that we found to do it.

            //Creates connection
       
            var myConnString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
            var conn = new MySqlConnection(myConnString);

            
                conn.Open();
            
            
            
            //If we are adding a new vehicle the damange will be 0
            if (cbQuality.Text == "New")
            {
                cbDamaged.Text = "0";
            }

            //uses the String Statement and the SQL command hold and execute for the Find Customer
            //which is then accessed by the Display form
            FindInventoryStatement = "Select * from INVENTORY Where CustomerID='" + txtCustomerID.Text +
                                     "' OR VINnumber='" + txtVin.Text +
                                     "' OR Year='" + txtYear.Text + "' OR Model='" + txtModel.Text + "' OR Make='" +
                                    cbMake.Text + "' OR Color='" + txtColor.Text +
                                     "' OR  Quality='" + cbQuality.Text + "' AND Damaged="+cbDamaged.Text+";";

            FindInventorySQL = new MySqlCommand(FindInventoryStatement, conn);
            MyAdapter.SelectCommand = FindInventorySQL;
            //Opens Display Form
            var DisplayFound = new Display();
            DisplayFound.Show();
            Hide();


            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbQuality.Text == "New")
            {
                cbDamaged.Enabled = false;
            }
            else if (cbQuality.Text == "Used")
            {
                cbDamaged.Enabled = true;
            }
        }
    }
}