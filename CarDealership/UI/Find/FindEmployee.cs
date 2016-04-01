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
    public partial class FindEmployee : Form
    {
        public static DataTable dTable = new DataTable();
        public static MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
        public static MySqlCommand FindEmployeeSQL;
        public static String FindEmployeeSr;
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
             String myConnString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
            MySqlConnection conn = new MySqlConnection(myConnString);

            
                conn.Open();
            
         
            FindEmployeeSr = "Select * from Employee Where EmployeeID=" + txtEmpNum.Text + " OR EmployeeFirstName='" + txtEmpFName.Text +
                "' OR EmployeeLastName='" + txtEmpLName.Text +"' OR Position='" + txtPosition.Text + "';";
            MessageBox.Show(FindEmployeeSr);
            FindEmployeeSQL = new MySqlCommand(FindEmployeeSr, conn);
            MyAdapter.SelectCommand = FindEmployeeSQL;
            DisplayE DisplayEmployee = new DisplayE();
            DisplayEmployee.Show();
            this.Hide();





           txtEmpFName.Clear();
           txtEmpLName.Clear();
            txtEmpNum.Clear();
            txtPosition.Clear();
        }

      
        }
    }
