using System;

public class Entry
{
    public string _date; 
    public string _promptText; 
    public string _entryText; 
    
    public Entry()
    {
       Console.WriteLine("Created successfully");
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}\n{_entryText}");    
    }

}