

using System;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> Entries { get; set; } = new List<Entry>();

    private static List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is one thing I learned today?",
        "How did I make someone’s day better?",
        "What am I grateful for today?",
        "What challenge did I overcome today?",
        "What was a small joy I experienced today?"
    };

    public void WriteNewEntry()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];

        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        Entries.Add(new Entry(prompt, response));
        Console.WriteLine("Entry saved!");
    }


}
