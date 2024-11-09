using System;

class Program
{
    static void Main()
    {
        bool playagain = true;

        while (playagain)
        {
            Random random = new Random();
            int magicnumber = random.Next(1, 101);

            int guess = -1;
            int guesscount = 0;

            Console.WriteLine("I have picked a magic number between 1 and 100. Try to guess it!");

            while (guess != magicnumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guesscount++;

                if (guess < magicnumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicnumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guesscount} guesses.");
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();

            if (response != "yes")
            {
                playagain = false;
            }
        }

        Console.WriteLine("Thanks for playing! Goodbye!");
    }
}

