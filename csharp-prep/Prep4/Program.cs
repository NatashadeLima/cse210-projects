using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int input;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            
            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);

        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        int smallestpositive = numbers.Where(n => n > 0).DefaultIfEmpty(int.MaxValue).Min();
        List<int> sortednumbers = new List<int>(numbers);
        sortednumbers.Sort();

        Console.WriteLine($"The smallest positive number is: {smallestpositive}");
        Console.WriteLine("The sorted list is:");
        foreach (int number in sortednumbers)
        {
            Console.WriteLine(number);
        }
    }
}
