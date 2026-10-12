using System;
using System.Reflection.PortableExecutable;

namespace arcade_manager;

internal class FightingGame : Machine
{
    public override decimal applySale()
    {
        if (OnSale)
        {
            return BaseMachinePrice * Convert.ToDecimal(Fighting_GameDiscount);
        }
        else {
            return BaseMachinePrice;
        }
        
    }
    private double Fighting_GameDiscount = 0.80;

    public FightingGame() { } // base constructor

    public FightingGame(string name, decimal price, string status) {
        MachineName = name;
        BaseMachinePrice = price;
        CurrentMachinePrice = price;
        MachineStatus = status;
        GameGenre = "Fighting Game";
    }

}
