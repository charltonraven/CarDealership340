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
    public partial class Purchase : Form
    {
        public Customer Customer;
        public double price;
        public List<String> VINnumbers;
        public String TradeIn;
        
        //No
        public Purchase(Customer C, List<String> VINnumbers,double price)
        {
            InitializeComponent();
            Customer = C;
            this.VINnumbers = VINnumbers;
            this.price = price;
            TradeIn = "";

        }
        //Yes
        public Purchase(Customer C, List<String> VINnumbers, String TradeIN,double price)
        {
            InitializeComponent();
            Customer = C;
            this.VINnumbers = VINnumbers;
            this.TradeIn = TradeIN;
            this.price = price;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            CreditCard Card=new CreditCard();

            if (rbCreditCard.Checked)
            {
                Card = new CreditCard(txtCardNum.Text, txtNOC.Text, txtCVV.Text, txtEDate.Text, Customer.CustomerID);
                Add AddCreditCard = new Add();
                AddCreditCard.AddCreditCard(Card);

            }
            else
            {
                double Change = Convert.ToDouble(txtCash.Text) - Convert.ToDouble(lblPrice.Text);
                if (Change == 0)
                {
                    MessageBox.Show("Purchase Complete. Thanks");
                }
                else
                {
                    MessageBox.Show("Purchase Complete. Thanks\nChange: $"+Change);
                }

            }
            if (TradeIn.Equals(""))
            {
                DisplayInvoices Invoice = new DisplayInvoices(Customer, VINnumbers, price,Card.CardNumber);
                Invoice.Show();
            }
            else
            {
                DisplayInvoices Invoice = new DisplayInvoices(Customer, VINnumbers,price,Card.CardNumber,TradeIn);
                Invoice.Show();
            }

            this.Close();
            

        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            rbCash.Checked = true;
            lblPrice.Text = price.ToString();

        }

        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCash.Checked)
            {
                txtCVV.Enabled = false;
                txtCardNum.Enabled = false;
                txtEDate.Enabled = false;
                txtCash.Enabled = true;
                txtNOC.Enabled = false;
            }
        }

        private void rbCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCreditCard.Checked)
            {
                txtCVV.Enabled = true;
                txtCardNum.Enabled = true;
                txtEDate.Enabled = true;
                txtCash.Enabled = false;
                txtNOC.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
