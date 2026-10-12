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
        private void InitializeComponent() {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadMachinesToolStripMenuItem = new ToolStripMenuItem();
            loadCustomersToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            saveMachinesToolStripMenuItem = new ToolStripMenuItem();
            saveCustomersToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabMachines = new TabPage();
            gbxArcadeFloor = new GroupBox();
            lbxFloorMachines = new ListBox();
            btnAddMach = new Button();
            btnRemoveMach = new Button();
            gbxNewMach = new GroupBox();
            cmbxNewMachGenre = new ComboBox();
            btnNewMachCancel = new Button();
            btnNewMachAdd = new Button();
            lblNewMachDiscount = new Label();
            txtbxNewMachDiscount = new TextBox();
            label4 = new Label();
            txtbxNewMachPlayCost = new TextBox();
            lblNewMachPlayCost = new Label();
            gbxNewMachStatus = new GroupBox();
            rbtnNewMachStatusMaint = new RadioButton();
            rbtnNewMachStatusOutOrder = new RadioButton();
            rbtnNewMachStatusAvail = new RadioButton();
            lblNewMachGenre = new Label();
            txtbxNewMachName = new TextBox();
            lblNewMachName = new Label();
            gbxMachInfo = new GroupBox();
            lblMachDiscount = new Label();
            txtbxMachDiscount = new TextBox();
            label1 = new Label();
            txtbxMachPlayCost = new TextBox();
            lblMachPlayCost = new Label();
            gbxMachStatus = new GroupBox();
            rbtnStatusMaint = new RadioButton();
            rbtnStatusOutOrder = new RadioButton();
            rbtnStatusAvail = new RadioButton();
            lblMachGenre = new Label();
            txtbxMachName = new TextBox();
            lblMachName = new Label();
            tabPlayCards = new TabPage();
            gbxPlayCards = new GroupBox();
            cmbxSortCards = new ComboBox();
            lblSortCards = new Label();
            lbxPlayCards = new ListBox();
            btnAddCard = new Button();
            btnRemoveCard = new Button();
            gbxNewPlayCard = new GroupBox();
            txtbxNewCardBalance = new TextBox();
            lblNewCardBalance = new Label();
            gbxNewCardStatus = new GroupBox();
            rbtnNewCardStatusVIP = new RadioButton();
            rbtnNewCardStatusStd = new RadioButton();
            txtbxNewCardCustName = new TextBox();
            lblNewCardCustName = new Label();
            btnNewCardCancel = new Button();
            btnNewCardAdd = new Button();
            gbxCustInfo = new GroupBox();
            btnTopUp5 = new Button();
            btnTopUp1 = new Button();
            btnTopUp10 = new Button();
            lblCustID = new Label();
            txtbxCustBalance = new TextBox();
            lblCustBalance = new Label();
            groupBox5 = new GroupBox();
            rbtnCustStatusVIP = new RadioButton();
            rbtnCustStatusStd = new RadioButton();
            txtbxCustName = new TextBox();
            lblCustName = new Label();
            tabSimPlay = new TabPage();
            btnSwipeCard = new Button();
            gbxSimPlayCard = new GroupBox();
            lblSimPlayCustStatus = new Label();
            lblSimPlayMoneyOnCard = new Label();
            cmbxSimPlayCards = new ComboBox();
            gbxSimPlayMachine = new GroupBox();
            lblSimPlayPlayCost2 = new Label();
            lblSimPlayPlayCostVIP = new Label();
            lblSimPlayPlayCost = new Label();
            cmbxSimPlayMachines = new ComboBox();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabMachines.SuspendLayout();
            gbxArcadeFloor.SuspendLayout();
            gbxNewMach.SuspendLayout();
            gbxNewMachStatus.SuspendLayout();
            gbxMachInfo.SuspendLayout();
            gbxMachStatus.SuspendLayout();
            tabPlayCards.SuspendLayout();
            gbxPlayCards.SuspendLayout();
            gbxNewPlayCard.SuspendLayout();
            gbxNewCardStatus.SuspendLayout();
            gbxCustInfo.SuspendLayout();
            groupBox5.SuspendLayout();
            tabSimPlay.SuspendLayout();
            gbxSimPlayCard.SuspendLayout();
            gbxSimPlayMachine.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadMachinesToolStripMenuItem, loadCustomersToolStripMenuItem, toolStripSeparator1, saveMachinesToolStripMenuItem, saveCustomersToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadMachinesToolStripMenuItem
            // 
            loadMachinesToolStripMenuItem.Name = "loadMachinesToolStripMenuItem";
            loadMachinesToolStripMenuItem.Size = new Size(160, 22);
            loadMachinesToolStripMenuItem.Text = "Load Machines";
            loadMachinesToolStripMenuItem.Click += loadMachinesToolStripMenuItem_Click;
            // 
            // loadCustomersToolStripMenuItem
            // 
            loadCustomersToolStripMenuItem.Name = "loadCustomersToolStripMenuItem";
            loadCustomersToolStripMenuItem.Size = new Size(160, 22);
            loadCustomersToolStripMenuItem.Text = "Load Customers";
            loadCustomersToolStripMenuItem.Click += loadCustomersToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(157, 6);
            // 
            // saveMachinesToolStripMenuItem
            // 
            saveMachinesToolStripMenuItem.Name = "saveMachinesToolStripMenuItem";
            saveMachinesToolStripMenuItem.Size = new Size(160, 22);
            saveMachinesToolStripMenuItem.Text = "Save Machines";
            saveMachinesToolStripMenuItem.Click += saveMachinesToolStripMenuItem_Click;
            // 
            // saveCustomersToolStripMenuItem
            // 
            saveCustomersToolStripMenuItem.Name = "saveCustomersToolStripMenuItem";
            saveCustomersToolStripMenuItem.Size = new Size(160, 22);
            saveCustomersToolStripMenuItem.Text = "Save Customers";
            saveCustomersToolStripMenuItem.Click += saveCustomersToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(157, 6);
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
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutArcadeManagerToolStripMenuItem_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabMachines);
            tabControl1.Controls.Add(tabPlayCards);
            tabControl1.Controls.Add(tabSimPlay);
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(12, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 486);
            tabControl1.TabIndex = 1;
            // 
            // tabMachines
            // 
            tabMachines.BackColor = Color.MidnightBlue;
            tabMachines.Controls.Add(gbxArcadeFloor);
            tabMachines.Controls.Add(gbxNewMach);
            tabMachines.Controls.Add(gbxMachInfo);
            tabMachines.Location = new Point(4, 30);
            tabMachines.Name = "tabMachines";
            tabMachines.Padding = new Padding(3);
            tabMachines.Size = new Size(768, 452);
            tabMachines.TabIndex = 0;
            tabMachines.Text = "Machines";
            // 
            // gbxArcadeFloor
            // 
            gbxArcadeFloor.Controls.Add(lbxFloorMachines);
            gbxArcadeFloor.Controls.Add(btnAddMach);
            gbxArcadeFloor.Controls.Add(btnRemoveMach);
            gbxArcadeFloor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxArcadeFloor.ForeColor = SystemColors.ControlLightLight;
            gbxArcadeFloor.Location = new Point(404, 6);
            gbxArcadeFloor.Name = "gbxArcadeFloor";
            gbxArcadeFloor.Size = new Size(358, 440);
            gbxArcadeFloor.TabIndex = 2;
            gbxArcadeFloor.TabStop = false;
            gbxArcadeFloor.Text = "Arcade Floor";
            // 
            // lbxFloorMachines
            // 
            lbxFloorMachines.FormattingEnabled = true;
            lbxFloorMachines.Location = new Point(6, 32);
            lbxFloorMachines.Name = "lbxFloorMachines";
            lbxFloorMachines.Size = new Size(346, 354);
            lbxFloorMachines.TabIndex = 14;
            lbxFloorMachines.SelectedIndexChanged += lbxFloorMachines_SelectedIndexChanged;
            // 
            // btnAddMach
            // 
            btnAddMach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddMach.ForeColor = SystemColors.ControlText;
            btnAddMach.Location = new Point(58, 407);
            btnAddMach.Name = "btnAddMach";
            btnAddMach.Size = new Size(144, 28);
            btnAddMach.TabIndex = 13;
            btnAddMach.Text = "Add Machine";
            btnAddMach.UseVisualStyleBackColor = true;
            btnAddMach.Click += btnAddMach_Click;
            // 
            // btnRemoveMach
            // 
            btnRemoveMach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoveMach.ForeColor = SystemColors.ControlText;
            btnRemoveMach.Location = new Point(208, 406);
            btnRemoveMach.Name = "btnRemoveMach";
            btnRemoveMach.Size = new Size(144, 28);
            btnRemoveMach.TabIndex = 12;
            btnRemoveMach.Text = "Remove Machine";
            btnRemoveMach.UseVisualStyleBackColor = true;
            btnRemoveMach.Click += btnRemoveMach_Click;
            // 
            // gbxNewMach
            // 
            gbxNewMach.BackColor = Color.RoyalBlue;
            gbxNewMach.Controls.Add(cmbxNewMachGenre);
            gbxNewMach.Controls.Add(btnNewMachCancel);
            gbxNewMach.Controls.Add(btnNewMachAdd);
            gbxNewMach.Controls.Add(lblNewMachDiscount);
            gbxNewMach.Controls.Add(txtbxNewMachDiscount);
            gbxNewMach.Controls.Add(label4);
            gbxNewMach.Controls.Add(txtbxNewMachPlayCost);
            gbxNewMach.Controls.Add(lblNewMachPlayCost);
            gbxNewMach.Controls.Add(gbxNewMachStatus);
            gbxNewMach.Controls.Add(lblNewMachGenre);
            gbxNewMach.Controls.Add(txtbxNewMachName);
            gbxNewMach.Controls.Add(lblNewMachName);
            gbxNewMach.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxNewMach.ForeColor = SystemColors.ControlLightLight;
            gbxNewMach.Location = new Point(6, 208);
            gbxNewMach.Name = "gbxNewMach";
            gbxNewMach.Size = new Size(392, 239);
            gbxNewMach.TabIndex = 1;
            gbxNewMach.TabStop = false;
            gbxNewMach.Text = "New Machine";
            // 
            // cmbxNewMachGenre
            // 
            cmbxNewMachGenre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbxNewMachGenre.FormattingEnabled = true;
            cmbxNewMachGenre.Items.AddRange(new object[] { "Fighting Game", "Racing Sim", "Shooter", "Other" });
            cmbxNewMachGenre.Location = new Point(67, 67);
            cmbxNewMachGenre.Name = "cmbxNewMachGenre";
            cmbxNewMachGenre.Size = new Size(319, 29);
            cmbxNewMachGenre.TabIndex = 12;
            cmbxNewMachGenre.Text = "Other";
            // 
            // btnNewMachCancel
            // 
            btnNewMachCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewMachCancel.ForeColor = SystemColors.ControlText;
            btnNewMachCancel.Location = new Point(311, 205);
            btnNewMachCancel.Name = "btnNewMachCancel";
            btnNewMachCancel.Size = new Size(75, 28);
            btnNewMachCancel.TabIndex = 11;
            btnNewMachCancel.Text = "Cancel";
            btnNewMachCancel.UseVisualStyleBackColor = true;
            btnNewMachCancel.Click += btnNewMachCancel_Click;
            // 
            // btnNewMachAdd
            // 
            btnNewMachAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewMachAdd.ForeColor = SystemColors.ControlText;
            btnNewMachAdd.Location = new Point(230, 205);
            btnNewMachAdd.Name = "btnNewMachAdd";
            btnNewMachAdd.Size = new Size(75, 28);
            btnNewMachAdd.TabIndex = 10;
            btnNewMachAdd.Text = "Add";
            btnNewMachAdd.UseVisualStyleBackColor = true;
            btnNewMachAdd.Click += btnNewMachAdd_Click;
            // 
            // lblNewMachDiscount
            // 
            lblNewMachDiscount.AutoSize = true;
            lblNewMachDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewMachDiscount.Location = new Point(227, 164);
            lblNewMachDiscount.Name = "lblNewMachDiscount";
            lblNewMachDiscount.Size = new Size(74, 21);
            lblNewMachDiscount.TabIndex = 9;
            lblNewMachDiscount.Text = "Discount:";
            // 
            // txtbxNewMachDiscount
            // 
            txtbxNewMachDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxNewMachDiscount.Location = new Point(307, 161);
            txtbxNewMachDiscount.Name = "txtbxNewMachDiscount";
            txtbxNewMachDiscount.Size = new Size(59, 29);
            txtbxNewMachDiscount.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(363, 164);
            label4.Name = "label4";
            label4.Size = new Size(23, 21);
            label4.TabIndex = 7;
            label4.Text = "%";
            // 
            // txtbxNewMachPlayCost
            // 
            txtbxNewMachPlayCost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxNewMachPlayCost.Location = new Point(93, 161);
            txtbxNewMachPlayCost.Name = "txtbxNewMachPlayCost";
            txtbxNewMachPlayCost.Size = new Size(128, 29);
            txtbxNewMachPlayCost.TabIndex = 6;
            // 
            // lblNewMachPlayCost
            // 
            lblNewMachPlayCost.AutoSize = true;
            lblNewMachPlayCost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewMachPlayCost.Location = new Point(6, 164);
            lblNewMachPlayCost.Name = "lblNewMachPlayCost";
            lblNewMachPlayCost.Size = new Size(90, 21);
            lblNewMachPlayCost.TabIndex = 5;
            lblNewMachPlayCost.Text = "Play Cost: $";
            // 
            // gbxNewMachStatus
            // 
            gbxNewMachStatus.Controls.Add(rbtnNewMachStatusMaint);
            gbxNewMachStatus.Controls.Add(rbtnNewMachStatusOutOrder);
            gbxNewMachStatus.Controls.Add(rbtnNewMachStatusAvail);
            gbxNewMachStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxNewMachStatus.ForeColor = SystemColors.ControlLightLight;
            gbxNewMachStatus.Location = new Point(6, 94);
            gbxNewMachStatus.Name = "gbxNewMachStatus";
            gbxNewMachStatus.Size = new Size(380, 61);
            gbxNewMachStatus.TabIndex = 4;
            gbxNewMachStatus.TabStop = false;
            gbxNewMachStatus.Text = "Status";
            // 
            // rbtnNewMachStatusMaint
            // 
            rbtnNewMachStatusMaint.AutoSize = true;
            rbtnNewMachStatusMaint.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtnNewMachStatusMaint.ForeColor = Color.Orange;
            rbtnNewMachStatusMaint.Location = new Point(241, 28);
            rbtnNewMachStatusMaint.Name = "rbtnNewMachStatusMaint";
            rbtnNewMachStatusMaint.Size = new Size(133, 25);
            rbtnNewMachStatusMaint.TabIndex = 2;
            rbtnNewMachStatusMaint.TabStop = true;
            rbtnNewMachStatusMaint.Text = "Maintainence";
            rbtnNewMachStatusMaint.UseVisualStyleBackColor = true;
            // 
            // rbtnNewMachStatusOutOrder
            // 
            rbtnNewMachStatusOutOrder.AutoSize = true;
            rbtnNewMachStatusOutOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtnNewMachStatusOutOrder.ForeColor = Color.Red;
            rbtnNewMachStatusOutOrder.Location = new Point(112, 28);
            rbtnNewMachStatusOutOrder.Name = "rbtnNewMachStatusOutOrder";
            rbtnNewMachStatusOutOrder.Size = new Size(123, 25);
            rbtnNewMachStatusOutOrder.TabIndex = 1;
            rbtnNewMachStatusOutOrder.TabStop = true;
            rbtnNewMachStatusOutOrder.Text = "Out of Order";
            rbtnNewMachStatusOutOrder.UseVisualStyleBackColor = true;
            // 
            // rbtnNewMachStatusAvail
            // 
            rbtnNewMachStatusAvail.AutoSize = true;
            rbtnNewMachStatusAvail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtnNewMachStatusAvail.ForeColor = Color.GreenYellow;
            rbtnNewMachStatusAvail.Location = new Point(6, 28);
            rbtnNewMachStatusAvail.Name = "rbtnNewMachStatusAvail";
            rbtnNewMachStatusAvail.Size = new Size(100, 25);
            rbtnNewMachStatusAvail.TabIndex = 0;
            rbtnNewMachStatusAvail.TabStop = true;
            rbtnNewMachStatusAvail.Text = "Available";
            rbtnNewMachStatusAvail.UseVisualStyleBackColor = true;
            // 
            // lblNewMachGenre
            // 
            lblNewMachGenre.AutoSize = true;
            lblNewMachGenre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewMachGenre.Location = new Point(6, 70);
            lblNewMachGenre.Name = "lblNewMachGenre";
            lblNewMachGenre.Size = new Size(59, 21);
            lblNewMachGenre.TabIndex = 3;
            lblNewMachGenre.Text = "Genre: ";
            // 
            // txtbxNewMachName
            // 
            txtbxNewMachName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxNewMachName.Location = new Point(67, 32);
            txtbxNewMachName.Name = "txtbxNewMachName";
            txtbxNewMachName.Size = new Size(319, 29);
            txtbxNewMachName.TabIndex = 1;
            // 
            // lblNewMachName
            // 
            lblNewMachName.AutoSize = true;
            lblNewMachName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewMachName.Location = new Point(6, 35);
            lblNewMachName.Name = "lblNewMachName";
            lblNewMachName.Size = new Size(55, 21);
            lblNewMachName.TabIndex = 0;
            lblNewMachName.Text = "Name:";
            // 
            // gbxMachInfo
            // 
            gbxMachInfo.Controls.Add(lblMachDiscount);
            gbxMachInfo.Controls.Add(txtbxMachDiscount);
            gbxMachInfo.Controls.Add(label1);
            gbxMachInfo.Controls.Add(txtbxMachPlayCost);
            gbxMachInfo.Controls.Add(lblMachPlayCost);
            gbxMachInfo.Controls.Add(gbxMachStatus);
            gbxMachInfo.Controls.Add(lblMachGenre);
            gbxMachInfo.Controls.Add(txtbxMachName);
            gbxMachInfo.Controls.Add(lblMachName);
            gbxMachInfo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxMachInfo.ForeColor = SystemColors.ControlLightLight;
            gbxMachInfo.Location = new Point(6, 6);
            gbxMachInfo.Name = "gbxMachInfo";
            gbxMachInfo.Size = new Size(392, 196);
            gbxMachInfo.TabIndex = 0;
            gbxMachInfo.TabStop = false;
            gbxMachInfo.Text = "Machine Information";
            // 
            // lblMachDiscount
            // 
            lblMachDiscount.AutoSize = true;
            lblMachDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMachDiscount.Location = new Point(227, 164);
            lblMachDiscount.Name = "lblMachDiscount";
            lblMachDiscount.Size = new Size(74, 21);
            lblMachDiscount.TabIndex = 9;
            lblMachDiscount.Text = "Discount:";
            // 
            // txtbxMachDiscount
            // 
            txtbxMachDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxMachDiscount.Location = new Point(307, 161);
            txtbxMachDiscount.Name = "txtbxMachDiscount";
            txtbxMachDiscount.Size = new Size(59, 29);
            txtbxMachDiscount.TabIndex = 8;
            txtbxMachDiscount.KeyDown += txtbxDiscount_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(363, 164);
            label1.Name = "label1";
            label1.Size = new Size(23, 21);
            label1.TabIndex = 7;
            label1.Text = "%";
            // 
            // txtbxMachPlayCost
            // 
            txtbxMachPlayCost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxMachPlayCost.Location = new Point(93, 161);
            txtbxMachPlayCost.Name = "txtbxMachPlayCost";
            txtbxMachPlayCost.Size = new Size(128, 29);
            txtbxMachPlayCost.TabIndex = 6;
            txtbxMachPlayCost.KeyDown += txtbxPlayCost_KeyDown;
            // 
            // lblMachPlayCost
            // 
            lblMachPlayCost.AutoSize = true;
            lblMachPlayCost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMachPlayCost.Location = new Point(6, 164);
            lblMachPlayCost.Name = "lblMachPlayCost";
            lblMachPlayCost.Size = new Size(90, 21);
            lblMachPlayCost.TabIndex = 5;
            lblMachPlayCost.Text = "Play Cost: $";
            // 
            // gbxMachStatus
            // 
            gbxMachStatus.Controls.Add(rbtnStatusMaint);
            gbxMachStatus.Controls.Add(rbtnStatusOutOrder);
            gbxMachStatus.Controls.Add(rbtnStatusAvail);
            gbxMachStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxMachStatus.ForeColor = SystemColors.ControlLightLight;
            gbxMachStatus.Location = new Point(6, 94);
            gbxMachStatus.Name = "gbxMachStatus";
            gbxMachStatus.Size = new Size(380, 61);
            gbxMachStatus.TabIndex = 4;
            gbxMachStatus.TabStop = false;
            gbxMachStatus.Text = "Status";
            // 
            // rbtnStatusMaint
            // 
            rbtnStatusMaint.AutoSize = true;
            rbtnStatusMaint.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtnStatusMaint.ForeColor = Color.Orange;
            rbtnStatusMaint.Location = new Point(241, 28);
            rbtnStatusMaint.Name = "rbtnStatusMaint";
            rbtnStatusMaint.Size = new Size(133, 25);
            rbtnStatusMaint.TabIndex = 2;
            rbtnStatusMaint.TabStop = true;
            rbtnStatusMaint.Text = "Maintainence";
            rbtnStatusMaint.UseVisualStyleBackColor = true;
            rbtnStatusMaint.Click += rbtnStatusMaintainence_CheckedChanged;
            // 
            // rbtnStatusOutOrder
            // 
            rbtnStatusOutOrder.AutoSize = true;
            rbtnStatusOutOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtnStatusOutOrder.ForeColor = Color.Red;
            rbtnStatusOutOrder.Location = new Point(112, 28);
            rbtnStatusOutOrder.Name = "rbtnStatusOutOrder";
            rbtnStatusOutOrder.Size = new Size(123, 25);
            rbtnStatusOutOrder.TabIndex = 1;
            rbtnStatusOutOrder.TabStop = true;
            rbtnStatusOutOrder.Text = "Out of Order";
            rbtnStatusOutOrder.UseVisualStyleBackColor = true;
            rbtnStatusOutOrder.Click += rbtnStatusOutOfOrder_CheckedChanged;
            // 
            // rbtnStatusAvail
            // 
            rbtnStatusAvail.AutoSize = true;
            rbtnStatusAvail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtnStatusAvail.ForeColor = Color.GreenYellow;
            rbtnStatusAvail.Location = new Point(6, 28);
            rbtnStatusAvail.Name = "rbtnStatusAvail";
            rbtnStatusAvail.Size = new Size(100, 25);
            rbtnStatusAvail.TabIndex = 0;
            rbtnStatusAvail.TabStop = true;
            rbtnStatusAvail.Text = "Available";
            rbtnStatusAvail.UseVisualStyleBackColor = true;
            rbtnStatusAvail.Click += rbtnStatusAvailable_CheckedChanged;
            // 
            // lblMachGenre
            // 
            lblMachGenre.AutoSize = true;
            lblMachGenre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMachGenre.Location = new Point(6, 70);
            lblMachGenre.Name = "lblMachGenre";
            lblMachGenre.Size = new Size(99, 21);
            lblMachGenre.TabIndex = 3;
            lblMachGenre.Text = "Genre: Other";
            // 
            // txtbxMachName
            // 
            txtbxMachName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxMachName.Location = new Point(67, 32);
            txtbxMachName.Name = "txtbxMachName";
            txtbxMachName.Size = new Size(319, 29);
            txtbxMachName.TabIndex = 1;
            txtbxMachName.KeyDown += txtbxMachineName_KeyDown;
            // 
            // lblMachName
            // 
            lblMachName.AutoSize = true;
            lblMachName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMachName.Location = new Point(6, 35);
            lblMachName.Name = "lblMachName";
            lblMachName.Size = new Size(55, 21);
            lblMachName.TabIndex = 0;
            lblMachName.Text = "Name:";
            // 
            // tabPlayCards
            // 
            tabPlayCards.BackColor = Color.Maroon;
            tabPlayCards.Controls.Add(gbxPlayCards);
            tabPlayCards.Controls.Add(gbxNewPlayCard);
            tabPlayCards.Controls.Add(gbxCustInfo);
            tabPlayCards.Location = new Point(4, 30);
            tabPlayCards.Name = "tabPlayCards";
            tabPlayCards.Padding = new Padding(3);
            tabPlayCards.Size = new Size(768, 452);
            tabPlayCards.TabIndex = 1;
            tabPlayCards.Text = "Play Cards";
            // 
            // gbxPlayCards
            // 
            gbxPlayCards.Controls.Add(cmbxSortCards);
            gbxPlayCards.Controls.Add(lblSortCards);
            gbxPlayCards.Controls.Add(lbxPlayCards);
            gbxPlayCards.Controls.Add(btnAddCard);
            gbxPlayCards.Controls.Add(btnRemoveCard);
            gbxPlayCards.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxPlayCards.ForeColor = SystemColors.ControlLightLight;
            gbxPlayCards.Location = new Point(404, 6);
            gbxPlayCards.Name = "gbxPlayCards";
            gbxPlayCards.Size = new Size(358, 440);
            gbxPlayCards.TabIndex = 5;
            gbxPlayCards.TabStop = false;
            gbxPlayCards.Text = "Play Cards";
            // 
            // cmbxSortCards
            // 
            cmbxSortCards.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbxSortCards.FormattingEnabled = true;
            cmbxSortCards.Items.AddRange(new object[] { "ID", "Balance (Low to High)", "Balance (High to Low)" });
            cmbxSortCards.Location = new Point(172, 32);
            cmbxSortCards.Name = "cmbxSortCards";
            cmbxSortCards.Size = new Size(180, 29);
            cmbxSortCards.TabIndex = 16;
            cmbxSortCards.Text = "ID";
            cmbxSortCards.SelectedIndexChanged += cmbxSortPlayCards_SelectedIndexChanged;
            // 
            // lblSortCards
            // 
            lblSortCards.AutoSize = true;
            lblSortCards.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSortCards.Location = new Point(103, 35);
            lblSortCards.Name = "lblSortCards";
            lblSortCards.Size = new Size(63, 21);
            lblSortCards.TabIndex = 15;
            lblSortCards.Text = "Sort by:";
            // 
            // lbxPlayCards
            // 
            lbxPlayCards.FormattingEnabled = true;
            lbxPlayCards.Location = new Point(6, 67);
            lbxPlayCards.Name = "lbxPlayCards";
            lbxPlayCards.Size = new Size(346, 329);
            lbxPlayCards.TabIndex = 14;
            lbxPlayCards.SelectedIndexChanged += lbxPlayCards_SelectedIndexChanged;
            // 
            // btnAddCard
            // 
            btnAddCard.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddCard.ForeColor = SystemColors.ControlText;
            btnAddCard.Location = new Point(58, 407);
            btnAddCard.Name = "btnAddCard";
            btnAddCard.Size = new Size(144, 28);
            btnAddCard.TabIndex = 13;
            btnAddCard.Text = "Add Card";
            btnAddCard.UseVisualStyleBackColor = true;
            btnAddCard.Click += btnAddCard_Click;
            // 
            // btnRemoveCard
            // 
            btnRemoveCard.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoveCard.ForeColor = SystemColors.ControlText;
            btnRemoveCard.Location = new Point(208, 406);
            btnRemoveCard.Name = "btnRemoveCard";
            btnRemoveCard.Size = new Size(144, 28);
            btnRemoveCard.TabIndex = 12;
            btnRemoveCard.Text = "Remove Card";
            btnRemoveCard.UseVisualStyleBackColor = true;
            btnRemoveCard.Click += btnRemoveCard_Click;
            // 
            // gbxNewPlayCard
            // 
            gbxNewPlayCard.BackColor = Color.IndianRed;
            gbxNewPlayCard.Controls.Add(txtbxNewCardBalance);
            gbxNewPlayCard.Controls.Add(lblNewCardBalance);
            gbxNewPlayCard.Controls.Add(gbxNewCardStatus);
            gbxNewPlayCard.Controls.Add(txtbxNewCardCustName);
            gbxNewPlayCard.Controls.Add(lblNewCardCustName);
            gbxNewPlayCard.Controls.Add(btnNewCardCancel);
            gbxNewPlayCard.Controls.Add(btnNewCardAdd);
            gbxNewPlayCard.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxNewPlayCard.ForeColor = SystemColors.ControlLightLight;
            gbxNewPlayCard.Location = new Point(6, 243);
            gbxNewPlayCard.Name = "gbxNewPlayCard";
            gbxNewPlayCard.Size = new Size(392, 203);
            gbxNewPlayCard.TabIndex = 4;
            gbxNewPlayCard.TabStop = false;
            gbxNewPlayCard.Text = "New Play Card";
            // 
            // txtbxNewCardBalance
            // 
            txtbxNewCardBalance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxNewCardBalance.Location = new Point(134, 128);
            txtbxNewCardBalance.Name = "txtbxNewCardBalance";
            txtbxNewCardBalance.Size = new Size(252, 29);
            txtbxNewCardBalance.TabIndex = 16;
            // 
            // lblNewCardBalance
            // 
            lblNewCardBalance.AutoSize = true;
            lblNewCardBalance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewCardBalance.Location = new Point(6, 131);
            lblNewCardBalance.Name = "lblNewCardBalance";
            lblNewCardBalance.Size = new Size(133, 21);
            lblNewCardBalance.TabIndex = 15;
            lblNewCardBalance.Text = "Money on Card: $";
            // 
            // gbxNewCardStatus
            // 
            gbxNewCardStatus.Controls.Add(rbtnNewCardStatusVIP);
            gbxNewCardStatus.Controls.Add(rbtnNewCardStatusStd);
            gbxNewCardStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxNewCardStatus.ForeColor = SystemColors.ControlLightLight;
            gbxNewCardStatus.Location = new Point(6, 61);
            gbxNewCardStatus.Name = "gbxNewCardStatus";
            gbxNewCardStatus.Size = new Size(380, 61);
            gbxNewCardStatus.TabIndex = 14;
            gbxNewCardStatus.TabStop = false;
            gbxNewCardStatus.Text = "Status";
            // 
            // rbtnNewCardStatusVIP
            // 
            rbtnNewCardStatusVIP.AutoSize = true;
            rbtnNewCardStatusVIP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtnNewCardStatusVIP.ForeColor = Color.SkyBlue;
            rbtnNewCardStatusVIP.Location = new Point(112, 28);
            rbtnNewCardStatusVIP.Name = "rbtnNewCardStatusVIP";
            rbtnNewCardStatusVIP.Size = new Size(54, 25);
            rbtnNewCardStatusVIP.TabIndex = 1;
            rbtnNewCardStatusVIP.TabStop = true;
            rbtnNewCardStatusVIP.Text = "VIP";
            rbtnNewCardStatusVIP.UseVisualStyleBackColor = true;
            // 
            // rbtnNewCardStatusStd
            // 
            rbtnNewCardStatusStd.AutoSize = true;
            rbtnNewCardStatusStd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtnNewCardStatusStd.ForeColor = SystemColors.ControlLightLight;
            rbtnNewCardStatusStd.Location = new Point(6, 28);
            rbtnNewCardStatusStd.Name = "rbtnNewCardStatusStd";
            rbtnNewCardStatusStd.Size = new Size(97, 25);
            rbtnNewCardStatusStd.TabIndex = 0;
            rbtnNewCardStatusStd.TabStop = true;
            rbtnNewCardStatusStd.Text = "Standard";
            rbtnNewCardStatusStd.UseVisualStyleBackColor = true;
            // 
            // txtbxNewCardCustName
            // 
            txtbxNewCardCustName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxNewCardCustName.Location = new Point(139, 26);
            txtbxNewCardCustName.Name = "txtbxNewCardCustName";
            txtbxNewCardCustName.Size = new Size(247, 29);
            txtbxNewCardCustName.TabIndex = 13;
            // 
            // lblNewCardCustName
            // 
            lblNewCardCustName.AutoSize = true;
            lblNewCardCustName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewCardCustName.Location = new Point(6, 29);
            lblNewCardCustName.Name = "lblNewCardCustName";
            lblNewCardCustName.Size = new Size(127, 21);
            lblNewCardCustName.TabIndex = 12;
            lblNewCardCustName.Text = "Customer Name:";
            // 
            // btnNewCardCancel
            // 
            btnNewCardCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewCardCancel.ForeColor = SystemColors.ControlText;
            btnNewCardCancel.Location = new Point(311, 169);
            btnNewCardCancel.Name = "btnNewCardCancel";
            btnNewCardCancel.Size = new Size(75, 28);
            btnNewCardCancel.TabIndex = 11;
            btnNewCardCancel.Text = "Cancel";
            btnNewCardCancel.UseVisualStyleBackColor = true;
            btnNewCardCancel.Click += btnNewCardCancel_Click;
            // 
            // btnNewCardAdd
            // 
            btnNewCardAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewCardAdd.ForeColor = SystemColors.ControlText;
            btnNewCardAdd.Location = new Point(230, 170);
            btnNewCardAdd.Name = "btnNewCardAdd";
            btnNewCardAdd.Size = new Size(75, 28);
            btnNewCardAdd.TabIndex = 10;
            btnNewCardAdd.Text = "Add";
            btnNewCardAdd.UseVisualStyleBackColor = true;
            btnNewCardAdd.Click += btnNewCardAdd_Click;
            // 
            // gbxCustInfo
            // 
            gbxCustInfo.Controls.Add(btnTopUp5);
            gbxCustInfo.Controls.Add(btnTopUp1);
            gbxCustInfo.Controls.Add(btnTopUp10);
            gbxCustInfo.Controls.Add(lblCustID);
            gbxCustInfo.Controls.Add(txtbxCustBalance);
            gbxCustInfo.Controls.Add(lblCustBalance);
            gbxCustInfo.Controls.Add(groupBox5);
            gbxCustInfo.Controls.Add(txtbxCustName);
            gbxCustInfo.Controls.Add(lblCustName);
            gbxCustInfo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxCustInfo.ForeColor = SystemColors.ControlLightLight;
            gbxCustInfo.Location = new Point(6, 6);
            gbxCustInfo.Name = "gbxCustInfo";
            gbxCustInfo.Size = new Size(392, 203);
            gbxCustInfo.TabIndex = 3;
            gbxCustInfo.TabStop = false;
            gbxCustInfo.Text = "Customer Information";
            // 
            // btnTopUp5
            // 
            btnTopUp5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTopUp5.ForeColor = SystemColors.ControlText;
            btnTopUp5.Location = new Point(134, 169);
            btnTopUp5.Name = "btnTopUp5";
            btnTopUp5.Size = new Size(122, 28);
            btnTopUp5.TabIndex = 13;
            btnTopUp5.Text = "Top Up $5";
            btnTopUp5.UseVisualStyleBackColor = true;
            // 
            // btnTopUp1
            // 
            btnTopUp1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTopUp1.ForeColor = SystemColors.ControlText;
            btnTopUp1.Location = new Point(6, 169);
            btnTopUp1.Name = "btnTopUp1";
            btnTopUp1.Size = new Size(122, 28);
            btnTopUp1.TabIndex = 12;
            btnTopUp1.Text = "Top Up $1";
            btnTopUp1.UseVisualStyleBackColor = true;
            // 
            // btnTopUp10
            // 
            btnTopUp10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTopUp10.ForeColor = SystemColors.ControlText;
            btnTopUp10.Location = new Point(262, 169);
            btnTopUp10.Name = "btnTopUp10";
            btnTopUp10.Size = new Size(122, 28);
            btnTopUp10.TabIndex = 11;
            btnTopUp10.Text = "Top Up $10";
            btnTopUp10.UseVisualStyleBackColor = true;
            // 
            // lblCustID
            // 
            lblCustID.AutoSize = true;
            lblCustID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustID.Location = new Point(6, 35);
            lblCustID.Name = "lblCustID";
            lblCustID.Size = new Size(95, 21);
            lblCustID.TabIndex = 10;
            lblCustID.Text = "ID: 0000000";
            // 
            // txtbxCustBalance
            // 
            txtbxCustBalance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxCustBalance.Location = new Point(134, 134);
            txtbxCustBalance.Name = "txtbxCustBalance";
            txtbxCustBalance.Size = new Size(252, 29);
            txtbxCustBalance.TabIndex = 6;
            // 
            // lblCustBalance
            // 
            lblCustBalance.AutoSize = true;
            lblCustBalance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustBalance.Location = new Point(6, 137);
            lblCustBalance.Name = "lblCustBalance";
            lblCustBalance.Size = new Size(133, 21);
            lblCustBalance.TabIndex = 5;
            lblCustBalance.Text = "Money on Card: $";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(rbtnCustStatusVIP);
            groupBox5.Controls.Add(rbtnCustStatusStd);
            groupBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = SystemColors.ControlLightLight;
            groupBox5.Location = new Point(6, 67);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(380, 61);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Status";
            // 
            // rbtnCustStatusVIP
            // 
            rbtnCustStatusVIP.AutoSize = true;
            rbtnCustStatusVIP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtnCustStatusVIP.ForeColor = Color.SkyBlue;
            rbtnCustStatusVIP.Location = new Point(112, 28);
            rbtnCustStatusVIP.Name = "rbtnCustStatusVIP";
            rbtnCustStatusVIP.Size = new Size(54, 25);
            rbtnCustStatusVIP.TabIndex = 1;
            rbtnCustStatusVIP.TabStop = true;
            rbtnCustStatusVIP.Text = "VIP";
            rbtnCustStatusVIP.UseVisualStyleBackColor = true;
            // 
            // rbtnCustStatusStd
            // 
            rbtnCustStatusStd.AutoSize = true;
            rbtnCustStatusStd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtnCustStatusStd.ForeColor = SystemColors.ControlLightLight;
            rbtnCustStatusStd.Location = new Point(6, 28);
            rbtnCustStatusStd.Name = "rbtnCustStatusStd";
            rbtnCustStatusStd.Size = new Size(97, 25);
            rbtnCustStatusStd.TabIndex = 0;
            rbtnCustStatusStd.TabStop = true;
            rbtnCustStatusStd.Text = "Standard";
            rbtnCustStatusStd.UseVisualStyleBackColor = true;
            // 
            // txtbxCustName
            // 
            txtbxCustName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxCustName.Location = new Point(168, 32);
            txtbxCustName.Name = "txtbxCustName";
            txtbxCustName.Size = new Size(218, 29);
            txtbxCustName.TabIndex = 1;
            txtbxCustName.KeyDown += txtbxCustName_KeyDown;
            // 
            // lblCustName
            // 
            lblCustName.AutoSize = true;
            lblCustName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustName.Location = new Point(107, 35);
            lblCustName.Name = "lblCustName";
            lblCustName.Size = new Size(55, 21);
            lblCustName.TabIndex = 0;
            lblCustName.Text = "Name:";
            // 
            // tabSimPlay
            // 
            tabSimPlay.BackColor = SystemColors.WindowFrame;
            tabSimPlay.Controls.Add(btnSwipeCard);
            tabSimPlay.Controls.Add(gbxSimPlayCard);
            tabSimPlay.Controls.Add(gbxSimPlayMachine);
            tabSimPlay.Location = new Point(4, 30);
            tabSimPlay.Name = "tabSimPlay";
            tabSimPlay.Size = new Size(768, 452);
            tabSimPlay.TabIndex = 2;
            tabSimPlay.Text = "Simulate Play";
            tabSimPlay.Enter += tabSimPlay_Enter;
            // 
            // btnSwipeCard
            // 
            btnSwipeCard.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSwipeCard.Location = new Point(309, 254);
            btnSwipeCard.Name = "btnSwipeCard";
            btnSwipeCard.Size = new Size(150, 50);
            btnSwipeCard.TabIndex = 2;
            btnSwipeCard.Text = "Swipe Card";
            btnSwipeCard.UseVisualStyleBackColor = true;
            btnSwipeCard.Click += btnSimPlay_Click;
            // 
            // gbxSimPlayCard
            // 
            gbxSimPlayCard.BackColor = Color.Maroon;
            gbxSimPlayCard.Controls.Add(lblSimPlayCustStatus);
            gbxSimPlayCard.Controls.Add(lblSimPlayMoneyOnCard);
            gbxSimPlayCard.Controls.Add(cmbxSimPlayCards);
            gbxSimPlayCard.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxSimPlayCard.ForeColor = SystemColors.ControlLightLight;
            gbxSimPlayCard.Location = new Point(388, 136);
            gbxSimPlayCard.Name = "gbxSimPlayCard";
            gbxSimPlayCard.Size = new Size(377, 112);
            gbxSimPlayCard.TabIndex = 1;
            gbxSimPlayCard.TabStop = false;
            gbxSimPlayCard.Text = "Play Card";
            // 
            // lblSimPlayCustStatus
            // 
            lblSimPlayCustStatus.AutoSize = true;
            lblSimPlayCustStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSimPlayCustStatus.Location = new Point(308, 78);
            lblSimPlayCustStatus.Name = "lblSimPlayCustStatus";
            lblSimPlayCustStatus.Size = new Size(63, 21);
            lblSimPlayCustStatus.TabIndex = 4;
            lblSimPlayCustStatus.Text = "VIP: Yes";
            // 
            // lblSimPlayMoneyOnCard
            // 
            lblSimPlayMoneyOnCard.AutoSize = true;
            lblSimPlayMoneyOnCard.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSimPlayMoneyOnCard.Location = new Point(6, 78);
            lblSimPlayMoneyOnCard.Name = "lblSimPlayMoneyOnCard";
            lblSimPlayMoneyOnCard.Size = new Size(163, 21);
            lblSimPlayMoneyOnCard.TabIndex = 3;
            lblSimPlayMoneyOnCard.Text = "Money on Card: $0.00";
            // 
            // cmbxSimPlayCards
            // 
            cmbxSimPlayCards.FormattingEnabled = true;
            cmbxSimPlayCards.Location = new Point(6, 32);
            cmbxSimPlayCards.Name = "cmbxSimPlayCards";
            cmbxSimPlayCards.Size = new Size(365, 33);
            cmbxSimPlayCards.TabIndex = 1;
            // 
            // gbxSimPlayMachine
            // 
            gbxSimPlayMachine.BackColor = Color.MidnightBlue;
            gbxSimPlayMachine.Controls.Add(lblSimPlayPlayCost2);
            gbxSimPlayMachine.Controls.Add(lblSimPlayPlayCostVIP);
            gbxSimPlayMachine.Controls.Add(lblSimPlayPlayCost);
            gbxSimPlayMachine.Controls.Add(cmbxSimPlayMachines);
            gbxSimPlayMachine.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxSimPlayMachine.ForeColor = SystemColors.ControlLightLight;
            gbxSimPlayMachine.Location = new Point(3, 136);
            gbxSimPlayMachine.Name = "gbxSimPlayMachine";
            gbxSimPlayMachine.Size = new Size(377, 112);
            gbxSimPlayMachine.TabIndex = 0;
            gbxSimPlayMachine.TabStop = false;
            gbxSimPlayMachine.Text = "Machine";
            // 
            // lblSimPlayPlayCost2
            // 
            lblSimPlayPlayCost2.AutoSize = true;
            lblSimPlayPlayCost2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSimPlayPlayCost2.Location = new Point(80, 78);
            lblSimPlayPlayCost2.Name = "lblSimPlayPlayCost2";
            lblSimPlayPlayCost2.Size = new Size(49, 21);
            lblSimPlayPlayCost2.TabIndex = 3;
            lblSimPlayPlayCost2.Text = "$0.00";
            // 
            // lblSimPlayPlayCostVIP
            // 
            lblSimPlayPlayCostVIP.AutoSize = true;
            lblSimPlayPlayCostVIP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSimPlayPlayCostVIP.Location = new Point(177, 78);
            lblSimPlayPlayCostVIP.Name = "lblSimPlayPlayCostVIP";
            lblSimPlayPlayCostVIP.Size = new Size(176, 21);
            lblSimPlayPlayCostVIP.TabIndex = 2;
            lblSimPlayPlayCostVIP.Text = "with VIP discount: $0.00";
            // 
            // lblSimPlayPlayCost
            // 
            lblSimPlayPlayCost.AutoSize = true;
            lblSimPlayPlayCost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSimPlayPlayCost.Location = new Point(6, 78);
            lblSimPlayPlayCost.Name = "lblSimPlayPlayCost";
            lblSimPlayPlayCost.Size = new Size(77, 21);
            lblSimPlayPlayCost.TabIndex = 1;
            lblSimPlayPlayCost.Text = "Play Cost:";
            // 
            // cmbxSimPlayMachines
            // 
            cmbxSimPlayMachines.FormattingEnabled = true;
            cmbxSimPlayMachines.Location = new Point(6, 32);
            cmbxSimPlayMachines.Name = "cmbxSimPlayMachines";
            cmbxSimPlayMachines.Size = new Size(365, 33);
            cmbxSimPlayMachines.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 525);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Arcade Manager";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabMachines.ResumeLayout(false);
            gbxArcadeFloor.ResumeLayout(false);
            gbxNewMach.ResumeLayout(false);
            gbxNewMach.PerformLayout();
            gbxNewMachStatus.ResumeLayout(false);
            gbxNewMachStatus.PerformLayout();
            gbxMachInfo.ResumeLayout(false);
            gbxMachInfo.PerformLayout();
            gbxMachStatus.ResumeLayout(false);
            gbxMachStatus.PerformLayout();
            tabPlayCards.ResumeLayout(false);
            gbxPlayCards.ResumeLayout(false);
            gbxPlayCards.PerformLayout();
            gbxNewPlayCard.ResumeLayout(false);
            gbxNewPlayCard.PerformLayout();
            gbxNewCardStatus.ResumeLayout(false);
            gbxNewCardStatus.PerformLayout();
            gbxCustInfo.ResumeLayout(false);
            gbxCustInfo.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            tabSimPlay.ResumeLayout(false);
            gbxSimPlayCard.ResumeLayout(false);
            gbxSimPlayCard.PerformLayout();
            gbxSimPlayMachine.ResumeLayout(false);
            gbxSimPlayMachine.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadMachinesToolStripMenuItem;
        private ToolStripMenuItem loadCustomersToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem saveMachinesToolStripMenuItem;
        private ToolStripMenuItem saveCustomersToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabMachines;
        private TabPage tabPlayCards;
        private GroupBox gbxMachInfo;
        private Label lblMachGenre;
        private TextBox txtbxMachName;
        private Label lblMachName;
        private TabPage tabSimPlay;
        private GroupBox gbxMachStatus;
        private RadioButton rbtnStatusMaint;
        private RadioButton rbtnStatusOutOrder;
        private RadioButton rbtnStatusAvail;
        private Label lblMachDiscount;
        private TextBox txtbxMachDiscount;
        private Label label1;
        private TextBox txtbxMachPlayCost;
        private Label lblMachPlayCost;
        private GroupBox gbxNewMach;
        private Button btnNewMachCancel;
        private Button btnNewMachAdd;
        private Label lblNewMachDiscount;
        private TextBox txtbxNewMachDiscount;
        private Label label4;
        private TextBox txtbxNewMachPlayCost;
        private Label lblNewMachPlayCost;
        private GroupBox gbxNewMachStatus;
        private RadioButton rbtnNewMachStatusMaint;
        private RadioButton rbtnNewMachStatusOutOrder;
        private RadioButton rbtnNewMachStatusAvail;
        private Label lblNewMachGenre;
        private TextBox txtbxNewMachName;
        private Label lblNewMachName;
        private ComboBox cmbxNewMachGenre;
        private GroupBox gbxArcadeFloor;
        private ListBox lbxFloorMachines;
        private Button btnAddMach;
        private Button btnRemoveMach;
        private GroupBox gbxPlayCards;
        private ListBox lbxPlayCards;
        private Button btnAddCard;
        private Button btnRemoveCard;
        private GroupBox gbxNewPlayCard;
        private Button btnNewCardCancel;
        private Button btnNewCardAdd;
        private GroupBox gbxCustInfo;
        private TextBox txtbxCustBalance;
        private Label lblCustBalance;
        private GroupBox groupBox5;
        private RadioButton rbtnCustStatusVIP;
        private RadioButton rbtnCustStatusStd;
        private TextBox txtbxCustName;
        private Label lblCustName;
        private Button btnTopUp10;
        private Label lblCustID;
        private Button btnTopUp5;
        private Button btnTopUp1;
        private TextBox txtbxNewCardBalance;
        private Label lblNewCardBalance;
        private GroupBox gbxNewCardStatus;
        private RadioButton rbtnNewCardStatusVIP;
        private RadioButton rbtnNewCardStatusStd;
        private TextBox txtbxNewCardCustName;
        private Label lblNewCardCustName;
        private Label lblSortCards;
        private ComboBox cmbxSortCards;
        private GroupBox gbxSimPlayCard;
        private GroupBox gbxSimPlayMachine;
        private ComboBox cmbxSimPlayCards;
        private Label lblSimPlayPlayCostVIP;
        private Label lblSimPlayPlayCost;
        private ComboBox cmbxSimPlayMachines;
        private Label lblSimPlayCustStatus;
        private Label lblSimPlayMoneyOnCard;
        private Button btnSwipeCard;
        private Label lblSimPlayPlayCost2;
    }
}
