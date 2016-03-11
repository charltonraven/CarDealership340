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
    public partial class AddInventory : Form
    {
        public AddInventory()
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

        private void btnVehAdd_Click(object sender, EventArgs e)
        {
            String myConnString = "SERVER=localhost;Port=3306;Database=carDealership;uid=root;Password=Raven47946$;";
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

            String addVehicleSr = "INSERT INTO Vehicle VALUES('" + txtVehicleID.Text +"','" + ddVehicleYear.Text+ 
                "','" + ddVehicleMake.Text + "','" + ddVehicleModel.Text + "','" 
                + ddVehicleCondition.Text+ "','" + txtVehicleColor.Text + "')";
            MessageBox.Show(addVehicleSr);
            MySqlCommand addVehicleSQL = new MySqlCommand(addVehicleSr, conn);
            addVehicleSQL.ExecuteNonQuery();
            txtCustomerID.Clear();
            txtVehicleColor.Clear();
            txtVehicleID.Clear();
            
            
            
           
        }
    }
}
