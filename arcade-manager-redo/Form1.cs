using System.Diagnostics.Eventing.Reader;
using System.IO;
using static System.Windows.Forms.LinkLabel;

namespace arcade_manager_redo {
    public partial class Form1 : Form {
        List<Machine> floorMachines = new List<Machine> {

        };
        List<PlayCard> customers = new List<PlayCard> {

        };
        List<int> sortedCustomers = new List<int> { }; // parallel list of indexes of sorted customers (how theyre displayed in GUI)
        FileIO fileIO = new FileIO();

        int selectedMachine = 0;
        int selectedCustomer = 0;

        public void updatePlayCardsListBox() { // updates the play cards displayed in the list box in the Customers tab
            lbxPlayCards.Items.Clear();

            // sorting
            sortedCustomers.Clear();
            for (int i = 0; i < customers.Count(); i++) {
                if (customers[i].IsActive) { // if the customer is active,
                    sortedCustomers.Add(i); // add their card index to the sorted parallel list
                }
            }

            if (cmbxSortCards.Text == "Balance (Low to High)") {
                int temporary;
                for (int j = 0; j <= sortedCustomers.Count() - 2; j++) {
                    for (int i = 0; i <= sortedCustomers.Count() - 2; i++) {
                        if (customers[sortedCustomers[i]].MoneyOnCard > customers[sortedCustomers[i + 1]].MoneyOnCard) {
                            temporary = sortedCustomers[i + 1];
                            sortedCustomers[i + 1] = sortedCustomers[i];
                            sortedCustomers[i] = temporary;
                        }
                    }
                }
            }
            else if (cmbxSortCards.Text == "Balance (High to Low)") {
                int temporary;
                for (int j = 0; j <= sortedCustomers.Count() - 2; j++) {
                    for (int i = 0; i <= sortedCustomers.Count() - 2; i++) {
                        if (customers[sortedCustomers[i]].MoneyOnCard < customers[sortedCustomers[i + 1]].MoneyOnCard) {
                            temporary = sortedCustomers[i + 1];
                            sortedCustomers[i + 1] = sortedCustomers[i];
                            sortedCustomers[i] = temporary;
                        }
                    }
                }
            }
            else { // "ID" or anything else
                int temporary;
                for (int j = 0; j <= sortedCustomers.Count() - 2; j++) {
                    for (int i = 0; i <= sortedCustomers.Count() - 2; i++) {
                        if (customers[sortedCustomers[i]].CardID > customers[sortedCustomers[i + 1]].CardID) {
                            temporary = sortedCustomers[i + 1];
                            sortedCustomers[i + 1] = sortedCustomers[i];
                            sortedCustomers[i] = temporary;
                        }
                    }
                }
            }

            // put sorted cards into listbox
            for (int i = 0; i < sortedCustomers.Count(); i++) {
                lbxPlayCards.Items.Add(customers[sortedCustomers[i]].CardID + "\t\t$" + customers[sortedCustomers[i]].MoneyOnCard);
            }
        }
        public void updateCustomerInfo(int customer) {
            lblCustName.Text = ("Name: " + customers[customer].CustomerName);
            lblCustID.Text = ("Card ID: " + customers[customer].CardID);
            txtbxCustBalance.Text = ("" + customers[customer].MoneyOnCard);

            rbtnCustStatusVIP.Checked = false;
            rbtnCustStatusStd.Checked = false;
            if (customers[customer].VIP) {
                rbtnCustStatusVIP.Checked = true;
            }
            else {
                rbtnCustStatusStd.Checked = true;
            }
        }

        public void updateMachines() { // updates machines displayed on floor in the Machines tab


        }

        public void updateMachineInfo(int machine) { // update displayed info of machine in GUI
            selectedMachine = machine;

            txtbxMachName.Text = floorMachines[machine].MachineName;

            rbtnStatusAvail.Checked = false;
            rbtnStatusMaint.Checked = false;
            rbtnStatusOutOrder.Checked = false;
            if (floorMachines[machine].MachineStatus == "Maintainence") {
                rbtnStatusMaint.Checked = true;
            }
            else if (floorMachines[machine].MachineStatus == "Out of Order") {
                rbtnStatusOutOrder.Checked = true;
            }
            else if (floorMachines[machine].MachineStatus == "Available") {
                rbtnStatusAvail.Checked = true;
            }

            txtbxMachPlayCost.Text = ("" + floorMachines[machine].BaseMachinePrice);

            if (floorMachines[machine].OnSale) {
                txtbxMachDiscount.Text = ("" + floorMachines[machine].Discount * 100);
            }
            else {
                txtbxMachDiscount.Text = "N/A";
            }
        }

        public void updateSimPlayMachines() {
            cmbxSimPlayMachines.Items.Clear();

            // put machines into combobox
            for (int i = 0; i < floorMachines.Count(); i++) {
                cmbxSimPlayMachines.Items.Add(floorMachines[i].MachineName);
            }
        }
        public void updateSimPlayCards() {
            cmbxSimPlayCards.Items.Clear();

            // sort cards by ID
            int temporary;
            for (int j = 0; j <= sortedCustomers.Count() - 2; j++) {
                for (int i = 0; i <= sortedCustomers.Count() - 2; i++) {
                    if (customers[sortedCustomers[i]].CardID > customers[sortedCustomers[i + 1]].CardID) {
                        temporary = sortedCustomers[i + 1];
                        sortedCustomers[i + 1] = sortedCustomers[i];
                        sortedCustomers[i] = temporary;
                    }
                }
            }

            // put sorted cards into combobox
            for (int i = 0; i < sortedCustomers.Count(); i++) {
                cmbxSimPlayCards.Items.Add(customers[sortedCustomers[i]].CardID);
            }
        }

        public Form1() {
            InitializeComponent();
        }
    }
}
