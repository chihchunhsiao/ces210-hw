public class ListingActivity : Activity
{   
    private int _count;
    private List<string> _prompts; 
    public ListingActivity() :base ()
    {
        _prompts = new List<string>();

        _count = 0; 

    }


    public void Run()
    {
        ListingActivity l = new ListingActivity();
        Console.Write($"List as many responses you can to the following prompt:\n --- ");
        l.GetRandomPrompt();
        Console.WriteLine(" ---");
        Console.WriteLine("You may begin in: ");
        
        l.ShowCountDown(5);

        string userInput = Console.ReadLine();
        l.GetListFromUser(userInput);

        Console.WriteLine($"You listed {l._count} items");

    }

    public void GetRandomPrompt()
    {
        ListingActivity l = new ListingActivity();

        // Add prompts to the List<string> _prompts.
        l._prompts.Add("Who are people that you appreciate?");
        l._prompts.Add("What are personal strengths of yours?");
        l._prompts.Add("Who are people that you have helped this week?");
        l._prompts.Add("When have you felt the Holy Ghost this month?"); 
        l._prompts.Add("Who are some of your personal heroes?");
        // Generate a random prompt to the user.
        var random = new Random();
        int i = random.Next(l._prompts.Count);

        Console.Write(l._prompts[i]);

    }

    public List<string> GetListFromUser(string userInput)
    {
        List<string> userList = new List<string>();

        while (userInput.Length > 0)
        {
            userList.Add(userInput);

            userInput = Console.ReadLine();
        }

        _count = userList.Count();

        return userList;
    }




}
