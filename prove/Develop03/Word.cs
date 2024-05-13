using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word()
    {
        _text = "";

        _isHidden = true;
    }

    public void SetText (string text)
    {
        _text = text;
    }

    public string GetText()
    {
        return _text;
    }


    public string [] GetWordsArray()
    {
        string [] words = _text.Split(' ');

        return words;
    }
    

    public string Hide(string word)
    {
        char[] chars = word.ToCharArray();
        
        for (int j = 0; j < chars.Length; j++)
        {
                    
            chars[j] = '_';
            
            chars.SetValue('_', j);
        }
            
        return string.Join(null, chars);   
    }

    public string Show(string word)
    {
        return word;
    }

    public bool IsHidden()
    { 
        return true;
    }

    public string GetDisplayText()
    {
        Word word = new Word();
        string [] words = _text.Split(' ');
        
        for (int i = 0; i < words.Length; i++)
        {
            
            if (_isHidden)
            {
                words[i] = word.Hide(words[i]);
            }
            else
            {
                words[i] = word.Show(words[i]);
            }
        }
        _text = string.Join(" ", words);
        return _text;  
    }
}

