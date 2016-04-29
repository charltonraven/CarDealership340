using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    //Entity Class to calculate Bluebook Information
    class Bluebook
    {
        public double Price;




        public Bluebook(String Make,int Damaged)
        {
            //Mitsubishi
            if (Make.Equals("Bugatti"))
            {
                Price = (20000 + 60000)*(1 - ((double)Damaged)/6);
            }
            else if (Make.Equals("BMW") ||Make.Equals("Mercedes") ||Make.Equals("Cadillac") ||
                     Make.Equals("Audi"))
            {
                Price = (20000 + 20000) * (1 - ((double)Damaged) / 6);
            }
            else
            {
                Price = (20000 + 5000) * (1 - ((double)Damaged) / 6);
            }
        }
    }
}
