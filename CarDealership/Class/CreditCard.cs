using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    class CreditCard
    {
        public char CardID;
        public char CardNumber;
        public char NameonCard;
        public char CVC;
        public char ExpirationDate;
        public char PIN;




        public CreditCard(char CardID, char CardNumber, char NameonCard,char CVC, char ExpirationDate,
            char PIN)
        {
            this.CardID = CardID;
            this.CardNumber = CardNumber;
            this.NameonCard = NameonCard;
            this.CVC = CVC;
            this.ExpirationDate = ExpirationDate;
            this.PIN = PIN;

        }

    }

    }

