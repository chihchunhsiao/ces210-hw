public class ReflectingActivity : Activity
{   
    private List<string> _prompts;
    private List<string> _questions; 
    public ReflectingActivity() :base ()
    {
        _prompts = new List<string>();

        _questions = new List<string>(); 
    }


    public void Run()
    {
        ReflectingActivity r = new ReflectingActivity();

        Console.WriteLine($"Consider the following prompt:\n --- {r.GetRandomPrompt()} ---");
        Console.Write("When you have something in mind, press enter to continue.");

        string userInput = Console.ReadLine();
        if (userInput == "")
        {
            Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            r.ShowCountDown(5);

            r.DisplayQuestions();
            r.ShowSpinner(8);

            r.DisplayQuestions();
            r.ShowSpinner(8);

        }

    }

    public string GetRandomPrompt()
    {
        ReflectingActivity r = new ReflectingActivity();

        // Add prompts to the List<string> _prompts.
        r._prompts.Add("Think of a time when you stood up for someone else.");
        r._prompts.Add("Think of a time when you did something really difficult.");
        r._prompts.Add("Think of a time when you helped someone in need.");
        r._prompts.Add("Think of a time when you did something truly selfless."); 
        // Generate a random prompt to the user.
        var random = new Random();
        int i = random.Next(r._prompts.Count);

        return r._prompts[i];
    }

    public string GetRandomQuestion()
    {
        ReflectingActivity r = new ReflectingActivity();

        // Add questions to the List<string> _questions.
        r._questions.Add("Why was this experience meaningful to you?");
        r._questions.Add("Have you ever done anything like this before?");
        r._questions.Add("How did you get started?");
        r._questions.Add("How did you feel when it was complete?"); 
        r._questions.Add("What made this time different than other times when you were not as successful?");
        r._questions.Add("What is your favorite thing about this experience?");
        r._questions.Add("What could you learn from this experience that applies to other situations?");
        r._questions.Add("How can you keep this experience in mind in the future?"); 

        // Generate a random prompt to the user.
        var random = new Random();
        int i = random.Next(r._questions.Count);

        return r._questions[i];
        
    }


    public void DisplayPrompt()
    {
        ReflectingActivity r = new ReflectingActivity();
        
        Console.WriteLine(r.GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        ReflectingActivity r = new ReflectingActivity();
        Console.WriteLine(r.GetRandomQuestion());
    }

}