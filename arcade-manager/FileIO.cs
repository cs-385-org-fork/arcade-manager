using System;
using System.Collections.Generic;
using System.Text;

namespace arcade_manager {
    internal class FileIO {

        public void readCustomers() {
            if (File.Exists("Customers.txt")) {
                StreamReader sr = new StreamReader("Customers.txt");
                string currentLine = sr.ReadLine();
                //First line is amount of customers with active cards
                if (int.TryParse(currentLine, out int activeCards)) { }
                else {
                    return;
                }
                //Create an array of the length of active cards

                //Read the remaining lines and assign them to new playcard
                int item = 1;
                while (currentLine != null) {
                    //Read the next line
                    currentLine = sr.ReadLine();
                    //ID Number
                    if (item == 1) {
                        if (int.TryParse(currentLine, out int parsedLine)) {.cardID = parsedLine; }
                    }
                    //Money On Card
                    if (item == 2) {
                        if (decimal.TryParse(currentLine, out int parsedLine)) {.moneyOnCard = parsedLine; }
                    }
                    //customerName
                    if (item == 3) {
                        if (decimal.TryParse(currentLine, out int parsedLine)) {.customerName = currentLine; }
                    }
                    //VIP
                    if (item == 4) {
                        if (decimal.TryParse(currentLine, out int parsedLine)) { }
                    }

                    item++;
                }
                //close the file
                sr.Close();
            }
            else { Console.WriteLine("No customer text file."); }
        }

    }
}
