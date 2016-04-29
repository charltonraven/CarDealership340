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
    public partial class DisplayInvoices : Form
    {
         public Customer Customer;
        public double Price;
        public List<String> VINnumbers;
        public String TradeIn;
        public String Credit_CardNumber;
        public DisplayInvoices(Customer Customer,List<String>VINnumbers,double Price,String Credit_CardNumber)
        {
            InitializeComponent();
            if (Credit_CardNumber == "")
            {
                Credit_CardNumber = "Null";
            }
            this.Customer = Customer;
            this.VINnumbers = VINnumbers;
            this.Price = Price;
            
            this.Credit_CardNumber = Credit_CardNumber;

        }

        public DisplayInvoices(Customer Customer, List<String> VINnumbers, double Price, String Credit_CardNumber, String TradeIn)
        {
             InitializeComponent();
            if (Credit_CardNumber == "")
            {
                Credit_CardNumber = "Null";
            }
           
            this.Customer = Customer;
            this.VINnumbers = VINnumbers;
            this.Price = Price;
            this.TradeIn = TradeIn;
            this.Credit_CardNumber = Credit_CardNumber;
            

        }

        private void DisplayInvoices_Load(object sender, EventArgs e)
        {
            DateTime ConvertDateFormat = DateTime.Now;
            String CurrentDate = ConvertDateFormat.ToString("yyyy-MM-dd");
            Invoices GenerateInvoice=new Invoices(CurrentDate,Customer.CustomerID,VINnumbers,Login.EmployeeID,TradeIn);


            Add invoices=new Add();
            invoices.AddInvoice(GenerateInvoice);

            lblTrade.Text = TradeIn;
            lblEmployeeID.Text = Login.EmployeeID;
            lblName.Text = Customer.CusFirstName + " " + Customer.CusLastName;
            if (!String.IsNullOrEmpty(Credit_CardNumber))
            {
                lblPaymentInfo.Text = Credit_CardNumber.Substring(Credit_CardNumber.Length - 4, 4);
            }
            else
            {
                lblPaymentInfo.Text = "Cash";
            }
            DateTime currentDate = DateTime.Now;
            lblPurchaseDate.Text = currentDate.ToShortDateString();
            txtVins.Text = string.Join(",", VINnumbers.ToArray());

            Edit EditCommission=new Edit();
            EditCommission.CalculateCommission(Price,Login.EmployeeID);




        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtVins_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
