using System;
using System.ComponentModel;

public class Resume
{
    public string _owner;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_owner}");
        Console.WriteLine("Jobs: ");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}