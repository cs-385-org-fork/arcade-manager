using System;
using System.Collections.Generic;
using System.Text;

namespace arcade_manager
{
    internal class PlayCard
    {
        int cardID;
        decimal moneyOnCard;
        string customerName;
        bool VIP;

        //Initializes the card
        public void newCard(int ID, decimal money, string Name, bool VIPass)
        {
            cardID = ID;
            moneyOnCard = money;
            customerName = Name;
            VIP = VIPass;
        }

        //Adds money paid to the card
        public void topUpCard(decimal payment)
        {
            moneyOnCard += payment;
        }

        //Returns a bool based on if the customer is able to actually pay for the game or not.
        public bool gamePaidFor(decimal machinePrice)
        {
            if (VIP) { machinePrice *= 0.75m; }
            if (moneyOnCard < machinePrice) { Console.WriteLine("Invalid Amount On Card"); return false; }
            else { moneyOnCard -= machinePrice; return true; }
        }
    }
}
