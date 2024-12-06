public abstract class Activity
{
    public string Name { get; protected set; }
    public string Description { get; protected set; }
    public int Duration { get; protected set; }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting: {Name}");
        Console.WriteLine(Description);
        Console.Write("Enter the duration of the activity (in seconds): ");
        Duration = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You completed the {Name} for {Duration} seconds.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b-");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b\\");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b|");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b");
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            System.Threading.Thread.Sleep(1000);
        }
    }

    public abstract void Run();
}
