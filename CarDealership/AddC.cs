using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CarDealership
{
    public partial class AddC : Form
    {


        public AddC()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          

               Customer customer = new Customer(txtCusFirstName.Text, txtCusLastName.Text, txtDOB.Text, txtPhone.Text, txtAddress.Text, txtCity.Text, txtState.Text, txtZip.Text);
                Add AddNewCustomer = new Add();
            AddNewCustomer.AddCustomer(customer);
               

            
            txtAddress.Clear();
            txtCity.Clear();
            txtCusFirstName.Clear();
            txtCusLastName.Clear();
            txtDOB.Clear();
            txtPhone.Clear();
            txtState.Text = "";
            txtZip.Clear();
            txtState.Clear();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

            txtCusID.Enabled = false;
       
            
        }

        private void ddState_SelectedItemChanged(object sender, EventArgs e)
        {
        }

        private void ddState_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void cbExisting_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}