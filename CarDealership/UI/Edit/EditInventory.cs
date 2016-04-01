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
    public partial class EditInventory : Form
    {
        public EditInventory()
        {
            InitializeComponent();
        }
        public EditInventory(String ID, String year, String make, String model, String condition, String color){
            InitializeComponent();
            txtID.Text = ID;
            ddYear.Text = year;
            ddMake.Text = make;
            ddModel.Text = model;
            ddCondition.Text = condition;
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

        }
    }
}
