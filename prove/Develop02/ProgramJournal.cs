
using System;
using System.Collections.Generic;
using System.IO;

public class ProgramJournal
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool exit = false;

        while (!exit)
    {
        Console.WriteLine($"Welcome to the Journal Program!");
        Console.WriteLine($"Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        Console.Write("What would you like to do? ");

        string choice = Console.ReadLine();
            
            if (choice == "1")
            {
                journal.WriteNewEntry();
            }
            else if (choice == "2")
            {
                DisplayJournal.Display(journal.Entries);
            }
            else if (choice == "3")
            {
                journal.Entries = LoadJournal.Load();
            }
            else if (choice == "4")
            {
                SaveJournal.Save(journal.Entries);
            }
            else if (choice == "5")
            {
                exit = true;
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }

        }

    }

}

