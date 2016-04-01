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
    public partial class EditEmployee : Form
    {
        public EditEmployee()
        {
            InitializeComponent();
        }
        public EditEmployee(String EmployeeID, String EmployeeFirst, String EmployeeLast,String EmployeeHireDate,String Salary,String Position)
        {
            InitializeComponent();
            txtEmpNum.Text = EmployeeID;
            txtEmpFName.Text = EmployeeFirst;
            txtEmpLName.Text = EmployeeLast;
            txtEmpHD.Text = EmployeeHireDate;
            txtEmployeeSalary.Text = Salary;
            txtPosition.Text = Position;
            
        }
       

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEmpCommit_Click(object sender, EventArgs e)
        {
            String myConnString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
            MySqlConnection conn = new MySqlConnection(myConnString);

            DateTime PutInDateFormat = DateTime.Parse(txtEmpHD.Text);
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



            String DeleteEmployeeSr = "DELETE FROM Employee WHERE EmployeeID=" + txtEmpNum.Text+ ";";
            MySqlCommand deleteEmployeeSQL = new MySqlCommand(DeleteEmployeeSr, conn);
            deleteEmployeeSQL.ExecuteNonQuery();

            Employee employee = new Employee(txtEmpNum.Text, txtEmpFName.Text, txtEmpLName.Text, DateFormatted, txtEmployeeSalary.Text, txtPosition.Text, txtPassword.Text);
            Edit EditExistingEmployee = new Edit(employee);
            
            this.Close();
        }

        private void EditEmployee_Load(object sender, EventArgs e)
        {
            txtEmpNum.Enabled = false;
            txtEmpHD.Enabled = false;

        }
    }
}
