public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        Name = "Breathing Activity";
        Description = "This activity will help you relax by walking you through breathing in and out slowly.";
    }

    public override void Run()
    {
        DisplayStartingMessage();

        int elapsed = 0;
        while (elapsed < Duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            elapsed += 4;

            Console.WriteLine("Breathe out...");
            ShowCountDown(4);
            elapsed += 4;
        }

        DisplayEndingMessage();
    }
}
