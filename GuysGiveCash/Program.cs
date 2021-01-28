using System;

namespace GuysGiveCash
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Guy object in a variable called joe
            Guy joe = new Guy() { Cash = 50, Name = "Joe" };
            // Create a new Guy object in a variable called bob
            Guy bob = new Guy() { Cash = 100, Name = "Bob" };

            while (true)
            {
                // Call the WriteMyInfo methods for each Guy object
                joe.WriteMyInfo();
                bob.WriteMyInfo();
                Console.Write("Enter an amount: ");
                string howMuch = Console.ReadLine();
                if (howMuch == "") return;
                // Use int.TryParse to try to convert the howMuch string to an int
                if (int.TryParse(howMuch, out int amount))
                {
                    Console.Write("Who should give the cash: ");
                    string whichGuy = Console.ReadLine();
                    if (whichGuy == "Joe")
                    {
                        // Call the joe object's GiveCash method and save the results
                        int cashGiven = joe.GiveCash(amount);
                        // Call the bob object's ReceiveCash method with the saved results
                        bob.ReceiveCash(cashGiven);
                    }
                    else if (whichGuy == "Bob")
                    {
                        // Call the bob object's GiveCash method and save the results
                        int cashGiven = bob.GiveCash(amount);
                        // Call the joe object's ReceiveCash method with the saved results
                        joe.ReceiveCash(cashGiven);
                    }
                    else
                    {
                        Console.WriteLine("Please enter 'Joe' or 'Bob'");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an amount (or a blank line to exit).");
                }
            }
        }

    }
}