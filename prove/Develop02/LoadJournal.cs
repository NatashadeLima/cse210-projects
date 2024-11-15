

using System;
using System.Collections.Generic;
using System.IO;

public class LoadJournal
{
    public static List<Entry> Load()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        List<Entry> journal = new List<Entry>();

        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    string dateLine = reader.ReadLine();
                    string promptLine = reader.ReadLine();
                    string responseLine = reader.ReadLine();
                    reader.ReadLine();

                    journal.Add(new Entry(promptLine, responseLine) { Date = dateLine });
                }
            }

            Console.WriteLine("Journal loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }

        return journal;
    }
}
