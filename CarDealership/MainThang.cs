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
    public partial class CarDealership : Form
    {
        public CarDealership()
        {
            

            InitializeComponent();
           

        }
        public void RefreshTables()
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
            String ShowAllInventory = "Select * from Vehicle;";
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

            RefreshTables();
           


            //Make The Employee tab not show up if it is a sales employee.
            tabTables.SelectTab(tabEmployee);
            if (Login.Position == "Sales")
            {
                TabPage DeleteEmployeeTab = tabTables.SelectedTab;
                tabTables.TabPages.Remove(DeleteEmployeeTab);

    

            }
            tabTables.SelectTab(tabCustomer);
            lblPosition.Text = Login.Position;


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
    }
}
