using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CarDealership
{
    public partial class Main_Page : Form
    {
        public static string SelectedTable;

        public Main_Page()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        public static extern int ExitWindowsEx(int uFlags, int dwReason);

        public void RefreshTables()
        {
            var myConnString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
            var conn = new MySqlConnection(myConnString);

            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
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
            var cTable = new DataTable();
            var iTable = new DataTable();
            var epTable = new DataTable();
            //Employee
            var ShowAllEmp = "Select * from Employee;";
            var ShowAllEmpSQL = new MySqlCommand(ShowAllEmp, conn);
            var MyAdapterEmpl = new MySqlDataAdapter();
            MyAdapterEmpl.SelectCommand = ShowAllEmpSQL;
            MyAdapterEmpl.Fill(epTable);
            dgEmp.DataSource = epTable;
            //  MessageBox.Show(dgEmp.RowCount.ToString());
            // dgEmp.AutoResizeRowMode = DataGridViewAutoSizeColumnMode.AllCells;

            ////Customer
            var ShowAllCustomer = "Select * from CUSTOMER;";
            var ShowAllCustomerSQL = new MySqlCommand(ShowAllCustomer, conn);
            var MyAdapterCus = new MySqlDataAdapter();
            MyAdapterCus.SelectCommand = ShowAllCustomerSQL;
            MyAdapterCus.Fill(cTable);
            dgCustomer.DataSource = cTable;
            dgCustomer.TopLeftHeaderCell.Value = "Reset";
            dgCustomer.TopLeftHeaderCell.Style.ForeColor =
                Color.DeepPink;
            ////Inventory
            var ShowAllInventory = "Select * from Inventory;";
            var ShowAllInventorySQL = new MySqlCommand(ShowAllInventory, conn);
            var MyAdapterInv = new MySqlDataAdapter();
            MyAdapterInv.SelectCommand = ShowAllInventorySQL;
            MyAdapterInv.Fill(iTable);
            dgInventory.DataSource = iTable;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CarDealership_Load(object sender, EventArgs e)
        {
            lblUsername.Text = Login.Username;
            lblPosition.Text = Login.Position;


            RefreshTables();


            //Make The Employee tab not show up if it is a sales employee.
            tabTables.SelectTab(tabEmployee);
            if (Login.Position == "Sales")
            {
                var DeleteEmployeeTab = tabTables.SelectedTab;
                tabTables.TabPages.Remove(DeleteEmployeeTab);
            }
            tabTables.SelectTab(tabCustomer);
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void onLotToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        private void findToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var myConnString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
            var conn = new MySqlConnection(myConnString);

            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
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

            if (tabTables.SelectedIndex == 0)
            {
              
                var FindCustomer = new FindCustomer();
                FindCustomer.Show();
            }
            if (tabTables.SelectedIndex == 1)
            {
               
                var FindInventory = new FindInventory();
                FindInventory.Show();
            }
            if (tabTables.SelectedIndex == 2)
            {
               
                var FindEmployee = new FindEmployee();
                FindEmployee.Show();
            }

            conn.Close();
        }

        private void findCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FindCustomer = new FindCustomer();
            FindCustomer.Show();
        }

        private void findEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addEmployee = new AddEmployee();
            addEmployee.Show();
        }

        private void findInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addInventory = new AddInventory();
            addInventory.Show();
        }

        private void editStrip_Click(object sender, EventArgs e)
        {
           

            if (tabTables.SelectedIndex == 0)
            {
               
                SelectedTable = "Customer";
                var FindCustomer = new FindCustomer();
                FindCustomer.Show();
            }
            if (tabTables.SelectedIndex == 1)
            {
                SelectedTable = "Inventory";
              
                var FindInventory = new FindInventory();
                FindInventory.Show();
            }
            if (tabTables.SelectedIndex == 2)
            {
                SelectedTable = "Employee";
            
                var EditEmployee = new FindEmployee();
                EditEmployee.Show();
            }

            
        }

        private void process1_Exited(object sender, EventArgs e)
        {
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {
        }

        private void CarMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void addCustomerTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CustomerWindow = new AddCustomer();
            CustomerWindow.Show();
        }

        private void addEmployeeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newEmployee = new AddEmployee();
            newEmployee.Show();
        }

        private void addInventoryTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenInventory = new AddInventory();
            OpenInventory.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void tabCustomer_Click(object sender, EventArgs e)
        {
        }

        private void tabCustomer_BindingContextChanged(object sender, EventArgs e)
        {
        }

        private void tabCustomer_DragOver(object sender, DragEventArgs e)
        {
        }

        private void refreshStrip_Click(object sender, EventArgs e)
        {
            RefreshTables();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshTables();
        }

        private void stripAddCustomer_Click(object sender, EventArgs e)
        {
            var myConnString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
            var conn = new MySqlConnection(myConnString);

            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
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

            if (tabTables.SelectedIndex == 0)
            {
               // MessageBox.Show("Your are on the Customer's Table");
                var AddCustomer = new AddC();
                AddCustomer.Show();
            }
            if (tabTables.SelectedIndex == 1)
            {
              //  MessageBox.Show("Your are on the Inventory's Table");
                var AddInventory = new AddInventory();
                AddInventory.Show();
            }
            if (tabTables.SelectedIndex == 2)
            {
               // MessageBox.Show("Your are on the Employee's Table");
                var AddEmployee = new AddEmployee();
                AddEmployee.Show();
            }

            conn.Close();
        }

        private void customerStrip_Click(object sender, EventArgs e)
        {
        }

        private void dgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgCustomer.MultiSelect == true)
            //{
            //    MessageBox.Show("Multiple is selected");
            //    //}
            // String famous = dgCustomer.Rows[1].Cells.ToString
            var pt = dgCustomer.PointToClient(MousePosition);
            var hti = dgCustomer.HitTest(pt.X, pt.Y);
            if (hti.Type == DataGridViewHitTestType.Cell)
            {
                dgCustomer.ClearSelection();
                dgCustomer.CurrentCell = dgCustomer.Rows[hti.RowIndex].Cells[hti.ColumnIndex];
                dgCustomer.Rows[hti.RowIndex].Selected = true;
            }
        }

        private void dgCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //  
            var pt = dgCustomer.PointToClient(MousePosition);
            var hti = dgCustomer.HitTest(pt.X, pt.Y);
            if (hti.Type == DataGridViewHitTestType.Cell)
            {
                dgCustomer.ClearSelection();
                dgCustomer.CurrentCell = dgCustomer.Rows[hti.RowIndex].Cells[hti.ColumnIndex];
                dgCustomer.Rows[hti.RowIndex].Selected = true;

                var ID = dgCustomer.Rows[hti.RowIndex].Cells[0].Value.ToString();
                MessageBox.Show(ID);
                var First = dgCustomer.Rows[hti.RowIndex].Cells[1].Value.ToString();
                var Last = dgCustomer.Rows[hti.RowIndex].Cells[2].Value.ToString();
                var DOB = dgCustomer.Rows[hti.RowIndex].Cells[3].Value.ToString();
                var Phone = dgCustomer.Rows[hti.RowIndex].Cells[4].Value.ToString();
                var Address = dgCustomer.Rows[hti.RowIndex].Cells[5].Value.ToString();
                var City = dgCustomer.Rows[hti.RowIndex].Cells[6].Value.ToString();
                var State = dgCustomer.Rows[hti.RowIndex].Cells[7].Value.ToString();
                var Zip = dgCustomer.Rows[hti.RowIndex].Cells[8].Value.ToString();
                var ec = new EditCustomer(ID, First, Last, Phone, DOB, Address, City, State, Zip);
                ec.Show();
            }
        }

        private void dgEmp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var pt = dgEmp.PointToClient(MousePosition);
            var hti = dgEmp.HitTest(pt.X, pt.Y);
            if (hti.Type == DataGridViewHitTestType.Cell)
            {
                dgEmp.ClearSelection();
                dgEmp.CurrentCell = dgEmp.Rows[hti.RowIndex].Cells[hti.ColumnIndex];
                dgEmp.Rows[hti.RowIndex].Selected = true;

                var ID = dgEmp.Rows[hti.RowIndex].Cells[0].Value.ToString();
                MessageBox.Show(ID);
                var EmpFirst = dgEmp.Rows[hti.RowIndex].Cells[1].Value.ToString();
                var EmpLast = dgEmp.Rows[hti.RowIndex].Cells[2].Value.ToString();
                var EmpHD = dgEmp.Rows[hti.RowIndex].Cells[3].Value.ToString();
                var Salary = dgEmp.Rows[hti.RowIndex].Cells[4].Value.ToString();
                var Position = dgEmp.Rows[hti.RowIndex].Cells[5].Value.ToString();
                var Password = dgEmp.Rows[hti.RowIndex].Cells[6].Value.ToString();
                var EE = new EditEmployee(ID, EmpFirst, EmpLast, EmpHD, Salary, Position,Password);
                EE.Show();
            }
        }

        private void dgInventory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var pt = dgInventory.PointToClient(MousePosition);
            var hti = dgInventory.HitTest(pt.X, pt.Y);
            if (hti.Type == DataGridViewHitTestType.Cell)
            {
                dgInventory.ClearSelection();
                dgInventory.CurrentCell = dgInventory.Rows[hti.RowIndex].Cells[hti.ColumnIndex];
                dgInventory.Rows[hti.RowIndex].Selected = true;

                var ID = dgInventory.Rows[hti.RowIndex].Cells[0].Value.ToString();
                MessageBox.Show(ID);
                var year = dgInventory.Rows[hti.RowIndex].Cells[1].Value.ToString();
                var make = dgInventory.Rows[hti.RowIndex].Cells[2].Value.ToString();
                var model = dgInventory.Rows[hti.RowIndex].Cells[3].Value.ToString();
                var condition = dgInventory.Rows[hti.RowIndex].Cells[4].Value.ToString();
                var color = dgInventory.Rows[hti.RowIndex].Cells[5].Value.ToString();
                var EE = new EditInventory(ID, year, make, model, condition, color);
                EE.Show();
            }
        }

        private void fileMenuStrip_Click(object sender, EventArgs e)
        {
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addCustomer = new AddCustomer();
            addCustomer.Show();
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var I = new DisplayI();
            I.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var LogOff = new Login();
            LogOff.Show();
            Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var changepassword = new ChangePassword();
            changepassword.Show();
        }

        private void templatesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xxToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

        }
    }
}