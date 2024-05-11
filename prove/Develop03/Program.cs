using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {    
        
        Reference newReference = new Reference("Proverbs", 3, 5, 6);

        string wordText = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        
        // Scripture newScripture = new Scripture(newReference, wordText);
             
        string [] words = wordText.Split(' ');

        // Word newWord = new Word("Trust in the Lord with all thine heart");

        // newWord.GetDisplayText();                 
       
        Console.WriteLine($"{newReference.GetDisplayText()} {string.Join(" ", words)}");  


        Console.WriteLine("\nPress <Enter> to continue or type 'quit' to finish: ");

        string userInput = Console.ReadLine();

        int numberToHide = 3;

        while (userInput != "quit" && numberToHide < words.Length)
        {           
            List<int> hideNum = new List<int>();
            List<int> showNum = new List<int>();
            List<string> newWords = new List<string>();

            for(int l = 0; l < words.Length; l++)
                {
                    showNum.Add(l);
                }

            if (hideNum.Count != words.Length)
            {
            
                Random rnd = new Random();
                for (int j = 0; j < numberToHide; j++) 
                {
                    int addHideNum = rnd.Next(0, words.Length); 
                   
                    hideNum.Add(addHideNum);
                    showNum.Remove(addHideNum); 
                    
                }
                
                
            
                for (int k = 0; k < words.Length; k++)
                {
                    if (hideNum.Contains(k))
                    {
                        char[] chars = words[k].ToCharArray();
                        // Console.WriteLine(word);
                        for (int i = 0; i < chars.Length; i++)
                        {
                            // Console.WriteLine(chars[i]);
                            chars[i] = '_';
                            // Console.WriteLine(chars[i]);
                            chars.SetValue('_', i);
                        }   
                        // Console.WriteLine(chars);
                        string wordNew = string.Join(null, chars);
                        newWords.Add(wordNew);
                    }
                    else
                    {
                        newWords.Add(words[k]);
                    }
                    // Console.Clear();     
                    
                }
                Console.WriteLine($"{newReference.GetDisplayText()} {string.Join(" ", newWords)}");
                Console.WriteLine("Press enter to continue or type 'quit to finish: ");
                userInput = Console.ReadLine();
                numberToHide += 3;
            }
            
            
        }  
    }
}
