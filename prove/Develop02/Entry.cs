using System;
using System.Xml.Linq;

public class Entry
{
    public string _date; 
    public string _promptText; 
    public string _entryText; 
    
    public Entry()//Initialize the three variables of the class Entry.
    {
       _date = "" ;

       _promptText = "" ;

       _entryText = "" ;

       Console.WriteLine("Save successfully");
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}\n{_entryText}");    
    }


}