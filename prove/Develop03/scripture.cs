using System;
class Scripture
{
    private List<Verse> _verses = new List<Verse>();
    public List<Verse> Verses { get { return _verses; } }
    public Scripture(List<string> verses)
    {
        foreach (string verseStr in verses)
        {
            Verse verse = new Verse(verseStr);
            _verses.Add(verse);
        }
    }
    public int GetVerseCount()
    {
        int count = 0;
        foreach (Verse verse in _verses)
        {
            count += GetVerseCount();
        }
        return count;
    }
    public void Display()
    {
        Console.Clear();



        foreach (Verse verse in _verses)
        {
            verse.Display();
        }

    }
    public int GetWordsCount()
    {
        int count = 0;
        foreach (Verse verse in _verses)
        {
            count += verse.GetLength();
        }
        return count;
    }

}
