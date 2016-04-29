using System;
using System.Windows.Forms;

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
            //Creates an employee Object
            var employee = new Employee(txtEmpNum.Text, txtEmpFName.Text, txtEmpLName.Text, txtEmpHireDate.Text,
                txtSalary.Text, txtPosition.Text);
            //Creates a control enity to Add the employee Object to the database
            var addnewEmployee = new Add();
            addnewEmployee.AddEmployee(employee);
            
            Close();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            txtEmpNum.Enabled = false;
            txtEmpFName.Text = "";
            txtEmpHireDate.Text = "";
            txtEmpLName.Text = "";
            txtPosition.Text = "";
            txtSalary.Text = "";

        }

        private void txtEmpNum_TextChanged(object sender, EventArgs e)
        {
        }
    }
}