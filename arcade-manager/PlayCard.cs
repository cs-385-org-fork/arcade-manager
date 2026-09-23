using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace arcade_manager
{
    internal class PlayCard
    {
        public PlayCard() 
        {
            cardID = 999999;
            moneyOnCard = 0;
            customerName = "Null";
            vip = false;
        }
        public PlayCard(int ID, decimal money, string Name, bool VIPass)
        {
            cardID = ID;
            moneyOnCard = money;
            customerName = Name;
            vip = VIPass;
        }

        int cardID;
        decimal moneyOnCard;
        string customerName;
        bool vip;

        //VIP status might change after a customer owns a card.
        public bool VIP
        {
            get { return vip; }
            set { vip = value; }
        }
        public int CardID
        {
            get { return cardID; }
            set { cardID = value; }
        }
        public string CustomerName
        {
            get { return customerName; }
            set {  customerName = value; }
        }
        public decimal MoneyOnCard
        {
            get { return moneyOnCard; }
            set {  moneyOnCard = value; }
        }

        //Initializes the card
        public void newCard(int ID, decimal money, string Name, bool VIPass)
        {
            cardID = ID;
            moneyOnCard = money;
            customerName = Name;
            vip = VIPass;
        }

        //Adds money paid to the card
        public void topUpCard(decimal payment)
        {
            moneyOnCard += payment;
        }

        
        //Returns a bool based on if the customer is able to actually pay for the game or not.
        public bool gamePaidFor(decimal machinePrice)
        {
            if (vip) { machinePrice *= 0.75m; }
            if (moneyOnCard < machinePrice) { Console.WriteLine("Invalid Amount On Card"); return false; }
            else { moneyOnCard -= machinePrice; return true; }
        }
    }
}
