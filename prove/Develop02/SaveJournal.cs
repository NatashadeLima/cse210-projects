

using System;
using System.IO;
using System.Collections.Generic;

public class SaveJournal
{
    public static void Save(List<Entry> journal)
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in journal)
            {
                writer.WriteLine(entry.Date);
                writer.WriteLine(entry.Prompt);
                writer.WriteLine(entry.Response);
                writer.WriteLine("------");
            }
        }

        Console.WriteLine("Journal saved successfully!");
    }
}
