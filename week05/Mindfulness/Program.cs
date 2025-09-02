using System;
// I added "Keeping a log of how many times activities were performed"
class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nSelect a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                new BreathingActivity().Run();
                breathingCount++;
            }
            else if (choice == "2")
            {
                new ReflectingActivity().Run();
                reflectingCount++;
            }
            else if (choice == "3")
            {
                new ListingActivity().Run();
                listingCount++;
            }
            else if (choice == "4")
            {
                Console.Clear();
                Console.WriteLine("Session Summary:");
                Console.WriteLine($"- Breathing Activity: {breathingCount} times");
                Console.WriteLine($"- Reflecting Activity: {reflectingCount} times");
                Console.WriteLine($"- Listing Activity: {listingCount} times");
                Console.WriteLine("\nThanks for using the program!");
                break;
            }
        }

    }
}