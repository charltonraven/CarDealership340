using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarDealership
{
    public partial class TradeIn : Form
    {
        public String TradeCar = "";
        public String CustomerID;
        public List<String> VINnumbers;
        public double price;
        public TradeIn(String CustomerID, List<String> VINnumbers,double price )
        {
            InitializeComponent();
            this.CustomerID = CustomerID;
            this.VINnumbers = VINnumbers;
            this.price = price;
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
            if (txtVehicleID.Text.Length > 17)
            {
                MessageBox.Show("VIN# IS TOO LONG !");
                txtVehicleID.Clear();
            }
            else {
            TradeCar = txtVehicleID.Text;
            Bluebook BluebookVehiclePrice = new Bluebook(ddMake.Text,int.Parse(cbDamaged.Text));
            var addTradeIN = new Inventory(txtVehicleID.Text, txtYear.Text, ddMake.Text, txtModel.Text,
                "Used", int.Parse(cbDamaged.Text), txtVehicleColor.Text,BluebookVehiclePrice.Price,"");
            var TradeIN = new Add();
            
            TradeIN.AddTradeIN(addTradeIN);
            //need it here
            Find FindCustomer = new Find();
            Customer CusInfo = FindCustomer.GetCustomer(CustomerID);
            Purchase VehiclePurchase = new Purchase(CusInfo, VINnumbers,txtVehicleID.Text,price);
            VehiclePurchase.Show();
            this.Hide();
            }
         


            
            txtVehicleColor.Clear();
            txtVehicleID.Clear();
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
    }
}