using System;
using System.IO;

public class Journal
{
    public string _journalName = "";
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
           entry.Display();
        }
    }

    public void SaveJournal(List<Entry> _entries)
    {
        Console.WriteLine("Saving to file...");

        string filename = _journalName;

        using (StreamWriter outputFile = new StreamWriter(filename))
        { 
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}--{entry._moodResponse}--{entry._prompt}--{entry._response}");
            }
        }
    }

    public List<Entry> LoadJournal()
    {
        Console.WriteLine("Reading lines from file...");
        List<Entry> entries = new List<Entry>();
        string filename = _journalName;

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            // line will look like this: "Date--Mood--Prompt--Response"
            // Console.WriteLine(line);
            string[] parts = line.Split("--");

            // parts[0] - Date
            // parts[1] - Mood
            // parts[2] - Prompt
            // parts[3] - Response

            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._moodResponse = parts[1];
            newEntry._prompt = parts[2];
            newEntry._response = parts[3];

            entries.Add(newEntry);
        }

        return entries;
    }
}