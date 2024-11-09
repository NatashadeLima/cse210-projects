using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your grade percentage: ");
        int gradepercentage = int.Parse(Console.ReadLine());

        string letter = "";

        if (gradepercentage >= 90)
        {
            letter = "A";
        }
        else if (gradepercentage >= 80)
        {
            letter = "B";
        }
        else if (gradepercentage >= 70)
        {
            letter = "C";
        }
        else if (gradepercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        if (gradepercentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass the course. Better luck next time!");
        }
    }
}
