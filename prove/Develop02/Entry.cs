using System;

public class Entry
{
    public string _date;
    public string _moodResponse;
    public string _response;
    public string _prompt;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} Mood: {_moodResponse} - Prompt: {_prompt}");
        Console.WriteLine($"{_response}");
    }



}