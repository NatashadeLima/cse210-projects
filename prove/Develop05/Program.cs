using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectionActivity(),
                "3" => new ListingActivity(),
                "4" => null,
                _ => null
            };

            if (activity == null)
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            activity.Run();
        }
    }
}
