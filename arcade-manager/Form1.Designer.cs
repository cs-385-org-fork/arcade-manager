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
            saveCustomersToolStripMenuItem = new ToolStripMenuItem();
            saveMachinesToolStripMenuItem = new ToolStripMenuItem();
            loadCustomersToolStripMenuItem = new ToolStripMenuItem();
            loadMachinesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            gbxArcadeFloor = new GroupBox();
            btnMachine4 = new Button();
            btnMachine3 = new Button();
            btnMachine6 = new Button();
            btnMachine5 = new Button();
            btnMachine2 = new Button();
            btnMachine1 = new Button();
            gbxMachineInfo = new GroupBox();
            lblAmntEarned = new Label();
            btnSimPlay = new Button();
            txtbxPlayCost = new TextBox();
            lblPlayCost = new Label();
            gbxStatus = new GroupBox();
            rbtnStatusMaintainence = new RadioButton();
            rbtnStatusOutOfOrder = new RadioButton();
            rbtnStatusAvailable = new RadioButton();
            machineName = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            menuStrip1.SuspendLayout();
            gbxArcadeFloor.SuspendLayout();
            gbxMachineInfo.SuspendLayout();
            gbxStatus.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
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
            saveCustomersToolStripMenuItem.Size = new Size(180, 22);
            saveCustomersToolStripMenuItem.Text = "Save Customers";
            saveCustomersToolStripMenuItem.Click += saveCustomersToolStripMenuItem_Click;
            // 
            // saveMachinesToolStripMenuItem
            // 
            saveMachinesToolStripMenuItem.Name = "saveMachinesToolStripMenuItem";
            saveMachinesToolStripMenuItem.Size = new Size(180, 22);
            saveMachinesToolStripMenuItem.Text = "Save Machines";
            saveMachinesToolStripMenuItem.Click += saveMachinesToolStripMenuItem_Click;
            // 
            // loadCustomersToolStripMenuItem
            // 
            loadCustomersToolStripMenuItem.Name = "loadCustomersToolStripMenuItem";
            loadCustomersToolStripMenuItem.Size = new Size(180, 22);
            loadCustomersToolStripMenuItem.Text = "Load Customers";
            // 
            // loadMachinesToolStripMenuItem
            // 
            loadMachinesToolStripMenuItem.Name = "loadMachinesToolStripMenuItem";
            loadMachinesToolStripMenuItem.Size = new Size(180, 22);
            loadMachinesToolStripMenuItem.Text = "Load Machines";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
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
            btnMachine4.ForeColor = Color.Black;
            btnMachine4.Location = new Point(254, 191);
            btnMachine4.Name = "btnMachine4";
            btnMachine4.Size = new Size(242, 144);
            btnMachine4.TabIndex = 5;
            btnMachine4.Text = "Machine4";
            btnMachine4.UseVisualStyleBackColor = true;
            // 
            // btnMachine3
            // 
            btnMachine3.ForeColor = Color.Black;
            btnMachine3.Location = new Point(254, 34);
            btnMachine3.Name = "btnMachine3";
            btnMachine3.Size = new Size(242, 144);
            btnMachine3.TabIndex = 4;
            btnMachine3.Text = "Machine3";
            btnMachine3.UseVisualStyleBackColor = true;
            // 
            // btnMachine6
            // 
            btnMachine6.ForeColor = Color.Black;
            btnMachine6.Location = new Point(502, 191);
            btnMachine6.Name = "btnMachine6";
            btnMachine6.Size = new Size(242, 144);
            btnMachine6.TabIndex = 3;
            btnMachine6.Text = "Machine6";
            btnMachine6.UseVisualStyleBackColor = true;
            // 
            // btnMachine5
            // 
            btnMachine5.ForeColor = Color.Black;
            btnMachine5.Location = new Point(502, 34);
            btnMachine5.Name = "btnMachine5";
            btnMachine5.Size = new Size(242, 144);
            btnMachine5.TabIndex = 2;
            btnMachine5.Text = "Machine5";
            btnMachine5.UseVisualStyleBackColor = true;
            // 
            // btnMachine2
            // 
            btnMachine2.ForeColor = Color.Black;
            btnMachine2.Location = new Point(6, 191);
            btnMachine2.Name = "btnMachine2";
            btnMachine2.Size = new Size(242, 144);
            btnMachine2.TabIndex = 1;
            btnMachine2.Text = "Machine2";
            btnMachine2.UseVisualStyleBackColor = true;
            // 
            // btnMachine1
            // 
            btnMachine1.ForeColor = Color.Black;
            btnMachine1.Location = new Point(6, 34);
            btnMachine1.Name = "btnMachine1";
            btnMachine1.Size = new Size(242, 144);
            btnMachine1.TabIndex = 0;
            btnMachine1.Text = "Machine1";
            btnMachine1.UseVisualStyleBackColor = true;
            // 
            // gbxMachineInfo
            // 
            gbxMachineInfo.Controls.Add(lblAmntEarned);
            gbxMachineInfo.Controls.Add(btnSimPlay);
            gbxMachineInfo.Controls.Add(txtbxPlayCost);
            gbxMachineInfo.Controls.Add(lblPlayCost);
            gbxMachineInfo.Controls.Add(gbxStatus);
            gbxMachineInfo.Controls.Add(machineName);
            gbxMachineInfo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxMachineInfo.ForeColor = Color.White;
            gbxMachineInfo.Location = new Point(6, 353);
            gbxMachineInfo.Name = "gbxMachineInfo";
            gbxMachineInfo.Size = new Size(750, 159);
            gbxMachineInfo.TabIndex = 2;
            gbxMachineInfo.TabStop = false;
            gbxMachineInfo.Text = "Machine Information";
            // 
            // lblAmntEarned
            // 
            lblAmntEarned.AutoSize = true;
            lblAmntEarned.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAmntEarned.Location = new Point(209, 40);
            lblAmntEarned.Name = "lblAmntEarned";
            lblAmntEarned.Size = new Size(162, 25);
            lblAmntEarned.TabIndex = 5;
            lblAmntEarned.Text = "Amount Earned: $";
            // 
            // btnSimPlay
            // 
            btnSimPlay.ForeColor = Color.Black;
            btnSimPlay.Location = new Point(460, 77);
            btnSimPlay.Name = "btnSimPlay";
            btnSimPlay.Size = new Size(132, 78);
            btnSimPlay.TabIndex = 4;
            btnSimPlay.Text = "Simulate Play";
            btnSimPlay.UseVisualStyleBackColor = true;
            // 
            // txtbxPlayCost
            // 
            txtbxPlayCost.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxPlayCost.Location = new Point(539, 37);
            txtbxPlayCost.Name = "txtbxPlayCost";
            txtbxPlayCost.Size = new Size(205, 33);
            txtbxPlayCost.TabIndex = 3;
            // 
            // lblPlayCost
            // 
            lblPlayCost.AutoSize = true;
            lblPlayCost.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlayCost.Location = new Point(409, 37);
            lblPlayCost.Name = "lblPlayCost";
            lblPlayCost.Size = new Size(108, 25);
            lblPlayCost.TabIndex = 2;
            lblPlayCost.Text = "Play Cost: $";
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
            // 
            // machineName
            // 
            machineName.AutoSize = true;
            machineName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            machineName.Location = new Point(6, 40);
            machineName.Name = "machineName";
            machineName.Size = new Size(134, 25);
            machineName.TabIndex = 0;
            machineName.Text = "machineName";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(771, 553);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.MidnightBlue;
            tabPage1.Controls.Add(gbxArcadeFloor);
            tabPage1.Controls.Add(gbxMachineInfo);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(763, 525);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(803, 255);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
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
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private GroupBox gbxArcadeFloor;
        private GroupBox gbxMachineInfo;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
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
        private Label machineName;
        private Button btnSimPlay;
        private TextBox txtbxPlayCost;
        private Label lblPlayCost;
        private Label lblAmntEarned;
        private ToolStripMenuItem saveCustomersToolStripMenuItem;
        private ToolStripMenuItem saveMachinesToolStripMenuItem;
        private ToolStripMenuItem loadCustomersToolStripMenuItem;
        private ToolStripMenuItem loadMachinesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}
