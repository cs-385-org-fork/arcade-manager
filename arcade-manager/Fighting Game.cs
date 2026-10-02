using System;
using System.Reflection.PortableExecutable;

namespace arcade_manager;

public class Fighting_Game : Machine
{
public override decimal applySale()
{
if (OnSale)
{
    return Machine.BaseMachinePrice * Convert.ToDecimal(Fighting_GameDiscount)
}
        
}
private double Fighting_GameDiscount = 0.80;
}
