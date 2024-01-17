using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        Console.Write("What is your first name? ") ;
        string first = Console.ReadLine();

        Console.Write("What is your second name? ");
        string first_name = Console.ReadLine();

        Console.WriteLine($"Your name is (last_name), (first_name) (last_name).");
    }
}