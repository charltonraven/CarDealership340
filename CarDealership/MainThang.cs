﻿using System;
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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CarDealership_Load(object sender, EventArgs e)
        {
            tabTables.SelectTab(tabEmployee);

            // lblPosition.Text= Login.Position.;
            if (Login.Position == "Sales")
            {


                TabPage DeleteEmployeeTab = tabTables.SelectedTab;
                tabTables.TabPages.Remove(DeleteEmployeeTab);

                //  if(conn.State==ConnectionState.Open){
                //    MessageBox.Show("Connection YAY !");
                //}
                



            }
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
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
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
    }
}
