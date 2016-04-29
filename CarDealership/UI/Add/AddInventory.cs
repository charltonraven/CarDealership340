using System;
using System.Windows.Forms;

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
            int length = txtVehicleID.Text.Length;
            if (txtVehicleID.Text.Length > 17)
            {
                MessageBox.Show("VIN# is too Long");
            }
            else
            {
                var inventory = new Inventory(txtVehicleID.Text, txtYear.Text, cbMake.Text, txtModel.Text,
                "New",0, txtVehicleColor.Text, double.Parse(txtPrice.Text), "");
                //Creates an Add control class to Add the Inveontory object to the database
                 var addNewInventory = new Add();

                 addNewInventory.AddInventory(inventory);

           

            txtVehicleColor.Clear();
            txtVehicleID.Clear();
            txtModel.Clear();
            txtPrice.Clear();
            txtVehicleColor.Clear();
            txtYear.Clear();
            }
          
            
            
        }

        private void AddInventory_Load(object sender, EventArgs e)
        {
        }

        private void cbTradeIn_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rbNewCustomBool_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rbCustID_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void txtCustID_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtVehicleID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}