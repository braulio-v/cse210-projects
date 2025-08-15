using System;
using System.Collections.Generic;
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many thing as you can in a certain area.";
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people you have helped this week?",
            "Who are some of your personal heroes?"
        };
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }
        return items;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Prompt: " + GetRandomPrompt());
        Console.WriteLine("You may begin in:");
        ShowCountDown(3);

        var list = GetListFromUser();
        _count = list.Count;

        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }
}
