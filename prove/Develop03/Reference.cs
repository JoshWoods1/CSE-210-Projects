public class Reference
{
    private string _book;
    int _chapter;
    int _firstVerse;
    int _lastVerse;

    public Reference(string book, int chapter, int firstVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = -1;
    }
    public Reference(string book, int chapter, int firstVerse, int lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }
    
    public void Display()
    { 
        if (_lastVerse != -1)
        {
        Console.WriteLine($"{_book} {_chapter}:{_firstVerse}-{_lastVerse}");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter}:{_firstVerse}");
        }
    }
}