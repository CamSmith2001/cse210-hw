using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class PromptGenerator
{
    public string _prompt;
    public List<string> _prompts = new List<string>
    {
        "What was the most interesting thing I did today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "How did I serve someone today?",
        "If I had one thing I could do over today, what would it be?",
        "What's one thing I did to be productive today?"
    };

    public string PickPrompt()
    {
        Random rnd = new Random();
        int rNum = rnd.Next(_prompts.Count);
        string _prompt = _prompts[rNum];

        return _prompt;
    }

}