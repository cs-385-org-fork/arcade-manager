namespace arcade_manager {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveCustomersToolStripMenuItem = new ToolStripMenuItem();
            saveMachinesToolStripMenuItem = new ToolStripMenuItem();
            loadCustomersToolStripMenuItem = new ToolStripMenuItem();
            loadMachinesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            gbxArcadeFloor = new GroupBox();
            btnMachine4 = new Button();
            btnMachine3 = new Button();
            btnMachine6 = new Button();
            btnMachine5 = new Button();
            btnMachine2 = new Button();
            btnMachine1 = new Button();
            gbxMachineInfo = new GroupBox();
            txtbxMachineName = new TextBox();
            label3 = new Label();
            txtbxDiscount = new TextBox();
            lblDiscount = new Label();
            txtbxPlayCost = new TextBox();
            lblPlayCost = new Label();
            gbxStatus = new GroupBox();
            rbtnStatusMaintainence = new RadioButton();
            rbtnStatusOutOfOrder = new RadioButton();
            rbtnStatusAvailable = new RadioButton();
            lblMachineName = new Label();
            tabControl1 = new TabControl();
            tabMachines = new TabPage();
            tabCustomers = new TabPage();
            gbxNewCard = new GroupBox();
            txtbxNewCardName = new TextBox();
            btnNewCardCancel = new Button();
            btnNewCardAdd = new Button();
            txtbxNewCardMoney = new TextBox();
            gbxNewCardTier = new GroupBox();
            rbtnNewCardVIPTier = new RadioButton();
            rbtnNewCardStdTier = new RadioButton();
            label2 = new Label();
            lblNewCardMoney = new Label();
            lblNewCardName = new Label();
            gbxCustomerInfo = new GroupBox();
            txtbxMoneyOnCard = new TextBox();
            gbxCustomerTier = new GroupBox();
            rbtnVIPTier = new RadioButton();
            rbtnStdTier = new RadioButton();
            label1 = new Label();
            lblMoneyOnCard = new Label();
            lblCardID = new Label();
            lblCustomerName = new Label();
            gbxPlayCards = new GroupBox();
            lblSortPlayCards = new Label();
            cmbxSortPlayCards = new ComboBox();
            btnRemoveCard = new Button();
            btnAddCard = new Button();
            lbxPlayCards = new ListBox();
            tabSimPlay = new TabPage();
            btnSimPlay = new Button();
            gbxChooseCard = new GroupBox();
            lblSimPlayVIP = new Label();
            lblSimPlayMoneyOnCard = new Label();
            cmbxPlayCards = new ComboBox();
            gbxChooseMachine = new GroupBox();
            cmbxMachines = new ComboBox();
            lblSimPlayPlayCost3 = new Label();
            lblSimPlayPlayCost2 = new Label();
            lblSimPlayPlayCost1 = new Label();
            toolTipEnter = new ToolTip(components);
            aboutArcadeManagerToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            gbxArcadeFloor.SuspendLayout();
            gbxMachineInfo.SuspendLayout();
            gbxStatus.SuspendLayout();
            tabControl1.SuspendLayout();
            tabMachines.SuspendLayout();
            tabCustomers.SuspendLayout();
            gbxNewCard.SuspendLayout();
            gbxNewCardTier.SuspendLayout();
            gbxCustomerInfo.SuspendLayout();
            gbxCustomerTier.SuspendLayout();
            gbxPlayCards.SuspendLayout();
            tabSimPlay.SuspendLayout();
            gbxChooseCard.SuspendLayout();
            gbxChooseMachine.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(794, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveCustomersToolStripMenuItem, saveMachinesToolStripMenuItem, loadCustomersToolStripMenuItem, loadMachinesToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveCustomersToolStripMenuItem
            // 
            saveCustomersToolStripMenuItem.Name = "saveCustomersToolStripMenuItem";
            saveCustomersToolStripMenuItem.Size = new Size(160, 22);
            saveCustomersToolStripMenuItem.Text = "Save Customers";
            saveCustomersToolStripMenuItem.Click += saveCustomersToolStripMenuItem_Click;
            // 
            // saveMachinesToolStripMenuItem
            // 
            saveMachinesToolStripMenuItem.Name = "saveMachinesToolStripMenuItem";
            saveMachinesToolStripMenuItem.Size = new Size(160, 22);
            saveMachinesToolStripMenuItem.Text = "Save Machines";
            saveMachinesToolStripMenuItem.Click += saveMachinesToolStripMenuItem_Click;
            // 
            // loadCustomersToolStripMenuItem
            // 
            loadCustomersToolStripMenuItem.Name = "loadCustomersToolStripMenuItem";
            loadCustomersToolStripMenuItem.Size = new Size(160, 22);
            loadCustomersToolStripMenuItem.Text = "Load Customers";
            loadCustomersToolStripMenuItem.Click += loadCustomersToolStripMenuItem_Click;
            // 
            // loadMachinesToolStripMenuItem
            // 
            loadMachinesToolStripMenuItem.Name = "loadMachinesToolStripMenuItem";
            loadMachinesToolStripMenuItem.Size = new Size(160, 22);
            loadMachinesToolStripMenuItem.Text = "Load Machines";
            loadMachinesToolStripMenuItem.Click += loadMachinesToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(157, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(160, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutArcadeManagerToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // gbxArcadeFloor
            // 
            gbxArcadeFloor.Controls.Add(btnMachine4);
            gbxArcadeFloor.Controls.Add(btnMachine3);
            gbxArcadeFloor.Controls.Add(btnMachine6);
            gbxArcadeFloor.Controls.Add(btnMachine5);
            gbxArcadeFloor.Controls.Add(btnMachine2);
            gbxArcadeFloor.Controls.Add(btnMachine1);
            gbxArcadeFloor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxArcadeFloor.ForeColor = Color.White;
            gbxArcadeFloor.Location = new Point(6, 6);
            gbxArcadeFloor.Name = "gbxArcadeFloor";
            gbxArcadeFloor.Size = new Size(750, 341);
            gbxArcadeFloor.TabIndex = 1;
            gbxArcadeFloor.TabStop = false;
            gbxArcadeFloor.Text = "Arcade Floor";
            // 
            // btnMachine4
            // 
            btnMachine4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMachine4.ForeColor = Color.Black;
            btnMachine4.Location = new Point(254, 191);
            btnMachine4.Name = "btnMachine4";
            btnMachine4.Size = new Size(242, 144);
            btnMachine4.TabIndex = 5;
            btnMachine4.Text = "Machine4";
            btnMachine4.UseVisualStyleBackColor = true;
            btnMachine4.Click += btnMachine4_Click;
            // 
            // btnMachine3
            // 
            btnMachine3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMachine3.ForeColor = Color.Black;
            btnMachine3.Location = new Point(254, 34);
            btnMachine3.Name = "btnMachine3";
            btnMachine3.Size = new Size(242, 144);
            btnMachine3.TabIndex = 4;
            btnMachine3.Text = "Machine3";
            btnMachine3.UseVisualStyleBackColor = true;
            btnMachine3.Click += btnMachine3_Click;
            // 
            // btnMachine6
            // 
            btnMachine6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMachine6.ForeColor = Color.Black;
            btnMachine6.Location = new Point(502, 191);
            btnMachine6.Name = "btnMachine6";
            btnMachine6.Size = new Size(242, 144);
            btnMachine6.TabIndex = 3;
            btnMachine6.Text = "Machine6";
            btnMachine6.UseVisualStyleBackColor = true;
            btnMachine6.Click += btnMachine6_Click;
            // 
            // btnMachine5
            // 
            btnMachine5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMachine5.ForeColor = Color.Black;
            btnMachine5.Location = new Point(502, 34);
            btnMachine5.Name = "btnMachine5";
            btnMachine5.Size = new Size(242, 144);
            btnMachine5.TabIndex = 2;
            btnMachine5.Text = "Machine5";
            btnMachine5.UseVisualStyleBackColor = true;
            btnMachine5.Click += btnMachine5_Click;
            // 
            // btnMachine2
            // 
            btnMachine2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMachine2.ForeColor = Color.Black;
            btnMachine2.Location = new Point(6, 191);
            btnMachine2.Name = "btnMachine2";
            btnMachine2.Size = new Size(242, 144);
            btnMachine2.TabIndex = 1;
            btnMachine2.Text = "Machine2";
            btnMachine2.UseVisualStyleBackColor = true;
            btnMachine2.Click += btnMachine2_Click;
            // 
            // btnMachine1
            // 
            btnMachine1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMachine1.ForeColor = Color.Black;
            btnMachine1.Location = new Point(6, 34);
            btnMachine1.Name = "btnMachine1";
            btnMachine1.Size = new Size(242, 144);
            btnMachine1.TabIndex = 0;
            btnMachine1.Text = "Machine1";
            btnMachine1.UseVisualStyleBackColor = true;
            btnMachine1.Click += btnMachine1_Click;
            // 
            // gbxMachineInfo
            // 
            gbxMachineInfo.Controls.Add(txtbxMachineName);
            gbxMachineInfo.Controls.Add(label3);
            gbxMachineInfo.Controls.Add(txtbxDiscount);
            gbxMachineInfo.Controls.Add(lblDiscount);
            gbxMachineInfo.Controls.Add(txtbxPlayCost);
            gbxMachineInfo.Controls.Add(lblPlayCost);
            gbxMachineInfo.Controls.Add(gbxStatus);
            gbxMachineInfo.Controls.Add(lblMachineName);
            gbxMachineInfo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxMachineInfo.ForeColor = Color.White;
            gbxMachineInfo.Location = new Point(6, 353);
            gbxMachineInfo.Name = "gbxMachineInfo";
            gbxMachineInfo.Size = new Size(750, 159);
            gbxMachineInfo.TabIndex = 2;
            gbxMachineInfo.TabStop = false;
            gbxMachineInfo.Text = "Machine Information";
            // 
            // txtbxMachineName
            // 
            txtbxMachineName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxMachineName.Location = new Point(78, 37);
            txtbxMachineName.Name = "txtbxMachineName";
            txtbxMachineName.Size = new Size(350, 33);
            txtbxMachineName.TabIndex = 8;
            toolTipEnter.SetToolTip(txtbxMachineName, "Press Enter after typing in the box to update the machine information.");
            txtbxMachineName.KeyDown += txtbxMachineName_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(705, 109);
            label3.Name = "label3";
            label3.Size = new Size(28, 25);
            label3.TabIndex = 7;
            label3.Text = "%";
            toolTipEnter.SetToolTip(label3, "Press Enter after typing in the box to update the machine information.");
            // 
            // txtbxDiscount
            // 
            txtbxDiscount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxDiscount.Location = new Point(557, 106);
            txtbxDiscount.Name = "txtbxDiscount";
            txtbxDiscount.Size = new Size(142, 33);
            txtbxDiscount.TabIndex = 6;
            toolTipEnter.SetToolTip(txtbxDiscount, "Press Enter after typing in the box to update the machine information.");
            txtbxDiscount.KeyDown += txtbxDiscount_KeyDown;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiscount.Location = new Point(456, 109);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(95, 25);
            lblDiscount.TabIndex = 5;
            lblDiscount.Text = "Discount: ";
            toolTipEnter.SetToolTip(lblDiscount, "Press Enter after typing in the box to update the machine information.");
            // 
            // txtbxPlayCost
            // 
            txtbxPlayCost.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxPlayCost.Location = new Point(557, 37);
            txtbxPlayCost.Name = "txtbxPlayCost";
            txtbxPlayCost.Size = new Size(176, 33);
            txtbxPlayCost.TabIndex = 3;
            toolTipEnter.SetToolTip(txtbxPlayCost, "Press Enter after typing in the box to update the machine information.");
            txtbxPlayCost.KeyDown += txtbxPlayCost_KeyDown;
            // 
            // lblPlayCost
            // 
            lblPlayCost.AutoSize = true;
            lblPlayCost.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlayCost.Location = new Point(443, 40);
            lblPlayCost.Name = "lblPlayCost";
            lblPlayCost.Size = new Size(108, 25);
            lblPlayCost.TabIndex = 2;
            lblPlayCost.Text = "Play Cost: $";
            toolTipEnter.SetToolTip(lblPlayCost, "Press Enter after typing in the box to update the machine information.");
            // 
            // gbxStatus
            // 
            gbxStatus.Controls.Add(rbtnStatusMaintainence);
            gbxStatus.Controls.Add(rbtnStatusOutOfOrder);
            gbxStatus.Controls.Add(rbtnStatusAvailable);
            gbxStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxStatus.ForeColor = Color.White;
            gbxStatus.Location = new Point(6, 77);
            gbxStatus.Name = "gbxStatus";
            gbxStatus.Size = new Size(435, 78);
            gbxStatus.TabIndex = 1;
            gbxStatus.TabStop = false;
            gbxStatus.Text = "Status";
            // 
            // rbtnStatusMaintainence
            // 
            rbtnStatusMaintainence.AutoSize = true;
            rbtnStatusMaintainence.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtnStatusMaintainence.ForeColor = Color.Orange;
            rbtnStatusMaintainence.Location = new Point(272, 32);
            rbtnStatusMaintainence.Name = "rbtnStatusMaintainence";
            rbtnStatusMaintainence.Size = new Size(150, 29);
            rbtnStatusMaintainence.TabIndex = 2;
            rbtnStatusMaintainence.TabStop = true;
            rbtnStatusMaintainence.Text = "Maintainence";
            rbtnStatusMaintainence.UseVisualStyleBackColor = true;
            rbtnStatusMaintainence.Click += rbtnStatusMaintainence_CheckedChanged;
            // 
            // rbtnStatusOutOfOrder
            // 
            rbtnStatusOutOfOrder.AutoSize = true;
            rbtnStatusOutOfOrder.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtnStatusOutOfOrder.ForeColor = Color.Red;
            rbtnStatusOutOfOrder.Location = new Point(122, 32);
            rbtnStatusOutOfOrder.Name = "rbtnStatusOutOfOrder";
            rbtnStatusOutOfOrder.Size = new Size(144, 29);
            rbtnStatusOutOfOrder.TabIndex = 1;
            rbtnStatusOutOfOrder.TabStop = true;
            rbtnStatusOutOfOrder.Text = "Out of Order";
            rbtnStatusOutOfOrder.UseVisualStyleBackColor = true;
            rbtnStatusOutOfOrder.Click += rbtnStatusOutOfOrder_CheckedChanged;
            // 
            // rbtnStatusAvailable
            // 
            rbtnStatusAvailable.AutoSize = true;
            rbtnStatusAvailable.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtnStatusAvailable.ForeColor = Color.GreenYellow;
            rbtnStatusAvailable.Location = new Point(6, 32);
            rbtnStatusAvailable.Name = "rbtnStatusAvailable";
            rbtnStatusAvailable.Size = new Size(110, 29);
            rbtnStatusAvailable.TabIndex = 0;
            rbtnStatusAvailable.TabStop = true;
            rbtnStatusAvailable.Text = "Available";
            rbtnStatusAvailable.UseVisualStyleBackColor = true;
            rbtnStatusAvailable.Click += rbtnStatusAvailable_CheckedChanged;
            // 
            // lblMachineName
            // 
            lblMachineName.AutoSize = true;
            lblMachineName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMachineName.Location = new Point(6, 40);
            lblMachineName.Name = "lblMachineName";
            lblMachineName.Size = new Size(66, 25);
            lblMachineName.TabIndex = 0;
            lblMachineName.Text = "Name:";
            toolTipEnter.SetToolTip(lblMachineName, "Press Enter after typing in the box to update the machine information.");
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabMachines);
            tabControl1.Controls.Add(tabCustomers);
            tabControl1.Controls.Add(tabSimPlay);
            tabControl1.Location = new Point(12, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(771, 553);
            tabControl1.TabIndex = 3;
            // 
            // tabMachines
            // 
            tabMachines.BackColor = Color.MidnightBlue;
            tabMachines.Controls.Add(gbxArcadeFloor);
            tabMachines.Controls.Add(gbxMachineInfo);
            tabMachines.Location = new Point(4, 24);
            tabMachines.Name = "tabMachines";
            tabMachines.Padding = new Padding(3);
            tabMachines.Size = new Size(763, 525);
            tabMachines.TabIndex = 0;
            tabMachines.Text = "Machines";
            // 
            // tabCustomers
            // 
            tabCustomers.BackColor = Color.Maroon;
            tabCustomers.Controls.Add(gbxNewCard);
            tabCustomers.Controls.Add(gbxCustomerInfo);
            tabCustomers.Controls.Add(gbxPlayCards);
            tabCustomers.Location = new Point(4, 24);
            tabCustomers.Name = "tabCustomers";
            tabCustomers.Padding = new Padding(3);
            tabCustomers.Size = new Size(763, 525);
            tabCustomers.TabIndex = 1;
            tabCustomers.Text = "Customers";
            // 
            // gbxNewCard
            // 
            gbxNewCard.BackColor = Color.IndianRed;
            gbxNewCard.Controls.Add(txtbxNewCardName);
            gbxNewCard.Controls.Add(btnNewCardCancel);
            gbxNewCard.Controls.Add(btnNewCardAdd);
            gbxNewCard.Controls.Add(txtbxNewCardMoney);
            gbxNewCard.Controls.Add(gbxNewCardTier);
            gbxNewCard.Controls.Add(label2);
            gbxNewCard.Controls.Add(lblNewCardMoney);
            gbxNewCard.Controls.Add(lblNewCardName);
            gbxNewCard.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxNewCard.ForeColor = Color.White;
            gbxNewCard.Location = new Point(374, 251);
            gbxNewCard.Name = "gbxNewCard";
            gbxNewCard.Size = new Size(383, 268);
            gbxNewCard.TabIndex = 4;
            gbxNewCard.TabStop = false;
            gbxNewCard.Text = "New Card";
            // 
            // txtbxNewCardName
            // 
            txtbxNewCardName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxNewCardName.Location = new Point(83, 31);
            txtbxNewCardName.Name = "txtbxNewCardName";
            txtbxNewCardName.Size = new Size(294, 33);
            txtbxNewCardName.TabIndex = 9;
            // 
            // btnNewCardCancel
            // 
            btnNewCardCancel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewCardCancel.ForeColor = Color.Black;
            btnNewCardCancel.Location = new Point(249, 222);
            btnNewCardCancel.Name = "btnNewCardCancel";
            btnNewCardCancel.Size = new Size(128, 40);
            btnNewCardCancel.TabIndex = 8;
            btnNewCardCancel.Text = "Cancel";
            btnNewCardCancel.UseVisualStyleBackColor = true;
            btnNewCardCancel.Click += btnNewCardCancel_Click;
            // 
            // btnNewCardAdd
            // 
            btnNewCardAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewCardAdd.ForeColor = Color.Black;
            btnNewCardAdd.Location = new Point(115, 222);
            btnNewCardAdd.Name = "btnNewCardAdd";
            btnNewCardAdd.Size = new Size(128, 40);
            btnNewCardAdd.TabIndex = 7;
            btnNewCardAdd.Text = "Add";
            btnNewCardAdd.UseVisualStyleBackColor = true;
            btnNewCardAdd.Click += btnNewCardAdd_Click;
            // 
            // txtbxNewCardMoney
            // 
            txtbxNewCardMoney.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxNewCardMoney.Location = new Point(173, 65);
            txtbxNewCardMoney.Name = "txtbxNewCardMoney";
            txtbxNewCardMoney.Size = new Size(204, 33);
            txtbxNewCardMoney.TabIndex = 6;
            // 
            // gbxNewCardTier
            // 
            gbxNewCardTier.Controls.Add(rbtnNewCardVIPTier);
            gbxNewCardTier.Controls.Add(rbtnNewCardStdTier);
            gbxNewCardTier.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxNewCardTier.ForeColor = Color.White;
            gbxNewCardTier.Location = new Point(12, 104);
            gbxNewCardTier.Name = "gbxNewCardTier";
            gbxNewCardTier.Size = new Size(365, 78);
            gbxNewCardTier.TabIndex = 5;
            gbxNewCardTier.TabStop = false;
            gbxNewCardTier.Text = "Tier";
            // 
            // rbtnNewCardVIPTier
            // 
            rbtnNewCardVIPTier.AutoSize = true;
            rbtnNewCardVIPTier.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtnNewCardVIPTier.ForeColor = Color.Cyan;
            rbtnNewCardVIPTier.Location = new Point(124, 32);
            rbtnNewCardVIPTier.Name = "rbtnNewCardVIPTier";
            rbtnNewCardVIPTier.Size = new Size(61, 29);
            rbtnNewCardVIPTier.TabIndex = 1;
            rbtnNewCardVIPTier.TabStop = true;
            rbtnNewCardVIPTier.Text = "VIP";
            rbtnNewCardVIPTier.UseVisualStyleBackColor = true;
            // 
            // rbtnNewCardStdTier
            // 
            rbtnNewCardStdTier.AutoSize = true;
            rbtnNewCardStdTier.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtnNewCardStdTier.ForeColor = Color.White;
            rbtnNewCardStdTier.Location = new Point(6, 32);
            rbtnNewCardStdTier.Name = "rbtnNewCardStdTier";
            rbtnNewCardStdTier.Size = new Size(112, 29);
            rbtnNewCardStdTier.TabIndex = 0;
            rbtnNewCardStdTier.TabStop = true;
            rbtnNewCardStdTier.Text = "Standard";
            rbtnNewCardStdTier.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 139);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 4;
            // 
            // lblNewCardMoney
            // 
            lblNewCardMoney.AutoSize = true;
            lblNewCardMoney.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewCardMoney.Location = new Point(6, 68);
            lblNewCardMoney.Name = "lblNewCardMoney";
            lblNewCardMoney.Size = new Size(161, 25);
            lblNewCardMoney.TabIndex = 3;
            lblNewCardMoney.Text = "Money on Card: $";
            // 
            // lblNewCardName
            // 
            lblNewCardName.AutoSize = true;
            lblNewCardName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewCardName.Location = new Point(6, 34);
            lblNewCardName.Name = "lblNewCardName";
            lblNewCardName.Size = new Size(71, 25);
            lblNewCardName.TabIndex = 1;
            lblNewCardName.Text = "Name: ";
            // 
            // gbxCustomerInfo
            // 
            gbxCustomerInfo.Controls.Add(txtbxMoneyOnCard);
            gbxCustomerInfo.Controls.Add(gbxCustomerTier);
            gbxCustomerInfo.Controls.Add(label1);
            gbxCustomerInfo.Controls.Add(lblMoneyOnCard);
            gbxCustomerInfo.Controls.Add(lblCardID);
            gbxCustomerInfo.Controls.Add(lblCustomerName);
            gbxCustomerInfo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxCustomerInfo.ForeColor = Color.White;
            gbxCustomerInfo.Location = new Point(374, 6);
            gbxCustomerInfo.Name = "gbxCustomerInfo";
            gbxCustomerInfo.Size = new Size(383, 231);
            gbxCustomerInfo.TabIndex = 3;
            gbxCustomerInfo.TabStop = false;
            gbxCustomerInfo.Text = "Customer Information";
            // 
            // txtbxMoneyOnCard
            // 
            txtbxMoneyOnCard.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxMoneyOnCard.Location = new Point(173, 102);
            txtbxMoneyOnCard.Name = "txtbxMoneyOnCard";
            txtbxMoneyOnCard.Size = new Size(204, 33);
            txtbxMoneyOnCard.TabIndex = 6;
            // 
            // gbxCustomerTier
            // 
            gbxCustomerTier.Controls.Add(rbtnVIPTier);
            gbxCustomerTier.Controls.Add(rbtnStdTier);
            gbxCustomerTier.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxCustomerTier.ForeColor = Color.White;
            gbxCustomerTier.Location = new Point(12, 139);
            gbxCustomerTier.Name = "gbxCustomerTier";
            gbxCustomerTier.Size = new Size(365, 78);
            gbxCustomerTier.TabIndex = 5;
            gbxCustomerTier.TabStop = false;
            gbxCustomerTier.Text = "Tier";
            // 
            // rbtnVIPTier
            // 
            rbtnVIPTier.AutoSize = true;
            rbtnVIPTier.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtnVIPTier.ForeColor = Color.Cyan;
            rbtnVIPTier.Location = new Point(124, 32);
            rbtnVIPTier.Name = "rbtnVIPTier";
            rbtnVIPTier.Size = new Size(61, 29);
            rbtnVIPTier.TabIndex = 1;
            rbtnVIPTier.TabStop = true;
            rbtnVIPTier.Text = "VIP";
            rbtnVIPTier.UseVisualStyleBackColor = true;
            // 
            // rbtnStdTier
            // 
            rbtnStdTier.AutoSize = true;
            rbtnStdTier.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtnStdTier.ForeColor = Color.White;
            rbtnStdTier.Location = new Point(6, 32);
            rbtnStdTier.Name = "rbtnStdTier";
            rbtnStdTier.Size = new Size(112, 29);
            rbtnStdTier.TabIndex = 0;
            rbtnStdTier.TabStop = true;
            rbtnStdTier.Text = "Standard";
            rbtnStdTier.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 139);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 4;
            // 
            // lblMoneyOnCard
            // 
            lblMoneyOnCard.AutoSize = true;
            lblMoneyOnCard.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMoneyOnCard.Location = new Point(6, 105);
            lblMoneyOnCard.Name = "lblMoneyOnCard";
            lblMoneyOnCard.Size = new Size(161, 25);
            lblMoneyOnCard.TabIndex = 3;
            lblMoneyOnCard.Text = "Money on Card: $";
            // 
            // lblCardID
            // 
            lblCardID.AutoSize = true;
            lblCardID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCardID.Location = new Point(6, 68);
            lblCardID.Name = "lblCardID";
            lblCardID.Size = new Size(84, 25);
            lblCardID.TabIndex = 2;
            lblCardID.Text = "Card ID: ";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerName.Location = new Point(6, 34);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(71, 25);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "Name: ";
            // 
            // gbxPlayCards
            // 
            gbxPlayCards.Controls.Add(lblSortPlayCards);
            gbxPlayCards.Controls.Add(cmbxSortPlayCards);
            gbxPlayCards.Controls.Add(btnRemoveCard);
            gbxPlayCards.Controls.Add(btnAddCard);
            gbxPlayCards.Controls.Add(lbxPlayCards);
            gbxPlayCards.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxPlayCards.ForeColor = Color.White;
            gbxPlayCards.Location = new Point(7, 6);
            gbxPlayCards.Name = "gbxPlayCards";
            gbxPlayCards.Size = new Size(361, 513);
            gbxPlayCards.TabIndex = 2;
            gbxPlayCards.TabStop = false;
            gbxPlayCards.Text = "Play Cards";
            // 
            // lblSortPlayCards
            // 
            lblSortPlayCards.AutoSize = true;
            lblSortPlayCards.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSortPlayCards.Location = new Point(104, 31);
            lblSortPlayCards.Name = "lblSortPlayCards";
            lblSortPlayCards.Size = new Size(63, 21);
            lblSortPlayCards.TabIndex = 7;
            lblSortPlayCards.Text = "Sort by:";
            // 
            // cmbxSortPlayCards
            // 
            cmbxSortPlayCards.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbxSortPlayCards.FormattingEnabled = true;
            cmbxSortPlayCards.Items.AddRange(new object[] { "ID", "Balance (Low to High)", "Balance (High to Low)" });
            cmbxSortPlayCards.Location = new Point(173, 27);
            cmbxSortPlayCards.Name = "cmbxSortPlayCards";
            cmbxSortPlayCards.Size = new Size(182, 29);
            cmbxSortPlayCards.TabIndex = 6;
            cmbxSortPlayCards.Text = "ID";
            cmbxSortPlayCards.SelectedIndexChanged += cmbxSortPlayCards_SelectedIndexChanged;
            // 
            // btnRemoveCard
            // 
            btnRemoveCard.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoveCard.ForeColor = Color.Black;
            btnRemoveCard.Location = new Point(184, 467);
            btnRemoveCard.Name = "btnRemoveCard";
            btnRemoveCard.Size = new Size(171, 40);
            btnRemoveCard.TabIndex = 5;
            btnRemoveCard.Text = "Remove Card";
            btnRemoveCard.UseVisualStyleBackColor = true;
            btnRemoveCard.Click += btnRemoveCard_Click;
            // 
            // btnAddCard
            // 
            btnAddCard.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddCard.ForeColor = Color.Black;
            btnAddCard.Location = new Point(6, 467);
            btnAddCard.Name = "btnAddCard";
            btnAddCard.Size = new Size(172, 40);
            btnAddCard.TabIndex = 4;
            btnAddCard.Text = "Add Card";
            btnAddCard.UseVisualStyleBackColor = true;
            btnAddCard.Click += btnAddCard_Click;
            // 
            // lbxPlayCards
            // 
            lbxPlayCards.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbxPlayCards.FormattingEnabled = true;
            lbxPlayCards.Location = new Point(6, 59);
            lbxPlayCards.Name = "lbxPlayCards";
            lbxPlayCards.Size = new Size(349, 404);
            lbxPlayCards.TabIndex = 3;
            lbxPlayCards.SelectedIndexChanged += lbxPlayCards_SelectedIndexChanged;
            // 
            // tabSimPlay
            // 
            tabSimPlay.BackColor = SystemColors.WindowFrame;
            tabSimPlay.Controls.Add(btnSimPlay);
            tabSimPlay.Controls.Add(gbxChooseCard);
            tabSimPlay.Controls.Add(gbxChooseMachine);
            tabSimPlay.Location = new Point(4, 24);
            tabSimPlay.Name = "tabSimPlay";
            tabSimPlay.Size = new Size(763, 525);
            tabSimPlay.TabIndex = 2;
            tabSimPlay.Text = "Simulate Play";
            tabSimPlay.Enter += tabSimPlay_Enter;
            // 
            // btnSimPlay
            // 
            btnSimPlay.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSimPlay.Location = new Point(265, 319);
            btnSimPlay.Name = "btnSimPlay";
            btnSimPlay.Size = new Size(237, 50);
            btnSimPlay.TabIndex = 4;
            btnSimPlay.Text = "Swipe Card";
            btnSimPlay.UseVisualStyleBackColor = true;
            btnSimPlay.Click += btnSimPlay_Click;
            // 
            // gbxChooseCard
            // 
            gbxChooseCard.BackColor = Color.Maroon;
            gbxChooseCard.Controls.Add(lblSimPlayVIP);
            gbxChooseCard.Controls.Add(lblSimPlayMoneyOnCard);
            gbxChooseCard.Controls.Add(cmbxPlayCards);
            gbxChooseCard.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxChooseCard.ForeColor = Color.White;
            gbxChooseCard.Location = new Point(385, 151);
            gbxChooseCard.Name = "gbxChooseCard";
            gbxChooseCard.Size = new Size(362, 162);
            gbxChooseCard.TabIndex = 3;
            gbxChooseCard.TabStop = false;
            gbxChooseCard.Text = "Choose Play Card";
            // 
            // lblSimPlayVIP
            // 
            lblSimPlayVIP.AutoSize = true;
            lblSimPlayVIP.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSimPlayVIP.Location = new Point(6, 125);
            lblSimPlayVIP.Name = "lblSimPlayVIP";
            lblSimPlayVIP.Size = new Size(49, 25);
            lblSimPlayVIP.TabIndex = 9;
            lblSimPlayVIP.Text = "VIP: ";
            // 
            // lblSimPlayMoneyOnCard
            // 
            lblSimPlayMoneyOnCard.AutoSize = true;
            lblSimPlayMoneyOnCard.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSimPlayMoneyOnCard.Location = new Point(6, 90);
            lblSimPlayMoneyOnCard.Name = "lblSimPlayMoneyOnCard";
            lblSimPlayMoneyOnCard.Size = new Size(161, 25);
            lblSimPlayMoneyOnCard.TabIndex = 8;
            lblSimPlayMoneyOnCard.Text = "Money on Card: $";
            // 
            // cmbxPlayCards
            // 
            cmbxPlayCards.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbxPlayCards.FormattingEnabled = true;
            cmbxPlayCards.Location = new Point(6, 44);
            cmbxPlayCards.Name = "cmbxPlayCards";
            cmbxPlayCards.Size = new Size(350, 33);
            cmbxPlayCards.TabIndex = 7;
            cmbxPlayCards.SelectedIndexChanged += cmbxPlayCards_SelectedIndexChanged;
            // 
            // gbxChooseMachine
            // 
            gbxChooseMachine.BackColor = Color.MidnightBlue;
            gbxChooseMachine.Controls.Add(cmbxMachines);
            gbxChooseMachine.Controls.Add(lblSimPlayPlayCost3);
            gbxChooseMachine.Controls.Add(lblSimPlayPlayCost2);
            gbxChooseMachine.Controls.Add(lblSimPlayPlayCost1);
            gbxChooseMachine.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxChooseMachine.ForeColor = Color.White;
            gbxChooseMachine.Location = new Point(15, 151);
            gbxChooseMachine.Name = "gbxChooseMachine";
            gbxChooseMachine.Size = new Size(362, 162);
            gbxChooseMachine.TabIndex = 2;
            gbxChooseMachine.TabStop = false;
            gbxChooseMachine.Text = "Choose Machine";
            // 
            // cmbxMachines
            // 
            cmbxMachines.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbxMachines.FormattingEnabled = true;
            cmbxMachines.Location = new Point(6, 44);
            cmbxMachines.Name = "cmbxMachines";
            cmbxMachines.Size = new Size(350, 33);
            cmbxMachines.TabIndex = 8;
            cmbxMachines.SelectedIndexChanged += cmbxMachines_SelectedIndexChanged;
            // 
            // lblSimPlayPlayCost3
            // 
            lblSimPlayPlayCost3.AutoSize = true;
            lblSimPlayPlayCost3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSimPlayPlayCost3.Location = new Point(16, 125);
            lblSimPlayPlayCost3.Name = "lblSimPlayPlayCost3";
            lblSimPlayPlayCost3.Size = new Size(179, 25);
            lblSimPlayPlayCost3.TabIndex = 7;
            lblSimPlayPlayCost3.Text = "with VIP Discount: $";
            // 
            // lblSimPlayPlayCost2
            // 
            lblSimPlayPlayCost2.AutoSize = true;
            lblSimPlayPlayCost2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSimPlayPlayCost2.Location = new Point(110, 90);
            lblSimPlayPlayCost2.Name = "lblSimPlayPlayCost2";
            lblSimPlayPlayCost2.Size = new Size(46, 25);
            lblSimPlayPlayCost2.TabIndex = 6;
            lblSimPlayPlayCost2.Text = "0.00";
            // 
            // lblSimPlayPlayCost1
            // 
            lblSimPlayPlayCost1.AutoSize = true;
            lblSimPlayPlayCost1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSimPlayPlayCost1.Location = new Point(6, 90);
            lblSimPlayPlayCost1.Name = "lblSimPlayPlayCost1";
            lblSimPlayPlayCost1.Size = new Size(108, 25);
            lblSimPlayPlayCost1.TabIndex = 5;
            lblSimPlayPlayCost1.Text = "Play Cost: $";
            // 
            // aboutArcadeManagerToolStripMenuItem
            // 
            aboutArcadeManagerToolStripMenuItem.Name = "aboutArcadeManagerToolStripMenuItem";
            aboutArcadeManagerToolStripMenuItem.Size = new Size(197, 22);
            aboutArcadeManagerToolStripMenuItem.Text = "About Arcade Manager";
            aboutArcadeManagerToolStripMenuItem.Click += aboutArcadeManagerToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(794, 592);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Arcade Manager";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            gbxArcadeFloor.ResumeLayout(false);
            gbxMachineInfo.ResumeLayout(false);
            gbxMachineInfo.PerformLayout();
            gbxStatus.ResumeLayout(false);
            gbxStatus.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabMachines.ResumeLayout(false);
            tabCustomers.ResumeLayout(false);
            gbxNewCard.ResumeLayout(false);
            gbxNewCard.PerformLayout();
            gbxNewCardTier.ResumeLayout(false);
            gbxNewCardTier.PerformLayout();
            gbxCustomerInfo.ResumeLayout(false);
            gbxCustomerInfo.PerformLayout();
            gbxCustomerTier.ResumeLayout(false);
            gbxCustomerTier.PerformLayout();
            gbxPlayCards.ResumeLayout(false);
            gbxPlayCards.PerformLayout();
            tabSimPlay.ResumeLayout(false);
            gbxChooseCard.ResumeLayout(false);
            gbxChooseCard.PerformLayout();
            gbxChooseMachine.ResumeLayout(false);
            gbxChooseMachine.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private GroupBox gbxArcadeFloor;
        private GroupBox gbxMachineInfo;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Button btnMachine4;
        private Button btnMachine3;
        private Button btnMachine6;
        private Button btnMachine5;
        private Button btnMachine2;
        private Button btnMachine1;
        private GroupBox gbxStatus;
        private RadioButton rbtnStatusMaintainence;
        private RadioButton rbtnStatusOutOfOrder;
        private RadioButton rbtnStatusAvailable;
        private Label lblMachineName;
        private TextBox txtbxPlayCost;
        private Label lblPlayCost;
        private ToolStripMenuItem saveCustomersToolStripMenuItem;
        private ToolStripMenuItem saveMachinesToolStripMenuItem;
        private ToolStripMenuItem loadCustomersToolStripMenuItem;
        private ToolStripMenuItem loadMachinesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabMachines;
        private TabPage tabCustomers;
        private GroupBox gbxPlayCards;
        private ListBox lbxPlayCards;
        private Button btnAddCard;
        private GroupBox gbxCustomerInfo;
        private Button btnRemoveCard;
        private Label lblMoneyOnCard;
        private Label lblCardID;
        private Label lblCustomerName;
        private GroupBox gbxCustomerTier;
        private RadioButton rbtnVIPTier;
        private RadioButton rbtnStdTier;
        private Label label1;
        private TextBox txtbxMoneyOnCard;
        private GroupBox gbxNewCard;
        private TextBox txtbxNewCardMoney;
        private GroupBox gbxNewCardTier;
        private RadioButton rbtnNewCardVIPTier;
        private RadioButton rbtnNewCardStdTier;
        private Label label2;
        private Label lblNewCardMoney;
        private Label lblNewCardName;
        private Button btnNewCardCancel;
        private Button btnNewCardAdd;
        private TextBox txtbxNewCardName;
        private ComboBox cmbxSortPlayCards;
        private Label lblSortPlayCards;
        private Label lblDiscount;
        private TextBox txtbxDiscount;
        private Label label3;
        private TabPage tabSimPlay;
        private GroupBox gbxChooseMachine;
        private Label lblSimPlayPlayCost3;
        private Label lblSimPlayPlayCost2;
        private Label lblSimPlayPlayCost1;
        private GroupBox gbxChooseCard;
        private Label lblSimPlayVIP;
        private Label lblSimPlayMoneyOnCard;
        private ComboBox cmbxPlayCards;
        private ComboBox cmbxMachines;
        private Button btnSimPlay;
        private TextBox txtbxMachineName;
        private ToolTip toolTipEnter;
        private ToolStripMenuItem aboutArcadeManagerToolStripMenuItem;
    }
}
