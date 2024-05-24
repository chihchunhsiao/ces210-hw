using System;
using System.IO;
// To exceed the requirements, the program will ask the user to set a milestone score,
// and display congratulations when the score exceeds the milestone score.
class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int menuChoice = 0;
        int score = 0;
        int typeNum = 0;
        int mileStone = 99999999;
        

        do
        {
            if (score > mileStone)
            {
                Console.WriteLine($"Congratulations! You have acchieved the milestone score \"{mileStone}\" ponits");
            }

            Console.WriteLine($"You have {score} points.\n");

            Console.WriteLine("Menu Optoins:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Set A Milestone\n  7. Quit");

            Console.Write("Select a choice from the menu: ");
           

            menuChoice = int.Parse(Console.ReadLine());

            if (menuChoice == 1)
            {
                               
                Console.Write("The types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal\nWhich type of goal would you like to creat? ");
                typeNum = int.Parse(Console.ReadLine());      
                if (typeNum == 1)
                {
                    Console.Write("What is the name of your goal? ");
                    string shortName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    string points = Console.ReadLine();
                    SimpleGoal simpleGoal = new SimpleGoal(shortName, description, points);
                    goals.Add(simpleGoal);
                }
                else if (typeNum == 2)
                {
                    Console.Write("What is the name of your goal? ");
                    string shortName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    string points = Console.ReadLine();
                    EternalGoal eternalGoal = new EternalGoal(shortName, description, points);
                    goals.Add(eternalGoal);
                }
                else if (typeNum == 3)
                {
                    Console.Write("What is the name of your goal? ");
                    string shortName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    string points = Console.ReadLine();
                    Console.Write("How many time does this goal need to be accomplished for a bonus? ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());
                    ChecklistGoal checklistGoal = new ChecklistGoal(shortName, description, points, target, bonus);
                    goals.Add(checklistGoal);
                }
                Console.WriteLine();

            }

            else if (menuChoice == 2)
            {
                int i = 1;
                
                foreach (Goal goal in goals)
                {    
                    if (goal.IsComplete())
                    {
                        Console.WriteLine($"{i}. [X] {goal.GetDetailsString()}");
                    }
                    
                    else
                    {
                        Console.WriteLine($"{i}. [ ] {goal.GetDetailsString()}");
                    }
                    
                    i++;
                }
                Console.WriteLine();
            }

            else if (menuChoice == 3)
            {
                Console.WriteLine("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine(score);
                    // You can add text to the file with the WriteLine method.
                    foreach (Goal goal in goals)
                    {
                        outputFile.WriteLine($"{goal}:{goal.GetStringRepresentation()}");
                    }
                }
                Console.WriteLine();
            }

            else if (menuChoice == 4)
            {
                /// Ask for the filename.
                Console.WriteLine("What is the filename? ");
                string fileName = Console.ReadLine();
                Console.WriteLine("Reading list from file ...");                
                string [] lines = File.ReadAllLines(fileName);

                score = int.Parse(lines[0]);

                for(int l = 0; l < lines.Length; l++)
                {
                    string[] parts = lines[l].Split(":");
                    if (parts[0] == "SimpleGoal")
                    {
                        
                        string[] items = parts[1].Split(",");
                        string sShortNeam = items[0];
                        string sDescription = items[1];
                        string sPoints = items[2];
                        string sIsComplete = items[3];

                        SimpleGoal s = new SimpleGoal(sShortNeam, sDescription, sPoints);
                        if (sIsComplete == "False")
                        {
                            s.SetIsComplete(false);
                        }

                        else if (sIsComplete == "True")
                        {
                            s.SetIsComplete(true);
                        }

                        goals.Add(s);

                        

                    }

                    else if (parts[0] == "EternalGoal")
                    {
                        string[] items = parts[1].Split(",");
                        string eShortNeam = items[0];
                        string eDescription = items[1];
                        string ePoints = items[2];

                        EternalGoal e = new EternalGoal(eShortNeam, eDescription, ePoints);

                        goals.Add(e);
                    }

                    else if (parts[0] == "ChecklistGoal")
                    {
                        string[] items = parts[1].Split(",");
                        string cShortNeam = items[0];
                        string cDescription = items[1];
                        string cPoints = items[2];
                        int cBonus = int.Parse(items[3]);
                        int cTarget = int.Parse(items[4]);
                        int cAmountComplete = int.Parse(items[5]);

                        ChecklistGoal c = new ChecklistGoal(cShortNeam, cDescription, cPoints, cTarget, cBonus);
                        c.SetAmountComplete(cAmountComplete);

                        goals.Add(c);
                    }

                }

                Console.WriteLine();
               
            }

            else if (menuChoice == 5)
            {
                Console.WriteLine("The goals are:");
                int k = 1;
                
                foreach (Goal goal in goals)
                {    
                    Console.WriteLine($"{k}. {goal.GetShortName()}");
                    k++;

                }

                Console.Write("Which goal did you accomplish? ");

                int setGoalNum = int.Parse(Console.ReadLine()) - 1;
                               
                goals[setGoalNum].RecordEvent();
                Console.WriteLine($"Congratulations! You have earned {goals[setGoalNum].GetPoints()}");
                score = score + int.Parse(goals[setGoalNum].GetPoints());
                Console.WriteLine($"You now have {score} points.");
                
                Console.WriteLine();
       
            }

            else if (menuChoice == 6)
            {
                Console.WriteLine("What score do you want to set as a Milestone score? ");
                mileStone = int.Parse(Console.ReadLine());

                Console.WriteLine();
            }

            else if (menuChoice == 7)
            {
                break;
            }

        } while(menuChoice != 7);
        
    }
        
   
}