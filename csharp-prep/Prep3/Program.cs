using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int mNumber = randomGenerator.Next(1,101);

//        Console.Write("What is the magic number? ");
//        string answer = Console.ReadLine();
//        int mNumber = int.Parse(answer);
//
        int gNumber = -1;

        while (gNumber != mNumber)
        {
            Console.Write("What is your guess? ");
            gNumber = int.Parse(Console.ReadLine());

            if (mNumber > gNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (mNumber < gNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }
         

        

    }
}