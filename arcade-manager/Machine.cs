using System;
using System.Collections.Generic;
using System.Text;

namespace arcade_manager
{
    internal class Machine
    {
        private string machineName = "";
        private double machinePrice = 0;
        private string machineStatus = "";
        private bool onSale = false;

        public string MachineName
        {
            get { return machineName; }
            set { machineName = value; }
        }
        public double MachinePrice
        {
            get { return machinePrice; }
            set { machinePrice = value; }
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
        public void ChangeStatus(string machineName)
        {

        }
    }
}
