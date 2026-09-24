using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!!");

        // IF statements in C# are formatted like this
        // if (x > y)
        // {
        //     Console.WriteLine("Greater");
        // }

        // This is how to use variables in C#
        // string school = "BYU-Idaho";
        // Console.WriteLine($"I am studying at {school}");

        // else and else if statements
        // if (x > y)
        // {
        //     Console.WriteLine("Greater than");
        // }
        // else
        // {
        //     Console.WriteLine("Less than");
        // }

        // if (x > y)
        // {
        //     Console.WriteLine("Greater than y");
        // }
        // else if (x > z)
        // {
        //     Console.WriteLine("Greater than z");
        // }
        // else
        // {
        //     Console.WriteLine("Less than both");
        // }

        // Operators
        // if (name == "John");
        // {
        //     Console.WriteLine("The name is John");
        // }

        // if (color != favoriteColor)
        // {
        //     Console.WriteLine("That color is not my favorite");
        // }

        //And, Or, and Not operators
        // if (name == "Peter" || name == "James" || name == "John")
        // {
        //     Console.WriteLine("This is a biblical name.");
        // }

        // if (firstName == "Brigham" && lastName == "Young")
        // {
        //     Console.WriteLine("Welcome Brother Brigham!");
        // }

        // if (!(name == "Peter" || name == "James" || name == "John"))
        // {
        //     Console.WriteLine("This is not one of those three");
        // }

        // Variables and Types
        // Use "camel case" meaning that the first word in a variable name starts with a lower case letter
        // and every word after that is capitalized.

        // For example:
        // string color;
        // string firstName;
        // string lastName;
        // int velocityBeforeImpactWasMade;

        // Converting Types
        // As mentioned before, in C#, all variables must have their data type defined when the variable is first declared. Once defined, variables cannot change type, so you 
        // cannot set a variable to an integer first and later reassign it to a string.
        // You can, however convert a the value of a variable to a different type. For example, you can create an integer from the digits stored in a string using the 
        // int.Parse() function.

        // string valueInText = "42";
        // int number = int.Parse(valueInText);

        // This is especially important if the value comes from the user via a Console.ReadLine() statement, which always returns a string:

        // Console.Write("What is your favorite number?" );
        // string userInput = Console.ReadLine():
        // int number = int.Parse(userInput);

        // Numbers to Strings
        // An integer can converted into a string using .ToString()

        // int number = 42;
        // string textVersion = number.ToString();

        // While Loops in C#

        // string response = "yes";

        // while (response == "yes")
        // {
        //     Console.Write("Do you want to continue? ");
        //     response = Console.ReadLine();
        // }

        // Do-While Loops in C#

        // string response;

        // do
        // {
        //     Console.Write("Do you want to continue? ");
        //     response = Console.ReadLine();
        // } while (response == "yes");

        // For Loops

        // The standard for loop in C# is more like a "for x in range" loop in Python. The
        // condition has three parts, separated by semi-colons. The first initializes the
        // value, the second is the condition to check, the third is an increment step that
        // is run at the end of each loop.

        // The following code shows the syntax of a for loop that counts from 0 to 9.

        // for (int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // In that code, you will see the use of the ++ operator which increments the value
        // in the variable by one.

        // Another example. The code will count from 2 to 20 by two's.

        // for (int i = 2; i <= 20; i = i + 2)
        // {
        //     Console.WriteLine(i);
        // }

        // Foreach Loops

        // C# contains a foreach loop that is similar to a standard for loop in Python. It is important
        // to remember that the iterator variable must have its type defined, just like when declaring 
        // any other variable:

        // foreach (string color in colors)
        // {
        //     Console.WriteLine(color);
        // }

        // Random Numbers

        // In addition, for this assignment you'll need to get a random number from the computer. In
        // C#, this is done by creating an instance of the Random class, and then using it to get the
        // next integer in the particular range.

        // Random randomGenerator = new Random();
        // int number = randomGenerator.Next(1, 11);

        // Lists

        // To create a new list of integers, you specify int inside angle brackets <> directly following
        // the name of the data structure: List<int> and if you want to have a list of strings, you
        //  would use: List<string> as shown below.

        // List<int> numbers;
        // List<string> words;

        // The code above declares a variable to hold the list, but before you can use one, you need to
        // create a new one to use with the new keyword.

        // List<int> numbers;
        // numbers = new List<int>();

        // This is typically done on the same line:

        // List<int> numbers = new List<int>();
        // List<string> words = new List<string>();

        // One more important thing to be aware of: Any file that uses Lists (or any other
        // standard collection), must refer to that library at the top of the file. (This is so common
        // that sometimes your settings for C# can be specified so that you do not not have include
        // this, but it is important to know about it, in case you run into problems.)

        // using System.Collections.Generic;

        // Adding Items to the List

        // using System.Collections.Generic;

        // List<string> words = new List<string>;

        // words.Add("phone");
        // words.Add("keyboard");
        // words.Add("mouse");

        // Getting the list size

        // Console.WriteLine(words.Count);

        // Iterating through a list
        // The easiest (and safest) way to iterate through a list in C# is to use the foreach loop:

        // foreach (string word in words)
        // {
        //     Console.WriteLine(word);
        // }

        // You can also access the items by their index:

        // for (int i = 0; i < words.count; i++)
        // {
        //     Console.WriteLine(words[i]);
        // }

        // Console.WriteLine("Hello Prep4 World!");

        // List<int> numbers = new List<int>();

        // Console.WriteLine("Enter a list of numbers, then type 0 when finished.");
        // int number = -1;


        // while (number != 0)
        // {
        //     Console.Write("Enter Number: ");
        //     number = int.Parse(Console.ReadLine());
        //     numbers.Add(number);
        // }

        // int sum = 0;
        // foreach (int lNumber in numbers)
        // {
        //     Console.WriteLine(lNumber);
        //     sum += lNumber;
        // }

        // Console.WriteLine(sum);



        
    }
}