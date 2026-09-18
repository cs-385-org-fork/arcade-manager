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
            //method to change machine status
        }
        public void applySale(string machineName)
        { 
            //method to apply a discount if onSale bool == true
        }
        public void changePrice(string machineName)
        {
            //method to update price per play of a machine
        }
    }
}
