using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromtUserNumber();
        int square = SquareNumber(userNumber);
        DisplayResult(userName, square);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");

    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }


    static int PromtUserNumber()
    {
        Console.Write("Please enter your number: ");
        string str = Console.ReadLine();
        int number = int.Parse(str);
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
    

}