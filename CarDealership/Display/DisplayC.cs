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
            FindCustomer.FindCustomerSQL = new MySqlCommand(FindCustomer.FindCusStatement, conn);
            FindCustomer.MyAdapter.SelectCommand = FindCustomer.FindCustomerSQL;
            FindCustomer.MyAdapter.Fill(FindCustomer.dTable);
            dgDisplay.DataSource = FindCustomer.dTable;
            int columnCount = dgDisplay.RowCount-1;
            //MessageBox.Show(columnCount.ToString());

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Point pt = dgDisplay.PointToClient(MousePosition);
            DataGridView.HitTestInfo hti = dgDisplay.HitTest(pt.X, pt.Y);
            if (hti.Type == DataGridViewHitTestType.Cell)
            {
                dgDisplay.ClearSelection();
                dgDisplay.CurrentCell = dgDisplay.Rows[hti.RowIndex].Cells[hti.ColumnIndex];
                dgDisplay.Rows[hti.RowIndex].Selected = true;

                String ID = dgDisplay.Rows[hti.RowIndex].Cells[0].Value.ToString();
                MessageBox.Show(ID);
                String First = dgDisplay.Rows[hti.RowIndex].Cells[1].Value.ToString();
                String Last = dgDisplay.Rows[hti.RowIndex].Cells[2].Value.ToString();
                String DOB = dgDisplay.Rows[hti.RowIndex].Cells[3].Value.ToString();
                String Phone = dgDisplay.Rows[hti.RowIndex].Cells[4].Value.ToString();
                String Address = dgDisplay.Rows[hti.RowIndex].Cells[5].Value.ToString();
                String City = dgDisplay.Rows[hti.RowIndex].Cells[6].Value.ToString();
                String State = dgDisplay.Rows[hti.RowIndex].Cells[7].Value.ToString();
                String Zip = dgDisplay.Rows[hti.RowIndex].Cells[8].Value.ToString();
                EditCustomer ec = new EditCustomer(ID, First, Last, Phone, DOB, Address, City, State, Zip);
                ec.Show();
                this.Close();
            }
        }
    }
}
