using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage.
        
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        float grade = float.Parse(userInput);
       
        string letter = "";

        // Set the conditions to determine grade levels.
        if (grade >= 90) 
        {
            letter = "A";
        }
        
        else if (grade >= 80)
        {
            letter = "B";
        }
        
        else if (grade >= 70)
        {
            letter = "C";
        }
        
        else if (grade >= 60)
        {
            letter = "D";
        }
        
        else
        {
            letter = "F";
        }

        string sign = "";
        float newGrade = grade % 10;

        if (newGrade >= 7 && letter != "A" && letter !="F")
        {
            sign = "+";
        }
        
        else if (newGrade < 3 && letter !="F")
        {
            sign = "-";
        }
        
        else 
        {
            sign = "";
        }
               
        Console.WriteLine($"Your grade is: {letter}{sign}");
        
        // Determine whether the student passed the course.
        // The user must have at least a 70 to pass the class.

        if (grade >= 70)
        {
            Console.WriteLine("Congratulation! You passed the course.");
        }
             
        else
        {
            Console.WriteLine("You did not pass the course. Please try your best next time.");
        } 
          
    }
}