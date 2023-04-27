using System;

class Program
{
    static void Main(string[] args)
    {
        //string again = "yes";

        int guess = -1;

        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 101);

        while (guess != magicNum)
        {
            Console.Write("Guess the magic number (1-100): ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else if (guess == magicNum)
            {
                Console.WriteLine("You guessed it!");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
            //Console.Write("Would you like to try again (yes or no)? ");
            //again = Console.ReadLine();



        }
        
    }
}