using System;

class Program
{
    static void Main()
    {
        // Call the functions
        DisplayWelcome();
        string username = PromptUserName();
        int usernumber = PromptUserNumber();
        int squarednumber = SquareNumber(usernumber);
        DisplayResult(username, squarednumber);
    }

    // Function to display a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function to prompt the user for their name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function to prompt the user for their favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Function to square a number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display the result
    static void DisplayResult(string name, int squarednumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squarednumber}");
    }
}
