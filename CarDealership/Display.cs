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
    public partial class Display : Form
    {
        public Display()
        {

            InitializeComponent();
        }

        private void dgDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Display_Load(object sender, EventArgs e)
        {

            
        //    MessageBox.Show(Main_Page.SelectedTable);


            String myConnString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
            MySqlConnection conn = new MySqlConnection(myConnString);
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


            String myConnString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
            MySqlConnection conn = new MySqlConnection(myConnString);
            conn.Open();


            if (Main_Page.SelectedTable == "Customer")
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
            else if (Main_Page.SelectedTable == "Inventory")
            {
                Point pt = dgDisplay.PointToClient(MousePosition);
                DataGridView.HitTestInfo hti = dgDisplay.HitTest(pt.X, pt.Y);
                if (hti.Type == DataGridViewHitTestType.Cell)
                {
                    dgDisplay.ClearSelection();
                    dgDisplay.CurrentCell = dgDisplay.Rows[hti.RowIndex].Cells[hti.ColumnIndex];
                    dgDisplay.Rows[hti.RowIndex].Selected = true;

                    String VINnumber = dgDisplay.Rows[hti.RowIndex].Cells[0].Value.ToString();
                    String Year = dgDisplay.Rows[hti.RowIndex].Cells[1].Value.ToString();
                    String Make = dgDisplay.Rows[hti.RowIndex].Cells[2].Value.ToString();
                    String Model = dgDisplay.Rows[hti.RowIndex].Cells[3].Value.ToString();
                    String Quality = dgDisplay.Rows[hti.RowIndex].Cells[4].Value.ToString();
                    String Color = dgDisplay.Rows[hti.RowIndex].Cells[5].Value.ToString();
                    String CustomerID = dgDisplay.Rows[hti.RowIndex].Cells[6].Value.ToString();
                    EditInventory ei = new EditInventory(VINnumber, Year, Make, Model, Quality, Color, CustomerID);
                    ei.Show();
                    this.Close();
                }

            }
            else
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
                    String HireDate = dgDisplay.Rows[hti.RowIndex].Cells[3].Value.ToString();
                    String Salary = dgDisplay.Rows[hti.RowIndex].Cells[4].Value.ToString();
                    String Position = dgDisplay.Rows[hti.RowIndex].Cells[5].Value.ToString();
                    String Password = dgDisplay.Rows[hti.RowIndex].Cells[6].Value.ToString();
                    EditEmployee ec = new EditEmployee(ID, First, Last, HireDate, Salary, Position);
                    ec.Show();
                    this.Close();
                }

            }
        }
    }
}

