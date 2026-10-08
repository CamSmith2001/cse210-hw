using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        

        PromptGenerator prompt = new PromptGenerator();
        string promptString = prompt.ToString();
        
        Entry entry = new Entry();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();


        entry._date = dateText;
        entry._prompt = "What was the best part of my day?";
        entry._response = "I got to see my wife!";
        entry._moodResponse = "Happy";
        entry.Display();
    }

    // public void MenuMaker()
    // {
    //     string option1 = "1. Write";
    //     string option2 = "2. Display";
    //     string option3 = "3. Load";
    //     string option4 = "4. Save";
    //     string option5 = "5. Quit";


    // }
}