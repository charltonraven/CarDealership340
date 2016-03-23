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
    public partial class DisplayC : Form
    {
        public DisplayC()
        {
            InitializeComponent();
        }

        private void DisplayC_Load(object sender, EventArgs e)
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
            FindCustomer.FindCustomerSQL = new MySqlCommand(FindCustomer.FindCusStatement, conn);
            FindCustomer.MyAdapter.SelectCommand = FindCustomer.FindCustomerSQL;
            FindCustomer.MyAdapter.Fill(FindCustomer.dTable);
            dataGridView1.DataSource = FindCustomer.dTable;
            int columnCount = dataGridView1.RowCount-1;
            MessageBox.Show(columnCount.ToString());

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
