using System;
using System.Reflection.PortableExecutable;

namespace arcade_manager_redo;

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

}
