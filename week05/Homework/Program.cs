using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment homework = new Assignment("Samuel Bennett", "Multiplication");

        Console.WriteLine(homework.GetSummary());


        MathAssignment homework1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(homework1.GetSummary());
        Console.WriteLine(homework1.GetHomeworkList());

        WritingAssignment homework2 = new WritingAssignment("Mary Water", "European History", "The Causes of World War II");
        Console.WriteLine(homework2.GetSummary());
        Console.WriteLine(homework2.GetWritingInformation());

    }
}