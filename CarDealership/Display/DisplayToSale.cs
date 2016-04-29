using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CarDealership
{
    public partial class DisplayI : Form
    {

        public String CustomerID;
        public DisplayI()
        {
            InitializeComponent();
        }
        public DisplayI(String CustomerID)
        {
            InitializeComponent();
            this.CustomerID = CustomerID;

        }

        

        private void dgDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DisplayI_Load(object sender, EventArgs e)
        {
            var myConnString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
            var conn = new MySqlConnection(myConnString);
            conn.Open();


            var column = new DataGridViewCheckBoxColumn();
            column.HeaderText = "Purchase Vehicles";
            column.Name = "colPuchaseVehicles";


            var dTable = new DataTable();
            var MyAdapter = new MySqlDataAdapter();

            dgDisplay.Columns.Insert(0, column);
            var FindInventorySR = "Select * from Inventory Where CustomerID IS NULL;";
            var NotPurchased = new MySqlCommand(FindInventorySR, conn);
            MyAdapter.SelectCommand = NotPurchased;
            MyAdapter.Fill(dTable);
            dgDisplay.DataSource = dTable;
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            List<String> vinNumbers=new List<string>();
       
            var CheckedColumns = new List<DataGridViewRow>();
            var i = 1;
        

            foreach (DataGridViewRow row in dgDisplay.Rows)
            {
                var chk = row.Cells[0] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(chk.Value))
                {
                    var VINnumber = row.Cells[1].Value.ToString();
                    vinNumbers.Add(VINnumber);
                    Edit UpdateInventory=new Edit();
                    UpdateInventory.UpdateInventory(CustomerID,VINnumber);

     
                }
                i++;
            }

            double price = new Find().getPrice(vinNumbers);

            WeeklySales Sales=new WeeklySales(price,vinNumbers,CustomerID);
            Sales.Show();

          
          // Find findControl=new Find();
          //String CheckCoupon= findControl.CheckCoupon(vinNumbers,CustomerID);


          //  if (CheckCoupon != "")
          //  {
          //      MessageBox.Show(CheckCoupon);
          //  }


          //  String Trade = "Do you have a Trade-In?";
          //  var result = MessageBox.Show(Trade, "Caption", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

          //    Find FindCustomer=new Find();
          //     Customer CusInfo= FindCustomer.GetCustomer(CustomerID);
          //  if (result == DialogResult.Yes)
          //  {
          //      TradeIn HandleTradeIns = new TradeIn(CustomerID,vinNumbers);
          //      HandleTradeIns.Show();
          //      this.Hide();

          //  }
          //  else
          //  {
          //      //need one here
          //     Purchase VehiclePurchase = new Purchase(CusInfo, vinNumbers);
          //      VehiclePurchase.Show();
          //  }
           


            this.Hide();


        }

        private void dgDisplay_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}