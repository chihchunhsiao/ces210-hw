using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished."); 
        
        int number = -1;
        int sum = 0;
        int largest = -1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
                sum += number;

                if (number > largest)
                {
                    largest = number;
                }
            }

            if (number == 0)
            {
                break;
            }
            
        }

        Console.WriteLine($"The sum is: {sum}");
        int count = numbers.Count();
        float average = ((float)sum) / count;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
               
    }
}