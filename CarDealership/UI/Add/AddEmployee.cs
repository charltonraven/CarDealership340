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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
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

        private void btnEmpAdd_Click(object sender, EventArgs e)
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

            String addEmployeeSr = "INSERT INTO EMPLOYEE VALUES('" + txtEmpNum.Text + "','" +txtEmpFName.Text + "','" + txtEmpLName.Text + "','" 
                + txtEmpHireDate.Text + "','" + txtSalary.Text + "','" + txtPosition.Text + "','" + txtPassword.Text +"');";
            MessageBox.Show(addEmployeeSr);
            MySqlCommand addEmployeeSQL = new MySqlCommand(addEmployeeSr, conn);
            addEmployeeSQL.ExecuteNonQuery();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
