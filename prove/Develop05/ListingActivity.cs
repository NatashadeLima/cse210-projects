public class ListingActivity : Activity
{
    private static readonly string[] Prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        Name = "Listing Activity";
        Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();
        string prompt = Prompts[random.Next(Prompts.Length)];
        Console.WriteLine($"Prompt: {prompt}");
        ShowCountDown(5);

        Console.WriteLine("Start listing:");
        DateTime startTime = DateTime.Now;
        int count = 0;

        while ((DateTime.Now - startTime).TotalSeconds < Duration)
        {
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items.");
        DisplayEndingMessage();
    }
}
