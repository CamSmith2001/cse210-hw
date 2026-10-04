using System;

// A class that holds the name of a person as well as a list
// of their jobs made from instances of the Job class.
public class Resume
{
    // Member variables for the name of the person on the resume
    // and the list of their jobs.
    public string _name;
    
    // Make sure to initialize lists when you first declare(make) them. As shown here.
    public List<Job> _jobs = new List<Job>();

    // A method to display the person's name and iterate through their list of jobs.
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.DisplayJob();
        }
    }

    
}