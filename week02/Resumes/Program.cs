using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");


        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "(Microsoft)";
        job1._startYear = 2022;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Software Junior";
        job2._company = "(Apple)";
        job2._startYear = 2022;
        job2._endYear = 2024;

        job1.Display();
        job2.Display();

        Resume myResume = new Resume();

        myResume._owner = "Braulio Villa";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();




    }
}




