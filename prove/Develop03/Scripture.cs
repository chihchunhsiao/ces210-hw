using System;
using System.Collections.Concurrent;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, List<Word> text)
    {
        _reference = reference;
        _words = new List<Word>(text);
      
    }

    public void HideRandomWords(int numberToHide, String text)
    {
        List<int> hideNum = new List<int>();
        List<int> showNum = new List<int>();
        List<string> newWords = new List<string>();
        Random rnd = new Random();
        string [] words = text.Split(' ');

        for (int j = 0; j < numberToHide; j++) 
        {
            int addHideNum = rnd.Next(0, _words.Count); 
                   
            hideNum.Add(addHideNum);
            showNum.Remove(addHideNum); 
                    
        }

        for (int k = 0; k < _words.Count; k++)
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
        }
    }
    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} {string.Join(" ", _words)}";
    }

    public bool IsCompletelyHidden(int numberToHide, List<Word>_words)
    {
        
        if (numberToHide > _words.Count)
        {
            return true;
        }
        
        else
        {
            return false;
        }
    }
}