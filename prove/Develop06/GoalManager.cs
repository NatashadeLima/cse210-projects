using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class GoalManager
{
    private List<Goal> goals;
    private int totalPoints;

    public GoalManager()
    {
        goals = new List<Goal>();
        totalPoints = 0;
    }

    public void CreateGoal(string type, string name, int points, int targetCount = 0, int bonus = 0)
    {
        Goal goal = type switch
        {
            "1" => new SimpleGoal(name, points),
            "2" => new EternalGoal(name, points),
            "3" => new ChecklistGoal(name, points, targetCount, 0, bonus),
            _ => throw new ArgumentException("Invalid goal type")
        };

        goals.Add(goal);
    }

    public void ListGoals()
    {
        Console.WriteLine("Goals:");
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetDetails()}");
        }
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex < 1 || goalIndex > goals.Count)
        {
            Console.WriteLine("Invalid goal index.");
            return;
        }

        Goal selectedGoal = goals[goalIndex - 1];
        int earnedPoints = selectedGoal.RecordEvent();

        if (earnedPoints > 0)
        {
            totalPoints += earnedPoints;
            Console.WriteLine($"You earned {earnedPoints} points! Total points: {totalPoints}");
        }
        else
        {
            Console.WriteLine("No points earned. Goal may already be completed.");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total Points: {totalPoints}");
    }

    public void SaveGoals(string filename)
    {
        try
        {
            using StreamWriter writer = new StreamWriter(filename);
            writer.WriteLine(totalPoints); // Save total points
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.Serialize());
            }
            Console.WriteLine("Goals saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    public void LoadGoals(string filename)
    {
        try
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("File does not exist.");
                return;
            }

            using StreamReader reader = new StreamReader(filename);
            totalPoints = int.Parse(reader.ReadLine()); // Load total points
            goals.Clear();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Goal goal = Goal.Deserialize(line);
                if (goal != null)
                {
                    goals.Add(goal);
                }
            }

            Console.WriteLine("Goals loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }
}
