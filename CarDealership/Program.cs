using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CarDealership
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());


            String myConString = "SERVER=localhost;Database=carDealership;uid=root;Password=Raven47946$;";
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = myConString;
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("FAILED BITCH");
            }

            


            
        }
    }
}
