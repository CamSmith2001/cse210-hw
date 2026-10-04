using System;
using System.Diagnostics.CodeAnalysis;
using System.Formats.Asn1;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, then type 0 when finished.");
        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter Number: ");
            number = int.Parse(Console.ReadLine());
            
            if (number != 0)
            {
                numbers.Add(number);    
            }
            
        }

        int sum = 0;
        int highest = numbers[0];
        foreach (int lNumber in numbers)
        {
            sum += lNumber;

            if (lNumber > highest)
            {
                highest = lNumber;
            }
        }

        float ave = ((float)sum) / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {ave}");
        Console.WriteLine($"The largest number is: {highest}");

        
    }
}
