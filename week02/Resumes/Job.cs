using System;
public class Job
{
    public string _company;
    public string _jobTitle;

    public int _startYear;

    public int _endYear;  // this is a new C# convention//

    // THIS IS THE CONSTRUCTOR //
    public Job()
    {

    }

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} {_company} {_startYear} {_endYear}");
    }

}


