using System;
using System.IO;

// To exceed the requirements, the program will display the number of times of the Mindfulness Activity has been completed.

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity();
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();

        Console.WriteLine("Welcome to the Mindfulness Activity!\n");

        int userChoice = 0;
        int numberMindfulnessActivity = 0;
        do
        {
            
            Console.WriteLine("Menu Optoins:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu:");           
            userChoice = int.Parse(Console.ReadLine());
            Console.Clear();

            if (userChoice == 1)
            {
                breathingActivity.SetName("Breathing");
                breathingActivity.SetDesription("relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
                breathingActivity.DisplayStartingMessage();                
               
                int breathingDuration = int.Parse(Console.ReadLine());
                breathingActivity.SetDuration(breathingDuration);
                

                Console.WriteLine("Get ready...");
                breathingActivity.ShowSpinner(8);

                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(breathingActivity.GetDuration());
                while (DateTime.Now < endTime)
                {
                    breathingActivity.Run();
                }

                breathingActivity.DisplayEndingMessage();
               
            } 

            
            else if (userChoice == 2)
            {
                reflectingActivity.SetName("Reflecting");
                reflectingActivity.SetDesription("reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life");
                reflectingActivity.DisplayStartingMessage();                
               
                int reflectingDuration = int.Parse(Console.ReadLine());
                reflectingActivity.SetDuration(reflectingDuration);
                
                Console.WriteLine("Get ready...");
                reflectingActivity.ShowSpinner(8);
                
                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(reflectingActivity.GetDuration());
                while (DateTime.Now < endTime)
                {
                    reflectingActivity.Run();
                }

                reflectingActivity.DisplayEndingMessage();
                
            }

            else if (userChoice == 3)
            {
                listingActivity.SetName("Listing");
                listingActivity.SetDesription("reflect on the good things in your life by having you list as many things as you can in a certain area");
                listingActivity.DisplayStartingMessage();                
               
                int listingDuration = int.Parse(Console.ReadLine());
                listingActivity.SetDuration(listingDuration);
                
                Console.WriteLine("Get ready...");
                listingActivity.ShowSpinner(8);
                
                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(listingActivity.GetDuration());
                while (DateTime.Now < endTime)
                {
                    listingActivity.Run();
                }

                listingActivity.DisplayEndingMessage();
            }

            else if (userChoice == 4)
            {
                break;
            }

            numberMindfulnessActivity ++;

        }while (userChoice != 4);

        Console.WriteLine($"You have completed  Mindful Activity {numberMindfulnessActivity} time(s).");
   
    }
}