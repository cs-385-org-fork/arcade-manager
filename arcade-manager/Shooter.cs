using System;
using System.Collections.Generic;
using System.Text;

namespace arcade_manager {
    internal class Shooter : Machine {
        public override decimal applySale() {
            if (OnSale) {
                return BaseMachinePrice * Convert.ToDecimal(Shooter_GameDiscount);
            }
            else {
                return BaseMachinePrice;
            }

        }
        private double Shooter_GameDiscount = 0.50;

        public Shooter() { } // base constructor

        public Shooter(string name, decimal price, string status) {
            MachineName = name;
            BaseMachinePrice = price;
            CurrentMachinePrice = price;
            MachineStatus = status;
            GameGenre = "Shooter";
        }

    }
}
