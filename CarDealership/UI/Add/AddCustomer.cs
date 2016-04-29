using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CarDealership
{
    public partial class AddCustomer : Form
    {
     

        public AddCustomer()
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


        //Whether or not the Check box for existing Customer or not
        //this goes with the flow of Make Purchase to add customer if it is not checked
        //or Continue if it is checked and a CustomerID is given.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            String CustomerID = "";
            
 

            if (cbExisting.Checked == false)
            {
               //Creates customer object
                Customer customer = new Customer(txtCusFirstName.Text, txtCusLastName.Text, txtDOB.Text, txtPhone.Text, txtAddress.Text, txtCity.Text, txtState.Text, txtZip.Text);
               //Creates add Control to addd customer above to the database and extract the 
                //CustomerID for the next form
                Add AddNewCustomer = new Add();
                CustomerID=AddNewCustomer.AddCustomer(customer);
                //displays Onlot Cars ready to be sold
                DisplayI findInventory = new DisplayI(CustomerID);
                findInventory.Show();
                this.Close();
            
                
            }
            else if (cbExisting.Checked == true)
            {
    
                //displays Onlot Cars ready to be sold
                DisplayI findInventory = new DisplayI(txtCusID.Text);
                findInventory.Show();
                this.Close();
            }





           


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
            //Disables some of the text fields 
            txtCusID.Enabled = false;
            if (cbExisting.Checked)
            {
                txtAddress.Enabled = false;
                txtCity.Enabled = false;
                txtCusFirstName.Enabled = false;
                txtCusLastName.Enabled = false;
                txtDOB.Enabled = false;
                txtPhone.Enabled = false;
                txtState.Enabled = false;
                txtZip.Enabled = false;
            }
        }

        private void ddState_SelectedItemChanged(object sender, EventArgs e)
        {
        }

        private void ddState_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void cbExisting_CheckedChanged(object sender, EventArgs e)
        {
            //Makes Check boxes work approprately 
            if (cbExisting.Checked)
            {
                btnAdd.Text = "Continue";
                txtCusID.Enabled = true;
                txtAddress.Enabled = false;
                txtCity.Enabled = false;
                txtCusFirstName.Enabled = false;
                txtCusLastName.Enabled = false;
                txtDOB.Enabled = false;
                txtPhone.Enabled = false;
                txtState.Enabled = false;
                txtZip.Enabled = false;
            }
            else if (cbExisting.Checked == false)
            {
                btnAdd.Text = "Add";
                txtCusID.Enabled = false;
                txtAddress.Enabled = true;
                txtCity.Enabled = true;
                txtCusFirstName.Enabled = true;
                txtCusLastName.Enabled = true;
                txtDOB.Enabled = true;
                txtPhone.Enabled = true;
                txtState.Enabled = true;
                txtZip.Enabled = true;
            }
        }
    }
}