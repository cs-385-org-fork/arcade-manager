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

        public void newCard(int ID, decimal money, string Name, bool VIPass)
        {
            cardID = ID;
            moneyOnCard = money;
            customerName = Name;
            VIP = VIPass;
        }

        public void topUpCard(decimal payment)
        {
            moneyOnCard += payment;
        }

        public void gamePaidFor(decimal machinePrice)
        {
            if (VIP) { machinePrice *= 0.75m; }
            if (moneyOnCard < machinePrice) { Console.WriteLine("Invalid Amount On Card"); }
            else { moneyOnCard -= machinePrice; }
        }
    }
}
