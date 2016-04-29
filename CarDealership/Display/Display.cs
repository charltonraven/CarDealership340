using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CarDealership
{
    public partial class Display : Form
    {
        private String myConnString;
        MySqlConnection conn;
        public Display()
        {
            InitializeComponent();
        }

        public Display(MySqlCommand SqlCommand, MySqlDataAdapter MyAdapter, DataTable dTable, String SQLStatement)
        {
            myConnString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
            conn = new MySqlConnection(myConnString);

            SqlCommand = new MySqlCommand(SQLStatement, conn);
            MyAdapter.SelectCommand = SqlCommand;
            MyAdapter.Fill(dTable);
            dgDisplay.DataSource = dTable;
            
        }

        private void dgDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Display_Load(object sender, EventArgs e)
        {
            //    MessageBox.Show(Main_Page.SelectedTable);


            var myConnString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
            var conn = new MySqlConnection(myConnString);
            conn.Open();


            if (Main_Page.SelectedTable == "Customer")
            {

                FindCustomer.FindCustomerSQL = new MySqlCommand(FindCustomer.FindCusStatement, conn);
                FindCustomer.MyAdapter.SelectCommand = FindCustomer.FindCustomerSQL;
                FindCustomer.MyAdapter.Fill(FindCustomer.dTable);
                dgDisplay.DataSource = FindCustomer.dTable;
            }
            else if (Main_Page.SelectedTable == "Inventory")
            {
                FindInventory.FindInventorySQL = new MySqlCommand(FindInventory.FindInventoryStatement, conn);
                FindInventory.MyAdapter.SelectCommand = FindInventory.FindInventorySQL;
                FindInventory.MyAdapter.Fill(FindInventory.dTable);
                dgDisplay.DataSource = FindInventory.dTable;
            }


            else
            {
                FindEmployee.FindEmployeeSQL = new MySqlCommand(FindEmployee.FindEmployeeSr, conn);
                FindEmployee.MyAdapter.SelectCommand = FindEmployee.FindEmployeeSQL;
                FindEmployee.MyAdapter.Fill(FindEmployee.dTable);
                dgDisplay.DataSource = FindEmployee.dTable;
            }
        }

        private void dgDisplay_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //  MessageBox.Show(Main_Page.SelectedTable);


            var myConnString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
            var conn = new MySqlConnection(myConnString);
            conn.Open();


            if (Main_Page.SelectedTable == "Customer")
            {
                var pt = dgDisplay.PointToClient(MousePosition);
                var hti = dgDisplay.HitTest(pt.X, pt.Y);
                if (hti.Type == DataGridViewHitTestType.Cell)
                {
                    dgDisplay.ClearSelection();
                    dgDisplay.CurrentCell = dgDisplay.Rows[hti.RowIndex].Cells[hti.ColumnIndex];
                    dgDisplay.Rows[hti.RowIndex].Selected = true;

                    var ID = dgDisplay.Rows[hti.RowIndex].Cells[0].Value.ToString();
                    MessageBox.Show(ID);
                    var First = dgDisplay.Rows[hti.RowIndex].Cells[1].Value.ToString();
                    var Last = dgDisplay.Rows[hti.RowIndex].Cells[2].Value.ToString();
                    var DOB = dgDisplay.Rows[hti.RowIndex].Cells[3].Value.ToString();
                    var Phone = dgDisplay.Rows[hti.RowIndex].Cells[4].Value.ToString();
                    var Address = dgDisplay.Rows[hti.RowIndex].Cells[5].Value.ToString();
                    var City = dgDisplay.Rows[hti.RowIndex].Cells[6].Value.ToString();
                    var State = dgDisplay.Rows[hti.RowIndex].Cells[7].Value.ToString();
                    var Zip = dgDisplay.Rows[hti.RowIndex].Cells[8].Value.ToString();
                    var ec = new EditCustomer(ID, First, Last, Phone, DOB, Address, City, State, Zip);
                    ec.Show();
                    Close();
                }
            }
            else if (Main_Page.SelectedTable == "Inventory")
            {
                var pt = dgDisplay.PointToClient(MousePosition);
                var hti = dgDisplay.HitTest(pt.X, pt.Y);
                if (hti.Type == DataGridViewHitTestType.Cell)
                {
                    dgDisplay.ClearSelection();
                    dgDisplay.CurrentCell = dgDisplay.Rows[hti.RowIndex].Cells[hti.ColumnIndex];
                    dgDisplay.Rows[hti.RowIndex].Selected = true;

                    var VINnumber = dgDisplay.Rows[hti.RowIndex].Cells[0].Value.ToString();
                    var Year = dgDisplay.Rows[hti.RowIndex].Cells[1].Value.ToString();
                    var Make = dgDisplay.Rows[hti.RowIndex].Cells[2].Value.ToString();
                    var Model = dgDisplay.Rows[hti.RowIndex].Cells[3].Value.ToString();
                    var Quality = dgDisplay.Rows[hti.RowIndex].Cells[4].Value.ToString();
                    var Damage = dgDisplay.Rows[hti.RowIndex].Cells[5].Value.ToString();
                    var Color = dgDisplay.Rows[hti.RowIndex].Cells[6].Value.ToString();
                    var Price = dgDisplay.Rows[hti.RowIndex].Cells[7].Value.ToString();
                    var CustomerID = dgDisplay.Rows[hti.RowIndex].Cells[8].Value.ToString();
                    var ei = new EditInventory(VINnumber, Year, Make, Model, Quality,Damage, Color, Price, CustomerID);
                    ei.Show();
                    Close();
                }
            }
            else
            {
                var pt = dgDisplay.PointToClient(MousePosition);
                var hti = dgDisplay.HitTest(pt.X, pt.Y);
                if (hti.Type == DataGridViewHitTestType.Cell)
                {
                    dgDisplay.ClearSelection();
                    dgDisplay.CurrentCell = dgDisplay.Rows[hti.RowIndex].Cells[hti.ColumnIndex];
                    dgDisplay.Rows[hti.RowIndex].Selected = true;

                    var ID = dgDisplay.Rows[hti.RowIndex].Cells[0].Value.ToString();
                    MessageBox.Show(ID);
                    var First = dgDisplay.Rows[hti.RowIndex].Cells[1].Value.ToString();
                    var Last = dgDisplay.Rows[hti.RowIndex].Cells[2].Value.ToString();
                    var HireDate = dgDisplay.Rows[hti.RowIndex].Cells[3].Value.ToString();
                    var Salary = dgDisplay.Rows[hti.RowIndex].Cells[4].Value.ToString();
                    var Position = dgDisplay.Rows[hti.RowIndex].Cells[5].Value.ToString();
                    var Password = dgDisplay.Rows[hti.RowIndex].Cells[6].Value.ToString();
                    var ec = new EditEmployee(ID, First, Last, HireDate, Salary, Position,Password);
                    ec.Show();
                    Close();
                }
            }
        }
    }
}