using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the User for their name.
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}