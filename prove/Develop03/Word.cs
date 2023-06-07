public class Word 
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;

    }
    
    public void HideWord()
    {
        _isHidden = true;
    }

    public void ShowWord()
    {
        _isHidden = false;
    }

    public void Display()
    {
        if (_isHidden == true)
        {
            for (int i = 0; i < _word.Count(); i++)
        {
            Console.Write("_");
        }
        Console.Write(" ");
        }
        else {
            Console.Write($"{_word} ");
        }
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }
    
}