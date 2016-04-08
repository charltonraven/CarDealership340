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
    public partial class DisplayI : Form
    {
        public DisplayI()
        {
            InitializeComponent();
        }

        private void dgDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

       
        }

        private void DisplayI_Load(object sender, EventArgs e)
        {
            String myConnString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
            MySqlConnection conn = new MySqlConnection(myConnString);
            conn.Open();



            DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
            column.HeaderText = "Purchase Vehicles";
            column.Name = "colPuchaseVehicles";
         

            DataTable dTable=new DataTable();
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();

            dgDisplay.Columns.Insert(0, column);
            String FindInventorySR = "Select * from Inventory Where CustomerID IS NULL;";
            MySqlCommand NotPurchased = new MySqlCommand(FindInventorySR, conn);
            MyAdapter.SelectCommand = NotPurchased;
            MyAdapter.Fill(dTable);
            dgDisplay.DataSource = dTable;
      
            

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> CheckedColumns = new List<DataGridViewRow>();
            int i = 1;
            String myConnString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
            MySqlConnection conn = new MySqlConnection(myConnString);
            conn.Open();

            foreach (DataGridViewRow row in dgDisplay.Rows)
            {
                
                DataGridViewCheckBoxCell chk = row.Cells[0] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(chk.Value) == true)
                {
                    String VINnumber = row.Cells[1].Value.ToString();

                    String Statement = "UPDATE INVENTORY SET CustomerID=" + AddCustomer.CustomerID + " where VINnumber='" + VINnumber+"';";
                    MySqlCommand UpdateInventory = new MySqlCommand(Statement, conn);
                    UpdateInventory.ExecuteNonQuery();

                 

                }
                i++;
            }

            this.Close();
            conn.Close();
            
        }

        private void dgDisplay_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }
    }
}
