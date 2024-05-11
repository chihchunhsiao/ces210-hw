using System;

public class Word
{
    private string _text;
    // private bool _isHidden;

        public Word(string text)
    {
        _text = text;

        // _isHidden = true;

    }

    public void Hide(string word)
    {
        char[] chars = word.ToCharArray();
        
        for (int j = 0; j < chars.Length; j++)
        {
                    
            chars[j] = '_';
            
            chars.SetValue('_', j);
        }
            
        Console.WriteLine(string.Join(null, chars));   
    }

    public void Show(string word)
    {
        Console.WriteLine(word);
    }

    public bool IsHidden()
    { 
        return true;
    }

    public string GetDisplayText()
    {
        string [] words = _text.Split(' ');
        
        for (int i = 0; i < words.Length; i++)
        {
            // if (Word.IsHidden())
            // {
            //     Word.Hide();
            // }
            // else
            // {
            //     Word.Show();
            // }
        }
        _text = string.Join(" ", words);
        return _text;  
    }
}

