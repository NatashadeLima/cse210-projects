
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        string fileName = "goals.txt";

        while (true)
        {
            Console.WriteLine("\nEternal Quest Program");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal(goalManager);
                    break;

                case "2":
                    goalManager.DisplayGoals();
                    break;

                case "3":
                    goalManager.SaveGoals(fileName);
                    Console.WriteLine("Goals saved.");
                    break;

                case "4":
                    goalManager.LoadGoals(fileName);
                    Console.WriteLine("Goals loaded.");
                    break;

                case "5":
                    RecordEvent(goalManager);
                    break;

                case "6":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void CreateNewGoal(GoalManager goalManager)
    {
        Console.WriteLine("\nChoose Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("Enter the points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                goalManager.AddGoal(new SimpleGoal(name, points));
                break;

            case "2":
                goalManager.AddGoal(new EternalGoal(name, points));
                break;

            case "3":
                Console.Write("Enter the target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                goalManager.AddGoal(new ChecklistGoal(name, points, target, 0, bonus));
                break;

            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    static void RecordEvent(GoalManager goalManager)
    {
        Console.Write("Enter the goal name to record progress: ");
        string goalName = Console.ReadLine();
        goalManager.RecordEvent(goalName);
    }
}
