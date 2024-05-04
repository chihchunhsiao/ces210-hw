using System;
using System.Collections.Generic;
using System.IO;

// To achieve to exceed the requirements, I will use a Dictionary for storaging entries.
class Program
{
    static void Main(string[] args)
    {

        Journal theJournal = new Journal();
        // List<string> saveEntries = new List<string>();
        List<Entry> entries = new List<Entry>();

        // PromptGenerator myPrompts = new PromptGenerator();
       
        List<string> prompts = new List<string>();
        
        prompts.Add("Write about an event you'd like to remember today.");
        prompts.Add("List the top 5 goals you most want to acchieve and write down why.");
        prompts.Add("Write down the person you are most grateful for today and why.");
        prompts.Add("What did you do today that made you feel happy?");
        prompts.Add("How do you see God's hand guiding your life today?"); 

        Console.WriteLine("Welcom to the Journal Program!");

        int choice = 0;

        while(choice < 5)
        {                      
            Console.WriteLine("Please select one of the following Choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. quit");
            Console.Write("What would you like to do? ");
            int userInput = int.Parse(Console.ReadLine());
                       
            // Console.WriteLine(userInput);
            choice = userInput;
            
            if (choice == 1)
            {
                Entry newEntry = new Entry();

                // Generate random prompt to the user.
                var random = new Random();
                int i = random.Next(prompts.Count);
                Console.WriteLine(prompts[i]);

                // Save the user's entry.
                string entry = Console.ReadLine();
                newEntry._entryText = entry;
                // Save the time.
                DateTime theCurrentTime = DateTime.Now;
                string date = theCurrentTime.ToShortDateString();
                newEntry._date = date;
                string prompt = prompts[i];
                newEntry._promptText = prompt;
                
                theJournal._entries.Add(newEntry);
                // theJournal._entries = List<Entry> entries;                           

            }   
            else if (choice == 2)
            {   
                theJournal.DisplayAll();

                // for (int i =0; i < saveEntries.Count; i++) 
                //     {
                //         Console.WriteLine(saveEntries[i]);
                //     }
            }   
            else if (choice == 3)
            {   
                Journal j = new Journal();
                /// Ask for the filename.
                Console.WriteLine("What is the filename? ");
                string fileName = Console.ReadLine();

                // theJournal.LoadFromFile(fileName);
               

            }
              
            else if (choice == 4)
            {   
                // Ask for the filename.
                Console.WriteLine("What is the filename? ");
                string fileName = Console.ReadLine();

                // theJournal.SaveToFile(entries,fileName);

                
            }   
        }
    }       
}