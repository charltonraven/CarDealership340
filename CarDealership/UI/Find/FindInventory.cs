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
    public partial class FindInventory : Form
    {
        public static DataTable dTable = new DataTable();
        public static MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
        public static MySqlCommand FindInventorySQL;
        public static String FindInventoryStatement;
   
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

            FindInventoryStatement = "Select * from INVENTORY Where CustomerID='" + txtCustomerID.Text + "' OR VINnumber='" + txtVin.Text +
                "' OR Year='" + ddYear.Text + "' OR Model='" + ddModel.Text + "' OR Make='"+ddMake.Text+"'OR Quality='"+ddCondition.Text+"' OR Color='"+txtColor.Text+"';";

            FindInventorySQL = new MySqlCommand(FindInventoryStatement, conn);
            MyAdapter.SelectCommand = FindInventorySQL;
           // DisplayI DisplayInventory = new DisplayI();
           // DisplayInventory.Show();
            Display DisplayFound = new Display();
            DisplayFound.Show();
            this.Hide();


            this.Close();

        }
    }
}
