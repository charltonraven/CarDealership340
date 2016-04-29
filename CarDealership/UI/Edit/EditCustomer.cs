using System;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CarDealership
{
    public partial class EditCustomer : Form
    {
        public EditCustomer()
        {
            InitializeComponent();
        }

        public EditCustomer(string CustomerID, string FirstName, string LastName, string Phone, string DOB,
            string Address, string City, string State, string ZipCode)
        {
            InitializeComponent();
            txtID.Text = CustomerID;
            txtCusFirstName.Text = FirstName;
            txtCusLastName.Text = LastName;
            txtPhone.Text = Phone;
            txtDOB.Text = DOB;
            txtAddress.Text = Address;
            txtCity.Text = City;
            txtState.Text = State;
            txtZip.Text = ZipCode;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CustomerTemplate1_Load(object sender, EventArgs e)
        {
            txtDOB.Enabled = false;
            txtID.Enabled = false;
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {



         
            //Formatts the date so it could be add to the Database easier
            var PutInDateFormat = DateTime.Parse(txtDOB.Text);
            var DateFormatted = PutInDateFormat.ToString("yyyy-MM-dd");
    
            //Creates a Customer Object
            var customer = new Customer(txtID.Text, txtCusFirstName.Text, txtCusLastName.Text, DateFormatted,
                txtPhone.Text, txtAddress.Text, txtCity.Text, txtState.Text, txtZip.Text);
            //Creats an edit control object to Edit the Customer Object above
            var EditExisitingCustomer = new Edit();
            EditExisitingCustomer.EditCustomer(customer);

            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Customer DeleteCustomer=new Customer(txtID.Text);
            Edit Delete=new Edit();
            Delete.DeleteCustomer(DeleteCustomer);
        }
    }
}