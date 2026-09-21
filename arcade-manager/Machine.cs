using System;
using System.Collections.Generic;
using System.Text;

namespace arcade_manager
{
    internal class Machine
    {
        private string machineName = "";
        private decimal baseMachinePrice = 0;
        private decimal currentMachinePrice = 0;
        private string machineStatus = "";
        private bool onSale = false;
        private double discount = 0.85;

        public string MachineName
        {
            get { return machineName; }
            set { machineName = value; }
        }
        public decimal BaseMachinePrice
        {
            get { return baseMachinePrice; }
            set { baseMachinePrice = value; }
        }
        public decimal CurrentMachinePrice
        {
            get { return currentMachinePrice; }
            set
            {
                currentMachinePrice = baseMachinePrice;
                applySale();
            }
        }
        }
        public string MachineStatus
        {
            get { return machineStatus; }
            set { machineStatus = value; }
        }
        public bool OnSale
        {
            get { return onSale; }
            set { onSale = value; }
        }
        public void applySale()
        {
            if (onSale)
            {
                baseMachinePrice = baseMachinePrice * Convert.ToDecimal(discount);
            }

        }
    }
}
