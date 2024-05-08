using System;
using System.Collections.Generic;
using System.IO;

// To achieve to exceed the requirements, I will use a Dictionary for storaging entries.
class Program
{
    static void Main(string[] args)
    {
        // Initialize the Journal class as a new variable.
        Journal theJournal = new Journal();
               
        // Create a new List<string> variable and initialize it.
        List<string> prompts = new List<string>();
        
        // Add 5 prompts to the List<string> prompts.
        prompts.Add("Write about an event you'd like to remember today.");
        prompts.Add("List the top 5 goals you most want to acchieve and write down why.");
        prompts.Add("Write down the person you are most grateful for today and why.");
        prompts.Add("What did you do today that made you feel happy?");
        prompts.Add("How do you see God's hand guiding your life today?"); 

        Console.WriteLine("Welcom to the Journal Program!");

        // Set a int variable choice = 0.
        int choice = 0;

        // Use while loop to ask the user's choice and save the answer.
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
                       
            // Declare the variable choice = userInput and judge the condition.
            choice = userInput;
            
            if (choice == 1)
            {
                //Initialize the Entry class as a new variable. 
                Entry newEntry = new Entry();

                // Generate a random prompt to the user.
                var random = new Random();
                int i = random.Next(prompts.Count);
                Console.WriteLine(prompts[i]);

                // Save the user's entry into the newEntry.               
                newEntry._entryText = Console.ReadLine();
                
                // Save the time into the newEntry.
                DateTime theCurrentTime = DateTime.Now;               
                newEntry._date = theCurrentTime.ToShortDateString();

                // Save the prompt text into the newEntry.
                newEntry._promptText = prompts[i];
                             
                // Add three valuse of the class variable newEntry into the List<Entry> _entries of theJournal.
                theJournal._entries.Add(newEntry);  
                     

            }   
            else if (choice == 2)
            {   
                // Call the DisplayAll method to display all entries of the List<Entry> _entries. 
                theJournal.DisplayAll(theJournal._entries);

                
            } 

            else if (choice == 3)
            {   
               
                // Call a LoadFromFile method to Load the file.
                // Save the returned List to the List<Entry> _entries of theJournal.
                theJournal._entries = theJournal.LoadFromFile();              

            }
              
            else if (choice == 4)
            {   
                // Ask for the filename.
                Console.WriteLine("What is the filename? ");
                string fileName = Console.ReadLine();

                // Call a SaveToFile method to save the List<Entry> _entries to an external file.
                theJournal.SaveToFile(theJournal._entries,fileName);
                
            }   
        }
    }       
}