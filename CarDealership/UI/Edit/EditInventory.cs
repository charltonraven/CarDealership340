using System;
using System.Windows.Forms;

namespace CarDealership
{
    public partial class EditInventory : Form
    {
        public EditInventory()
        {
            InitializeComponent();
        }

        public EditInventory(string ID, string year, string make, string model, string condition, String Damaged, string color, string price,
            string CustomerID)
        {
            InitializeComponent();
            txtID.Text = ID;
            txtYear.Text = year;
            cbMake.Text = make;
            txtModel.Text = model;
            cbCondition.Text = condition;
            txtColor.Text = color;
            txtCustomerID.Text = CustomerID;
            txtPrice.Text = price;
            cbDamaged.Text = Damaged;
        }

        public EditInventory(string ID, string year, string make, string model, string condition, string color)
        {
            InitializeComponent();
            txtID.Text = ID;
            txtYear.Text = year;
            cbMake.Text = make;
            txtModel.Text = model;
            cbCondition.Text = condition;
            txtColor.Text = color;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnVehCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditInventory_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
        }

        private void btnVehCommit_Click(object sender, EventArgs e)
        {
            //Creates an Invenory Object
            Inventory I=new Inventory(txtID.Text,txtYear.Text,cbMake.Text,txtModel.Text,cbCondition.Text,Convert.ToInt32(cbDamaged.Text),txtColor.Text,Convert.ToDouble(txtPrice.Text),txtCustomerID.Text);
            //Creats an edit control object to Edit the Inventory Object above
            Edit EditExistingInventory=new Edit();
            EditExistingInventory.EditInventory(I);

            Close();
            txtYear.Clear();
            txtColor.Clear();
            txtCustomerID.Clear();
            txtID.Clear();
            txtModel.Clear();
            txtPrice.Clear();

        }
    }
}