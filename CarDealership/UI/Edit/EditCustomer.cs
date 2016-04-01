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
using System.Globalization;
using System.Threading;
namespace CarDealership
{
    public partial class EditCustomer : Form
    {
        public EditCustomer()
        {
            InitializeComponent();

        }
        public EditCustomer(String CustomerID, String FirstName, String LastName,String Phone, String DOB, String Address, String City, String State, String ZipCode)
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
            String myConnString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
            MySqlConnection conn = new MySqlConnection(myConnString);

            DateTime PutInDateFormat = DateTime.Parse(txtDOB.Text);
            String DateFormatted = PutInDateFormat.ToString("yyyy-MM-dd");
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



            String DeleteCustomerSr = "DELETE FROM CUSTOMER WHERE CustomerID=" + txtID.Text + ";";
            MySqlCommand deleteCustomerSQL = new MySqlCommand(DeleteCustomerSr, conn);
            deleteCustomerSQL.ExecuteNonQuery();

            Customer customer = new Customer(txtID.Text, txtCusFirstName.Text, txtCusLastName.Text, DateFormatted, txtPhone.Text, txtAddress.Text, txtCity.Text, txtState.Text, txtZip.Text);
            Edit EditExisitingCustomer = new Edit(customer);

            this.Close();
        }
    }
}
