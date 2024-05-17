public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        
    }

    public string GetName()
    {
        return _name;
    }
    
    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDesription()
    {
        return _description;
    }

    public void SetDesription(string description)
    {
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }
    
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        
        Console.WriteLine($"\nWelcome to the {_name} Activity.\n");
        Console.WriteLine($"This activity will help you {_description}.");
        Console.Write("\nHow long, in seconds, would you like for your session? ");

    }

    public void DisplayEndingMessage()
    {
        Activity activity = new Activity();
        Console.WriteLine("Well done!!");
        activity.ShowSpinner(8);
        
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.\n");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

       foreach (string s in animationStrings)
        {
            Console.Write(s); 
            Thread.Sleep(1000); 
            Console.Write("\b \b");
        }

    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i); 
            Thread.Sleep(1000); 
            
            Console.Write("\b \b");

        }

        Console.WriteLine("Done.");
    }
}