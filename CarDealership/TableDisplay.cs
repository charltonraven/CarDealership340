using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

using Microsoft.Office.Tools.Word;


namespace CarDealership
{
    class TableDisplay
    {
        public  DataTable dTable = new DataTable();
        public  MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
        public  MySqlCommand FindCustomerSQL;
        public  String FindCusStatement;
        public 

        TableDisplay(DataTable dTable, MySqlDataAdapter MyAdapter, MySqlCommand FindCustomerSQL, String FindCusStatement)
        {
            this.dTable = dTable;
            this.MyAdapter = MyAdapter;
            this.FindCustomerSQL = FindCustomerSQL;
            this.FindCusStatement = FindCusStatement;




        }

        public void Display()
        {
            //FindCustomerSQL = new MySqlCommand(FindCusStatement, conn);
            //MyAdapter.SelectCommand = FindCustomer.FindCustomerSQL;
            //MyAdapter.Fill(FindCustomer.dTable);
            //DataGridView1.DataSource = FindCustomer.dTable;
            

           
        }
        
    }
}
