using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;


namespace arcade_manager
{
    internal class FileIO
    {

        public FileIO() { }

        public void readCustomers(ref List<PlayCard> customers)
        {

            string filePath = "";
            OpenFileDialog fileDiag = new OpenFileDialog();
            DialogResult diagResult = fileDiag.ShowDialog();

            if (diagResult == DialogResult.OK)
            {
                filePath = fileDiag.FileName;
            }
            else
            {
                return;
            }

            StreamReader sr = new StreamReader(filePath);
            string currentLine = sr.ReadLine();
            //First line is amount of customers with active cards
            if (int.TryParse(currentLine, out int activeCards)) { }
            else
            {
                return;
            }

            customers = new List<PlayCard> { }; //Create a list of active cards

            //Read the remaining lines and assign them to new playcard
            int item = 1;
            int card = 0;
            while (currentLine != null)
            {

                //Read the next line
                currentLine = sr.ReadLine();
                //ID Number
                if (item == 1)
                {
                    if (int.TryParse(currentLine, out int parsedLine)) { customers.Add(new PlayCard()); customers[card].CardID = parsedLine; }
                }
                //Money On Card
                if (item == 2)
                {
                    if (decimal.TryParse(currentLine, out decimal parsedLine)) { customers[card].MoneyOnCard = parsedLine; }
                }
                //customerName
                if (item == 3)
                {
                    customers[card].CustomerName = currentLine;
                }
                //VIP
                if (item == 4)
                {
                    if (currentLine == "true")
                    {
                        customers[card].VIP = true;
                    }
                    else if (currentLine == "false")
                    {
                        customers[card].VIP = false;
                    }
                }
                //isActive
                if (item == 5)
                {
                    if (currentLine == "true")
                    {
                        customers[card].IsActive = true;
                    }
                    else if (currentLine == "false")
                    {
                        customers[card].IsActive = false;
                    }

                    card++; // move on to next card
                    item = 0; // reset item count
                }

                item++; // move on to next item
            }
            //close the file
            sr.Close();
        }

        public void readMachines(ref List<Machine> floorMachines)
        {

            string filePath = "";

            OpenFileDialog fileDiag = new OpenFileDialog();
            DialogResult diagResult = fileDiag.ShowDialog();

            if (diagResult == DialogResult.OK)
            {
                filePath = fileDiag.FileName;
            }
            else
            {
                return;
            }

            StreamReader sr = new StreamReader(filePath);

            floorMachines = new List<Machine> { }; //Create a list of arcade machines

            for (int machine = 0; machine < 6; machine++)
            {
                floorMachines.Add(new Machine()); // create new machine
                int item = 1;
                string currentLine = " ";
                while (currentLine != null)
                {
                    //Read the next line
                    currentLine = sr.ReadLine();

                    //MachineName
                    if (item == 1)
                    {
                        floorMachines[machine].MachineName = currentLine;
                    }
                    //(Base) Machine Price
                    if (item == 2)
                    {
                        if (decimal.TryParse(currentLine, out decimal parsedLine)) { floorMachines[machine].BaseMachinePrice = parsedLine; }
                    }
                    //machineStatus
                    if (item == 3)
                    {
                        floorMachines[machine].MachineStatus = currentLine;
                        currentLine = null;
                    }

                    item++; // move on to next item
                }
            }

            //close the file
            sr.Close();
        }
        public void outputPlaycards(List<PlayCard> customers)
        {
            string filePath = "";

            SaveFileDialog fileDiag = new SaveFileDialog();
            fileDiag.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fileDiag.FilterIndex = 1;
            DialogResult diagResult = fileDiag.ShowDialog();

            if (diagResult == DialogResult.OK)
            {
                filePath = fileDiag.FileName;
            }
            else
            {
                return;
            }

            using (StreamWriter pc = new StreamWriter(filePath))
            {
                pc.WriteLine(customers.Count());
                for (int i = 0; i < customers.Count(); i++)
                {
                    pc.WriteLine(customers[i].CardID);
                    pc.WriteLine(customers[i].MoneyOnCard);
                    pc.WriteLine(customers[i].CustomerName);
                    pc.WriteLine(customers[i].VIP);
                    pc.WriteLine(customers[i].IsActive);
                }
                pc.Flush();
            }
        }

        public void outputMachines(List<Machine> floorMachines)
        {
            string filePath = "";

            SaveFileDialog fileDiag = new SaveFileDialog();
            fileDiag.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fileDiag.FilterIndex = 1;
            DialogResult diagResult = fileDiag.ShowDialog();

            if (diagResult == DialogResult.OK)
            {
                filePath = fileDiag.FileName;
            }
            else
            {
                return;
            }

            using (StreamWriter mach = new StreamWriter(filePath))
            {
                for (int i = 0; i < floorMachines.Count(); i++)
                {
                    mach.WriteLine(floorMachines[i].MachineName);
                    mach.WriteLine(floorMachines[i].BaseMachinePrice);
                    mach.WriteLine(floorMachines[i].MachineStatus);
                }
                mach.Flush();
            }
        }
    }
}
