using System.Diagnostics.Eventing.Reader;
using System.IO;
using static System.Windows.Forms.LinkLabel;

namespace arcade_manager {
    public partial class Form1 : Form {

        List<Machine> floorMachines = new List<Machine>
        {

        };
        List<PlayCard> customers = new List<PlayCard>
        {

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

        public void updateMachines() { // updates machines displayed on floor in the Machines tab

            
        }

        public void updateMachineInfo(int machine) { // update displayed info of machine in GUI
            selectedMachine = machine;

            txtbxMachineName.Text = floorMachines[machine].MachineName;

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

        public void updateSimPlayMachines() {
            cmbxMachines.Items.Clear();

            // put machines into combobox
            for (int i = 0; i < 6; i++) {
                cmbxMachines.Items.Add(floorMachines[i].MachineName);
            }
        }
        public void updateSimPlayCards() {
            cmbxPlayCards.Items.Clear();

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
                cmbxPlayCards.Items.Add(customers[sortedCustomers[i]].CardID);
            }
        }


        public Form1() {
            InitializeComponent();

            // update stuff on Machines tab:
            updateMachines();
            cmbxMachineGenre.Visible = false;
            btnNewMachAdd.Visible = false;
            btnNewMachCancel.Visible = false;


            // on Customers tab:
            updatePlayCardsListBox();
            gbxNewCard.Visible = false;
            lblSimPlayPlayCost3.Visible = false;
        }

        private void saveCustomersToolStripMenuItem_Click(object sender, EventArgs e) {
            //Pass the customer list in the tab to be written.
            FileIO fileIO = new FileIO();
            fileIO.outputPlaycards(customers);
        }

        private void saveMachinesToolStripMenuItem_Click(object sender, EventArgs e) {
            //Pass the machine list to the FileIO
            FileIO fileIO = new FileIO();
            fileIO.outputMachines(floorMachines);
        }

        private void loadCustomersToolStripMenuItem_Click(object sender, EventArgs e) {
            fileIO.readCustomers(ref customers);
            updatePlayCardsListBox();
        }

        private void loadMachinesToolStripMenuItem_Click(object sender, EventArgs e) {
            fileIO.readMachines(ref floorMachines);
            updateMachines();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void rbtnStatusAvailable_CheckedChanged(object sender, EventArgs e) {
            floorMachines[selectedMachine].MachineStatus = "Available";
            updateMachines();
        }
        private void rbtnStatusOutOfOrder_CheckedChanged(object sender, EventArgs e) {
            floorMachines[selectedMachine].MachineStatus = "Out of Order";
            updateMachines();
        }
        private void rbtnStatusMaintainence_CheckedChanged(object sender, EventArgs e) {
            floorMachines[selectedMachine].MachineStatus = "Maintainence";
            updateMachines();
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

        private void txtbxMoneyOnCard_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                decimal.TryParse(txtbxMoneyOnCard.Text, out decimal parsedAmount);
                customers[selectedCustomer].MoneyOnCard = parsedAmount;
                updatePlayCardsListBox();
                updateCustomerInfo(selectedCustomer);
            }
        }

        private void btnTopUp1_Click(object sender, EventArgs e) {
            customers[selectedCustomer].topUpCard(1);
            updatePlayCardsListBox();
            updateCustomerInfo(selectedCustomer);
        }
        private void btnTopUp5_Click(object sender, EventArgs e) {
            customers[selectedCustomer].topUpCard(5);
            updatePlayCardsListBox();
            updateCustomerInfo(selectedCustomer);
        }
        private void btnTopUp10_Click(object sender, EventArgs e) {
            customers[selectedCustomer].topUpCard(10);
            updatePlayCardsListBox();
            updateCustomerInfo(selectedCustomer);
        }

        private void rbtnStdTier_CheckedChanged(object sender, EventArgs e) {
            customers[selectedCustomer].VIP = false;
            updateCustomerInfo(selectedCustomer);
        }
        private void rbtnVIPTier_CheckedChanged(object sender, EventArgs e) {
            customers[selectedCustomer].VIP = true;
            updateCustomerInfo(selectedCustomer);
        }

        private void txtbxMachineName_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                floorMachines[selectedMachine].MachineName = txtbxMachineName.Text;
                updateMachineInfo(selectedMachine);
                updateMachines();
            }
        }
        private void txtbxPlayCost_KeyDown(object sender, KeyEventArgs e) { // update play cost
            if (e.KeyCode == Keys.Enter) {
                decimal.TryParse(txtbxPlayCost.Text, out decimal parsedAmount);
                floorMachines[selectedMachine].BaseMachinePrice = Math.Round(parsedAmount, 2);
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
                    floorMachines[selectedMachine].Discount = Math.Round((parsedAmount / 100.0), 2);
                }
                updateMachineInfo(selectedMachine);
            }
        }

        private void tabSimPlay_Enter(object sender, EventArgs e) {
            updateSimPlayMachines();
            updateSimPlayCards();
        }

        private void cmbxMachines_SelectedIndexChanged(object sender, EventArgs e) {
            lblSimPlayPlayCost2.Font = new Font(lblSimPlayPlayCost2.Font, FontStyle.Regular);
            lblSimPlayPlayCost3.Visible = false;

            if (cmbxPlayCards.Text == "") {
                MessageBox.Show("Please select a Play Card before selecting a machine.");
                cmbxMachines.Text = "";
            }
            else if (floorMachines[cmbxMachines.SelectedIndex].MachineStatus != "Available") {
                MessageBox.Show("Sorry, this machine is currently unavailable. Please try a different machine.");
            }
            else {
                floorMachines[cmbxMachines.SelectedIndex].CurrentMachinePrice = 0;
                lblSimPlayPlayCost2.Text = ("" + floorMachines[cmbxMachines.SelectedIndex].CurrentMachinePrice);
                //MessageBox.Show("DEBUG: " + floorMachines[cmbxMachines.SelectedIndex].CurrentMachinePrice);

                if (customers[Int32.Parse(cmbxPlayCards.Text) - 1].VIP) {
                    lblSimPlayPlayCost2.Font = new Font(lblSimPlayPlayCost2.Font, FontStyle.Strikeout);
                    lblSimPlayPlayCost3.Visible = true;
                    lblSimPlayPlayCost3.Text = ("with VIP Discount: $" + Math.Round((floorMachines[cmbxMachines.SelectedIndex].CurrentMachinePrice * (decimal)0.75), 2));
                }
            }
        }

        private void cmbxPlayCards_SelectedIndexChanged(object sender, EventArgs e) {
            lblSimPlayMoneyOnCard.Text = ("Money on Card: $" + customers[sortedCustomers[cmbxPlayCards.SelectedIndex]].MoneyOnCard);
            if (customers[Int32.Parse(cmbxPlayCards.Text) - 1].VIP) {
                lblSimPlayVIP.Text = "VIP: Yes";
            }
            else {
                lblSimPlayVIP.Text = "VIP: No";
            }
        }

        private void btnSimPlay_Click(object sender, EventArgs e) {
            if (cmbxMachines.Text == "" || cmbxPlayCards.Text == "") { // if a machine or play card isnt selected, notify user
                MessageBox.Show("Please choose both a Machine and Play Card to swipe card.");
            }
            else {
                bool play = customers[Int32.Parse(cmbxPlayCards.Text) - 1].gamePaidFor(floorMachines[cmbxMachines.SelectedIndex].CurrentMachinePrice);

                if (play) {
                    MessageBox.Show(customers[Int32.Parse(cmbxPlayCards.Text) - 1].CustomerName + " (ID " + customers[Int32.Parse(cmbxPlayCards.Text) - 1].CardID + ") played " + floorMachines[cmbxMachines.SelectedIndex].MachineName + "!");
                }
                else {
                    MessageBox.Show("Insufficient funds.");
                }
            }

            lblSimPlayMoneyOnCard.Text = ("Money on Card: $" + customers[Int32.Parse(cmbxPlayCards.Text) - 1].MoneyOnCard);
        }

        private void aboutArcadeManagerToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Arcade Manager" + "\n"
                               + "By Miles Crane, Connor Klering, Trevor Past" + "\n"
                               + "September 2026");
        }

    }
}
