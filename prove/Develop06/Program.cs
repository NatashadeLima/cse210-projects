
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("\n--- Eternal Quest Program ---");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Display Score");
            Console.WriteLine("7. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(goalManager);
                    break;

                case "2":
                    goalManager.ListGoals();
                    break;

                case "3":
                    SaveGoals(goalManager);
                    break;

                case "4":
                    LoadGoals(goalManager);
                    break;

                case "5":
                    RecordEvent(goalManager);
                    break;

                case "6":
                    goalManager.DisplayScore();
                    break;

                case "7":
                    Console.WriteLine("Exiting program. Goodbye!");
                    isRunning = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void CreateGoal(GoalManager goalManager)
    {
        Console.WriteLine("\n--- Create New Goal ---");
        Console.WriteLine("\nChoose Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        string type = Console.ReadLine();
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter points: ");
        int points;

        if (!int.TryParse(Console.ReadLine(), out points))
        {
            Console.WriteLine("Invalid input for points. Please enter a valid number.");
            return;
        }

        if (type == "3")
        {
            Console.Write("Enter target count: ");
            int targetCount;
            if (!int.TryParse(Console.ReadLine(), out targetCount))
            {
                Console.WriteLine("Invalid input for target count. Please enter a valid number.");
                return;
            }

            Console.Write("Enter bonus points: ");
            int bonus;
            if (!int.TryParse(Console.ReadLine(), out bonus))
            {
                Console.WriteLine("Invalid input for bonus points. Please enter a valid number.");
                return;
            }

            goalManager.CreateGoal(type, name, points, targetCount, bonus);
        }
        else if (type == "1" || type == "2")
        {
            goalManager.CreateGoal(type, name, points);
        }
        else
        {
            Console.WriteLine("Invalid goal type. Please try again.");
        }
    }

    static void SaveGoals(GoalManager goalManager)
    {
        Console.Write("\nEnter filename to save goals: ");
        string filename = Console.ReadLine();
        goalManager.SaveGoals(filename);
    }

    static void LoadGoals(GoalManager goalManager)
    {
        Console.Write("\nEnter filename to load goals: ");
        string filename = Console.ReadLine();
        goalManager.LoadGoals(filename);
    }

    static void RecordEvent(GoalManager goalManager)
    {
        Console.WriteLine("\n--- Record Event ---");
        goalManager.ListGoals();
        Console.Write("Enter the goal number to record an event: ");
        int goalIndex;

        if (!int.TryParse(Console.ReadLine(), out goalIndex))
        {
            Console.WriteLine("Invalid input for goal number. Please enter a valid number.");
            return;
        }

        goalManager.RecordEvent(goalIndex);
    }
}
