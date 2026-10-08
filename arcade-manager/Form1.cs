using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Text;
using static System.Windows.Forms.LinkLabel;

namespace arcade_manager {
    public partial class Form1 : Form {
        List<Machine> floorMachines = new List<Machine> {
            new Machine("Machine1", 0.25m, "Available"),
            new Shooter("Machine2", 0.24m, "Available")
        };
        List<PlayCard> customers = new List<PlayCard> {
            new PlayCard(1, 1.00m, "John Doe", false)
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
                lbxPlayCards.Items.Add(customers[sortedCustomers[i]].CardID + " [$" + customers[sortedCustomers[i]].MoneyOnCard + "]");
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
            lbxFloorMachines.Items.Clear();

            for (int i = 0; i < floorMachines.Count(); i++) {
                lbxFloorMachines.Items.Add(floorMachines[i].MachineName + " [" + floorMachines[i].MachineStatus + "]");
            }
        }

        public void updateMachineInfo(int machine) { // update displayed info of machine in GUI
            selectedMachine = machine;

            txtbxMachName.Text = floorMachines[machine].MachineName;

            lblMachGenre.Text = ("Genre: " + floorMachines[machine].GameGenre);

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

            updateMachines();
            updatePlayCardsListBox();

            gbxNewMach.Visible = false;
            gbxNewPlayCard.Visible = false;
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

        private void lbxFloorMachines_SelectedIndexChanged(object sender, EventArgs e) {
            selectedMachine = lbxFloorMachines.SelectedIndex;
            updateMachineInfo(selectedMachine);
        }

        private void btnAddMach_Click(object sender, EventArgs e) {
            gbxNewMach.Visible = true;
        }
        private void btnRemoveMach_Click(object sender, EventArgs e) {
            floorMachines.RemoveAt(selectedMachine);
            selectedMachine = 0;
            updateMachines();
            updateMachineInfo(selectedMachine);
        }
        private void btnNewMachAdd_Click(object sender, EventArgs e) {
            decimal.TryParse(txtbxNewMachPlayCost.Text, out decimal parsedCost);

            bool newMachSale;
            if (txtbxNewMachDiscount.Text == "N/A" || txtbxNewMachDiscount.Text == "n/a" || txtbxNewMachDiscount.Text == "" || decimal.Parse(txtbxNewMachDiscount.Text) == 0) {
                newMachSale = false;
            }
            else {
                newMachSale = true;
                double.TryParse(txtbxNewMachDiscount.Text, out double parsedAmount);
                floorMachines[selectedMachine].Discount = Math.Round((parsedAmount / 100.0), 2);
            }

            string machStatus;
            if (rbtnNewMachStatusAvail.Checked) {
                machStatus = "Available";
            }
            else if (rbtnNewMachStatusMaint.Checked) {
                machStatus = "Maintainence";
            }
            else { // Out of Order
                machStatus = "Out of Order";
            }

            // machine category
            if (cmbxNewMachGenre.Text == "Fighting Game") {
                floorMachines.Add(new FightingGame(txtbxNewMachName.Text, parsedCost, machStatus));
            }
            else if (cmbxNewMachGenre.Text == "Racing Sim") {
                floorMachines.Add(new RacingSim(txtbxNewMachName.Text, parsedCost, machStatus));
            }
            else if (cmbxNewMachGenre.Text == "Shooter") {
                floorMachines.Add(new Shooter(txtbxNewMachName.Text, parsedCost, machStatus));
            }
            else { // Other
                floorMachines.Add(new Machine(txtbxNewMachName.Text, parsedCost, machStatus));
            }
            selectedMachine = floorMachines.Count() - 1;

            if (txtbxNewMachDiscount.Text == "N/A" || txtbxNewMachDiscount.Text == "n/a" || txtbxNewMachDiscount.Text == "" || txtbxNewMachDiscount.Text == "0") {
                floorMachines[selectedMachine].OnSale = false;
            }
            else {
                floorMachines[selectedMachine].OnSale = true;
                double.TryParse(txtbxNewMachDiscount.Text, out double parsedAmount);
                floorMachines[selectedMachine].Discount = Math.Round((parsedAmount / 100.0), 2);
            }

            updateMachines();
            updateMachineInfo(selectedMachine);

            gbxNewMach.Visible = false;
        }
        private void btnNewMachCancel_Click(object sender, EventArgs e) {
            gbxNewMach.Visible = false;
        }


        private void lbxPlayCards_SelectedIndexChanged(object sender, EventArgs e) {
            selectedCustomer = sortedCustomers[lbxPlayCards.SelectedIndex];
            updateCustomerInfo(selectedCustomer);
        }

        private void btnAddCard_Click(object sender, EventArgs e) {
            gbxNewPlayCard.Visible = true;
        }

        private void btnRemoveCard_Click(object sender, EventArgs e) {
            customers[sortedCustomers[lbxPlayCards.SelectedIndex]].IsActive = false;
            updatePlayCardsListBox();
        }

        private void btnNewCardAdd_Click(object sender, EventArgs e) {
            decimal.TryParse(txtbxNewCardBalance.Text, out decimal parsedMoney);
            bool status = false;
            if (rbtnNewCardStatusVIP.Checked) {
                status = true;
            }
            customers.Add(new PlayCard((customers.Count() + 1), parsedMoney, txtbxNewCardCustName.Text, status));
            updatePlayCardsListBox();
            gbxNewPlayCard.Visible = false;
        }

        private void btnNewCardCancel_Click(object sender, EventArgs e) {
            gbxNewPlayCard.Visible = false;
        }

        private void cmbxSortPlayCards_SelectedIndexChanged(object sender, EventArgs e) {
            updatePlayCardsListBox();
        }

        private void txtbxCustName_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                customers[selectedCustomer].CustomerName = txtbxCustName.Text;
                updatePlayCardsListBox();
                updateCustomerInfo(selectedCustomer);
            }
        }
        private void txtbxMoneyOnCard_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                decimal.TryParse(txtbxCustBalance.Text, out decimal parsedAmount);
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
                floorMachines[selectedMachine].MachineName = txtbxMachName.Text;
                updateMachineInfo(selectedMachine);
                updateMachines();
            }
        }
        private void txtbxPlayCost_KeyDown(object sender, KeyEventArgs e) { // update play cost
            if (e.KeyCode == Keys.Enter) {
                decimal.TryParse(txtbxMachPlayCost.Text, out decimal parsedAmount);
                floorMachines[selectedMachine].BaseMachinePrice = Math.Round(parsedAmount, 2);
                updateMachineInfo(selectedMachine);
            }
        }

        private void txtbxDiscount_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                if (txtbxMachDiscount.Text == "N/A" || txtbxMachDiscount.Text == "n/a" || txtbxMachDiscount.Text == "" || txtbxMachDiscount.Text == "0") {
                    floorMachines[selectedMachine].OnSale = false;
                }
                else {
                    floorMachines[selectedMachine].OnSale = true;
                    double.TryParse(txtbxMachDiscount.Text, out double parsedAmount);
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
            lblSimPlayPlayCostVIP.Visible = false;

            if (cmbxSimPlayCards.Text == "") {
                MessageBox.Show("Please select a Play Card before selecting a machine.");
                cmbxSimPlayMachines.Text = "";
            }
            else if (floorMachines[cmbxSimPlayMachines.SelectedIndex].MachineStatus != "Available") {
                MessageBox.Show("Sorry, this machine is currently unavailable. Please try a different machine.");
            }
            else {
                floorMachines[cmbxSimPlayMachines.SelectedIndex].CurrentMachinePrice = 0;
                lblSimPlayPlayCost2.Text = ("" + floorMachines[cmbxSimPlayMachines.SelectedIndex].CurrentMachinePrice);
                //MessageBox.Show("DEBUG: " + floorMachines[cmbxMachines.SelectedIndex].CurrentMachinePrice);

                if (customers[Int32.Parse(cmbxSimPlayCards.Text) - 1].VIP) {
                    lblSimPlayPlayCost2.Font = new Font(lblSimPlayPlayCost2.Font, FontStyle.Strikeout);
                    lblSimPlayPlayCostVIP.Visible = true;
                    lblSimPlayPlayCostVIP.Text = ("with VIP Discount: $" + Math.Round((floorMachines[cmbxSimPlayCards.SelectedIndex].CurrentMachinePrice * (decimal)0.75), 2));
                }
            }
        }

        private void cmbxPlayCards_SelectedIndexChanged(object sender, EventArgs e) {
            lblSimPlayMoneyOnCard.Text = ("Money on Card: $" + customers[sortedCustomers[cmbxSimPlayCards.SelectedIndex]].MoneyOnCard);
            if (customers[Int32.Parse(cmbxSimPlayCards.Text) - 1].VIP) {
                lblSimPlayCustStatus.Text = "VIP: Yes";
            }
            else {
                lblSimPlayCustStatus.Text = "VIP: No";
            }
        }

        private void btnSimPlay_Click(object sender, EventArgs e) {
            if (cmbxSimPlayMachines.Text == "" || cmbxSimPlayCards.Text == "") { // if a machine or play card isnt selected, notify user
                MessageBox.Show("Please choose both a Machine and Play Card to swipe card.");
            }
            else {
                bool play = customers[Int32.Parse(cmbxSimPlayCards.Text) - 1].gamePaidFor(floorMachines[cmbxSimPlayMachines.SelectedIndex].CurrentMachinePrice);

                if (play) {
                    MessageBox.Show(customers[Int32.Parse(cmbxSimPlayCards.Text) - 1].CustomerName + " (ID " + customers[Int32.Parse(cmbxSimPlayCards.Text) - 1].CardID + ") played " + floorMachines[cmbxSimPlayMachines.SelectedIndex].MachineName + "!");
                }
                else {
                    MessageBox.Show("Insufficient funds.");
                }
            }

            lblSimPlayMoneyOnCard.Text = ("Money on Card: $" + customers[Int32.Parse(cmbxSimPlayCards.Text) - 1].MoneyOnCard);
        }

        private void aboutArcadeManagerToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Arcade Manager" + "\n"
                               + "Now with Inheritance and Virtual Methods!" + "\n"
                               + "By Miles Crane, Connor Klering, Trevor Past" + "\n"
                               + "October 2026");
        }

        
    }
}
