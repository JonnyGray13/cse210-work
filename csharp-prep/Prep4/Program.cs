using System;

class Program
{
    static void Main(string[] args)
    {
        int inputNum = -1;
        List<int> numbers = new List<int>();
        
        while (inputNum != 0)
        {
            Console.Write("Type a number (or type 0 to quit): ");
            string reply = Console.ReadLine();
            inputNum = int.Parse(reply);

            if (inputNum !=0)
            {
                numbers.Add(inputNum);
            }
        }
        int total = 0;

        foreach (int number in numbers)
        {
            total += number;
        }
        Console.WriteLine($"The sum of the numbers is {total}");

        int listMax = numbers[0];
        foreach (int number in numbers)
        {
            if (number > listMax)
            {
                listMax = number;
            }
        }
        Console.WriteLine($"The maximum is: {listMax}");
    }
}