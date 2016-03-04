using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CarDealership
{
    public partial class Login : Form
       
    {
        public static String Username;
        public static String Password;
        public Login()
        {
            
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login.Username = txtID.Text;
            Login.Password = txtPassword.Text;
            Visible = false;
            CarDealership CD = new CarDealership();
            CD.Show();
            


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
