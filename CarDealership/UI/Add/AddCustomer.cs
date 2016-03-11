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
           
            String addCustomerSr = "INSERT INTO CUSTOMER VALUES('"+txtCusID.Text+"','"+txtCusFirstName.Text+"','"+txtCusLastName.Text+"','"+txtDOB.Text+"','"+txtPhone.Text+"','"+txtAddress.Text+"','"+txtCity.Text+"','"+txtState.Text+"','"+txtZip.Text+"')";
            MessageBox.Show(addCustomerSr);
            MySqlCommand addCustomerSQL = new MySqlCommand(addCustomerSr, conn);
            addCustomerSQL.ExecuteNonQuery();
            txtAddress.Clear();
            txtCity.Clear();
            txtCusFirstName.Clear();
            txtCusID.Clear();
            txtCusLastName.Clear();
            txtDOB.Clear();
            txtPhone.Clear();
            txtState.Text = "";
            txtZip.Clear();
            
        }
    }
}
