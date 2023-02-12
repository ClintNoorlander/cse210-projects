using System;
using System.Collections.Generic;

class Verse
{
    private List<Word> _words = new List<Word>();
    public List<Word> Words { get { return _words; } }
    public Verse(string verse)
    {
        string currentWord = "";
        foreach (char c in verse)
        {
            if (c == ' ' || c == ',' || c == '.' || c == ':' || c == '\t')
            {
                if (currentWord != "")
                {
                    Word word = new Word(currentWord);
                    _words.Add(word);
                    currentWord = "";
                }
                Word delimiter = new Word(c.ToString());
                _words.Add(delimiter);
            }
            else
            {
                currentWord += c;
            }
        }
        if (currentWord != "")
        {
            Word word = new Word(currentWord);
            _words.Add(word);
        }
    }
    public int GetLength()
    {
        return _words.Count;
    }
    public int HiddenWordsCount()
    {
        int count = 0;
        foreach (Word word in this.Words)
        {
            if (word.IsHidden())
            {
                count++;
            }
        }
        return count;
    }
    public void Display()
    {
        foreach(Word word in _words)
        {
            word.Display();
        }
        System.Console.WriteLine();
    }
}
