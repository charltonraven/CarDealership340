using System;
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

        public EditEmployee(string EmployeeID, string EmployeeFirst, string EmployeeLast, string EmployeeHireDate,
            string Salary, string Position,String Password)
        {
            InitializeComponent();
            txtEmpNum.Text = EmployeeID;
            txtEmpFName.Text = EmployeeFirst;
            txtEmpLName.Text = EmployeeLast;
            txtEmpHD.Text = EmployeeHireDate;
            txtEmployeeSalary.Text = Salary;
            txtPosition.Text = Position;
            txtPassword.Text = Password;
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
            //Get appropriate date format to make passing to the database eaiser.
            var PutInDateFormat = DateTime.Parse(txtEmpHD.Text);
            var DateFormatted = PutInDateFormat.ToString("yyyy-MM-dd");
           
            //Creates an employee object
            var employee = new Employee(txtEmpNum.Text, txtEmpFName.Text, txtEmpLName.Text, DateFormatted,
                txtEmployeeSalary.Text, txtPosition.Text, txtPassword.Text);
            //Creats an edit control object to Edit the employee Object above
            Edit EditExistingEmployee = new Edit();
            EditExistingEmployee.EditEmployee(employee);

            Close();
        }

        private void EditEmployee_Load(object sender, EventArgs e)
        {
            txtEmpNum.Enabled = false;
            txtEmpHD.Enabled = false;
        }

        private void btnCusDelete_Click(object sender, EventArgs e)
        {
            Employee DeleteEmployee = new Employee(txtEmpNum.Text);
            Edit Delete = new Edit();
            Delete.DeleteEmployee(DeleteEmployee);
        }
    }
}