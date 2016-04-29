using System;


namespace CarDealership
{
    //Entity Class to create Credit Objects for Purchasing purposes
    internal class CreditCard
    {
        public String CardID;
        public String CardNumber;
        public String CVV;
        public String ExpirationDate;
        public String NameOnCard;
        public String CustomerID;
      


        public CreditCard(String CardNumber, String NameOnCard, String CVV, String ExpirationDate,String CustomerID)
        {
        
            this.CardNumber = CardNumber;
            this.NameOnCard = NameOnCard;
            this.CVV = CVV;
            this.ExpirationDate = ExpirationDate;
            this.CustomerID = CustomerID;
        }
        public CreditCard()
        {

         
        }
    }
}