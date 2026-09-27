using System.Diagnostics.Eventing.Reader;
using System.IO;
using static System.Windows.Forms.LinkLabel;

namespace arcade_manager {
    public partial class Form1 : Form {

        Machine[] floorMachines = new Machine[6];
        //List<PlayCard> customers = new List<PlayCard> { };
        List<PlayCard> customers = new List<PlayCard>
        {
            new PlayCard(1, (decimal)123.45, "Bob", true),
            new PlayCard(2, (decimal)234.56, "John", false)
        };
        FileIO fileIO = new FileIO();

        int selectedMachine = 0;
        int selectedCustomer = 0;

        public void updatePlayCardsListBox() { // updates the play cards displayed in the list box in the Customers tab
            lbxPlayCards.Items.Clear();
            for (int i = 0; i < customers.Count(); i++) {
                lbxPlayCards.Items.Add("" + customers[i].CardID);
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


        public Form1() {
            InitializeComponent();

            updatePlayCardsListBox();
            gbxNewCard.Visible = false;
        }

        private void saveCustomersToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void saveMachinesToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void loadCustomersToolStripMenuItem_Click(object sender, EventArgs e) {
            fileIO.readCustomers(customers);
            updatePlayCardsListBox();
        }

        private void loadMachinesToolStripMenuItem_Click(object sender, EventArgs e) {

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
            selectedCustomer = lbxPlayCards.SelectedIndex;
            updateCustomerInfo(selectedCustomer);
        }

        private void btnAddCard_Click(object sender, EventArgs e) {
            gbxNewCard.Visible = true;
        }

        private void btnNewCardCancel_Click(object sender, EventArgs e) {
            gbxNewCard.Visible = false;
        }
    }
}
