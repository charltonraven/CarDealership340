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
using System.Runtime.InteropServices;





namespace CarDealership
{
    public partial class Main_Page : Form
    {
        [DllImport("user32.dll")]
        public static extern int ExitWindowsEx(int uFlags, int dwReason);


        public static String SelectedTable;
        public Main_Page()
        {


            InitializeComponent();


        }
        public void RefreshTables()
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
            DataTable cTable = new DataTable();
            DataTable iTable = new DataTable();
            DataTable epTable = new DataTable();
            //Employee
            String ShowAllEmp = "Select * from Employee;";
            MySqlCommand ShowAllEmpSQL = new MySqlCommand(ShowAllEmp, conn);
            MySqlDataAdapter MyAdapterEmpl = new MySqlDataAdapter();
            MyAdapterEmpl.SelectCommand = ShowAllEmpSQL;
            MyAdapterEmpl.Fill(epTable);
            dgEmp.DataSource = epTable;
            //  MessageBox.Show(dgEmp.RowCount.ToString());
            // dgEmp.AutoResizeRowMode = DataGridViewAutoSizeColumnMode.AllCells;

            ////Customer
            String ShowAllCustomer = "Select * from CUSTOMER;";
            MySqlCommand ShowAllCustomerSQL = new MySqlCommand(ShowAllCustomer, conn);
            MySqlDataAdapter MyAdapterCus = new MySqlDataAdapter();
            MyAdapterCus.SelectCommand = ShowAllCustomerSQL;
            MyAdapterCus.Fill(cTable);
            dgCustomer.DataSource = cTable;
            dgCustomer.TopLeftHeaderCell.Value = "Reset";
            dgCustomer.TopLeftHeaderCell.Style.ForeColor =
            System.Drawing.Color.DeepPink;
            ////Inventory
            String ShowAllInventory = "Select * from Inventory;";
            MySqlCommand ShowAllInventorySQL = new MySqlCommand(ShowAllInventory, conn);
            MySqlDataAdapter MyAdapterInv = new MySqlDataAdapter();
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
                TabPage DeleteEmployeeTab = tabTables.SelectedTab;
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

            if (tabTables.SelectedIndex == 0)
            {
                MessageBox.Show("Your are on the Customer's Table");
                FindCustomer FindCustomer = new FindCustomer();
                FindCustomer.Show();


            }
            if (tabTables.SelectedIndex == 1)
            {
                MessageBox.Show("Your are on the Inventory's Table");
                FindInventory FindInventory = new FindInventory();
                FindInventory.Show();


            }
            if (tabTables.SelectedIndex == 2)
            {
                MessageBox.Show("Your are on the Employee's Table");
                FindEmployee FindEmployee = new FindEmployee();
                FindEmployee.Show();
                
            }

            conn.Close();
            
        }

