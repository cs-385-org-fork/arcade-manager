using System.Diagnostics.Eventing.Reader;
using System.IO;
using static System.Windows.Forms.LinkLabel;

namespace arcade_manager {
    public partial class Form1 : Form {

        List<Machine> floorMachines = new List<Machine>
        {
            new Machine("Machine1", 0, "Available"),
            new Machine("Machine2", 0, "Available"),
            new Machine("Machine3", 0, "Available"),
            new Machine("Machine4", 0, "Available"),
            new Machine("Machine5", 0, "Available"),
            new Machine("Machine6", 0, "Available")
        };
        List<PlayCard> customers = new List<PlayCard>
        {
            new PlayCard(1, (decimal)123.45, "Bob", true),
            new PlayCard(2, (decimal)234.56, "John", false)
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

            if (cmbxSortPlayCards.Text == "Balance (Low to High)") {
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
            else if (cmbxSortPlayCards.Text == "Balance (High to Low)") {
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
            else { // "ID" or anything else 5 2 7 3
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
            lblCustomerName.Text = ("Name: " + customers[customer].CustomerName);
            lblCardID.Text = ("Card ID: " + customers[customer].CardID);
            txtbxMoneyOnCard.Text = ("" + customers[customer].MoneyOnCard);

            rbtnVIPTier.Checked = false;
            rbtnStdTier.Checked = false;
            if (customers[customer].VIP) {
                rbtnVIPTier.Checked = true;
            }
            else {
                rbtnStdTier.Checked = true;
            }
        }

        public void updateMachineButtons() { // updates machines displayed on floor in the Machines tab

            btnMachine1.Text = floorMachines[0].MachineName; // update displayed name
            if (floorMachines[0].MachineStatus == "Maintainence") { // update color to show status of machine
                btnMachine1.BackColor = Color.Orange;
            }
            else if (floorMachines[0].MachineStatus == "Out of Order") {
                btnMachine1.BackColor = Color.Red;
            }
            else if (floorMachines[0].MachineStatus == "Available") {
                btnMachine1.BackColor = Color.GreenYellow;
            }

            btnMachine2.Text = floorMachines[1].MachineName;
            if (floorMachines[1].MachineStatus == "Maintainence") {
                btnMachine2.BackColor = Color.Orange;
            }
            else if (floorMachines[1].MachineStatus == "Out of Order") {
                btnMachine2.BackColor = Color.Red;
            }
            else if (floorMachines[1].MachineStatus == "Available") {
                btnMachine2.BackColor = Color.GreenYellow;
            }

            btnMachine3.Text = floorMachines[2].MachineName;
            if (floorMachines[2].MachineStatus == "Maintainence") {
                btnMachine3.BackColor = Color.Orange;
            }
            else if (floorMachines[2].MachineStatus == "Out of Order") {
                btnMachine3.BackColor = Color.Red;
            }
            else if (floorMachines[2].MachineStatus == "Available") {
                btnMachine3.BackColor = Color.GreenYellow;
            }

            btnMachine4.Text = floorMachines[3].MachineName;
            if (floorMachines[3].MachineStatus == "Maintainence") {
                btnMachine4.BackColor = Color.Orange;
            }
            else if (floorMachines[3].MachineStatus == "Out of Order") {
                btnMachine4.BackColor = Color.Red;
            }
            else if (floorMachines[3].MachineStatus == "Available") {
                btnMachine4.BackColor = Color.GreenYellow;
            }

            btnMachine5.Text = floorMachines[4].MachineName;
            if (floorMachines[4].MachineStatus == "Maintainence") {
                btnMachine5.BackColor = Color.Orange;
            }
            else if (floorMachines[4].MachineStatus == "Out of Order") {
                btnMachine5.BackColor = Color.Red;
            }
            else if (floorMachines[4].MachineStatus == "Available") {
                btnMachine5.BackColor = Color.GreenYellow;
            }

            btnMachine6.Text = floorMachines[5].MachineName;
            if (floorMachines[5].MachineStatus == "Maintainence") {
                btnMachine6.BackColor = Color.Orange;
            }
            else if (floorMachines[5].MachineStatus == "Out of Order") {
                btnMachine6.BackColor = Color.Red;
            }
            else if (floorMachines[5].MachineStatus == "Available") {
                btnMachine6.BackColor = Color.GreenYellow;
            }
        }

        public void updateMachineInfo(int machine) { // update displayed info of machine in GUI
            selectedMachine = machine;

            lblMachineName.Text = floorMachines[machine].MachineName;

            rbtnStatusAvailable.Checked = false;
            rbtnStatusMaintainence.Checked = false;
            rbtnStatusOutOfOrder.Checked = false;
            if (floorMachines[machine].MachineStatus == "Maintainence") {
                rbtnStatusMaintainence.Checked = true;
            }
            else if (floorMachines[machine].MachineStatus == "Out of Order") {
                rbtnStatusOutOfOrder.Checked = true;
            }
            else if (floorMachines[machine].MachineStatus == "Available") {
                rbtnStatusAvailable.Checked = true;
            }

            txtbxPlayCost.Text = ("" + floorMachines[machine].BaseMachinePrice);

            if (floorMachines[machine].OnSale) {
                txtbxDiscount.Text = ("" + floorMachines[machine].Discount * 100);
            }
            else {
                txtbxDiscount.Text = "N/A";
            }
        }


        public Form1() {
            InitializeComponent();

            updateMachineButtons();
            updatePlayCardsListBox();
            gbxNewCard.Visible = false;
        }

        private void saveCustomersToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void saveMachinesToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void loadCustomersToolStripMenuItem_Click(object sender, EventArgs e) {
            fileIO.readCustomers(ref customers);
            updatePlayCardsListBox();
        }

        private void loadMachinesToolStripMenuItem_Click(object sender, EventArgs e) {
            fileIO.readMachines(ref floorMachines);
            updateMachineButtons();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnMachine1_Click(object sender, EventArgs e) {
            updateMachineInfo(0);
        }
        private void btnMachine2_Click(object sender, EventArgs e) {
            updateMachineInfo(1);
        }
        private void btnMachine3_Click(object sender, EventArgs e) {
            updateMachineInfo(2);
        }
        private void btnMachine4_Click(object sender, EventArgs e) {
            updateMachineInfo(3);
        }
        private void btnMachine5_Click(object sender, EventArgs e) {
            updateMachineInfo(4);
        }
        private void btnMachine6_Click(object sender, EventArgs e) {
            updateMachineInfo(5);
        }

        private void rbtnStatusAvailable_CheckedChanged(object sender, EventArgs e) {
            floorMachines[selectedMachine].MachineStatus = "Available";
            updateMachineButtons();
        }
        private void rbtnStatusOutOfOrder_CheckedChanged(object sender, EventArgs e) {
            floorMachines[selectedMachine].MachineStatus = "Out of Order";
            updateMachineButtons();
        }
        private void rbtnStatusMaintainence_CheckedChanged(object sender, EventArgs e) {
            floorMachines[selectedMachine].MachineStatus = "Maintainence";
            updateMachineButtons();
        }

        private void lbxPlayCards_SelectedIndexChanged(object sender, EventArgs e) {
            selectedCustomer = sortedCustomers[lbxPlayCards.SelectedIndex];
            updateCustomerInfo(selectedCustomer);
        }

        private void btnAddCard_Click(object sender, EventArgs e) {
            gbxNewCard.Visible = true;
        }

        private void btnRemoveCard_Click(object sender, EventArgs e) {
            customers[sortedCustomers[lbxPlayCards.SelectedIndex]].IsActive = false;
            updatePlayCardsListBox();
        }

        private void btnNewCardAdd_Click(object sender, EventArgs e) {
            decimal.TryParse(txtbxNewCardMoney.Text, out decimal parsedMoney);
            bool status = false;
            if (rbtnNewCardVIPTier.Checked) {
                status = true;
            }
            customers.Add(new PlayCard((customers.Count() + 1), parsedMoney, txtbxNewCardName.Text, status));
            updatePlayCardsListBox();
            gbxNewCard.Visible = false;
        }

        private void btnNewCardCancel_Click(object sender, EventArgs e) {
            gbxNewCard.Visible = false;
        }

        private void cmbxSortPlayCards_SelectedIndexChanged(object sender, EventArgs e) {
            updatePlayCardsListBox();
        }

        private void txtbxPlayCost_KeyDown(object sender, KeyEventArgs e) { // update play cost
            if (e.KeyCode == Keys.Enter) {
                decimal.TryParse(txtbxPlayCost.Text, out decimal parsedAmount);
                floorMachines[selectedMachine].BaseMachinePrice = parsedAmount;
                updateMachineInfo(selectedMachine);
            }
        }

        private void txtbxDiscount_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                if (txtbxDiscount.Text == "N/A" || txtbxDiscount.Text == "n/a" || txtbxDiscount.Text == "" || txtbxDiscount.Text == "0") {
                    floorMachines[selectedMachine].OnSale = false;
                }
                else {
                    floorMachines[selectedMachine].OnSale = true;
                    double.TryParse(txtbxDiscount.Text, out double parsedAmount);
                    floorMachines[selectedMachine].Discount = (parsedAmount / 100.0);
                }
                updateMachineInfo(selectedMachine);
            }
        }
    }
}
