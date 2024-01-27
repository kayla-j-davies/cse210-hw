using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write($"What is your graded percentage? ");
        string answer = Console.ReadLine();
        int percentage = int.Parse(answer);

        string grade = "";

        if (percentage >= 90)
        {
            grade = "A";
        }
        else if (percentage >= 80)
        {
            grade = "B";
        }
        else if (percentage >= 70)
        {
            grade = "C";
        }
        else if (percentage >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is: {grade}");

        if (percentage >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else 
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}