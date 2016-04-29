using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealership
{
    public partial class WeeklySales : Form
    {
        public List<String> vinNumbers;
        public String CustomerID;
        public double price;
        public WeeklySales(double price, List<String> vinNumbers,String CustomerID)
        {
            InitializeComponent();
            this.price = price;
            this.vinNumbers = vinNumbers;
            this.CustomerID = CustomerID;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (rbFlatRate.Checked)
            {
                price -= double.Parse(txtFlatRate.Text);
            }
            else if (rbPercentage.Checked)
            {

                price -=(price* double.Parse(txtPercentages.Text))/100 ;

            }
            else
            {
                
            }
            Find findControl = new Find();
            String CheckCoupon = findControl.CheckCoupon(vinNumbers, CustomerID);


            if (CheckCoupon != "")
            {
                MessageBox.Show(CheckCoupon);
            }


            String Trade = "Do you have a Trade-In?";
            var result = MessageBox.Show(Trade, "Caption", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            Find FindCustomer = new Find();
            Customer CusInfo = FindCustomer.GetCustomer(CustomerID);
            if (result == DialogResult.Yes)
            {
                TradeIn HandleTradeIns = new TradeIn(CustomerID, vinNumbers,price);
                HandleTradeIns.Show();
                this.Hide();

            }
            else
            {
                //need one here
                Purchase VehiclePurchase = new Purchase(CusInfo, vinNumbers,price);
                VehiclePurchase.Show();
            }



            this.Hide();
        }

        private void WeeklySales_Load(object sender, EventArgs e)
        {

        }

       
    }
}
