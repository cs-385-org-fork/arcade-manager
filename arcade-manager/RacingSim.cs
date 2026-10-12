using System;

namespace arcade_manager;

internal class RacingSim : Machine
{
    public RacingSim() { } // base constructor

    public RacingSim(string name, decimal price, string status) {
        MachineName = name;
        BaseMachinePrice = price;
        CurrentMachinePrice = price;
        MachineStatus = status;
        GameGenre = "Racing Sim";
    }
}
