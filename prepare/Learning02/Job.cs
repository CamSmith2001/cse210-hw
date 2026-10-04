using System;

// A class that carries and displays job details. 
public class Job
{
    // Members variables used are the company name, job title, 
    // the year you started, and the year you ended your job.
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // A method to display the job details in a uniform format. For example:
    // "Software Engineer (Microsoft) 2001-2026"
    public void DisplayJob()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}