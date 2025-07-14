using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int> { 18, 22, 88, 89 };

        Console.WriteLine(numbers.Count);
        Console.WriteLine(string.Join(",", numbers));
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }




        List<string> words = new List<string>();
        words.Add("jaja");
        words.Add("hola");
        words.Add("arroz");

        Console.WriteLine(words.Count);
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }






        List<int> numbe = new List<int>();

        int i = -1;
        int Suma = 0;
        int amount = 0;
        float average = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (i != 0)
        {
            Console.Write("Enter a number ");
            string user = Console.ReadLine();
            i = int.Parse(user);


            if (i != 0)
            {
                numbe.Add(i);
                Suma = i + Suma;
                amount += 1;
                average = ((float)Suma) / amount;

            }
        }
        Console.WriteLine($"The sum: {Suma}");
        Console.WriteLine($"The average is: {average}");

        int max = numbe[0];

        foreach (int num in numbe)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The max is: {max}");

        List<int> robot = new List<int> { 4, 3, 78, 5, 6 };
        int maximo = robot.Max();
        Console.WriteLine("El numero mayor es:" + maximo);

    }
}