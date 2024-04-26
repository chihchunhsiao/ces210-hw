using System;
using System.Formats.Asn1;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
         
        // // Ask the user for the magic number. 
        // Console.Write("What is the magic number? ");      
        // int magic = int.Parse(Console.ReadLine());

        // Use a random number as the magic number.
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 100);
        // Console.WriteLine(magic);

        int guess = -1;
              
        do
        {           
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magic > guess)                         
            {             
                Console.WriteLine("Higher"); 
            }
                
            else if (magic < guess)
            {
                Console.WriteLine("Lower"); 
            }   

            else 
            {
                Console.WriteLine("You guessed it!"); 
            }           
        
        } while (guess != magic );
        
    }
}