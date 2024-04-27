using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
            
        string userName = PromptUserName();
        int number = PromptUserNumber();

        int squareNumber = SquareNumber(number);
            
        DisplayResult(userName, squareNumber);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");           
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
            
        return number;           
    }

    static int SquareNumber(int number)
    {
        int squareNumber = number * number;

        return squareNumber;
    }

    static void DisplayResult(string userName, int squareNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
    }

}