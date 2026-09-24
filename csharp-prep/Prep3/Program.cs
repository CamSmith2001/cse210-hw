using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int mNumber = randomGenerator.Next(1, 100);
        
        int guess = -1;

        while (guess != mNumber)
        {
            
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            

            if (guess < mNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > mNumber)
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