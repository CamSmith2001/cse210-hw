using System;
using System.Drawing;
using System.Runtime.CompilerServices;
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





        
    }
}