        private void findCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindCustomer FindCustomer = new FindCustomer();
            FindCustomer.Show();
        }

        private void findEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }

        private void findInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddInventory addInventory = new AddInventory();
            addInventory.Show();
        }

        private void editStrip_Click(object sender, EventArgs e)
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

            if (tabTables.SelectedIndex == 0)
            {
              //  MessageBox.Show("Your are on the Customer's Table");
                SelectedTable = "Customer";
                FindCustomer FindCustomer = new FindCustomer();
                FindCustomer.Show();



            }
            if (tabTables.SelectedIndex == 1)
            {
                SelectedTable = "Inventory";
              //  MessageBox.Show("Your are on the Inventory's Table");
                FindInventory FindInventory = new FindInventory();
                FindInventory.Show();



            }
            if (tabTables.SelectedIndex == 2)
            {
                SelectedTable = "Employee";
              //  MessageBox.Show("Your are on the Employee's Table");
                FindEmployee EditEmployee = new FindEmployee();
                EditEmployee.Show();

            }

            conn.Close();
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
            AddCustomer CustomerWindow = new AddCustomer();
            CustomerWindow.Show();
        }

        private void addEmployeeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee newEmployee = new AddEmployee();
            newEmployee.Show();
        }

        private void addInventoryTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddInventory OpenInventory = new AddInventory();
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

            if (tabTables.SelectedIndex == 0)
            {
                MessageBox.Show("Your are on the Customer's Table");
                AddCustomer AddCustomer = new AddCustomer();
                AddCustomer.Show();


            }
            if (tabTables.SelectedIndex == 1)
            {
                MessageBox.Show("Your are on the Inventory's Table");
                AddInventory AddInventory = new AddInventory();
                AddInventory.Show();
            }
            if (tabTables.SelectedIndex == 2)
            {
                MessageBox.Show("Your are on the Employee's Table");
                AddEmployee AddEmployee = new AddEmployee();
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
            Point pt = dgCustomer.PointToClient(MousePosition);
            DataGridView.HitTestInfo hti = dgCustomer.HitTest(pt.X, pt.Y);
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
            Point pt = dgCustomer.PointToClient(MousePosition);
            DataGridView.HitTestInfo hti = dgCustomer.HitTest(pt.X, pt.Y);
            if (hti.Type == DataGridViewHitTestType.Cell)
            {
                dgCustomer.ClearSelection();
                dgCustomer.CurrentCell = dgCustomer.Rows[hti.RowIndex].Cells[hti.ColumnIndex];
                dgCustomer.Rows[hti.RowIndex].Selected = true;

                String ID = dgCustomer.Rows[hti.RowIndex].Cells[0].Value.ToString();
                MessageBox.Show(ID);
                String First = dgCustomer.Rows[hti.RowIndex].Cells[1].Value.ToString();
                String Last = dgCustomer.Rows[hti.RowIndex].Cells[2].Value.ToString();
                String DOB = dgCustomer.Rows[hti.RowIndex].Cells[3].Value.ToString();
                String Phone = dgCustomer.Rows[hti.RowIndex].Cells[4].Value.ToString();
                String Address = dgCustomer.Rows[hti.RowIndex].Cells[5].Value.ToString();
                String City = dgCustomer.Rows[hti.RowIndex].Cells[6].Value.ToString();
                String State = dgCustomer.Rows[hti.RowIndex].Cells[7].Value.ToString();
                String Zip = dgCustomer.Rows[hti.RowIndex].Cells[8].Value.ToString();
                EditCustomer ec = new EditCustomer(ID, First, Last, Phone, DOB, Address, City, State, Zip);
                ec.Show();
            }



        }

        private void dgEmp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Point pt = dgEmp.PointToClient(MousePosition);
            DataGridView.HitTestInfo hti = dgEmp.HitTest(pt.X, pt.Y);
            if (hti.Type == DataGridViewHitTestType.Cell)
            {
                dgEmp.ClearSelection();
                dgEmp.CurrentCell = dgEmp.Rows[hti.RowIndex].Cells[hti.ColumnIndex];
                dgEmp.Rows[hti.RowIndex].Selected = true;

                String ID = dgEmp.Rows[hti.RowIndex].Cells[0].Value.ToString();
                MessageBox.Show(ID);
                String EmpFirst = dgEmp.Rows[hti.RowIndex].Cells[1].Value.ToString();
                String EmpLast = dgEmp.Rows[hti.RowIndex].Cells[2].Value.ToString();
                String EmpHD = dgEmp.Rows[hti.RowIndex].Cells[3].Value.ToString();
                String Salary = dgEmp.Rows[hti.RowIndex].Cells[4].Value.ToString();
                String Position = dgEmp.Rows[hti.RowIndex].Cells[5].Value.ToString();
                EditEmployee EE = new EditEmployee(ID, EmpFirst, EmpLast, EmpHD, Salary, Position);
                EE.Show();
            }
        }

        private void dgInventory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Point pt = dgInventory.PointToClient(MousePosition);
            DataGridView.HitTestInfo hti = dgInventory.HitTest(pt.X, pt.Y);
            if (hti.Type == DataGridViewHitTestType.Cell)
            {
                dgInventory.ClearSelection();
                dgInventory.CurrentCell = dgInventory.Rows[hti.RowIndex].Cells[hti.ColumnIndex];
                dgInventory.Rows[hti.RowIndex].Selected = true;

                String ID = dgInventory.Rows[hti.RowIndex].Cells[0].Value.ToString();
                MessageBox.Show(ID);
                String year = dgInventory.Rows[hti.RowIndex].Cells[1].Value.ToString();
                String make = dgInventory.Rows[hti.RowIndex].Cells[2].Value.ToString();
                String model = dgInventory.Rows[hti.RowIndex].Cells[3].Value.ToString();
                String condition = dgInventory.Rows[hti.RowIndex].Cells[4].Value.ToString();
                String color = dgInventory.Rows[hti.RowIndex].Cells[5].Value.ToString();
                EditInventory EE = new EditInventory(ID, year, make, model, condition, color);
                EE.Show();
            }

        }

        private void fileMenuStrip_Click(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayI I = new DisplayI();
            I.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            Login LogOff = new Login();
            LogOff.Show();
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword changepassword = new ChangePassword();
            changepassword.Show();
        }
    }
}
