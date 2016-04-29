using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CarDealership
{
    public partial class FindEmployee : Form
    {
        public static DataTable dTable = new DataTable();
        public static MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
        public static MySqlCommand FindEmployeeSQL;
        public static string FindEmployeeSr;

        public FindEmployee()
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

        private void FindEmployee_Load(object sender, EventArgs e)
        {
            dTable.Clear();
        }

        private void btnEmpAdd_Click(object sender, EventArgs e)
        {
            //Had to make a connection to the database directly inorder to make this work
            //That is the only way that we found to do it.

            //Creates connection

            var myConnString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
            var conn = new MySqlConnection(myConnString);


            conn.Open();
            //uses the String Statement and the SQL command hold and execute for the Find employee
            //which is then accessed by the Display form.


            FindEmployeeSr = "Select * from Employee Where EmployeeID=" + txtEmpNum.Text + " OR EmployeeFirstName='" +
                             txtEmpFName.Text +
                             "' OR EmployeeLastName='" + txtEmpLName.Text + "' OR Position='" + txtPosition.Text + "';";
            MessageBox.Show(FindEmployeeSr);
            FindEmployeeSQL = new MySqlCommand(FindEmployeeSr, conn);
            MyAdapter.SelectCommand = FindEmployeeSQL;
            //Open Display Form
            var DisplayFound = new Display();
            DisplayFound.Show();
            Hide();


            txtEmpFName.Clear();
            txtEmpLName.Clear();
            txtEmpNum.Clear();
            txtPosition.Clear();
            Close();
        }
    }
}