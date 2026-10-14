using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Collections.Generic;

// I added a question asking about the user's current mood and a response variable to exceed requirements.

class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Journal journal = new Journal();

        int choice = 0;

        Console.WriteLine("Choose an option from the menu");

        while (choice != 5)
        {
            Entry newEntry = new Entry();

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                PromptGenerator newPrompt = new PromptGenerator();
                
                newEntry._prompt = newPrompt.PickPrompt();

                newEntry._date = dateText;
                Console.WriteLine("What is your current mood? ");
                newEntry._moodResponse = Console.ReadLine();
                Console.WriteLine(newEntry._prompt);
                newEntry._response = Console.ReadLine();
                
                journal.AddEntry(newEntry);
            }
            else if (choice == 2)
            {
                journal.DisplayEntries();
            }
            else if (choice == 3)
            {
                Console.WriteLine("What is the name of the file? ");
                journal._journalName = Console.ReadLine();
                journal.SaveJournal(journal._entries);
            }
            else if (choice == 4)
            {
                Console.WriteLine("What is the name of the file? ");
                journal._journalName = Console.ReadLine();
                journal._entries = journal.LoadJournal();
            }
            else if (choice == 5)
            {
                Console.WriteLine("Have a good day!");
            }


        }
    }
}