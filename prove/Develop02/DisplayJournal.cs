


using System;
using System.Collections.Generic;

public class DisplayJournal
{
    public static void Display(List<Entry> journal)
    {
        Console.WriteLine("\nJournal Entries:");

        if (journal.Count == 0)
        {
            Console.WriteLine("No entries to display.");
        }
        else
        {
            foreach (var entry in journal)
            {
                Console.WriteLine(entry.ToString());
                Console.WriteLine("------");
            }
        }
    }
}
