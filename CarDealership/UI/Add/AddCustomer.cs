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
    public partial class AddCustomer : Form
    {
        public static String CustomerID = "";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

            
        String myConnString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";

        MySqlConnection conn = new MySqlConnection(myConnString);


        conn.Open();

            if (cbExisting.Checked == false) {
          Customer customer = new Customer(txtCusFirstName.Text,txtCusLastName.Text,txtDOB.Text,txtPhone.Text,txtAddress.Text,txtCity.Text,txtState.Text,txtZip.Text);
          Add AddNewCustomer = new Add(customer);
                //change
            }
            else if (cbExisting.Checked == true)
            {
                MySqlDataReader MyReader;
                String ExistingCustomerSR = "Select CustomerID from Customer Where CustomerID=" + txtCusID.Text + ";";
                MySqlCommand ExistingCustomerSQL = new MySqlCommand(ExistingCustomerSR, conn);
                MyReader = ExistingCustomerSQL.ExecuteReader();
                MyReader.Read();
                CustomerID = MyReader.GetString(0);
                MyReader.Close();
              

                DisplayI findInventory = new DisplayI();
                findInventory.Show();
                
                


            }





            txtAddress.Clear();
            txtCity.Clear();
            txtCusFirstName.Clear();
            //txtCusID.Clear();
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
            if (cbExisting.Checked == true)
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
            if (cbExisting.Checked == true)
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
