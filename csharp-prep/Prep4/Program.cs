using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int uNumber = -1;
        while (uNumber != 0) 
        {
            Console.Write("Entwr number: ");
            string userAnswer = Console.ReadLine();
            uNumber = int.Parse(userAnswer);

            if (uNumber != 0)
            {
                numbers.Add(uNumber);
            }

        }

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int maximum = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maximum)
            {
                maximum = number;
            }
        }
        
        Console.WriteLine($"The largest number is: {maximum}");

    }
}