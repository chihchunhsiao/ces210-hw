public class BreathingActivity : Activity
{   
    public BreathingActivity() :base ()
    {

    }

    
    public void Run()
    {
    
        BreathingActivity b = new BreathingActivity();

        Console.Write("\nBreathe in...");
        b.ShowCountDown(4);

        Console.Write("Now breathe out...");
        b.ShowCountDown(6);

    }
}