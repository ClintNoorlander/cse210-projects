class Word
{
    public string _text = "";
    public bool _hidden = false;
    public Word(String text)
    {
        _text = text;
    }

    public string Text
    {
        get { return _text; }
        set { _text = value; }
    }

    public void Display()
    {
        if (_hidden)
        {
            foreach(char c in _text)
            {
                Console.Write('_');
            }
        }
        else
        {
            Console.Write(_text);
        }
    }
    public bool IsHidden()
    {
        return _hidden;
    }
}
