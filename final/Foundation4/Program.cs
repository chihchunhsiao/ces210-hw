using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("03 Jan 2024", 30, 4.8);
        Cycling cycling = new Cycling("20 Feb 2024", 45, 25);
        Swimming swimming = new Swimming("14 Jun 2024", 30, 24);

        List<Activity> activities = new List<Activity>();
        activities.Add(running); 
        activities.Add(cycling);
        activities.Add(swimming);

        Console.WriteLine("Summary of activities:");

        for (int i = 0; i < activities.Count(); i ++)
        {            
            Console.WriteLine(activities[i].GetSummary(activities[i]));
        }
       
    }
}