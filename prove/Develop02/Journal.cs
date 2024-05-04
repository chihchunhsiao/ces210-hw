using System;
using System.Collections.Generic;
using System.IO;



public class Journal
{
    public List<Entry> _entries = new List<Entry>();
      

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);    
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            // This calls the Display method on each entry.
            entry.Display();
        }

    }


    public static List<Entry> LoadFromFile()
    {
        /// Ask for the filename.
        Console.WriteLine("What is the filename? ");
        string fileName = Console.ReadLine();
        Console.WriteLine("Reading list from file ...");
        List<Entry> newEntries = new List<Entry>();
        string [] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");
            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2]; 
            newEntries.Add(newEntry);
        }

        return newEntries;
 
    }

    public void SaveToFile(List<Entry> _entries, string fileName)
    {
        Console.WriteLine("Saving to file...");
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method.
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~{entry._promptText}~{entry._entryText}");
            }

        }                 

    }
}